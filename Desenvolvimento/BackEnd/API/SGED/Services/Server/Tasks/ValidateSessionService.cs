﻿using SGED.Context;
using SGED.DTO.Entities;
using SGED.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SGED.Helpers;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json.Linq;
using SGED.Services.Server.Filter;

namespace SGED.Services.Server.Tasks

{
    public class ValidateSessionService
    {
        private readonly RequestDelegate _next;
        private readonly IServiceProvider _serviceProvider;

        public ValidateSessionService(RequestDelegate next, IServiceProvider serviceProvider)
        {
            _next = next;
            _serviceProvider = serviceProvider;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            using var scope = _serviceProvider.CreateScope();
            var _sessaoRepository = scope.ServiceProvider.GetRequiredService<ISessaoRepository>();
            var _usuarioRepository = scope.ServiceProvider.GetRequiredService<IUsuarioRepository>();

            string requestBody;
            using (var reader = new StreamReader(context.Request.Body))
            {
                requestBody = await reader.ReadToEndAsync();
            }

            // Analisa o JSON
            var jsonObject = JObject.Parse(requestBody);

            // Obtém o valor do campo "object"
            var session = jsonObject["session"];

            if (session != null)
            {
                // Converte o objeto JSON em uma string
                var sessionString = session.ToString();

                // Desserializa a string para o tipo DataSession
                var dataSession = JsonConvert.DeserializeObject<DataSession>(sessionString);

                var sessao = await _sessaoRepository.GetById(dataSession.Id);

                if (sessao is null)
                {
                    // Sessão não encontrada
                    var responseJson = "{\"error\": \"Sessão não encontrada!\"}";
                    await context.Response.WriteAsync(responseJson);
                    return;
                }

                else if (!sessao.StatusSessao || !SessaoDTO.ValidateToken(sessao.TokenSessao, sessao.Usuario.EmailPessoa))
                {
                    // Sessão inválida
                    sessao.TokenSessao = "";
                    sessao.StatusSessao = false;
                    sessao.DataHoraEncerramento = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    await _sessaoRepository.Update(sessao);

                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    context.Response.ContentType = "application/json";
                    var responseJson = "{\"error\": \"Sessão inválida!\"}";
                    await context.Response.WriteAsync(responseJson);
                    return;
                }

                // Atualiza o token da sessão
                sessao.TokenSessao = SessaoDTO.GenerateToken(sessao.Usuario.EmailPessoa);
                await _sessaoRepository.Update(sessao);

                context.Items.Remove("Session");
                context.Items["User"] = sessao.Usuario;
                await _next(context);
            }
            else
            {
                // Sessão não informada
                var responseJson = "{\"error\": \"Sessão não informada!\"}";
                await context.Response.WriteAsync(responseJson);
                return;
            }
        }
    }
}

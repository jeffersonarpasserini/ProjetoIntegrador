﻿using SGED.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Authorization;
using SGED.Objects.DTO.Entities;
using SGED.Objects.Utilities;
using SGED.Services.Entities;

namespace SGED.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class TipoUsuarioController : Controller
	{

		private readonly ITipoUsuarioService _tipoUsuarioService;
		private readonly Response _response;

		public TipoUsuarioController(ITipoUsuarioService tipoUsuarioService)
		{
			_tipoUsuarioService = tipoUsuarioService;

			_response = new Response();
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<TipoUsuarioDTO>>> Get()
		{
			try
			{
				var tipoUsuariosDTO = await _tipoUsuarioService.GetAll();
				_response.SetSuccess(); _response.Data = tipoUsuariosDTO;
				_response.Message = tipoUsuariosDTO.Any() ?
					"Lista do(s) Tipo(s) de Usuário obtida com sucesso." :
					"Nenhum Tipo de Usuário encontrado.";
				return Ok(_response);
			}
			catch (Exception ex)
			{
				_response.SetError(); _response.Message = "Não foi possível excluir o TipoUsuario!"; _response.Data = new { ErrorMessage = ex.Message, StackTrace = ex.StackTrace ?? "No stack trace available!" };
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}

		[HttpGet("{id}", Name = "GetTipoUsuario")]
		public async Task<ActionResult<TipoUsuarioDTO>> Get(int id)
		{
			try
			{
				var tipoUsuarioDTO = await _tipoUsuarioService.GetById(id);
				if (tipoUsuarioDTO == null)
				{
					_response.SetNotFound(); _response.Message = "Tipo de Usuário não encontrado!"; _response.Data = tipoUsuarioDTO;
					return NotFound(_response);
				};

				_response.SetSuccess(); _response.Message = "Tipo de Usuário " + tipoUsuarioDTO.NomeTipoUsuario + " obtido com sucesso."; _response.Data = tipoUsuarioDTO;
				return Ok(_response);
			}
			catch (Exception ex)
			{
				_response.SetError(); _response.Message = "Não foi possível excluir o TipoUsuario!"; _response.Data = new { ErrorMessage = ex.Message, StackTrace = ex.StackTrace ?? "No stack trace available!" };
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}

		[HttpPost]
		public async Task<ActionResult> Post([FromBody] TipoUsuarioDTO tipoUsuarioDTO)
		{
			if (tipoUsuarioDTO == null)
			{
				_response.SetInvalid(); _response.Message = "Dado(s) inválido(s)!"; _response.Data = tipoUsuarioDTO;
				return BadRequest(_response);
			}

			try
			{
				if (await TipoUsuarioExists(tipoUsuarioDTO))
				{
					_response.SetConflict(); _response.Message = "Já existe o Tipo Usuário " + tipoUsuarioDTO.NomeTipoUsuario + "!"; _response.Data = tipoUsuarioDTO;
					return BadRequest(_response);
				}

				await _tipoUsuarioService.Create(tipoUsuarioDTO);

				_response.SetSuccess(); _response.Message = "Tipo de Usuário " + tipoUsuarioDTO.NomeTipoUsuario + " cadastrado com sucesso."; _response.Data = tipoUsuarioDTO;
				return Ok(_response);
			}
			catch (Exception ex)
			{
				_response.SetError(); _response.Message = "Não foi possível excluir o TipoUsuario!"; _response.Data = new { ErrorMessage = ex.Message, StackTrace = ex.StackTrace ?? "No stack trace available!" };
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}

		[HttpPut()]
		public async Task<ActionResult> Put([FromBody] TipoUsuarioDTO tipoUsuarioDTO)
		{
			if (tipoUsuarioDTO == null)
			{
				_response.SetInvalid(); _response.Message = "Dado(s) inválido(s)!"; _response.Data = tipoUsuarioDTO;
				return BadRequest(_response);
			}

			try
			{
				var existingTipoUsuario = await _tipoUsuarioService.GetById(tipoUsuarioDTO.Id);
				if (existingTipoUsuario == null)
				{
					_response.SetNotFound(); _response.Message = "O Tipo de Usuário informado não existe!"; _response.Data = tipoUsuarioDTO;
					return NotFound(_response);
				}

				if (await TipoUsuarioExists(tipoUsuarioDTO))
				{
					_response.SetConflict(); _response.Message = "Já existe o Tipo Usuário " + tipoUsuarioDTO.NomeTipoUsuario + "!"; _response.Data = tipoUsuarioDTO;
					return BadRequest(_response);
				}

				await _tipoUsuarioService.Update(tipoUsuarioDTO);

				_response.SetSuccess(); _response.Message = "Tipo de Usuário " + tipoUsuarioDTO.NomeTipoUsuario + " alterado com sucesso."; _response.Data = tipoUsuarioDTO;
				return Ok(_response);
			}
			catch (Exception ex)
			{
				_response.SetError(); _response.Message = "Não foi possível excluir o TipoUsuario!"; _response.Data = new { ErrorMessage = ex.Message, StackTrace = ex.StackTrace ?? "No stack trace available!" };
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<TipoUsuarioDTO>> Delete(int id)
		{
			try
			{
				var tipoUsuarioDTO = await _tipoUsuarioService.GetById(id);
				if (tipoUsuarioDTO == null)
				{
					_response.SetNotFound(); _response.Message = "Tipo de Usuário não encontrado!"; _response.Data = tipoUsuarioDTO;
					return NotFound(_response);
				}

				await _tipoUsuarioService.Remove(id);

				_response.SetSuccess(); _response.Message = "Tipo de Usuário " + tipoUsuarioDTO.NomeTipoUsuario + " excluído com sucesso."; _response.Data = tipoUsuarioDTO;
				return Ok(_response);
			}
			catch (Exception ex)
			{
				_response.SetError(); _response.Message = "Não foi possível excluir o TipoUsuario!"; _response.Data = new { ErrorMessage = ex.Message, StackTrace = ex.StackTrace ?? "No stack trace available!" };
				return StatusCode(StatusCodes.Status500InternalServerError, _response);
			}
		}

		private async Task<bool> TipoUsuarioExists(TipoUsuarioDTO tipoUsuarioDTO)
		{
			var tipoUsuariosDTO = await _tipoUsuarioService.GetAll();
			return tipoUsuariosDTO.FirstOrDefault(tu => Operator.CompareString(tu.NomeTipoUsuario, tipoUsuarioDTO.NomeTipoUsuario)) is not null;
		}
	}
}
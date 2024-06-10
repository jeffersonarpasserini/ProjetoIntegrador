﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SGED.Migrations
{
    /// <inheritdoc />
    public partial class database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "engenheiro",
                columns: table => new
                {
                    idengenheiro = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imagempessoa = table.Column<string>(type: "text", nullable: false),
                    nomepessoa = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    emailpessoa = table.Column<string>(type: "text", nullable: false),
                    telefonepessoa = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    cpfcnpjpessoa = table.Column<string>(type: "character varying(18)", maxLength: 18, nullable: false),
                    rgiepessoa = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    creaengenheiro = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_engenheiro", x => x.idengenheiro);
                });

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    idestado = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomeestado = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ufestado = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado", x => x.idestado);
                });

            migrationBuilder.CreateTable(
                name: "fiscal",
                columns: table => new
                {
                    idfiscal = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imagempessoa = table.Column<string>(type: "text", nullable: false),
                    nomepessoa = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    emailpessoa = table.Column<string>(type: "text", nullable: false),
                    telefonepessoa = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    cpfcnpjpessoa = table.Column<string>(type: "character varying(18)", maxLength: 18, nullable: false),
                    rgiepessoa = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fiscal", x => x.idfiscal);
                });

            migrationBuilder.CreateTable(
                name: "municipe",
                columns: table => new
                {
                    idmunicipe = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imagempessoa = table.Column<string>(type: "text", nullable: false),
                    nomepessoa = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    emailpessoa = table.Column<string>(type: "text", nullable: false),
                    telefonepessoa = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    cpfcnpjpessoa = table.Column<string>(type: "character varying(18)", maxLength: 18, nullable: false),
                    rgiepessoa = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipe", x => x.idmunicipe);
                });

            migrationBuilder.CreateTable(
                name: "ocupacaoatual",
                columns: table => new
                {
                    idocupacaoatual = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomeocupacaoatual = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    descricaoocupacaoatual = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ocupacaoatual", x => x.idocupacaoatual);
                });

            migrationBuilder.CreateTable(
                name: "tipodocumento",
                columns: table => new
                {
                    idTipoDocumento = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomeTipoDocumento = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    descricaoTipoDocumento = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: false),
                    statustipoprocesso = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipodocumento", x => x.idTipoDocumento);
                });

            migrationBuilder.CreateTable(
                name: "tipoinfraestrutura",
                columns: table => new
                {
                    idtipoinfraestrutura = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nometipoinfraestrutura = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    descricaotipoinfraestrutura = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoinfraestrutura", x => x.idtipoinfraestrutura);
                });

            migrationBuilder.CreateTable(
                name: "tipologradouro",
                columns: table => new
                {
                    idtipologradouro = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigoinformativo = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    descricaotipologradouro = table.Column<string>(type: "character varying(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipologradouro", x => x.idtipologradouro);
                });

            migrationBuilder.CreateTable(
                name: "tipoprocesso",
                columns: table => new
                {
                    idtipoprocesso = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipoprocesso = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    descricaotipoprocesso = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    statustipoprocesso = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoprocesso", x => x.idtipoprocesso);
                });

            migrationBuilder.CreateTable(
                name: "tipouso",
                columns: table => new
                {
                    iduso = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomeuso = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    descricaouso = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipouso", x => x.iduso);
                });

            migrationBuilder.CreateTable(
                name: "tipousuario",
                columns: table => new
                {
                    idtipousuario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nivelacesso = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    nometipousuario = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    descricaotipousuario = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipousuario", x => x.idtipousuario);
                });

            migrationBuilder.CreateTable(
                name: "topografia",
                columns: table => new
                {
                    idtopografia = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nometopografia = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topografia", x => x.idtopografia);
                });

            migrationBuilder.CreateTable(
                name: "cidade",
                columns: table => new
                {
                    idcidade = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomecidade = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IdEstado = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cidade", x => x.idcidade);
                    table.ForeignKey(
                        name: "FK_cidade_estado_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "estado",
                        principalColumn: "idestado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "infraestrutura",
                columns: table => new
                {
                    idinfraestrutura = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomeinfraestrutura = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    IdTipoInfraestrutura = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infraestrutura", x => x.idinfraestrutura);
                    table.ForeignKey(
                        name: "FK_infraestrutura_tipoinfraestrutura_IdTipoInfraestrutura",
                        column: x => x.IdTipoInfraestrutura,
                        principalTable: "tipoinfraestrutura",
                        principalColumn: "idtipoinfraestrutura",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etapa",
                columns: table => new
                {
                    idetapa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomeetapa = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    descricaoetapa = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    posicaoetapa = table.Column<int>(type: "integer", nullable: false),
                    statusetapa = table.Column<int>(type: "integer", nullable: false),
                    IdTipoProcesso = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etapa", x => x.idetapa);
                    table.ForeignKey(
                        name: "FK_etapa_tipoprocesso_IdTipoProcesso",
                        column: x => x.IdTipoProcesso,
                        principalTable: "tipoprocesso",
                        principalColumn: "idtipoprocesso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    idusuario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imagempessoa = table.Column<string>(type: "text", nullable: false),
                    nomepessoa = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    emailpessoa = table.Column<string>(type: "text", nullable: false),
                    telefonepessoa = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    cpfcnpjpessoa = table.Column<string>(type: "character varying(18)", maxLength: 18, nullable: false),
                    rgiepessoa = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    senhausuario = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    cargousuario = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    statususuario = table.Column<bool>(type: "boolean", nullable: false),
                    IdTipoUsuario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.idusuario);
                    table.ForeignKey(
                        name: "FK_usuario_tipousuario_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "tipousuario",
                        principalColumn: "idtipousuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bairro",
                columns: table => new
                {
                    idbairro = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomebairro = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    IdCidade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairro", x => x.idbairro);
                    table.ForeignKey(
                        name: "FK_bairro_cidade_IdCidade",
                        column: x => x.IdCidade,
                        principalTable: "cidade",
                        principalColumn: "idcidade",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tipodocumentoetapa",
                columns: table => new
                {
                    idtipodocumentoetapa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    posicaotipodocumentoetapa = table.Column<int>(type: "integer", nullable: false),
                    statustipodocumentoetapa = table.Column<int>(type: "integer", nullable: false),
                    IdTipoDocumento = table.Column<int>(type: "integer", nullable: false),
                    IdEtapa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipodocumentoetapa", x => x.idtipodocumentoetapa);
                    table.ForeignKey(
                        name: "FK_tipodocumentoetapa_etapa_IdEtapa",
                        column: x => x.IdEtapa,
                        principalTable: "etapa",
                        principalColumn: "idetapa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tipodocumentoetapa_tipodocumento_IdTipoDocumento",
                        column: x => x.IdTipoDocumento,
                        principalTable: "tipodocumento",
                        principalColumn: "idTipoDocumento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sessao",
                columns: table => new
                {
                    idsessao = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datahoraabertura = table.Column<string>(type: "text", nullable: false),
                    datahorafechamento = table.Column<string>(type: "text", nullable: true),
                    tokensessao = table.Column<string>(type: "text", nullable: false),
                    statussessao = table.Column<bool>(type: "boolean", nullable: false),
                    emailpessoa = table.Column<string>(type: "text", nullable: false),
                    nivelacesso = table.Column<string>(type: "text", nullable: false),
                    IdUsuario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sessao", x => x.idsessao);
                    table.ForeignKey(
                        name: "FK_sessao_usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "usuario",
                        principalColumn: "idusuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "logradouro",
                columns: table => new
                {
                    idlogradouro = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ceplogradouro = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: false),
                    numeroInicial = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    numeroFinal = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    IdBairro = table.Column<int>(type: "integer", nullable: false),
                    IdTipoLogradouro = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logradouro", x => x.idlogradouro);
                    table.ForeignKey(
                        name: "FK_logradouro_bairro_IdBairro",
                        column: x => x.IdBairro,
                        principalTable: "bairro",
                        principalColumn: "idbairro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_logradouro_tipologradouro_IdTipoLogradouro",
                        column: x => x.IdTipoLogradouro,
                        principalTable: "tipologradouro",
                        principalColumn: "idtipologradouro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "imovel",
                columns: table => new
                {
                    idimovel = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imagemimovel = table.Column<string>(type: "text", nullable: true),
                    inscricaocadastral = table.Column<string>(type: "text", nullable: false),
                    cepimovel = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: false),
                    numeroimovel = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    areaterreno = table.Column<float>(type: "real", nullable: false),
                    areacomstruida = table.Column<float>(type: "real", nullable: false),
                    condicoessolo = table.Column<string>(type: "text", nullable: false),
                    valorvenal = table.Column<float>(type: "real", nullable: false),
                    valormercado = table.Column<float>(type: "real", nullable: false),
                    localizacaogeografica = table.Column<string>(type: "text", nullable: true),
                    IdLogradouro = table.Column<int>(type: "integer", nullable: false),
                    IdProprietario = table.Column<int>(type: "integer", nullable: false),
                    IdContribuinte = table.Column<int>(type: "integer", nullable: false),
                    IdTopografia = table.Column<int>(type: "integer", nullable: false),
                    IdUso = table.Column<int>(type: "integer", nullable: false),
                    IdOcupacaoAtual = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imovel", x => x.idimovel);
                    table.ForeignKey(
                        name: "FK_imovel_logradouro_IdLogradouro",
                        column: x => x.IdLogradouro,
                        principalTable: "logradouro",
                        principalColumn: "idlogradouro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_imovel_municipe_IdContribuinte",
                        column: x => x.IdContribuinte,
                        principalTable: "municipe",
                        principalColumn: "idmunicipe",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_imovel_municipe_IdProprietario",
                        column: x => x.IdProprietario,
                        principalTable: "municipe",
                        principalColumn: "idmunicipe",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_imovel_ocupacaoatual_IdOcupacaoAtual",
                        column: x => x.IdOcupacaoAtual,
                        principalTable: "ocupacaoatual",
                        principalColumn: "idocupacaoatual",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_imovel_tipouso_IdUso",
                        column: x => x.IdUso,
                        principalTable: "tipouso",
                        principalColumn: "iduso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_imovel_topografia_IdTopografia",
                        column: x => x.IdTopografia,
                        principalTable: "topografia",
                        principalColumn: "idtopografia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "instalacao",
                columns: table => new
                {
                    idinstalacao = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datainstalacao = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    situacaoinstalacao = table.Column<string>(type: "text", nullable: false),
                    IdInfraestrutura = table.Column<int>(type: "integer", nullable: false),
                    IdImovel = table.Column<int>(type: "integer", nullable: false),
                    IdEngenheiro = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instalacao", x => x.idinstalacao);
                    table.ForeignKey(
                        name: "FK_instalacao_engenheiro_IdEngenheiro",
                        column: x => x.IdEngenheiro,
                        principalTable: "engenheiro",
                        principalColumn: "idengenheiro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_instalacao_imovel_IdImovel",
                        column: x => x.IdImovel,
                        principalTable: "imovel",
                        principalColumn: "idimovel",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_instalacao_infraestrutura_IdInfraestrutura",
                        column: x => x.IdInfraestrutura,
                        principalTable: "infraestrutura",
                        principalColumn: "idinfraestrutura",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "estado",
                columns: new[] { "idestado", "nomeestado", "ufestado" },
                values: new object[,]
                {
                    { 1, "São Paulo", "SP" },
                    { 2, "Alagoas", "AL" },
                    { 3, "Amapá", "AP" },
                    { 4, "Amazonas", "AM" },
                    { 5, "Bahia", "BA" },
                    { 6, "Ceará", "CE" },
                    { 7, "Distrito Federal", "DF" },
                    { 8, "Espírito Santo", "ES" },
                    { 9, "Goiás", "GO" },
                    { 10, "Maranhão", "MA" },
                    { 11, "Mato Grosso", "MT" },
                    { 12, "Mato Grosso do Sul", "MS" },
                    { 13, "Minas Gerais", "MG" },
                    { 14, "Pará", "PA" },
                    { 15, "Paraíba", "PB" },
                    { 16, "Paraná", "PR" },
                    { 17, "Pernambuco", "PE" },
                    { 18, "Piauí", "PI" },
                    { 19, "Rio de Janeiro", "RJ" },
                    { 20, "Rio Grande do Norte", "RN" },
                    { 21, "Rio Grande do Sul", "RS" },
                    { 22, "Rondônia", "RO" },
                    { 23, "Roraima", "RR" },
                    { 24, "Santa Catarina", "SC" },
                    { 25, "Acre", "AC" },
                    { 26, "Sergipe", "SE" },
                    { 27, "Tocantins", "TO" }
                });

            migrationBuilder.InsertData(
                table: "ocupacaoatual",
                columns: new[] { "idocupacaoatual", "descricaoocupacaoatual", "nomeocupacaoatual" },
                values: new object[,]
                {
                    { 1, "Terreno sem construções.", "Não Edificada" },
                    { 2, "Terreno com construções.", "Edificada" },
                    { 3, "Terreno com obras em andamento.", "Em Construção" },
                    { 4, "Terreno com construções, mas sem uso.", "Desocupada" },
                    { 5, "Terreno com construções e em uso.", "Ocupada" }
                });

            migrationBuilder.InsertData(
                table: "tipoinfraestrutura",
                columns: new[] { "idtipoinfraestrutura", "descricaotipoinfraestrutura", "nometipoinfraestrutura" },
                values: new object[,]
                {
                    { 1, "Infraestrutura para tratamento e fornecimento de água potável, coleta e tratamento de esgoto.", "Saneamento Básico" },
                    { 2, "Infraestrutura que garante acesso facilitado para pessoas com mobilidade reduzida.", "Acessibilidade" },
                    { 3, "Infraestrutura para fornecimento de energia elétrica ao imóvel.", "Energia Elétrica" },
                    { 4, "Infraestrutura de pavimentação de ruas e calçadas.", "Pavimentação" },
                    { 5, "Infraestrutura para fornecimento de serviços de internet e telecomunicações.", "Internet" }
                });

            migrationBuilder.InsertData(
                table: "tipologradouro",
                columns: new[] { "idtipologradouro", "codigoinformativo", "descricaotipologradouro" },
                values: new object[,]
                {
                    { 1, "A", "Área" },
                    { 2, "AC", "Acesso" },
                    { 3, "ACA", "Acampamento" },
                    { 4, "ACL", "Acesso Local" },
                    { 5, "AD", "Adro" },
                    { 6, "AE", "Área Especial" },
                    { 7, "AER", "Aeroporto" },
                    { 8, "AL", "Alameda" },
                    { 9, "AMD", "Avenida Marginal Direita" },
                    { 10, "AME", "Avenida Marginal Esquerda" },
                    { 11, "AN", "Anel Viário" },
                    { 12, "ANT", "Antiga Estrada" },
                    { 13, "ART", "Artéria" },
                    { 14, "AT", "Alto" },
                    { 15, "ATL", "Atalho" },
                    { 16, "A V", "Área Verde" },
                    { 17, "AV", "Avenida" },
                    { 18, "AV", "Avenida" },
                    { 19, "AVC", "Avenida do Contorno" },
                    { 20, "AVM", "Avenida Marginal" },
                    { 21, "AVV", "Avenida Velha" },
                    { 22, "BAL", "Balneário" },
                    { 23, "BC", "Beco" },
                    { 24, "BCO", "Buraco" },
                    { 25, "BEL", "Belvedere" },
                    { 26, "BL", "Bloco" },
                    { 27, "BLO", "Balão" },
                    { 28, "BLS", "Blocos" },
                    { 29, "BLV", "Bulevar" },
                    { 30, "BSQ", "Bosque" },
                    { 31, "BVD", "Boulevard" },
                    { 32, "BX", "Baixa" },
                    { 33, "C", "Cais" },
                    { 34, "CAL", "Calçada" },
                    { 35, "CAM", "Caminho" },
                    { 36, "CAN", "Canal" },
                    { 37, "CH", "Chácara" },
                    { 38, "CHA", "Chapadão" },
                    { 39, "CIC", "Ciclovia" },
                    { 40, "CIR", "Circular" },
                    { 41, "CJ", "Conjunto" },
                    { 42, "CJM", "Conjunto Multirão" },
                    { 43, "CMP", "Complexo Viário" },
                    { 44, "COL", "Colônia" },
                    { 45, "COM", "Comunidade" },
                    { 46, "CON", "Condomínio" },
                    { 47, "COR", "Corredor" },
                    { 48, "CPO", "Campo" },
                    { 49, "CRG", "Córrego" },
                    { 50, "CTN", "Contorno" },
                    { 51, "DSC", "Descida" },
                    { 52, "DSV", "Desvio" },
                    { 53, "DT", "Distrito" },
                    { 54, "EB", "Entre Bloco" },
                    { 55, "EIM", "Estrada Intermunicipal" },
                    { 56, "ENS", "Enseada" },
                    { 57, "ENT", "Entrada Particular" },
                    { 58, "EQ", "Entre Quadra" },
                    { 59, "ESC", "Escada" },
                    { 60, "ESD", "Escadaria" },
                    { 61, "ESE", "Estrada Estadual" },
                    { 62, "ESI", "Estrada Vicinal" },
                    { 63, "ESL", "Estrada de Ligação" },
                    { 64, "ESM", "Estrada Municipal" },
                    { 65, "ESP", "Esplanada" },
                    { 66, "ESS", "Estrada de Servidão" },
                    { 67, "EST", "Estrada" },
                    { 68, "ESV", "Estrada Velha" },
                    { 69, "ETA", "Estrada Antiga" },
                    { 70, "ETC", "Estação" },
                    { 71, "ETD", "Estádio" },
                    { 72, "ETN", "Estância" },
                    { 73, "ETP", "Estrada Particular" },
                    { 74, "ETT", "Estacionamento" },
                    { 75, "EVA", "Evangélica" },
                    { 76, "EVD", "Elevada" },
                    { 77, "EX", "Eixo Industrial" },
                    { 78, "FAV", "Favela" },
                    { 79, "FAZ", "Fazenda" },
                    { 80, "FER", "Ferrovia" },
                    { 81, "FNT", "Fonte" },
                    { 82, "FRA", "Feira" },
                    { 83, "FTE", "Forte" },
                    { 84, "GAL", "Galeria" },
                    { 85, "GJA", "Granja" },
                    { 86, "HAB", "Núcleo Habitacional" },
                    { 87, "IA", "Ilha" },
                    { 88, "IND", "Indeterminado" },
                    { 89, "IOA", "Ilhota" },
                    { 90, "JD", "Jardim" },
                    { 91, "JDE", "Jardinete" },
                    { 92, "LD", "Ladeira" },
                    { 93, "LGA", "Lagoa" },
                    { 94, "LGO", "Lago" },
                    { 95, "LOT", "Loteamento" },
                    { 96, "LRG", "Largo" },
                    { 97, "LT", "Lote" },
                    { 98, "MER", "Mercado" },
                    { 99, "MNA", "Marina" },
                    { 100, "MOD", "Modulo" },
                    { 101, "MRG", "Projeção" },
                    { 102, "MRO", "Morro" },
                    { 103, "MTE", "Monte" },
                    { 104, "NUC", "Núcleo" },
                    { 105, "NUR", "Núcleo Rural" },
                    { 106, "OUT", "Outeiro" },
                    { 107, "PAR", "Paralela" },
                    { 108, "PAS", "Passeio" },
                    { 109, "PAT", "Pátio" },
                    { 110, "PC", "Praça" },
                    { 111, "PCE", "Praça de Esportes" },
                    { 112, "PDA", "Parada" },
                    { 113, "PDO", "Paradouro" },
                    { 114, "PNT", "Ponta" },
                    { 115, "PR", "Praia" },
                    { 116, "PRL", "Prolongamento" },
                    { 117, "PRM", "Parque Municipal" },
                    { 118, "PRQ", "Parque" },
                    { 119, "PRR", "Parque Residencial" },
                    { 120, "PSA", "Passarela" },
                    { 121, "PSG", "Passagem" },
                    { 122, "PSP", "Passagem de Pedestre" },
                    { 123, "PSS", "Passagem Subterrânea" },
                    { 124, "PTE", "Ponte" },
                    { 125, "PTO", "Porto" },
                    { 126, "Q", "Quadra" },
                    { 127, "QTA", "Quinta" },
                    { 128, "QTS", "Quintas" },
                    { 129, "R", "Rua" },
                    { 130, "R I", "Rua Integração" },
                    { 131, "R L", "Rua de Ligação" },
                    { 132, "R P", "Rua Particular" },
                    { 133, "R V", "Rua Velha" },
                    { 134, "RAM", "Ramal" },
                    { 135, "RCR", "Recreio" },
                    { 136, "REC", "Recanto" },
                    { 137, "RER", "Retiro" },
                    { 138, "RES", "Residencial" },
                    { 139, "RET", "Reta" },
                    { 140, "RLA", "Ruela" },
                    { 141, "RMP", "Rampa" },
                    { 142, "ROA", "Rodo Anel" },
                    { 143, "ROD", "Rodovia" },
                    { 144, "ROT", "Rotula" },
                    { 145, "RPE", "Rua de Pedestre" },
                    { 146, "RPR", "Margem" },
                    { 147, "RTN", "Retorno" },
                    { 148, "RTT", "Rotatória" },
                    { 149, "SEG", "Segunda Avenida" },
                    { 150, "SIT", "Sitío" },
                    { 151, "SRV", "Servidão" },
                    { 152, "ST", "Setor" },
                    { 153, "SUB", "Subida" },
                    { 154, "TCH", "Trincheira" },
                    { 155, "TER", "Terminal" },
                    { 156, "TR", "Trecho" },
                    { 157, "TRV", "Trevo" },
                    { 158, "TUN", "Túnel" },
                    { 159, "TV", "Travessa" },
                    { 160, "TVP", "Travessa Particular" },
                    { 161, "TVV", "Travessa Velha" },
                    { 162, "UNI", "Unidade" },
                    { 163, "V", "Via" },
                    { 164, "V C", "Via Coletora" },
                    { 165, "V L", "Via Local" },
                    { 166, "VAC", "Via de Acesso" },
                    { 167, "VAL", "Vala" },
                    { 168, "VCO", "Vila Costeira" },
                    { 169, "VD", "Viaduto" },
                    { 170, "V-E", "Via Expressa" },
                    { 171, "VEV", "Via Elevado" },
                    { 173, "VL", "Vila" },
                    { 174, "VLA", "Viela" },
                    { 175, "VLE", "Vale" },
                    { 176, "VLT", "Vila Litorânea" },
                    { 177, "VPE", "Via de Pedestre" },
                    { 178, "VRT", "Variante" },
                    { 179, "ZIG", "Zigue-zague" }
                });

            migrationBuilder.InsertData(
                table: "tipouso",
                columns: new[] { "iduso", "descricaouso", "nomeuso" },
                values: new object[,]
                {
                    { 1, "Uso do imóvel para habitação.", "Residencial" },
                    { 2, "Uso do imóvel para atividades comerciais.", "Comercial" },
                    { 3, "Uso do imóvel para atividades industriais.", "Industrial" },
                    { 4, "Uso do imóvel para serviços públicos ou comunitários.", "Institucional" },
                    { 5, "Uso do imóvel que combina mais de uma finalidade.", "Misto" }
                });

            migrationBuilder.InsertData(
                table: "tipousuario",
                columns: new[] { "idtipousuario", "descricaotipousuario", "nivelacesso", "nometipousuario" },
                values: new object[,]
                {
                    { 1, "Entidade voltada ao time de desenvolvimento para uso do Sistema durante testes.", "A", "Desenvolvedor" },
                    { 2, "Entidade administrativa do Sistema.", "A", "Administrador" },
                    { 3, "Entidade responsável pela alimentação de informações do Sistema.", "B", "Funcionário" },
                    { 4, "Entidade auxiliar na alimentação de informações do Sistema.", "C", "Estagiário" }
                });

            migrationBuilder.InsertData(
                table: "topografia",
                columns: new[] { "idtopografia", "nometopografia" },
                values: new object[,]
                {
                    { 1, "Plano" },
                    { 2, "Aclive" },
                    { 3, "Declive" },
                    { 4, "Irregular" }
                });

            migrationBuilder.InsertData(
                table: "cidade",
                columns: new[] { "idcidade", "IdEstado", "nomecidade" },
                values: new object[,]
                {
                    { 1, 1, "Aparecida d'Oeste" },
                    { 2, 1, "Jales" },
                    { 3, 1, "Palmeira d'Oeste" },
                    { 4, 1, "Paranapuã" },
                    { 5, 1, "Rubineia" },
                    { 6, 1, "Santa Clara d'Oeste" },
                    { 7, 1, "Santa Fé do Sul" },
                    { 8, 1, "São Francisco" },
                    { 9, 1, "São João das Duas Pontes" },
                    { 10, 1, "Urânia" }
                });

            migrationBuilder.InsertData(
                table: "infraestrutura",
                columns: new[] { "idinfraestrutura", "IdTipoInfraestrutura", "nomeinfraestrutura" },
                values: new object[,]
                {
                    { 1, 1, "Água" },
                    { 2, 3, "Energia Elétrica" },
                    { 3, 1, "Esgoto" },
                    { 4, 4, "Pavimentação" },
                    { 5, 5, "Internet" },
                    { 6, 5, "Telefonia" },
                    { 7, 3, "Iluminação Pública" },
                    { 8, 1, "Coleta de Lixo" }
                });

            migrationBuilder.InsertData(
                table: "usuario",
                columns: new[] { "idusuario", "cargousuario", "cpfcnpjpessoa", "emailpessoa", "IdTipoUsuario", "imagempessoa", "nomepessoa", "rgiepessoa", "senhausuario", "statususuario", "telefonepessoa" },
                values: new object[,]
                {
                    { 1, "Desenvolvimento", "000.000.000-00", "sged@development.com", 1, "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAZ0AAAE5CAYAAAE8Vc3MAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAAFxEAABcRAcom8z8AAGa+SURBVHhe7X13nBzVkf/vrzPgs40JBttgMMagSFBAWSutpJW0q5W0QTnnLK0iKOecc06btFm72iwJc/b5fOcIxhh8NskmGIczNkorwK5fVfV7Pa97eja0pGFnqO/n8/1Uvap6oft1dU3Pzs78P4gyyAE1dsgBNXbIATV2yAE1dsgBNXbc0AGlnMl2MPVMlpIBW7jh+4D0gt0H4OaRn/5Y9QgPbuiAkrOzFAM6240DIn3ZxYvIC/XmjcD3ASUeO2qz/7FjSK1bNP1uu9bdNH1+4fuA+uzZzeyrpIO7d7Hd9Gk9lI25d4+t+4XvA+qxcQOzpyK3N220bFqaNtKVZCq7SbL3Una/8H1AMSuW+2LJ6CS4HN8ePorvAJcSOsBHyCvY7rhyBfu7qji/8H1AXZct9WQXDxvx8qin4fLoAC8Zumkb9NxcjveLGz6gzksWw+yKCpszy8qgy9Iltp8O8MrcpvXmjMpqHscvbuiAzAPxYgzGXF3/iMV1Shq8Zugfr33I0dcvfB+QObkXZxn61cMPQM2hbzCvKan58aH7Hf00/eKWHdCN0i/kgDS8FkGcU1lZL1td9AvfBzSjvDKIX3yipdJxUdUXLL2iiuVMlHe0bIEHVwZpyEf692M5r7oCZanqF6Bf+D6g4dm5MOZsmZPFZTC2uBzu6tAexpVWsY3aw7Lz+GDpgKhN9of69bP7jS2p4L66TWP7he8DSjyELyaRKek5kJJhscfm7fDV9u0hbvtuSDqNr7TRF7thC3w7KRlajJ8ELSdNgRaKWh9w9JTdX5PG9QvfB9Rj0xZmz81b8UC2QtyuPdB7117Ffdi29Lide2yd27bdkErvuWmzNe7mLWqWhsP3ATVWyAE1dsgBNXbIATV2yAE1dsgBNXbIATV2yAE1dsgBNXbIATV2yAE1dsgBaei/cqdkW9LrT/sffHRJRYcPN35AivpP+ilaKoYbvg7og0uXrIMg0ucTlK5t+qD8fEbh4I//R83iD74OaOPzz0P/48ccn0EwpUn9uQOzbfq1TdtZ4th+4euABh7Yb3/WwKT5uYNa7fQ5BqS2mSQf2f3C1wH1WL+OP2cQ6rMG9mcSDL9tU9K20zhKmja/8HVAUw4ddHz2oL7svGIFXIlvx59R+CjB+qwCfWZhx9Qx0E19TkHTL3wd0C/eeMP+s319WDE1Hi4Zn1Nwf0aB2sSro56CmOXLsM8SNVPDccMHlHrggP0nxzlVVRC/ZYtalOW/NreJ5+cRLDZz6DVpj1nj4Hh+4fuA+m3f5vibqJuTCwqg47Lljs8l2FwX+IyCljOqzjv6+4XvAzInN2l+PoE4v7wk+DMKBxUPfROeK8tzxGv6ha8Duvjmm56LuJn0C18HVP36656LIM7xsPmhX9z0A5rt/kyCj88oEP3C9wHpzxNML68IfL6gospu39a0CdzWrKnyWTb67AJ9JoE+n5CyaztL+nP/7MpyFWdxWmmZmqnh8HVAz7/5FowuOuf4bAF/3gDb485VwsMDB+LBNOHFUoyOHVdWbX9OofeWHSzpswvcn8ZCjkU97J9T+MGbb/NnCQYcPeH4fMEjqYPgvu6xkIx68wmTIBUlfW5hcE4h6/ozCsnpZ1g+OW0GpKAeGCMX+h/CF72fxecUem62PqPQU31WgT5/YH4ewab6DALR8u8LtPkzCrq9jz+fQGP12rpdzdJw+D6gxgo5oMYOOaDGDjmgxg45oMYOOaDGjqg7oGiDbFAjh2xQI4dsUCOHbFAjh2xQI4dsUCOHbFAjh2xQI4dsUCPHZ7ZBY4oK7U/S1fZtQF4cXVigRol+hH2DJpcUB0626yOP9aF7M6MdYd8gPrHmxoTYJN4Ijzh7g1R7CGZiNCOsG3Txd7+DgemnIen0KRjogwM8bPXmqZPMJJzf049MSvewnbbiac2v/flP6kjCh7Bu0MTsbEg4eKBhPHSQZT8lvah9/TzsbDuw39k/aCwVF4rYX+vhRlg3qNfWLRC3fdvN57atLHsTSddtrRt+dx87TtnsGKOfrSPDjbBuUN/166D72jXQfc1qi6aOjHX7NN1tN1evsvqTxHasjtdjKXZDW5e1a6HTunXItdAV293Ih/24D9EYj2jbFcONsG7Qj3/3W/vTzjeT+lPU9K1vnVD/0eg4uJTaFtkGLg1C2pJsitpuU8WjvIZy0ZxJQfMQw42wblBDP39fX3ZGXp/cAi5Pacm8oqjbN8p9e1fwp17779ypjiR8+Mw2qMuSxQ3+CrNZ5eWYJYsdm3Nt6XfhqsErLB9T1HZT1zEol1i6bpvMOu79dYbhRtg3KG7jBs8D98ONOTuhZueDcG3Ht/xx50O2fn37A7CorMhzHpPhRlg36OU//MHzoIPo84P3syoqYU5FOfxPTiJ8nH4vfHz6bqg5/TXkfcyPUf/X6Tvh7exWsKw0G2ZWWN822hCGG2HdoFr/OyJCGG587jeooXUw3Gi0G/S1rl3gjhbN4e4O7eFLrZ6G25s3g7SqKph7/jz/yw7FzK2uZvuXnn4K7mrfDm7H+HEZGeyj/24xSXHzLlyAb/dLCNgxnji1KHTtcf8jV7gR1g268MabMK6gCCaVVsBEJEmTpq3D3Hl8Eul/p+7t3AmS9h9k+5RKa4NIp39D0vFJ+w4wB+7dz23q+6WnnsTNe5LjplRWs/3hxETot30X6pU4H9GKnYrj6rGIei2WrGSd1h5uhHWDvv/m7yH1ZDoyA4bmFMGw3CIYmluMUvMsDM9HmVcMHZ5dAiMKS7k9PL8EHklOgW8nJ7ONNo1ivorZdS9m2vCCcxzzUP/+vBnD8s7ySR9dUsnxFs9Bwt6D8K2EBOixcattfzA+Afs8Yc/PxP60Nktabb3ucCOsG/TbP/8F+uzaC31372XZByXpCQePQuKRk8gTSmrd3bb0foe1HpD9jzrbDsk+3T4B/Vg3/A7SWKcs/fBxXmf87n1qrfvUkYQPYd0gjdj166HbqlXQffVqlMRVlqT2aqWzDYm27mvXQfc1a1l2W4tS6dwmfY2lW3aL3VarGMNm9dEyoMciaRy9jhh7biXRFrdunVp9ePGZbJCg/pANauSQDWrkkA1q5JANauSQDWrkkA1q5JANauSQDWrkkA1q5JANasSQzWnEkM1pxJDNacSQzWnEkM1pxJDNacSQzWnEkM1pxJDNacSQzWnEkM1pxJDNacSQzWnEkM1pxJDNacSQzWnEkM1pxJDNacSQzWnEkM1pxPhMNudXf/oABhfkB763rQ6aX7g3uLAAXnjrLTVSdCPsm7Ph+//hOPE29ZfsGV+2V9tXWtLmRjvCvjmOk2x+66EP0o9bRzPCujnFr75qbUh9NqWWODOjohlh3ZxBuTmOk2z/1r3LllqfzVP857/+pUaPPoR3c/Jy+YTy7/YT1Qm2JW0K2y2/7TN1HafkvMoKvr01nBc9bN58/f/+qo4gvAjr5iRlZQZ9kepNI32RK31RK0kvn9KDvmT2FDL9tPUlsqS7/Yp0gYQbYd2c/seOQiKSpCa1TZoxbrubps9L1+3+x44padqcbbNPKFvmz36mjiQ8COvm2N9oa38DrvnNt8pGvqBvyHXR7Te+Ideh14M0f23f7msy8fgxdSThQVg3p++e3cw+iqZu0m0P1a/v7l2WjpKp7O44pvYraY+xdw/rTNPnGpNs/fACCifCujn6q4g1HV9VXA+GjHd/jbHL5/l1x15+L6o+9PXJtHnhRFg3p8fGDdBz00Ym6waprf1at20eumkzfZp22xivNp9JHePWaRPDibBuDn/vs/4uafd3Spt2k14+tw2l+7ulbRrfPx2DsV3WrYVO69dB57VrIQZtju+31tLQY+l7epSkzQwnwro5MSuW3zJ2M9vLl0EXlAtmT4WP4tvDFeQl5EfxHeCjBIuXSEdeZn87eCWlJ/Rb8hx0xb7muCZpI8OJsG5OF+MrjG8V+y5ZBB8nt3J8OXjgi8MNG0vtV20l3x3SETqqLyjXX1ROpCwMJ8K6OfogbwbNjaYT2GH5cqgZ9SRcHvM0XB4d4CWSo5ztS0bb9GlyH+Tfx7RyzCmb44PrFo6yv5G9Xt/uPjUQxxLb7hjtvzapGX/JK303KX1XWzjxmW9O91UrYVpJMR+8+SWpxDlom5CbG9THvNVseG4EXJnbDNm0gfTqQ7aAfX/6dsd6EnZsV0cSHoR9c/SJTdm/33HgmrM8bJoD8DlDbwqxw7LlQV+br79OP/CV+vqr9y15BaX2mV+7T3Zt+3jxIzCzMvhimXI2vF/cGtbN4VdRS5c0+LugTVLf7itX8OZ8sv4huLr+kVp5zcu2zmi79ONZazznJc57/nl1JOFB2DPnRjbGJI3zt91N1O8aBH7fwLttcKe3/vr+zvy1/V5zac69EN6/vIZ1c4YePRp0wLXdxurDmRVVUHxmBnxy8D64dugbUEM8SPKbqv1Ny2bwGvu/AR8fuh9+cro/j2GNV67onkfZqs+rIwkPwro5XkX/ZnJ65XnYfO4gvJ/ZAv55+k64fvpe9WMV9KMVX4NPTt8D19O/Bs/njTA2pP5MOx/Fm+N1wJHEqL6teR1wJDGqXxB4HfBnTfePUNTGGWVl6kjCg0a/OTfr1d3NoGyOQdqY+mwOx4RhE2VzkPSqiH75485n2vJv6tDv4zwQ14t9ZKd7P+mPpaTwb+rcjTFfbvU0/6II2SdkZ/MviFAsE/t/uXUr3kTTTn2/0qa1PW9djOrNmXauDGaUV9qcbugmn540CdpOnWa3p5fjicGXvqTTSZ1z4XmYVHgWbsfN0DFMfIgkOTbrDG/sTHw+SassVSyDuVXlvDm6TfKxlGToNGcmbhytDecxx3OwAqaUnFNHEh6EdXNq+0Ekk1PKq/iqvqOl9atSLceMhckV1o8a0eZMq74IzUaNhvbz5rNtZFYOJO07CAORE4rPwYgMzByMox9EIt7W5HFrzjIrc+jHkPQPHU0oKYe7OrRnvTaOw4thTH54f60+rJszPDuXOeZsGYwpRpJ002UfX1oFg09n8UmlNm3OhPLz0H7+Qnhs6DC2JezeByPzivi2RvGDTmXCnW3bwtjicpsUNxY3Qo8zluZBxu/YA1/v2ZNtnlTroXUPQ4YTYd2cVP7Fp3RIQdIvQA3lX4dSv1SFbfplKrJ9e2ASykIYkV+C9mIYUVTKJ5V+OYo2Z9TZcts2NKcQhmPMyKIybtMvUA08dgq+0raN9YtUGEdyUCZeGAUldowVd5rbZKd5LNKvU5m/XFUMKSesdaeeTldHEh6EdXMSDx2F/kiSxJSMHIvpSmbkMpMwU1rNToP7Y2PhznbtoOnosTDoTAHHNJ8wiX9BiuLIRj8xdnenTtBl5RpoPn4iJKdnQ4/N26HlpCnQQpF08qXgBuk2yU7LV8Gg7HyeP1mthaRmKrI/zqXX2/9IVH+o0Po5LvMnxIj2z3YZP/MVsJm0/LpNPx1mxlrS8ls/FRaIDabbp/rZP1F2ktdm/ewZrhvliMNH1ZGEB2HdnN34KqvH5q3ILZbctAV6IkkSe23bDr3xJBDjNHdaJBudIO0347TUcVr2Rqn7WHH7WCebHl/H6Rjq22vrduhJa9y42V4bMdwI6+YQnsNnEPrNNvs31NTvp/FvuwXpyDVrQP9OG/0Om9YDv89m6dbvvAV+ry12nUUrziL/NpyydWMbjklxKO05XZLXiWt456/h/zeQsG+OoP6QzWnEkM1pxJDNacSQzWnEkM1pxJDNacSQzWnEkM1pxJDNacSQzWnEkM1pxJDNacSQzWnEkM1pxJDNacSQzWnEkM1pxJDNacSQzWnEkM1pxJDNEQh8QpJHIPAJSR6BwCckeQQCn5DkEQh8QpJHIPAJSR6BwCckeQQCn5DkEQh8QpJHIPAJSR6BwCckeQQCn5DkEQh8QpJHIPAJSR6BwCckeQQCn5DkEQh8QpJHIPAJSR6BwCckeQQCn/hcJs8/amrgJ++8Awd+/GNYUFUJowvyIeVMNjMVOTI/DyYVn4W0inJYdvECbPj+92H3f/8Ijv7sp5Dx4ouQ+dJLUPDrV5g5v3qZ2+TbgzHrvv8CpJWXI8vgwE9+DL94/324fP26mlkQTfjcJM+K5y/aCcLMznIkTMqZQJuYjH7Lbummj6lsOobatq5o+vT4IzBRP8LkFUQ+oj55fv/3v0Nqbo59QZt0X+xB9EqaBjLUHIMwif6l1iiITER18nz86acwKC/X8+JlUnLcaIK4K44xXqBiec9Ba/vkn/9UqxVEGqI6eWaWlQZdsHVWG6K+6EkayaBtni/jNGvzEV3+MYUFarWCSEPUJs8///UvGIIXZshkwYvY9rkuaLOPnShKhurjaJPu9iO9ko5eUn5w+bJatSCSELXJ89qf/2xfoMlZmZCUmdH4mZFuUesokzMNm4vJJHUfJLfZZti1Tce6dRVr99U+TWwnGzq3dYxqm/MNxhvEe//4h9qF6EbUJk/6z38GA06dhAEnTzRK9vewefKEJQeqtpYhqeK9GKpvXWOaa+XYE8cdfi9SIkU7ojZ5Fp0rgX6HD4XmkcMWvXyhiPGJZj+3rIvuOFebx2bdY7z6zhGSwf3NY0l0+bwYWJ9TN9umfRxW/GhG1CbPcLw7xu/fF+A+g6adfXtD20hqmm0zVjOU3ST397LvgwSiHWPMw+sOtBOC7CipbfbVult6+UPFKtkX6ViXoZOPpF67bhMTjx5RuxGdiNrk6b1jO/TetZPZpxap6Y4NpZs2t89sm/Sy67b29d65Q7V3oI5rJ+oY8iHpmKy28pGNqHTyMZWu4zkOx7Wk6s8xO6AvzUe27dvYbo2h4jkWdeKOHRDHfSwb9TP9QX1Qxh/Yp3YjOhG1ydNz00botWVzg9jTw3YrGGoetm/e5LRTW9l6aunyBfUzddOm7J7ze/VRjNN9PWJoTTQe0+WnZI1mRG3ydF+zGmLXr2P2UFLrPTast23cVtQx2s7SFaulF80YN02/V6y221y3FmLXrnHYgvpgjMNPfbRuSK3XZee2Maa2MZWdYxR1vNtG66b4OEygaEbUJk/y1i0Qs2oldItIrgq59u6mvnoVdFu9Gjoju6Aev2wppKXNgvSxw6B62ED4n5R4eG1AL3gnoRv8qU9X+EvvLvBefAy8nhgLLyb1gRcG94ezI1Nh/fSJMPS5RdAF5+2ixqI1BOZdYeiWneburnVHbICUTNGMqE2e7efOQVe8mKKFXZRcOnMCvJ/cCa73bwtXBjwDl2y2g48MPUB32yLFWvHBPt2nBuf4cGB7KBo7EAY8uwA6rFgRtC5izPJlnnZKsGhG1CbPL95803NDGyuDLkBsxy9eBC+N7QZXhrWCy8NawyWUFk1dtYeaPk1sD9WxLnsQg33WnNpmycuKq+eMhY7LlzvX7KIkT4TiF2+84bmhjZlUXQYtnguXJjwJl+vi+BD6rWAt418f3xLSZydBx2XLoMvSxfyyMmaFlVSSPBGKF7Hy0N081EuKUOy8ZDF0w83vu2kTDNyzG1IPHoDBhw/DkCOHYfChQ5C8bx8k7tgOPdbgs8HSJcyuRGOM2uaNWR5s64wX3okFSXBtZjO4Mqs5XCbObIFsDldIzmrB8oqWtg9JtlB2ZQu0PewkbRvNq2J4DXotym5I8l/F9b62LB5mVlbC7IoKB+egLWblCrUb0YnPbeWhiz4Jk2MGPhvNqawK2nw/TKuqgol5eRC3Yb2VVDyXM7E0dXINWZoG1xd9F64uagJXFj1uENsLURIddjcx7lln36skVT/Wa2HwvMiFyuYx97VFj8Fbq7p4Hr+bI9JPq92ITnyukodeUswsK/Pc6FtCvPvSfHEbNtjJpJOG5O7lKXBt5Xfg6qpH4epKpJZu3avttofya7rH9oo37Q7/d+Ddje34X8s9jzMU8WYSzfhcJA+9/KKXEZ4b3EDO8rDVl7SGMRkZvKak5WlQs/khuLb54Tp51cPmh+5xahv3400Pwk8OJnkcb7mrHZpzL15UuxGdiOrkobv9zUqaW8HpledhbclJ+P2htvDpnvvg2t4Hbog1HjaTNXsf9LQTP91zP7x1+BlYWpoNMyqrPdfbUKadP692IzoRtcnz09/9FmaV1/8uSZzjYQsHrXmttc6oqIZny/KhMmcC/OPEw/DJ8Xvh+vH7oYb5dUWtm3bTb9IZe/34ffDpsXvgf9M7w4GzmzFRzmN1oRtMQ85VIDb0OSuHOdXVajeiE1GbPK998EGjrjp+SIk1rfICpFWUwcqydNhWuhcOlmyA08VLoKBoNjO9eDEcQhv5VpRl4MVdzn1mVtycN0UawrlSeSIT1a+/7rmhwvBxnjzzRCYkeRoB5d22yIQkz2fPGWVlajeiE5I8wltGSZ4Ixa1KnrTqahh57Bg8PigV7u8WA/d26sTyW73joOnQIZCwfj1Mzsuz46eXlECzoUOh2bChMC4ryzHWHHxZMwlj202fDg/G9eKxvta5MzzQqyc0HzYMknftdLxjSO0WI4bXyWemT+OxiS1GjvCMeWrsWOizejWMz87mB3tzXTeLkjwRCkoe+gOf/iNfXX/cdMd59euzZg188YmW8CAmytwLF6wLtLLSvlApsaYWFUHryZPtTzLQ3zruaNkCbmvahB+geSzs89igFB7rzjatYUp+QWAsNR71G3LwIMSvW2evYQJe6DTWnc+0hfnPX+SPA5mci/PPLD0H8WvXYnw5j/VIYiLPk7x7F66P1miRYmecK4HWEydY62veDMdwvzuJY6i3pc3zUBcpljhdkicycf6NN2DS2RKYcq4cppZVwtRyJMk6OMWg25d68BDc0aIZsjk8M2MmjMsv5HFnVF2A6VXnYVp5VSBezUc+nTwzzz/P9h6rVvMF/d2UZJhWgQlX19qUf1TmGTt5Zl98gce25lYS42byBV8Kc6tKYH71OfhO/wSea/DurTC/qtjmPGYJpFWeg+FHD/O4X+8RC9NDrYdsSK/zYsbzuSsth0nFJTC+qFjtRnQiapPn4htvwui8AhiVWwBjCs7C+HMVFkvKlVRtZZtgSqXbsZiAHK/aE8uqIOnwUXhy0mR4ZMBAuLtjB7itWVO+ACmxvvT0UzBOx+LFqJNnctVFtjUZPoIv6PbzF6h5rDlbTZ/B43yh6eMcT2PdgRVhUsV59g/LsCoP9X0cX9Y9hi8HTZJt/LlKNSYeS2klPNSvH8f33bYDfbQma102ce6xZ0t53Lvat4dJ5dWG3xrHca5sO0oP37jiMj7nxJG5+Wo3ohNRmzzfe/NtGIwXm+aQ9GwYWVACIwvPBVhg6DZ1jCsWOaqo1GgH+4n9Dx7ji/6uDh1g1NkyGI0XFydPsyYwtrSKY1JPZrDtdqxio/ECdI9BY1NfSiS68GkMWnvKCavfV9q2gdHFaFOxZj/dprUSH1TJ02vzNttn9hlTUgn39+jBMe3mLXD4PKnPmT6XxjkcnltonWvjvEczojZ5/gOTJ+nYKeRJ5kBDpmbkwOAzBQFmk8SNd9jyDZ/FTktXqETAi/rJJ+DLrVrBV9q0YX651dNWpUB+tX07GJxTxH2H5hXbfYYVlOI4OA+OPSSnkJPgi5REzZtytfoyPv/QOLdjtWEfXtDEofnF3C/x8Akei+0kPUj+LzR5DAYcPQlDsM8DfeM5nvuZcbhOmvd2XNfdnTrBoCw8Xn3M+rg12UbnxzhH2q4kneuBTDrH6rwfP6l2IzoRtcnzwzffgvh9ByFhP/EQ69xWtHyHoD9eZANPZsIAJElNamuadjeTtDyVxSTd7Ecy6VRAJ6mp+w48QTLDtg/gtkXqW9caiBSn5yHyGrBSaR9L5TOpx+b+qq1ttlTjeJHOoT6nNpWt34FDajeiE1GbPPTDUX127YW4rTsgbvtOiNtmkNom2Y5xyN7Ypy9uft/9R5CHIZ54QEkHLb8Vc4Rtdryhs8T+jraSCWpc0i27NQ7b9mHCK13H2O0DOk6vMbAWWrcdb8zrpHFsdrwxtyk91t57157AefQ8n9a5PPWDH1ibEaWI2uTRGLp3P8SuWw/dmfQ9Y+uxvQFi1yNZX69sAXZHX/e167gPxZFOfXps3AQ9N2+1uGUbSqSWaOtFxDaR7Sa5j+pr9zfatk3btwT62v20jnOoPvQsY/entj2u1bfXVtU2x7ZjXKR4JXX/Hhu3WOeDz4XzHJnnjHzdlZ/O02/ee1ftQPQi6pNH40pNDZz9yU/guYwMWHj6FPK0k+kWFzhs6TDfbCubHaPj0WbGLMDxLaJOMea4NI+W1E/3pXaG1dZ9eHxuk133QZ4OxAXG0rqKxbEsv3N8e73Y1rq9NiSvWa/dsOk5bF35NDefPQuvvvOOOtufD3xukkcguNmQ5BEIfEKSRyDwCUkegcAnJHkEAp+Q5BEIfEKSRyDwCUkegcAnJHkEAp+Q5BEIfEKSRyDwCUkegcAnJHkEAp+Q5BEIfEKSRyDwCUkegcAnJHkEAp+Q5BEIfEKSRyDwCUkegcAnJHkEAh+QxBEIfEASRyDwAUkcgcAHJHEEAh+QxBEIfEASRyDwAUkcgcAHJHEEAh+QxBEIfEASRyDwAUkcgcAHJHEEAh+QxBEIfEASRyDwAUkcgcAHJHEEAh+QxBEIfEASRyDwAUkcgcAHJHEEAh+QxBEIfEASRyDwAUkcgcAHJHEEAh+QxBEIfEASRyDwAUkcgcAHJHEEAh+QxBEIfEASRyDwAUkcgcAHJHEEAh+QxBEIfEASRyDwAUkcgcAHJHEEAh+QxBEIfEASRyDwAUkcgcAHJHEEAh/4XCbOW3/7G5x97VVY98ILMO1cCQzPy4OUM9nM4Xm5MOFsEUwvPQeLqqpgzQvfg+3/9UPY99//DSd+8XPIfOklyHn5ZSj49StMap/8+c/h4E9+DFt/+J+w7MIFmFJSDKuxX/Frr8Hv//53NasgmvC5SZx/Idf9xwswuDAfUnNz7ERxMDurYfZ6kOYaXJAPyy5egGuffmotRhDx+Fwkzrv/+AcMwotXX8zJlAhmMqCeqnXVtvX62Ina5xqXJM+HclB+Hhz92c/UqgSRjKhPnJpPPsEqUxB00XOiuGwh6Y7Tbbc0/cjk7ExuO5IS+dyF82p1gkhF1CcOPa/YF626oM2LuFa6Yt0J4EVdXWolxhz/uVSeSEZUJ84f8MF8ED7se168btZxwdcnaRysYzx67vlHzTW1UkGkIaoTZwm+JKIL2KsK2C/VNF3++lCP6/myz2jrpHOv47nz1WqlgkhDVCeO/e6ZvmDdF3cIW4OrC7GeY5tMxWooiExEbeL8vaYGBuXjyzS8eB2JYFzMjopRD9pxegyStYwRclzdBxP75Q8+UCsWRBKiNnEuvP47SMk540gU+6I1LniHrtsoPS96V5z90su0m0R7XePQH04FkYeoTZw9//2joIvUQcPu9QxENC960h1JEGpcopfPbaM2cnJJsVqxIJIQtYkzu7zMeaGaVBctJUwytllmoyRdk2JUrKN9xpkA7njdZp1sqj/Ha90eC2OwKtLHdOiTBTeXFz1sN5HGmumjS+exwl/75BN19qMfUZs4g3Ott6Hp4k3KzLgxZqR72/0yI9iWrHWvuVw2jiWbtqNMtnVjLB2ndI4x21mZjnntcbXNpNlP0dHGseil8QZMos8DojZx6O83tKEDT5/yZJKil88PB3jYGsx05KmTrPPaDD0p/TT6T9vrpra5fq1rv7brMSzd6qfbDl1Jm9QP4wN+FavnNcd1cXJRodqF6EXUJg7dAQecPAH9kSQjibWu+cRxb3sIDvSwabvDd8LQ67CHGpOo137sx/+tdiI6EbWJMwDviP2PHWUm1oM6VsebbZNmvBmn7Ww7fsxh94xxtb3o1U/bBxhtretY3c+kjvWKM31uu9bdNne8u02VJ5oRtYlDG9jv8CGDhyHxyGHop8i6w++m6Vf9HP5aqOcJ5fNo22szfGTT6zTXG3LtnjHOWLa7+icausPunsfdVvRaT+LRI/CHDz9UuxF9iNrE6XfoIDOBePBAEG2/h69uevXzO5aTda1Jr7ufbis6Ykge2O+w2T6P8T3718KgeI81kfzlu++q3Yg+RG3ixO/fj9xncd/e2qUXQ/nIzvTwuYlxfRV12+lXNrfd9ht2d5zZ9rKbPkNPMO3ueCSvVXPvHkvqviS9+gbpVtzL70niRBz67tnN7FMHveJ0u7YxTB/L3bscbdPv7uO2M7G/jjHH0ra+e/Yo6YzVcQ5pjmVIzb6YEA6bnk9JTXMdffconxqbfabOMc4+UnEiEL137WT2UdJNLzvZTJq2ULpum3T73G3TxvrOHSiJ2N6xXcUoG/mQFNNnJ/q05P7k2275uI3E/pZd2Qy/Hs+az5qX4u0xyU46xlk+K8aOVf6+Slr9yK99au1s2wm/fOcdtRvRh6hNnLjt224qe3vY6sOG9Ou9baulk9Q0Y7DNMdq+LRBrz6P9mm476o7Y7Spm65YQ8VrqeMvvWKtbKv2Xf/iD2o3oQ9QmTq8tm+vNnnW0byV5rs2boCdR21C3fcqv4+22JrZDrTfObdvsnM89ji1Nmn5FGpfGca/X1Mn30h9+r3Yj+hC1idNz4wbogey5aaMlXW3TVhepjx1r9Nc+sx1Ecz5zHG0z7Jq2X/U1Y+y20r3otSa2ETesd4zjjrNpxJl097VjzPWp+V/6vSROxCF2/Trooah1kiZNm9tv9g3l19LLFyrebTPttr5ure3roXQdExSrdYyz/abutrmly6/nNf20Bu2zbVp3j4PkMdD+0u/fVrsRfYjaxOm+dg10X7PaIum6XR+p9dr87rYZY1L7TZ8rPta0EVevCuhexFju42En2Q0Zg3oXZOe1a6ETXsgd8ULuRESd7OSnOO5nzqfG8GLsapRrXTaSZh8ai4i2F9+WxIk4dMPN67ZqZYMZ42Grm8FzWeM47YGx3fHB/bt72IK5CrrgcRJjUB+5eBFsnjoBSkakwPcHJ8JLSX3gzX6x8F58DPyldxf4oG9X+ENCN3h1QC/40aAEqBqeBCfHjYCZc2dD7+XLoDOPhUnlce5iVgbmDNhJ91qnZXvxrbfUbkQfojdxVq6AmBXLo45dkR3x2JIwSfZNGgm/S+4OV+Lbw5W+7eAyykvEhA7wUTxSS61rKhvHJWBf7t8eruIYH6Itf0wKzEmbwfN0MefG5LLPK+raHoqSOBGIGNzgrsuWfrbEi8vTXg/yhan6k2y3fDkMWjQPXhgZD/8Y2B6u9W8Llwa0Y3404Bmmbl8aqCT7LH+g7daRRrzmFbTX4Bxvp3SFhbMnQ2ecv4trjXXxxTffVLsRfYjeZxx8ueG1mZFAnTDEjsuWw6pZ4+BPQzrA1ZTWcCkVEyYFSXKQYmobi6wbthSyq7YZRzY7jqTu6/Zpe1u4ntwKLoyNhx5LF0OnWm4I5tolcSIQ9IxjbmhjYtCde6nzgiN2XLECdsweBdeGPg2XhraCS8NuJjEBmaF8odtXcT3/M74nJxAfh8faiWSTxIlA1Lvi1HL3/CxIF+PoZ2fDpdFPw+VRT8FlkqwrGYIcb8jLY1Tb6Gf7QoxFfo5X/ktqDNOv9ZpRT0LGjGSuiF7HIYkToaDE8boTNmZ2wIuwYkZfqBnfEi5PePLmcbyil+8G+beJraDPkmehy9IlELNiGcSuWmXpkjiRiUh7xum0bBm8N601XJ7SEq4gSdqc6mwH+WuhV2yo/nWNq/2mvDK5BfxlTgeYWFgEcyorYXZFBcwoLeXkkcSJQOjEoTtffSsPbTbJHmtWQ+KO7ZC8bx8MOnQIhhw5DIMPH4ZBBw/AQPrI/OZN0G3Fcui8ZDG+xrf6mGxopeuxbDFcntkcrsxqYZH0mS0sG0rbbtDyBfx2f2prn26rPldmkU35VBz1c8yt+9gxSme7M65mRhM4cGobzKys4oQxmYrnShInAlHfikPJ0hcTYXzOGZhZVgZzqqqY7gvBJN1Z0ygO5bSSEhh86CAnGyeSxxwOupKKKs3luc3gytymSLcMZQtFdz9Nty1UrG676fRdTWsCv13ZC2ZVWBXGi9NLzsEv3nhD7Ub04XNRccwLlUjJ0n3VShiXnc0J4LXxDSUl0SxMvKHHjtlzuOd1k55p/vfZtnBl0ePeXOhhs9lEUbUx9qqSlo4+pQdiXH1su6vtoj0W6tcXfAdOnFznWWVMplVXw89ff13tRvThc1VxKIm6r1wBk/Lz7dfj9eUsD1so0thjs7L45Zx7DSZXLRsBV5d+18Ertv4YM9AO+EheWWLGKhvT6mfGB2Ise8AfiA2ey9kmvrOmPcwtL/M45vIgG52DX8l/gEYe3IlDFWDIkSMNTpj6MFRS0VwjTp1yVB9dATssWwHXVz4CV1c+Wj+uUjTbbt20hWJdMR7+T1Y8BJmnlsGMyvOex+lFOvbf/OlPajeiD1GdOHSREunCnXb2rOcGh4sD9ux2JNDKlVht1mHirK8/r3nYNK+ZY9Vj3FBjmfaadQ/BW9s6Qppnlambr0jiRB50xaGLdca5c54bG27OKiuHftu3Q6elS+Gvmx6Da5sfdvDq5oeYbrvNLR425NV62twMHYPrwLl25u+GmRX+nwH/U/6RLfJAiUNJM9VVaRryrHJLiC9hppdXwH8fTYFPdnwdru34lkFMGpI7ta5pxrjp4ef+WldjmLZaxry+/QHIz5yHL8uqvdcfksHPORW//a3ajehD1CYOfVYt9eBBexM/84RxUb+VW5o5Fa7ufRCu7/0G1Ox9AK656GVz0x1Tg+OZbZPaR9LqR/KbzLzs+T4SJjTzf/6fajeiD1GbODGrVtz0NwLcyTfH1fbLaZUXYNvZffDGifbw8cH74PpBrESHMJEOfsOSDuJFjpLsQT6M9+6DNvI5bN+ETw7dB38/8h04WLCR1+C1thth3g+i91cLojZxkg8cuGkXtmZtVavhFU2/tAm8xKEqRM8UR4rWwa8zusEnx+6F68fug5rj9yt+3aC7HcqmaY3x8fGvwaUT34LKnPGwsLyojmeY4JdfTrspg2Mzf/ETtRvRh6hNnIkFBUEbSbxVL9lu9rh0Qc+oqIZny/Mhv2AOvJbdBT5KfxA+PX0X8/ppTKrTX4Oa05hYLlq+e+zYDzO+Db880wOOFK+DuRWl/Lay91/9QyWKP+a+8orajehD1CbOLONl2q1Klhuj9106mFYcXejTKi/aybS+9AjsObcVjpWshpyz86CgaDacQXm8ZBXb15cew7gCjqeXYVai1HfOuli/MQp//Wu1G9GHqE2cuRdu/mt2YcMo76pFICRxPnv+l3wFbuRBEuez52/+8he1G9EHSRzhLSF/Vu3Pf1a7EX2QxBHeElLivPrHP6rdiD5I4ghvCSVxIhSSOJ8tJXEiFJI4ny0lcSIU4Ugcujg0vfz1of5Y0M0YK9ysba3kk8SJQNyqxKH/7YlZuBC+1ac33NupE9zbuRN8o0csfGdAf2g/cyYMO3zYjqWLp+Ps2dBixHBoM2Vy0PcbUDtlz254NCkJ7u8Ww+N9vXs3eCSxH3RKmwPjs7MCY2Fss2FDeazaSDFTCvK5z+iTJ6G5Rwyx/YwZMOTAAf4foVuRrJI4EYpbkTjJO3fCF5o2gdtbNIcvt3oa7mrfDu7u0B7ubNsGvvhES7i9eTP4QpPHYXxW4ILvMn8e+1qOHOEYa0x6OtzRogXc0RKJ4331mbZBY93bsQN/6QXFU5Ldg23ycR8PUp/bmjWFAdu2cR/6r1eycR+cIxDbnO10HHQ8z0ybWuc3+zSUkjgRijSVODfrc2p0AXPS4AU3NjPT+hopvDj4bk06kmJS9uyB2MWLuQ/N3RWrE124T4waxW3i1KIiuA3Hoou589y5kHb+fGA8NRZ9qV+bKVPQpuZHGyUOXfgjTxzntoPVVTD3fDUmbSYk7dgOs7HftLNFdjIt+N73OEaTYocdPgRfevopXl+HWTMdx+umPo9ahmLAL4kTkZhZVc3/aTmjvNIibqSta7vDpkk+ox9Sj0MXIVWUmZXnLZ9Xf7TNrKy2210WWInTcvRo5a+CR/BlHdlaTZ7MbbuvSRqbPyFt6bNwTJ04Q48ewxi8OCvpZVYZzEWmVZYatNozigt5zZSgCy5We8SUwezSYk4siltwsZJtNObM8vLgNWl6HbfB6fjyb3ppmSROJGJqWQVMKi5BWcmcoqSl410fN5hp2AP+YNv0qgvwldat+YK/p1NHSD18FCaXlMI0SiL0TcML292H2EklTgtMHGpPr6iG2/FCpYozrqAoKN5ekyFpPdTvbp04J07CjOoLvCYizT+z6jxMLSmBmRWlmEglMK+qBGaV5HJC0EuyZ58vh/lVxUjyFbOf4tKqy+ErbVpz3KisbOdaQhLPH0n3+VPtSWdLYHLxOfj1+++r3Yg+RG3iTMSLmi7MCcWlMKkUk8gHJ7raYwvO8rOIfl6gi40S4MutW8FD/RKg86JFOG8ZTC7Fi0f16TjfSpzmI0dxe3J5FV7IVr9p5593zDFg735I2n8QkvYhlUw9chQm4cVI/e7uYD3jfLFlS/jSU0/iy6wAb2vWBGKWLLPHonFpvVxxmjeHqVUXbfskY33Er7Zrx8fUf/c+h92kuU7SQ7bx+Om8jy88C69I4kQexuJdb3RuAXN8SQWMP1eOJKlYotrs0zZX2/BP4HY5TCirgjFFJdB95Sp4fOgw+EavXvDvT7bklztfpGRC2X7uPDu+/bwFfLE3w8ShOam/TpzJVc875vu3xx9j+xeaPm5d8Hgxd1i4iMeZiP2o4tBY30pIgMeGDg3iyOx8ayw15uh8lTg4zqTKCzy/fdya2NaJ02/3Xttmny8ey6Of7XPqo/MKkXjeUb7yniROxGFUfhEMz85VzIMxxWUw5izSlFr3amubl362lNtji8thXEkljC87D6MKSvAif5YvQEqisXghUWy7ufP5Ym+CiUPtsXhx6Uo1Ei9sPe6ogmJIOnYCRuQWwsjcIngkKYkTseOzi61+ON5dWHGo0g08dJTntokXNUlrbQHSWJSk9FJtfFm1suPajRgal94hpDUNSc92+DyJ6x2tjt/tG114LnDOz+TBr957T+1G9CFqE2d4Tj4MyciGwYpDcTNH4sYGsySEdOvnYFRRKYzEBDFtNtE+Ci8evrjxQh1w+Djb26ZZb0c/PmIEt0djzN34jES29vgybmQhjukYB4nzPJQ4AGNaQPtFz7HdHhsTp9++Q84+rnXq9lCsQJQ4dyDHnKv0XHvy8dN2VRqDScT2UMeoGcJP5ztwzs/Ar96VxIk4DMk8A6knM5DpkIIkOQjvqMPyzsKw3GIYnleMknSk1kmyX9uQ+ZZtaE4hPBifAAn43DECL/bhePGQb7jiCLzgBxw9yRcgXYja33rOXCtxho/gMWnePjv3cgyx66q1MAITxYovgeE4dsKeA+yjxGk3/1nuMxx9gcQ5zHHD8WKltTBxDCbqMavW8dyDsnKtitOMEqdKxdJFTvOdg64r11hJg2O2x8pmnQ86XnXcuq3Ox1CshEO5rVnE54Z8gzBR6BwHmAEvy3dHRx5STmfBwGMn8eXPKSUV8Q475EwhDD5TwByipJuDsp3toXiBfAGfQfhCw+Sgv398uU1r+EqbNvyu1L/jwzr56CVY+0WL7X5Pz5zNifPdIcOwHZi3LT770PMQjUV+eoOBxvv3J5/gt7y/2r49Jw7FUb8hePHexTbrD6D0Ms6LtIb7e/bA+CJIPpVlj2/2IV3PTYnVNm0+DMkpCnkuLAbW7mYqJo0+z4FzfQpefkcSJ+Iw8PgpSMRnAZP9Dx1Dojx8jC+qlIxcSEnPgeSMHNQtmnoqS4xh5kDfvQehw5Ll0GzsOHgQH9Dv7dIF7sQH67s6doQH+yXiXXsJJPG4ql9mLrSdvwhaTJoCrWbN5XYq2pNxTpIDTqTD0zNmwX3dY3mc+2Nj4Ymp06HfoePQ/rml3K/doiU8XmpmHjSfMIltmi0nT7UlU9k7LV3BfRIOHIUWE1WsotV3KrTBZ6+eW3fxDcI+ZlyXvXYl6RyQ34qx1k4+tpF+OjvoPFs8Br985x21G9GHqE0cSg56FiDG48sreomlZb/9ZEPfgSN48WZA0slMGIAcaHDACSUVTV9oZtixQf0wodx2hx9J6zB1s61jQ8UknbTGp8RlPx6Xe3zNpFOWdK+FzoWXnaTbTvP2x5em+pwm8Dm1zjHbsP2SfOdA5GEQPpz32bXXZt/dlozfvc9hZ9veA9Dv8AlIPHIyQLwoAjpWL6X31xL9/RxtK4bsZjyR4hKP0Piauu0Rw/0Ddme8phlvzMs2RdXW62Id43Wcc+1OGUzn3ERKDn1OiaT3xXPLVOf093/9q9qN6EPUJs7R//wviNu2A+K277SIei/d3rYTems7stdWHbcLX44dgPj9hy0eUFKxL9uOWNJt33/E0J0+t81tt3XX2H2xTWswY4kJal0h+ymbbps2M87NYJ/HsWLC8PmzzyVKbPN5RF2f194796idiE5EbeL8618AvXADe27aAj2QPTcjlc6kNjLQ3gq9VAzHYpsSKQ7vnr0Nxu100rLvY+q27uOIVTa6O1uxe/jiIrvlQ5vSyUfSig3QHIt8djz7rD52nLJ79e+tpctnHYfRVjYea8duPDdbA+dTnzcinis6X3xOle3QxYtqJ6ITUZs4BPopvR4bN0Hs+vUQuw6Jsvv6Dax3p7ay2W309TB9rK9jxm7cyBdFL7pItmyDXkgryUjfbtmUrwf50M5k3bLzxaX6mDa+IElnkq7bmMxbcWw1Ds9p9iM79UXd06fm6aHG60XS9ilJ8eTTfTVVTOwGPH98btbzueHzRedQn1OD+rwN2btX7UD0IqoTh/D2X/4CPfHC77Z6NXRbtcogth02pz/GoNtnt6n/mjXQfe1a6L4GuRaTjEltrVuMZa6Fbtq/ViUlxnXjvms5hu2qjxWracXYbXt8w6Z0PUc3dx+b2qZjLDsdS7c1eEx0XEjr2K3j7G4fuzpupdsxSEqmZTk56sxHN6I+cTRexeqzpbgYFpw+BQtPn0ZpkfRQtP3pLqmox5qvbei3xj3l6Et+jlH+henpzrEyqK1smmhfRPGmXY1BXMBS9zNJcUpS2x7bslnz43rS67F2JPl1m+dUuk0c97nMTCj56U/hck2NOtvRj89N4ggENxOSOAKBD0jiCAQ+IIkjEPiAJI5A4AOSOAKBD0jiCAQ+IIkjEPiAJI5A4AOSOAKBD0jiCAQ+IIkjEPiAJI5A4AOSOAKBD0jiCAQ+IIkjEPiAJI5A4AOSOAKBD0jiCAQ+IIkjEPiAJI5A4AOSOAKBD0jiCAQ+IIkjEPiAJI5A4AOSOAKBD0jiCAQ+IIkjEPiAJI5A4AOSOAKBD0jiCAQ+IIkjEPiAJI5A4AOSOAKBD0jiCAQ+IIkjEPiAJI5A4AOSOAKBD0jiCAQ+IIkjEPiAJI5A4AOSOAKBQCAIG6ToCAQCgSBskKIjEAgEgrBBio5AIBAIwgYpOgKBQCAIG6ToCAQCgSBskKIjEAgEgrBBio5AIBAIwgYpOgKBQCAIG6ToCAQCgSBskKIjEAgEgrBBio5AIBAIwgYpOgKBQCAIG6ToCAQCgSBskKIjEAgEgrBBio5AIBAIwgYpOgKBQCAIG6ToCAQCgSBskKIjEAgEgrBBio5AIBAIwgYpOgKBQCAIG6ToCAQCgSBskKIjEAgEgrBBio5AIBAIwgYpOgKBQCAIG6ToCAQCgSBskKIjEAgEgrBBio5AIBAIwgYpOgKBQCAIG6ToCAQCgSBskKIjEAgEgrBBio5AIBAIwgYpOgKBQCAIG6ToCAQCgSBskKIjEAgEgrBBio5AIBAIwgYpOgKBQCAIG6ToCAQCgSBskKIjEAgEgrBBio5AIBAIwgYpOgKBQCAIG6ToRDH+9a9/wS8/+AAyXnwRVj5/EcYWFsDggnwYlJ8HqXm5kJp7BpkDqTlnIIV4JrtepHjup5lHpPFyYBBKB3Eum2ab1lFAumEz+6C0xlaSSPOquSlmcKF1LBPOnoV1//ECZP3yl/DiH9+Hf+JxCwSCxgkpOlGGv129Cod/+hMYqm7MdIP2Khw2s7O87Teb9Z1HxaV62esaA/1ckKhQIZdcvAA/fvcd+FSKkEDQaCBFJ0rw/kcfweILF2BwUaF9A67zJk1sSBzK5Npi2Yc3/mwPXx2kcWsd28WgouSmGks/Fa363vfgT5cuqbMlEAg+K0jRiQKcffVVfmWvb7jmDZl1vAFrW8ibtb7hs/S4+YcoCPa45DfmsWn2c48RYsxQDBQlt6ydek2D8/NhNRafy9evqzMnEAjCDSk6EYxP//lPOP7zn+Er+Xy+qeqbcm1PDJYPqWJCFqG6SP2RnnN5+NxxQf1qiXWT/cha167HcI1FTz4jCwvgx++8o86iQCAIJ6ToRDDO/eY1GIw3UPOmGpLum6+he1H7veJq89VmD6IqHu612T63zaS7Xx3x7jUNzs+DF956Q51JgUAQLkjRiVC8/eGHMNjrE2e13Yg9bszmzbjexaIOOsZxzRnkQ7rXUNeTjqbnetWYpk3HueMH4fl79c9/VmdUIBCEA1J0IhTr/+MF/gO5fqvJvpl63bDdNmxTP74Ja59uu3Uk6e4bdq00xgzyebBBYxsM2Q/ntQuXuQbXeuhj2/MrK+Hyxx+rsyoQCG41pOhEIF7+4AMYU1hgfRy6njd2B6lPffq5Y3Q/ba/HGA0uKDim2ae+/YOejuqxNvrfJCo8Zf/7G3VmBQLBrYYUnQhExksvwuAi9bccurnWcoP1vGmr+Dpv6F5xei41r+Nmb/rctpvE+hahuqjXTU+LK773PFyST7QJBGGBFJ0IA90cV+FNkl6hu2+kdIN335TNomD7lM1qK39QcXC3LXrd9B02GsdjHXXS7BO0Fm+ac3jO5x4nxLj0oYI3//Y3dYYFAsGthBSdCMNbH34IYwrz+a01942WCkwQs4iZATp8dbRtu5cNYzMzgm1az0TdNR7d9B393PNR221z0x0Tqo+2hYp12fkc6q/ZUR/QsHVFrdN5T83JCdjpbU7SzwR07muMaccaum6zjcZU8Uwci/30VUVqLY54Q9prN+bW60/WPrIpacfRNUSSYvQcSpq63c/QTalptoPiaSw6P4ZNz2+1la7mpD1Z88L34AdvvwXXPvlEXf2CaIAUnQjDT955x3rKMW6YSRnpDg4MoZv0sjcoNt3D5tGua55Qumlz23Xby1cb64xPP43HdToglS1JHSvZko14O0bT7uPyG3Fk03aHNOhuJ9u6Ggup+5LN0lUM2wy/MY+zXyCebcrH58fw2VT+wHzGuAb1WEE2XJ/ub/uV3Y7Ftt2fmc4vUKgozSgphl/98Y8qCwSRDCk6EYbCX/2KXw1ygp4+BQNOnaw3Byq6bWb7Rnizxg7Vj+y1jek1f119QnHgSZRE0slm66fUmK5zr/26n0mOt6RmqDUFjUs8ecLQDbsiz+m20Tge9rpor8vV12E3faizT9lI19Qx9lps4vEoXR+vjrfGso7X0nXcSS5Ac7H4XKqpUdkgiET8PyUFEYJ9P/whvxrtf/wY8jgMYBmg2Q6lJ7raWnfbNLWt3jxxXMng/qHGrGsur3HMttte13gmHXG4dm7j2u3j0G2UA+xjOw4DSad4po5TuurP8Sb1GEirH5L62X0NG0p7HYaP26qPHa/sbmnHKeo+bFdx9lzaZkqk2c8+NmXjfti2x7Rt1thaDzDgd/ezdcNmxQd89EJrND7h/17+BhexkKITYVhRVckJmHj0iPAWs7+H7WaRxvYc/8jhYJvB2tYU5NNj1TKm7sPSiK9tHi864kP0r6+tLtJTz7KKcnniiVBI0YkwzC4s4KTud/gQJBw6CP0MutsOuuLr29ezD47FNNtaN6jjSQaNr/uodZl+1msZX8e6x7THoXhXH+13xHnQ237A0XbHmG3P/uoYa7PXNSa3QxyXF+0+brrmdMc42j7nSjR07Tell8+ta7rHYuK6BmAOvPbBByorBJEEKToRhtGnT0H8wQMQf2C/xf37DH0/JGjdtpl+Z6xD2nYVQ9LQ7XGVzm3tV2S7sjn8NIcmtd1+aptjudbEsR607NiPx8Z1ER0+g/ZaXNJNPYa5Bq/YWvoH9FB2PQfa3OMYbTtG60ryufKKQzrG1efFy08SyW1NV4w7VtPuo+LtWMNObbu/9oeyKybwegNtHWPrhkw8dhRefu89lRWCSIIUnQhDMr7S67tvb70ZT3LvHqcd22Rnn2pbNGMsesbptmGPV3Zbmn6i2c+I4ThjXqttjEG6pivGjGVqG5KkqdsxmnpM3Z+OVbVJMo1Y1pXfPYbps3Q1fwi/ex72kV3Had20mbFMy679eiyOsfu4+nqM6R4nSDds9lyO/q4+FKelV5yrbdpI2n5jPB1ntulp55fvvquyQhBJkKITYUjcvxf67N5167hrp7f9JrC3h63RkY5f08vntjGV3e33GifUGNru2ceSfe22Eattbpo+PWYtNhq7r922bI54m26b6oPsq3XtU/aAP7hPINaIt+O0L9iWgE/7v3xXfp4iEiFFJ8IQt30bxO3YDr3rIMW447RN20P5a7O5/fWx1eavT19Nt89NM6426jgzlnU8t0yl07lmnzrnWvYhv4t9jH5Bvp2WXc8Xt8OI8ein59K65Q/YiLQGy+e8HkLp3KY1GGNYxDbZSTekpr1WOgbTx32tdhyuzW6bdkMnSW2vNQWNafi4j5K9t221ffQU9Uv5TaSIhBSdCEPPzZug19YtDsaF0E3adkxchzRY1zihxvbDeo3lsUa/rG0+t4/abrJvy+ZAHOpsV2t0xBnUNjPWzTi0O/qa8yC9xq0X1RrpZq1tccbYNK/WuR1CMj3WZPcnn/I7+oRoaxvJ3oZu+siudcfcqJO9z57d8NIf/qCyQhBJkKITYeixcQMXHjd7edg0Q/lq61Mfmv1vdCyin2Mg8k1J64Zdt2vr6+CmjY623Y/sLvYiqWKCxjf8mhyj9s4Rr8Zz04zROo9JpDbFmG3t1z4lddth96KOQVIMjeUYQ9m4rX1kU9JN3dfTT+dBj6vHNPx2H+0zqI+x984dWHR+r7JCEEmQohNhiF23FnpsWB+amNBmO9bQg0ixrvg62247j+HymazPeKHmMOg4Dp6z7j43RI/xe7raDqp4xzrXrwvQsPE4Ptbf0z1WKNY2tu6vxgo6JrfNnM/rGOtBPZ49rjmmqRPred7jtm2Bl34vRScSIUUnwhC3fj10X7sGumPxiUVJpDbrZEPaftIVtd2O0e21Ad2mR6zW9Xxsw77sV7GOOKJht2NUf62bNkcbpfuYWLp0cz1sV21HrG4bdkcbpUn3vNpmxnRfs9q2a2of91XSjne1tV/bvPrr4zPjzJiQEtdm90Op+5h+h02R29TH6G/3MWMMm9kOmsvUKd4Vw7p7LUaMYw4jjvz01PPS22+rrBBEEqToRBgS8FUeJWC31assuQql0oNI9tUkVZy2ecUpvRu3tV3ZXH04xmzj2O4Ytpu6sRaLrj40ho7V8STV8VGbqWIsGm1zbGw7xlaszcaSSPNpUgyNR2vTfoO8NqKKsan9iuS3jkPNS7o5p7apGN2vK+qd0dcJb7IdscB3Qdlj1Urou2IZDFi2FAYveQ5GPbsQJi6YB9Pmp8EM5Jx5c2Bu2ixIQ85Gfca8NJgyfy6MXzSfY1MXPweJy5dBnxXLIRbH6oxjtsexO9H4a9ZAjL1WdXxqjQ4b0l472831ax/abF37jOPXdpNqDPNcOdeixkSdnn5efPstlRWCSIIUnQjDiJ3bMelWQszKFTeN3VzSzVD2ulhXP9NPum7Xd776xNU2ppevtjHd8XofqE160L7gjd3RVuyMcR2omKDsiQUkecmzWDjmwPJZkyFz7BD4WWofeGNALLyTGAN/ju8M/+jTEa71bgc1cU5eQ17t3R6uKF7u3QFJUusdbB/FEalPTVx7RWscsv+9b0f4U0Jn+APO+duBsfCfQxLg2PjhsGT2FBi3aB70xwIXi8fTEW/4HfHG38V9rF4McfyafN48dEcMnVdbD9jpKejFt6ToRCKk6EQYlmRkcDJ3xVe6QcRXsJ52Yf0Y4vzFKDvJLh52L3ZBX8fly6ETktqpzy6ANTPGQ8WoAfCLwb3gL/07wvWEZ6AmoS1c6dcOPlK8lIjs195qo068xHa0KZ3jlJ99GE/97P4uBuJUW/U1acUac7h8V/o9g+ttC9eQfxzYGX4ytDcUjkmG52ZNgn6LF0Fn+3jxnNRyXjyJ8V7n0jzvbDNi6InnxTffVFkhiCRI0Ykw5P3ov/iVn04+YcMZ42Ejdlm6hGWoYhJkXx6wUzHqgDfdnksXw9y0KZA1MRVeH9IVria1YV5JaguXkZeSNZ/xkG4a/iTdVjYai21mnCvGJMZ+ZNs9/NrmNQ/Kj8wYQ15G0rFdU8f48rBYOD5pMExbMIPPc0c6Z+q8uc+7Pp903okNOe9SdCIXUnQiDJRolHCOJBTeFNLNrb43vs7LlnGRSVq8ELbNHAmvjYqBS0NaQ82gVnBlcGu4NLiNk0Nc7Qbysup/2WX3pGuuevUhYj87tqHrdcVfxXNA5+LvQ9rCL0bHwoo54/CJaCG0X77Cflp0F/lQ596LUnQiF1J0Igy/eOMNKTqfAflJZtly6LZsCTw3dwL8Ynx3uDSyFdQMf4rlZeKIVnBpxNNIkki0efNpjidd9+O27mf0Z79iUFvFWBLn9fCxru06Xs1v+njdStf2gC8gTbuOc/vMGNZV/+sjnoK/j2wN35/UG6YvmMaFm96S8zrfXjSLkhSdyIUUnQjD5+1Jx/wbSrho3tw64Y0xduli2Dx3JLw5sQNcH/MEXB77FFwehyQ59klX27AZvORqe8W4eQljPPs55roBuo/BRZrf0r3WgQx5zKH0AK8ga9D3yqQusHj+BD7P9Hcwcx+I+q033aa9IUrRiVxI0Ykw3LInHY+E/zySbmhU6OhV+MxFU+C1aR3h+sQWcGVSS7g8CQtObZzsYauDVybhTdnD7s26Yg2/vZYncQ6tN4A+jsUvr+G5rcFz/F/Tu8H4RdOg5/r1kLR3L4zOSIdpxcUw49w5GJuVCQnbtkLXpdY+SdGJXEjRiTD4LTrmq3dfVK84uyxZDJ0VSdevRPnVqKHb9IinOD3uDa/LTR/j6TVQoYlZtgR2LxgCf5/+BNRMbw6Xp7eweaU2fZolNbXPi4G4lkzT7oyzfOaYZrzb526b0qSOdbN2X/C8zrbTb1LHesmaqU3hw5lPwfc2TYTV+emQVlkJcyqrYHZFRRDnoG8qFqFYvP7p/3+k6EQmpOhEGLyKDt00Q92863tTNwsFtSmx47dsgUGHDsGo9NMwLjsbJuXn8yvPWWVlfAOwWAVzqqogTZF0m+RTcbPKy7nvpLx8HCsLRp0+DYPpVyzx1WuPNas91xAu6iebI4uS4dKc5nBtdlO4MrsZXJnjItlC0Yxx93FLk2as2x8q3qVfVu3LagwtHTTiNXU/2+eOM6WX7tXWNleb51L2mtmPw0dpT0DVjumwrOgMTK86j0Wl0igw5YbuJF1LE3Nzgf4x+BdSdCISUnQiDDfr7TV66ohZsQwStm7lm/+EnDNcGALFxLwJ3Fq655xcWAjDjx+H/rt2cvHjpyRViIKLaMOfbEx2XLYcFi4ZD39d0BJqFjwOV+ZjwVlQD1KcpmG/auih2cQlFfVY7jWYdqbqZ7eRdrwxph3nmicUHeO46PaptvN4XevSOspr8x+DSwubw/ldk2FpcS7MwEIzy1Fo6sdZSqbiNfuz3/1OZYUgkiBFJ8LgLjr1epLhp4fF/ESRvG8fTCkq5MTVTyJmUpvUCf5ZUq9xRmkpjMlI5yej7itXcCHyPNYQdJ8nerqhT6JVL4mFT577Llx57nG4qkh6gI85fFe5bdkCMkDL744NxF1d7OxHMTzn4kC/QB/ls+NVDI/hpo616OxntQN+99iWrv2BOLOfmtulu2NNef3ZR+Hy4ibwox3DYPnZLCw01TCrluutvqQn6vH4tCPfvRaZkKITYajv22v6bSp6khl/5gzfuGsrMJFEeuuOnsrGZmXxW4D6eM3jr42d8Olm4LJ58MqKNvDx8u/A1RXfDXC54opHLbJuUPuWPwpXkFac4WObarPNGEP7g8ZU47DfoOlnG8UZUq3D1nU8xxg2O0bbtU79TUl2pXMM9dN9ya7b2mbY1RzXlz+C5+W78NOdqbCu8CTMwBcNN6PQmKTreHpZKbz6xz+qrBBEEqToRBjqenuN3jbru2kjjFOFxitpbxVv5MnoRvpSEZp69iwMOnzIfjvO/LCCSSo4Scvnw69Xt4JP1jwMV9c8gsTCw1LT3dY2bQ/l1zJUnNn2iiFdU9vMmID9WlCMpmn/Tog4Z4yXz+qnfVrXbWfc9dUPw+U1j8IP9w+HDYXHsdBUe+5Twxj67zrEuRcvwm//+leVFYJIghSdCEOoJx16pT9w926YWVrKN2GvRP08kAstkv7YnLhrJ3RbvpwLsT5X9LbaD9d2gI83PgRXN36beU3J2kgxZpy7j+mvzee2e8oNgbajH9mRDpsH2V9LnGm3dSOepEkda8dveBg+Xv8A/GXrE3D+6ARYXJKHhabhf6OZU+llr73YaM57/nn46XvvqawQRBKk6EQY3EWHik3ijh1YbKxPlHklaKTQ79NObf34rbiyMn4rLm7rNli9diTUbHkAPt76IFzb9lC9eNXDdmv4sIctwKtbve03lSHm+GTrN9H3Lfjt/hg4dmYdzCs7B9Ox0Dg/dXazGboAzb1wAS5iLggiD1J0Igy66FCx6b5yJf/TXLT8rSYcpLd+0ipKYXfBDvjeqVHwt72Pw8e7vsGs2fUAXNuFxSgUd1uyxm2/SaxzXDW/p930hYojap9XjLLRebi+65t4Tr4J7+9/Cgqy5sGKkkwuMnU/zdT1pFK/J5m64tLOX4Bzv/6VygpBJEGKToSBig79iFWvdWtheknx56Pg3KJjpBvozIoqLkTPluZDVu5z8NNT/eH/Dj0Gn+y7Dz7e/3W4dgBf4SNrDjwANfuxKHFbSdWuUdRx5KdYW7djNQNxgfEsWnbl36/6oTTH1X2seZWdJbY5XpH9enxzHt1fjYHjf7L/Prh84FvwyokekJszHxaX0ltm1Xx+vM5dw1jfQlMfWmPNqT4PuT+qUFkhiCRI0Ykw/ByLTq+NG2BKYWFQwTHfZrqRP8zfCD+reT0ZsliFvglSIbJe0VfBwvIi2Hl2F/wgazC8dbIdfHT0Yfj0yL3Ie+D6kfuh5gg+HR35uovaRlLTtAf0a662Uyf5DSPG7XPb9HhefayY60hr/ffC3489Ar891QlKcqbBmpKTMBef/ui4b0aR8f5bDbGhxSd0PBWdrB9VqqwQRBKk6EQYfv766zAqIx3Sqm/GJ4QazkZVVOpDLDzea27YDZCK0LTKizCjohoWl+XBtuK9kFmIT0ZnEuCPp5vDRycfhJqT98EnJ++GT0/cDZ+cuAc+PnkvXD/5NbY7iQUryGbxusMXOk5Tx9M8NN+nJ+9B3s361ZNfh/87/Si8mhUDBfmzYWfxTlhSlsPHML3yAhdYr2P1ZsPOV6DwePVraPEJZtr585D58ssqKwSRBCk6EYZfv/8+TKdPqN2Et5zCWUDCMdfNnaP+N0b9Np1+UphfXgzrSo/BoeJ1kFM0D8oLJ8IP81Pg1zkx8F52c/gw6yG4lPVNuJp5P1zPvBf+mflV+BRJ0uJd3NY2ktcz74Frmfdxvw+zvo3jtIBXcrvD9/OHQFnhZMguWgD7SrbCsrIsSKsog+kV57m40Npu/bl3n6sbKSr16zsXi07Bq6+qrBBEEqToRBhe/uP7MKe66pb9ncPkHA9bdLHhN0c/58S68au/H2EhmKEKgpszPegVp/vTeLU/rejju5EicCvobz3m23b06bWS3/xGZYUgkiBFJ8JQ9frrnHBmMgqFnzfSP4c+L1/4GZGQohNhqJaiIxTyP4f+7P33VVYIIglSdCIM0Vx05P+NhPUl5cD//uUvKisEkQQpOhGGehcduYELo5T04mRGeRm8+oF84WckQopOhEH+piP8vJOLThkWHfmW6YiEFJ0Ig/xNR/h5pxSdyIYUnQiDFB3h551SdCIbUnQiDFJ0hJ93StGJbEjRiTBE4t906CZBPzFMpPaMc+dgalERTC0sDBDb04qLYXpJCf8Ugd2nuppJbfe4mub4xIb8nhDF8hwo6ddIaX7H2kg/exam49r4t4qMddU1j7mmG2WouXj9vmidV9JrO7eNkbReKTqRCyk6EYZIetKhG9qww4ehxcgR8JXWreD25s188TbkU+PGclFwfyqPvg7l6Qnj4bamTTj23x77LjyaNJB9oW6mdLOdXFAAPZYuhW/2jIUvPtHSmqtFc8e8QWwR0L+A89E8kwvygwoCjT/61Cn44pNPOPv7JM31ta5dcMyTPDbNQXNOzs+H+9B+W7Omnv3qIh33fTFdofWkSZC0YwefX/OcNdpvpJCiE9GQohNhiIQnHSo2E7LPwIO94/iGyTd1vKE/0Ksn9Fy2FIYdOQLjs7Jgcl4ef1v2FCwAE3NyYFxmJgw/ehQG7tgO3Z5dBE2HDOExvvpMW75J9tu4Eea5jp2KTteFC+GOli14Hio+T4weBfMuXnTEEemGPSY9nddBN2rqcweui+SDcXEQs3ABDD10CMZnZ8MUvKHT2ibl5fK6RhzDdW3fDu1nzoBvJ/aDu9u3h397/DFI2b2bv3zSMQ8ffzbc07GDva5/xwLUKS0Nknbu5HGISUqa7LdpE8StXMmxzYYPg4cT4uH+bjE8TsyihfZxUXGYhk9gjyQm2gWEZMtRI6H3qlUQt2JFEHvRr6jOn8cxD8X3hbs7tOc++jzcjueEXiBMLSqs8ynus6Q86UQ2pOhEGKrfeANm481zOibdjPIKmIlJGGAlzHTYzDZ995cptW7Yy4muWHM8cyzHuEa80ttMmWzfDP+tyeN8E6Wvo7f66jgr1knyB/RZeIOZc/4CzKysgol5+XyzoS+w1P45eMPv4io6LbHopOHNOTCWNUaftWvgDozhWCIWgh7Ll+ErZ7zBVtF3mRlzq372uuw1WXaal/RJWDCdfnxSwLHGYdG5WxUd4p1YOIdj4Zp7nt4qpLcPQ5GeNohWOw31tOoKLDb0dhg9fSh7VQVMLy6CR/r3CxQdLBzJu3bA/IvnVX9rrDQ1VqBtcd4FenutHLpiIaKiqNdKRX7saXqqoht8oJ+lB0jfoUZ7YX2vnKZ1Dtzny6b7vLp9mg6/0tFuXfflMPVcqRSdCIUUnQjDeSw60zERJ5ec48SbjjfwaS562dz2umKmGrZpZZZdU9tsv80KlvTjXzHPPmc/5dCN7J5OnSBp9x6YVX0BpqN/On0rM5LizXHdsi7OxPG6LHAWnRZYdGZdeD4QU3Uehh49Dv/+9FP2eu5s2xYGHznG/c3xguh5nN7Ua6bjH511xn7S4fnwRj7k6DE+fkc/3MsZ6qY6WxeUylKYW3kO5lWVIkmWKKn1EphfXQqzivNcRacZDNq1FRY9j0WqEuNsYj9NGkNLGgv9Cy9WQu8VS+xzQ0+B3xmQiOvBObCwzETOwLXWd09M+unDVOfdvB6m4PU+ufgcTCkphYlnS+DXUnQiElJ0IgwX3ngTJpeWw4SiYiYl32RM0CnIyWUVTEvXNku66bZT293HbQvQmifYp2x4g5iEa2w7axa/ZUNv3Vg3xeasf+mpJ/lvFN9JSoJWU6ZAt2XLIX7zVhiwey8MwuIw+kwuHiPebLBYTKs871pT4PiIFNNxvrPoNB81Gqaff57jmBXV0HradPvm/AV88qJ5zbHdnFJezX7NqYau29o2FcfX6yJSe2TmGceTzpew4HV5bjEfY+KOXdAfSVKT2sR+23ZAr7Ub4JmZs/C45uNY59Wa9N5apBvxhMIifqvPLDoDd+7Ap7Bq/o99zenIaWXl2MfiVHxxMFWtl4+1rArG5hVyYaS10nj3dO4EqYeO8PFZcYHj0+sJ9HdS26y40DRjnPGBuTQnnD3nuObH4bHTz3wIIg9SdCIMF998E8YXl8KY/CIYixyTXwhjCopgfEk5TDxXARNLK2ACSUXW0ca64atNat2ktpt+L123mXgzm4jFI/nQMWiDN9Gv94jlG9u/Y9G5vXlT6w/gRNTphsl/V0CSnQoD3QC/2q4dfCc5CeLxZsxj4njmHJPwptxh/oJA0WlGRWcUTKm6yH6OxXU8Nngwj803Z7ypdlr4LEytet4ey1z7ZCw4MUuXwZdbtYK72rerlXe2bQNPT56CfarsMSbjfMMysuEu42861rx4zFgU6yQe/23NmkHKoaMwCccy12hLPA9j8s/CQ0bRofOXsH0nHvsFOzYQH9Ad42gdrx8617ReGof2KX77LizYF4L6mW03vXzapvuaMW7dbGuOKyzh691iIYzF631UXgG8IkUnIiFFJ8Lw/BtvwejCYhiZkwcjz+TBCCTJkTn5MKYIXwEWl8NYJElLL7PblixzxGi/O47apI/Dm5Hl03T289IDtgD1WOPpRkLFCIvF2LOlMCK3AAadzIDEPQeg5/qN0B6fWpqOHA13d+rENz990yZJxar35m0wHm+4PB5yPI7Vbt58R9FpOmKUNb5ez7lKaDl+gn1z/kKTx6DV9BkYc0HFGMdQUoHntwSaDB/BTyffjOsFjyQlw6OpgyympNpPBPx3IRyv03NL8Jiq7bHG43xDTmc5nnS+3Lo19Nu9n9dOxz0GSdLUTdtYfGERWFfgHNo6rnNkbiE81M/5N50+W3fAhHI69kA/PY7V30PHsYbik9lX2gaedO7t0hkGHjzKe2XFufu6x9Z6sM8Zp2M0zX7B9tFYWOna5uscr3lL5sNwlL96T4pOJEKKToThe2++DSPzCmFoVg4MQ5IcmqnlGRienQej8KY5Gm9cNotIlnnYPNqm3a1rum2h2oqjQsTZdpO8zjIYQzeec1XQeclyfjuObvD0NERv+wzOyMEbdBn3H4s3+GfS5jmKTpMRI7EYVdvjj8Wbau+tOx1PBPd07gxJh09gfywy9tzGGvCmNwaLJM1DOhP18fgU9GgqPjXh04guOh0XPQdjsZjo/tQv9VQG3N0hUHS+gk9E/Q8c5vXac9nzGdJLd8egHIPrGZ5TAN+iooPnRReduC3bYRwWCorj43f1IzrsyLGlVVyE6bx88QnrbzrfxkI7mm76KsbuZ8hQtP2uuUPZTRlY2zksLPl4XZ/h69y+1pm5MASv+V+9957KCkEkQYpOhOGFN9+CoVhYBp3OhMHpWShNZtpyMCbl8LxiGJFfAiMKkCiHk1Qcru2mjaSyk1/HsFTt4fnFllTx2meOMyynELquXA2D0nNg1NlyGFmEN0gVS/11HPclybo1rrYTR5dUQk98svlym9Z447b+HkQfSEg9lQUjCs9x7Cgcu82cuY6i8zg+pYzGmzvPg+OMLMAbWN5ZaD7O+n8eLjwYf2e7Z6DPjj28xhEYo+OtNQSvc3RxBcTv2o9PMB3Vjd6as/3CZ2EU3qD5HGHcyMJSSD6eDne5ik7C3oM8lx7PHp+kPW+wbsWf4/M4DI+D23j8QzLz4FsJCXbRuQNlz01beZ0U46RxfpG0xtFYjJNPZsJ3hwxzPC3d3akjpJzK5DkdazGktS41JulkI7+S7mNwtx3SFT889ywMST/jeV1bMpvly+9K0YlESNGJMPwHPukMSs+G5BOnAzxuySQlk0+csnRkKt48BmfjK8bcIhiSQ8SnJNSHsh6Q2m7pVtum0VdzqFtyDLVxTLxpPDFlKnzh8e/yDfeeLl3g4QED4YmJk6HDs0ugx8atEL/vEAw4ehKSsYCk4E2E5MBjp6Dv7v3QdfU6eHLKNLive6z9NHEH3hS/9PTTXISG4c1Or5NuUq1mpxlFpyk8NnQ43pTLrBg61lzrGGhd7RYu4o9KW6/qrace+sdVemXfdt4CHH87JB46BgNwLbS+vrsPQOflq6DZmHF8HPR3Gb0mXXSemb+Ib7b2OcBi3//ISSw67e110UeSm44eA23wqaw1rrc1FkqWs1GybrQNtpoxC5ri3A/Ex/Pben127cPjt+ZKwevgwfgE+1io+HwndZA1B43pGDcNWs2cBS0nToJHBw2Gr/fsqf62pgoWSVxrywmTresFi1tgf+k80h5be01t67rRPq1b+2+fdxVjXmMBieR+gRg6pkEZZ+xrOklf36pt6yfSsViexqLzrsoKQSRBik6E4Qdv/R6STqbDgCMnbA48SvI4DDiMVLb+h9FOktuWPQlf1aZm5sKgrHzFPGwjUQ4iqXXDbrdtqn6hiP3oZhKHTxB3d+ps/Vc+3gzp5maSbpShaMZ9FZ9GHh0yFHpgMRiUXYDM53n0GoZgIXl8xEi4rcnjHP+Fx77LbznZx0nHgX20zhLb3dZthIeTk+FLTz1V63qsdVgfdPhGXBx0XbUWHk5KUvNZHwxoicWUbtL6HAw5Q8e/13pLEIugPhYexxfxuLCAP5KSCsn0Kh/XP/hMARbFU/xhhdtxDYE56prHiqEiQ39nehDP1ZPTZ2Ix24/rLuSCY59fPoeWrs83nT++Nvj6sPw63tbpPLPfOO+a3M7l/roPMQWfbAZikbeu4eN83dL1S9c263yN6+v9JPOX77yjskIQSZCiE2H4IRadAcdOQr8Dh5FHbJl4UOuhmXhQ6QeP8it5KkLJp/GV5akzkIQ3s6RTSJJuHUk3O6cP++DTiWVT/Q3SuCkZOXxzSUaZjDcVslGfgTgv80QGygwYwDLTlgNPZlnrSs/hMaive3ybtAZ68sPYJI6z5hmIdlqzXre5ftbxmHl8Wh/1pXXh/LwGLXFtZKf5UzJyMTbX6k/HYhP78nj6XFjk+Y04XptuqzWyHSWv2fbj8ZJNxyo7k8dGmzGfHof7qXiznylt4jmlY6Fjt88vnkNrPEPac1g2L3Jf0l3H7+5Dbdumrjc+TjzPfO3ud16r/fS1yjr6zRjUEw8flaIToZCiE2H46R/egfi9B6Dvnv2QsHe/rcdroo3bym7S8qt4kjqWkhlfYSZiIep/PB36HzuNkqh01R6g9AF2DEqveK2bMmhsgzxmsGQd+1g6jUO6Ja1xXDrLAK3+SD0u26w4fSy6X+CYTKLNsCcqaffVpFhbpz6BttVHrVvZTJ1jHP1N3RqL145tLW0fS0VbV/OztM6d7TdjVNs+H3bMKbsP+fhYeRxrPOfYho3jdD9vXc9J7HfoGF+DdE3a16d9beq24dOSrvl9ByF+9154VT5IEJGQohNh+PDqNZibW8AJ2HvH7gB3GlLrpl2xz849St8ViDX69EHZZ9deTuwEfEWZgDcHi8fxRnGcdS3J5mwHYuOVZN/BQKz2003HbuOTF8UFjxM8l9Om7VY7nubRtP1W29FH+W0b9zka5HfSnNNsu+0W+7nGoLn4nHiOHaDXsbEN+2kZOhbPgekzj8m067Y676bfpOUL+J1tpy+e5uL5AjaiOT5dU3RtxRnXYxxdh0abqa7F3nStGtem9sXvOwDP5eXDpatXVVYIIglSdCIQv/ngTzBo/0GIo/9e37LN4tbtShrEdpxtN6SXblLZeqo2S5wrjgvSPui9ex/0wVelffa46LZ5xRB3O9t99+LNSOvuNr36Ndo8Zj3moXG01KQ4Go9jSO7ejzrRsKtYHd/HnFvFmuRYGteQPI8pvUhje9h1vFu6dQe9xnLbaC2Gjc6p1aYnCGM+x7kPPu/OMQK620aSrhMqMOa1RNelrSPt65N96nq0acXbforfvhMG49POW3/6k8oGQaRBik6E4q9XrsCEY8eh5+Yt0GPDpmBu1NxoyQ0bIda0Y1vrsbYfbSrG0q0Y1jl2c8COJD0WbT02bcZ1bMUbBBbBbTv5xtAL2Xv7LmzvwuKINkXLjzZFalOsLbVNxVF/22bGab/yWbrls+3IgD1gs+NoLEVeM+nk1xJp96d1bKU+yu7ux7rqq2N0W42h20FzaZv2s0/FsE/3C8Q7qPuyJJs1t57HXAfbaX28RsuvfWYM+5lmf0vntrJZuhoDi0KPjXg9qutJXz9BVNcO6T3xetN64DoLjif22roVJh8/Dv/Aa18QuZCiE+H4+VtvwcgDBzkpu69dy+y2Zk2Aq9dA9zUBu63r9upAPPk4nsZB2U21zTE4hmPV+MS1qq9qO+LWrrO4jrgBeqzHGwiSCxbfcNzU9oDsjrRuPIE4uhmxpDbpqq37xK7foPyBefRNLBBHbYq1xifJfV0xHMdSxWm7mpeLsd3H1d+0axuNo+16Tsc5oWMOxOp5An6LVozuFxiTzpc7zvKhnc+L7qNiHGOTxBcSaOPzrs5jwIdrw32MXbee95WvEdpnuj6Y6howZKzyUSy1LRrXEV9rgT6WjrHqOopdvx5G7tsPL+G1Loh8SNGJEnz86adQ9dJLsPjMGei9nm4GlMyrIWbVKuRKiFmJRNlt9SroxjZNtDmk5bd1jNe2gKSxdFygvxmv/d2VLdDfirPm07qKNeeiPrh+7uvQ6ZhIR/INinR1o+IYg+wL0LqpkU6xWkfq8TR1HNMa2+6vYmIcsR5zK9pxao2ONWE74LfaWvL6tE3Z7TWzLbCeGG3j+EAfc726D4+jpJ7ba+2BPXJK3h/aB25bkveYGRzPdoy3xlM2uz+NF6AVi+vBFzG9162FZzMz4eLLL8P1Tz5RV7kgGiBFRyAQCARhgxQdgUAgEIQNUnQEAoFAEDZI0REIBAJB2CBFRyAQCARhgxQdgUAgEIQNUnQEAoFAEDZI0REIBAJB2CBFRyAQCARhgxQdgUAgEIQNUnQEAoFAEDZI0REIBAJB2CBFRyAQCARhgxQdgUAgEIQNUnQEAoFAEDZI0REIBAJB2CBFRyAQCARhgxQdgUAgEIQNUnQEAoFAEDZI0REIBAJB2CBFRyAQCARhgxQdgUAgEIQNUnQEAoFAEDZI0REIBAJB2CBFRyAQCARhgxQdgUAgEIQNUnQEAoFAEDZI0REIBAJB2CBFRyAQCARhgxQdgUAgEIQNUnQEAoFAEDZI0REIBAJB2CBFRyAQCARhgxQdgUAgEIQNUnQEAoFAEDZI0REIBAJB2CBFRyAQCARhgxQdgUAgEIQNUnQEAoFAEDZI0REIBAJB2CBFRyAQCARhAsD/ByMULhu7lHJyAAAAAElFTkSuQmCC", "SGED", "00.000.000-0", "123456", true, "(00) 00000-0000" },
                    { 2, "Secretário Geral", "000.000.000-00", "admin@gmail.com", 2, "data:application/octet-stream;base64,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", "Secretário Geral", "00.000.000-0", "987654", true, "(00) 00000-0000" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bairro_IdCidade",
                table: "bairro",
                column: "IdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_cidade_IdEstado",
                table: "cidade",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_etapa_IdTipoProcesso",
                table: "etapa",
                column: "IdTipoProcesso");

            migrationBuilder.CreateIndex(
                name: "IX_imovel_IdContribuinte",
                table: "imovel",
                column: "IdContribuinte");

            migrationBuilder.CreateIndex(
                name: "IX_imovel_IdLogradouro",
                table: "imovel",
                column: "IdLogradouro");

            migrationBuilder.CreateIndex(
                name: "IX_imovel_IdOcupacaoAtual",
                table: "imovel",
                column: "IdOcupacaoAtual");

            migrationBuilder.CreateIndex(
                name: "IX_imovel_IdProprietario",
                table: "imovel",
                column: "IdProprietario");

            migrationBuilder.CreateIndex(
                name: "IX_imovel_IdTopografia",
                table: "imovel",
                column: "IdTopografia");

            migrationBuilder.CreateIndex(
                name: "IX_imovel_IdUso",
                table: "imovel",
                column: "IdUso");

            migrationBuilder.CreateIndex(
                name: "IX_infraestrutura_IdTipoInfraestrutura",
                table: "infraestrutura",
                column: "IdTipoInfraestrutura");

            migrationBuilder.CreateIndex(
                name: "IX_instalacao_IdEngenheiro",
                table: "instalacao",
                column: "IdEngenheiro");

            migrationBuilder.CreateIndex(
                name: "IX_instalacao_IdImovel",
                table: "instalacao",
                column: "IdImovel");

            migrationBuilder.CreateIndex(
                name: "IX_instalacao_IdInfraestrutura",
                table: "instalacao",
                column: "IdInfraestrutura");

            migrationBuilder.CreateIndex(
                name: "IX_logradouro_IdBairro",
                table: "logradouro",
                column: "IdBairro");

            migrationBuilder.CreateIndex(
                name: "IX_logradouro_IdTipoLogradouro",
                table: "logradouro",
                column: "IdTipoLogradouro");

            migrationBuilder.CreateIndex(
                name: "IX_sessao_IdUsuario",
                table: "sessao",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_tipodocumentoetapa_IdEtapa",
                table: "tipodocumentoetapa",
                column: "IdEtapa");

            migrationBuilder.CreateIndex(
                name: "IX_tipodocumentoetapa_IdTipoDocumento",
                table: "tipodocumentoetapa",
                column: "IdTipoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_IdTipoUsuario",
                table: "usuario",
                column: "IdTipoUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fiscal");

            migrationBuilder.DropTable(
                name: "instalacao");

            migrationBuilder.DropTable(
                name: "sessao");

            migrationBuilder.DropTable(
                name: "tipodocumentoetapa");

            migrationBuilder.DropTable(
                name: "engenheiro");

            migrationBuilder.DropTable(
                name: "imovel");

            migrationBuilder.DropTable(
                name: "infraestrutura");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "etapa");

            migrationBuilder.DropTable(
                name: "tipodocumento");

            migrationBuilder.DropTable(
                name: "logradouro");

            migrationBuilder.DropTable(
                name: "municipe");

            migrationBuilder.DropTable(
                name: "ocupacaoatual");

            migrationBuilder.DropTable(
                name: "tipouso");

            migrationBuilder.DropTable(
                name: "topografia");

            migrationBuilder.DropTable(
                name: "tipoinfraestrutura");

            migrationBuilder.DropTable(
                name: "tipousuario");

            migrationBuilder.DropTable(
                name: "tipoprocesso");

            migrationBuilder.DropTable(
                name: "bairro");

            migrationBuilder.DropTable(
                name: "tipologradouro");

            migrationBuilder.DropTable(
                name: "cidade");

            migrationBuilder.DropTable(
                name: "estado");
        }
    }
}

﻿// <auto-generated />
using System;
using Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(PortalDoColaboradorDataContext))]
    [Migration("20180919111304_comunicado-novos-campos")]
    partial class comunicadonovoscampos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Calendario", b =>
                {
                    b.Property<Guid>("IdCalendario")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(5000)")
                        .HasMaxLength(5000);

                    b.Property<Guid?>("IdTema");

                    b.Property<string>("Identificador")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Local")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("IdCalendario");

                    b.HasIndex("IdTema");

                    b.ToTable("Calendario");
                });

            modelBuilder.Entity("Domain.Entities.Comunicado", b =>
                {
                    b.Property<Guid>("IdComunicado")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime");

                    b.Property<bool?>("DestinatarioDex");

                    b.Property<bool?>("DestinatarioDexCoordenador");

                    b.Property<bool?>("DestinatarioUnidade");

                    b.Property<bool?>("DestinatarioUnidadeDiretor");

                    b.Property<bool?>("DestinatarioUnidadeSupervisor");

                    b.HasKey("IdComunicado");

                    b.ToTable("Comunicado");
                });

            modelBuilder.Entity("Domain.Entities.ComunicadoVersao", b =>
                {
                    b.Property<Guid>("IdComunicadoVersao")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Assunto")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<Guid>("IdComunicado");

                    b.Property<Guid?>("IdTema");

                    b.Property<Guid>("IdTemplate");

                    b.Property<int>("Versao");

                    b.HasKey("IdComunicadoVersao");

                    b.HasIndex("IdComunicado");

                    b.HasIndex("IdTema");

                    b.HasIndex("IdTemplate");

                    b.ToTable("ComunicadoVersao");
                });

            modelBuilder.Entity("Domain.Entities.ComunicadoVersaoLog", b =>
                {
                    b.Property<Guid>("IdComunicadoVersaoLog")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataLeitura")
                        .HasColumnType("datetime");

                    b.Property<Guid>("IdComunicadoVersao");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(50);

                    b.HasKey("IdComunicadoVersaoLog");

                    b.HasIndex("IdComunicadoVersao");

                    b.ToTable("ComunicadoVersaoLog");
                });

            modelBuilder.Entity("Domain.Entities.ContatoDiex", b =>
                {
                    b.Property<Guid>("IdContatoDiex")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Area")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataMensagem")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataResposta")
                        .HasColumnType("datetime");

                    b.Property<Guid>("IdAssunto");

                    b.Property<Guid>("IdSituacao");

                    b.Property<string>("LoginRemetente")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LoginResposta")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Origem")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Resposta")
                        .HasColumnType("varchar(MAX)")
                        .HasMaxLength(500);

                    b.HasKey("IdContatoDiex");

                    b.HasIndex("IdAssunto");

                    b.HasIndex("IdSituacao");

                    b.ToTable("ContatoDiex");
                });

            modelBuilder.Entity("Domain.Entities.Indicador", b =>
                {
                    b.Property<Guid>("IdIndicador")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("IdTipoIndicador");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdIndicador");

                    b.HasIndex("IdTipoIndicador");

                    b.ToTable("Indicador");
                });

            modelBuilder.Entity("Domain.Entities.Publicacao", b =>
                {
                    b.Property<Guid>("IdPublicacao")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<byte[]>("Binario");

                    b.Property<string>("Chamada")
                        .HasColumnType("varchar(5000)")
                        .HasMaxLength(5000);

                    b.Property<string>("Conteudo")
                        .HasColumnType("varchar(MAX)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataPublicacao")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("IdTema");

                    b.Property<Guid>("IdTipoDeConteudo");

                    b.Property<string>("Identificador")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<byte[]>("ImagemCapa");

                    b.Property<string>("Tags")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("IdPublicacao");

                    b.HasIndex("IdTema");

                    b.HasIndex("IdTipoDeConteudo");

                    b.ToTable("Publicacao");
                });

            modelBuilder.Entity("Domain.Entities.Tema", b =>
                {
                    b.Property<Guid>("IdTema")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(MAX)");

                    b.Property<byte[]>("Imagem");

                    b.Property<string>("Tags")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdTema");

                    b.ToTable("Tema");
                });

            modelBuilder.Entity("Domain.Entities.TemaRelacionamento", b =>
                {
                    b.Property<Guid>("IdTemaRelacionamento")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("IdArea");

                    b.Property<Guid?>("IdDocumento");

                    b.Property<Guid?>("IdProjeto");

                    b.Property<Guid?>("IdSistema");

                    b.Property<Guid>("IdTema");

                    b.HasKey("IdTemaRelacionamento");

                    b.HasIndex("IdTema");

                    b.ToTable("TemaRelacionamento");
                });

            modelBuilder.Entity("Domain.Entities.TipoIndicador", b =>
                {
                    b.Property<Guid>("IdTipoIndicador")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdTipoIndicador");

                    b.ToTable("TipoIndicador");
                });

            modelBuilder.Entity("Domain.Entities.Calendario", b =>
                {
                    b.HasOne("Domain.Entities.Tema", "Tema")
                        .WithMany("Calendarios")
                        .HasForeignKey("IdTema");
                });

            modelBuilder.Entity("Domain.Entities.ComunicadoVersao", b =>
                {
                    b.HasOne("Domain.Entities.Comunicado", "Comunicado")
                        .WithMany("Versoes")
                        .HasForeignKey("IdComunicado")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Tema", "Tema")
                        .WithMany("Comunicados")
                        .HasForeignKey("IdTema");

                    b.HasOne("Domain.Entities.Indicador", "Template")
                        .WithMany("ComunicadosTemplate")
                        .HasForeignKey("IdTemplate")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.ComunicadoVersaoLog", b =>
                {
                    b.HasOne("Domain.Entities.ComunicadoVersao", "ComunicadoVersao")
                        .WithMany("Logs")
                        .HasForeignKey("IdComunicadoVersao")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.ContatoDiex", b =>
                {
                    b.HasOne("Domain.Entities.Indicador", "Assunto")
                        .WithMany("ContatosDiexAssunto")
                        .HasForeignKey("IdAssunto")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Indicador", "Situacao")
                        .WithMany("ContatosDiexSituacao")
                        .HasForeignKey("IdSituacao")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Indicador", b =>
                {
                    b.HasOne("Domain.Entities.TipoIndicador", "TipoIndicador")
                        .WithMany("Indicadores")
                        .HasForeignKey("IdTipoIndicador")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.Publicacao", b =>
                {
                    b.HasOne("Domain.Entities.Tema", "Tema")
                        .WithMany("Publicacoes")
                        .HasForeignKey("IdTema");

                    b.HasOne("Domain.Entities.Indicador", "TipoDeConteudo")
                        .WithMany("PublicacoesTipoConteudo")
                        .HasForeignKey("IdTipoDeConteudo")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.TemaRelacionamento", b =>
                {
                    b.HasOne("Domain.Entities.Tema", "Tema")
                        .WithMany("Relacionamentos")
                        .HasForeignKey("IdTema")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

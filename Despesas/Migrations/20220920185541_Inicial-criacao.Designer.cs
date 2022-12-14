// <auto-generated />
using Despesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Despesas.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220920185541_Inicial-criacao")]
    partial class Inicialcriacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Despesas.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CNPJ")
                        .HasColumnType("int")
                        .HasColumnName("CNPJ");

                    b.Property<int>("Emissão")
                        .HasColumnType("int")
                        .HasColumnName("Emissão");

                    b.Property<int>("Fone")
                        .HasColumnType("int")
                        .HasColumnName("Telefone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<int>("Preço")
                        .HasColumnType("int")
                        .HasColumnName("Preço");

                    b.Property<int>("Vencimento")
                        .HasColumnType("int")
                        .HasColumnName("Vencimento");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}

// <auto-generated />
using System;
using Facturacion.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Facturacion.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20210702181745_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Facturacion.Models.Cliente", b =>
                {
                    b.Property<int?>("codigo_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("codigo_cliente");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("Facturacion.Models.Detalle_Factura", b =>
                {
                    b.Property<int?>("Numero_Factura")
                        .HasColumnType("int");

                    b.Property<int?>("ID_PROUCTO")
                        .HasColumnType("int");

                    b.Property<double>("Precio_Unitario")
                        .HasColumnType("float");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.HasKey("Numero_Factura", "ID_PROUCTO");

                    b.HasIndex("ID_PROUCTO");

                    b.ToTable("detalle_Facturas");
                });

            modelBuilder.Entity("Facturacion.Models.Factura", b =>
                {
                    b.Property<int?>("Numero_Factura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Anulada")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("codigo_cliente")
                        .HasColumnType("int");

                    b.HasKey("Numero_Factura");

                    b.HasIndex("codigo_cliente");

                    b.ToTable("facturas");
                });

            modelBuilder.Entity("Facturacion.Models.Producto", b =>
                {
                    b.Property<int?>("ID_PROUCTO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ACTIVO")
                        .HasColumnType("bit");

                    b.Property<double>("COSTO")
                        .HasColumnType("float");

                    b.Property<string>("DESCRIPCION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EXISTENCIA")
                        .HasColumnType("int");

                    b.Property<string>("NOMBRE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PRECIO")
                        .HasColumnType("float");

                    b.HasKey("ID_PROUCTO");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Facturacion.Models.Usuario", b =>
                {
                    b.Property<int>("id_usu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_usu");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Facturacion.Models.Detalle_Factura", b =>
                {
                    b.HasOne("Facturacion.Models.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("ID_PROUCTO")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Facturacion.Models.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("Numero_Factura")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("producto");
                });

            modelBuilder.Entity("Facturacion.Models.Factura", b =>
                {
                    b.HasOne("Facturacion.Models.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("codigo_cliente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("cliente");
                });
#pragma warning restore 612, 618
        }
    }
}

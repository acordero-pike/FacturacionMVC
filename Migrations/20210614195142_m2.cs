using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Facturacion.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    codigo_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.codigo_cliente);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ID_PROUCTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRECIO = table.Column<double>(type: "float", nullable: false),
                    COSTO = table.Column<double>(type: "float", nullable: false),
                    EXISTENCIA = table.Column<int>(type: "int", nullable: false),
                    ACTIVO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ID_PROUCTO);
                });

            migrationBuilder.CreateTable(
                name: "facturas",
                columns: table => new
                {
                    Numero_Factura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo_cliente = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Anulada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturas", x => x.Numero_Factura);
                    table.ForeignKey(
                        name: "FK_facturas_clientes_codigo_cliente",
                        column: x => x.codigo_cliente,
                        principalTable: "clientes",
                        principalColumn: "codigo_cliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "detalle",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_Factura = table.Column<int>(type: "int", nullable: true),
                    ID_PROUCTO = table.Column<int>(type: "int", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio_Unitario = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle", x => x.id);
                    table.ForeignKey(
                        name: "FK_detalle_facturas_Numero_Factura",
                        column: x => x.Numero_Factura,
                        principalTable: "facturas",
                        principalColumn: "Numero_Factura",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_detalle_Producto_ID_PROUCTO",
                        column: x => x.ID_PROUCTO,
                        principalTable: "Producto",
                        principalColumn: "ID_PROUCTO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalle_ID_PROUCTO",
                table: "detalle",
                column: "ID_PROUCTO");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_Numero_Factura",
                table: "detalle",
                column: "Numero_Factura");

            migrationBuilder.CreateIndex(
                name: "IX_facturas_codigo_cliente",
                table: "facturas",
                column: "codigo_cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalle");

            migrationBuilder.DropTable(
                name: "facturas");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}

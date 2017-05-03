using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarProject.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Demos (Name) VALUES ('Demo1')");
            migrationBuilder.Sql("INSERT INTO Demos (Name) VALUES ('Demo2')");
            migrationBuilder.Sql("INSERT INTO Demos (Name) VALUES ('Demo3')");
            migrationBuilder.Sql("INSERT INTO Demos (Name) VALUES ('Demo4')");
            migrationBuilder.Sql("INSERT INTO Demos (Name) VALUES ('Demo5')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Demos");
        }
    }
}

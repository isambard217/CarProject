using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarProject.Migrations
{
    public partial class seedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make1')");
             migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make2')");
             migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make3')");

             migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make1-ModelA', (SELECT ID From Makes WHERE Name ='Make1'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make1-ModelB', (SELECT ID From Makes WHERE Name ='Make1'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make1-ModelC', (SELECT ID From Makes WHERE Name ='Make1'))");

             migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make2-ModelA', (SELECT ID From Makes WHERE Name ='Make2'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make2-ModelB', (SELECT ID From Makes WHERE Name ='Make2'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make2-ModelC', (SELECT ID From Makes WHERE Name ='Make2'))");

             migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make3-ModelA', (SELECT ID From Makes WHERE Name ='Make3'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make3-ModelB', (SELECT ID From Makes WHERE Name ='Make3'))");
             migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make3-ModelC', (SELECT ID From Makes WHERE Name ='Make3'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

                // We do not need the second line, because when we delete from 
                // Makes all of the assosciated lines will be deleted from Models
                migrationBuilder.Sql("DELETE FROM Makes where Name In ('Make1', 'Make2', 'Make3')");
               // migrationBuilder.Sql("DELETE FROM Models");
        }

    }
}

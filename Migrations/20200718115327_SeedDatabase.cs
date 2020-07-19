using Microsoft.EntityFrameworkCore.Migrations;

namespace AutomobileManagement.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Makes (Name) values('Make1')");
            migrationBuilder.Sql("Insert Into Makes (Name) values('Make2')");
            migrationBuilder.Sql("Insert Into Makes (Name) values('Make3')");

            migrationBuilder.Sql("Insert Into Models (Name,Makeid) values('Make1-ModelA',(select Id From makes where name='Make1'))");
            migrationBuilder.Sql("Insert Into Models (Name,Makeid) values('Make1-ModelB',(select Id From makes where name='Make1'))");
            migrationBuilder.Sql("Insert Into Models (Name,Makeid) values('Make1-ModelC',(select Id From makes where name='Make1'))");


            migrationBuilder.Sql("Insert Into Models (Name,Makeid) values('Make2-ModelA',(select Id From makes where name='Make2'))");
            migrationBuilder.Sql("Insert Into Models (Name,Makeid) values('Make2-ModelB',(select Id From makes where name='Make2'))");
            migrationBuilder.Sql("Insert Into Models (Name,Makeid) values('Make2-ModelC',(select Id From makes where name='Make2'))");


            migrationBuilder.Sql("Insert Into Models (Name,Makeid) values('Make3-ModelA',(select Id From makes where name='Make3'))");
            migrationBuilder.Sql("Insert Into Models (Name,Makeid) values('Make3-ModelB',(select Id From makes where name='Make3'))");
            migrationBuilder.Sql("Insert Into Models (Name,Makeid) values('Make3-ModelC',(select Id From makes where name='Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from makes where name in ('Make1','Make2','Make3')");
        }
    }
}


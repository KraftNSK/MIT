using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace MIT.Migrations
{
    public partial class MIT_Migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Parentid = table.Column<int>(nullable: true),
                    isGroup = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                    table.ForeignKey(
                        name: "FK_Category_Category_Parentid",
                        column: x => x.Parentid,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Departament",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Parentid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departament", x => x.id);
                    table.ForeignKey(
                        name: "FK_Departament_Departament_Parentid",
                        column: x => x.Parentid,
                        principalTable: "Departament",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "MethodFeed",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Method = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MethodFeed", x => x.id);
                });
            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.id);
                });
            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.id);
                });
            migrationBuilder.CreateTable(
                name: "Priority",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ratio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priority", x => x.id);
                });
            migrationBuilder.CreateTable(
                name: "RequestState",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestState", x => x.id);
                });
            migrationBuilder.CreateTable(
                name: "RequestType",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestType", x => x.id);
                });
            migrationBuilder.CreateTable(
                name: "FileObject",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Path = table.Column<string>(nullable: true),
                    Requestid = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileObject", x => x.id);
                });
            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Responsibleid = table.Column<int>(nullable: true),
                    Statusid = table.Column<int>(nullable: true),
                    UserChangeid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.id);
                    table.ForeignKey(
                        name: "FK_History_RequestState_Statusid",
                        column: x => x.Statusid,
                        principalTable: "RequestState",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BaseRequestid = table.Column<int>(nullable: true),
                    Clientid = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Method_Feedid = table.Column<int>(nullable: true),
                    ReactionTime = table.Column<DateTime>(nullable: false),
                    Request_Typeid = table.Column<int>(nullable: true),
                    Responsibleid = table.Column<int>(nullable: true),
                    Stateid = table.Column<int>(nullable: true),
                    Topic = table.Column<string>(nullable: true),
                    Urgencyid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.id);
                    table.ForeignKey(
                        name: "FK_Request_Request_BaseRequestid",
                        column: x => x.BaseRequestid,
                        principalTable: "Request",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Request_MethodFeed_Method_Feedid",
                        column: x => x.Method_Feedid,
                        principalTable: "MethodFeed",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Request_RequestType_Request_Typeid",
                        column: x => x.Request_Typeid,
                        principalTable: "RequestType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Request_RequestState_Stateid",
                        column: x => x.Stateid,
                        principalTable: "RequestState",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Request_Priority_Urgencyid",
                        column: x => x.Urgencyid,
                        principalTable: "Priority",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    AccessLevel = table.Column<byte>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    LoginAD = table.Column<string>(nullable: true),
                    OfficeNumber = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PhoneNumbers = table.Column<string>(nullable: true),
                    Requestid = table.Column<int>(nullable: true),
                    Requestid1 = table.Column<int>(nullable: true),
                    UserOrganizationid = table.Column<int>(nullable: true),
                    UserPositionid = table.Column<int>(nullable: true),
                    isVIP = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_Request_Requestid",
                        column: x => x.Requestid,
                        principalTable: "Request",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Request_Requestid1",
                        column: x => x.Requestid1,
                        principalTable: "Request",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Organization_UserOrganizationid",
                        column: x => x.UserOrganizationid,
                        principalTable: "Organization",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Position_UserPositionid",
                        column: x => x.UserPositionid,
                        principalTable: "Position",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Departament_id",
                        column: x => x.id,
                        principalTable: "Departament",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Parentid = table.Column<int>(nullable: true),
                    Responsibleid = table.Column<int>(nullable: true),
                    SLA_MinReactionTimeMinutes = table.Column<int>(nullable: false),
                    SLA_TimeDone = table.Column<int>(nullable: false),
                    isGroup = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.id);
                    table.ForeignKey(
                        name: "FK_Service_Service_Parentid",
                        column: x => x.Parentid,
                        principalTable: "Service",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_User_Responsibleid",
                        column: x => x.Responsibleid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.AddForeignKey(
                name: "FK_FileObject_Request_Requestid",
                table: "FileObject",
                column: "Requestid",
                principalTable: "Request",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_History_User_Responsibleid",
                table: "History",
                column: "Responsibleid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_History_User_UserChangeid",
                table: "History",
                column: "UserChangeid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Request_User_Clientid",
                table: "Request",
                column: "Clientid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Request_User_Responsibleid",
                table: "Request",
                column: "Responsibleid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_User_Departament_id", table: "User");
            migrationBuilder.DropForeignKey(name: "FK_Request_MethodFeed_Method_Feedid", table: "Request");
            migrationBuilder.DropForeignKey(name: "FK_User_Organization_UserOrganizationid", table: "User");
            migrationBuilder.DropForeignKey(name: "FK_User_Position_UserPositionid", table: "User");
            migrationBuilder.DropForeignKey(name: "FK_Request_Priority_Urgencyid", table: "Request");
            migrationBuilder.DropForeignKey(name: "FK_User_Request_Requestid", table: "User");
            migrationBuilder.DropForeignKey(name: "FK_User_Request_Requestid1", table: "User");
            migrationBuilder.DropTable("Category");
            migrationBuilder.DropTable("FileObject");
            migrationBuilder.DropTable("History");
            migrationBuilder.DropTable("Service");
            migrationBuilder.DropTable("Departament");
            migrationBuilder.DropTable("MethodFeed");
            migrationBuilder.DropTable("Organization");
            migrationBuilder.DropTable("Position");
            migrationBuilder.DropTable("Priority");
            migrationBuilder.DropTable("Request");
            migrationBuilder.DropTable("User");
            migrationBuilder.DropTable("RequestType");
            migrationBuilder.DropTable("RequestState");
        }
    }
}

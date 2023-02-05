using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevNot2021.Migrations
{
    public partial class AllMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AB_ABONE_GRUBU",
                columns: table => new
                {
                    IdAboneGrubu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboneGrubuAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KismiOdemeYapabilir = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AB_ABONE_GRUBU", x => x.IdAboneGrubu);
                });

            migrationBuilder.CreateTable(
                name: "AB_ABONE_TIPI",
                columns: table => new
                {
                    IdAboneTipi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboneTipiAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdAboneTipiGib = table.Column<int>(type: "int", nullable: true),
                    SabitAl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SahaKontrol = table.Column<bool>(type: "bit", nullable: false),
                    ResmiDaire = table.Column<bool>(type: "bit", nullable: false),
                    IdAboneSektor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AB_ABONE_TIPI", x => x.IdAboneTipi);
                });

            migrationBuilder.CreateTable(
                name: "Companies_Info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Number = table.Column<long>(type: "bigint", nullable: true),
                    Company_Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Conn_Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Conn_Str = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies_Info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DB_MENU",
                columns: table => new
                {
                    IdMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IdSecurityController = table.Column<int>(type: "int", nullable: true),
                    ActionNumber = table.Column<long>(type: "bigint", nullable: true),
                    RoutingPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageClass = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    IdMenuParent = table.Column<int>(type: "int", nullable: false),
                    IsParent = table.Column<bool>(type: "bit", nullable: false),
                    HasChild = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_MENU", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "DB_ROLE",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_ROLE", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "DB_ROLE_MENU",
                columns: table => new
                {
                    IdRoleMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<int>(type: "int", nullable: false),
                    IdMenu = table.Column<int>(type: "int", nullable: false),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_ROLE_MENU", x => x.IdRoleMenu);
                });

            migrationBuilder.CreateTable(
                name: "DB_SECURITY_CONTROLLER",
                columns: table => new
                {
                    IdSecurityController = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControllerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_SECURITY_CONTROLLER", x => x.IdSecurityController);
                });

            migrationBuilder.CreateTable(
                name: "DB_SECURITY_ROLE",
                columns: table => new
                {
                    IdSecurityRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecurityRoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_SECURITY_ROLE", x => x.IdSecurityRole);
                });

            migrationBuilder.CreateTable(
                name: "DB_USER_MENU",
                columns: table => new
                {
                    IdUserMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    IdMenu = table.Column<int>(type: "int", nullable: false),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_USER_MENU", x => x.IdUserMenu);
                });

            migrationBuilder.CreateTable(
                name: "GN_BOLGE",
                columns: table => new
                {
                    IdBolge = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolgeKodu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BolgeAdi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FirmaAdi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FirmaKisaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Vkn = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    EfaturaIban = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GN_BOLGE", x => x.IdBolge);
                });

            migrationBuilder.CreateTable(
                name: "GN_SOZLESME_TIPI",
                columns: table => new
                {
                    IdSozlesmeTipi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SozlesmeTipiAdi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SozlesmeTipiKodu = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GN_SOZLESME_TIPI", x => x.IdSozlesmeTipi);
                });

            migrationBuilder.CreateTable(
                name: "LogTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableId = table.Column<int>(type: "int", nullable: true),
                    RowId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoleGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PasswordHash = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DB_SECURITY_ACTION",
                columns: table => new
                {
                    IdSecurityAction = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionNumber = table.Column<long>(type: "bigint", nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IdSecurityController = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    OpenStatus = table.Column<bool>(type: "bit", nullable: true),
                    OpenStatusUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_SECURITY_ACTION", x => x.IdSecurityAction);
                    table.ForeignKey(
                        name: "FK_DB_SECURITY_ACTION_DB_SECURITY_CONTROLLER",
                        column: x => x.IdSecurityController,
                        principalTable: "DB_SECURITY_CONTROLLER",
                        principalColumn: "IdSecurityController");
                });

            migrationBuilder.CreateTable(
                name: "DB_SECURITY_USER_ROLE",
                columns: table => new
                {
                    IdSecurityUserRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSecurityRole = table.Column<int>(type: "int", nullable: false),
                    IdSecurityController = table.Column<int>(type: "int", nullable: true),
                    ActionNumberTotal = table.Column<long>(type: "bigint", nullable: true),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_SECURITY_USER_ROLE", x => x.IdSecurityUserRole);
                    table.ForeignKey(
                        name: "FK_DB_SECURITY_USER_ROLE_DB_SECURITY_CONTROLLER",
                        column: x => x.IdSecurityController,
                        principalTable: "DB_SECURITY_CONTROLLER",
                        principalColumn: "IdSecurityController");
                    table.ForeignKey(
                        name: "FK_DB_SECURITY_USER_ROLE_DB_SECURITY_ROLE",
                        column: x => x.IdSecurityRole,
                        principalTable: "DB_SECURITY_ROLE",
                        principalColumn: "IdSecurityRole");
                });

            migrationBuilder.CreateTable(
                name: "DB_USER",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSecurityRole = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PasswordHash = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TotalCompanyNumber = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    IsRoleLock = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_USER", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_DB_USER_DB_SECURITY_ROLE",
                        column: x => x.IdSecurityRole,
                        principalTable: "DB_SECURITY_ROLE",
                        principalColumn: "IdSecurityRole");
                });

            migrationBuilder.CreateTable(
                name: "DB_USER2",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSecurityRole = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PasswordHash = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_USER2", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_DB_USER2_DB_SECURITY_ROLE",
                        column: x => x.IdSecurityRole,
                        principalTable: "DB_SECURITY_ROLE",
                        principalColumn: "IdSecurityRole");
                });

            migrationBuilder.CreateTable(
                name: "DB_USER2017",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSecurityRole = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PasswordHash = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_USER2017", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_DB_USER2017_DB_SECURITY_ROLE",
                        column: x => x.IdSecurityRole,
                        principalTable: "DB_SECURITY_ROLE",
                        principalColumn: "IdSecurityRole");
                });

            migrationBuilder.CreateTable(
                name: "DB_USER2018",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSecurityRole = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PasswordHash = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_USER2018", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_DB_USER2018_DB_SECURITY_ROLE",
                        column: x => x.IdSecurityRole,
                        principalTable: "DB_SECURITY_ROLE",
                        principalColumn: "IdSecurityRole");
                });

            migrationBuilder.CreateTable(
                name: "DB_USER2019",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSecurityRole = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PasswordHash = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_USER2019", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_DB_USER2019_DB_SECURITY_ROLE",
                        column: x => x.IdSecurityRole,
                        principalTable: "DB_SECURITY_ROLE",
                        principalColumn: "IdSecurityRole");
                });

            migrationBuilder.CreateTable(
                name: "AB_ABONE",
                columns: table => new
                {
                    IdAbone = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboneNo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    SozlesmeNo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    IdAboneGrubu = table.Column<int>(type: "int", nullable: false),
                    IdAboneTipi = table.Column<int>(type: "int", nullable: false),
                    IdSozlesmeTipi = table.Column<int>(type: "int", nullable: false),
                    IdBolge = table.Column<int>(type: "int", nullable: false),
                    KimlikNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AboneAdi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AboneSoyadi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SozlesmeBaslangicTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    SozlesmeBitisTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    MalSahibi = table.Column<bool>(type: "bit", nullable: false),
                    AcikAdres = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AB_ABONE", x => x.IdAbone);
                    table.ForeignKey(
                        name: "FK_AB_ABONE_TIPI_IdAboneTipi",
                        column: x => x.IdAboneTipi,
                        principalTable: "AB_ABONE_TIPI",
                        principalColumn: "IdAboneTipi");
                    table.ForeignKey(
                        name: "FK_GN_BOLGE_IdBolge",
                        column: x => x.IdBolge,
                        principalTable: "GN_BOLGE",
                        principalColumn: "IdBolge");
                    table.ForeignKey(
                        name: "FK_GN_SOZLESME_TIPI_IdSozlesmeTipi",
                        column: x => x.IdSozlesmeTipi,
                        principalTable: "GN_SOZLESME_TIPI",
                        principalColumn: "IdSozlesmeTipi");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<long>(type: "bigint", nullable: true),
                    RoleName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GroupID = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Roles_RoleGroups",
                        column: x => x.GroupID,
                        principalTable: "RoleGroups",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    RoleGroupID = table.Column<int>(type: "int", nullable: true),
                    Roles = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserRoles_RoleGroups",
                        column: x => x.RoleGroupID,
                        principalTable: "RoleGroups",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DB_SECURITY_USER_ACTION",
                columns: table => new
                {
                    IdSecurityUserAction = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    IdSecurityController = table.Column<int>(type: "int", nullable: true),
                    ActionNumberTotal = table.Column<long>(type: "bigint", nullable: true),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    CreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DB_SECURITY_USER_ACTION", x => x.IdSecurityUserAction);
                    table.ForeignKey(
                        name: "FK_DB_SECURITY_USER_ACTION_DB_SECURITY_CONTROLLER",
                        column: x => x.IdSecurityController,
                        principalTable: "DB_SECURITY_CONTROLLER",
                        principalColumn: "IdSecurityController");
                    table.ForeignKey(
                        name: "FK_DB_SECURITY_USER_ACTION_DB_USER",
                        column: x => x.IdUser,
                        principalTable: "DB_USER",
                        principalColumn: "IdUser");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AB_ABONE_IdAboneTipi",
                table: "AB_ABONE",
                column: "IdAboneTipi");

            migrationBuilder.CreateIndex(
                name: "IX_AB_ABONE_IdBolge",
                table: "AB_ABONE",
                column: "IdBolge");

            migrationBuilder.CreateIndex(
                name: "IX_AB_ABONE_IdSozlesmeTipi",
                table: "AB_ABONE",
                column: "IdSozlesmeTipi");

            migrationBuilder.CreateIndex(
                name: "IX_DB_SECURITY_ACTION_IdSecurityController",
                table: "DB_SECURITY_ACTION",
                column: "IdSecurityController");

            migrationBuilder.CreateIndex(
                name: "IX_DB_SECURITY_USER_ACTION_IdSecurityController",
                table: "DB_SECURITY_USER_ACTION",
                column: "IdSecurityController");

            migrationBuilder.CreateIndex(
                name: "IX_DB_SECURITY_USER_ACTION_IdUser",
                table: "DB_SECURITY_USER_ACTION",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_DB_SECURITY_USER_ROLE_IdSecurityController",
                table: "DB_SECURITY_USER_ROLE",
                column: "IdSecurityController");

            migrationBuilder.CreateIndex(
                name: "IX_DB_SECURITY_USER_ROLE_IdSecurityRole",
                table: "DB_SECURITY_USER_ROLE",
                column: "IdSecurityRole");

            migrationBuilder.CreateIndex(
                name: "IX_DB_USER_IdSecurityRole",
                table: "DB_USER",
                column: "IdSecurityRole");

            migrationBuilder.CreateIndex(
                name: "IX_DB_USER2_IdSecurityRole",
                table: "DB_USER2",
                column: "IdSecurityRole");

            migrationBuilder.CreateIndex(
                name: "IX_DB_USER2017_IdSecurityRole",
                table: "DB_USER2017",
                column: "IdSecurityRole");

            migrationBuilder.CreateIndex(
                name: "IX_DB_USER2018_IdSecurityRole",
                table: "DB_USER2018",
                column: "IdSecurityRole");

            migrationBuilder.CreateIndex(
                name: "IX_DB_USER2019_IdSecurityRole",
                table: "DB_USER2019",
                column: "IdSecurityRole");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_GroupID",
                table: "Roles",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleGroupID",
                table: "UserRoles",
                column: "RoleGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRoles",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AB_ABONE");

            migrationBuilder.DropTable(
                name: "AB_ABONE_GRUBU");

            migrationBuilder.DropTable(
                name: "Companies_Info");

            migrationBuilder.DropTable(
                name: "DB_MENU");

            migrationBuilder.DropTable(
                name: "DB_ROLE");

            migrationBuilder.DropTable(
                name: "DB_ROLE_MENU");

            migrationBuilder.DropTable(
                name: "DB_SECURITY_ACTION");

            migrationBuilder.DropTable(
                name: "DB_SECURITY_USER_ACTION");

            migrationBuilder.DropTable(
                name: "DB_SECURITY_USER_ROLE");

            migrationBuilder.DropTable(
                name: "DB_USER_MENU");

            migrationBuilder.DropTable(
                name: "DB_USER2");

            migrationBuilder.DropTable(
                name: "DB_USER2017");

            migrationBuilder.DropTable(
                name: "DB_USER2018");

            migrationBuilder.DropTable(
                name: "DB_USER2019");

            migrationBuilder.DropTable(
                name: "LogTable");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "AB_ABONE_TIPI");

            migrationBuilder.DropTable(
                name: "GN_BOLGE");

            migrationBuilder.DropTable(
                name: "GN_SOZLESME_TIPI");

            migrationBuilder.DropTable(
                name: "DB_USER");

            migrationBuilder.DropTable(
                name: "DB_SECURITY_CONTROLLER");

            migrationBuilder.DropTable(
                name: "RoleGroups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DB_SECURITY_ROLE");
        }
    }
}

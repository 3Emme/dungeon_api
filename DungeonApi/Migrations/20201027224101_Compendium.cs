using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonApi.Migrations
{
    public partial class Compendium : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    ArmorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArmorName = table.Column<string>(nullable: true),
                    ArmorDescription = table.Column<string>(nullable: true),
                    ArmorSlot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.ArmorId);
                });

            migrationBuilder.CreateTable(
                name: "Behavior",
                columns: table => new
                {
                    BehaviorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BehaviorName = table.Column<string>(nullable: true),
                    BehaviorDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Behavior", x => x.BehaviorId);
                });

            migrationBuilder.CreateTable(
                name: "ItemProperty",
                columns: table => new
                {
                    ItemPropertyId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemPropertyName = table.Column<string>(nullable: true),
                    ItemPropertyDescription = table.Column<string>(nullable: true),
                    ItemPropertyFlags = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemProperty", x => x.ItemPropertyId);
                });

            migrationBuilder.CreateTable(
                name: "MainType",
                columns: table => new
                {
                    MainTypeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MainTypeName = table.Column<string>(nullable: true),
                    MainTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainType", x => x.MainTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    WeaponId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeaponName = table.Column<string>(nullable: true),
                    WeaponDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.WeaponId);
                });

            migrationBuilder.CreateTable(
                name: "MonsterArmor",
                columns: table => new
                {
                    MonsterArmorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonsterId = table.Column<int>(nullable: false),
                    ArmorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterArmor", x => x.MonsterArmorId);
                    table.ForeignKey(
                        name: "FK_MonsterArmor_Armor_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Armor",
                        principalColumn: "ArmorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterArmor_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterBehavior",
                columns: table => new
                {
                    MonsterBehaviorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonsterId = table.Column<int>(nullable: false),
                    BehaviorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterBehavior", x => x.MonsterBehaviorId);
                    table.ForeignKey(
                        name: "FK_MonsterBehavior_Behavior_BehaviorId",
                        column: x => x.BehaviorId,
                        principalTable: "Behavior",
                        principalColumn: "BehaviorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterBehavior_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterMainType",
                columns: table => new
                {
                    MonsterMainTypeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonsterId = table.Column<int>(nullable: false),
                    MainTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterMainType", x => x.MonsterMainTypeId);
                    table.ForeignKey(
                        name: "FK_MonsterMainType_MainType_MainTypeId",
                        column: x => x.MainTypeId,
                        principalTable: "MainType",
                        principalColumn: "MainTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterMainType_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemPropertyJoin",
                columns: table => new
                {
                    ItemPropertyJoinId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArmorId = table.Column<int>(nullable: true),
                    WeaponId = table.Column<int>(nullable: true),
                    ItemPropertyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPropertyJoin", x => x.ItemPropertyJoinId);
                    table.ForeignKey(
                        name: "FK_ItemPropertyJoin_Armor_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Armor",
                        principalColumn: "ArmorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemPropertyJoin_ItemProperty_ItemPropertyId",
                        column: x => x.ItemPropertyId,
                        principalTable: "ItemProperty",
                        principalColumn: "ItemPropertyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPropertyJoin_Weapon_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapon",
                        principalColumn: "WeaponId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterWeapon",
                columns: table => new
                {
                    MonsterWeaponId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonsterId = table.Column<int>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false),
                    WeaponSlot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterWeapon", x => x.MonsterWeaponId);
                    table.ForeignKey(
                        name: "FK_MonsterWeapon_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterWeapon_Weapon_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapon",
                        principalColumn: "WeaponId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemPropertyJoin_ArmorId",
                table: "ItemPropertyJoin",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPropertyJoin_ItemPropertyId",
                table: "ItemPropertyJoin",
                column: "ItemPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPropertyJoin_WeaponId",
                table: "ItemPropertyJoin",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterArmor_ArmorId",
                table: "MonsterArmor",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterArmor_MonsterId",
                table: "MonsterArmor",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterBehavior_BehaviorId",
                table: "MonsterBehavior",
                column: "BehaviorId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterBehavior_MonsterId",
                table: "MonsterBehavior",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterMainType_MainTypeId",
                table: "MonsterMainType",
                column: "MainTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterMainType_MonsterId",
                table: "MonsterMainType",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterWeapon_MonsterId",
                table: "MonsterWeapon",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterWeapon_WeaponId",
                table: "MonsterWeapon",
                column: "WeaponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemPropertyJoin");

            migrationBuilder.DropTable(
                name: "MonsterArmor");

            migrationBuilder.DropTable(
                name: "MonsterBehavior");

            migrationBuilder.DropTable(
                name: "MonsterMainType");

            migrationBuilder.DropTable(
                name: "MonsterWeapon");

            migrationBuilder.DropTable(
                name: "ItemProperty");

            migrationBuilder.DropTable(
                name: "Armor");

            migrationBuilder.DropTable(
                name: "Behavior");

            migrationBuilder.DropTable(
                name: "MainType");

            migrationBuilder.DropTable(
                name: "Weapon");
        }
    }
}

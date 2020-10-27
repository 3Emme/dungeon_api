using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonApi.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPropertyJoin_Armor_ArmorId",
                table: "ItemPropertyJoin");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPropertyJoin_ItemProperty_ItemPropertyId",
                table: "ItemPropertyJoin");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPropertyJoin_Weapon_WeaponId",
                table: "ItemPropertyJoin");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterArmor_Armor_ArmorId",
                table: "MonsterArmor");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterArmor_Monsters_MonsterId",
                table: "MonsterArmor");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterBehavior_Behavior_BehaviorId",
                table: "MonsterBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterBehavior_Monsters_MonsterId",
                table: "MonsterBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterMainType_MainType_MainTypeId",
                table: "MonsterMainType");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterMainType_Monsters_MonsterId",
                table: "MonsterMainType");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterWeapon_Monsters_MonsterId",
                table: "MonsterWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterWeapon_Weapon_WeaponId",
                table: "MonsterWeapon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterWeapon",
                table: "MonsterWeapon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterMainType",
                table: "MonsterMainType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterBehavior",
                table: "MonsterBehavior");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterArmor",
                table: "MonsterArmor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainType",
                table: "MainType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemPropertyJoin",
                table: "ItemPropertyJoin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemProperty",
                table: "ItemProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Behavior",
                table: "Behavior");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Armor",
                table: "Armor");

            migrationBuilder.RenameTable(
                name: "Weapon",
                newName: "Weapons");

            migrationBuilder.RenameTable(
                name: "MonsterWeapon",
                newName: "MonsterWeapons");

            migrationBuilder.RenameTable(
                name: "MonsterMainType",
                newName: "MonsterMainTypes");

            migrationBuilder.RenameTable(
                name: "MonsterBehavior",
                newName: "MonsterBehaviors");

            migrationBuilder.RenameTable(
                name: "MonsterArmor",
                newName: "MonsterArmors");

            migrationBuilder.RenameTable(
                name: "MainType",
                newName: "MainTypes");

            migrationBuilder.RenameTable(
                name: "ItemPropertyJoin",
                newName: "ItemPropertyJoins");

            migrationBuilder.RenameTable(
                name: "ItemProperty",
                newName: "ItemProperties");

            migrationBuilder.RenameTable(
                name: "Behavior",
                newName: "Behaviors");

            migrationBuilder.RenameTable(
                name: "Armor",
                newName: "Armors");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterWeapon_WeaponId",
                table: "MonsterWeapons",
                newName: "IX_MonsterWeapons_WeaponId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterWeapon_MonsterId",
                table: "MonsterWeapons",
                newName: "IX_MonsterWeapons_MonsterId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterMainType_MonsterId",
                table: "MonsterMainTypes",
                newName: "IX_MonsterMainTypes_MonsterId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterMainType_MainTypeId",
                table: "MonsterMainTypes",
                newName: "IX_MonsterMainTypes_MainTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterBehavior_MonsterId",
                table: "MonsterBehaviors",
                newName: "IX_MonsterBehaviors_MonsterId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterBehavior_BehaviorId",
                table: "MonsterBehaviors",
                newName: "IX_MonsterBehaviors_BehaviorId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterArmor_MonsterId",
                table: "MonsterArmors",
                newName: "IX_MonsterArmors_MonsterId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterArmor_ArmorId",
                table: "MonsterArmors",
                newName: "IX_MonsterArmors_ArmorId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPropertyJoin_WeaponId",
                table: "ItemPropertyJoins",
                newName: "IX_ItemPropertyJoins_WeaponId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPropertyJoin_ItemPropertyId",
                table: "ItemPropertyJoins",
                newName: "IX_ItemPropertyJoins_ItemPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPropertyJoin_ArmorId",
                table: "ItemPropertyJoins",
                newName: "IX_ItemPropertyJoins_ArmorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons",
                column: "WeaponId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterWeapons",
                table: "MonsterWeapons",
                column: "MonsterWeaponId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterMainTypes",
                table: "MonsterMainTypes",
                column: "MonsterMainTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterBehaviors",
                table: "MonsterBehaviors",
                column: "MonsterBehaviorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterArmors",
                table: "MonsterArmors",
                column: "MonsterArmorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainTypes",
                table: "MainTypes",
                column: "MainTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemPropertyJoins",
                table: "ItemPropertyJoins",
                column: "ItemPropertyJoinId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemProperties",
                table: "ItemProperties",
                column: "ItemPropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Behaviors",
                table: "Behaviors",
                column: "BehaviorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Armors",
                table: "Armors",
                column: "ArmorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPropertyJoins_Armors_ArmorId",
                table: "ItemPropertyJoins",
                column: "ArmorId",
                principalTable: "Armors",
                principalColumn: "ArmorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPropertyJoins_ItemProperties_ItemPropertyId",
                table: "ItemPropertyJoins",
                column: "ItemPropertyId",
                principalTable: "ItemProperties",
                principalColumn: "ItemPropertyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPropertyJoins_Weapons_WeaponId",
                table: "ItemPropertyJoins",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterArmors_Armors_ArmorId",
                table: "MonsterArmors",
                column: "ArmorId",
                principalTable: "Armors",
                principalColumn: "ArmorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterArmors_Monsters_MonsterId",
                table: "MonsterArmors",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "MonsterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterBehaviors_Behaviors_BehaviorId",
                table: "MonsterBehaviors",
                column: "BehaviorId",
                principalTable: "Behaviors",
                principalColumn: "BehaviorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterBehaviors_Monsters_MonsterId",
                table: "MonsterBehaviors",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "MonsterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterMainTypes_MainTypes_MainTypeId",
                table: "MonsterMainTypes",
                column: "MainTypeId",
                principalTable: "MainTypes",
                principalColumn: "MainTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterMainTypes_Monsters_MonsterId",
                table: "MonsterMainTypes",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "MonsterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterWeapons_Monsters_MonsterId",
                table: "MonsterWeapons",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "MonsterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterWeapons_Weapons_WeaponId",
                table: "MonsterWeapons",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPropertyJoins_Armors_ArmorId",
                table: "ItemPropertyJoins");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPropertyJoins_ItemProperties_ItemPropertyId",
                table: "ItemPropertyJoins");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPropertyJoins_Weapons_WeaponId",
                table: "ItemPropertyJoins");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterArmors_Armors_ArmorId",
                table: "MonsterArmors");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterArmors_Monsters_MonsterId",
                table: "MonsterArmors");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterBehaviors_Behaviors_BehaviorId",
                table: "MonsterBehaviors");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterBehaviors_Monsters_MonsterId",
                table: "MonsterBehaviors");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterMainTypes_MainTypes_MainTypeId",
                table: "MonsterMainTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterMainTypes_Monsters_MonsterId",
                table: "MonsterMainTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterWeapons_Monsters_MonsterId",
                table: "MonsterWeapons");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterWeapons_Weapons_WeaponId",
                table: "MonsterWeapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterWeapons",
                table: "MonsterWeapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterMainTypes",
                table: "MonsterMainTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterBehaviors",
                table: "MonsterBehaviors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterArmors",
                table: "MonsterArmors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainTypes",
                table: "MainTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemPropertyJoins",
                table: "ItemPropertyJoins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemProperties",
                table: "ItemProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Behaviors",
                table: "Behaviors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Armors",
                table: "Armors");

            migrationBuilder.RenameTable(
                name: "Weapons",
                newName: "Weapon");

            migrationBuilder.RenameTable(
                name: "MonsterWeapons",
                newName: "MonsterWeapon");

            migrationBuilder.RenameTable(
                name: "MonsterMainTypes",
                newName: "MonsterMainType");

            migrationBuilder.RenameTable(
                name: "MonsterBehaviors",
                newName: "MonsterBehavior");

            migrationBuilder.RenameTable(
                name: "MonsterArmors",
                newName: "MonsterArmor");

            migrationBuilder.RenameTable(
                name: "MainTypes",
                newName: "MainType");

            migrationBuilder.RenameTable(
                name: "ItemPropertyJoins",
                newName: "ItemPropertyJoin");

            migrationBuilder.RenameTable(
                name: "ItemProperties",
                newName: "ItemProperty");

            migrationBuilder.RenameTable(
                name: "Behaviors",
                newName: "Behavior");

            migrationBuilder.RenameTable(
                name: "Armors",
                newName: "Armor");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterWeapons_WeaponId",
                table: "MonsterWeapon",
                newName: "IX_MonsterWeapon_WeaponId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterWeapons_MonsterId",
                table: "MonsterWeapon",
                newName: "IX_MonsterWeapon_MonsterId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterMainTypes_MonsterId",
                table: "MonsterMainType",
                newName: "IX_MonsterMainType_MonsterId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterMainTypes_MainTypeId",
                table: "MonsterMainType",
                newName: "IX_MonsterMainType_MainTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterBehaviors_MonsterId",
                table: "MonsterBehavior",
                newName: "IX_MonsterBehavior_MonsterId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterBehaviors_BehaviorId",
                table: "MonsterBehavior",
                newName: "IX_MonsterBehavior_BehaviorId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterArmors_MonsterId",
                table: "MonsterArmor",
                newName: "IX_MonsterArmor_MonsterId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterArmors_ArmorId",
                table: "MonsterArmor",
                newName: "IX_MonsterArmor_ArmorId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPropertyJoins_WeaponId",
                table: "ItemPropertyJoin",
                newName: "IX_ItemPropertyJoin_WeaponId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPropertyJoins_ItemPropertyId",
                table: "ItemPropertyJoin",
                newName: "IX_ItemPropertyJoin_ItemPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPropertyJoins_ArmorId",
                table: "ItemPropertyJoin",
                newName: "IX_ItemPropertyJoin_ArmorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon",
                column: "WeaponId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterWeapon",
                table: "MonsterWeapon",
                column: "MonsterWeaponId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterMainType",
                table: "MonsterMainType",
                column: "MonsterMainTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterBehavior",
                table: "MonsterBehavior",
                column: "MonsterBehaviorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterArmor",
                table: "MonsterArmor",
                column: "MonsterArmorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainType",
                table: "MainType",
                column: "MainTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemPropertyJoin",
                table: "ItemPropertyJoin",
                column: "ItemPropertyJoinId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemProperty",
                table: "ItemProperty",
                column: "ItemPropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Behavior",
                table: "Behavior",
                column: "BehaviorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Armor",
                table: "Armor",
                column: "ArmorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPropertyJoin_Armor_ArmorId",
                table: "ItemPropertyJoin",
                column: "ArmorId",
                principalTable: "Armor",
                principalColumn: "ArmorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPropertyJoin_ItemProperty_ItemPropertyId",
                table: "ItemPropertyJoin",
                column: "ItemPropertyId",
                principalTable: "ItemProperty",
                principalColumn: "ItemPropertyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPropertyJoin_Weapon_WeaponId",
                table: "ItemPropertyJoin",
                column: "WeaponId",
                principalTable: "Weapon",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterArmor_Armor_ArmorId",
                table: "MonsterArmor",
                column: "ArmorId",
                principalTable: "Armor",
                principalColumn: "ArmorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterArmor_Monsters_MonsterId",
                table: "MonsterArmor",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "MonsterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterBehavior_Behavior_BehaviorId",
                table: "MonsterBehavior",
                column: "BehaviorId",
                principalTable: "Behavior",
                principalColumn: "BehaviorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterBehavior_Monsters_MonsterId",
                table: "MonsterBehavior",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "MonsterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterMainType_MainType_MainTypeId",
                table: "MonsterMainType",
                column: "MainTypeId",
                principalTable: "MainType",
                principalColumn: "MainTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterMainType_Monsters_MonsterId",
                table: "MonsterMainType",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "MonsterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterWeapon_Monsters_MonsterId",
                table: "MonsterWeapon",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "MonsterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterWeapon_Weapon_WeaponId",
                table: "MonsterWeapon",
                column: "WeaponId",
                principalTable: "Weapon",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

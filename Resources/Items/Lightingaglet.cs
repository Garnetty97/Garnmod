using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Garnmod.Resources.Items
{
    class Lightningaglet : ModItem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Lightning Chip";
            item.maxStack = 1;
            item.value = 400000;
            item.rare = 4;
            item.width = 30;
            item.height = 30;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed *= 1.2F;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips[1] = new TooltipLine(mod, "equipline", "Equipable");
            tooltips[2] = new TooltipLine(mod, "defenseline", "20% increased movement speed");
        }
    }
}

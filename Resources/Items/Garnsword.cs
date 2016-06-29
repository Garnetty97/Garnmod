using Garnmod.Resources.Dusts;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Garnmod.Resources.Items
{
    class Garnsword : ModItem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Infused Broadsword";
            item.toolTip = "Has a 17% chance to deal 40% bonus damage and heal for 33% of total damage dealt";         
            item.damage = 28;
            item.melee = true;
            item.width = 45;
            item.height = 45;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 60000; 
            item.rare = 4;
            item.useSound = 1;            
            item.autoReuse = true;
        }

        public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
        
            Vector2 loc = player.itemLocation;
            loc.Y -= 20;

            Random rand = new Random();
            int r = rand.Next(0, 6);

            if (r == 0)
            {
                for (int i = 0; i < 9; i++)
                {           
                    Dust.NewDust(loc, 50, 30, mod.DustType("Garnsworddust"), 0.0F, 0.0F, 0, default(Color), 4.5F);
                }

                damage += (int) (damage * 0.4);

                int healamount = (int)(damage * 0.33);
                player.HealEffect(healamount, true);

                if (player.statLife + healamount <= (player.statLifeMax + player.statLifeMax2))
                {
                    player.statLife += healamount;
                }
                else
                {
                    player.statLife = (player.statLifeMax + player.statLifeMax2);
                }
            }
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips[5].overrideColor = Color.Red;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            Lighting.AddLight(player.position, 1.0F, 1.0F, 0.6F);
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(item.position, 1.0F, 1.0F, 0.0F);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Energyorb"), 4);
            recipe.AddIngredient(mod.ItemType("Garngemshiny"), 8);
            recipe.AddTile(Terraria.ID.TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Garnmod.Resources.Items
{
    class Garngemshiny : ModItem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Shiny Garnet Gem";
            item.maxStack = 999;
            item.value = 60000;
            item.rare = 4;
            item.width = 30;
            item.height = 30;
        }

        public override DrawAnimation GetAnimation()
        {
            return new Terraria.DataStructures.DrawAnimationVertical(14, 12);
        }

        public override void PostUpdate()
        {
            base.PostUpdate();

            Lighting.AddLight(item.position, 2.0F, 0.0F, 0.0F);
        }

    }
}

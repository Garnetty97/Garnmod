using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Garnmod.Resources.Items
{
    class Garngem : ModItem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Garnet Gem";
            item.toolTip = "This doesn't seem to be very useful...";
            item.maxStack = 999;
            item.value = 15000;
            item.rare = 3;
            item.width = 30;
            item.height = 30;
            item.holdStyle = 1;
        }

        public override void HoldItem(Player player)
        {
            base.HoldItem(player);
            Lighting.AddLight(player.itemLocation, 0.5F, 0.0F, 0.0F);
        }

        public override void PostUpdate()
        {
            base.PostUpdate();
 
            Lighting.AddLight(item.position, 2.0F, 0.0F, 0.0F);

        }
    }
}

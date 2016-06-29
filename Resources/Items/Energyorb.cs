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
    class Energyorb : ModItem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Energy Fragment";
            item.maxStack = 999;
            item.value = 60000;
            item.rare = 5;
            item.width = 16;
            item.height = 16;
        }

        public override void PostUpdate()
        {
            base.PostUpdate();
            
            Lighting.AddLight(item.position, 1.0F, 1.0F, 0.0F);
        }
    }
}

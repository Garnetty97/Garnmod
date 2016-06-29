using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Garnmod.Resources.Dusts
{
    class Garnoredust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.noLight = false;
        }

        public override bool MidUpdate(Dust dust)
        {
            Lighting.AddLight(dust.position, 1.0F, 0.0F, 0.0F);
            return false;
        }
    }
}

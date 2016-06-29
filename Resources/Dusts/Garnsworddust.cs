using Garnmod.Resources.Dusts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Garnmod.Resources.Dusts
{
    class Garnsworddust : ModDust
    {
        public override void OnSpawn(Dust dust)
        { 
            dust.noGravity = true;
            dust.noLight = false;
            dust.customData = new Garnsworddustdata();
        }

        public override bool Update(Dust dust)
        {      
            Lighting.AddLight(dust.position, 1.0F, 0.0F, 0.0F);

            Garnsworddustdata data = (Garnsworddustdata) dust.customData;

            if (data.counter < 15)
            {
                data.counter++;
            }
            else
            {
                dust.active = false;
            }

            return false;

        }

    }
}

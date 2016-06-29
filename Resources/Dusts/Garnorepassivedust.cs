using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Garnmod.Resources.Dusts
{
    class Garnorepassivedust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.noLight = false;
            dust.customData = new Garnorepassivedustdata();
        }

        public override bool Update(Dust dust)
        {
            Garnorepassivedustdata data = (Garnorepassivedustdata)dust.customData;

            switch (data.counter)
            {
                case 10:
                    Lighting.AddLight(dust.position, 0.4F, 0.0F, 0.0F);
                    break;
                case 15:
                    Lighting.AddLight(dust.position, 0.4F, 0.0F, 0.0F);
                    break;
                case 20:
                    Lighting.AddLight(dust.position, 0.3F, 0.0F, 0.0F);
                    break;
                case 25:
                    Lighting.AddLight(dust.position, 0.3F, 0.0F, 0.0F);
                    break;
                case 30:
                    Lighting.AddLight(dust.position, 0.2F, 0.0F, 0.0F);
                    break;
            }

            if (data.counter < 30)
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

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Garnmod.Resources.Tiles
{
    class Garnore : ModTile
    {
        public override void SetDefaults()
        {
            mineResist = 3F;
            minPick = 55;
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("Garngem");
            AddMapEntry(new Microsoft.Xna.Framework.Color(200, 200, 200));
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = 1;
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            type = mod.DustType("Garnoredust");
            return true;
        }

        public override void KillTile(int i, int j, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (fail == false)
            {
                Random r = new Random();
                int l = r.Next(0, 10);

                if (l == 1)
                {
                    this.drop = mod.ItemType("Garngemshiny");
                }
                else
                {
                   this.drop = mod.ItemType("Garngem");
                }
            }
    
        }

        static Random rand = new Random();

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                int l = rand.Next(0, 150);

                if (l == 0)
                {
                    Vector2 loc = new Vector2(i * 16, j * 16);
                    Dust.NewDust(loc, 16, 16, mod.DustType("Garnorepassivedust"), 0.0F, 0.0F, 0, default(Color), 1.0F);
                }

            }
            
        }

    }
}

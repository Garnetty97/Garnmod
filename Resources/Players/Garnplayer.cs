using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Garnmod.Resources.Players
{
    class Garnplayer : ModPlayer
    {
        bool canshitjump = true;
        bool alreadyjumpedonce = false;
        bool wasjumping = false;

        public override void SetControls()
        {
            if (player.controlJump && player.jump == 0 && canshitjump == true)
            {
                wasjumping = true;

                if (alreadyjumpedonce)
                {
                    alreadyjumpedonce = false;
                    wasjumping = false;
                    canshitjump = false;
                    Main.NewText("ffffffffffffff");
                    Main.NewText(Main.maxTilesX * Main.maxTilesY * 6E-05 * 1.4 + "");
                }
   
            }
            else if (!player.controlJump && wasjumping == true)
            {
                alreadyjumpedonce = true;
                wasjumping = false;
            }

            // if player on ground, canshitjump = true
            

        }
    }
}

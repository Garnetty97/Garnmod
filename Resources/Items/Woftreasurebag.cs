using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Garnmod.Resources.Items
{
    class Woftreasurebag : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossBag" && arg == ItemID.WallOfFleshBossBag)
            {
                Random rand = new Random();
                int i = rand.Next(0, 6);

                if (i == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("Guardianemblem"), 1);
                }
            }
        }
    }
}

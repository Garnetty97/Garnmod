using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Garnmod.Resources.NPCs
{
    class Garnwallofflesh : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Name.ToLower().Equals("wall of flesh") && Main.expertMode == false)
            {
                Random rand = new Random();
                int i = rand.Next(0, 8);
                
                if (i == 0)
                {
                    Item.NewItem((int)npc.position.X + 3, (int)npc.position.Y + 3, 28, 28, mod.ItemType("Guardianemblem"));
                }
            }
        }
    }
}

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Garnmod.Resources.NPCs
{
    class Energymob : ModNPC
    {
        public override void SetDefaults()
        {
            npc.lifeMax = 55;
            npc.aiStyle = 14;
            npc.height = 18;
            npc.width = 22;
            npc.defense = 8;
            npc.damage = 26;
            npc.knockBackResist = 0.6F;
            npc.value = 20000;
            npc.soundHit = 1;
            npc.soundKilled = 4;
            animationType = Terraria.ID.NPCID.CaveBat;
            Main.npcFrameCount[npc.type] = 5;
            npc.displayName = "Energy Bat";

            if (Main.hardMode)
            {
                npc.lifeMax = 120;
                npc.defense = 18;
                npc.knockBackResist = 0.9F;
                npc.value = 80000;
                npc.damage = 52;
            }
        }

        public override void ModifyHitByItem(Player player, Item item, ref int damage, ref float knockback, ref bool crit)
        { 
            if (!Main.hardMode)
            {
                int direction = 0;
                float i = player.position.X - npc.position.X;

                Random rand = new Random();
                int r = rand.Next(0, 5);

                if (r == 0)
                {
                    if (i < 1)
                    {
                        direction = -1;
                    }
                    else
                    {
                        direction = 1;
                    }

                    int reflectdamage = damage / 2;

                    player.Hurt(reflectdamage, direction, false, false, " knived the toaster", false, 1);
                }
            }
            
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.86F;
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;

            switch (frame)
            {
                case 2:
                    Lighting.AddLight(npc.position, 0.04F, 0.04F, 0.0F);
                    break;
                case 3:
                    Lighting.AddLight(npc.position, 0.1F, 0.1F, 0.0F);
                    break;
            }
        }

        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            int nearhell = Main.maxTilesY * 6/7;

            int y = spawnInfo.spawnTileY;

            if (Main.rockLayer < y && spawnInfo.desertCave == false && y < nearhell)
            {
                return 0.05F;
            }

            return 0.0F;
        }

        public override void NPCLoot()
        {
            Vector2 loc = npc.position;

            Random rand = new Random();
            int i = rand.Next(0, 8);

            if (i == 0)
            {
                Item.NewItem((int)loc.X, (int)loc.Y, 20, 20, mod.ItemType("Energyorb"), 1);
            }
            
        }


    }
}

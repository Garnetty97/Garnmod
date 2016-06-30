using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ModLoader;
using Terraria.World.Generation;

namespace Garnmod.Resources.Worlds
{
    class Garnworld : ModWorld
    {
        private const int saveVersion = 0;
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex == -1)
            {
                return;
            }
            tasks.Insert(ShiniesIndex + 1, new PassLegacy("Custom Mod Ores", delegate (GenerationProgress progress)
            {
                progress.Message = "Adding Mysterious Ores";

                int half = Main.maxTilesY / 2;
                int bot = Main.maxTilesY;

                for (int k = 0; k < (int)((double)(Terraria.Main.maxTilesX * Main.maxTilesY) * 6E-05 * 1.4); k++)                                                                                                                                      //      |
                {                                                                                                                                                                                                                      //       |
                    WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next(half, bot),
                         (double)WorldGen.genRand.Next(7, 13), WorldGen.genRand.Next(3, 4), mod.TileType("Garnore"), false, 0f, 0f, false, true);
                }
            }));
        }
    }
}

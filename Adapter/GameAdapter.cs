using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class GameAdapter : PCGame
    {
        private ComputerGame computerGame;
        public GameAdapter(ComputerGame computerGame)
        {
            this.computerGame = computerGame;
        }
        public string getTitle() => computerGame.getName();
        public int getPegiAllowedAge()
        {
            switch (computerGame.getPegiAgeRating())
            {
                case PegiAgeRating.P3: return 3;
                case PegiAgeRating.P7: return 7;
                case PegiAgeRating.P12: return 12;
                case PegiAgeRating.P16: return 16;
                case PegiAgeRating.P18: return 18;
                default: return 0;
            }
        }
        public bool isTripleAGame() => computerGame.getBudgetInMillionsOfDollars() > 50;
        public Requirements getRequirements()
        {
            int gpuGb = computerGame.getMinimumGpuMemoryInMegabytes() / 1024;
            int hddGb = computerGame.getDiskSpaceNeededInGB();
            int ramGb = computerGame.getRamNeededInGb();
            double cpuGhz = computerGame.getCoreSpeedInGhz();
            int coresNum = computerGame.getCoresNeeded();
            return new Requirements(gpuGb, hddGb, ramGb, cpuGhz, coresNum);
        }
    }
}

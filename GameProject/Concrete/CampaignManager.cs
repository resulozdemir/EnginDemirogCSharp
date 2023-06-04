using ConsoleApp4.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Game game, Campaign campaign)
        {
            Console.WriteLine("Campaign added");
        }

        public void Delete(Game game, Campaign campaign)
        {
            Console.WriteLine("Campaign deleted");
        }

        public void Update(Game game, Campaign campaign)
        {
            Console.WriteLine("Campaign updated");
        }
    }
}

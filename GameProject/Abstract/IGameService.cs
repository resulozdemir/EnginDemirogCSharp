using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Abstract
{
    public interface IGameService
    {
        void Sell(Customer customer, Game game);
    }
}

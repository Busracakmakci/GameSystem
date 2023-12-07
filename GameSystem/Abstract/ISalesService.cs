using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Abstract
{
    public interface ISalesService
    {
        void SellGame(Gamer gamer, Game game);
        public void SellGameWithGame(Gamer gamer, Game game, Campaign compaign)
        { }
    }
}
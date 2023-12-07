using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Abstract
{
    public interface IGamerService
    {
        public void Add(Gamer game);
        public void Delete(Gamer game);
    }
}

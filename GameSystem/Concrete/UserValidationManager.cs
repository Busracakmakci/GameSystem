using GameSystem.Abstract;
using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
       
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.Name == "su" && gamer.BirthYear == 2001 && gamer.NationalityId =="21363456748" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

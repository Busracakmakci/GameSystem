using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalityId { get; set; }
        public int BirthYear { get; set; }
        public Game PurschasedGAme { get; set; }
    }
}

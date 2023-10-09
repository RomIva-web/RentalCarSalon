using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR_RENTAL.Classes
{
    class UserAuthorization
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static int Role { get; set; }

        public static void UserExit()
        {
            Id = 0;
            Name = "";
            Role = 0;
        }
    }
}

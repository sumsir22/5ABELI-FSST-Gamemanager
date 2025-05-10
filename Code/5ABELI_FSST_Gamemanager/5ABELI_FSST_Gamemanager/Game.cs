using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _5ABELI_FSST_Gamemanager
{
    public class Game
    {

        // These are our properties
        public string name { get; set; } = "";
        public string genre { get; set; } = "";
        public DateTime releaseDate { get; set; }
        /*public string platform { get; set; } = "";
        public string developer { get; set; } = "";
        public string publisher { get; set; } = "";*/

        // This is our constructor
        public Game(string name, string genre, DateTime releaseDate)
        {
            this.name = name;
            this.genre = genre;
            this.releaseDate = releaseDate;
        }

        // This is how we want to display our games in the list
        public override string ToString()
        {
            return $"{name} ({genre}) - {releaseDate.ToShortDateString()}";
        }

        // This is how we want to save our games to a file
        public string saveformat()
        {
            return $"{name};{genre};{releaseDate.ToString("yyyy-MM-dd")}";
        }



    }
}

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

        // Propertys
        public string name { get; set; } = "";      //Name of the game
        public string genre { get; set; } = "";     //Genre of the game
        public DateTime releaseDate { get; set; }   //Releasedate of the game
        /*public string platform { get; set; } = "";
        public string developer { get; set; } = "";
        public string publisher { get; set; } = "";*/

       
        public Game(string name, string genre, DateTime releaseDate)    //constructor
        {
            this.name = name;
            this.genre = genre;
            this.releaseDate = releaseDate;
        }

       
        public override string ToString()
        {
            return $"{name} ({genre}) - {releaseDate.ToShortDateString()}"; //Output format for List
        }

        
        public string saveformat()
        {
            return $"{name};{genre};{releaseDate.ToString("yyyy-MM-dd")}";  //saveformat for storage
        }



    }
}

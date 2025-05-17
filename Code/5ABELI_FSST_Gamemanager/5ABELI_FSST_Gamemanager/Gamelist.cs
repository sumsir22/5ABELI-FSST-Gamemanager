using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ABELI_FSST_Gamemanager
{
    public class Gamelist
    {
        
        public List<Game> gamelist = new List<Game>();  //List of game class

        
        public Gamelist() { }   //constructor

        public override string ToString()
        {
            int i = 0;
            string g = "";
            foreach (Game game in gamelist)
            {
                i++;
                g += i + ".\t" + gamelist.ToString() + "\n";    //Writing the gamelist 
            }
            return g;       //return the complet list
        }

        public void save(string path)   //save the list to external path
        {
            StreamWriter sw = new StreamWriter(path);
            foreach (Game game in gamelist)
            {
                sw.WriteLine(game.saveformat());
            }
            sw.Close();
        }

        public void load(string path)   //load list from external path
        {
            StreamReader sr = new StreamReader(path);
            gamelist.Clear();
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] ts = s.Split(';');
                gamelist.Add(new Game(ts[0], ts[1],ts[2]));
            }
            sr.Close();
        }

        public void add(string name, string genre, string date)    //add a new game to list
        {
            gamelist.Add(new Game(name, genre, date));
        }
        public void del(int pos)    //delet a game at specified position
        {
            gamelist.RemoveAt(pos - 1);
        }
    }
}

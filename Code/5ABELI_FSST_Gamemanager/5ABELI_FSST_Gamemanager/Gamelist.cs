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
        // This class is used to store a list of games
        public List<Game> gamelist = new List<Game>();

        // This is our constructor
        public Gamelist() { }

        public override string ToString()
        {
            int i = 0;
            string g = "";
            foreach (Game game in gamelist)
            {
                i++;
                g += i + ".\t" + gamelist.ToString() + "\n";
            }
            return g;
        }

        public void save(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            foreach (Game game in gamelist)
            {
                sw.WriteLine(game.saveformat());
            }
            sw.Close();
        }

        public void load(string path)
        {
            StreamReader sr = new StreamReader(path);
            gamelist.Clear();
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] ts = s.Split(';');
                gamelist.Add(new Game(ts[0], ts[1], Convert.ToDateTime(ts[2])));
            }
            sr.Close();
        }

        public void add(string name, string genre, DateTime releaseDate)
        {
            gamelist.Add(new Game(name, genre, releaseDate));
        }
        public void del(int pos)
        {
            gamelist.RemoveAt(pos - 1);
        }
    }
}

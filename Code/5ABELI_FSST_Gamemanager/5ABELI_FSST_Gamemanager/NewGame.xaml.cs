using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _5ABELI_FSST_Gamemanager
{
    /// <summary>
    /// Interaktionslogik für NewGame.xaml
    /// </summary>
    public partial class NewGame : Window
    {
        Gamelist gamelist = new Gamelist();
        ListView listview_games = new ListView();
        public NewGame(Gamelist gamelist, ListView listview_games)
        {
            InitializeComponent();
            this.gamelist = gamelist;
            this.listview_games = listview_games;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (dp == null || tb_genre == null || tb_name == null)
            {
                throw new Exception("Bitte füllen sie alle Felder korrekt aus!");
            }

            DateTime releaseDate = (DateTime)dp.SelectedDate;
            string date = releaseDate.ToString("dd.MM.yyyy"); // Format the date to "dd.MM.yyyy"
            string genre = tb_genre.Text;
            string name = tb_name.Text;

            gamelist.add(name, genre, date); // Add the new game to the gamelist
            listview_games.ItemsSource = null; // Reset the ItemsSource to refresh the ListView
            listview_games.ItemsSource = gamelist.gamelist; // Set the updated gamelist as the ItemsSource

            this.Close(); // Close the window
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Close the window
        }
    }
}

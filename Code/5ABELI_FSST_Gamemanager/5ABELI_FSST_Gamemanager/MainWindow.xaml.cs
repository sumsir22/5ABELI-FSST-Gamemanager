using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _5ABELI_FSST_Gamemanager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Gamelist gamelist = new Gamelist();
        string safepath = ""; // Path to save the file

        public MainWindow()
        {
            InitializeComponent();
        }

        public void btn_new_game_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            
            bool? result = sfd.ShowDialog();

            if (result == true)     // if the user clicked "OK"
            {
                listview_games.ItemsSource = null; // Reset the ItemsSource to refresh the ListView
                listview_games.ItemsSource = gamelist.gamelist; // Set the updated gamelist as the ItemsSource
                gamelist.save(safepath = sfd.FileName);  //saves the file
            }

        }
        private void btn_save_list_Click(object sender, RoutedEventArgs e)
        {
            gamelist.save(safepath);  //saves the file
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            NewGame newGameWindow = new NewGame(gamelist, listview_games);  //create new window
            newGameWindow.ShowDialog();     //open new window
        }

        
    }
}
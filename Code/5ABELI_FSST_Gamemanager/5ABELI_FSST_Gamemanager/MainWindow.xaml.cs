using Microsoft.Win32;
using System.ComponentModel;
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

        //for sorting the ListView
        private GridViewColumnHeader _lastHeaderClicked = null;
        private ListSortDirection _lastDirection = ListSortDirection.Ascending;

        private void disable_btn() //Deactivates the usage of Buttons
        {
            btn_add.IsEnabled = false;
            btn_save_list.IsEnabled = false;
            btn_delete.IsEnabled = false;
        }

        private void enable_btn() //Deactivates the usage of Buttons
        {
            btn_add.IsEnabled = true;
            btn_save_list.IsEnabled = true;
            btn_delete.IsEnabled = true;
        }

        public MainWindow()
        {
            InitializeComponent();
            disable_btn(); // Deactivate buttons at the beginning
        }


        public void btn_new_game_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";

            bool? result = sfd.ShowDialog();

            if (result == true)     // if the user clicked "OK"
            {
                listview_games.ItemsSource = null; // clears ListView 
                gamelist = new Gamelist(); // new gamelist
                listview_games.ItemsSource = gamelist.gamelist; // gives gamelist to listview
                gamelist.save(safepath = sfd.FileName);  // saves gamelist in the file
                enable_btn(); // activates button
            }
        }

        private void btn_open_list_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            bool? result = ofd.ShowDialog();
            if (result == true)     // if the user clicked "OK"
            {
                listview_games.ItemsSource = null; // Reset the ItemsSource to refresh the ListView
                gamelist.load(safepath = ofd.FileName);  //load the file
                listview_games.ItemsSource = gamelist.gamelist; // Set the updated gamelist as the ItemsSource
                enable_btn(); // Activate buttons
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

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            // it checks, if a game is selected in the listview
            if (listview_games.SelectedItem is Game selectedGame)
            {
                // index of the selected game
                int index = gamelist.gamelist.IndexOf(selectedGame);
                if (index >= 0)
                {
                    // delete the selected game from the list
                    gamelist.del(index);
                    // listview refresh
                    listview_games.ItemsSource = null;
                    listview_games.ItemsSource = gamelist.gamelist;
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Spiel aus, das gelöscht werden soll.", "Kein Spiel ausgewählt", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            var headerClicked = e.OriginalSource as GridViewColumnHeader;
            if (headerClicked == null || headerClicked.Column == null)
                return;

            string sortBy = headerClicked.Column.Header as string;
            ListSortDirection direction = ListSortDirection.Ascending;
            if (headerClicked == _lastHeaderClicked && _lastDirection == ListSortDirection.Ascending)
                direction = ListSortDirection.Descending;

            Sort(sortBy, direction);

            _lastHeaderClicked = headerClicked;
            _lastDirection = direction;
        }

        private void Sort(string sortBy, ListSortDirection direction)
        {
            ICollectionView dataView = CollectionViewSource.GetDefaultView(listview_games.ItemsSource);

            dataView.SortDescriptions.Clear();
            dataView.SortDescriptions.Add(new SortDescription(sortBy, direction));
            dataView.Refresh();
        }

    }
}
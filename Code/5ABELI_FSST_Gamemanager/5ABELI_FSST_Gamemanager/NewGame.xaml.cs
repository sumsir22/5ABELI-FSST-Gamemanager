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
        public NewGame(Gamelist gamelist)
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (dp == null || tb_genre == null || tb_name == null)
            {
                throw new Exception("Bitte füllen sie alle Felder korrekt aus!");
            }



        }

        private void btn_cancle_Click(object sender, RoutedEventArgs e)
        {
            NewGame newGame = new NewGame(gamelist);
            newGame.Close();
        }
    }
}

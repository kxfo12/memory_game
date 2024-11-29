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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace memory_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Card> characters = new List<Card>();
        Card[] randomCharacters = new Card[12];
        int counter = 0;
        int lastIdCLicked = -1;
        public MainWindow()
        {
            InitializeComponent();

        }
        public void shuffle()
        {
            int i = 0;
            while (i < 12)
            {
                int rand = new Random().Next(0, 11);
                if (randomCharacters[rand] == null)
                {
                    randomCharacters[rand] = characters[i];
                    i++;
                }
            }
        }

        private void choose(object sender, RoutedEventArgs e, int id)
        {
            
            if (lastIdCLicked != id)
            {
                
                lastIdCLicked = id;
                Image button = (Image)FindName("image" + id);
                button.Source = randomCharacters[id].Reverse();
            }
        }
    }
}

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

namespace AgentSelectorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AgentButton_Click(object sender, RoutedEventArgs e)
        {

            //Array of Agnets
            string[] agents = {"Astra", "Brim", "Omen", "Viper", "Jett", "Phoenix", "Neon","Reyna","Raze","Yoru","Breach",
        "KAY/O", "Fade", "Sova", "Skye", "Chamber", "Cypher", "Killjoy", "Sage", "Harbor"};

            // Random generation

            Random rand = new Random();
            int index = rand.Next(agents.Length);

            // Change text
            MainLabel.Content = agents[index];


        }
    }
}
  


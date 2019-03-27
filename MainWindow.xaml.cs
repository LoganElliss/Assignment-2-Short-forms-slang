//Logan Ellis
//March 2019
//a code showing how many fish can be caught before the limit 
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

namespace _219016Fishing
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

        private void Btnclick_Click(object sender, RoutedEventArgs e)
        {
            int Trout = 1;
            int pike = 2;
            int Pickeral = 3;
            int Total = 2;
            for (int CountTrout = 0; CountTrout <= Trout; CountTrout++)
            {
                for (int CountPike = 0; CountPike <= pike; CountPike++)
                {
                    for (int CountPickeral = 0; CountPickeral <= Pickeral; CountPickeral++)
                    {
                        if (CountTrout*CountPike*CountPickeral<=Total)

                        lblOutput.Content += CountTrout.ToString() + "\t" + CountPike.ToString() +"\t" +CountPickeral.ToString() +"\t" + Environment.NewLine;
                    }
                }
            }
        }
}   }

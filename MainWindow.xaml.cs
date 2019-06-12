/*David Laughton
 * June 12th 2019
 * Baseball runs s1 2017
 */

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

namespace CulminatingProblemS1SumGame
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

        private void Click_Click(object sender, RoutedEventArgs e)
        {
            int days;
            int.TryParse(NInput.Text, out days);

            string scoreOne = SwiftsRunsInput.Text;
            string[] splitOne = scoreOne.Split(null);
            int[] one = Array.ConvertAll(splitOne, int.Parse);

            string scoreTwo = SemaphoresRunsInput.Text;
            string[] splitTwo = scoreTwo.Split(null);
            int[] two = Array.ConvertAll(splitTwo, int.Parse);
            Int64 total = 0;
            Int64 total2 = 0;

            for (int i = 0; i < two.Length; i++)
            {
                total += one[i];
                total2 += two[i];
            }
            if (total == total2)
            {
                lblOutput.Content = two.Length;
            }
            else
            {
                for (int j = two.Length - 1; j >= 0; j-- )
                {
                    total -= one[j];
                    total2 -= two[j];
                    if (total == total2)
                    {
                        lblOutput.Content = j;
                        break;
                    }
                    else
                    {
                        lblOutput.Content = "0";
                    }
                }
            }
        }
    }
}

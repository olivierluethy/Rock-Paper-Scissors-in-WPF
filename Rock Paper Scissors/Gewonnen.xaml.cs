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

namespace Rock_Paper_Scissors
{
  /// <summary>
  /// Interaktionslogik für Gewonnen.xaml
  /// </summary>
  public partial class Gewonnen : Window
  {
    public Gewonnen()
    {
      InitializeComponent();
    }

    private void btnReplay_Click(object sender, RoutedEventArgs e)
    {
      this.Hide();
      MainWindow f1 = new MainWindow();
      f1.ShowDialog();
      this.Close();
    }

    private void btnFinish_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}

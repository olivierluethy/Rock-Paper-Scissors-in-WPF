using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Rock_Paper_Scissors
{
  /// <summary>
  /// Interaktionslogik für MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    int PunkteUser = 0;
    int PunkteComputer = 0;

    public void CheckWinner(int Computer, int User)
    {
      if (Computer == 10){
        this.Hide();
        Verloren f1 = new Verloren();
        f1.ShowDialog();
        this.Close();
      }
      else if (User == 10){
        this.Hide();
        Gewonnen f1 = new Gewonnen();
        f1.ShowDialog();
        this.Close();
      }
    }

    private void btnRock_Click(object sender, RoutedEventArgs e)
    {
      Endscheidung_User.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/rock.png", UriKind.Relative));

      Random rnd = new Random();
      int entscheidung = rnd.Next(1, 4);

      if (entscheidung == 1){
        Endscheidung_Computer.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/rock.png", UriKind.Relative));
        lblResult.Content = "Beide haben das Gleiche!";
      }
      else if (entscheidung == 2){
        Endscheidung_Computer.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/paper.png", UriKind.Relative));
        lblResult.Content = "Der Computer hat gewonnen!";
        PunkteComputer++;
        lblPunkteComputer.Content = PunkteComputer.ToString();
        lblPunkteUser.Content = PunkteUser.ToString();
      }
      else if (entscheidung == 3){
        Endscheidung_Computer.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/scissor.png", UriKind.Relative));
        lblResult.Content = "Du hast gewonnen!";
        PunkteUser++;
        lblPunkteComputer.Content = PunkteComputer.ToString();
        lblPunkteUser.Content = PunkteUser.ToString();
      }
      CheckWinner(PunkteComputer, PunkteUser);
    }

    private void btnPaper_Click(object sender, RoutedEventArgs e)
    {
      Endscheidung_User.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/paper.png", UriKind.Relative));

      Random rnd = new Random();
      int entscheidung = rnd.Next(1, 4);

      if (entscheidung == 1){
        Endscheidung_Computer.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/rock.png", UriKind.Relative));
        lblResult.Content = "Du hast gewonnen!";
        PunkteUser++;
        lblPunkteComputer.Content = PunkteComputer.ToString();
        lblPunkteUser.Content = PunkteUser.ToString();
      }
      else if (entscheidung == 2){
        Endscheidung_Computer.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/paper.png", UriKind.Relative));
        lblResult.Content = "Beide haben das Gleiche!";
      }
      else if (entscheidung == 3){
        Endscheidung_Computer.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/scissor.png", UriKind.Relative));
        lblResult.Content = "Der Computer hat gewonnen!";
        PunkteComputer++;
        lblPunkteComputer.Content = PunkteComputer.ToString();
        lblPunkteUser.Content = PunkteUser.ToString();
      }
      CheckWinner(PunkteComputer, PunkteUser);
    }

    private void btnScissor_Click(object sender, RoutedEventArgs e)
    {
      Endscheidung_User.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/scissor.png", UriKind.Relative));

      Random rnd = new Random();
      int entscheidung = rnd.Next(1, 4);

      if (entscheidung == 1){
        Endscheidung_Computer.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/rock.png", UriKind.Relative));
        lblResult.Content = "Der Computer hat gewonnen!";
        PunkteComputer++;
        lblPunkteComputer.Content = PunkteComputer.ToString();
        lblPunkteUser.Content = PunkteUser.ToString();
      }
      else if (entscheidung == 2){
        Endscheidung_Computer.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/scissor.png", UriKind.Relative));
        lblResult.Content = "Beide haben das Gleiche!";
      }
      else if (entscheidung == 3){
        Endscheidung_Computer.Source = new BitmapImage(new Uri(@"/Rock Paper Scissors;component/Images/paper.png", UriKind.Relative));
        lblResult.Content = "Du hast gewonnen!";
        PunkteUser++;
        lblPunkteComputer.Content = PunkteComputer.ToString();
        lblPunkteUser.Content = PunkteUser.ToString();
      }
      CheckWinner(PunkteComputer, PunkteUser);
    }
  }
}

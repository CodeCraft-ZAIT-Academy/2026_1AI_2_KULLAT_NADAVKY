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

namespace Nadavky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string nadavky = "trulo,truba,geno,hlupacik";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] ZoznamNadavok = nadavky.Split(","); 
            if (ZoznamNadavok.Any(nadavky =>txtboxPouzivatel.Text.Contains(nadavky, StringComparison.InvariantCultureIgnoreCase)))
            {
                MessageBox.Show("Obsahuje nadavku");
            }
            else
            {
                MessageBox.Show("Text neobsahuje nadavku.");
            }



        }
        
         
          
        
       
        
        
        
        
    }
}
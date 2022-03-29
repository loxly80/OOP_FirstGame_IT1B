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

namespace OOP_FirstGame_IT1B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Character character1;
        Character character2;
    
        public MainWindow()
        {
            InitializeComponent();
            character1 = new Character("Petr");
            character2 = new Character("Pavel");
            Txt1.Text = character1.ToString();
            Txt2.Text = character2.ToString();
        }

        private void Attack_Click(object sender, RoutedEventArgs e)
        {
            character2.GetHit(character1.Damage);
            Txt2.Text = character2.ToString();
        }

        private void Heal_Click(object sender, RoutedEventArgs e)
        {
            character1.Heal();
            Txt1.Text = character1.ToString();
        }
    }
}

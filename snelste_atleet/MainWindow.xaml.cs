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

namespace snelste_atleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nameFastest;
        int secondsFastest = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this .Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Clear();
            secondenTextBox.Clear();
            resultTextBox.Clear();

            nameTextBox.Focus();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValidNumber = int.TryParse(secondenTextBox.Text, out int secondsCurrent);
            //int secondsCurrent;

            if (isValidNumber)
            {
                if (secondsFastest == 0 || secondsFastest < secondsFastest)
                {
                    secondsFastest = secondsCurrent;
                    nameFastest = nameTextBox.Text;
                }
                nameTextBox.Clear();
                secondenTextBox .Clear();
                nameTextBox .Focus();
            }
        }

        private void fastestButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = $"De snelste atleet is {nameFastest} met een tijd van {secondsFastest} seconden";
        }
    }
}
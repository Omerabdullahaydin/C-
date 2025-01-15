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

namespace Yapılacaklar_Listesi
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = Text.Text;
            if (!string.IsNullOrEmpty(text))
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = text,
                    Margin = new Thickness(10),

                };
                CheckBox check = new CheckBox()
                {
                    Margin = new Thickness(10,10,2,10),
                };
                Panel.Children.Add(check);
                Panel.Children.Add(textBlock);

                Text.Clear();
            }
        }
    }
}
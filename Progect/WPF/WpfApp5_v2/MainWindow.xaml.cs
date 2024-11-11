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

namespace WpfApp5_v2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            // Сброс стилей всех текстовых полей
            ResetTextBoxStyles();

            // Установка стиля для активного текстового поля
            if (sender is TextBox activeTextBox)
            {
                activeTextBox.Style = (Style)Resources["LargeTextBoxStyle"];
            }
        }

        private void ResetTextBoxStyles()
        {
            // Сброс стилей для всех текстовых полей
            LeftLargeTextBox.Style = (Style)Resources["SmallTextBoxStyle"];
            RightLargeTextBox.Style = (Style)Resources["SmallTextBoxStyle"];

            foreach (var child in LogicalTreeHelper.GetChildren(LeftLargeTextBox.Parent))
            {
                if (child is TextBox textBox)
                {
                    textBox.Style = (Style)Resources["SmallTextBoxStyle"];
                }
            }

            foreach (var child in LogicalTreeHelper.GetChildren(RightLargeTextBox.Parent))
            {
                if (child is TextBox textBox)
                {
                    textBox.Style = (Style)Resources["SmallTextBoxStyle"];
                }
            }
        }
    }
}

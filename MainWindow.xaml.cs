using System.Windows;

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void saludarButton_Click(object sender, RoutedEventArgs e)
        {
            NombreTextBlock.Text = "Hola " + NombreTextBox.Text;
        }

        
    }
}

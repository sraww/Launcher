using GameLauncher.View.Resources;
using System.Windows;
using System.Windows.Input;

namespace GameLauncher.View
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

        private void WowPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new WowPage());
        }

        private void HSPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HSPage());
        }

        private void OWPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new OWPage());
        }

        private void W3Page_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new W3Page());
        }

        private void D3Page_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new D3Page());
        }

        private void HOTSPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HOTSPage());
        }

        private void SC2Page_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SC2Page());
        }

        private void SCPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SCPage());
        }

        // Премещение окна
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SCPage());
           // MessageBox.Show("Здесь скоро появятся новые игры", "Сообщение");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Скоро","Сообщение");
          
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Скоро", "Сообщение");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Скоро", "Сообщение");
        }
    }
}

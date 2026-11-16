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

namespace LoginPage
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
        public void click_login(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(password.Password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (txt_username.Text != "An" || password.Password != "*")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không đúng", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBox.Show("Đăng nhập thành công", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
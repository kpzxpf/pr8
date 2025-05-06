using System.Windows;
using Pr8.entity;

namespace Pr8;

public partial class LoginWindow : Window
{
    private AppDbContext _context = new AppDbContext();

    public LoginWindow()
    {
        InitializeComponent();
    }

    private void Login_Click(object sender, RoutedEventArgs e)
    {
        User user = _context.users.FirstOrDefault(u => u.email == loginEmailTextBox.Text && u.password == loginPasswordBox.Password);
            
        if (user != null)
        {
            MessageBox.Show("Добро пожаловать, " + user.first_name);
                
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        else
        {
            MessageBox.Show("Неверный Email или пароль");
        }
    }

    private void OpenRegisterWindow(object sender, RoutedEventArgs e)
    {
        RegisterWindow registerWindow = new RegisterWindow();
        registerWindow.Show();
        this.Close();
    }
}
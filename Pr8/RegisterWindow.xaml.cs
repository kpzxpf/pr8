using System.Windows;
using Pr8.entity;

namespace Pr8;

public partial class RegisterWindow : Window
{
    private AppDbContext _context = new AppDbContext();

    public RegisterWindow()
    {
        InitializeComponent();
    }

    private void Register_Click(object sender, RoutedEventArgs e)
    {
        if (passwordBox.Password != confirmPasswordBox.Password)
        {
            MessageBox.Show("Пароли не совпадают");
            return;
        }

        User user = new User
        {
            last_name = lastNameTextBox.Text,
            first_name = firstNameTextBox.Text,
            middle_name = middleNameTextBox.Text,
            email = emailTextBox.Text,
            password = passwordBox.Password,
            role = User.UserRole.User
        };

        _context.users.Add(user);
        _context.SaveChanges();

        MessageBox.Show("Регистрация успешна");
        
        LoginWindow loginWindow = new LoginWindow();
        loginWindow.Show();
        this.Close();
    }
}
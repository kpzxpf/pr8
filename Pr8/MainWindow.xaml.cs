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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pr8.entity;

namespace Pr8;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        LoadUsers();
    }

    private async void LoadUsers()
    {
        using (var context = new AppDbContext())
        {
            List<User> users = await context.users.ToListAsync();
            UsersDataGrid.ItemsSource = users;
        }
    }

    private void ViewPurchaseHistoryButton_Click(object sender, RoutedEventArgs e)
    {
        if (UsersDataGrid.SelectedItem is User selectedUser)
        {
            PurchaseHistory purchaseHistoryWindow = new PurchaseHistory(selectedUser.id);
            purchaseHistoryWindow.Show();
        }
        else
        {
            MessageBox.Show("Выберите пользователя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
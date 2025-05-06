using System.Windows;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;
using Pr8.entity;

namespace Pr8;

public partial class PurchaseHistory : Window
{
    private List<Purchase> _allPurchases = new();
    public List<string> Categories { get; set; }
    public string SelectedCategory { get; set; } = "Все";

    private int _userId;

    public PurchaseHistory(int userId)
    {
        InitializeComponent();
        
        _userId = userId;
        Categories = new List<string> { "Все", "Электроника", "Одежда", "Книги", "Бытовая техника" };
        DataContext = this;
        
        LoadPurchases();
    }

    private async void LoadPurchases()
    {
        using (var context = new AppDbContext())
        {
            _allPurchases = await context.purchases
                .Where(p => p.user_id == _userId) 
                .ToListAsync();

            ApplyFilter();
        }
    }

    private void ApplyFilter()
    {
        var filteredPurchases = SelectedCategory == "Все"
            ? _allPurchases
            : _allPurchases.Where(p => p.category.ToString() == SelectedCategory).ToList();

        PurchasesGrid.ItemsSource = filteredPurchases;
    }

    private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        SelectedCategory = (string)((ComboBox)sender).SelectedItem;
        ApplyFilter();
    }
}
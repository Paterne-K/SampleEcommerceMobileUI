using System.Collections.ObjectModel;
using System.Windows.Input;
using SampleEcommerceMobileUI.Models;
using SampleEcommerceMobileUI.Services;

namespace SampleEcommerceMobileUI.ViewModels;

/// <summary>
/// ViewModel for the Categories page. Displays all product categories.
/// </summary>
public class CategoriesViewModel : BaseViewModel
{
    private readonly MockDataService _dataService;

    public ObservableCollection<Category> Categories { get; } = new();
    public ICommand NavigateToCategoryCommand { get; }

    public CategoriesViewModel(MockDataService dataService)
    {
        _dataService = dataService;
        Title = "Categories";
        NavigateToCategoryCommand = new Command<Category>(async (c) => await NavigateToCategory(c));
        LoadCategories();
    }

    private void LoadCategories()
    {
        Categories.Clear();
        foreach (var category in _dataService.GetCategories())
            Categories.Add(category);
    }

    private async Task NavigateToCategory(Category category)
    {
        if (category == null) return;
        await Shell.Current.GoToAsync($"productlist?category={Uri.EscapeDataString(category.Name)}");
    }
}

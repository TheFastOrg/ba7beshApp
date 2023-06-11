using System;
using bahbashApp.ViewModels.Base;

namespace bahbashApp.Views;

public abstract class ContentPageBase : ContentPage
{
    protected ContentPageBase()
    {
        NavigationPage.SetBackButtonTitle(this, string.Empty);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is not IViewModelBase viewModel)
        {
            return;
        }

        await viewModel.InitializeAsyncCommand.ExecuteAsync(null);
    }
}


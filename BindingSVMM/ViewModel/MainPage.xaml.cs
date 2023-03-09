namespace BindingSVMM;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        (sender as ListView).SelectedItem = null;

        if (args.SelectedItem != null)
        {
            DataModel DataHal = args.SelectedItem as DataModel;
            Page Halaman = (Page)Activator.CreateInstance(DataHal.Data);
            await Navigation.PushAsync(Halaman);
        }
    }


}



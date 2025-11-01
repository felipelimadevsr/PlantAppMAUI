using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PlantAppMAUI.ViewModels
{
    public partial class PlantSettingsVM : ObservableObject
    {
        public PlantSettingsVM()
        {

        }

        [RelayCommand]
        private async Task GoToHome() => await Shell.Current.GoToAsync("//HomePage");
        [RelayCommand]
        private async Task GoToPlantDisplay() => await Shell.Current.GoToAsync("//PlantDisplayPage");
    }
}

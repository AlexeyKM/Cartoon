using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cartoon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            CartoonModel model = await LoadSunInfo();

            lblIdCharacter.Content = "IdCharacter: " + model.Results.Sunrise.ToLocalTime();
            lblPicture.Content = "Picture: " + model.Results.Sunset.ToLocalTime();
            lblLocation.Content = "Info Day Lendth: " + model.Results.Day_Length.TimeOfDay;
            lblSpecies.Content = "Status " + model.Results.Day_Length.TimeOfDay;
        }
        private async Task<CartoonModel> LoadSunInfo()
        {
            return await SunProcessor.LoadSunInfo(55.809062f, 37.622382f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValuteConverter.ViewModels;
using Xamarin.Forms;

namespace ValuteConverter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            ((MainViewModel)BindingContext).LoadCurrencies(e.NewDate);
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue)) return;

            if (!double.TryParse(e.NewTextValue, out double value))
            {
                ((Entry)sender).Text = e.OldTextValue;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDC60Module02.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace PDC60Module02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }
    }
}
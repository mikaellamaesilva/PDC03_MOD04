using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity3 : ContentPage
    {
        ObservableCollection<Item> items = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items { get { return items; } }

        public activity3()
        {
            InitializeComponent();

            ItemView.ItemsSource = items;

            items.Add(new Item { Name = "Rose", ImageCredit = "Photo from Wikimedia", Image = "rose.jpg" });
            items.Add(new Item { Name = "Carnation", ImageCredit = "Photo from Impex ", Image = "carnation.jpg" });
            items.Add(new Item { Name = "Tulips", ImageCredit = "Photo from JSPN", Image = "tulips.jpg" });
            items.Add(new Item { Name = "Sunflower", ImageCredit = "Photo from Thursd", Image = "sunflower.jpg" });
            items.Add(new Item { Name = "Daisy", ImageCredit = "Photo from Dengarden", Image = "daisy.jpg" });
            items.Add(new Item { Name = "Lily", ImageCredit = "Photo from HFBC", Image = "Lily.jpg" });

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace PDC03_MOD04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity2 : ContentPage
    {
        ObservableCollection<Item> items = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items { get { return items; } }
        public activity2()
        {
            InitializeComponent();
            ItemView.ItemsSource = items;

            items.Add(new Item { Name = "Amber", ImageCredit = "Photo from Amazon", Image = "cat.png" });
            items.Add(new Item { Name = "Mocha", ImageCredit = "Photo from AAHA", Image = "dog.jpg" });
            items.Add(new Item { Name = "Taylor", ImageCredit = "Photo from iStock", Image = "horse.jpg" });
            items.Add(new Item { Name = "Peppa", ImageCredit = "Photo from DK Find out", Image = "pig.jpg" });
            items.Add(new Item { Name = "Zebby", ImageCredit = "Photo from DK Find out", Image = "zebra.jpg" });

        }
    }
}
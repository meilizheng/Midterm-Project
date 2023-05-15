using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Shapes;

namespace Midterm_Project
{
    /// <summary>
    /// Interaction logic for Add_New_Products.xaml
    /// </summary>
    public partial class AddNewProducts : Window
    {
        public AddNewProducts()
        {
            InitializeComponent();

            PopulateSizeComboBox();  //populate size

            DataBind(); //bind data;

           
        }

        void DataBind() //call static class to display data 
        {
            lbProductInfor.ItemsSource = Data.ProductCollection;
        }


        public void btnCoffee_Click(object sender, RoutedEventArgs e) //add coffee to product collection;
        {            
            Coffee coffee = new Coffee(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), (Drink.Size)Enum.Parse(typeof(Drink.Size), cbSize.SelectedValue.ToString()), txtRoastOrTea.Text);

            Data.ProductCollection.Add(coffee);
        }

        private void btnTea_Click(object sender, RoutedEventArgs e) //add tea to product collection;
        {
            Tea tea = new Tea(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), (Drink.Size)Enum.Parse(typeof(Drink.Size), cbSize.SelectedValue.ToString()), txtRoastOrTea.Text);
            Data.ProductCollection.Add(tea);
        }

        private void btnBreakfast_Click(object sender, RoutedEventArgs e) //if the check box has been check add it to product collection;
        {
            if (ckIsHeated.IsChecked.Value && ckHasDairy.IsChecked.Value)
            {
                Breakfast breakfast = new Breakfast(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), ckIsHeated.IsChecked.Value, ckHasDairy.IsChecked.Value);
                Data.ProductCollection.Add(breakfast);
            }
            else if (ckIsHeated.IsChecked.Value)
            {
                Breakfast breakfast = new Breakfast(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), ckIsHeated.IsChecked.Value);
                Data.ProductCollection.Add(breakfast);
            }
            else if (ckHasDairy.IsChecked.Value)
            {
                Breakfast breakfast = new Breakfast(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), ckHasDairy.IsChecked.Value);
                Data.ProductCollection.Add(breakfast);
            }
        }

        public void PopulateSizeComboBox() 
        {
            cbSize.Items.Add("Short");
            cbSize.Items.Add("Tall");
            cbSize.Items.Add("Grande");
            cbSize.Items.Add("Venti");
            cbSize.Items.Add("Trenta");
            cbSize.SelectedIndex = 0;
        }

        private void btnlunch_Click(object sender, RoutedEventArgs e) //if the check box has been check add it to product collection;
        {
            if (ckIsHeated.IsChecked.Value && ckHasDairy.IsChecked.Value)
            {
                Lunch lunch = new Lunch(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), ckIsHeated.IsChecked.Value, ckHasDairy.IsChecked.Value);
                Data.ProductCollection.Add(lunch);
            }
            else if (ckIsHeated.IsChecked.Value)
            {
                Lunch lunch = new Lunch(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), ckIsHeated.IsChecked.Value);
                Data.ProductCollection.Add(lunch);
            }
            else if (ckHasDairy.IsChecked.Value)
            {
                Lunch lunch = new Lunch(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), ckHasDairy.IsChecked.Value);
                Data.ProductCollection.Add(lunch);
            }
        }

        private void btnTumbler_Click(object sender, RoutedEventArgs e) //add tumblers to product collection;
        {
            Tumblers tumblers = new Tumblers(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), txtColorOrStyle.Text);
            Data.ProductCollection.Add(tumblers);
        }

        private void btnMug_Click(object sender, RoutedEventArgs e) //add mug to product collection;
        {
            Mugs mug = new Mugs(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), txtColorOrStyle.Text);
            Data.ProductCollection.Add(mug);
        }

        public void btnGiftCard_Click(object sender, RoutedEventArgs e) //add gift card to producto collection;
        {
            GiftCard gift = new GiftCard(txtName.Text, double.Parse(txtPrice.Text), double.Parse(txtPoints.Text), double.Parse(txtPoints.Text));
            Data.ProductCollection.Add(gift);
        }
    }
}

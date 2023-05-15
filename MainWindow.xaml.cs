using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Midterm_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window  //Main Window;
    {      
        public MainWindow()
        {
            InitializeComponent();
            BindData();
        }

        void BindData()  //created a method all the static class to disply the information in different place 
        {
            cbMemberInfo.ItemsSource = Data.MemberCollection;
            lbProductsInfo.ItemsSource = Data.ProductCollection;
        }

        public void btnAddProducts_Click(object sender, RoutedEventArgs e) //open new window;
        {
            AddNewProducts addnewproducts = new AddNewProducts();
            if (addnewproducts.ShowDialog() == true)
            {

            }
        }

        public void btnMemberInfor_Click(object sender, RoutedEventArgs e) //open new window;
        {
            MemberInformation addMemberWindow = new MemberInformation();            

            if (addMemberWindow.ShowDialog() == true)
            {
            
            }
        }

        private void btnBuyProducts_Click(object sender, RoutedEventArgs e) //a event when you select the member add member's previos transaction points;
        {
            Member selectedMemember = (Member)cbMemberInfo.SelectedItem;
            selectedMemember.AddProduct((Product)lbProductsInfo.SelectedItem);

            lbMemberTransations.ItemsSource = selectedMemember.PreviousTransactions;

            txtUserPoints.Text = selectedMemember.PointAmount.ToString();
        }

        private void btnUsePoints_Click(object sender, RoutedEventArgs e) //deduct the points from the total points;
        {            
            Member selectedMemember = (Member)cbMemberInfo.SelectedItem;
            Product productToBuy = (Product)lbProductsInfo.SelectedItem;

            selectedMemember.DeductPoints(productToBuy);

            txtUserPoints.Text = selectedMemember.PointAmount.ToString();
        }

        private void cbMemberInfo_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
            Member selectedMemember = (Member)cbMemberInfo.SelectedItem;
            lbMemberTransations.ItemsSource = selectedMemember.PreviousTransactions;

            txtUserPoints.Text = selectedMemember.PointAmount.ToString();
        }
    }
}

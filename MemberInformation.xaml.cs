using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.RightsManagement;
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
    /// Interaction logic for MemberInformation.xaml
    /// </summary>
    public partial class MemberInformation : Window  //created a MemberInformation class base on window;
    {
        public MemberInformation()   //creat method to call the method;
        {
            InitializeComponent();
            DataBind();

            //lbTransactionInfor1.Items.Add(Window.lbTrans)
        }

        void DataBind()  //created a method to bind the data;
        {
            lbMemberInformation.ItemsSource = Data.MemberCollection;
           
        }

        public void btnAddMember_Click(object sender, RoutedEventArgs e)  //a event;
        {
            Member m = null;            

            if (rbRegular.IsChecked.HasValue && rbRegular.IsChecked.Value)  //if the check box checked add the information to member collection;
            {
                m = new RegularMember(txtFirstName.Text, txtLastname.Text);
            }
            else if (rbGoldmember.IsChecked.HasValue && rbGoldmember.IsChecked.Value)
            {
                m = new GoldMember(txtFirstName.Text, txtLastname.Text);
            }

            Data.MemberCollection.Add(m);
        }

        private void lbMemberInformation_SelectionChanged(object sender, SelectionChangedEventArgs e) //if member has been selected. display the member's previous transaction;
        {
            Member selectedMemember = (Member)lbMemberInformation.SelectedItem;
            lbTransactionInfor1.ItemsSource = selectedMemember.PreviousTransactions;
        }
    }
}

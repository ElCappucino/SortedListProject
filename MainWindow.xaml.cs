using System;
using System.Collections;
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

namespace SortedListProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string allValue = "Value : ";
            sortedList.Add(KeyTxt.Text, ValueTxt.Text);

            ICollection icollection = sortedList.Keys;
            foreach (string key in icollection)
            {
                allValue += sortedList[key].ToString() + " ";
            }
            MessageBox.Show(allValue);
        }
    }
}

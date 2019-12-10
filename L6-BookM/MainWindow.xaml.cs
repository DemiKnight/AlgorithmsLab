using System;
using System.Windows;
using System.Windows.Controls;
using L6_Ex3;

namespace L6_BookM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BookManager bookManager = new BookManager();

        private Book result = null;
//        ref Book test = null;

        public MainWindow()
        {
            InitializeComponent();

        }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            base.OnContentChanged(oldContent, newContent);
        }

        private void toggleFound()
        {
            checkBoxOnLoan.IsChecked = false;
            checkBoxOnLoan.IsEnabled = !checkBoxOnLoan.IsEnabled;
            TextBoxAltDetails.Text = "";
            TextBoxAltDetails.IsEnabled = !TextBoxAltDetails.IsEnabled;
        }


        private void updateDetailsPane(ref Book toUpdate)
        {
            checkBoxOnLoan.IsChecked = toUpdate.OnLoan;
            TextBoxAltDetails.Text = toUpdate.Isbn;
            TextBoxSearch.Text = toUpdate.Name;

        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListVewBox.Items.Clear();

            foreach (Book selectBook in bookManager.searchBooks(((TextBox)sender).Text))
            {
                ListVewBox.Items.Add(selectBook);
            }

            if (ListVewBox.Items.Count == 1)
            {
                toggleFound();

                result = bookManager.searchBooks(TextBoxSearch.Text)[0];

//                updateDetailsPane(ref bookManager.searchBooks(TextBoxSearch.Text)[0]);
            }
            else
            {
                toggleFound();
            }
        }

        private void checkBoxOnLoan_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ListVewBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0)
            {
                toggleFound();
                updateDetailsPane(ref bookManager.searchBooks(e.AddedItems[0].ToString())[0]);

                Console.WriteLine(e.AddedItems[0].ToString());
            }
            else
            {
                toggleFound();
            }
        }
    }
}

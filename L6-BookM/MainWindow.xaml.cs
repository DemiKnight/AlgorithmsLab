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
        private Boolean SearchingWithName = true;
        private Boolean IsAdding = false;
//        ref Book test = null;

        public MainWindow()
        {
            InitializeComponent();

            foreach (Book selectBook in bookManager.getBooks())
            {
                ListVewBox.Items.Add(selectBook);
            }

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


        private void updateDetailsPane(Book toUpdate)
        {
            //TODO Can change later, to only update the changes.



            checkBoxOnLoan.IsChecked = toUpdate.OnLoan;
            TextBoxAltDetails.Text = toUpdate.Isbn;
            TextBoxSearch.Text = toUpdate.Name;

        }

        private void updateList(String returnStr)
        {
            int returnVal = 0;
            // if (int.TryParse(returnStr, out returnVal) == false) SearchingWithName = true;

            SearchingWithName = ! int.TryParse(returnStr, out returnVal);

            ListVewBox.Items.Clear();

            foreach (Book selectBook in bookManager.searchBooks(returnStr))
            {
                ListVewBox.Items.Add(selectBook);
            }
        }


        private void updateState()
        {
            if(result != null)
            {
                checkBoxOnLoan.IsEnabled = true;
                checkBoxOnLoan.IsChecked = result.OnLoan;

                TextBoxAltDetails.IsEnabled = false;
                TextBoxAltDetails.Text = result.Isbn;

                ButtonAddRemoveB.IsEnabled = true;
                ButtonAddRemoveB.Content = "Remove";

            }
            else
            {
                checkBoxOnLoan.IsEnabled = false;
                checkBoxOnLoan.IsChecked = false;
                TextBoxAltDetails.IsEnabled = false;
                TextBoxAltDetails.Text = "";

                LabelNameOrISBN.Content = "Name or ISBN";
                LabelAltDetailsIndicator.Content = "";
            }

            if (SearchingWithName == true)
            {
                LabelNameOrISBN.Content = "Name";
                LabelAltDetailsIndicator.Content = "ISBN";
            }
            else
            {
                LabelNameOrISBN.Content = "ISBN";
               
                LabelAltDetailsIndicator.Content = "Name";
            }

            if(IsAdding == true)
            {
                ButtonAddRemoveB.IsEnabled = true;
                TextBoxAltDetails.IsEnabled = true;
                ButtonAddRemoveB.Content = "Add";
            } else if (IsAdding == false)
            {
                ButtonAddRemoveB.IsEnabled = true;
                TextBoxAltDetails.IsEnabled = false;
                ButtonAddRemoveB.Content = "Remove";
            }
            else
            {
                ButtonAddRemoveB.IsEnabled = false;
                TextBoxAltDetails.IsEnabled = false;
                ButtonAddRemoveB.Content = "";
            }
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateList(((TextBox) sender).Text);
            
            if (ListVewBox.Items.Count == 1)
            {
                // toggleFound();

                result = bookManager.searchBooks(TextBoxSearch.Text)[0];
                TextBoxAltDetails.Text = result.Isbn;
                checkBoxOnLoan.IsChecked = result.OnLoan;
                //ButtonAddRemoveB.IsEnabled = true;
                //ButtonAddRemoveB.Content = "Remove";

            } else if (ListVewBox.Items.Count == 0)
            {
                result = null;
                //ButtonAddRemoveB.IsEnabled = true;
                //ButtonAddRemoveB.Content = "Add";
            }
        }

        private void checkBoxOnLoan_Checked(object sender, RoutedEventArgs e)
        {
            if(result != null)
            {
                result.OnLoan = (((CheckBox)sender).IsChecked == true ? true : false);
            }
        }

        private void ListVewBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0)
            {
                Console.WriteLine(((Book) e.AddedItems[0]).Name);
                updateDetailsPane((Book) e.AddedItems[0]);
                result = ((Book)e.AddedItems[0]);

            }
        }

        private void ButtonAddRemoveB_Click(object sender, RoutedEventArgs e)
        {
            if(result == null)
            {
                bookManager.addBook(new Book(TextBoxAltDetails.Text, TextBoxSearch.Text));
            }
            else
            {
                bookManager.removeBook(bookManager.searchBooks(TextBoxSearch.Text)[0]);
            }
        }
    }
}

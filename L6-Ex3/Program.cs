using System;
using Terminal.Gui;

namespace L6_Ex3
{
    class Program
    {
        static BookManager bookM = new BookManager();
        
        
        static void Main(string[] args)
        {
            bookM.addBook(new Book("9780393356250", "Odyssey"));
            bookM.addBook(new Book("9780151010264", "Animal Farm"));
            bookM.addBook(new Book("9780141439518", "Pride and Prejudice"));
            bookM.addBook(new Book("9781520560885", "Through the Looking-Glass"));
            
            Application.Init();
            
            Toplevel mainTop = Application.Top;

            Window win = new Window("Book Manager")
            {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };
            
            App.SetupView(win);
            /*
             TextField bookEntry = new TextField("Book Name")
             {
                 X = 1,
                 Y = 2
             };
             
             win.Add(bookEntry);
             
             ListView bookList = new ListView(mainTop.Frame, bookM.getBooks())
             {
                 X = 4,
                 Y = 2,
                 Height = Dim.Fill(),
                 Width = Dim.Fill()
             };
             
//             bookList.Source.
             
             win.Add(bookList);*/
            
            mainTop.Add(win);
            
            Application.Run();
            
        }
    }
}
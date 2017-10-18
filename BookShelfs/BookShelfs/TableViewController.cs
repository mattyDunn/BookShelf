using Foundation;
using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using UIKit;

namespace BookShelfs
{
    public partial class TableViewController : UITableViewController
    {

        List<Book> bookList;
        public TableViewController (IntPtr handle) : base (handle)
        {
            bookList = new List<Book>();

            bookList.Add(new Book ()
            {
                Name = "Harry Potter", 
                Author = "J.K.K Rowling", 
                Editor = "Bloomsberry", 
                Year = 1998
            });

			bookList.Add(new Book()
			{
				Name = "Harry Potter 2",
				Author = "J.K.K Rowling",
				Editor = "Bloomsberry",
				Year = 1999
			});

			bookList.Add(new Book()
			{
				Name = "Harry Potter 3",
				Author = "J.K.K Rowling",
				Editor = "Bloomsberry",
				Year = 2000
			});

        }

        public override nint NumberOfSections (UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return bookList.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Book") as BookTableViewCell;

            var data = bookList[indexPath.Row];

            cell.BookData = data;

            return cell;
        }
    }

    public class Book
    {
        public string Name;
        public string Author;
        public string Editor;
        public int Year;
    }
}
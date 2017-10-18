using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BookShelfs
{
    public partial class BookTableViewCell : UITableViewCell
    {
        private Book bookData;

        public Book BookData
        {
            get { return bookData;  }
          
            set{ 
                bookData = value;
                bookAuthorLabel.Text = bookData.Author;
                bookNameLabel.Text = bookData.Name;
                bookEditorLabel.Text = bookData.Editor;
                bookYearLabel.Text = bookData.Year.ToString();
            } 
        }

        public BookTableViewCell (IntPtr handle) : base (handle)
        {
            
        }
    }
}
// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BookShelfs
{
    [Register ("BookTableViewCell")]
    partial class BookTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bookAuthorLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bookEditorLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bookNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bookYearLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bookAuthorLabel != null) {
                bookAuthorLabel.Dispose ();
                bookAuthorLabel = null;
            }

            if (bookEditorLabel != null) {
                bookEditorLabel.Dispose ();
                bookEditorLabel = null;
            }

            if (bookNameLabel != null) {
                bookNameLabel.Dispose ();
                bookNameLabel = null;
            }

            if (bookYearLabel != null) {
                bookYearLabel.Dispose ();
                bookYearLabel = null;
            }
        }
    }
}
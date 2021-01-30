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

namespace MuscleApp.iOS
{
    [Register ("ItemDetailViewController")]
    partial class BrowseItemDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EditBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView ExcerciseTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (EditBtn != null) {
                EditBtn.Dispose ();
                EditBtn = null;
            }

            if (ExcerciseTable != null) {
                ExcerciseTable.Dispose ();
                ExcerciseTable = null;
            }
        }
    }
}
// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MuscleApp.iOS.ViewControllers
{
    [Register ("ArchiveViewController")]
    partial class ArchiveViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView ArchiveTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ArchiveTable != null) {
                ArchiveTable.Dispose ();
                ArchiveTable = null;
            }
        }
    }
}
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace MuscleApp.iOS.ViewControllers
{
	//[Register("ExcerciseAddViewController")]
	public class ExcerciseAddViewController : UITableViewController
    {
        [Outlet]
         UIKit.UIButton btnSave { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (btnSave != null)
            {
                btnSave.Dispose();
                btnSave = null;
            }
        }
    }
}
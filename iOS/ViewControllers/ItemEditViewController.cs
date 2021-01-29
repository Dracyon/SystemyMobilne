using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UIKit;

namespace MuscleApp.iOS.ViewControllers
{
	[Register("ItemEditViewController"), DesignTimeVisible(true)]
	public class ItemEditViewController : UIViewController
	{
        public ItemsViewModel ViewModel { get; set; }

        public ItemEditViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //btnSaveItem.TouchUpInside += (sender, e) =>
            //{
            //    var item = new Item
            //    {
            //        Text = txtTitle.Text,
            //        Description = txtDesc.Text
            //    };
            //    ViewModel.AddItemCommand.Execute(item);
            //    NavigationController.PopToRootViewController(true);
            //};
        }
        [Outlet]
		UIButton btnSaveItem { get; set; }

        [Outlet]
		UITextField txtDesc { get; set; }

		[Outlet]
		UITextField txtTitle { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (btnSaveItem != null)
            {
                btnSaveItem.Dispose();
                btnSaveItem = null;
            }

            if (txtDesc != null)
            {
                txtDesc.Dispose();
                txtDesc = null;
            }

            if (txtTitle != null)
            {
                txtTitle.Dispose();
                txtTitle = null;
            }
        }

    }
}
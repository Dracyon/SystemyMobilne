using MuscleApp.ViewModels;
using System;
using UIKit;

namespace MuscleApp.iOS
{
	public partial class BrowseItemDetailViewController : UIViewController
	{
		public ItemDetailViewModel ViewModel { get; set; }
		public ItemsViewModel ItemsViewModel { get; set; }
		public BrowseItemDetailViewController(IntPtr handle) : base(handle) { }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var head = new UIView(frame: new CoreGraphics.CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, 50));
			head.BackgroundColor = UIColor.Red;

			UILabel label = new UILabel(head.Frame);
			label.Text = ViewModel.Item.Description;
			head.Add(label);

			var foot = new UIView(frame: new CoreGraphics.CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, 50));

			EditBtn.Frame = foot.Frame;
			foot.Add(EditBtn);


			ExcerciseTable = new UITableView(View.Bounds);
			ExcerciseTable.Source = new TableSource(ViewModel.Item.Exercises);
			ExcerciseTable.TableHeaderView = head;
			ExcerciseTable.TableFooterView = foot;

			Add(ExcerciseTable);
		}

	}

}

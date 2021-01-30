using Foundation;
using MuscleApp.Models;
using MuscleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using UIKit;

namespace MuscleApp.iOS.ViewControllers
{
	[Register("ExcerciseAddViewController")]
	public class ExcerciseAddViewController : UIViewController
	{
		public ItemDetailViewModel ViewModel { get; set; }

		public ItemsViewModel ItemsViewModel { get; set; }

		public List<Exercise> Exercises;

		public ExcerciseAddViewController(IntPtr handle) : base(handle)
		{
			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Exercises = new List<Exercise>();

			
			ExcerciseTable = new UITableView(View.Bounds);
			ExcerciseTable.Source = new TableSource(Exercises);

			Exercises.Add(new Exercise
			{Id = "0", Name = "Sample Exercise", NumOfReps =1, Weight = 1
			});

			var foot = new UIView(frame: new CoreGraphics.CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, 50));

			AddBtn.Frame = foot.Frame;
			foot.Add(AddBtn);

			ExcerciseTable.TableFooterView = foot;

			Add(ExcerciseTable);

//			ViewModel.Item.Exercises = Exercises;
		}
		[Outlet]
		UITableView ExcerciseTable { get; set; }

		[Outlet]
		UIButton AddBtn { get; set; }

		public void ReleaseDesignerOutlets()
		{

			if (ExcerciseTable != null)
			{
				ExcerciseTable.Dispose();
				ExcerciseTable = null;
			}
			if (AddBtn != null)
			{
				AddBtn.Dispose();
				AddBtn = null;
			}
		}

	}
}
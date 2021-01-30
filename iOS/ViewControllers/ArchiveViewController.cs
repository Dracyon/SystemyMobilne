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
	[Register("ArchiveViewController")]
	public class ArchiveViewController : UIViewController
	{
		public ArchiveViewController(IntPtr handle) : base(handle)
		{

		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var Exercises = new List<TrainingHistory>{
				new TrainingHistory {TrainingName = "Sample Training", TrainingDate = DateTime.Today },
				new TrainingHistory {TrainingName = "Another Sample training", TrainingDate = DateTime.Today.AddDays(-1) }
			};

			ArchiveTable = new UITableView(View.Bounds);
			ArchiveTable.Source = new TrainingHistoryTableSource(Exercises);


			Add(ArchiveTable);


		}


		[Outlet]
		UITableView ArchiveTable { get; set; }
		public void ReleaseDesignerOutlets()
		{

			if (ArchiveTable != null)
			{
				ArchiveTable.Dispose();
				ArchiveTable = null;
			}
		}
	}
}
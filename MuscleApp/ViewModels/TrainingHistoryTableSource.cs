using Foundation;
using MuscleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace MuscleApp.ViewModels
{
	public class TrainingHistoryTableSource : UITableViewSource
	{

		string CellIdentifier = "TableCell";
		private List<TrainingHistory> exercises;

		public TrainingHistoryTableSource(List<TrainingHistory> exercises)
		{
			this.exercises = exercises;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			if (exercises == null)
			{
				return 0;
			}
			else
			{
				return exercises.Count;
			}
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
			var item = exercises.ElementAt(indexPath.Row);

			//if there are no cells to reuse, create a new one
			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Subtitle, CellIdentifier);
			}

			cell.TextLabel.Text = item.TrainingName;
			cell.DetailTextLabel.Text = " Date " + item.TrainingDate;

			return cell;
		}
	}
}

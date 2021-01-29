using System;

namespace MuscleApp
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public TrainingEntity Item { get; set; }
        public ItemDetailViewModel(TrainingEntity item = null)
        {
            if (item != null)
            {
                Title = item.Text;
                Item = item;
            }
        }
    }
}

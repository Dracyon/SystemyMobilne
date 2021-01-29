using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MuscleApp
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<TrainingEntity> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public Command AddItemCommand { get; set; }
        public Command EditItemCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<TrainingEntity>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            AddItemCommand = new Command<TrainingEntity>(async (TrainingEntity item) => await AddItem(item));
            EditItemCommand = new Command<TrainingEntity>(async (TrainingEntity item) => await EditItem(item));
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        async Task AddItem(TrainingEntity item)
        {
            Items.Add(item);
            await DataStore.AddItemAsync(item);
        }

        async Task EditItem(TrainingEntity item)
        {
            //update
            //Items.Add(item);
            await DataStore.UpdateItemAsync(item);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuscleApp
{
    public class MockDataStore : IDataStore<TrainingEntity>
    {
        List<TrainingEntity> items;

        public MockDataStore()
        {
            items = new List<TrainingEntity>();
            var _items = new List<TrainingEntity>
            {
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is a nice description"},
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is a nice description"},
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is a nice description"},
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is a nice description"},
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is a nice description"},
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is a nice description"},
            };

            foreach (TrainingEntity item in _items)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(TrainingEntity item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(TrainingEntity item)
        {
            var _item = items.Where((TrainingEntity arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((TrainingEntity arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<TrainingEntity> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<TrainingEntity>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}

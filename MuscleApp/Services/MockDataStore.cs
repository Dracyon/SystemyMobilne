using MuscleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuscleApp
{
    public class MockDataStore : IDataStore<TrainingEntity>
    {
        List<TrainingEntity> items;
        List<Exercise> excercises;

        public MockDataStore()
        {
            excercises = new List<Exercise>();

            var _exercises = new List<Exercise>
            {
                new Exercise {Id = Guid.NewGuid().ToString(), Name = "Pull up", NumOfReps = 10, Weight = 60},
                new Exercise {Id = Guid.NewGuid().ToString(), Name = "Push up", NumOfReps = 6, Weight = 13},
                new Exercise {Id = Guid.NewGuid().ToString(), Name = "Sit up", NumOfReps = 12, Weight = 20},
                new Exercise {Id = Guid.NewGuid().ToString(), Name = "Stand up", NumOfReps = 8, Weight = 60},
                new Exercise {Id = Guid.NewGuid().ToString(), Name = "Lay up", NumOfReps = 8, Weight = 14},
                new Exercise {Id = Guid.NewGuid().ToString(), Name = "Go up", NumOfReps = 7, Weight = 20}
            };

            foreach (Exercise exercise in _exercises)
            {
                excercises.Add(exercise);
            }

            items = new List<TrainingEntity>();
            var _items = new List<TrainingEntity>
            {
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "First Set", Description="This is a nice description", Exercises = excercises},
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "Second Set", Description="This is a nice description", Exercises = excercises},
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "Third Set", Description="This is a nice description", Exercises = excercises},
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "Fourth Set", Description="This is a nice description", Exercises = excercises},
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "Fifth Set", Description="This is a nice description", Exercises = excercises},
                new TrainingEntity { Id = Guid.NewGuid().ToString(), Text = "Sixth Set", Description="This is a nice description", Exercises = excercises},
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

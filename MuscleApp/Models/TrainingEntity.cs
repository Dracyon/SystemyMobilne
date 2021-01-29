using MuscleApp.Models;
using System;
using System.Collections.Generic;
namespace MuscleApp
{
    public class TrainingEntity
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public List<Exercise> Exercises { get; set; }
    }
}

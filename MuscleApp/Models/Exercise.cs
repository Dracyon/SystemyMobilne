using System;
using System.Collections.Generic;

namespace MuscleApp.Models
{
    public class Exercise
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public int NumOfReps { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MuscleApp.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Rep> Reps { get; set; }
    }
}

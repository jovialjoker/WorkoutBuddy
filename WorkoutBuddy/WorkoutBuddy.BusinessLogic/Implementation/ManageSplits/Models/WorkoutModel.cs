﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WorkoutBuddy.BusinessLogic.Implementation.ManageSplits.Models
{
    public class WorkoutModel
    {
        public Guid Id { get; set; }
        public string WorkoutName { get; set; }
        public List<Guid> Exercises { get; set; }
        public List<int> SelectedMuscleGroups { get; set; }
        public bool IsDeleted { get; set; }
    }
}

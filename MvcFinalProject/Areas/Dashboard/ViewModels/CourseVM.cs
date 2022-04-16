using MvcFinalProject.Models;
using System.Collections.Generic;

namespace MvcFinalProject.Areas.Dashboard.ViewModels
{
    public class CourseVM
    {
        public Course Course { get; set; }
        public List<Category> Categories { get; set; }
        public List<int> CategoryIds { get; set; }
        public Feature Feature { get; set; }
    }
}

using MvcFinalProject.Models;
using System.Collections.Generic;

namespace MvcFinalProject.ViewModels
{
    public class TeacherVM
    {
        public Teacher Teacher { get; set; }
        public List<Skill> Skils { get; set; }
        public Contact Contact { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcFinalProject.Models
{
    public class Skill
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public string Value { get; set; }
        
        public int Key { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}

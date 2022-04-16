using MvcFinalProject.Models;
using System.Collections.Generic;

namespace MvcFinalProject.ViewModels
{
    public class AboutVM
    {
        public Welcome Welcome { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Testimonial> Testimonials { get; set; }

    }
}

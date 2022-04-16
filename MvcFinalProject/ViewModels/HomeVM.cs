using MvcFinalProject.Models;
using System.Collections.Generic;

namespace MvcFinalProject.ViewModels
{
    public class HomeVM
    {
        public List<Blog> Blogs { get; set; }
        public List<Event> Events { get; set; }

        public List<Slider> Sliders { get; set; }
        public List<Information> Informations { get; set; }
        public List<NoticeBoard> Notices { get; set; }
        public WhyUs WhyUs { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Course> Courses { get; set; }
        public Layout Layout { get; set; }

    }
}

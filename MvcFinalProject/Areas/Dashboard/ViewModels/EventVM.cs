using Microsoft.AspNetCore.Http;
using MvcFinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcFinalProject.Areas.Dashboard.ViewModels
{
    public class EventVM
    {
        public Event Event { get; set; }
        public List<Speaker> Speakers { get; set; }
        public List<int> SpeakerIds { get; set; }
      
    }
}

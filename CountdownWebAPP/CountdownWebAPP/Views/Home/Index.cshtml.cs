using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CountdownWebAPP.Views
{
    public class IndexModel : PageModel
    {
        private int time;
        [BindProperty]
        public int RemainingTime { get; set; } 
        public void OnGet()
        {
            RemainingTime = 98;
        }
        public string EmailAddress { get; set; }
        public void OnPost()
        {
            var remainingTime = Request.Form["remainingTime"];
        }
    }
}

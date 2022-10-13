using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisasterAlert.Pages
{
    public class donateDisMoneyModel : PageModel
    {
        public bool hasData = false;
        public string fullName = "";
        public string fullAmount = "";
        public string disasterDetails = "";
        public string message = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
            fullName = Request.Form["fullname"];
            fullAmount = Request.Form["fullamount"];
            disasterDetails = Request.Form["disasterdetails"];
            message = Request.Form["message"];
        }
    }
}

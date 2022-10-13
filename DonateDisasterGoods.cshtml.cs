using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisasterAlert.Pages
{

    public class DonateDisasterGoodsModel : PageModel
    {
        public bool hasData = false;
        public string fullName = "";
        public string goodsdonated = "";
        public string disasterDetails = "";
        public string message = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
            fullName = Request.Form["fullname"];
            goodsdonated = Request.Form["goodsdonated"];
            disasterDetails = Request.Form["disasterdetails"];
            message = Request.Form["message"];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FE_Migration_Test_App.Pages
{
    public class logincallbackModel : PageModel
    {
        public int code;
        public void OnGet(int? code)
        {
            if (code.HasValue) code = code.Value;
        }
    }
}
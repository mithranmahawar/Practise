using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using MVCWebApplication1.Models;

namespace MVCWebApplication1.ViewModel
{
    public class KidsDanceActivity
    {
        public KidsDetail KidsDetail { get; set; }
        public List<DanceActivity> DanceActivities { get; set; }

    }
}
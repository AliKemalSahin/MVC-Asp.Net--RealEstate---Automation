using Emlakcilik.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emlakcilik.ViewModels
{
    public class IlanFormViewModel
    {
        public List<IlanTip> Tipler { get; set; }
        
        public List<Sehir> Sehirler { get; set; }

        public List<Gayrimenkul> Gayrimenkuller { get; set; }
        
        public List<Ilce> Ilceler { get; set;  }
        public Ilan ilan { get; set;  }
        
    }
}
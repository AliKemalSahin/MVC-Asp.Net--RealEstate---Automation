using Emlakcilik.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emlakcilik.ViewModels
{
    public class GayrimenkulFormViewModel
    {
        public IEnumerable<Gayrimenkul> Gayrimenkuller { get; set; }

        public Gayrimenkul gayrimenkul { get; set; }
    }
}
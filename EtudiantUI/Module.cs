using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_for_Teachers
{
    class Module
    {
        private String nom { get; set; }
        private Double volumehoraire { get; set; }
        public String regime { get; set; }
        public Double coefficient { get; set; }
        public String URL { get; set; }
        public String email { get; set; }
        public String niveau { get; set; }
        public String anneedetude { get; set; }
        List<Double> notes = new List<Double>();

    }
}

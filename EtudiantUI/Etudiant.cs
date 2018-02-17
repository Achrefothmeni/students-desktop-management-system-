using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtudiantUI
{
    class Etudiant
    {
        private int id { get; set; }
        private String nom { get; set; }
        private String prenom { get; set; }
        private String login { get; set; }
        private String motdepasse { get; set; }
        private String adressemail { get; set; }
        private Byte photo { get; set; }
        private Byte QRCODE  { get; set; }
        public String niveau { get; set; }
        public String anneedetude { get; set; }

    }
}

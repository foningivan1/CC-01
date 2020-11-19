using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Ecole
    {
        private string Etablissement;
        private string Site;
        private string Tel;

        public Ecole(string Etablissement, string Site, string Tel)
        {
            this.Etablissement = Etablissement;
            this.Site = Site;
            this.Tel = Tel;
        }

    }
}

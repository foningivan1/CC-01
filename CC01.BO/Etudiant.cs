using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Etudiant
    {
        private string Lastname;
        private string Firstname;
        private string BornOn;
        private string At;
        private string Identifiant;
        private int Contact;
        private string Email;

        public Etudiant(string Lastname, string Firstname, string BornOn, string At, string Identifiant, int Contact, string Email)
        {
            this.Lastname = Lastname;
            this.Firstname = Firstname;
            this.BornOn = BornOn;
            this.At = At;
            this.Identifiant = Identifiant;
            this.Contact = Contact;
            this.Email = Email;

        }

    }
}

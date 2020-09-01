using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercice
{
    class JuridicalCustomer : ICustomer
    {
        public string CompanyName { get; private set; }
        public IPerson LegalRepresentative { get; }

        public JuridicalCustomer(IPerson person, string companyName)
        {
            this.CompanyName = companyName;
            this.LegalRepresentative = person;

        }
    }
}
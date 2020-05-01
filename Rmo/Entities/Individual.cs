using System;
using System.Collections.Generic;
using System.Text;
using Rmo.Entities;

namespace Rmo.Entities
{
    
    class Individual : TaxPayer
    {
        public double HeathExpenditures { get; set; }

        public Individual()
        {
        }
        
        public Individual(string name, double anualIncome, double heathExpenditures) 
            : base(name, anualIncome)
        {
            HeathExpenditures = heathExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HeathExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HeathExpenditures * 0.5;
            }
        }
    }
}

using System;

namespace Opdracht5
{
    class Iban
    {
        public string IbanNumber { get; private set; }

        // remove spaces from IBAN
        public Iban(string IbanNumber) {
            this.IbanNumber = IbanNumber.Replace(" ", "");
        }
        
        // check Control Numbers
        public Boolean checkControlNumbers() {
            int controlNumber = Int32.Parse(this.IbanNumber.Substring(2, 2));
            return (this.IbanNumber.Substring(0, 2) == "BE" && controlNumber >= 2 && controlNumber <= 98);
        }

        // check if number of characters = 16
        public Boolean checkNumberOfCharcters() {
            return this.IbanNumber.Length == 16;
        }

        // switch controle numbers and replace them with hex numbers
        public void switchCharacters() {
            var controlNumbers = this.IbanNumber.Substring(0, 4);
            this.IbanNumber = (this.IbanNumber.Replace(controlNumbers, "") + controlNumbers).Replace("BE", "1114");
        }

        // check modulus 97 = 1
        public Boolean isIban() {
            var number = Int64.Parse(this.IbanNumber);
            return (number % 97 == 1);
        }

        public override string ToString() {
            return this.IbanNumber;
        }
        
    }
}
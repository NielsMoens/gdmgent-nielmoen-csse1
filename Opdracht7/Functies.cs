using System;

namespace Opdracht7
{
    class Calculator
    {
        
        public decimal Number1 { get; private set; }

        public decimal Number2 { get; private set; }

        //  assign numbers to Calculator
        public Calculator(decimal number1, decimal number2) {
            this.Number1 = number1;
            this.Number2 = number2;
        }
        
        //  som
        public decimal add() {
            return this.Number1 + this.Number2;
        }

        //  verschil
        public decimal subtract() {
            return this.Number1 - this.Number2;
        }
        
        //  quotiënt
        public decimal divide() {
            if (this.Number2 == 0) {
                throw new ArgumentException("Cannot divide by zero!!!");
            }
            return Math.Round(this.Number1 / this.Number2, 2);
        }

        //  product
        public decimal multiply() {
            return this.Number1 * this.Number2;
        }

        // modulus
        public decimal modulus(){
            return this.Number1 % this.Number2;
        }
        
        // faculteit
        public string faculteit(){
        long j;
            long facul=1;
            for(j=1;j<=this.Number1; j++)
            {
            facul= facul*j;
            }
            string magic = facul.ToString();            
            return magic;
        }

        // fibonacci
        public string fibonacci(){
            int i;
            decimal firstVal=0 , thrVal = 0; 
            decimal secVal = 1;
            decimal loop = this.Number1; 
            Console.WriteLine(firstVal.ToString());
            Console.WriteLine(secVal.ToString());
            for ( i = 2; i < loop; i++){
                thrVal = firstVal + secVal;
                firstVal = secVal;
                secVal = thrVal;
                Console.WriteLine(thrVal);
            }
            return null;
        }

        public override string ToString() {
            return "Add: " + this.add() + 
            "\nSubtract: " + this.subtract() + 
            "\nDivide: " + this.divide() + 
            "\nMultiply: " + this.multiply() + 
            "\nModulus: " + this.modulus() +
            "\nfaculteit: " + this.faculteit();
        } 
    }

        class Iban
    {
        
        public string IbanNumber { get; private  set; }

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
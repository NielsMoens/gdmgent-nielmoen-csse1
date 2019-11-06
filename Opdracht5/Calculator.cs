using System;

namespace Opdracht5
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
        public string fibonacci(){
            int i;
            decimal firstVal=0 , thrVal = 0; 
            decimal secVal = 1;
            // Console.WriteLine("=================================\n DE RIJ VAN FIBONACCI\n=================================");
            // Console.Write("Input the Row number: ");
            decimal loop = this.Number1; 
            Console.Write("\n");
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
            "\nfaculteit: " + this.faculteit() + 
            "\nfibonacci: " +this.fibonacci();
        } 
    }
}
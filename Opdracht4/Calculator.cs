using System;

namespace Opdracht4
{
    class Calculator
    {
        public decimal Number1 { get; private set; }

        public decimal Number2 { get; private set; }

        public Calculator(decimal number1, decimal number2) {
            this.Number1 = number1;
            this.Number2 = number2;
        }

        public decimal add() {
            return this.Number1 + this.Number2;
        }

        public decimal subtract() {
            return this.Number1 - this.Number2;
        }
        
        public decimal divide() {
            if (this.Number2 == 0) {
                throw new ArgumentException("Cannot divide by zero!!!");
            }
            return Math.Round(this.Number1 / this.Number2, 2);
        }
        public decimal multiply() {
            return this.Number1 * this.Number2;
        }
        public decimal modulo() {
            return this.Number1 % this.Number2;
        }



        
        public override string ToString() {
            return "Add: " + this.add() + "\nSubtract: " + this.subtract() + "\nDivide: " + this.divide() + "\nMultiply: " + this.multiply() + "\nModulo: "+this.modulo();
        } 
    }
}
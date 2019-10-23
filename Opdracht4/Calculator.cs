using System;

namespace Opdracht4
{
    class Calculator
    {
        public double Number1 { get; private set; }

        public double Number2 { get; private set; }

        public Calculator(double number1, double number2) {
            this.Number1 = number1;
            this.Number2 = number2;
        }

        public double add() {
            return this.Number1 + this.Number2;
        }

        public double subtract() {
            return this.Number1 - this.Number2;
        }
        
        public double divide() {
            if (this.Number2 == 0) {
                throw new ArgumentException("Cannot divide by zero!!!");
            }
            return this.Number1 / this.Number2;
        }
        public double multiply() {
            return this.Number1 * this.Number2;
        }

        public override string ToString() {
            return "Add: " + this.add() + "\nSubtract: " + this.subtract() + "\nDivide: " + this.divide() + "\nMultiply: " + this.multiply();
        } 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CPE200Lab1
{
    public class RPNCalculatorEngine :CalculatorEngine
    {        
        public string Process(string str)
        {
            Stack<string>  myStack = new Stack<string>();
            string first, second, sum;
            string[] parts = str.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            {
                if (isNumber(parts[i]))
                {
                    myStack.Push(parts[i]);
                }
                else if (isOperator(parts[i]) && myStack.Count >= 2)
                {
                    second = myStack.Pop();
                    first = myStack.Pop();
                    sum = calculate(parts[i], first, second);
                    myStack.Push(sum);
                }
                else return "E";
            }

            if (myStack.Count == 1)
            {
                return myStack.Pop();
            }
            else return "E";


            // your code here
            
        }     
    }
}

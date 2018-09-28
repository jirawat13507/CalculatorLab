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
                else if (parts[i] == "1/X" && myStack.Count == 1)
                {
                    first = myStack.Pop();                    
                    sum = unaryCalculate(parts[i],first);
                    myStack.Push(sum);
                }
                else if (parts[i] == "√" && myStack.Count == 1)
                {
                    first = myStack.Pop();
                    sum = unaryCalculate(parts[i], first);
                    myStack.Push(sum);
                }
                else if(parts[i] == "%" && myStack.Count == 1) 
                {
                    first = myStack.Pop();
                    sum = calculate(parts[i], first,second ="0");
                    myStack.Push(sum);
                }
                else if (isOperator(parts[i]) && myStack.Count >= 2)
                {
                    second = myStack.Pop();
                    first = myStack.Pop();
                    sum = calculate(parts[i], first, second);
                    myStack.Push(sum);
                }

                else if(isOperator(parts[i]) && myStack.Count < 2)
                    return "E";                                  
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

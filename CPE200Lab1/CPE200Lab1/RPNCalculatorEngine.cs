using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/// <summary>
/// Calaulated by RPN
/// </summary>
namespace CPE200Lab1
{
    public class RPNCalculatorEngine :CalculatorEngine
    {   
        /// <summary>
        /// Call function CalculatorEngine : caculated by function plus,minus,mutilty,divide,root,oneoverX,persent
        /// </summary>
        /// <param name="str"></param>
        /// <returns> string : Calculated value </returns>
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
                    // if input is number push stack
                }
                else if (parts[i] == "1/X" && myStack.Count == 1)
                {
                    first = myStack.Pop();                    
                    sum = unaryCalculate(parts[i],first);
                    myStack.Push(sum);
                    // value are calculated by oneoverX push stack
                }
                else if (parts[i] == "√" && myStack.Count == 1)
                {
                    first = myStack.Pop();
                    sum = unaryCalculate(parts[i], first);
                    myStack.Push(sum);
                    //value are calculated by root push stack
                }
                else if(parts[i] == "%" && myStack.Count == 1) 
                {
                    first = myStack.Pop();
                    sum = calculate(parts[i], first,second ="0");
                    myStack.Push(sum);
                    //value are calculated by persent push stack
                }
                else if (isOperator(parts[i]) && myStack.Count >= 2)
                {
                    second = myStack.Pop();
                    first = myStack.Pop();
                    sum = calculate(parts[i], first, second);
                    myStack.Push(sum);
                    //value are caculated by function CalculateEngine 
                }
                else if(isOperator(parts[i]) && myStack.Count < 2)
                    return "E";   
                    //error if stack.count not equal to 1 and will return value 
            }       
            if (myStack.Count == 1)
            {             
                return myStack.Pop();
                //return value in stack by stack.count = 1
            }
            else return "E";
            // your code here            
        }     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures.Stack
{
    public class PostfixCalculator
    {
        private int isNumber;
        private int item2;
        private int item1;

        public int CalculatePostfix(string expr)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var item in expr.ToCharArray())
            { 
                int value = 0;
                bool isNumber = int.TryParse(item.ToString(), out value);
                if (isNumber)
                {
                    stack.Push(value);
                }
                else
                {
                    item1 = Convert.ToInt32(stack.Pop());
                    item2 = Convert.ToInt32(stack.Pop());
                    switch (item.ToString())
                    {
                        case "*":                        
                            stack.Push(item1 * item2);
                            break;

                        case "+":
                            stack.Push(item1 + item2);
                            break;

                        case "-":
                            stack.Push(item1 - item2);
                            break;

                        case "/":
                            stack.Push(item1 / item2);
                            break;

                        case "%":
                            stack.Push(item1 % item2);
                            break;

                       
                    }
                }



            }

            if (stack.Count > 1)
            {
                throw new InvalidOperationException("String is wrong");
            }

            return stack.Pop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class MathOperation1
    {
        //Create a method that takes two integers as parameters
        //Make one parameter oprional by providing a default value
        public int MathOperation(int i, int j = 1) 
        {
            //Perform multiplicationon integers and return the result
            int result = i * j;
            return result;
        }
    }
}

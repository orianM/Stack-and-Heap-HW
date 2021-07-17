using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_heap_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*a.The stack is an array of memory that is in a LIFO structure,
                meaning - data can only be deleted or added from the top of it.
            
              b.The heap is an area of memory that stores certain data of objects, unlike the stack - data can be removed or stored
                in any order.
            
              c.Value types are data types that hold their data in their own memory allocation, 
                value types are stored in the stack.
            
              d.Reference types are types that store a reference to their data, 
                reference types get addresses which are stored in the heap.*/

            #endregion

            #region question 2

            /*examples of value types that get stored in the stack: 1.Int
                                                                    2.Char
                                                                    3.Boolean
                                                                    4.Double*/

            #endregion

            #region question 3

            /*If you're using something that isn't a value type, i.e., reference types.
              Then the address of said reference type is stored in the stack.*/

            #endregion

            #region question 4

            /*Arrays are also reference types, 
              since you have to first allocate an amount of space in the memory 
              (e.g. int[] arr = new arr[5] - would allocated 5 spaces in the memory).
            
              Since arrays are reference types it doesn't matter whether it's an array of ref type(e.g string)/value type(e.g int), 
              it's data will be stored in the heap.
            
              In other words the stack will only store the address of the array.*/

            #endregion

            #region question 5

            char[] myCharArr = { 'A', 'B', 'C' };
            char[] myCharArr2 = myCharArr;

            char[] myCharArr3 = new char[myCharArr.Length];
            for (int i = 0; i < myCharArr3.Length; i++)
            {
                myCharArr3[i] = myCharArr[i];
            }

            myCharArr2[0] = 'D';

            myCharArr3[0] = 'L';

            /*myCharArr3 does point to the same address in the heap therefore it doesn't affect any other array,
              nor does it get affected by other arrays, it remains neutral.*/

            #endregion
        }
    }
}

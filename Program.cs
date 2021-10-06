using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region uc1
            //int output = uc1_Max_int.MaximumIntegerNumber(25,21,64);
            //Console.WriteLine("Maximum value is :" +output);
            //#endregion uc1 


            //#region uc2
            //double doubleoutput = uc2_Max_Float.MaximumFloatNumber(12.54 , 0.25 , 8.24);
            //Console.WriteLine("Maximum value is :" + doubleoutput);
            //#endregion uc2


            //#region uc3

            //string strigoutput = uc3_Max_String.MaximumStringNumber("38", "67", "99");
            //Console.WriteLine("Maximum valuew is :" +strigoutput);
            //#endregion uc3


            //#region uc4_MoreThenThreeParameter
            //int[] intArray1 = { 977, 86, 500, 555, 236 };
            //uc4_MoreThenThreeParameter<int> checkInt1 = new uc4_MoreThenThreeParameter<int>(intArray1);
            //int i = checkInt1.MaxValue(intArray1);
            //Console.WriteLine(i);

            //float[] floatArray1 = { 3.6f, 7.5f, 54.2f, 85.89f, 56.2f };
            //uc4_MoreThenThreeParameter<float> checkFloat1 = new uc4_MoreThenThreeParameter<float>(floatArray1);
            //float f = checkFloat1.MaxValue(floatArray1);
            //Console.WriteLine(f);

            //string[] stringArray1 = { "951", "789", "635", "600", "350" };
            //uc4_MoreThenThreeParameter<string> checkString1 = new uc4_MoreThenThreeParameter<string>(stringArray1);
            //string s = checkString1.MaxValue(stringArray1);
            //Console.WriteLine(s);
            //#endregion uc4_MoreThenThreeParameters

            //#region UC5
            //int[] intArray = { 577, 668, 555, 29, 926 };
            //UC5<int> checkInt2 = new UC5<int>(intArray);
            //checkInt2.PrintMaxValue();

            //float[] floatArray = { 6.6f, 66.66f, 54.1f, 25.89f, 22.2f };
            //UC5<float> checkFloat2 = new UC5<float>(floatArray);
            //checkFloat2.PrintMaxValue();

            //string[] stringArray = { "65", "269", "257", "22", "559" };
            //UC5<string> checkString2 = new UC5<string>(stringArray);
            //checkString2.PrintMaxValue();
            //#endregion UC5

            //#region Refactor1
            //int checkInt3 = Refactor1<int>.MaximumIntNumber(97, 568, 200);
            //Console.WriteLine("Maximum Number:" + checkInt3);
            //float checkFloat3 = Refactor1<float>.MaxFloatNumber(55.5f, 75.47f, 98.65f);
            //Console.WriteLine("Maximum Number:" + checkFloat3);
            //string checkString3 = Refactor1<string>.MaximumStringNumber("35", "63", "72");
            //Console.WriteLine("Maximum Number:" + checkString3);
            //#endregion Refactor1

            #region Refactor2
            int checkInt = Refactor2<int>.MaximumIntegerNumber(6, 10, 500);
            Console.WriteLine("Maximum int  Number:" + checkInt);
            float checkFloat = Refactor2<float>.MaxFloatNumber(32.7f, 175.55f, 30.55f);
            Console.WriteLine("Maximum float Number:" + checkFloat);
            string checkString = Refactor2<string>.MaximumStringNumber("34", "66", "100");
            Console.WriteLine("Maximum string Number:" + checkString);
            #endregion Refactor2


            Console.ReadLine();
              
        }
    }
}

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ///*By Ref*/
            //string Name1 = "Mohamed";
            //EditStringref(ref Name1);
            //Console.WriteLine(Name1);

            ///*By Value*/
            //string Name2 = "Mohamed";
            //EditStringvalue(Name2);
            //Console.WriteLine(Name2);

            /**Answer of Question
            * by Ref:
            * you don't create new reference u use the original reference so if u make a new object
            * and refers to it the original object changes
            * 
            * by Value 
            * u copy the address in the original reference and create a new one so if u make a new object
            * and refers to it in the function the original object doesn't change
            */
            #endregion

            #region Q2
            //int Sum, Sub;
            //AddandSub(3, 4, out Sum, out Sub);
            //Console.WriteLine($"Sum = {Sum} and Sub = {Sub}");
            #endregion

            #region Q3
            //int Max = 0, Min = 0;
            //int[] Arr = { 1, 2, 3, 4, 5, 41 };
            //MinandMax(ref Arr, ref Max, ref Min);
            //Console.WriteLine($"Max = {Max} and Min = {Min}");
            #endregion

        }

        /*Functions*/

        #region Q1 Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        static void EditStringref(ref string text)
        {
            text = new string("ahmed");
        }
        static void EditStringvalue(string text)
        {
            text = new string("ahmed");
        }
        #endregion

        #region Q2 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        static void AddandSub(int Num1, int Num2, out int Sum, out int Sub)
        {
            Sum = Num1 + Num2;
            Sub = Num2 - Num1;
        }
        #endregion

        #region Q3 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        static void MinandMax(ref int[] Nums1, ref int Max, ref int Min)
        {
            if (Nums1 != null)
            {
                Max = Nums1[0];
                Min = Nums1[0];
                for (int i = 0; i < Nums1.Length; i++)
                {
                    if (Nums1[i] > Max)
                        Max = Nums1[i];
                    if (Nums1[i] < Min)
                        Min = Nums1[i];
                }
            }
        }
        #endregion
    }
}

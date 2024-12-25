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

    }
}

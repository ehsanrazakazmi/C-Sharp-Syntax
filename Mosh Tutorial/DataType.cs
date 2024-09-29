namespace MyApp
{
    class DataType
    {
        static void Main(string[] args)     // this method does not return any value
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;

            //Pi = 1;         // now I cannot change this value because I have declared Pi as a constant

            Console.WriteLine(Pi);

            /*checked
            {
                byte number = 255;
                number += 1;        // this is called overflowing
                Console.WriteLine(number);          // byte can store max of 255
            }*/

            int i = 1000;
            byte bt = (byte)i;

            Console.WriteLine(bt);

            try
            {
                /*
                var niya = "123";
                //int conv = Convert.ToInt32(niya);
                byte conv = Convert.ToByte(niya);

                Console.WriteLine(conv);

                string str = "true";
                bool bl = Convert.ToBoolean(str);
                Console.WriteLine(bl);
            */
            }
            catch (Exception)
            {
                Console.WriteLine("This number could not be converted to byte");

            }

            int a = 1;
            int b = ++a;
            Console.WriteLine(++b);
        }
    }
}
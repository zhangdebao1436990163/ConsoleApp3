namespace calculator
{
   public  class Calcultator
    {
        public static int Sum(int a, int b)
        {

            return a + b;
        }
        public static int Sum(string strA, string strB)
        {
            int a, b;
            int.TryParse(strA, out a);
            int.TryParse(strB, out b);
            return Sum(a, b);
        }
    }
}

namespace reverser3000
{
    static class Program
    {           
        static void Main()
        {
            string stringToReverse = " Alan come  tomyfriend ";
            
            Reverser r = new Reverser();
            
            Console.WriteLine(r.Reverse(stringToReverse));
            // test 2
            
        }
    }
}
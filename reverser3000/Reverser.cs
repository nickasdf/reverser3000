namespace reverser3000
{
    internal class Reverser
    {
        public  string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

            if (true)
            {

            }
        }

    }
}

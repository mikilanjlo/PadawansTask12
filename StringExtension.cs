using System;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source == "")
                throw new ArgumentException();
            char symbol;
            bool result = true;
            for (int i = 0; i < 256; i++)
            {
                symbol = (char)i;
                int count = 0;
                for(int j = 0; j < source.Length; j++)
                    if(symbol == source[j])
                    {
                        count++;
                        if(count > 1)
                        {
                            result = false;
                            break;
                        }
                    }
                if (!result)
                    break;
            }
            return result;
        }
    }
}
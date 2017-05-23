namespace Algorithms.ArraysAndStrings
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Find if string has unique characters.
    /// </summary>
    public class StringHasUniqueCharacters
    {
        public bool IsUniqueChars(string str)
        {
            if (str.Length > 128)
            {
                return false;
            }

            bool[] charSet = new bool[128];
            for (int i = 0; i < str.Length; i++)
            {
                var val = str[i];
                if (charSet[val])
                {
                    return false;
                }

                charSet[val] = true;
            }

            return true;

        }
    }
}

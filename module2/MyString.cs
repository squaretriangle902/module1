using System.Drawing;
using System.Runtime.CompilerServices;

namespace module2
{
    internal class MyString
    {
        private char[] myString;

        internal MyString(int size)
        {
            myString = new char[size];
        }

        internal MyString(string str)
        {
            myString = new char[str.Length];
            CopyString(str);
        }

        private void CopyString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                myString[i] = str[i];
            }
        }

        internal int Size { get { return myString.Length; } }   

        public char this[int index]
        { get { return myString[index]; } set { myString[index] = value; } }

        public static MyString operator +(MyString firstMyString, MyString secondMyString)
        {
            MyString result = new MyString(firstMyString.Size + secondMyString.Size);
            CopyMyString(result, firstMyString, startIndex: 0);
            CopyMyString(result, secondMyString, startIndex: firstMyString.Size);
            return result;
        }

        public static bool operator ==(MyString firstMyString, MyString secondMyString)
        {
            if (firstMyString.Size != secondMyString.Size)
            {
                return false;
            }
            for (int i = 0; i < firstMyString.Size; i++)
            {
                if (firstMyString[i] != secondMyString[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(MyString firstMyString, MyString secondMyString)
        {
            return !(firstMyString == secondMyString);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != typeof(MyString))
            {
                return false;
            }
            return this == (MyString)obj;
        }

        public override int GetHashCode()
        {
            int firstPrime = 17;
            int secondPrime = 23;
            unchecked
            {
                int hash = firstPrime;
                hash = hash * secondPrime + myString.GetHashCode();
                return hash;
            }
        }

        internal static MyString Concat(MyString[] myStrings)
        {
            MyString result = new MyString(ArrayConcatSize(myStrings));
            int startIndex = 0;
            foreach (MyString myString in myStrings)
            {
                CopyMyString(result, myString, startIndex);
                startIndex += myString.Size;
            }
            return result;
        }

        private static int ArrayConcatSize(MyString[] myStrings)
        {
            int resultSize = 0;
            foreach (MyString myString in myStrings)
            {
                resultSize += myString.Size;
            }
            return resultSize;
        }

        private static void CopyMyString(MyString result, MyString firstMyString, int startIndex)
        {
            for (int i = 0; i < firstMyString.Size; i++)
            {
                result[startIndex + i] = firstMyString[i];
            }
        }
    }
}

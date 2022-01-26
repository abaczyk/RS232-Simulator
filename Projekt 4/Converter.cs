using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_4
{
    internal class Converter
    {
        public string ASCIIToBinary(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in str)
            {
                stringBuilder.Append(0); //bit startu
                stringBuilder.Append(reverse(Convert.ToString(c, 2)));
                stringBuilder.Append(11); //bity stopu
                stringBuilder.Append("  ");
            }
            return stringBuilder.ToString();
        }

        public string binaryToASCII(string str)
        {
            string binary = deleteStartAndStopBits(getWordTable(str));
            List<Byte> bytesList = new List<Byte>();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < binary.Length; i += 8)
            {
                bytesList.Add(Convert.ToByte(reverse(binary.Substring(i, 8)), 2));
            }
            byte[] bytesTable = bytesList.ToArray();
            return UTF8Encoding.UTF8.GetString(bytesTable);
        }

        public string reverse(string str)
        {
            char[] chars = str.ToCharArray();
            char[] newChars = new char[8];

            int diff = newChars.Length - chars.Length;
            if (diff > 0)
            {
                for (int i = 0; i < diff; i++)
                {
                    newChars[i] = '0';
                }
            }

            for (int i = diff; i < newChars.Length; i++)
            {
                newChars[i] = chars[i - diff];
            }

            Array.Reverse(newChars);
            return new string(newChars);
        }

        public string deleteStartAndStopBits(string[] wordTable)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < wordTable.Length; i++)
            {
                for (int i1 = 1; i1 < wordTable[i].Length - 2; i1++)
                {
                    char c = wordTable[i][i1];
                    stringBuilder.Append(wordTable[i][i1]);
                }
            }
            return stringBuilder.ToString();
        }

        public string[] getWordTable(string str)
        {
            string[] wordTable = str.Split(' ');
            return wordTable;
        }
    }
}

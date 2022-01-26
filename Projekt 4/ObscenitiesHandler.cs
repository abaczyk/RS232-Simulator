using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_4
{
    internal class ObscenitiesHandler
    {
        public string changeStringToAsterisks(String str)
        {
            string censure = null;
            string newString = str;
            string[] obscenities = Resource.Obscenities.Split(Environment.NewLine);

            for (int i = 0; i < obscenities.Length; i++)

                if (str.ToLower().Equals(obscenities[i]))
                {
                    foreach (char c in str)
                    {
                        if (Char.IsWhiteSpace(c))
                        {
                            censure += " ";
                        }
                        else
                        {
                            censure += "*";
                        }
                    }
                    newString = str.Replace(str, censure);
                }
            return newString;
        }
    }
}


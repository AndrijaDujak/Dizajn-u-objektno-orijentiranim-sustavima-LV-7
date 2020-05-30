using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    public class PalindromChecker
    {
        public bool check(string sentence)
        {
            sentence=sentence.ToLower();
            sentence=sentence.Replace(" ", "");
            char[] sentencearray = sentence.Where(letter => (char.IsLetterOrDigit(letter))).ToArray();
            sentence = new string(sentencearray);
            Array.Reverse(sentencearray);
            string reversentence= new string(sentencearray);

            return sentence.Equals(reversentence);
        }

    }
}

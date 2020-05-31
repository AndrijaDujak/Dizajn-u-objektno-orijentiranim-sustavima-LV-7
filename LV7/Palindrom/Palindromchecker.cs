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
            sentence = makereadyforcheck(sentence);
            return sentence.SequenceEqual(sentence.Reverse());
        }
        public string makereadyforcheck(string sentence)
        {
            sentence = sentence.ToLower();
            sentence = sentence.Replace(" ", "");
            char[] sentencearray = sentence.Where(letter => (char.IsLetter(letter))).ToArray();
            sentence = new string(sentencearray);
            return sentence;
        }
    }
}

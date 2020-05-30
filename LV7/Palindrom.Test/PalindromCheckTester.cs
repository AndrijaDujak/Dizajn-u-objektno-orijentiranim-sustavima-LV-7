using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom.Test
{ 
    [TestFixture]
    public class PalindromCheckTester
    {
        PalindromChecker palindromchecker = new PalindromChecker();
        [TestCase ("kisik")]
        [TestCase("kuk")]
        [TestCase("rotor")]
        public void Check_ForPalindrom_ReturnsTrue(string sentence)
        {
            bool excpected = true;

            bool actual = palindromchecker.check(sentence);

            Assert.AreEqual(excpected, actual);
        }
        [TestCase("Ana")]
        [TestCase("Neven")]
        [TestCase("Potop")]
        public void Check_ForPalindromWithUppercase_ReturnsTrue(string sentence)
        {
            bool excpected = true;

            bool actual = palindromchecker.check(sentence);

            Assert.AreEqual(excpected, actual);
        }

        [TestCase("A?n!a")]
        [TestCase("Ne:v*en")]
        [TestCase("Po-t+op")]
        public void Check_ForPalindromWithSymbols_ReturnsTrue(string sentence)
        {
            bool excpected = true;

            bool actual = palindromchecker.check(sentence);

            Assert.AreEqual(excpected, actual);
        }

        [TestCase("a mene tu ni minute nema")]
        [TestCase("ana nabra par banana")]
        [TestCase("ana voli milovana")]
        public void Check_ForPalindromWithWhitespace_ReturnsTrue(string sentence)
        {
            bool excpected = true;

            bool actual = palindromchecker.check(sentence);

            Assert.AreEqual(excpected, actual);
        }

        [TestCase("tamo")]
        [TestCase("gdje")]
        [TestCase("treba")]
        public void Check_ForNotPalindromWithWhitespace_ReturnsTrue(string sentence)
        {
            bool excpected = false;

            bool actual = palindromchecker.check(sentence);

            Assert.AreEqual(excpected, actual);
        }
    }
}

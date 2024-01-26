using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestFrameworkTask.Test
{
    [TestFixture]
    public class StringUtilTests
    {
        [Test]
        public void MaxUnequalConsecutiveChars_WhenEmptyString_ReturnZero()
        {
            int result = StringUtil.MaxConsecutiveChars("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MaxUnequalConsecutiveChars_WhenConsecutiveCharsExist_ReturnMaxCount()
        {
            int result = StringUtil.MaxConsecutiveChars("abcd1234ab");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MaxConsecuntiveLatinLetters_WhenEmptyString_ReturnZero()
        {
            int result = StringUtil.MaxConsecuntiveLatinLetters("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MaxConsecutiveChars_WhenConsecutiveCharsExist_ReturnMaxCount()
        {
            int result = StringUtil.MaxConsecutiveChars("aaabbbbccc");
            Assert.AreEqual(4, result);
        }

        [Test]
        public void MaxConsecuntiveChars_WhenConsecutiveCharsExist_ReturnMaxCount()
        {
            int result = StringUtil.MaxConsecuntiveLatinLetters("abcd1234ab");
            Assert.AreEqual(4, result);
        }

        [Test]
        public void MaxConsecuntiveDigits_WhenEmpty_ReturnZero()
        {
            int result = StringUtil.MaxConsecuntiveDigits("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MaxConsecuntiveDigits_WhenConsecutiveDigitsExist_ReturnMaxCount()
        {
            int result = StringUtil.MaxConsecuntiveDigits("123aa456");
            Assert.AreEqual(3, result);
        }
    }
}
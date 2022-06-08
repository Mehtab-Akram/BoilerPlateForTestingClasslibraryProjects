using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Tests
{
    public class Tests
    {

        [Test]
        public void ToAcronym_TestIfToAcronymMethodIsWorkingCorrectlyInStringUtils()
        {
            List<string> lst = new List<string>()
           {
               "a b c",
               "Mobile network operator",
               "Example 1",
               "Mehtab AKram Kashmiri",

           };

            Assert.AreEqual(lst[0].ToAcronym(), "ABC");
            Assert.AreEqual(lst[1].ToAcronym(), "MNO");
            Assert.AreEqual(lst[2].ToAcronym(), "E1");
            Assert.AreEqual(lst[3].ToAcronym(), "MAK");


        }
        [Test]
        public void getStats_TestIfgetStatsMethodIsWorkingCorrectly_Analysis()
        {
            List<decimal> lstDecimals = new List<decimal>()
           {
               5,
               10,
               15,
               20,
               25,

           };

            Findings findings = Analysis.getStats(lstDecimals);
            Assert.AreEqual(findings.min, 5);
            Assert.AreEqual(findings.max, 25);
            Assert.AreEqual(findings.average, 15);


            lstDecimals = new List<decimal>()
           {
               5
           };

             findings = Analysis.getStats(lstDecimals);
            Assert.AreEqual(findings.min, 5);
            Assert.AreEqual(findings.max, 5);
            Assert.AreEqual(findings.average, 5);


            lstDecimals = new List<decimal>(){};

            findings = Analysis.getStats(lstDecimals);
            Assert.AreEqual(findings.min, 0);
            Assert.AreEqual(findings.max, 0);
            Assert.AreEqual(findings.average, 0);


        }

        [Test]
        public void Diff_TestIfDiffMethodIsWorkingCorrectly_ListUtils()
        {
            ArrayList lst1 = new ArrayList() { "a", "b", "c", "d", "a" };
            ArrayList lst2 = new ArrayList() { "b" };
            List<object> lstoutput = lst1.ToArray().ToList();
            var expectedList = new List<object> { 1, 3 };
            Assert.AreEqual(lstoutput.All(item => expectedList.Contains(item)), expectedList.All(item => lstoutput.Contains(item)));

            lst1 = new ArrayList() { 1, 2, 3 };
            lst2 = new ArrayList() { 2 };
            expectedList = new List<object> { 1, 3 };
            lstoutput = listUtils.Diff(lst1, lst2);
            Assert.AreEqual(lstoutput.All(item => expectedList.Contains(item)), expectedList.All(item => lstoutput.Contains(item)));

        }
    }
}
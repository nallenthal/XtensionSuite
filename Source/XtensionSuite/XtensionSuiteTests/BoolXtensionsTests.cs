// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Nallenthal.Common.XtensionSuite.BDDExtensions.BoolBDDXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.NumericBDDXtensions;
using Nallenthal.Common.XtensionSuite.BoolXtensions;

namespace Nallenthal.Common.XtensionSuiteTests
{
    [TestFixture]
    public class BoolXtensionsTests
    {
        [Test]
        public void Test_Methods_for_Bool()
        {
            var boolVar = true;
            boolVar.IsTrue().ShouldBeTrue();
            boolVar.IsFalse().ShouldBeFalse();
            boolVar.IsNotTrue().ShouldBeFalse();
            boolVar.IsNotFalse().ShouldBeTrue();
            boolVar = boolVar.Toggle();
            boolVar.ShouldBeFalse();

            boolVar.IsFalse().ShouldBeTrue();
            boolVar.IsTrue().ShouldBeFalse();
            boolVar.IsNotTrue().ShouldBeTrue();
            boolVar.IsNotFalse().ShouldBeFalse();

            boolVar = true;
            boolVar.ToInt().ShouldBeEqualTo(1);

            boolVar = false;
            boolVar.ToInt().ShouldBeEqualTo(0);

            boolVar = true;
            boolVar.ToLowerString().ShouldBeEqualTo("true");

            boolVar = false;
            boolVar.ToLowerString().ShouldBeEqualTo("false");

            boolVar = true;
            boolVar.ToYesNo().ShouldBeEqualTo("Yes");

            boolVar = false;
            boolVar.ToYesNo().ShouldBeEqualTo("No");

            boolVar = true;
            boolVar.ToString("true string", "false string").ShouldBeEqualTo("true string");

            boolVar = false;
            boolVar.ToString("true string", "false string").ShouldBeEqualTo("false string");

            var trueList = new List<int> { 1 };
            var falseList = new List<int> { 0 };

            boolVar = true;
            var resultList = boolVar.ToType<List<int>>(trueList, falseList);

            resultList.Count.ShouldBeEqualTo(1);
            resultList[0].ShouldBeEqualTo(1);

            boolVar = false;

            resultList = boolVar.ToType(trueList, falseList);

            resultList.Count.ShouldBeEqualTo(1);
            resultList[0].ShouldBeEqualTo(0);
        }
    }
}
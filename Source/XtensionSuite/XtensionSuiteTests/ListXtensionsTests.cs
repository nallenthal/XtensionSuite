// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;
using NUnit.Framework;
using Nallenthal.Common.XtensionSuite.ListXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.BoolBDDXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.NumericBDDXtensions;
using System.Collections.Generic;

namespace Nallenthal.Common.XtensionSuiteTests
{
    /// <summary>
    /// Test methods for ListXtenstions.
    /// </summary>
    [TestFixture]
    public class ListXtensionsTests
    {
        [Test]
        public void AddRangeTests()
        {
            var list1 = new List<int> {1,2,3};
            var list2 = new List<int> {4,5,6};
            var resultList = new List<int>();
            
            resultList.AddRange(list1,list2);
            
            resultList.Count.ShouldBeEqualTo(6);
            resultList[0].ShouldBeEqualTo(1);
            resultList[5].ShouldBeEqualTo(6);
        }
    }
}

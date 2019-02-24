// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;
using Nallenthal.Common.XtensionSuite.GenericXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.BoolBDDXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.NumericBDDXtensions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Nallenthal.Common.XtensionSuiteTests
{
    /// <summary>
    /// Unit tests for GenericXtension methods.
    /// </summary>
    [TestFixture]
    public class GenericXtensionsTests
    {
        [Test]
        public void IsInAndIsNotInTests()
        {
            1.IsIn(1,2,3).ShouldBeTrue();
            "Nallenthal".IsNotIn("nallenthal","NALLENTHAL","nALLENTHAL").ShouldBeTrue();
            
            4.IsIn(1,2,3).ShouldBeFalse();
            "Nallenthal".IsNotIn("Nallenthal","NALLENTHAL").ShouldBeFalse();
        }
        
        [Test]
        public void AsListTests()
        {
            int i = 10;
            List<int> list = i.AsList();
            
            list.Count.ShouldBeEqualTo(1);
            list[0].ShouldBeEqualTo(10);
        }
    }
}

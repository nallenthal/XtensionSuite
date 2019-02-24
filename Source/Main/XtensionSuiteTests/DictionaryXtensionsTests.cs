// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using Nallenthal.Common.XtensionSuite.DictionaryXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.BoolBDDXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.NumericBDDXtensions;

namespace Nallenthal.Common.XtensionSuiteTests
{
    /// <summary>
    /// Unit tests for Dictionary Extension methods.
    /// </summary>
    [TestFixture]
    public class DictonaryXtensionsTests
    {
        [Test]
        public void AddIfNotExistsTests()
        {
            var dict = new Dictionary<int, string>();
            dict.AddIfNotExists(1, "test").ShouldBeTrue();
            dict.AddIfNotExists(1, "test").ShouldBeFalse();
            dict.AddIfNotExists(2, "another test").ShouldBeTrue();
        }
        
        [Test]
        public void AddOrReplaceTests()
        {
            var dict = new Dictionary<int, string>();
            dict.AddOrReplace(1, "test");
            dict.AddOrReplace(1, "test2");
            dict.Count.ShouldBeEqualTo(1);
            dict.Keys.First().ShouldBeEqualTo(1);
            dict.Values.First().ShouldBeEqualTo("test2");
        }
        
        [Test]
        public void AddRangeTests()
        {
            var kvpList = new List<KeyValuePair<int, string>>();
            var dict = new Dictionary<int, string>();
            dict.Add(1, "test");
            kvpList.Add(new KeyValuePair<int, string>(2, "test2"));
            dict.AddRange(kvpList);
            
            dict.Count.ShouldBeEqualTo(2);
            dict.Keys.Last().ShouldBeEqualTo(2);
            dict.Values.Last().ShouldBeEqualTo("test2");
        }
    }
}

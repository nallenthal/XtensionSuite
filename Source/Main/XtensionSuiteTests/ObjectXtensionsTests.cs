// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;
using NUnit.Framework;
using Nallenthal.Common.XtensionSuite.BDDExtensions.BoolBDDXtensions;
using Nallenthal.Common.XtensionSuite.ObjectXtensions;

namespace Nallenthal.Common.XtensionSuiteTests
{
    /// <summary>
    /// Tests for ObjectXtensions methods
    /// </summary>
    [TestFixture]
    public class ObjectXtensionsTests
    {
        [Test]
        public void ObjectXtensionTestMethods()
        {
            "Nallenthal".IsA<string>().ShouldBeTrue();
            1.IsA<string>().ShouldBeFalse();
            
            "Nallenthal".IsNotA<System.Text.StringBuilder>().ShouldBeTrue();
            
            var obj = new InterfaceInstance();
            obj.As<IInterface>().IsNull().ShouldBeFalse();
            
            "Nallenthal".As<IInterface>().IsNotNull().ShouldBeFalse();
            
            obj.HasValue().ShouldBeTrue();
            
            InterfaceInstance obj1 = null;
            
            obj1.HasValue().ShouldBeFalse();
        }
        
        private interface IInterface
        {
            int fun();
        }
        
        private class InterfaceInstance : IInterface
        {
            public int fun()
            {
                return 0;
            }
        }
    }
}

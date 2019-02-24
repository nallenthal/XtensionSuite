// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Nallenthal.Common.XtensionSuite.BDDExtensions.BoolBDDXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.StringBDDXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.NumericBDDXtensions;
using Nallenthal.Common.XtensionSuite.StringXtensions;

namespace Nallenthal.Common.XtensionSuiteTests
{
    [TestFixture]
    public class StringXtensionsTests
    {
        [Test]
        public void Test_methods_for_string()
        {
            "Nallenthal".InvertCase().ShouldBeEqualTo("nALLENTHAL");
            
            "   ".IsNullOrEmptyAfterTrimmed().ShouldBeTrue();
            
            " Nallenthal ".IsNullOrEmptyAfterTrimmed().ShouldBeFalse();
            
            var charList = "Nallenthal".ToCharList();
            
            charList.Count.ShouldBeEqualTo(10);
            
            "Nallenthal".SubstringFromXToY(6,10).ShouldBeEqualTo("thal");
            
            "minimum".RemoveChar('m').ShouldBeEqualTo("iniu");
            
            "This is the text".GetWords().ShouldBeEqualTo(4);
            
            ("now".Reverse()).ShouldBeEqualTo("won");
            
            
            "1221".IsPalindrome().ShouldBeTrue();
            
            "123".IsPalindrome().ShouldBeFalse();
            
            "1221".IsNotPalindrome().ShouldBeFalse();
            
            "123".IsNotPalindrome().ShouldBeTrue();
            
            "info@nallenthal.in".IsAValidEmail().ShouldBeTrue();
            
            "invalid email".IsAValidEmail().ShouldBeFalse();
            
            "127.127.127.1".IsAValidIPAddress().ShouldBeTrue();
            
            "1231231".IsAValidIPAddress().ShouldBeFalse();
            
            "Nallenthal".AppendSep("#").ShouldBeEqualTo("Nallenthal#");
            
            "Nallenthal".AppendComma().ShouldBeEqualTo("Nallenthal,");
            
            "Nallenthal".AppendHyphen().ShouldBeEqualTo("Nallenthal-");
            
            "Nallenthal".AppendSpace().ShouldBeEqualTo("Nallenthal ");
            
            "Nallenthal".AppendSep('.').ShouldBeEqualTo("Nallenthal.");
            
            "Nallenthal".AppendWithSep("in",".").ShouldBeEqualTo("Nallenthal.in");
            
            "Nallenthal".AppendWithComma("in").ShouldBeEqualTo("Nallenthal,in");
            
            "Nallenthal".AppendWithHyphen("in").ShouldBeEqualTo("Nallenthal-in");
            
            "Nallenthal".AppendWithSpace("in").ShouldBeEqualTo("Nallenthal in");
            
            "Nallenthal".AppendWithSep("in",'.').ShouldBeEqualTo("Nallenthal.in");
            
        }
    }
}

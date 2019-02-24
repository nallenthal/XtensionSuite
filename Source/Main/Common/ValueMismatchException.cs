// Author  : Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in

using System;
using System.Collections.Generic;

namespace Nallenthal.Common
{
     /// <summary>
     /// A generic custom exception class that is used to indicate the consumer that the expected value is not matching with the actual value.
     /// Will be useful in writing unit tests and validations
     /// </summary>
     public class ValueMismatchException<T>:Exception
     {
          private T _expected;
          private T _actual;
          
          /// <summary>
          /// Parameterized constructor for the class. Instantiates the members
          /// </summary>
          /// <param name="expected">The ideal value</param>
          /// <param name="actual">The actual value</param>
          public ValueMismatchException(T expected, T actual)
          {
               _expected = expected;
               _actual = actual;
          }
          
          /// <summary>
          /// Overridden property from the base class
          /// </summary>
          public override string Message 
          {
               get 
               {
                    return string.Format("Value is not matching. Expected : {0} Actual: {1}",_expected.ToString(),_actual.ToString());
               }
          }
     }
}
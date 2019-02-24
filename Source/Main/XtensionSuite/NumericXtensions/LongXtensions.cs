// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;

namespace Nallenthal.Common.XtensionSuite.LongXtensions
{
     /// <summary>
     /// This class contains extension methods for <see cref="Int64"/>.
     /// </summary>
     public static class LongXtensions
     {
         /// <summary>
         /// Negates (* -1) the given long number.
         /// </summary>
         /// <param name="number">The given long number.</param>
         /// <returns>The negated long number.</returns>
          public static long Negate(this long number)
          {
               return number * -1;
          }
          
          /// <summary>
          /// Strips out the sign and returns the absolute value of given long number.
          /// </summary>
          /// <param name="number">The given long number.</param>
          /// <returns>The absolute value of given long number.</returns>
          public static long AbsoluteValue(this long number)
          {
               return Math.Abs(number);
          }
     }

    /// <summary>
    /// This Namespace contains extension methods for <see cref="Int64"/> class.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }
}

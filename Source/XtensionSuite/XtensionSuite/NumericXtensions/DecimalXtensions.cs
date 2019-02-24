// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;

namespace Nallenthal.Common.XtensionSuite.DecimalXtensions
{
     /// <summary>
     /// This class contains extension methods for <see cref="Decimal"/>.
     /// </summary>
     public static class DecimalXtensions
     {
         /// <summary>
         /// Rounds the decimal part of the given decimal number.
         /// </summary>
         /// <param name="number">The given decimal number.</param>
         /// <returns>The rounded value.</returns>
          public static long Round(this decimal number)
          {
               return (long)Math.Round(number);
          }
          
          /// <summary>
          /// Truncates the decimal part of the given decimal number.
          /// </summary>
          /// <param name="number">The given decimal number.</param>
          /// <returns>The truncated decimal number.</returns>
          public static long Truncate(this decimal number)
          {
               return (long)Math.Truncate(number);
          }
     }

    /// <summary>
    /// This Namespace contains extension methods for <see cref="Decimal"/>
    /// and other related classes.
    /// </summary>
     [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }
}

// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;

namespace Nallenthal.Common.XtensionSuite.DoubleXtensions
{
     /// <summary>
     /// This class contains extension methods for <see cref="Double"/>.
     /// </summary>
     public static class DoubleXtensions
     {
         /// <summary>
         /// Rounds the decimal portion of the given double number.
         /// </summary>
         /// <param name="number">The given double number.</param>
         /// <returns>The rounded double number.</returns>
          public static long Round(this double number)
          {
               return (long)Math.Round(number);
          }
          
          /// <summary>
          /// Truncates the decimal portion of the given double number.
          /// </summary>
          /// <param name="number">The given double number.</param>
          /// <returns>The truncated double number.</returns>
          public static long Truncate(this double number)
          {
               return (long)Math.Truncate(number);
          }
     }

    /// <summary>
    /// This Namespace contains extension methods for <see cref="Double"/>
    /// and other related classes.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }
}

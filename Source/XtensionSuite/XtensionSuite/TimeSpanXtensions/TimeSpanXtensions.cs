// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;

namespace Nallenthal.Common.XtensionSuite.TimeSpanXtensions
{
     /// <summary>
     /// This class contains extension methods for <see cref="TimeSpan"/>.
     /// </summary>
     public static class TimeSpanXtensions
     {
         /// <summary>
         /// Gets the number of weeks in the given time span.
         /// </summary>
         /// <param name="span">The given time span.</param>
         /// <returns>The number of weeks.</returns>
          public static int GetWeeks(this TimeSpan span)
          {
               return span.Days / Constants.DAYS_PER_WEEK;
          }

         /// <summary>
         /// Gets the number of fortnights in the given time span.
         /// </summary>
         /// <param name="span">The given time span.</param>
         /// <returns>The number of fortnights.</returns>          
          public static int GetFortnights(this TimeSpan span)
          {
               return span.GetWeeks() / Constants.WEEKS_PER_FORTNIGHT;
          }
     }

     /// <summary>
    /// This Namespace contains extension methods for <see cref="TimeSpan"/> class.
    /// </summary>
     [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }
}

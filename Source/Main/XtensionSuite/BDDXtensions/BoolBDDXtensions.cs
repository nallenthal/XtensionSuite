// Author : Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in

namespace Nallenthal.Common.XtensionSuite.BDDExtensions.BoolBDDXtensions
{
     using System;
     using Nallenthal.Common;
     using Nallenthal.Common.XtensionSuite.BoolXtensions;

     /// <summary>
     /// This class contains set of extension methods to ascertain boolean values.
     /// These can be used for unit testing and general validations.
     /// </summary>
     public static class BoolBDDXtensions
     {
         /// <summary>
         /// Ensures that the given boolean value is False.
         /// Checks the given boolean value and throws a <see cref="ValueMismatchException{T}"/>, if the item is not false.
         /// </summary>
         /// <param name="item">The given value.</param>
          public static void ShouldBeFalse(this bool item)
          {
               if (item.IsNotFalse())
               {
                    throw new ValueMismatchException<bool>(false, item);
               }
          }
          
          /// <summary>
          /// Ensures that the given boolean value is True
          /// Checks the given boolean value and throws a <see cref="ValueMismatchException{T}"/> if the item is not true. 
          /// </summary>
          /// <param name="item">The given value.</param>
          public static void ShouldBeTrue(this bool item)
          {
               if (item.IsNotTrue())
               {
                    throw new ValueMismatchException<bool>(true, item);
               }
          }
     }
     
    /// <summary>
    /// This Namespace contains BDD style extension methods for <see cref ="System.Boolean"></see>
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }
}

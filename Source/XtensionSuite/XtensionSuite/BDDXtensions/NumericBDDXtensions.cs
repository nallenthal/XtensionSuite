// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;
using Nallenthal.Common;

namespace Nallenthal.Common.XtensionSuite.BDDExtensions.NumericBDDXtensions
{
    /// <summary>
    /// This Class contains set of extension methods to ascertain values of objects that implement <see cref="IComparable"/>.
    /// These can be used for comparing numbers in unit tests and during validations.
    /// </summary>
    public static class NumericBDDXtensions 
    {
        /// <summary>
        /// Ensures that the firstItem is greater than the secondItem.
        /// Checks the two given values and throws a <see cref="ValueMismatchException{T}"/> if the firstItem is NOT greater than the secondItem.
        /// </summary>
        /// <param name="firstItem">The given first item.</param>
        /// <param name="secondItem">The second item to be compared.</param>
        /// <typeparam name="T">An instance of IComparable.</typeparam>
        public static void ShouldBeGreaterThan<T>(this T firstItem, T secondItem) where T : IComparable<T>
        {
            if (firstItem.CompareTo(secondItem) <= 0)
            {
                throw new ValueMismatchException<string>("a value greater than " + secondItem.ToString(), firstItem.ToString());
            }
        }
        
        /// <summary>
        /// Ensures that the firstItem is lesser than the secondItem 
        /// Checks the two given values and throws a <see cref="ValueMismatchException{T}"/> if the firsItem is NOT lesser than the secondItem.
        /// </summary>
        /// <param name="firstItem">The given first item.</param>
        /// <param name="secondItem">The second item to be compared.</param>
        /// <typeparam name="T">An instance IComparable.</typeparam>
        public static void ShouldBeLessThan<T>(this T firstItem, T secondItem) where T : IComparable<T>
        {
            if (firstItem.CompareTo(secondItem) >= 0)
            {
                throw new ValueMismatchException<string>("a value lesser than " + secondItem.ToString(), firstItem.ToString());
            }
        }  
        
        /// <summary>
        /// Ensures that the firstItem is equal to the secondItem
        /// Checks the two given values and throws a <see cref="ValueMismatchException{T}"/> if the firstItem is NOT equal to secondItem.              
        /// </summary>
        /// <param name="firstItem">The given first item.</param>
        /// <param name="secondItem">The second item to be compared.</param>
        /// <typeparam name="T">An instance of IComparable.</typeparam>
        public static void ShouldBeEqualTo<T>(this T firstItem, T secondItem) where T : IComparable<T>
        {
            if (firstItem.CompareTo(secondItem) != 0)
            {
                throw new ValueMismatchException<string>("a value equals to " + secondItem.ToString(), firstItem.ToString());
            }
        }
        
        /// <summary>
        /// Ensures that the firstItem is NOT greater than the secondItem
        /// Checks the two given values and throws a <see cref="ValueMismatchException{T}"/> if the firstItem is greater than the secondItem.
        /// </summary>
        /// <param name="firstItem">The given first item.</param>
        /// <param name="secondItem">The second item to be compared.</param>
        /// <typeparam name="T">An instance of IComparable.</typeparam>
        public static void ShouldNOTBeGreaterThan<T>(this T firstItem, T secondItem) where T : IComparable<T>
        {
            if (firstItem.CompareTo(secondItem) > 0)
            {
                throw new ValueMismatchException<string>("a value NOT greater than " + secondItem.ToString(), firstItem.ToString());
            }
        }
        
        /// <summary>
        /// Ensures that the first item is NOT lesser than the second item
        /// Checks the two given values and throws a <see cref="ValueMismatchException{T}"/> if the firsItem is lesser than the secondItem.
        /// </summary>
        /// <param name="firstItem">The given first item.</param>
        /// <param name="secondItem">The second item to be compared.</param>
        /// <typeparam name="T">An instance of IComparable.</typeparam>
        public static void ShouldNOTBeLessThan<T>(this T firstItem, T secondItem) where T : IComparable<T>
        {
            if (firstItem.CompareTo(secondItem) < 0)
            {
                throw new ValueMismatchException<string>("a value NOT lesser than " + secondItem.ToString(), firstItem.ToString());
            }
        }  
        
        /// <summary>
        /// Ensures that the first item is NOT equal to the second item
        /// Checks the two given values and throws a <see cref="ValueMismatchException{T}"/> if the firstItem is equal to secondItem.              
        /// </summary>
        /// <param name="firstItem">The given first item.</param>
        /// <param name="secondItem">The second item to be compared.</param>
        /// <typeparam name="T">An instance of IComparable.</typeparam>
        public static void ShouldNOTBeEqualTo<T>(this T firstItem, T secondItem) where T : IComparable<T>
        {
            if (firstItem.CompareTo(secondItem) == 0)
            {
                throw new ValueMismatchException<string>("a value NOT equals to " + secondItem.ToString(), firstItem.ToString());
            }
        }
    }
    
    /// <summary>
    /// This Namespace contains BDD style extension methods for numbers.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }
}

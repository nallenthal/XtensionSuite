// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in

using System;
using System.Collections.Generic;
using Nallenthal.Common.XtensionSuite.BoolXtensions;

namespace Nallenthal.Common.XtensionSuite.GenericXtensions
{
    /// <summary>
    /// This class contains set of generic extension methods.
    /// </summary>    
    public static class GenericXtensions
    {
        /// <summary>
        /// Checks whether the given instance tobject exists in the list of values.
        /// </summary>
        /// <param name="tobject">The given object.</param>
        /// <param name="values">The list of values.</param>
        /// <typeparam name="T">Refers the type of the object to be checked and values.</typeparam>
        /// <returns>True if tobject is present in values, false otherwise.</returns>
        public static bool IsIn<T>(this T tobject, params T[] values)
        {
            var list = new List<T>(values);
            return list.Contains(tobject);
        }
        
        /// <summary>
        /// Checks whether the given instance tobject does NOT exist in the list of values.
        /// </summary>
        /// <param name="tobject">The given object.</param>
        /// <param name="values">The list of values.</param>
        /// <typeparam name="T">Refers the type of the object to be checked and values.</typeparam>
        /// <returns>True if tobject is NOT present in values, false otherwise.</returns>
        public static bool IsNotIn<T>(this T tobject, params T[] values)
        {
            return tobject.IsIn(values).Toggle();
        }
        
        /// <summary>
        /// Wraps the given object into a List{T} and returns the list.
        /// </summary>
        /// <param name="tobject">The object to be wrapped.</param>
        /// <typeparam name="T">Refers the object to be returned as List{T}.</typeparam>
        /// <returns>Returns List{T}.</returns>
        public static List<T> AsList<T>(this T tobject)
        {
            return new List<T> { tobject };
        }
    }

    /// <summary>
    /// This namespace contains a set of generic extension methods. 
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }
}

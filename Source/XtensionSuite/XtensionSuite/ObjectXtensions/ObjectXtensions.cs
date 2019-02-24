// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in

using System;
using Nallenthal.Common.XtensionSuite.BoolXtensions;

namespace Nallenthal.Common.XtensionSuite.ObjectXtensions
{
    /// <summary>
    /// This class contains set of extension methods for <see cref="Object"></see>.
    /// </summary>    
    public static class ObjectXtensions
    {
        /// <summary>
        /// Checks whether the given object is of {T}.
        /// </summary>
        /// <param name="obj">The object to be checked.</param>
        /// <typeparam name="T">Refers the target data type.</typeparam>
        /// <returns>True if the given object is of type T, false otherwise.</returns>
        public static bool IsA<T>(this object obj)
        {
            return obj is T;
        }
        
        /// <summary>
        /// Checks whether the given object is NOT of type T.
        /// </summary>
        /// <param name="obj">The object to be checked.</param>
        /// <typeparam name="T">Refers the target data type.</typeparam>
        /// <returns>True if the given object is NOT of type T, false otherwise.</returns>
        public static bool IsNotA<T>(this object obj)
        {
            return obj.IsA<T>().Toggle();
        }
        
        /// <summary>
        /// Tries to cast the given object to type T.
        /// </summary>
        /// <param name="obj">The object to be casted.</param>
        /// <typeparam name="T">Refers target data type.</typeparam>
        /// <returns>Returns the casted objects. Null if casting fails.</returns>
        public static T As<T>(this object obj) where T : class
        {
            return obj as T;
        }
        
        /// <summary>
        /// Checks whether the given object is Null.
        /// </summary>
        /// <param name="obj">The object to be checked.</param>
        /// <returns>True if the object is Null, false otherwise.</returns>
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
        
        /// <summary>
        /// Checks whether the given object is NOT Null.
        /// </summary>
        /// <param name="obj">The object to be checked.</param>
        /// <returns>True if the object is NOT Null, false otherwise.</returns>
        public static bool IsNotNull(this object obj)
        {
            return obj.IsNull().Toggle();
        }
        
        /// <summary>
        /// Checks whether the given object has some value. Similar to IsNotNull().
        /// </summary>
        /// <param name="obj">The object to be checked.</param>
        /// <returns>True if the object is NOT Null, false otherwise.</returns>
        public static bool HasValue(this object obj)
        {
            return obj.IsNotNull();
        }
    }

    /// <summary>
    /// This Namespace contains extension methods for <see cref="Object"/>.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }    
}

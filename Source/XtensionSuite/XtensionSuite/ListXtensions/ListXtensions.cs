// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in

using System;
using System.Collections.Generic;

namespace Nallenthal.Common.XtensionSuite.ListXtensions
{
    /// <summary>
    /// This class contains a set of extension methods for <see cref="List{T}">.</see>
    /// </summary>
    public static class ListXtensions
    {
        /// <summary>
        /// Method that adds multiple lists to a single list.
        /// </summary>
        /// <param name="list">The master list.</param>
        /// <param name="lists">The list of child lists.</param>
        /// <typeparam name="T">Refers the type in the List.</typeparam>
        public static void AddRange<T>(this List<T> list, params List<T>[] lists)
        {
            foreach (var childList in lists) 
            {
                list.AddRange(childList);
            }
        }
    }

    /// <summary>
    /// This Namespace contains set of extension methods for <see cref="List{T}"></see> class.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }
}

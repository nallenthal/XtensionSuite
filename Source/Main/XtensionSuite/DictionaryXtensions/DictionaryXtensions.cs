// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in

using System;
using System.Collections.Generic;

namespace Nallenthal.Common.XtensionSuite.DictionaryXtensions
{
    /// <summary>
    /// This class contains a set of extension methods for <see cref="Dictionary{TKey,TValue}"></see>.
    /// </summary>
    public static class DictionaryXtensions
    {
        /// <summary>
        /// Method that adds the given key and value to the given dictionary only if the key is NOT present in the dictionary.
        /// This will be useful to avoid repetitive "if(!containskey()) then add" pattern of coding.
        /// </summary>
        /// <param name="dict">The given dictionary.</param>
        /// <param name="key">The given key.</param>
        /// <param name="value">The given value.</param>
        /// <returns>True if added successfully, false otherwise.</returns>
        /// <typeparam name="TKey">Refers the TKey type.</typeparam>
        /// <typeparam name="TValue">Refers the TValue type.</typeparam>
        public static bool AddIfNotExists<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, value);
                return true;
            }
            
            return false;
        }
        
        /// <summary>
        /// Method that adds the given key and value to the given dictionary if the key is NOT present in the dictionary.
        /// If present, the value will be replaced with the new value.
        /// </summary>
        /// <param name="dict">The given dictionary.</param>
        /// <param name="key">The given key.</param>
        /// <param name="value">The given value.</param>
        /// <typeparam name="TKey">Refers the Key type.</typeparam>
        /// <typeparam name="TValue">Refers the Value type.</typeparam>
        public static void AddOrReplace<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = value;
                return;
            }
            
            dict.Add(key, value);
        }
        
        /// <summary>
        /// Method that adds the list of given KeyValuePair objects to the given dictionary. If a key is already present in the dictionary,
        /// then an error will be thrown.
        /// </summary>
        /// <param name="dict">The given dictionary.</param>
        /// <param name="kvpList">The list of KeyValuePair objects.</param>
        /// <typeparam name="TKey">Refers the TKey type.</typeparam>
        /// <typeparam name="TValue">Refers the TValue type.</typeparam>
        public static void AddRange<TKey, TValue>(this Dictionary<TKey, TValue> dict, List<KeyValuePair<TKey, TValue>> kvpList)
        {
            foreach (var kvp in kvpList) 
            {
                dict.Add(kvp.Key, kvp.Value);
            }
        }
    }
    
    /// <summary>
    /// This Namespace contains set of extension methods for <see cref="Dictionary{TKey,TValue}"></see> class.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }    
}

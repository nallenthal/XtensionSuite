// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Nallenthal.Common.XtensionSuite.BoolXtensions;

namespace Nallenthal.Common.XtensionSuite.StringXtensions
{
     /// <summary>
     /// This class contains extension methods for <see cref="String"/>.
     /// </summary>
    public static class StringXtensions
    {
        /// <summary>
        /// Inverts the case of each character in the given string and returns the new string.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>The converted string.</returns>
        public static string InvertCase(this string s)
        {
            return new string(
            s.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ?
                      char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
        }
        
        /// <summary>
        /// Checks whether the given string is null, else if empty after trimmed.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>True if string is Null or Empty, false otherwise.</returns>
        public static bool IsNullOrEmptyAfterTrimmed(this string s)
        {
            return (s == null) || string.IsNullOrEmpty(s.Trim());
        }
        
        /// <summary>
        /// Converts the given string to <see cref="List{Char}"/>.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>Returns a list of char.</returns>
        public static List<char> ToCharList(this string s)
        {
            return s.ToCharArray().ToList();
        }
        
        /// <summary>
        /// Extracts the substring starting from 'start' position to 'end' position.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <param name="start">The start position.</param>
        /// <param name="end">The end position.</param>
        /// <returns>The substring.</returns>
        public static string SubstringFromXToY(this string s, int start, int end)
        {
            return s.Substring(start, end - start);
        }
        
        /// <summary>
        /// Removes the given character from the given string and returns the new string.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <param name="c">The character to be removed.</param>
        /// <returns>The new string.</returns>
        public static string RemoveChar(this string s, char c)
        {
            return s.Replace(c.ToString(), string.Empty);
        }
        
        /// <summary>
        /// Returns the number of words in the given string.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>The word count.</returns>
        public static int GetWords(this string s)
        {
            return (new Regex(@"\w+")).Matches(s).Count;
        }
        
        /// <summary>
        /// Returns the reversed string.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>The reversed string.</returns>
        public static string Reverse(this string s)
        {
            var array = s.ToList();
            array.Reverse();
            return new string(array.ToArray());
        }
        
        /// <summary>
        /// Checks whether the given string is a palindrome.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>True if the given string is palindrome, false otherwise.</returns>
        public static bool IsPalindrome(this string s)
        {
            return s.Equals(s.Reverse());
        }
        
        /// <summary>
        /// Checks whether the given string is NOT a palindrome.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>True if the given string is NOT palindrome, false otherwise.</returns>
        public static bool IsNotPalindrome(this string s)
        {
            return s.IsPalindrome().Toggle();
        }
        
        /// <summary>
        /// Checks whether the given string is a valid email using regular expressions.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>True if it is a valid email, false otherwise.</returns>
        public static bool IsAValidEmail(this string s)
        {
            return Regex.IsMatch(
                                s,
                                 @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$");
        }
        
        /// <summary>
        /// Checks whether the given string is a valid IP address using regular expressions.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>True if it is a valid IP address, false otherwise.</returns>
        public static bool IsAValidIPAddress(this string s)
        {
            return Regex.IsMatch(s, @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");
        }
        
        /// <summary>
        /// Appends the given separator to the given string.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <param name="sep">The separator to be appended.</param>
        /// <returns>The appended string.</returns>
        public static string AppendSep(this string s, string sep)
        {
            return s + sep;
        }
        
        /// <summary>
        /// Appends the a comma to the given string.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>The appended string.</returns>
        public static string AppendComma(this string s)
        {
            return s.AppendSep(",");
        }
        
        /// <summary>
        /// Appends the a space to the given string.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>The appended string.</returns>
        public static string AppendSpace(this string s)
        {
            return s.AppendSep(" ");
        }
        
        /// <summary>
        /// Appends the a hyphen to the given string.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <returns>The appended string.</returns>
        public static string AppendHyphen(this string s)
        {
            return s.AppendSep("-");
        }
        
        /// <summary>
        /// Appends the given character to the given string and returns the new string.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <param name="sep">The character to be appended.</param>
        /// <returns>The appended string.</returns>
        public static string AppendSep(this string s, char sep)
        {
            return s.AppendSep(sep.ToString());
        }
        
        /// <summary>
        /// Returns this string + sep + newString.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <param name="newString">The string to be concatenated.</param>
        /// <param name="sep">The separator to be introduced in between these two strings.</param>
        /// <returns>The appended string.</returns>
        /// <remarks>This may give poor performance for large number of strings used in loop. Use <see cref="StringBuilder"/> instead.</remarks>
        public static string AppendWithSep(this string s, string newString, string sep)
        {
            return s.AppendSep(sep) + newString;
        }
        
        /// <summary>
        /// Returns this string + sep + newString.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <param name="newString">The string to be concatenated.</param>
        /// <param name="sep">The separator to be introduced in between these two strings.</param>
        /// <returns>The appended string.</returns>
        /// <remarks>This may give poor performance for large number of strings used in loop. Use <see cref="StringBuilder"/> instead.</remarks>
        public static string AppendWithSep(this string s, string newString, char sep)
        {
            return s.AppendSep(sep) + newString;
        }

        /// <summary>
        /// Returns this string + "," + newString.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <param name="newString">The string to be concatenated.</param>
        /// <returns>The appended string.</returns>
        /// <remarks>This may give poor performance for large number of strings used in loop. Use <see cref="StringBuilder"/> instead.</remarks>
        public static string AppendWithComma(this string s, string newString)
        {
            return s.AppendWithSep(newString, ",");
        }
        
        /// <summary>
        /// Returns this string + "-" + newString.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <param name="newString">The string to be concatenated.</param>
        /// <returns>The appended string.</returns>
        /// <remarks>This may give poor performance for large number of strings used in loop. Use <see cref="StringBuilder"/> instead.</remarks>
        public static string AppendWithHyphen(this string s, string newString)
        {
            return s.AppendWithSep(newString, "-");
        }
        
        /// <summary>
        /// Returns this string + " " + newString.
        /// </summary>
        /// <param name="s">The given string.</param>
        /// <param name="newString">The string to be concatenated.</param>
        /// <returns>The appended string.</returns>
        /// <remarks>This may give poor performance for large number of strings used in loop. Use <see cref="StringBuilder"/> instead.</remarks>
        public static string AppendWithSpace(this string s, string newString)
        {
            return s.AppendWithSep(newString, " ");
        }
    }

    /// <summary>
    /// This Namespace contains extension methods for <see cref="String"/> class.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }
}

﻿// <auto-generated/>
using System;
using System.Collections.Generic;
using System.Linq;

namespace Insight.Database.MissingExtensions
{
    /// <summary>
    /// Adds missing methods.
    /// </summary>
    public static class MissingExtensions
    {
        /// <summary>
        /// Determines if a string is null or all whitespace.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>False if the string contains at least one non-whitespace character.</returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return String.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Returns the maximum value in a sequence or the default.
        /// </summary>
        /// <typeparam name="T1">The type of the sequence.</typeparam>
        /// <typeparam name="T2">The type of the value.</typeparam>
        /// <param name="list">The list to evaluate.</param>
        /// <param name="selector">A function to select the value.</param>
        /// <returns>The maximum selected value or the default.</returns>
        public static T2 MaxOrDefault<T1, T2>(this IEnumerable<T1> list, Func<T1, T2> selector)
        {
            if (!list.Any())
                return default(T2);

            return list.Max(selector);
        }
    }
}

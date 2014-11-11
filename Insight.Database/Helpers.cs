﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.Database
{
	/// <summary>
	/// Internal helpers.
	/// </summary>
	static class Helpers
	{
#if NODBASYNC
		/// <summary>
		/// Represents a completed false task.
		/// </summary>
		internal static readonly Task<bool> FalseTask = Task<bool>.Factory.StartNew(() => false);

		/// <summary>
		/// Returns a completed task from the given result.
		/// </summary>
		/// <typeparam name="T">The type of the result.</typeparam>
		/// <param name="result">The result.</param>
		/// <returns>A completed task.</returns>
		internal static Task<T> FromResult<T>(T result)
		{
			return Task.Factory.StartNew(() => result);
		}
#else
		/// <summary>
		/// Represents a completed false task.
		/// </summary>
		internal static readonly Task<bool> FalseTask = Task.FromResult(false);

		/// <summary>
		/// Returns a completed task from the given result.
		/// </summary>
		/// <typeparam name="T">The type of the result.</typeparam>
		/// <param name="result">The result.</param>
		/// <returns>A completed task.</returns>
		internal static Task<T> FromResult<T>(T result)
		{
			return Task.FromResult(result);
		}
#endif

#if NET35
		internal static bool HasFlag(this Enum e, Enum flag)
		{
			ulong f = Convert.ToUInt64(flag);
			return ((Convert.ToUInt64(e) & f) == f);
		}
#endif

        /// <summary>
        /// Determines whether two strings are case-insensitive equal.
        /// </summary>
        /// <param name="s1">The first string.</param>
        /// <param name="s2">The second string.</param>
        /// <returns>True if they are equal.</returns>
        internal static bool IsIEqualTo(this string s1, string s2)
        {
            return String.Compare(s1, s2, StringComparison.OrdinalIgnoreCase) == 0;
        }
	}
}

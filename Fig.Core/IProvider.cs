﻿using System.Collections.Generic;

namespace Fig
{
    /// <summary>
    /// Interface for all Providers
    /// </summary>
    public interface IProvider
    {
        bool TryGetValue(string key, out string value);

        /// <summary>
        /// Return all the keys
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        IEnumerable<string> AllKeys(string prefix = "");

        /// <summary>
        /// Retrieve the value associated with a given key
        /// </summary>
        /// <param name="key">Case insensitive key</param>
        /// <returns>the associated value or throw a KeyNotFoundException</returns>
        string Get(string key);
    }
}
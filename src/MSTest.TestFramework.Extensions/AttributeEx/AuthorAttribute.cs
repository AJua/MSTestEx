﻿using System;

namespace MSTest.TestFramework.Extensions.AttributeEx
{
    /// <summary>The AuthorAttribute adds information about the author of a test method.</summary>
    /// <param name="name">string representing the author name.</param>"
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(
            string name)
        {
            Value = name;
        }

        public string Value { get; }
    }
}

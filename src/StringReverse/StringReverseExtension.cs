using System;
using System.Collections.Generic;
using System.Globalization;

namespace StringReverse
{
    public static class StringReverseExtension
    {
        public static string Reverse(this string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            var enumerator = StringInfo.GetTextElementEnumerator(value);
            var elements = new List<string>();

            while (enumerator.MoveNext())
            {
                elements.Add(enumerator.GetTextElement());
            }

            elements.Reverse();

            return String.Concat(elements);
        }
    }
}
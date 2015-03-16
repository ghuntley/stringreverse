using System;
using System.Collections.Generic;
using System.Globalization;

namespace StringReverse
{
    public static class StringReverseExtension
    {
        public static string StringReverse(this string value)
        {
            if (value == null)
            {
                throw new NullReferenceException("Supplied argument 'value' is null.");
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
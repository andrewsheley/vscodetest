using System;

namespace vsmvc2
{
    public static class ExtensionMethods
    {
        public static string GetMe(this string value)
        {
            return value + " " + DateTime.Now;
        }
    }
}
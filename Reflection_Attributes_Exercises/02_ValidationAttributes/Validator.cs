using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                var attributes = property.GetCustomAttributes()
                    .Where(t => t.GetType().IsSubclassOf(typeof(MyValidationAttribute)))
                    .Cast<MyValidationAttribute>()
                    .ToArray();
                foreach (var atr in attributes)
                {
                    bool isValid = atr.IsValid(property.GetValue(obj));

                    if (!isValid) return false;
                }
            }
            return true;
        }
    }
}

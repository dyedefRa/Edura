using Edura.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Helpers
{
    public static class Extensions
    {
        public static bool isNotNull(this object item)
        {
            return item != null;
        }

        //public static TResult IfNotNull<T, TResult>(this T target, Func<T, TResult> getValue)
        //{
        //    if (target != null)
        //        return getValue(target);
        //    else
        //        return default(TResult);
        //}
    }
}

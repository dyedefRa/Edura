﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Helpers
{
    public static class SessionExtension
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

        
            return value == null ?
                 default(T) : (T)JsonConvert.DeserializeObject(value);
        }
    }
}

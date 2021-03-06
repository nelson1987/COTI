﻿using System.Collections;
using System.Linq;
using System.Web.Http.ModelBinding;

namespace Projeto.Presentation.Api.Util
{
    public class ValidationUtil
    {
        public static Hashtable GetErrorMessages(ModelStateDictionary ModelState)
        {
            var errors = new Hashtable();
            foreach (var item in ModelState)
            {
                if (item.Value.Errors.Count > 0)
                    errors[item.Key] = item.Value.Errors.Select(x => x.ErrorMessage).ToList();
            }
            return errors;
        }
    }
}
using Microsoft.AspNetCore.Http;
using PersonasWebCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasWebCore
{
    public static class PersonaExtension
    {
        public static Persona CreateModel(this Persona persona, IFormCollection collection)
        {
            var model = Activator.CreateInstance(typeof(Persona)) as Persona;
            Type typeModel = typeof(Persona);
            foreach (var item in typeModel.GetProperties())
            {
                var key = item.Name;
                var tipoDato = item.PropertyType.Name;
                if (collection.Keys.Contains(key))
                {
                    Microsoft.Extensions.Primitives.StringValues value = collection[key];
                    switch (tipoDato)
                    {
                        case "String":
                            item.SetValue(model, value[0]);
                            break;
                        case "Int32":
                            item.SetValue(model, int.Parse(value[0]));
                            break;
                        case "DateTime":
                            item.SetValue(model, Convert.ToDateTime(value[0]));
                            break;
                        case "Boolean":
                            item.SetValue(model, Convert.ToBoolean(value[0]));
                            break;

                        default:
                            break;
                    }
                }
            }
            return model;
        }
    }
}

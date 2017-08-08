﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HarestingFields.Engine
{
    using System.Reflection;

    public class ProtectedCommand
    {
        public string Execute()
        {
            StringBuilder sb = new StringBuilder();

            var typeInfo = typeof(HarvestingFields);
            var protectedFields = typeInfo.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.IsFamily);

            foreach (FieldInfo field in protectedFields)
            {
                sb.AppendLine($"protected {field.FieldType.Name} {field.Name}");
            }

            return sb.ToString().Trim();
        }
    }
}

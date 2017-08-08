using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HarestingFields.Engine
{
    using System.Reflection;

    public class PublicCommand
    {
        public string Execute()
        {
            StringBuilder sb = new StringBuilder();

            var typeInfo = typeof(HarvestingFields);
            var publicFields = typeInfo.GetFields(BindingFlags.Instance | BindingFlags.Public);

            foreach (FieldInfo field in publicFields)
            {
                sb.AppendLine($"public {field.FieldType.Name} {field.Name}");
            }

            return sb.ToString().Trim();
        }
    }
}

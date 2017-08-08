using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HarestingFields.Engine
{
    using System.Reflection;

    public class PrivateCommand
    {
        public string Execute()
        {
            StringBuilder sb = new StringBuilder();

            var typeInfo = typeof(HarvestingFields);
            var privateFields = typeInfo.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.IsPrivate);

            foreach (FieldInfo privateField in privateFields)
            {
                sb.AppendLine($"private {privateField.FieldType.Name} {privateField.Name}");
            }

            return sb.ToString().Trim();
        }
    }
}

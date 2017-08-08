using System.Text;

namespace _01HarestingFields.Engine
{
    using System.Reflection;

    public class AllCommand
    {
        public string Execute()
        {
            StringBuilder sb = new StringBuilder();

            var typeInfo = typeof(HarvestingFields);
            var allFields = typeInfo.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            string fieldModifier = null;

            foreach (FieldInfo fieldInfo in allFields)
            {
                if (fieldInfo.IsFamily)
                {
                    fieldModifier = "protected";
                }
                else if (fieldInfo.IsPublic)
                {
                    fieldModifier = "public";
                }
                else if (fieldInfo.IsPrivate)
                {
                    fieldModifier = "private";
                }

                sb.AppendLine($"{fieldModifier} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
            }

            return sb.ToString().Trim();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _02BlackBoxInteger.Models;

namespace _02BlackBoxInteger.Engine.Commands
{
    public class RightShiftCommand
    {
        public string Execute(object instance, int value)
        {
            var typeInfo = typeof(BlackBoxInt);
            var rightShiftMethod = instance.GetType().GetMethod("RightShift", BindingFlags.Instance | BindingFlags.NonPublic);
            rightShiftMethod.Invoke(instance, new object[] { value });
            var result = typeInfo.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault()
                .GetValue(instance).ToString();

            return result;
        }
    }
}

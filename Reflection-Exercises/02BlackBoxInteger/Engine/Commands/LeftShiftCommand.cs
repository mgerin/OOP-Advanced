﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _02BlackBoxInteger.Models;

namespace _02BlackBoxInteger.Engine.Commands
{
    public class LeftShiftCommand
    {
        public string Execute(object instance, int value)
        {
            var typeInfo = typeof(BlackBoxInt);
            var leftShiftMethod = instance.GetType().GetMethod("LeftShift", BindingFlags.Instance | BindingFlags.NonPublic);
            leftShiftMethod.Invoke(instance, new object[] { value });
            var result = typeInfo.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault()
                .GetValue(instance).ToString();

            return result;
        }
    }
}

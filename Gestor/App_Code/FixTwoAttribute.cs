using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace Gestor.App_Code
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class FixTwoAttribute : ValidationAttribute
    {
    }
}
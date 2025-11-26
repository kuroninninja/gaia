using System;
using System.ComponentModel;
using System.Reflection;

namespace gaia.locations 
{
    // Enum for all possible locations
    public enum Location
    {
        Placeholder,
        [Description("White Bed")]
        StartingBed
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute attribute =
                Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
                as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}

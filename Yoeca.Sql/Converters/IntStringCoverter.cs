using System;
using System.ComponentModel;
using System.Globalization;

namespace Yoeca.Sql
{
    internal sealed class IntStringCoverter : StringConverter
    {
        public override object ConvertTo(
            ITypeDescriptorContext context,
            CultureInfo culture,
            object value,
            Type destinationType)
        {
            return ((int) value).ToString(CultureInfo.InvariantCulture);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value == null)
            {
                return 0;
            }
            return int.Parse((string) value);
        }
    }
}
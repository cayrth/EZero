using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace EZero.Infrastructure.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// 获取枚举类Description
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum value)
        {
            if (value == null)
                return string.Empty;

            try
            {
                FieldInfo field = value.GetType().GetField(value.ToString());

                if (field == null)
                {
                    return string.Empty;
                }

                DescriptionAttribute attribute
                        = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
                            as DescriptionAttribute;

                return attribute == null ? value.ToString() : attribute.Description;
            }
            catch (Exception ex)
            {

                return string.Empty;
            }
        }

        /// <summary>
        /// 把枚举转换为键值对集合
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="getText">获得值得文本</param>
        /// <returns>以枚举值为key，枚举文本为value的键值对集合</returns>
        public static Dictionary<int, string> EnumToDictionary(this Type enumType, Func<Enum, string> getText)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException("传入的参数必须是枚举类型！", "enumType");
            }
            Dictionary<int, String> enumDic = new Dictionary<int, string>();
            Array enumValues = Enum.GetValues(enumType);
            foreach (Enum enumValue in enumValues)
            {
                var key = Convert.ToInt32(enumValue);
                var value = getText(enumValue);
                enumDic.Add(key, value);
            }
            return enumDic;
        }

        ///// <summary>
        ///// 获取枚举类MbtiDimensionInitials
        ///// </summary>
        ///// <param name="value"></param>
        ///// <returns></returns>
        //public static string GetInitials(this Enum value)
        //{
        //    if (value == null)
        //        return string.Empty;

        //    try
        //    {
        //        FieldInfo field = value.GetType().GetField(value.ToString());

        //        if (field == null)
        //        {
        //            return string.Empty;
        //        }

        //        InitialsAttribute attribute
        //                = Attribute.GetCustomAttribute(field, typeof(InitialsAttribute))
        //                    as InitialsAttribute;

        //        return attribute == null ? value.ToString().Substring(0, 1) : attribute.Initials;
        //    }
        //    catch (Exception ex)
        //    {

        //        return string.Empty;
        //    }
        //}
    }
}

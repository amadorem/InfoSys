using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.AutoMapper
{
    public static class Extensions
    {
        public static TDestination Map<TDestination>(this object source)
            where TDestination : class
        {
            return Mapper.Map<object, TDestination>(source);
        }

        public static IEnumerable<TDestination> Map<TDestination>(this IEnumerable<object> source)
            where TDestination : class
        {
            foreach (var item in source)
            {
                yield return item.Map<TDestination>();
            }
        }
    }
}

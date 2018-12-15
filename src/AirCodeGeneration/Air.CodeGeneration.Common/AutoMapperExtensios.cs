using System.Collections.Generic;
using System.Collections;
using AutoMapper;
using System;
using AutoMapper.Configuration;
using AutoMapper.Mappers.Internal;

namespace Air.CodeGeneration.Common
{
    //public static class AutoMapperExtensios
    //{


    //    /// <summary>
    //    /// 将源对象映射到目标对象
    //    /// </summary>
    //    /// <typeparam name="TSource">源类型</typeparam>
    //    /// <typeparam name="TDestination">目标类型</typeparam>
    //    /// <param name="source">源对象</param>
    //    /// <param name="destination">目标对象</param>
    //    /// <returns></returns>
    //    public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
    //    {

    //        return MapTo<TDestination>(source, destination);
    //    }

    //    /// <summary>
    //    /// 将源对象映射到目标对象
    //    /// </summary>
    //    /// <typeparam name="TSource">源类型</typeparam>
    //    /// <typeparam name="TDestination">目标类型</typeparam>
    //    /// <param name="source">源对象</param>
    //    /// <returns></returns>
    //    public static TDestination MapTo<TSource, TDestination>(this TSource source) where TDestination : new()
    //    {
    //        return MapTo(source, new TDestination());
    //    }

    //    /// <summary>
    //    /// 将源对象映射到目标对象
    //    /// </summary>
    //    /// <typeparam name="TDestination">目标类型</typeparam>
    //    /// <param name="source">源对象</param>
    //    /// <param name="destination">目标对象</param>
    //    /// <returns></returns>
    //    private static TDestination MapTo<TDestination>(object source, TDestination destination)
    //    {
    //        if (source == null)
    //        {
    //            throw new ArgumentNullException(nameof(source));
    //        }
    //        if (destination == null)
    //        {
    //            throw new ArgumentNullException(nameof(destination));
    //        }
    //        var sourceType = GetObjectType(source.GetType());
    //        var destinationType = GetObjectType(typeof(TDestination));
    //        try
    //        {
    //            //AutoMapper.Mapper.Map<Source, Destination>换成AutoMapper.Mapper.DynamicMap<Source, Destination>
    //            //先搜索是否已存在映射配置项
    //            var map = AutoMapper.Mapper.Configuration.FindTypeMapFor(sourceType, destinationType);
    //            if (map != null)
    //            {
    //                return AutoMapper.Mapper.Map(source, destination);
    //            }
    //            //没有则将原有的映射配置加本次的映射配置重新初始化
    //            var maps = AutoMapper.Mapper.Configuration.GetAllTypeMaps();
    //            AutoMapper.Mapper.Initialize(config =>
    //            {
    //                foreach (var item in maps)
    //                {
    //                    config.CreateMap(item.SourceType, item.DestinationType);
    //                }
    //                config.CreateMap(sourceType, destinationType);
    //            });
    //        }
    //        catch (InvalidOperationException ex)
    //        {
    //            AutoMapper.Mapper.Reset();
    //            AutoMapper.Mapper.Initialize(config =>
    //            {
    //                config.CreateMap(sourceType, destinationType);
    //            });
    //        }

    //        return AutoMapper.Mapper.Map(source, destination);
    //    }

    //    /// <summary>
    //    /// 获取对象类型
    //    /// </summary>
    //    /// <param name="source">类型</param>
    //    /// <returns></returns>
    //    private static Type GetObjectType(Type source)
    //    {
    //        if (source.IsGenericType && typeof(IEnumerable).IsAssignableFrom(source))
    //        {
    //            var type = source.GetGenericArguments()[0];
    //            return GetObjectType(type);
    //        }
    //        return source;
    //    }
    //}
}

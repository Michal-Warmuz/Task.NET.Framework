using AutoMapper;
using System;
using System.Linq.Expressions;
using Task.Core.Domain;
using Task.Infrastructure.Dtos;

namespace Task.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMappingExpression<TSource, TDestination> Ignore<TSource, TDestination>(
            this IMappingExpression<TSource, TDestination> map,
            Expression<Func<TDestination, object>> selector)
        {
            map.ForMember(selector, config => config.Ignore());
            return map;
        }

        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Guest, GuestDto>().ReverseMap();
                cfg.CreateMap<Reservation, ReservationDto>().ReverseMap();
            }).CreateMapper();
    }
}

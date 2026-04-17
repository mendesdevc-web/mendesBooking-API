using AutoMapper;
using Booking_Domain.Models;
using MendesBooking.Api.Dtos;
using System;

namespace MendesBooking.Api.Automapper
{
    public class HotelMappingProfiles : Profile
    {
        public HotelMappingProfiles()
        {
            CreateMap<HotelCreateDto, Hotel>();
            CreateMap<Hotel, HotelGetDto>();
        }
    }
}

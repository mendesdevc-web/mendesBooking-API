using AutoMapper;
using Booking_Domain.Models;
using MendesBooking.Api.Dtos;
using System;

namespace MendesBooking.Api.Automapper
{
    public class RoomMappingProfiles : Profile
    {
        public RoomMappingProfiles()
        {
            CreateMap<Room, RoomGetDto>();
            CreateMap<RoomPostPutDto, Room>();
        }
    }
}

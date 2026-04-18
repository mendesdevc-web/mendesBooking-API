using Booking.Domain.Models;
using Booking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking.Domain.Abstractions.Services
{
    public interface IReservationService
    {
        Task<Reservation> MakeReservationAsync(Reservation reservation);
        Task<List<Reservation>> GetAllReservationsAsync();
        Task<Reservation> GetReservationByIdAsync(int id);
        Task<Reservation> DeleteReservationAsync(int id);
    }
}
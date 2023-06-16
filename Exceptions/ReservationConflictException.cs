using ReservationManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManager.Exceptions
{
    /// <summary>
    /// ReservationConflictException class for reservation conflict exception
    /// </summary>
    public class ReservationConflictException : Exception
    {
        #region Properties
        public Reservation ExistingReservation { get; }
        public Reservation IncomingReservation { get; }
        #endregion

        #region Constructors
        public ReservationConflictException(Reservation existingReservation, Reservation incomingReservation)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictException(string? message, Reservation existingReservation, Reservation incomingReservation)
            : base(message)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictException(string? message, Exception? innerException, Reservation existingReservation, Reservation incomingReservation)
            : base(message, innerException)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }
        #endregion
    }
}

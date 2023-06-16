using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationManager.Exceptions;

namespace ReservationManager.Models
{
    /// <summary>
    /// ReservationList class of object reservation list.
    /// </summary>
    public class ReservationList
    {
        #region Fields/Attributes
        private readonly List<Reservation> _reservations;
        #endregion

        #region Constructor
        public ReservationList()
        {
            _reservations = new List<Reservation>();
        }
        #endregion

        #region Methods
        public IEnumerable<Reservation> GetReservationsForReserver(string reserverName)
        {
            return _reservations.Where(r => r.ReserverName == reserverName);
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservations;
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }

            _reservations.Add(reservation);
        }

        public void RemoveReservation(Reservation reservation)
        {
            _reservations.Remove(reservation);
        }
        #endregion
    }
}

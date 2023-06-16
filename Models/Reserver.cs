using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManager.Models
{
    /// <summary>
    /// Reserver class for object reserver.
    /// </summary>
    public class Reserver
    {
        #region Fields/Attributes
        private readonly ReservationList _reservationList;
        #endregion

        #region Properties
        public string Name { get; }
        #endregion

        #region Constructor
        public Reserver(string name)
        {
            _reservationList = new ReservationList();
            Name = name;
        }
        #endregion

        #region Methods
        public IEnumerable<Reservation> GetReservationsForReserver(string reserverID)
        {
            return _reservationList.GetReservationsForReserver(reserverID);
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationList.GetAllReservations();
        }

        public void MakeReservation(Reservation reservation)
        {
            _reservationList.AddReservation(reservation);
        }

        public void CancelReservation(Reservation reservation)
        {
            _reservationList.RemoveReservation(reservation);
        }
        #endregion
    }
}

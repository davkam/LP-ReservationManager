using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManager.Models
{
    /// <summary>
    /// Reservation class for object reservation.
    /// </summary>
    public class Reservation
    {
        #region Properties
        public Reservable Reservable { get; }
        public string ReserverName { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Duration => EndTime.Subtract(StartTime);
        #endregion

        #region Constructor
        public Reservation(Reservable reservable, string reserverName, DateTime startTime, DateTime endTime)
        {
            Reservable = reservable;
            ReserverName = reserverName;
            StartTime = startTime;
            EndTime = endTime;
        }
        #endregion

        #region Methods
        public bool Conflicts(Reservation reservation)
        {
            if (reservation.Reservable != Reservable)
            {
                return false;
            }

            return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
        }
        #endregion
    }
}

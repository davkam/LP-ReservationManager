using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManager.Models
{
    /// <summary>
    /// Reservable class for object reservable.
    /// </summary>
    public class Reservable
    {
        #region Properties
        public string Name { get; }
        public string Description { get; }
        #endregion

        #region Constructor
        public Reservable(string name, string description)
        {
            Name = name;
            Description = description;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name} {Description}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Reservable reservable && 
                Name == reservable.Name &&
                Description == reservable.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description);
        }

        public static bool operator ==(Reservable reservable1, Reservable reservable2)
        {
            if (reservable1 is null & reservable2 is null)
            {
                return true;
            }

            return !(reservable1 is null) && reservable1.Equals(reservable2);
        }

        public static bool operator !=(Reservable reservable1, Reservable reservable2)
        {
            return !(reservable1 == reservable2);
        }
        #endregion
    }
}

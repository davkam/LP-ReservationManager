using ReservationManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReservationManager.ViewModels
{
    public class ReservationListingViewModel :ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(new ReservationViewModel(
                new Reservation(
                    new Reservable("ROOM", "ROOM WITH BED"),
                    "DAVID", DateTime.Now, DateTime.Now.AddDays(1))
                        ));
            _reservations.Add(new ReservationViewModel(
                new Reservation(
                    new Reservable("BALL", "FOOTBALL"),
                    "SIMON", DateTime.Now.AddDays(13), DateTime.Now.AddDays(16))
                        ));
            _reservations.Add(new ReservationViewModel(
                new Reservation(
                    new Reservable("CELLO", "MUSICAL INSTRUMENT"),
                    "PETER", DateTime.Now.AddDays(3), DateTime.Now.AddDays(8))
                        ));
        }
    }
}

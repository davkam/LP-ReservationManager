using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace ReservationManager.ViewModels
{
    public class MakeReservationViewModel :ViewModelBase
    {
        private string? _reserverName;
        public string? ReserverName 
        {
            get => _reserverName; 
            set
            {
                _reserverName = value;
                OnPropertyChanged(nameof(ReserverName));
            } 
        }

        private string? _reservableName;
        public string? ReservableName
        {
            get => _reservableName;
            set
            {
                _reservableName = value;
                OnPropertyChanged(nameof(ReservableName));
            }
        }

        private string? _reservableDescription;
        public string? ReservableDescription
        {
            get => _reservableDescription;
            set
            {
                _reservableDescription = value;
                OnPropertyChanged(nameof(ReservableDescription));
            }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }
        private DateTime _endDate;
        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        public ICommand SubmitReservationCommand { get; }
        public ICommand CancelReservationCommand { get; }

        public MakeReservationViewModel()
        {
            // SubmitReservationCommand = new SubmitReservationCommand();
            // CancelReservationCommand = new CancelReservationCommand();
        }
    }
}

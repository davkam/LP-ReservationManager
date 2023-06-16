using ReservationManager.Exceptions;
using ReservationManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ReservationManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    Reserver reserver = new Reserver("David Kamran");

        //    try
        //    {
        //        reserver.MakeReservation(new Reservation(
        //            new Reservable("Book", "Book for reading"),
        //            "1647",
        //            new DateTime(2023, 6, 15),
        //            new DateTime(2023, 6, 16)
        //            ));

        //        reserver.MakeReservation(new Reservation(
        //            new Reservable("Bike", "Bike for riding"),
        //            "1647",
        //            new DateTime(2023, 6, 17),
        //            new DateTime(2023, 6, 19)
        //            ));

        //        reserver.MakeReservation(new Reservation(
        //            new Reservable("Book", "Book for reading"),
        //            "1647",
        //            new DateTime(2023, 6, 15),
        //            new DateTime(2023, 6, 16)
        //            ));
        //    }
        //    catch (ReservationConflictException exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }

        //    IEnumerable<Reservation> reservations = reserver.GetReservationsForReserver("1647");

        //    base.OnStartup(e);
        //}
    }
}

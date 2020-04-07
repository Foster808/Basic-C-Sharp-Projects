using Car_Insurance.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Insurance.Controllers
{
    public class HomeController : Controller
    {
        //public string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=C:\USERS\LAFOS\SOURCE\REPOS\CARINSURANCE\CARINSURANCE\APP_DATA\INSURANCE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress,
                            string dateOfBirth, string carYear, string carMake, string carModel, 
                            string DUI, string speedingTickets, string coverageType)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                

                string queryString = @"INSERT INTO Quote (FirstName, LastName, EmailAddress, DateOfBirth, CarYear
                                        CarMake, CarModel, DUI, SpeedingTickets, CoverageType)
                                        VALUES (@FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear,
                                        @CarMake @CarModel, @DUI, @SpeedingTickets, @CoverageType)";

                using (SqlConnection connection = new SqlConnection())
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@DateOfBirth", SqlDbType.VarChar);
                    command.Parameters.Add("@CarYear", SqlDbType.VarChar);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@DUI", SqlDbType.VarChar);
                    command.Parameters.Add("@SpeedingTickets", SqlDbType.VarChar);
                    command.Parameters.Add("@CoverageType", SqlDbType.VarChar);

                    //put in actual quote number here
                    //int total = 50;
                    //int newNumber;
                    //for i in range(5):
                    //    newNumber = (dateOfBirth) < 25 + (25);
                    //    newNumber = (dateOfBirth) < 18 + (100);
                    //    newNumber = int(InputType(dateOfBirth)) > 100 + (25);
                    //    total += newNumber

                        




                        //Console.WriteLine("Your Quote is: ", total);


                }
                return View("Success");

                
            }
        }
        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear,
                                 CarMake, CarModel, DUI, SpeedingTickets, CoverageType, Insurance from Quotes";
            List<Insuree> quotes = new List<Insuree>();

            using (InsuranceEntities connection = new InsuranceEntities())
            {
                //SqlCommand command = new SqlCommand(queryString, connection);

                //connection.Open();

                //SqlDataReader reader = command.ExecuteReader();

                
                    var quote = new Insuree();
                    quote.Id = Convert.ToInt32("Id");
                    quote.FirstName = "FirstName".ToString();
                    quote.LastName = "LastName".ToString();
                    quote.EmailAddress = "EmailAddress".ToString();
                    quote.DateOfBirth = DateTime.Parse("DateOfBirth".ToString());
                    quote.CarYear = Convert.ToInt32("CarYear");
                    quote.CarMake = "CarMake".ToString();
                    quote.CarModel = "CarModel".ToString();
                    quote.DUI = Convert.ToBoolean("DUI");
                    quote.SpeedingTickets = Convert.ToInt32("SpeedingTickets");
                    quote.CoverageType = Convert.ToBoolean("CoverageType");
                    quote.Quote = Convert.ToDecimal("Insurance");
                    quotes.Add(quote);
                
            }
            return View(quotes);
        }
    }
}
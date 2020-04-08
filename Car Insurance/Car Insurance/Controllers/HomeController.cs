using Car_Insurance.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Xml.Schema;

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
                            string DUI, string speedingTickets, string coverageType, string quote)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                int total = 50;
                int birthdate = Convert.ToInt32(dateOfBirth);
                int currentAge = DateTime.Now.Year - birthdate;
                
                

                if (currentAge > 1995)  
                {
                    total= + 25;
                }
                if (currentAge >= 2002)
                {
                    total= + 100;
                }
                if (currentAge > 1920) //for 100 or older
                {
                    total= + 25;
                }

                int vehicleYear = Convert.ToInt32(carYear);
                
                if (vehicleYear < 2000)
                {
                    total= + 25;
                }
                else
                {
                    total= + 0;
                }
                
                if (vehicleYear > 2015)
                {
                    total= + 25;
                }
                
                if (carMake == "Porsche")
                {
                    total= + 25;
                }

                if (carMake == "Carrera")
                {
                    total= + 25;
                }

                int ticket = Convert.ToInt32(speedingTickets);
                if (ticket >= 1)
                {
                    total = + 25;
                }

                bool drinker = Convert.ToBoolean(DUI);
                if (drinker == true)
                {
                    total = total + Convert.ToInt32(.25m);
                }

                bool type = Convert.ToBoolean(coverageType);
                if (type == true)
                {
                    total = total  + Convert.ToInt32(.50m);
                }



                Console.WriteLine("Your Quote is: {0} ", total );

                //If you're trying to calculate the quote price from the Insuree's info, an easy way to do
                //    that would be to make a series of "if-else" statements inside the "Add" function, before
                //    it saves the Insuree object to the database. They would check to see if the variables of 
                //    the Insuree object meet certain conditions, and adjust the price accordingly. You can 
                //    modify the "quote" property of the Insuree object so that afterwards, when it adds the 
                //    Insuree to the database, it also saves the quote price of that insuree into the database 
                //    as well.

                //Use line 21 info as variables and put quote logic into here

                //put in actual quote number here

                //int total = 50;
                //int newNumber;
                //for i in range(5):
                //    newNumber = (dateOfBirth) < 25 + (25);
                //    newNumber = (dateOfBirth) < 18 + (100);
                //    newNumber = int(InputType(dateOfBirth)) > 100 + (25);
                //total += newNumber











                string queryString = @"INSERT INTO Quote (FirstName, LastName, EmailAddress, DateOfBirth, CarYear
                                        CarMake, CarModel, DUI, SpeedingTickets, CoverageType, Quote)
                                        VALUES (@FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear,
                                        @CarMake @CarModel, @DUI, @SpeedingTickets, @CoverageType, @Quote)";

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
                    command.Parameters.Add("@Quote", SqlDbType.VarChar);
                }
                return View("Success");

                
            }
        }
        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear,
                                 CarMake, CarModel, DUI, SpeedingTickets, CoverageType, Quote, Insurance from Quotes";
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
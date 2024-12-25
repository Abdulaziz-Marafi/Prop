using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropTask.Models
{
    internal class User
    {
        string userName; [Required]
        int salary; 

        public string UserName {
            get { return userName; }
            set {
                do
                {
                    if ((String.IsNullOrEmpty(value)))
                    {
                        Console.WriteLine("Please enter a valid username: ");
                        value = Console.ReadLine().Trim();
                    }

                } while ((String.IsNullOrEmpty(value)));
            } 
        }
        public int Salary 
        { 
            get { return salary; } 
            set
            {
                //bool checkSal = !(value >= 350 && value <= 900);
                do
                {
                    if (!(value >= 350 && value <= 900))
                    {
                        Console.WriteLine("Please enter a salary within the correct range: ");
                        value = Convert.ToInt32(Console.ReadLine().Trim());
                        //checkSal = false;
                    }


                } while (!(value >= 350 && value <= 900));
            } 
        }


    }
}

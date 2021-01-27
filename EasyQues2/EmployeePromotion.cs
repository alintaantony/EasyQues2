using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQues2
{
    class EmployeePromotion
    {
        List<string> employeeNames = new List<string>();
        string input = "NotEmpty";
        string empoloyeeNameToChekPromotionPosition;
        int promotionPosition;

        public void AddEmployeesAccordingToPromotioneligibility()
        {
            try
            {
                Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
                while (input != String.Empty && input != " ")
                {
                    input = Console.ReadLine();
                    employeeNames.Add(input);
                }
                Console.WriteLine("The employees accoridng to their eligibility for promotion are :");
                foreach (var names in employeeNames)
                {
                    Console.WriteLine(names);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry !! There was an error !! Please Try Again !!");
                Console.WriteLine(e);
                AddEmployeesAccordingToPromotioneligibility();
            }
        }
        public void PromotionPostion()
        {
            try
            {
                Console.WriteLine("Please enter the name of the employee to check promotion position");
                empoloyeeNameToChekPromotionPosition = Console.ReadLine();
                if (employeeNames.Contains(empoloyeeNameToChekPromotionPosition))
                {
                    promotionPosition = employeeNames.IndexOf(empoloyeeNameToChekPromotionPosition) + 1;
                    Console.WriteLine($"'{empoloyeeNameToChekPromotionPosition}' is in position {promotionPosition} for promotion.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid name");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry !! There was an error !! Please Try Again !!");
                Console.WriteLine(e);
                PromotionPostion();
            }

        }
    }
}

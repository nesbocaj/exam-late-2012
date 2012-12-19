using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_end
{
    class Employee : IModel
    {
        public int Id;
        public int person_Id;
        public int positions_Id;
        public int salary_rate;
        public int working_hours;
        public string accessword;

        public Employee(int ID, int person_ID, int positions_ID, int salary_Rate, int working_Hours, string accesWord)
        {
            Id = ID;
            person_Id = person_ID;
            salary_rate = salary_Rate;
            working_hours = working_Hours;
            accessword = accesWord;
        }

        public int GetEmployeeId(int Id)
        {
            return Id;
        }

        public int GetEmployeePerson_Id(int person_Id)
        {
            return person_Id;
        }

        public int GetEmployeePositions_Id(int positions_Id)
        {
            return positions_Id;
        }

        public int GetEmployeeSalary_rate(int salary_rate)
        {
            return salary_rate;
        }

        public int GetEmployeeWorking_Hours(int working_hours)
        {
            return working_hours;
        }

        public string GetEmployeeaccessWord(string accessword)
        {
            return accessword;
        }   
    }
}
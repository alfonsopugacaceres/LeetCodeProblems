using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.Problems.EmployeeImportance
{
    public class EmployeeImportance
    {
        public class Employee
        {
            public int id;
            public int importance;
            public IList<int> subordinates;
        }


        public int GetImportance(IList<Employee> employees, int id)
        {
            if(employees.Count > 2000)
            {
                return -1;
            }
            else
            {
                //flatten the list search to a dictionary using linq
                IDictionary<int, Employee> employeeDict = employees.ToDictionary(employee => employee.id, employee => employee);
                //create a storage variable for the sum
                int importanceSum = 0;
                //use a recursive function to traverse the children of the parent and the childrens children
                RecursiveTraversal(id, employeeDict, ref importanceSum);
                return importanceSum;
            }
        }

        /// <summary>
        /// this is a depth first sum approach
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dict"></param>
        /// <param name="currentSum"></param>
        public void RecursiveTraversal(int id, IDictionary<int, Employee> dict, ref int currentSum)
        {
            //add the current parent to the sum by reference so we don't lose the sum
            currentSum += dict[id].importance;
            //for each children launch another recursive call and add the importance to the sum by reference
            //this will allow us to keep the running tally accurate
            foreach (int empid in dict[id].subordinates)
                RecursiveTraversal(empid, dict, ref currentSum);
        }
    }
}

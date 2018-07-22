using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lambdaexample;

namespace linqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> emp = new List<employee>
            {
                new employee
                {empid=100, Name="martin", Dept="IT", Salary=35000 },

                new employee
                {empid=200,Name="clark",Dept="accounts",Salary=1000 },

                new employee
                {
                    empid=300,Name="MAK",Dept="COMMERCE",Salary=1500
                },


                new employee {empid=400,Name="HR",Dept="SCIENCE",Salary=1400 }

            };
            //select all data

            var data=from t in emp
            select t;

            foreach (var d in data)
                Console.WriteLine(d.empid + " " + d.Name + " " + d.Dept + " " + d.Salary);
            Console.WriteLine("********");

            //select data based on id

            var data1 = (from t in emp
                        where t.empid == 100
                        select t).SingleOrDefault();
            if (data1 == null)
                Console.WriteLine("invalid address");
            else
                Console.WriteLine(data1.empid + " " + data1.Name + " " + data1.Dept + " " + data1.Salary);
            Console.WriteLine("********");

            //select data based on multiple conditions
            var data2 = from t in emp
                        where t.Dept == "IT" && t.Salary > 5000
                        select t;
            foreach(var d in data2)
                Console.WriteLine(d.empid + " " + d.Name + " " + d.Dept + " " + d.Salary);
            Console.WriteLine("********");

            //sort either in asc or desc and select only name

            var data3 = from t in emp
                        orderby t.Name ascending
                        select t.Name;

            foreach (var d in data3)
                Console.WriteLine(d);
            Console.WriteLine("***********");

            //print multiple data using anonymous types
            var data4 = from t in emp
                        select new { empname = t.Name, empsalary = t.Salary };

            foreach (var d in data4)
                Console.WriteLine(d.empname + " " +d.empsalary);
            Console.WriteLine("***********");

            // working of group b y in linkrd list
            // if we make use of extended function like sum, max, min etc make use of lambda method
            var data5 = from t in emp
                        group t by t.Dept into grp
                        select new { Deptname = grp.Key, EmpCount = grp.Count(), sumSalary = grp.Sum(x => x.Salary) };
            foreach (var d in data5)
                Console.WriteLine(d.Deptname + " " + d.EmpCount + " " + d.sumSalary);

            Console.WriteLine("***********");

            // select employee getting max or min salary

            var data6 = from t in emp
                        where t.Salary == emp.Max(x => x.Salary)
                        select t;

            foreach (var d in data6)
                Console.WriteLine(d.empid + " " + d.Name + " " + d.Dept + " " + d.Salary);


        }
    }
}

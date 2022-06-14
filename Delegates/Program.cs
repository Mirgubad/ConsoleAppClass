using System;
using System.Collections.Generic;
using static System.Console;

namespace Delegates
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> std = new();
            List<Employee> emp = new();
        first:
            Human human = new();
            WriteLine("1.Sagird Elave edin:2.Employee elave edin:3.Axtaris edin:4.Exit");
            string ask = ReadLine();
            switch (ask)
            {
                case "1":
                    Student st = new Student();

                    WriteLine("Sagirdin adini daxil edin");
                    human.Name = ReadLine();
                    st.Name = human.Name;
                    if (string.IsNullOrWhiteSpace(human.Name))
                    {
                        WriteLine("Adi yeniden daxil edin");
                        goto case "1";

                    }
                    WriteLine("Soyadini Daxil edin");
                    st.SurName = ReadLine();
                    WriteLine("Yash daxil edin");
                    st.Age = int.Parse(ReadLine());
                grade:
                    try
                    {
                        WriteLine("Grade daxil edin");
                        st.Grade = int.Parse(ReadLine());
                        std.Add(st);

                        if (st.Grade == null)
                        {
                            WriteLine("Grade daxil edin");
                        }
                        WriteLine($"{human.Name} ugurla elave edildi...");
                    }
                    catch (Exception)
                    {
                        WriteLine("Student elave edilmedi");
                        goto grade;
                    }
                    break;
                case "2":
                    Employee employee = new();

                    WriteLine("Position qeyd edin");
                    employee.Position = ReadLine();
                    if (string.IsNullOrWhiteSpace(employee.Position))
                    {
                        WriteLine("Employye position qeyd edilmeyib");
                        return;
                    }
                    else
                    {
                        WriteLine("Employee adini daxil edin");
                        employee.Name = ReadLine();
                        WriteLine("Soyadini Daxil edin");
                        employee.SurName = ReadLine();
                        WriteLine("Yash daxil edin");
                        employee.Age = int.Parse(ReadLine());
                        WriteLine($"{employee.Name} ugurla elave edildi...");
                        emp.Add(employee);

                    }
                    break;
                case "3":
                    WriteLine("1.Employe uzre axtaris:2.Student uzre axtaris");
                    string askcase = ReadLine();
                    switch (askcase)
                    {
                        case "1":
                            WriteLine("Position Daxil edin");
                            string pos = ReadLine();
                            foreach (var item in emp)
                            {
                                if (item.Position.ToLower().ToUpper() == pos.ToLower().ToUpper())
                                {
                                    WriteLine($"{item.Name} bu sirketde {item.Position} olaraq isleyir :");
                                }
                                else
                                {
                                    WriteLine("Axtardiginiz positionda isci yoxdur");
                                }
                            }
                            if (emp.Count == 0)
                            {
                                WriteLine("Isci siyahisi bosdur");
                            }
                            break;
                        case "2":
                            WriteLine("Minimum Grade daxil edin");
                            string mingr = ReadLine();
                            int mngr = int.Parse(mingr);
                            WriteLine("Maximum Grade daxil edin");
                            string maxgr = ReadLine();
                            int mxgr = int.Parse(maxgr);
                            foreach (var item in std)
                            {

                                if (item.Grade < mxgr && item.Grade > mngr)
                                {

                                    WriteLine($"{item.Name}'s grade  is { item.Grade} ");

                                }
                                else
                                {
                                    WriteLine("Bu araliqdaki gradde telebe yoxdur");
                                    goto case "2";
                                }
                            }
                            if (std.Count == 0)
                            { WriteLine("Grade Siyahisi bosdur"); }

                            break;
                    }
                    break;
                case "4":

                    return;
            }
            goto first;
        }
    }
}

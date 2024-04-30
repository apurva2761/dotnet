namespace _21Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string c;
            Emp[] emps = new Emp[2];
            for (int i = 0; i < emps.Length; i++)
            {
                Emp emp = new Emp();
                Console.WriteLine("Enter Id :");
                emp.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name :");
                emp.Name  = Console.ReadLine();
                Console.WriteLine("Enter Address :");
                emp.Address =  Console.ReadLine();
                emps[i] = emp;
            }
            Console.WriteLine("you can perform folowing opertaions");
            Console.WriteLine("1.search employee 2.update record");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
                {
                    Console.WriteLine("Enter ID whose details you want: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Emp fid = null;
                        bool isFound = false;
                    foreach (Emp emp in emps)
                    {
                        if (emp.Id == id)
                        {
                            fid = emp;
                            isFound = true;
                            break;
                        }
                    }
                    if(isFound)
                    {
                        Console.WriteLine(fid.GetEmpDetails());
                    }
                    else
                    {
                        Console.WriteLine("---------ID NOT FOUND-----------");
                        
                    }
                    //break;
                }

              else if (choice == 2)
              {
                    Console.WriteLine("Enter ID whose record you want to update");
                    int uid = Convert.ToInt32(Console.ReadLine());
                    foreach (Emp emp in emps)
                    {
                        if (emp.Id == uid)
                        {
                            Console.WriteLine("update name of {0} as :", uid);
                            string N_name = Console.ReadLine();
                            emp.Name  =  N_name;
                            Console.WriteLine("update Address of {0} as:", uid);
                            string N_address = Console.ReadLine();
                            emp.Address = N_address;
                            Console.WriteLine("updated Details of {0}", uid);
                            Console.WriteLine(emp.GetEmpDetails());
                            
                        }
                        else
                        {
                            Console.WriteLine("Enter valid choice");
                        }

                    
                    }
              }
              else
              {
                    Console.WriteLine("Request denied!!!!1");
                    
              }
            
          
            Console.ReadLine();
        }
    }
    public class Emp
    {
        private int _EId;
        private string _EName;
        private string _EAddress;

        public string Address
        {
            get { return  _EAddress; }
            set { _EAddress = value; }
        }


        public string Name
        {
            get { return _EName; }
            set { _EName = value; }
        }


        public int Id
        {
            get { return _EId; }
            set { _EId = value; }
        }

        public string GetEmpDetails()
        {
            return string.Format("Id ={0}, Name ={1}, Address ={2}", _EId, _EName, _EAddress);
        }

    }
}

namespace Assignment_Logger_files
{
    internal class Ass3
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\IET\Desktop\.net lab\demo.txt";
            Logger logger = Logger.GetLogger(filepath);
            Employee employee = new Employee();
            Console.WriteLine("Enter ID :");
            employee.Eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name ");
            employee.Ename = Console.ReadLine();
            logger.Log(employee.GetDetails());

            Console.WriteLine("Done");


        }
        public class Employee
        {
            private int _Eid;
            private string _Ename;

            public string Ename
            {
                get { return _Ename; }
                set { _Ename = value; }
            }


            public int Eid
            {
                get { return _Eid; }
                set { _Eid = value; }
            }
            public string GetDetails()
            {
                string str = "EId:" + Eid + ",    Ename:" + Ename;
                return str;
            }

        }
        public class Logger
        {
            private static Logger logger;
            private StreamWriter filewriter;
            private Logger(string filepath)
            {
                Console.WriteLine("Logger objct created for first time");
                if (!File.Exists(filepath))
                {
                    filewriter = new StreamWriter(filepath);
                }
                else
                {
                    filewriter = File.AppendText(filepath);

                }

            }
            public static Logger GetLogger(string filepath)
            {
                if (logger == null)
                {
                    logger = new Logger(filepath);

                }
                return logger;
            }
            public void Log(string msg)
            {
                Console.WriteLine("--- Logged msg {0} at {1}", msg, DateTime.Now.ToString());
                filewriter.WriteLine("--- Logged msg {0} at {1}", msg, DateTime.Now.ToString());
                filewriter.AutoFlush = true;

            }

        }
    }
}

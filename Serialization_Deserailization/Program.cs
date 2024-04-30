using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserailization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\IET\Desktop\.net lab\MyData3.txt";
            FileStream fs = null;
          /* if(File.Exists(filepath)) 
            { 
                fs= new FileStream(filepath, FileMode.OpenOrCreate,FileAccess.Write);
            }
            else
            {
                fs= new FileStream(filepath,FileMode.Append,FileAccess.Write);
            }
           */
          //  Student s = new Student();//obj1
           // Student s1 = new Student();//obj2
            //first object details
          /*  Console.WriteLine("enter roll number");
            s.Rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  name");
            s.Name= Console.ReadLine();

           //second object details 
            Console.WriteLine("enter roll number");
            s1.Rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  name");
            s1.Name = Console.ReadLine();
          

            //serialization
            BinaryFormatter bf = new BinaryFormatter();
           bf.Serialize(fs,s);
            bf.Serialize(fs,s1);
            fs.Close();
            Console.WriteLine("Done");
            Console.ReadLine();
          */
          if(File.Exists (filepath))
            {
                fs= new FileStream(filepath,FileMode.Open,FileAccess.Read);
            }

          BinaryFormatter bf = new BinaryFormatter();   
            Student studentobj = bf.Deserialize(fs) as Student;
            Console.WriteLine(studentobj.GetDetails());
            Student studentobj1 = bf.Deserialize(fs) as Student;
            Console.WriteLine(studentobj1.GetDetails());

            Console.WriteLine("Done");
            Console.ReadLine();

        }
    }
    [Serializable]
    public class Student
    {
        private int _Roll_No;
        private String _Name;

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public int Rollno
        {
            get { return _Roll_No; }
            set { _Roll_No = value; }
        }
        public string GetDetails()
        {
            string str = "ROll no:" + Rollno + "Name:" + Name;
            return str;
        }

    }


}

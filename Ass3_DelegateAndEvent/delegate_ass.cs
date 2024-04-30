namespace ConsoleApp3
{
    public delegate void MyDelegate();
    internal class Ass4
    {
        static void Main(string[] args)
        {
            PDF p = new PDF();
            MyDelegate mdl1 = new MyDelegate(p.parse);
            MyDelegate mdl2 = new MyDelegate(p.Validate);
            MyDelegate mdl3 = new MyDelegate(p.ReValidate);
            MyDelegate mdl4 = new MyDelegate(p.Save);
            Console.WriteLine("Do you want to revalidate y/n");
            string ch = Console.ReadLine();
            p.e1 += mdl1;
            p.e1 += mdl2;
            if (ch == "y")
            {
                p.e1 += mdl3;
            }
            p.e1 += mdl4;
            p.call();



        }

        public class PDF
        {
            public event MyDelegate e1;



            public void parse()
            {
                Console.WriteLine("PDF parsed");
            }
            public void Validate()
            {
                Console.WriteLine("PDF validated");
            }
            public void ReValidate()
            {
                Console.WriteLine("PDF Revalidated");
            }
            public void Save()
            {
                Console.WriteLine("PDF saved");
            }
            public void call()
            {
                e1();
            }
        }
    }
}

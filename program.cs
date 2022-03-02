using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise1;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization; // for serialization.
using System.Runtime.Serialization.Formatters.Binary;  // binary serialization.
using System.Reflection;

namespace exercise2
{
    internal class program
    {
        //delegate declaratiom
        public delegate int DelDoit(int no, int no1);
        static int Addnumbers(int no, int no1)
        {
            return no + no1;
        }
        static int Productnumbers(int no, int no1)
        {
            return no * no1;
        }
        static int Diffnumbers(int no, int no1)
        {
            return (no - no1);
        }
        static   string Getmessage()
        {
            return "Hello All";
        }
        static bool CheckforEven(int no)
        {
            bool bl=false;
            if(no%2==0)
            {
                bl = true;
            }
            return bl;
        }


        static void Main(string[] args)
        {

            
                


            //task2dictionary();












            //task1jsonserialize();


            //task1jsondeserialize();






















            // ISerializible();


            /* Cat mycat;
               Stream strm;
               BinaryFormatter bfrm;
               serializeBinaryformatxml(out mycat, out strm, out bfrm); 

               deseriazablebinaryformatxml(out mycat, out strm, out bfrm);*/















            // jsonserializationdemo();
            //jsondeserializationdemo();
            //streamwriterdemo();
            // Directorymethod();
            //file_binaryreader();
            //Streamwriter();
            //streamReader();

            //predicatedelegate();



            //actiondelegate();
            //Funcdelegate();
            //delegatedemo();
            //sortingcollection();
            // collectioninitialer();
            //IEnumerableoncollection();
            //stack();
            // queuemethod();
            //dictionary2();
            //dictionarycollection();
            //collection();
            //exception();














            //genericdemo();



            //properties_interface();
            // multipleinheritanceinterface();
            //sealedclass();
            //task();




            //abstractmethod();
            // anonymustypes();




            //methodoverandhiding();



            //multipleinheritance();

            //operatoroverloading();




            /*Customer customer = new Customer(122, "shashank", "shashank.32@mail.com",
                    "9640022022");
                   Console.WriteLine("{0} {1} {2} {3}", customer.Customerid,
                    customer.Name, customer.Email, customer.Phone);*/
        }

        private static void task2dictionary()
        {
            Dictionary<int, Scooter> scooters = new Dictionary<int, Scooter>();

            scooters.Add(1, new Scooter { Regno = "12355B", Model = "Apache", Type = "150cc", Price = 120000 });
            scooters.Add(2, new Scooter { Regno = "123wr5B", Model = "yahamaR15", Type = "150cc", Price = 160000 });
            scooters.Add(3, new Scooter { Regno = "1ewefB", Model = "Xpulse", Type = "200cc", Price = 220000 });
            scooters.Add(4, new Scooter { Regno = "12fewB", Model = "Impulse", Type = "220cc", Price = 200000 });
            scooters.Add(5, new Scooter { Regno = "12wqrB", Model = "Duke", Type = "250cc", Price = 820000 });
            scooters.Add(6, new Scooter { Regno = "14rfB", Model = "Benneli", Type = "600cc", Price = 720000 });
            scooters.Add(7, new Scooter { Regno = "12ferB", Model = "Tigerstreet", Type = "1000cc", Price = 920000 });
            scooters.Add(8, new Scooter { Regno = "1277h", Model = "unicorn", Type = "160cc", Price = 100000 });
            scooters.Add(9, new Scooter { Regno = "14hgt55B", Model = "fatboy", Type = "1000cc", Price = 180000 });
            scooters.Add(10, new Scooter { Regno = "45ytg5B", Model = "ducatti", Type = "1500cc", Price = 160000 });
            scooters[2].Model = "royalenfield";
            foreach (var sct in scooters.Values)
            {
                Console.WriteLine("{0} {1} {2} {3}", sct.Regno, sct.Model, sct.Type, sct.Price);
            }
        }

        private static void task1jsondeserialize()
        {
            string fileName = "Employeee.json";
            string jsonString = File.ReadAllText(fileName);
            List<Employeee> employee = new List<Employeee>
            {
                new Employeee{EmpId=1,Name="ram",DateofJoin=15-08-2022,Department="Testing",Salary=30000},
                new Employeee{EmpId=2,Name="rohith",DateofJoin=23-08-2022,Department="Developer",Salary=450000},
                new Employeee{EmpId=3,Name="rakesh",DateofJoin=23-07-2022,Department="Analyst",Salary=350000},
                new Employeee{EmpId=4,Name="ronith",DateofJoin=13-04-2022,Department="Graphics",Salary=550000},
                new Employeee{EmpId=5,Name="rahul",DateofJoin=8-08-2022,Department="Reasearch",Salary=650000},

            };
            employee = JsonSerializer.Deserialize<List<Employeee>>(jsonString);
            {
                foreach (Employeee emp in employee)
                {
                    Console.WriteLine("{0} \n{1} \n{2} \n{3} \n{4}", emp.EmpId, emp.Name, emp.DateofJoin, emp.Department, emp.Salary);

                }

            }
        }

        private static void task1jsonserialize()
        {
            List<Employeee> employee = new List<Employeee>
            {
                new Employeee{EmpId=1,Name="ram",DateofJoin=15-08-2022,Department="Testing",Salary=30000},
                new Employeee{EmpId=2,Name="rohith",DateofJoin=23-08-2022,Department="Developer",Salary=450000},
                new Employeee{EmpId=3,Name="rakesh",DateofJoin=23-07-2022,Department="Analyst",Salary=350000},
                new Employeee{EmpId=4,Name="ronith",DateofJoin=13-04-2022,Department="Graphics",Salary=550000},
                new Employeee{EmpId=5,Name="rahul",DateofJoin=8-08-2022,Department="Reasearch",Salary=650000},

            };
            string jsonString = JsonSerializer.Serialize(employee);
            string fileName = "Employeee.json";
            Console.WriteLine(jsonString);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));
        }

        private static void ISerializible()
        {
            string fileName = "dataStuff.txt";

            IFormatter formatter = new BinaryFormatter();
            SerializeItem(fileName, formatter);



            deserializeItem(fileName, formatter);
            Console.WriteLine("done");
        }

        private static void deserializeItem(string fileName, IFormatter formatter)
        {
            SerializeItem(fileName, formatter);
            MyItemType t = new MyItemType();
            t.Myvalue = "Hello everyone";
            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }

        private static void SerializeItem(string fileName, IFormatter formatter)
        {
            MyItemType t = new MyItemType();
            t.Myvalue = "Hello ! this is Serialization program";

            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }

        private static void deseriazablebinaryformatxml(out Cat mycat, out Stream strm, out BinaryFormatter bfrm)
        {
            //open the file and deserialize it.
            strm = File.Open("data.xml", FileMode.Open);
            bfrm = new BinaryFormatter();
            // typecasting to cat from object type
            mycat = (Cat)bfrm.Deserialize(strm);
            strm.Close();
            Console.WriteLine("After Deserialization");
            mycat.Showcat();
        }

        private static void serializeBinaryformatxml(out Cat mycat, out Stream strm, out BinaryFormatter bfrm)
        {
            mycat = new Cat();
            mycat.Name = "hikkey";
            mycat.Description = "Italian";
            mycat.Age = 3;
            // before serialization
            mycat.Showcat();
            strm = File.Open("data.xml", FileMode.Create);
            bfrm = new BinaryFormatter();
            bfrm.Serialize(strm, mycat);
            strm.Close();
            //empty the mycat object
            mycat = null;
        }

        private static void jsondeserializationdemo()
        {
            string fileName = "WeatherForecast.json";
            string jsonString = File.ReadAllText(fileName); ;
            // WeatherForecast wetherForecast=jsonSerializer.Deserialize<WeatherForecast>
            WeatherForecast weatherforecast = new WeatherForecast();
            weatherforecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
            Console.WriteLine($"Date :{weatherforecast.Date}");
            Console.WriteLine($"Temperature :{weatherforecast.TemperatureCelcius}");
            Console.WriteLine($"Summary:{weatherforecast.Summary}");
        }

        private static void jsonserializationdemo()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2022-02-24"),
                TemperatureCelcius = 33,
                Summary = "Hot"
            };
            string jsonString = JsonSerializer.Serialize(weatherForecast);
            string fileName = "WeatherForecast.json";
            Console.WriteLine(jsonString);
            // saves the data into the file as jason.
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));
        }

        private static void streamwriterdemo()
        {
            try
            {
                using (StreamWriter swr = new StreamWriter("hello.txt"))
                {
                    Console.WriteLine("enter any long string");
                    string data = Console.ReadLine();
                    swr.WriteLine(data);

                }
                Console.WriteLine("data saved");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static void file_binaryreader()
        {
            String fileName = "hello.txt";
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        Console.WriteLine(reader.ReadSingle());
                        Console.WriteLine(reader.ReadString());
                        Console.WriteLine(reader.ReadInt32());
                        Console.WriteLine(reader.ReadBoolean());
                    }

                }
            }
        }

        private static void Directorymethod()
        {
            string sourcedirctory = @"E:\Current";
            string destdirctory = @"E:\Archieve";
            try
            {
                var txtFiles = Directory.EnumerateFiles(sourcedirctory, "*.txt");
                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourcedirctory.Length + 1);
                    Directory.Move(currentFile, Path.Combine(destdirctory, fileName));


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

         private static void Streamwriter()
         {
             DirectoryInfo[] dirinfo = new DirectoryInfo(@"C:\").GetDirectories();
             using (StreamWriter sw = new StreamWriter("CDriceDirs.txt"))
             {
                 foreach (DirectoryInfo dir in dirinfo)
                 {
                     sw.WriteLine(dir.Name);
                 }

             }
            Console.WriteLine("File saved");
           /* Console.WriteLine("File saved");
            StreamReader srd = new StreamReader("CDriceDirs.txt");
            string line;
            while ((line = srd.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
           */


        }

       /* private static void streamReader()
         {
            string path = @"example1.txt";
            string line;
            StreamReader sr = new StreamReader(path);
            try
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
                sr.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       */
         

        private static void predicatedelegate()
        {
            Predicate<int> evencheck = CheckforEven;
            bool res = evencheck(15);

            if (res)
            {
                Console.WriteLine("even no");
            }
            else
            {
                Console.WriteLine("odd no");
            }
        }

        private static void actiondelegate()
        {
            Action<string> action = (string msg) => Console.WriteLine("This is Action Delegate  " + msg);
            action("Great!");
            Action<int, int> divide = (int no, int no1) => Console.WriteLine("Division : {0} ", no / no1);
            divide(250, 50);
        }

        private static void Funcdelegate()
        {

            //expression or lambda expression =>
            Func<int, int, int> product = (no, no1) => no * no1;
            Func<int, int, int> sum = Addnumbers;
            Func<int, int> square = (no) => no * no;
            Func<string> Sendit = Getmessage;
            Func<int, double, double> doit = (no, no1) => no * (no - no1);



            Console.WriteLine("Product :{0} ", product(10, 40));
            Console.WriteLine("Sum ={0}", sum(10, 40));
            Console.WriteLine("Sqaure ={0}", square(11));
            Console.WriteLine("string : {0} ", Getmessage());
            Console.WriteLine("Double Func :{0} ", doit(12, 87.45));
        }

        private static void sortingcollection()
        {
            var cars = new List<Car>
    { 
                
        { new Car() {Name="kia",Color="blue",Speed = 30}},
        { new Car() {Name="hyundai",Color="green",Speed = 80}},
        { new Car() {Name="maruti",Color="blue",Speed = 70}},
        { new Car() {Name="skoda",Color="green",Speed = 50}},
        { new Car() {Name="volkswagon",Color="red",Speed = 20}},
        { new Car() {Name="renault",Color="red",Speed = 80}},
        { new Car() {Name="mahindra",Color="green",Speed = 40}}

    };


            

            cars.Sort();
            foreach (Car thisCar in cars)
            {
                Console.Write(thisCar.Color.PadRight(5) + " ");
                Console.Write(thisCar.Speed.ToString() + " ");
                Console.Write(thisCar.Name);
                Console.WriteLine();



            }
        }

        private static void IEnumerableoncollection()
        {
            FormattedAddress address = new FormattedAddress()
            {
               {"john","doe","123 street","topeko","KS","0000" },{
               "jane","smith","456 street","topeko","KS","0000"}
            };




            Console.WriteLine("Address Entries:");
            foreach (string addressEntry in address)
            {
                Console.WriteLine("\r\n" + addressEntry);
            }
        }

        private static void collectioninitialer()
        {
            List<string> list = new List<string> { "rahul", "ramesh", "rajesh", "rohith" };
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            List<Cat> cats = new List<Cat>
            {
                new Cat{Name ="kiran",Description="persian",Age=20},
                new Cat{Name ="mitesh",Description ="italian",Age=22},
                new Cat{Name ="mohith",Description="australian",Age=19}
            };
            Console.WriteLine();
            foreach (var cat in cats)
            {
                Console.WriteLine("{0} {1} {2}", cat.Name, cat.Description, cat.Age);
            }
        }

        private static void delegatedemo()
        {
            // instantiate delegate and assign method name to it.
            DelDoit ddoit = Addnumbers;


            int res = ddoit(485, 855);
            Console.WriteLine(res);
            //delegate multicasting.
            ddoit += Productnumbers;
            int pro = ddoit(10, 25);
            Console.WriteLine(pro);
            ddoit += Diffnumbers;
            int diff = ddoit(100, 25);
            Console.WriteLine(diff);

            ddoit -= Diffnumbers;
            Console.WriteLine(ddoit(35, 15));
        }

        private static void collection()
        {
            var Names = new List<string>();
            Names.Add("hiren");
            Names.Add("george");
            Names.Add("Kiran");

            foreach (var name in Names)
            {
                Console.WriteLine(name + "");
            }
        }

        private static void stack()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("pondicherry");
            stack.Push("bangalore");
            stack.Push("delhi");
            stack.Push("panjim");

            foreach (var ct in stack)
            {
                Console.WriteLine(ct);
            }
            stack.Pop();
            foreach (var ct in stack)
            {
                Console.WriteLine(ct);
            }
        }

        private static void queuemethod()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("rajesh");
            queue.Enqueue("raju");
            queue.Enqueue("dileep");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.Write(item);
            }
        }

        private static void dictionary2()
        {
            Dictionary<int, Customer> customerdictional = new Dictionary<int, Customer>();
            customerdictional.Add(1, new Customer { Name = "rakesh", Customerid = 56, Email = "rakesh332@mail.com", Phone = "9495562326" });
            customerdictional.Add(2, new Customer { Name = "rohit", Customerid = 48, Email = "rohith32@mail.com", Phone = "989985626" });
            customerdictional.Add(3, new Customer { Name = "ram", Customerid = 87, Email = "ram2@mail.com", Phone = "9705552326" });
            customerdictional[3].Name = "rajesh";
            foreach (var cst in customerdictional.Values)
            {
                Console.WriteLine("{0} {1} {2} {3}", cst.Customerid, cst.Name, cst.Email, cst.Phone);
            }


        }

        private static void dictionarycollection()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Hyderabad");
            keyValuePairs.Add(2, "Chennai");
            keyValuePairs.Add(3, "Pune");
            keyValuePairs.Add(4, "Kolkata");
            keyValuePairs.Add(5, "Delhi");
            foreach (var city in keyValuePairs)
            {
                Console.WriteLine("{0} {1}", city.Key, city.Value);
            }
            
        }

        private static void genericdemo()
        {
            Generic<string> gstring = new Generic<string>();
            gstring.field = "Generic class field data";
            Console.WriteLine("String data :{0}", gstring.field);
            Generic<int> gint = new Generic<int>();
            gint.field = 8500;
            Console.WriteLine("int data:{0}", gint.field);
            Generic<Book> book = new Generic<Book>();
            book.field = new Book();
            book.field.Bookcode = 89989;
            book.field.Title = "Dreams of wings";
            book.field.Author = "abdul kalam";
            book.field.Price = 678;
            Console.WriteLine("{0} \t{1} \t{2}\t{3}", book.field.Bookcode, book.field.Title, book.field.Author, book.field.Price);

        }

        private static void exception()
        {
            int x = 10;
            try
            {
                int y = 100 / x;
                Console.WriteLine(y);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(x);
            }
        }

        private static void properties_interface()
        {
            Student student = new Student();
            student.Name = "manikanta";
            Console.WriteLine("{0}\t{1}", student.Name, student.Count);
            Student s = new Student();
            s.Name = "akash rao";
            Console.WriteLine($"{s.Name}\t{s.Count}");
        }

        private static void multipleinheritanceinterface()
        {
            Activity activity = new Activity();
            activity.show();
            activity.Makeit();
            activity.Doit();
            Console.WriteLine("interest rate :{0}", activity.RateofInterest());
        }

        private static void sealedclass()
        {
            Teacher teacher = new Teacher("shashank", 33000, 1000, "mathematics");
            Console.WriteLine("{0}\t{1}\t{2}", teacher.Name, teacher.Subject, teacher.CalculatePay());
            teacher.CalculatePay();
        }

        private static void task()
        {
            liveshow talks = new liveshow("TEDX", 1400, "motivational talks", 1500);
            Console.WriteLine("name of liveshow:{0}\tno of visitors:{1}\tcategory of liveshow:{2}\tprice of the liveshow:{3}", talks.Name, talks.Visitors, talks.Category, talks.Price);
            Movie m = new Movie("incredibles", 500, "triller genre");
            Console.WriteLine("name of the movie :{0}\tno of visitors :{1}\t genre of the movie:{2}", m.Name, m.Visitors, m.Genre);
        }

        private static void abstractmethod()
        {
            SBI sbibank = new SBI();
            Console.WriteLine("SBI rate of interest :{0}", sbibank.RateofInterest());
            sbibank.show();



            HDFC hdfcbank = new HDFC();
            Console.WriteLine("HDFC rate of interest :{0}", hdfcbank.RateofInterest());
            hdfcbank.show();
        }

        private static void anonymustypes()
        {
            var x = new { Name = "rakesh", city = "hyderabad", Id = 18884 };
            Console.WriteLine("{0} \t {1} \t {2} ", x.Name, x.city, x.Id);

            var anonArray = new[] { new { Name = "apple", Price = 200 }, new { Name = "grapes", Price = 250 } };
            foreach (var a in anonArray)
            {
                Console.WriteLine("{0}  {1}", a.Name, a.Price);


            }

        }

        private static void operatoroverloading()
        {
            Class1 c = new Class1();
            Class1 c1 = new Class1(300);
            Class1 c2 = new Class1(400);
            c = c1 + c2;
            c1.Display();
            c2.Display();
            c.Display();
        }

        private static void multipleinheritance()
        {
            shopkeeper seller = new shopkeeper(211, "Q sellers", "qseller.45@gmail.com", "9640220224", "ongc");
            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", seller.Customerid, seller.Name, seller.Email, seller.Phone, seller.Nichebusiness);
            distributor dist = new distributor(444, "FAST distributor", "fastdistributo32@gmail.com", "8898553635", "FAST");
            Console.WriteLine("{0}", dist.Customerid);


            Console.WriteLine($"{dist.Name} \t { dist.Email} \t {dist.Phone} \t {dist.Area}");
        }

        private static void methodoverandhiding()
        {
            SalesEmployee se = new SalesEmployee("Rohith", 26400, 5500);
            Console.WriteLine("{0} \t {1} \t Salary with sales bonus ", se.Name, se.CalculatePay());

            Employee emp = new Employee("ajith", 65000);
            Console.WriteLine("name:{0} \t Basic:{1}", emp.Name, emp.CalculatePay());
        }
    }
}


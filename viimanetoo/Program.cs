namespace viimanetoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali 1, 2, 3 või 4");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    WhereLINQ();
                    break;

                case "2":
                   TakeWhileLINQ();
                    break;
                case "3":
                    FileWrite();
                    break;
                case "4":
                    Pyramiid();
                    break;

                default:
                    Console.WriteLine("sisestatud on midagi muud");
                    break;
            }
        }
        public static void WhereLINQ()
        {
            Console.WriteLine("WhereLINQ ");
            var PeopleAge = PeopleList.Peoples
                .Where(x => x.Age > 5 && x.Age < 30);

            foreach (var person in PeopleAge)
            {
                Console.WriteLine(person.Name);
            }
        }
        public static void TakeWhileLINQ()
        {
            Console.WriteLine("TakeWhileLINQ ");
            var takewhileResult = PeopleList.Peoples
                .TakeWhile(x => x.Age > 18);
            {
                foreach (var item in takewhileResult)
                {
                    Console.WriteLine(item.Name + " " + item.Age);
                }
            }
        }
        public static void FileWrite()
        {
            Console.WriteLine("kirjuta ja");
            string p = "ja";
            string l = "ei";
            string ps = Console.ReadLine();
            try { 

             if(ps == p)
                {
                    Console.WriteLine("Kirjuta faili läbi konsooli");

                    string filePath = @"C:\Users\opilane\Desktop\failiasi\WriteToFile.txt";
                    string inputText = Console.ReadLine();

                    File.WriteAllText(filePath, inputText);
                }
             else
                {
                    Console.WriteLine("valisid ei");
                }
            }
            
            catch(Exception ex) 
            {
                Console.WriteLine("teie faili ei saanud salvestada");
                Console.WriteLine(ex.Message);
            }
        }
        public static void Pyramiid()
        {
            int i, j, rows;
            int t = 1;
            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 1 * i - 1; j++)
                {
                    Console.Write("{0} ", t++);      
                }
                Console.Write("\n");
            }
        }
    }
}

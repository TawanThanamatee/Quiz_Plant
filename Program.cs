using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //input plant rose
            Console.Write("Name Plant Rose : ");
            string name_plant_rose = Console.ReadLine();
            Console.Write("Description : ");
            string description_rose = Console.ReadLine();
            Console.Write("Many_Rose : ");
            int many_rose = int.Parse(Console.ReadLine());
            Console.Write("High_Rose : ");
            string high_rose = Console.ReadLine();
            Console.Write("Circumference_Plant : ");
            string Circumference_rose = Console.ReadLine();
            Plant_Rose plant_rose = new Plant_Rose(name_plant_rose,description_rose,many_rose,high_rose, Circumference_rose);

            //intput plant sunflower
            Console.Write("Name Plant Sunflower : ");
            string name_plant_sunflowerd = Console.ReadLine();
            Console.Write("Description : ");
            string description_sunflower = Console.ReadLine();
            Console.Write("Many_Sunflower : ");
            int many_sunflower = int.Parse(Console.ReadLine());
            Console.Write("High_Sunflower : ");
            string high_sunflower = Console.ReadLine();
            Console.Write("Circumference_Plant : ");
            string Circumference_sunflower = Console.ReadLine();
            Plant_Sunflower plant_sunflower = new Plant_Sunflower(name_plant_sunflowerd,description_sunflower,many_sunflower,high_sunflower, Circumference_sunflower);
        }
    }
    class Plant_Rose
    {
        public int Rose;
        public string Name_Plant;
        public string Description;
        public int Many_Plant;
        public string High_Plant;
        public string Circumference;

        public Plant_Rose(string name_plant_rose, string description_rose, int 
            many_rose, string high_rose, string Circumference_rose)
        {
            Name_Plant = name_plant_rose;
            Description = description_rose;
            Many_Plant = many_rose;
            High_Plant = high_rose;
            Circumference = Circumference_rose;
        }
    }
    class Plant_Sunflower
    {
        public int Sunflower;
        public string Name_Plant;
        public string Description;
        public int Many_Plant;
        public string High_Plant;
        public string Circumference;
        public Plant_Sunflower(string name_plant_sunflower, string description_sunflower, int many_sunflower, 
            string high_sunflower, string Circumference_sunflower)
        {
            Name_Plant = name_plant_sunflower;
            Description = description_sunflower;
            Many_Plant = many_sunflower;
            High_Plant = high_sunflower;
            Circumference = Circumference_sunflower;
        }
    }
}

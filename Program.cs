using System;

namespace quiz2_MDT211
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree1 = new Tree(1, "ดอกกุหลาบสีขาว", "สวยงามมาก", 2, "10.5", "6");
            Tree tree2 = new Tree(2, "ดอกกุหลาบสีแดง", "สวยงามมาก", 2, "10.5", "6");
            Tree tree3 = new Tree(1, "ดอกทานตะวันเล็ก", "สวยงาม", 2, "2.0", "2.0");
            Tree tree4 = new Tree(2, "ดอกทานตะวันใหญ่", "สวยงาม", 2, "2.0", "2.0");

            Console.WriteLine("Input Rose");
            Console.WriteLine("-----------");
            tree1.output();
            tree2.output();
            Console.WriteLine();
            Console.WriteLine("Input Sunflower");
            Console.WriteLine("-----------");
            tree3.output();
            tree4.output();
        }
    }
    class Tree
    {
        public int ID;
        public string Tree_name;
        public string Tree_Descript;
        public int Tree_Num;
        public string Tree_Height;
        public string Tree_Diameter;

        public Tree(int id, string tree_name, string tree_descript, int tree_num, string tree_height, string tree_diameter)
        {
            this.ID = id;
            this.Tree_name = tree_name;
            this.Tree_Descript = tree_descript;
            this.Tree_Num = tree_num;
            this.Tree_Height = tree_height;
            this.Tree_Diameter = tree_diameter;
        }
        public void output()
        {
            Console.WriteLine("ID: {0}", this.ID);
            Console.WriteLine("Name: {0}", this.Tree_name);
            Console.WriteLine("Decription: {0}", this.Tree_Descript);
            Console.WriteLine("Amount: {0}", this.Tree_Num);
            Console.WriteLine("Height: {0}", this.Tree_Height);
            Console.WriteLine("Circumference: {0}", this.Tree_Diameter);
        }
    }
}

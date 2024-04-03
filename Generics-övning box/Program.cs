namespace Generics_övning_box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxList = new BoxCollection();

            boxList.Add(new Box(10, 10, 10));
            boxList.Add(new Box(2, 2, 2));
            boxList.Add(new Box(10, 2, 10));
            boxList.Add(new Box(10, 4, 10));

            Display(boxList);

        }


    public static void Display(BoxCollection boxes)
        {
            Console.WriteLine("\nHight:\tWidth\tLength");

            foreach (Box box in boxes)
            {
                Console.WriteLine("{0}\t{1}\t{2}", box.hight.ToString(), box.width.ToString(), box.length.ToString());
            }
        }
    }
}

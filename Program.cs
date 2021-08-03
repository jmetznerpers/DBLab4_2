using System;

namespace DBLab4_2
{
    class Rectangle
    {
        public int Length;
        public int Width;

        public Rectangle(int nLength, int nWidth)
        {
            SetLength(nLength);
            SetWidth(nWidth);

        }
        public double GetWidth()
        {
            return Width;
        }
        public double GetLength()
        {
            return Length;
        }
        public void SetWidth(int newWidth)
        {


            Width = newWidth;
        }
        public void SetLength(int newLength)
        {
            Length = newLength;
        }

    }
    
    class MenuItem
    {
        private int ID;
        private string Name;
        private string Description;
        private decimal Price;

        public int GetID()
        {
            return ID;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetDescription()
        {
            return Description;
        }
        public decimal GetPrice()
        {
            return Price;
        }
        public void SetID(int newID)
        {
            if (ID < 0)
            {
                newID = 0;
            }

            ID = newID;
        }
        public void SetPrice(decimal newPrice)
        {
            if (newPrice <= 0.50m)
            {
                newPrice = .50m;
            }
            if (newPrice >= 10.0m)
            {
                newPrice = 10.0m;
            }
            Price = newPrice;
            
            
        }
        public void SetName(string newName)  
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                Name = "EMPTY";
                //Console.WriteLine("EMPTY");
            }
            else
            {
                Name = newName;
            }
        }
        public void SetDescription(string newDescription)
        {
            if (string.IsNullOrWhiteSpace(newDescription))
            {
               Description = "EMPTY";
               //Console.Write("EMPTY");
            }
            else
            {
                Description = newDescription;
            }
        }
        public MenuItem(int nID, string nName, string nDescription, decimal nPrice)
        {
            SetID(nID);
            SetName(nName);
            SetDescription(nDescription);
            SetPrice(nPrice);
        }
        public MenuItem(int n2ID, string n2Name, decimal n2Price)
        {
            SetID(n2ID);
            SetName(n2Name);
            //Description = "Fresh";
            SetPrice(n2Price);
        }
        
        public override string ToString()
        {
            return $"\nMenu: \nID{ID}\nName: {Name}\nDescription: {Description}\nPrice: ${Price}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem m1 = new MenuItem ( 1, "Quesadilla", "Tasty", 9.95m );
            MenuItem m2 = new MenuItem( 2,"HotDog","", .49m);


            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());
            //When comparing the rectangles, when using r2 = r1 I get the they are the same response, but when I give them the same values they come up as different (without the r1 =r2 line)  Im assuming that even though they have the same values
            //Because they are different instances it will not show them as equal, we aren't comparing strings but rather instance objects.  When using r2 = r1 however we are implicitly telling the compiler that HEY THESE ARE THE SAME.
            Rectangle r1 = new Rectangle(10, 20);
            Rectangle r2 = new Rectangle(10,20);
            r2 = r1;
            Console.WriteLine();
            Console.WriteLine("Checking Rectangles!");
            if (r1 == r2)
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are different!");
            }

        }
    }
}

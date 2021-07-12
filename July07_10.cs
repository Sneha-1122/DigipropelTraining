using System;
public  class Table 
    {
        private int width = 0; 
        private int height = 0; 

        //parameterised constructor
        public Table(int width, int height) 
        {
            if (width >= 0) this.width = width;
            if (height >= 0) this.height = height;
        }

        // Method to show the height and width on the screen
        public void ShowData()
        {
            Console.WriteLine("Height - {0} cm, width - {1} cm", height, width);
        }
        public static void Main(string[] args)
        {
            Table[] arr = new Table[10];

            // Generating random values 
            Random value = new Random();
            for(int i = 0; i<5; i++)
                arr[i] = new Table(value.Next(0,100), value.Next(100,200));
            foreach (var i in arr)
                i.ShowData();
        }
}

/*
OUTPUT:
Height - 137 cm, width - 32 cm
Height - 146 cm, width - 36 cm
Height - 185 cm, width - 20 cm
Height - 116 cm, width - 33 cm
Height - 100 cm, width - 45 cm
*/


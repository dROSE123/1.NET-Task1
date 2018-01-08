using System;

namespace Task1
{
    public class Children
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gift { get; set; }

        public int NumberOfWickedness { get; set; }

        public Children(string name, string address, string gift, int numberOfWickedness)
        {
            Name = name;
            Address = address;
            Gift = gift;
            NumberOfWickedness = numberOfWickedness;
        }

        public int DoesHeDeserveGifts()
        {
            if (NumberOfWickedness > 5)
            {
                return 0; // nu merita caodu
            }
            else
            {
                return 1; // merita
            }

        }
    }
}
using System;

namespace AccessModifiersAndConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Access Modifiers and Constructors");
            Console.WriteLine("Personnel 1:");

            // Creating an instance of the Shopping class with all information provided
            Shopping personnelList1 = new Shopping("Taha", "BÖREKCİ", 351, "Sales");
            personnelList1.DisplayPersonnel();
            Console.WriteLine("*****************************");

            Console.WriteLine("*****************************************************");

            // Creating an instance of the Shopping class with only name and surname provided
            Shopping personnelList2 = new Shopping("Hakan", "BULUT");
            personnelList2.DisplayPersonnel();

            Console.WriteLine("*********Personnel 3******************");

            // Creating an instance of the Shopping class without providing any information initially
            Shopping personnelList3 = new Shopping();
            personnelList3.Name = "Barış";
            personnelList3.Surname = "AKAN";
            personnelList3.PersonnelNo = 355;
            personnelList3.Department = "Administrator";
            personnelList3.DisplayPersonnel();
        }
    }

    // Shopping class definition
    class Shopping
    {
        // Properties for the shopping personnel
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonnelNo { get; set; }
        public string Department { get; set; }

        // Constructor with all information provided
        public Shopping(string name, string surname, int personnelNo, string department)
        {
            Name = name;
            Surname = surname;
            PersonnelNo = personnelNo;
            Department = department;
        }

        // Constructor with only name and surname provided (a shortened version)
        public Shopping(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        // Default constructor needed for the shoppersonel method not to produce errors
        public Shopping() { }

        // Method to display shopping personnel information
        public void DisplayPersonnel()
        {
            Console.WriteLine("Personnel Name: {0}", Name);
            Console.WriteLine("Personnel Surname: {0}", Surname);
            Console.WriteLine("Personnel PersonnelNo: {0}", PersonnelNo);
            Console.WriteLine("Personnel Department: {0}", Department);
        }
    }
}

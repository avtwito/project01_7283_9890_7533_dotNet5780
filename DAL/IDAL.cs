using System;

namespace DAL
{
    public class IDAL
    {
       interface Idal
        {
            void AddGuestRequest();
            void AddHostingUnit();
            void DeleteHostingUnit();
            void UpdateHostingUnit();
            void AddOrder();
            void AddBankAccount();
            void UpdateOrder();
            void ListHostingUnits();
            void ListCustomers();
            void ListOrders();
            void ListBanks();
        }
        public class Dal_imp : Idal
        {
            public void AddGuestRequest()
            {
                Console.WriteLine("Please enter the followings:");
                Console.Write("Firstname:");
                string FirstName = Console.ReadLine();
                Console.Write("Lastname:");
                string LastName = Console.ReadLine();
                Console.Write("Email Address:");
                string MailAddress = Console.ReadLine();
                bool Status = true;
                string RegistrationDate = Console.ReadLine();
                string EntryDate = Console.ReadLine();
                string ReleaseDate = Console.ReadLine();
                
                Console.WriteLine("Where do you want your hosting unit?");
                Console.WriteLine("All - 0 /n North - 1 /n South - 2 /n Center - 3 /n Jerusalem - 4");
                int Area = int.Parse(Console.ReadLine());

                string SubArea = Console.ReadLine();

                Console.WriteLine("Do you want your hosting unit to have a pool?");
                Console.WriteLine("Yes-0 /n Optional - 1 /n No - 2:");
                int Pool= int.Parse(Console.ReadLine());

                Console.WriteLine("Do you want your hosting unit to have a jacuzzi?");
                Console.WriteLine("Yes-0 /n Optional - 1 /n No - 2:");
                int Jacuzzi=int.Parse(Console.ReadLine());

                Console.WriteLine("Do you want your hosting unit to have a garden?");
                Console.WriteLine("Yes-0 /n Optional - 1 /n No - 2:");
                int Garden= int.Parse(Console.ReadLine());

                Console.WriteLine("Do you want your hosting unit to have a children attraction?");
                Console.WriteLine("Yes-0 /n Optional - 1 /n No - 2:");
                int ChildrenAttraction= int.Parse(Console.ReadLine());

                BE.GuestRequest temp;
                temp.GuestRequestKey = GuestRequestKey;
            }

            public void AddHostingUnit()
            {
                string HostingUnitKey = Console.ReadLine();
                string HostKey = Console.ReadLine();
                string HostingUnitName = Console.ReadLine();

                bool[,] Diary = new bool[12, 31];
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 31; j++)
                    {
                        Diary[i, j] = false;
                    }
                }
            }

            public void AddBankAccount()
            {
                int BankNumber, BranchNumber, BankAccountNumber;
                string BankName, BranchAddress, BranchCity;
                BankNumber = int.Parse(Console.ReadLine());
                BankName = Console.ReadLine();
                BranchNumber = int.Parse(Console.ReadLine());
                BranchAddress = Console.ReadLine();
                BranchCity = Console.ReadLine();
                BankAccountNumber = int.Parse(Console.ReadLine());
            }

            public void DeleteHostingUnit(string HostingUnitKey)
            {
<<<<<<< HEAD
               
=======
                int a;
>>>>>>> cd46474169391a4a8c15b61229dde2f95fa61b06
            }

            public void UpdateHostingUnit()
            {
               
            }

            public void AddOrder()
            {

            }

            public void UpdateOrder()
            {

            }

            public void ListHostingUnits()
            {

            }

            public void ListCustomers()
            {

            }

            public void ListOrders()
            {

            }

            public void ListBanks()
            {

            }
        }

    }
}

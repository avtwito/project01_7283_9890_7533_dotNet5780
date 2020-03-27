using System;
using DS;
using System.Collections.Generic;


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
                BE.GuestRequest temp;
                int GenerateRequestKey()
                {
                    int key;
                Label:
                    key = rnd.Next(10000000, 100000000);  // creates a number between 10000000 and 99999999
                    for (int i = 0; i < GuestRequestList.Count(); i++)
                    {
                        if (GuestRequsetList[i].GuestRequestKey == key)
                        {
                            goto Label;
                        }
                    }
                    return key;
                }
                temp.GuestRequestKey = GenerateRequestKey();

                Console.WriteLine("Please enter the followings:");
                Console.Write("Firstname:");
                string FirstName = Console.ReadLine();
                temp.

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
                Guid g = Guid.NewGuid();
                Console.WriteLine(g.ToString());
                
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

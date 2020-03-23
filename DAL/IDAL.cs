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
                int GuestRequestKey= int.Parse(Console.ReadLine());
                string PrivateName = Console.ReadLine();
                string FamilyName = Console.ReadLine();
                string MailAddress = Console.ReadLine();
                bool Status = bool.Parse(Console.ReadLine());
                string RegistrationDate = Console.ReadLine();
                string EntryDate = Console.ReadLine();
                string ReleaseDate = Console.ReadLine();
                string Area = Console.ReadLine();
                string SubArea = Console.ReadLine();
                int Pool= int.Parse(Console.ReadLine());
                int Jacuzzi=int.Parse(Console.ReadLine());
                int Garden= int.Parse(Console.ReadLine());
                int ChildrenAttraction= int.Parse(Console.ReadLine());
            }

            public void AddHostingUnit()
            {
                string HostingUnitKey = Console.ReadLine();
                string HostKey = Console.ReadLine();
                string HostringUnitName = Console.ReadLine();

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

            public void DeleteHostingUnit()
            {
                throw new NotImplementedException();
            }

            public void UpdateHostingUnit()
            {
                throw new NotImplementedException();
            }

            public void AddOrder()
            {
                throw new NotImplementedException();
            }

            public void UpdateOrder()
            {
                throw new NotImplementedException();
            }

            public void ListHostingUnits()
            {
                throw new NotImplementedException();
            }

            public void ListCustomers()
            {
                throw new NotImplementedException();
            }

            public void ListOrders()
            {
                throw new NotImplementedException();
            }

            public void ListBanks()
            {
                throw new NotImplementedException();
            }
        }

    }
}

using System;

namespace BE
{

    public class GuestRequest
    {
        void ToString()//צריך להגדיר אותה
        {

        }
        public int GuestRequestKey   // property
        {
            get { return GuestRequestKey; }   // get method
            set { GuestRequestKey = value; }  // set method
        }
       

        public string FirstName   // property
        {
            get { return FirstName; }   // get method
            set { FirstName = value; }  // set method
        }
        public string LastName   // property
        {
            get { return LastName; }   // get method
            set { LastName = value; }  // set method
        }
        string MailAddress;
        bool Status;
        string RegistrationDate;
        string EntryDate;
        string ReleaseDate;
        int Area;
        string SubArea;
        int Pool;
        int Jacuzzi;
        int Garden;
        int ChildrenAttraction;
        

    }

    public class BankAccount
    {
        void Tostring()
        {

        }

        int BankNumber;
        string BankName;
        int BranchNumber;
        string BranchAddres;
        string BranchCity;
        int BankAccountNumber;
    }

    public class Host
    {
        void Tostring()
        {

        }

        int HostNumber;
        string FirstName;
        string LastName;
        string PhoneNumber;
        string MailAddress;
        BankAccount HostBankAccount;
        bool CollectionClearance;

    }

    public class HostingUnit
    {
        void Tostring()
        {

        }

        string HostingUnitKey;
        string HostKey;
        string HostringUnitName;

        bool[,] Diary = new bool[12, 31];

    }

    public class Order
    {
        void Tostring()
        {

        }

        string HostingUnitKey;
        string Name;
        string CreateDate;
        string OrderDate;
    }
}

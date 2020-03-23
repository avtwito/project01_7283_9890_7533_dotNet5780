using System;

namespace BE
{

    public class GuestRequest
    {
         void ToString()//צריך להגדיר אותה
        {

        }
        
       static int GuestRequestKey;
        string PrivateName;
        string FamilyName;
        string MailAddress;
        bool Status;
        string RegistrationDate;
        string EntryDate;
        string ReleaseDate;
        string Area;
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
        string PrivateName;
        string FamilyName;
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

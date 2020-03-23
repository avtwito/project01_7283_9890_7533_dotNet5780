using System;

namespace BE
{
    enum Accesories
    {
        NotInterested = 0, Optional = 1, Must = 2
    };
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

    class BankAccount
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

    class Host
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

    class HostingUnit
    {
        string HostingUnitKey;
        string HostKey;
        string HostringUnitName;
        bool[,] Diary = new bool[12, 31];
    }

}

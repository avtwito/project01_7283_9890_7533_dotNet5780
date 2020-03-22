using System;

namespace BE
{
    enum Accesories
    {
        NotInterested = 0, Optional = 1, Must = 2
    };
    public class GuestRequest
    {
        short Teen;
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

}

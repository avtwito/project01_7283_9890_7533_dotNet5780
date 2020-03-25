using System;
using System.Collections.Generic;


namespace DS
{
    public class DataSource
    {
        public List<BE.GuestRequest> GuestRequsetList = new List<BE.GuestRequest>();
        public List<BE.BankAccount> BankAccountList = new List<BE.BankAccount>();
        public List<BE.Host> HostList = new List<BE.Host>();
        public List<BE.HostingUnit> HostingUnitList = new List<BE.HostingUnit>();
        public List<BE.Order> OrderList = new List<BE.Order>();
    }
}
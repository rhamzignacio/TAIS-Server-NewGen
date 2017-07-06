//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAIS_Server_NewGen
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profiles
    {
        public decimal ProfileID { get; set; }
        public byte ProfileType { get; set; }
        public string ProfileNumber { get; set; }
        public string InterfaceCode { get; set; }
        public byte AccountType { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Salutation { get; set; }
        public string PhoneType1 { get; set; }
        public string PhoneType2 { get; set; }
        public string PhoneType3 { get; set; }
        public string PhoneType4 { get; set; }
        public string PhoneType5 { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string PhoneNumber3 { get; set; }
        public string PhoneNumber4 { get; set; }
        public string PhoneNumber5 { get; set; }
        public string PhoneSort1 { get; set; }
        public string PhoneSort2 { get; set; }
        public string PhoneSort3 { get; set; }
        public string PhoneSort4 { get; set; }
        public string PhoneSort5 { get; set; }
        public byte Language { get; set; }
        public Nullable<System.DateTime> FirstDate { get; set; }
        public Nullable<System.DateTime> LastDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public decimal Balance { get; set; }
        public decimal AddedBy { get; set; }
        public bool Active { get; set; }
        public bool SendEmail { get; set; }
        public bool CBSync { get; set; }
        public string Notes { get; set; }
        public string Branches { get; set; }
    }
}

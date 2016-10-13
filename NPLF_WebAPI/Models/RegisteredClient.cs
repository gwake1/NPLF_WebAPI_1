using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPLF_WebAPI.Models
{
    public class RegisteredClient
    {
        public int      RegisteredClientID      { get; set; }
        public string   LastName                { get; set; }
        public string   FirstName               { get; set; }
        public int      AreaCode                { get; set; }
        public string   PhoneNumber1            { get; set; }
        public string   PhoneNumber2            { get; set; }
        public string   EmailAddress            { get; set; }
        public string   StreetAddress           { get; set; }
        public string   HouseNumber             { get; set; }
        public int      ZipCode                 { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace f360
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fish
    {
        public int Id { get; set; }
        public Nullable<int> tripId { get; set; }
        public string name { get; set; }
        public Nullable<double> weight { get; set; }
        public Nullable<double> length { get; set; }
        public Nullable<System.DateTime> caughtDate { get; set; }
        public string species { get; set; }
    
        public virtual Trip Trip { get; set; }
    }
}
namespace f360
{
    using System;
    using System.Collections.Generic;
    
    public partial class SecurityToken
    {
        public int Id { get; set; }
        public Nullable<System.Guid> token { get; set; }
        public Nullable<int> userId { get; set; }
    
        public virtual User User { get; set; }
    }
}
namespace f360
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trip
    {
        public Trip()
        {
            this.Fish = new HashSet<Fish>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<int> userId { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Fish> Fish { get; set; }
        public virtual User User { get; set; }
    }
}
namespace f360
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Trips = new HashSet<Trip>();
            this.SecurityTokens = new HashSet<SecurityToken>();
        }
    
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    
        public virtual ICollection<Trip> Trips { get; set; }
        public virtual ICollection<SecurityToken> SecurityTokens { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace February27th_EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Section
    {
        public int Id { get; set; }
        public int Course_Id { get; set; }
        public string Days { get; set; }
        public string Time { get; set; }
        public int Instructor_ID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}

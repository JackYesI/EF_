//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_
{
    using System;
    using System.Collections.Generic;
    
    public partial class books
    {
        public int Id { get; set; }
        public string bookName { get; set; }
        public int page_count { get; set; }
        public int autorsId { get; set; }
        public int languagesId { get; set; }
    
        public virtual autors autors { get; set; }
        public virtual languages languages { get; set; }
    }
}
﻿namespace EXandIM.Web.Core.Models
{
    public class ItemInActivity
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public Book? Book { get; set; }
        public int? ReadingId { get; set; }
        public Reading? Reading{ get; set; }
        public string? Procedure { get; set; }
        public DateTime? ProcedureDate { get; set; }
        public int? ActivityBookId { get; set; }
        public ActivityBook? ActivityBook { get; set; }
    }
}

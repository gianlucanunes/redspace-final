using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpaceDesktop.DTO
{
    public class ReviewDTO
    {
        public int IdReview { get; set; }
        public int IdJogo { get; set; }
        public int IdTopico1 { get; set; }
        public decimal ResultadoTopico1 { get; set; }
        public int IdTopico2 { get; set; }
        public decimal ResultadoTopico2 { get; set; }
        public int IdTopico3 { get; set; }
        public decimal ResultadoTopico3 { get; set; }
        public int IdTopico4 { get; set; }
        public decimal ResultadoTopico4 { get; set; }
        public int IdTopico5 { get; set; }
        public decimal ResultadoTopico5 { get; set; }
        public decimal ResultadoTotal { get; set; }
        public bool Status { get; set; }
    }
}

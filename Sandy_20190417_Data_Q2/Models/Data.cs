using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sandy_20190417_Data_Q2.Models
{
   
    public class Data
    {
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime Date { get; set; }
        public int Ticket { get; set; }
        public int ResponseMinutes { get; set; }
    }

}
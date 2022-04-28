
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace task.Models
{
    public class ReceivedSamples
    {
        public int id { get; set; }

        public string name { get; set; }
        public int receivingSideId { get; set; }
        public int clientId { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime recevingDate { get; set; }
        
      
        public string  describtion { get; set; }
        public int numberOfSamples { get; set; }
        public string  attachments { get; set; }
        public string  clienAttachments { set; get; }
        public double sampleCost { set; get; }
        public bool status { set; get; }
        public virtual Client client { set; get; }
        public virtual ReceivingSide side { set; get; }


    }
}

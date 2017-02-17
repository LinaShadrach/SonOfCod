using SonOfCodSeafood.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCodSeafood.Models
{
    [Table("FishChoices")]
    public class FishChoice
    {
        [Key]
        public int Id { get; set; }
        public int FishId { get; set; }
        public virtual Fish Fish { get; set; }
        public virtual Recipient Recipient { get; set; }
        public int RecipientId { get; set; }
        public FishChoice(int recipientId, int fishId)
        {
            FishId = fishId;
            RecipientId = recipientId;
        }
    }
}

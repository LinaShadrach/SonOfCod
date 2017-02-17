using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCodSeafood.Models
{
    [Table("Recipents")]
    public class Recipient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public Recipient()
        {
        }
        public Recipient(string name, string zipCode)
        {
            Name = name;
            ZipCode = zipCode;
        }
        public override bool Equals(System.Object otherRecipient)
        {
            if (!(otherRecipient is Recipient))
            {
                return false;
            }
            else
            {
                Recipient newRecipient = (Recipient)otherRecipient;
                bool nameEquality = (this.Name == newRecipient.Name);
                bool zipCodeEquality = (this.ZipCode == newRecipient.ZipCode);
                //bool userIdEquality = (this.UserId == newRecipient.UserId);

                return (nameEquality && zipCodeEquality);
            }
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}

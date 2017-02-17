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
        public string Email { get; set; }
        public int ZipCode { get; set; }
        public int UserId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }

        public Recipient()
        {
        }
        public Recipient(int id, string name, string email, int zipCode, int userId)
        {
            Id = id;
            Name = name;
            Email = email;
            ZipCode = zipCode;
            //UserId = userId;
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
                bool emailEquality = (this.Email == newRecipient.Email);
                bool zipCodeEquality = (this.ZipCode == newRecipient.ZipCode);
                //bool userIdEquality = (this.UserId == newRecipient.UserId);

                return (nameEquality && emailEquality && zipCodeEquality);
            }
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}

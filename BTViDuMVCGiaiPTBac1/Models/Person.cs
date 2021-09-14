using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTViDuMVCGiaiPTBac1.Models
{
    [Table("Person")]
    public class Person
    {
        LTQLDbContext db = new LTQLDbContext();
        [Key]
        public string PersonID { get; set; }
        [Required(ErrorMessage = "Ten Person khong duoc de trong")]
        [MinLength(3)]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "Dia chi Adress khong duoc de trong")]
        public string Adress { get; set; }

        public bool Delete(string id)
        {
            var ps = db.Persons.Find(id);
            db.Persons.Remove(ps);
            db.SaveChanges();
            return true;
        }

        public Person GetById(string ID)
        {
            return db.Persons.SingleOrDefault(x => x.PersonID == ID);
        }
    }
}
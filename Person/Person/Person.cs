using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public int Id { get; set; }
        public string Produit { get; set; }
        public string Client { get; set; }
        public string Fournisseur { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }

    public class LibraryContect : DbContext
    {
        public DBSet<Book> Books { get; set; }
        public DBSet<Person> Persons { get; set; }
    }
}

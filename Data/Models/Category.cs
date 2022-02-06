using System.Collections.Generic;
using System.Linq;

namespace HomeApp.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string categoryName { get; set; }

        public string desk { get; set; }

        public List<Appl> appl { get; set; }

       
    }
}

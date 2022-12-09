using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillmineProject
{
    class Book
    {
        private int id;
        private string Name;
        private string Author;
        private int Price;

        public int Id { get => id; set => id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Author1 { get => Author; set => Author = value; }
        public int Price1 { get => Price; set => Price = value; }

        public override string ToString()
        {

            return $"Name of book{Name},Id-{id},Authour{Author},Price{Price1}";
        }
        
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanNhatHuy_BaiTapC_.BaiTapLinQ2
{
    public class Position
    {
        public int Id { get; set; }
        public string PosName { get; set; }
        public string Description { get; set; }

        public Position() { }

        public Position(int id, string name, string description)
        {
            this.Id = id;
            this.PosName = name;
            this.Description = description;
        }

        public static IList<Position> Postions 
        {
            get
            {
                return new List<Position>
                {
                    new Position { Id = 1, PosName = "Designer", Description = "Designing UI"},
                    new Position { Id = 2, PosName = "Developer", Description = "Coding product"},
                    new Position { Id = 3, PosName = "Leader", Description = "Leading tech team" }
                };
            }
        }

        public override string ToString()
        {
            return $"Id: {Id} - Position name: {PosName} - Description: {Description}";
        }
    }
}

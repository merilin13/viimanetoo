using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viimanetoo
{
    internal class PeopleList
    {
        public static readonly List<People> Peoples = new List<People>
        {
            new People()
                {
                    Id = 1,
                    Name = "Piip",
                    Age = 33,
                   
                },
                new People()
                {
                    Id = 2,
                    Name = "Tuut",
                    Age = 34,
                   
                },
                new People()
                {
                    Id = 3,
                    Name = "Hello kitty",
                    Age = 5,
                   
                },
                new People()
                {
                    Id = 4,
                    Name = "Mymelody",
                    Age = 10,
                   
                },
                new People()
                {
                    Id = 5,
                    Name = "Kuromi",
                    Age = 17,
                    
                },
                new People()
                {
                    Id = 6,
                    Name = "Pompompurin",
                    Age = 19,
                    
                },
        };
    }
}

using Challenge.Clear.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Clear.Core.Domain.Entities
{
    public class MovieActor 
    {
        public MovieActor()
        {

        }

        public int MovieId { get; set; }

        public int ActorId { get; set; }

        public Movie Movie { get; set; }

        public Actor Actor { get; set; }
    }
}

using Challenge.Clear.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Clear.Domain.Entities
{
    public class Actor : BaseEntity
    {
        public Actor()
        {
            MovieActors = new List<MovieActor>();
        }
        public string Name { get; set; }

        public IList<MovieActor> MovieActors { get; set; }
    }
}

using System;
using System.Linq;

namespace cytoscape.Models
{
    public static class DbInitializer
    {
        public static void Initialize(CytoscapeElementsContext context)
        {
            context.Database.EnsureCreated();

            if (context.Nodes.Any())
            {
                return;   // DB has been seeded
            }

            var nodes = new[]
            {
                new Node {Name = "SwecoCore", DbName = "SwecoDB", Comments = "some info", PositionX = 275, PositionY = 225},
                new Node {Name = "Maconomy", DbName = "SecondDB", Comments = "also some info", PositionX = 50, PositionY = 400},
                new Node {Name = "HRPlus", DbName = "thirdDB", Comments = "this is a comment", PositionX = 500, PositionY = 50 },
                new Node {Name = "Webbeko", DbName = "fourthDB", Comments = "something something' ", PositionX = 500, PositionY = 400 },
                new Node {Name = "Aplus", DbName = "fifthDB", Comments = "info about aplus' ", PositionX = 50, PositionY = 50 }
            };
            context.Nodes.AddRange(nodes);

            context.Edges.RemoveRange(context.Edges);
            var edges = new[]
            {
                new Edge {Id = "rel_1", StartNode = "Maconomy", EndNode = "SwecoCore" },
                new Edge {Id = "rel_2", StartNode = "HRPlus", EndNode ="SwecoCore" },
                new Edge {Id = "rel_3", StartNode = "Webbeko", EndNode = "SwecoCore" },
                new Edge {Id = "rel_4", StartNode = "Aplus", EndNode = "SwecoCore", Description = "Ekonomidata till core"},
                new Edge {Id = "rel_5", StartNode = "Aplus", EndNode = "HRPlus", Description = "En tuill dependency"}
            };
            context.Edges.AddRange(edges);

            context.SaveChanges();
        }
    }
}
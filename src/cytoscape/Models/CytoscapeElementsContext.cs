using Microsoft.EntityFrameworkCore;

namespace cytoscape.Models
{
    public class CytoscapeElementsContext : DbContext
    {
        public CytoscapeElementsContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Node> Nodes { get; set; }
        public DbSet<Edge> Edges { get; set; }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using cytoscape.Models;

namespace cytoscape.Migrations
{
    [DbContext(typeof(CytoscapeElementsContext))]
    [Migration("20161025081931_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cytoscape.Models.Edge", b =>
                {
                    b.Property<int>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("EndNodeId");

                    b.Property<int>("StartNodeId");

                    b.HasKey("Name");

                    b.ToTable("Edges");
                });

            modelBuilder.Entity("cytoscape.Models.Node", b =>
                {
                    b.Property<int>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments");

                    b.Property<string>("DbName");

                    b.Property<string>("Name");

                    b.Property<decimal>("PositionX");

                    b.Property<decimal>("PositionY");

                    b.HasKey("Name");

                    b.ToTable("Nodes");
                });
        }
    }
}

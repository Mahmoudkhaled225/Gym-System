using System.Reflection;
using A_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace A_DataAccessLayer.Contexts;


/*
 * In Entity Framework,
 * DbContext is a class that represents a session
 * with the database and provides a set of APIs
 * for performing database operations.
 * 
 */
public class GymContext: DbContext
{
    
    /*
     * CTOR with instance of DbContextOptions<ProjectContext> as a parameter
     * DbContextOptions contains the Configration options that are used by DbContext.
     * ex : ConnectionString
     * and other settings needed to connect to the database
     * base(options) call is used to
     * pass these options to the constructor of the base class (DbContext).
     *
     */
    public GymContext(DbContextOptions<GymContext> options): base(options)
    {
        
    }
    
    /*
     * It is called when the model for a derived context is being created
     * This is where we can configure the model that was discovered
     * by convention from the entity type configurations that will be used for db.
     * all that happen by modelBuilder parameter
     */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // assembly is a unit of deployment and versioning
        // assembly typically contains compiled code(DLL), metadata,
        // and resources related to a set of one or more .NET types.
        // In the context of Entity Framework and the code you provided,
        // the term "assembly" refers to the compiled code
        // that includes the ProjectContext class and 
        // any other related classes and configurations

        // Assembly.GetExecutingAssembly() to retrieve
        // the assembly where the ProjectContext class is defined.
        // This assembly contains all the types and configurations
        // that Entity Framework needs to know about
        // when creating the database model.
        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
        
    }

    public DbSet<Trainer> Trainers { get; set; } = null!;

    public DbSet<Trainee> Trainees { get; set; } = null!;
}
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RoomWeave.Server.Models;
using System;

namespace RoomWeave.Data;
public class RoomWeaveDbContext : DbContext
{
    private readonly IConfiguration _configuration;

   // public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Artifact> Artifacts { get; set; }
    public DbSet<EnvironCondition> EnvironConditions { get; set; }
    public DbSet<Floor> Floors { get; set; }
    public DbSet<Harbinger> Harbingers { get; set; }
    public DbSet<House> Houses { get; set; }
    public DbSet<NPC> NPCs { get; set; }
    public DbSet<NPCScript> NPCScripts { get; set; }
    public DbSet<NPCVibe> NPCVibes { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomArtifact> RoomArtifacts { get; set; }
    public DbSet<RoomEnviron> RoomEnvirons { get; set; }
    public DbSet<RoomHarbinger> RoomHarbingers { get; set; }
    public DbSet<RoomTrap> RoomTraps { get; set; }
    public DbSet<Script> Scripts { get; set; }
    public DbSet<Trap> Traps { get; set; }
    

    public RoomWeaveDbContext(DbContextOptions<RoomWeaveDbContext> context, IConfiguration config) : base(context)
    {
        _configuration = config;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //rolls available
        //only adding 1 so I dont need the bracket to indicate an array of IdentityRoles
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
            Name = "Admin",
            NormalizedName = "admin"
        });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {

            Id = "a601c402-545f-4ba8-869d-6f0968774d58",
            Name = "User",
            NormalizedName = "user"
        });
        //User info with login credentials
        modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
        {
            Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
            UserName = "Administrator",
            Email = "admin@neopets.com",
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])
        });
        modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
        {
            Id = "e2731372-eb45-4cc5-9a34-d9711f3642b2",
            UserName = "Schlebethany",
            Email = "Schlebethany@neopets.com",
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])
        });
        //join table of user roles with users
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
            UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f"
        });
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = "a601c402-545f-4ba8-869d-6f0968774d58",
            UserId = "e2731372-eb45-4cc5-9a34-d9711f3642b2"
        });
        // modelBuilder.Entity<UserProfile>().HasData(new UserProfile
        // {
        //     Id = 1,
        //     IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
        //     FirstName = "Admina",
        //     LastName = "Strator",
        //     Address = "101 Main Street",
        // });
        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[]
        {
            new UserProfile
            {
            Id = 1,
            IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
            FirstName = "Admina",
            LastName = "Strator",
            Address = "101 Main Street",
            IsAdmin = true
            },
            new UserProfile
            {
                Id = 2,
                IdentityUserId = "e2731372-eb45-4cc5-9a34-d9711f3642b2",
                FirstName = "Schlebethany",
                LastName = "Pleasance",
                Address = "222 N Sidereal Way",
                IsAdmin = false
            }
        });
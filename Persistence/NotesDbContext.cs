using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityTypeConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options){}

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }
    }
}

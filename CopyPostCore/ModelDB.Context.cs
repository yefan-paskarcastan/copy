﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CopyPostCore
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class autoParsingContext : DbContext
    {
        public autoParsingContext()
            : base("name=autoParsingContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FoundPost> FoundPost { get; set; }
        public virtual DbSet<Img> Img { get; set; }
        public virtual DbSet<ReadyPost> ReadyPost { get; set; }
        public virtual DbSet<Spoiler> Spoiler { get; set; }
        public virtual DbSet<TorrentSoftPost> TorrentSoftPost { get; set; }
        public virtual DbSet<TorrentTracker> TorrentTracker { get; set; }
        public virtual DbSet<TypeImg> TypeImg { get; set; }
    }
}

﻿// <auto-generated />
namespace Event_Attendees_Tracker_DAL.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.4.0")]
    public sealed partial class AddingOneToOneRelationfromCollegeDetailsTableToPointOfContactTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddingOneToOneRelationfromCollegeDetailsTableToPointOfContactTable));
        
        string IMigrationMetadata.Id
        {
            get { return "202003100816125_Adding OneToOne Relation from CollegeDetails Table To PointOfContact Table"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
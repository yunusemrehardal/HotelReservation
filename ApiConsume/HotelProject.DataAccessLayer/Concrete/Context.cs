﻿using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=PST-4;initial catalog=ApiDb;integrated security=true");
		}
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Staff> Staff { get; set; }
		public DbSet<Subscribe> Subscribes { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<About> Abouts { get; set; }
	}
}

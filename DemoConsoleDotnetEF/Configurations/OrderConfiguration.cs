﻿using DemoConsoleDotnetEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleDotnetEF.Configurations
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {

        public OrderConfiguration()
        {
            this.ToTable("orders");

            this.HasKey<int>(s => s.OrderId);

            this.Property(p => p.Fecha);
            //.HasMaxLength(800);

            this.HasMany(p => p.OrdersDetails);


        }

    }
}

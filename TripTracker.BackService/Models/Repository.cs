﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {
        private List<Trip> trips = new List<Trip>()
        {
            new Trip{
            Id=1,
            Name = "MVP Summit",
            StartDate = new DateTime(2018,3,5),
            EndDate = new DateTime(2018,3,8)
            },
            new Trip{
                Id = 2,
                Name = "DevIntersection Orlando 2018",
                StartDate = new DateTime(2018,3,25),
                EndDate =new DateTime(2018,3,28) 
            },
            new Trip
            {
                Id = 3,
                Name="Build 2018",
                StartDate = new DateTime(2018,5,7),
                EndDate = new DateTime(2018,5,9)
            }
        };
        public List<Trip> Get()
        {
            return trips;
        }
        public void Add(Trip mtrip)
        {
            
        }
    }
}

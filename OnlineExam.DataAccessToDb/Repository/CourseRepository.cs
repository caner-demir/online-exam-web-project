﻿using OnlineExam.DataAccessToDb.Data;
using OnlineExam.DataAccessToDb.Repository.IRepository;
using OnlineExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.DataAccessToDb.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly ApplicationDbContext _db;

        public CourseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Course course)
        {
            var ObjFromDb = _db.Courses.FirstOrDefault(c => c.Id == course.Id);

            if (ObjFromDb != null)
            {
                if (course.ImageUrl != null)
                {
                    ObjFromDb.ImageUrl = course.ImageUrl;
                }

                ObjFromDb.Name = course.Name;
                ObjFromDb.DescriptionShort = course.DescriptionShort;
                ObjFromDb.DescriptionDetailed = course.DescriptionDetailed;
            }
        }
    }
}

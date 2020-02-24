﻿using System;
using System.Collections.Generic;
using System.Linq;
using CS321_W5D2_BlogAPI.Core.Models;
using CS321_W5D2_BlogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace CS321_W5D2_BlogAPI.Infrastructure.Data
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _dbContext;

        public BlogRepository(AppDbContext dbContext) 
        {
            // TODO: inject AppDbContext
            AppDbContext = AppDbContext;
        }

        public IEnumerable<Blog> GetAll()
        {
            // TODO: Retrieve all blgs. Include Blog.User.
            return _dbContext;
        }

        public Blog Get(int id)
        {
            // TODO: Retrieve the blog by id. Include Blog.User.
            return _dbContext.Blogs.FirstOrDefault(b => b.Id == id);
        }

        public Blog Add(Blog blog)
        {
            // TODO: Add new blog
            return blog;
        }

        public Blog Update(Blog updatedItem)
        {
            // TODO: update blog
            throw new NotImplementedException();
            //var existingItem = _dbContext.Find(updatedItem.Id);
            //if (existingItem == null) return null;
            if (updatedItem == null) return null;
            //_dbContext.Entry(existingItem)
            //   .CurrentValues
            //   .SetValues(updatedItem);
            //_dbContext.Blogs.Update(existingItem);
            //_dbContext.SaveChanges();
            //return existingItem;
            return updatedItem;
        }

        public void Remove(int id)
        {
            // TODO: remove blog
            _dbContext.Remove(blog);
        }
    }
}

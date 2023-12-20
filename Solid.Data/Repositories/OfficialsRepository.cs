﻿using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class OfficialsRepository:IOfficialsRepositories
    {
        private readonly DataContext _context;

        public OfficialsRepository(DataContext context)
        {
            _context = context;
        }
        public Official AddOfficial(Official official)
        {
            _context.Officials.Add(official);
            return official;
        }

        public void DeleteOfficial(int id)
        {
            var temp = _context.Officials.Find(x => x.Id == id);
            _context.Officials.Remove(temp);
        }

        public List<Official> GetOfficials()
        {
            return _context.Officials;
        }

        public Official GetById(int id)
        {
            return _context.Officials.Find(x => x.Id == id);
        }

        public Official UpdateOfficial(int id, Official official)
        {
            var temp = _context.Officials.Find(u => u.Id == id);
            temp.Id = official.Id;
            temp.Name = official.Name;
            return temp;
        }
    }
}

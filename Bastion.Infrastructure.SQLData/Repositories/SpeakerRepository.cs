using Bastion.Core.DomainService;
using Bastion.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bastion.Infrastructure.SQLData.Repositories
{
    class SpeakerRepository : ISpeakerRepository
    {
        private readonly BastionContext _context;


        public Speaker Create(Speaker speaker)
        {
            _context.Attach(speaker).State = EntityState.Added;
            _context.SaveChanges();
            return speaker;
        }

        public Speaker Update(Speaker speaker)
        {
            _context.Attach(speaker).State = EntityState.Modified;
            _context.SaveChanges();
            return speaker;
        }

        public Speaker Delete(int id)
        {
            Speaker speaker = ReadById(id);
            _context.Attach(speaker).State = EntityState.Deleted;
            _context.SaveChanges();
            return speaker;
        }

        public Speaker ReadById(int id)
        {
            return _context.Speakers.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Speaker> ReadAll()
        {
            return _context.Speakers;
        }
    }
}

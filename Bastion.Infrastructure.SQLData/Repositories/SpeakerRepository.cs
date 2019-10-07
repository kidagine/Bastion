using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bastion.Core.Entity;
using Bastion.Core.DomainService;

namespace Bastion.Infrastructure.SQLData.Repositories
{
    public class SpeakerRepository : ISpeakerRepository
    {
        private readonly BastionContext _context;


        public SpeakerRepository(BastionContext context)
        {
            _context = context;
        }

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

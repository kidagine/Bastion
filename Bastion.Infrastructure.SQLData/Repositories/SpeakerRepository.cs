using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bastion.Core.Entity;
using Bastion.Core.DomainService;
using Bastion.Core.Entity.Filtering;

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

		public IEnumerable<Speaker> ReadAll(Filter filter = null)
		{
			if (filter.SpeakerType == SpeakerType.All)
			{
				if (filter.CurrentPage != 0 && filter.ItemsPerPage != 0)
				{
					return _context.Speakers.Skip((filter.CurrentPage - 1) * filter.ItemsPerPage).Take(filter.ItemsPerPage);
				}
				else
				{
					return _context.Speakers;
				}
			}
			else
			{
				if (filter.CurrentPage != 0 && filter.ItemsPerPage != 0)
				{
					return _context.Speakers.Where(s => s.SpeakerType == filter.SpeakerType).Skip((filter.CurrentPage - 1) * filter.ItemsPerPage).Take(filter.ItemsPerPage);
				}
				else
				{
					return _context.Speakers.Where(s => s.SpeakerType == filter.SpeakerType);
				}
			}
		}
	}
}

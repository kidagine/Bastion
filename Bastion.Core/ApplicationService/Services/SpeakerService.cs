using System.Linq;
using System.Collections.Generic;
using Bastion.Core.Entity;
using Bastion.Core.DomainService;

namespace Bastion.Core.ApplicationService.Services
{
    class SpeakerService : ISpeakerService
    {
        private readonly ISpeakerRepository _speakerRepository;


        public SpeakerService(ISpeakerRepository speakerRepository)
        {
            _speakerRepository = speakerRepository;
        }

        public Speaker New(string name, double price, ColorType color)
        {
            Speaker speaker = new Speaker() { Name = name, Price = price, Color = color };
            return speaker;
        }

        public Speaker Create(Speaker speaker)
        {
            return _speakerRepository.Create(speaker);
        }

        public Speaker Update(Speaker speaker)
        {
            return _speakerRepository.Update(speaker);
        }

        public Speaker Delete(int id)
        {
            return _speakerRepository.Delete(id);
        }

        public Speaker ReadById(int id)
        {
            return _speakerRepository.ReadById(id);
        }

        public List<Speaker> ReadAll()
        {
            return _speakerRepository.ReadAll().ToList();
        }
    }
}

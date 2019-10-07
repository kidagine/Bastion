using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Bastion.Core.Entity;
using Bastion.Core.DomainService;

namespace Bastion.Core.ApplicationService.Services
{
    public class SpeakerService : ISpeakerService
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
            if (speaker.Id != default)
            {
                throw new NotSupportedException($"The speaker id should not be specified");
            }
            else if (string.IsNullOrEmpty(speaker.Name))
            {
                throw new InvalidDataException("You need to specify the speaker's name");
            }
            else if (speaker.Price == default)
            {
                throw new InvalidDataException("You need to specify the speaker's price");
            }
            return _speakerRepository.Create(speaker);
        }

        public Speaker Update(Speaker speaker)
        {
            if (string.IsNullOrEmpty(speaker.Name))
            {
                throw new InvalidDataException("You need to specify the speaker's name");
            }
            else if (speaker.Price == default)
            {
                throw new InvalidDataException("You need to specify the speaker's price");
            }
            return _speakerRepository.Update(speaker);
        }

        public Speaker Delete(int id)
        {
            Speaker speaker = _speakerRepository.ReadById(id);
            if (speaker == null)
            {
                throw new NullReferenceException($"The speaker with Id: {id} does not exist");
            }
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


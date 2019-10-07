using Bastion.Core.Entity;
using System.Collections.Generic;

namespace Bastion.Core.DomainService
{
    public interface ISpeakerRepository
    {
        Speaker Create(Speaker speaker);
        Speaker Update(Speaker speaker);
        Speaker Delete(int id);
        Speaker ReadById(int id);
        IEnumerable<Speaker> ReadAll();
    }
}

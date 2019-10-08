using System.Collections.Generic;
using Bastion.Core.Entity;
using Bastion.Core.Entity.Filtering;

namespace Bastion.Core.DomainService
{
    public interface ISpeakerRepository
    {
        Speaker Create(Speaker speaker);
        Speaker Update(Speaker speaker);
        Speaker Delete(int id);
        Speaker ReadById(int id);
        IEnumerable<Speaker> ReadAll(Filter filter = null);
    }
}

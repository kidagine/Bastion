using System.Collections.Generic;
using Bastion.Core.Entity;
using Bastion.Core.Entity.Filtering;

namespace Bastion.Core.ApplicationService
{
    public interface ISpeakerService
    {
        Speaker New(string name, double price, ColorType color);
        Speaker Create(Speaker speaker);
        Speaker Update(Speaker speaker);
        Speaker Delete(int id);
        Speaker ReadById(int id);
        List<Speaker> ReadAll(Filter filter = null);
    }
}

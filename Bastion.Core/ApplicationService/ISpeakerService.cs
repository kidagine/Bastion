using System.Collections.Generic;
using Bastion.Core.Entity;

namespace Bastion.Core.ApplicationService
{
    interface ISpeakerService
    {
        Speaker New(string name, double price, ColorType color);
        Speaker Create(Speaker speaker);
        Speaker Update(Speaker speaker);
        Speaker Delete(int id);
        Speaker ReadById(int id);
        List<Speaker> ReadAll();
    }
}

using HomeApp.Data.Models;
using System.Linq;
using System.Collections.Generic;

namespace HomeApp.Data.InterFaces
{
    public interface IAllAppls
    {
        IEnumerable<Appl> Appls { get; }
        IEnumerable<Appl> getFavAppls { get; set; }
        Appl getObjectAppl(int applId);
    }
}

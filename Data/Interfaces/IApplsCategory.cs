using HomeApp.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace HomeApp.Data.InterFaces
{
    public interface IApplsCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}

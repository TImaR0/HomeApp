using HomeApp.Data.InterFaces;
using HomeApp.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace HomeApp.Data.Mocks
{
    public class MockCategorycs : IApplsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Холодильники", desk = "Холодильники для вашого дому"},
                    new Category {categoryName = "Пральні машини", desk = "Пральні машини для зручного прання"},
                    
                };  
            }
        }
    }
}

using HomeApp.Data.InterFaces;
using HomeApp.Data.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace HomeApp.Data.Mocks
{
    public class MockAppl : IAllAppls
    {
        private readonly IApplsCategory _categoryTehn = new MockCategorycs();
        public IEnumerable<Appl> Tehns
        {


            get
            {
                return new List<Appl>
                {
                    new Appl
                    {name = "Холодильник SAMSUNG RB38T676FB1",
                        shortDesc = "Холодильник для вашого дому",
                        longDesc = "Має приємний чорний колір та з широким функціоналом можливостей.",
                        img = "https://files.foxtrot.com.ua/PhotoNew/img_0_142_5108_0.jpg",
                        price = 17999,
                        isFavourite = true,
                        available = true,
                        Category = _categoryTehn.AllCategories.First()
                    },

                    new Appl
                    {name = "Холодильник LG GW-B509SMUM",
                        shortDesc = "Холодильник для вашого дому",
                        longDesc = "Холодильник срібного кольору та з широким фунціоналом можливостей.",
                        img = "https://cdn.comfy.ua/media/catalog/product/cache/4/image/600x/9df78eab33525d08d6e5fb8d27136e95/0/2/02_gw-b509smum_front_inverter_thinq.jpg",
                        price = 12999,
                        isFavourite = false,
                        available = true,
                        Category = _categoryTehn.AllCategories.First()
                    },
                    new Appl
                    {name = "Пральна машина LG F2V9GW9P",
                        shortDesc = "Зручна пральна машина",
                        longDesc = "Має сірий колір та широкий вибір режимів.",
                        img = "https://cdn.27.ua/499/4e/05/1199621_2.jpeg",
                        price = 10999,
                        isFavourite = false,
                        available = false,
                        Category = _categoryTehn.AllCategories.Last()
                    },

                    new Appl
                    {name = "Пральна машина SAMSUNG WW80R42LHFXDUA",
                        shortDesc = "Зручна пральна машина",
                        longDesc = "Пральна машина чорного кольору та з великим вибором функцій.",
                        img = "https://cdn.27.ua/499/0e/ae/1117870_34.jpeg",
                        price = 14999,
                        isFavourite = true,
                        available = true,
                        Category = _categoryTehn.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Appl> Appls => throw new System.NotImplementedException();

        public IEnumerable<Appl> getFavAppls { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Appl getObjectAppl(int applId)
        {
            throw new System.NotImplementedException();
        }
    }
}
       

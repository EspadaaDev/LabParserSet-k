using System;
using System.Collections.Generic;
using System.Text;

namespace LabParserSet_k.Core.SETK
{
    class ProductCatalog
    {
        // Поля
        public string Name { get; }
        public string Link { get; }

        // Подкотегории - каталоги товаров
        public List<ProductCatalog> productCatalogs { get; }       

        // Конструкторы класса
        public ProductCatalog(string name, string link) {
            Name = name;
            Link = link;
        }
        // Конструктор класса, применяемый, если имеются подкатегории у каталога
        public ProductCatalog(string name, string link, List<ProductCatalog> prodCatalog) {
            Name = name;
            Link = link;
            productCatalogs = prodCatalog;
        }        
    }
}

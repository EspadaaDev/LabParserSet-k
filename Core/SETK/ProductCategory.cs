namespace LabParserSet_k.Core.SETK
{
    /// <summary>
    /// Класс описывает большие категории товаров, 
    /// содержащие подкотегории - каталоги товаров.
    /// </summary>
    class ProductCategory
    {
        // Поля класса ProductCategory - - - - - - - - -

        // Название большой категории - свойство
        public string Name { get; }
        // Подкотегории - каталоги товаров
        public ProductCatalog[] productCatalogs { get; }

        // Конструктор класса
        public ProductCategory(string name, params ProductCatalog[] ProductCatalogs) {
            Name = name;
            productCatalogs = ProductCatalogs;
        }
    }
}

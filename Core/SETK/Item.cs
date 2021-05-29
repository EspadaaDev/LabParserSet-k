namespace LabParserSet_k.Core.SETK
{
    class Item
    {
        // Поля - - - - - - - - - - - - -
        // Название товара
        public string Name { get; }
        // Стоимость товара
        public string Cost { get; }
        // Ссылка на страницу товара
        public string Link { get; }
        // Ссылка на изображение товара
        public string ImageLink { get; }        
        // Конструктор
        public Item(string name, string cost, string link, string imageLink) {
            Name = name;
            Cost = cost;
            Link = link;
            ImageLink = imageLink;
        }
    }
}

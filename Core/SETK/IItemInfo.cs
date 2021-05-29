namespace LabParserSet_k.Core.SETK { 
    interface IItemInfo
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
    }
}

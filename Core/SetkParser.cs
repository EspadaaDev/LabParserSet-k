using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using LabParserSet_k.Core.SETK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace LabParserSet_k.Core
{
    class SetkParser
    {
        // Загрузчик html-документов
        HtmlLoader htmlLoader;

        /* - - - ОСНОВНЫЕ МЕТОДЫ - - - */
        // Функция, возвращающая список категорий товаров
        public async Task<List<ProductCategory>> GetProductCategories() {
            // ПЕРЕМЕННЫЕ
            // Список всех категорий
            List<ProductCategory> allCategories = new List<ProductCategory>();
            // HTML-документ главной страницы
            var document = await htmlLoader.GetSourceByPage("https://set-k.ru/");

            var aElement = document.QuerySelectorAll("main > section > ul > li > a");

            // Большой каталог
            foreach (var child in aElement) {
                // Если класс родительского элемента равен has_sub
                if (child.ParentElement.ClassName == "has_sub") {
                    // Добавить большую категорию
                    allCategories.Add(new ProductCategory(
                    // Название большой категории
                    child.TextContent,
                    // Добавляем подкатегории категории
                    GetCatalogs(child)
                    ));
                }
            }
            return allCategories;
        }

        // Функция, возвращающая список товаров товаров
        public async Task<List<Item>> GetItemsFromUri(string uri) {
            // Все товары, возвращаемая переменная
            List<Item> allItems = new List<Item>();
            // Документ
            IHtmlDocument document = await htmlLoader.GetSourceByPage(uri);

            var aElement = document.QuerySelectorAll("div")
                .Where(item => item.ClassName != null && item.ClassName.Contains("product-row")
                && item.ParentElement.ClassName.Contains("products"));

            foreach (var child in aElement) {
                // Название товара
                var name = child.QuerySelectorAll("a > div").Where(item => item.ClassName != null
                && item.ClassName.Contains("h3") && item.ParentElement.ParentElement.ClassName.Contains("product-row"))
                .FirstOrDefault().TextContent.Replace("\n", "").Replace("\t", "").Replace("  ", "");

                // Стоимость
                var cost = child.QuerySelectorAll("a > p > span").Where(item =>
                item.ParentElement.ClassName.Contains("price"))
                .FirstOrDefault().TextContent;

                // Ссылка на товар
                var link = "https://set-k.ru" + child.QuerySelectorAll("a").Where(item => item.ClassName.Contains("linkHov link--slide")
                 && item.ParentElement.ClassName.Contains("product-row")).FirstOrDefault().GetAttribute("href");

                // Ссылка на изображение товара
                var linkOnImage = "https://set-k.ru" + child.QuerySelectorAll("a > div").Where(item => item.ClassName != null
                 && item.ClassName.Contains("img") && item.ParentElement.ParentElement.ClassName.Contains("product-row"))
                 .FirstOrDefault().GetAttribute("style").Replace(")", "").Split(new char[] { '(' },
                 StringSplitOptions.RemoveEmptyEntries)[1];

                // Добавляем товар
                allItems.Add(new Item(name, cost, link, linkOnImage));
            }
            return allItems;
        }

        // Функция, возвращающая список:
        // производитель, базвая единица, вес, объем, наличие, подробное описание
        public async Task<List<string>> GetItemInformation(string uri) {
            List<string> allInfo = new List<string>();
            // Загружаем html страницы товара
            IHtmlDocument document = await htmlLoader.GetSourceByPage(uri);
            // Парсим информацию
            var aElement = document.QuerySelectorAll("div > ul > li > span");

            foreach (var child in aElement) {
                allInfo.Add(child.TextContent);
            }

            // Парсим наличие
            var bElement = document.QuerySelectorAll("div > span").Where(item => item.ParentElement.ClassName == "product-inner__instock");

            foreach (var child in bElement) {
                allInfo.Add(child.TextContent);
            }

            // Парсим описание
            bElement = document.QuerySelectorAll("div").Where(item => item.ClassName == "contentBlock" && item.ParentElement.Id == "content_1");
            foreach (var child in bElement) {
                allInfo.Add(child.TextContent);
            }

            return allInfo;
        }

        /* - - - ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ - - - */
        // Получить подкатегории большой категории (так же если у подкатегории есть подкатегории,
        // они добавляются соответственно
        private ProductCatalog[] GetCatalogs(IElement child) {
            List<ProductCatalog> productCatalogs = new List<ProductCatalog>();

            var aElement = child.ParentElement.QuerySelectorAll("ul > li > a");

            foreach (var item in aElement) {
                if (item.ParentElement.ParentElement.ParentElement.ClassName == child.ParentElement.ClassName) {
                    // Добавляем подкатегорию
                    ProductCatalog tempPC = new ProductCatalog(
                        // Название категории
                        item.TextContent,
                        // Ссылка на категорию и товары
                        "https://set-k.ru" + item.GetAttribute("href") + "?page=3&SHOWALL_2=1"
                        );
                    // Добавлем подкатегории подкатегории, если таковые имеются
                    if (item.ParentElement.QuerySelectorAll("ul").Count() > 0) {
                        var tempElement = item.ParentElement.QuerySelectorAll("ul > li > a");
                        foreach (var kid in tempElement) {
                            // Проверка по имени класса родителя
                            if (kid.ParentElement.ParentElement.ClassName.Contains("lvl-3")) {
                                // Добавляем подкатегорию подкатегории
                                tempPC.productCatalogs.Add(new ProductCatalog(
                                    // Имя
                                    kid.TextContent,
                                    // Ссылка
                                    "https://set-k.ru" + kid.GetAttribute("href") + "?page=3&SHOWALL_2=1"
                                    ));
                            }
                        }
                    }
                    productCatalogs.Add(tempPC);
                }
            }
            return productCatalogs.ToArray();
        }



        // Конструктор
        public SetkParser() {
            htmlLoader = new HtmlLoader();
        }
    }
}

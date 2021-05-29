using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using LabParserSet_k.Core.SETK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabParserSet_k.Core {
    class SetkParser {
        // Поля
        HtmlLoader htmlLoader;

        /* ОСНОВНЫЕ МЕТОДЫ */
        // Функция, возвращающая список категорий товаров
        public async Task<List<ProductCategory>> GetProductCategories() {
            // ПЕРЕМЕННЫЕ
            // Список всех категорий
            List<ProductCategory> allCategories = new List<ProductCategory>();
            // HTML-документ главной страницы
            var document = await htmlLoader.GetSourceByPage("https://set-k.ru/");

            var aElement = document.QuerySelectorAll("main > section > ul > li > a");
            // .Where(item => item.ParentElement.ClassName == "has_sub") ;
            // Большой каталог
            foreach (var child in aElement) {
                if (child.ParentElement.ClassName == "has_sub") {
                    allCategories.Add(new ProductCategory(
                    child.TextContent,
                    GetCatalogs(child)
                    ));                    
                }
            }
            // Получение списка категорий


            return allCategories;
        }
        // Получить подкаталоги
        private ProductCatalog[] GetCatalogs(IElement child) {
            List<ProductCatalog> productCatalogs = new List<ProductCatalog>();

            var aElement = child.ParentElement.QuerySelectorAll("ul > li > a");

            foreach (var item in aElement) {
                if (item.ParentElement.ParentElement.ParentElement.ClassName == child.ParentElement.ClassName) {
                    ProductCatalog tempPC = new ProductCatalog(
                        item.TextContent,
                        item.GetAttribute("href")
                        );
                    if (item.ParentElement.("ul")) {
                       // tempPC.productCatalogs = GetCatalogs(item).ToList();
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

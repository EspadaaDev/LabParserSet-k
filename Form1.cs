using LabParserSet_k.Core;
using LabParserSet_k.Core.SETK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabParserSet_k
{
    public partial class Form1 : Form
    {
        // Поля
        // Экземпляр класса SetkParser - парсер магазина СЕТКА
        SetkParser parser;
        // Список всех категорий
        List<ProductCategory> productCategories;
        // Выбрана ли подкатегория
        bool podcategorySelected;
        // Список товаров выбранной категории
        List<Item> items;
        List<Item> showedItems;

        // Товары - - -
        // Изображение товара
        Image ItemImage;
        // Производитель
        string Manufacturer;
        // Базовая единица
        string BaseUnit;
        // Вес
        string Weight;



        // Проверка подключения к интернету
        public bool CheckForInternetConnection() {
            try {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com")) {                    
                    return true;
                    
                }
            }
            catch {
                this.Hide();
                DialogResult result = MessageBox.Show(
                    "Нет подключения к сети!",
                    "Подключение к интернету...",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );
                if (result == DialogResult.Retry) return CheckForInternetConnection();
                if (result == DialogResult.Cancel) return false;
                return false;
            }
        }
        // Конструктор
        public Form1() {
            InitializeComponent();
        }
        // Загрузка формы
        private void Form1_Load(object sender, EventArgs e) {
            // Проверяем подключение к интернету
            if (!CheckForInternetConnection()) 
            {
                Application.Exit();
            }
            else {
                parser = new SetkParser();
                Loading();
                podcategorySelected = false;     
            }
        }
        private async void Loading() {
            productCategories = await parser.GetProductCategories();
            for (int i = 0; i < productCategories.Count; i++) {
                cbox_catalog.Items.Add(productCategories[i].Name);
            }
        }

        // Выпадающий список – "КАТАЛОГ"
        // Выбран элемент
        private void cbox_catalog_SelectedIndexChanged(object sender, EventArgs e) {
            // Отключение кнопки показать
            btn_showItems.Enabled = false;
            // Очищаем каталог
            cbox_category.Items.Clear();
            cbox_category.Text = "";
            cbox_category.Enabled = true;
            // Очищаем и блокируем подкатегории
            cbox_podcategory.Text = "";
            cbox_podcategory.Enabled = false;
            podcategorySelected = false;

            for (int i = 0; i < productCategories[cbox_catalog.SelectedIndex].productCatalogs.Length; i++) {
                cbox_category.Items.Add(productCategories[cbox_catalog.SelectedIndex].productCatalogs[i].Name);
            }
        }

        // Выпадающий список – "КАТЕГОРИЯ"
        // Выбран элемент
        private void cbox_category_SelectedIndexChanged(object sender, EventArgs e) {
            // Очистка подкатегории
            cbox_podcategory.Items.Clear();
            cbox_podcategory.Text = "";
            podcategorySelected = false;
            //
            if (productCategories[cbox_catalog.SelectedIndex].
                productCatalogs[cbox_category.SelectedIndex].productCatalogs.Count > 0) {
                cbox_podcategory.Enabled = true;
                for (int i = 0; i < productCategories[cbox_catalog.SelectedIndex].
                productCatalogs[cbox_category.SelectedIndex].productCatalogs.Count; i++) {
                    cbox_podcategory.Items.Add(productCategories[cbox_catalog.SelectedIndex].
                    productCatalogs[cbox_category.SelectedIndex].productCatalogs[i].Name);
                }
            }
            else {
                cbox_podcategory.Enabled = false;
            }
            btn_showItems.Enabled = true;
        }
        // Выпадающий список – "ПОДКАТЕГОРИЯ"
        // Выбран элемент
        private void cbox_podcategory_SelectedIndexChanged(object sender, EventArgs e) {
            podcategorySelected = true;
        }
        // Кнопка "ПОКАЗАТЬ"
        // Клик
        private async void btn_showItems_Click(object sender, EventArgs e) {
            btn_showItems.Enabled = false;
            if (CheckForInternetConnection()) {
                // Загрузка предметов
                if (podcategorySelected) {
                    items = await parser.GetItemsFromUri(productCategories[cbox_catalog.SelectedIndex]
                        .productCatalogs[cbox_category.SelectedIndex].productCatalogs[cbox_podcategory.SelectedIndex].Link);
                }
                else {
                    items = await parser.GetItemsFromUri(productCategories[cbox_catalog.SelectedIndex]
                        .productCatalogs[cbox_category.SelectedIndex].Link);
                }
                DgvReload();
            }
            btn_showItems.Enabled = true;
        }

        // Обновить таблицу с товарами
        private void DgvReload() {
            dgv_itemsTable.Rows.Clear();
            showedItems = new List<Item>();
            for (int i = 0; i < items.Count; i++) {
                showedItems.Add(items[i]);
                dgv_itemsTable.Rows.Add(new object[]{
                    i.ToString(),
                    items[i].Name,
                    items[i].Cost                    
                });
            }
        }
        // Таблица с товарами
        // Выбор товара
        private async void dgv_itemsTable_SelectionChanged(object sender, EventArgs e) {
            try {
                if (showedItems != null) {
                    if (dgv_itemsTable.SelectedCells[0].RowIndex < showedItems.Count && dgv_itemsTable.SelectedCells[0].RowIndex >= 0) {
                        itemImage.ImageLocation = showedItems[dgv_itemsTable.SelectedCells[0].RowIndex].ImageLink;
                        List<string> tempInfo = await parser.GetItemInformation(showedItems[dgv_itemsTable.SelectedCells[0].RowIndex].Link);

                        // Цена
                        txt_CostItem.Text = showedItems[dgv_itemsTable.SelectedCells[0].RowIndex].Cost;
                        // Производитель
                        if (tempInfo[0] != "") {
                            txt_manufacturer.Text = tempInfo[0];
                        }
                        else {
                            txt_manufacturer.Text = "–";
                        }
                        // Базовая единица
                        txt_baseUnit.Text = tempInfo[1];
                        // Вес
                        txt_weight.Text = tempInfo[2];
                        // Объем
                        txt_volume.Text = tempInfo[3];
                        // Наличие
                        label11.Text = tempInfo[4];
                        // Описание
                        txtb_ItemInfo.Text = tempInfo[5];
                    }

                }
            }
            catch {
                
            }
        }
    }
}

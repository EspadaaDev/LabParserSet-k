using LabParserSet_k.Core;
using LabParserSet_k.Core.SETK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabParserSet_k {
    public partial class Test : Form {
        SetkParser parser;
        List<ProductCategory> productCategories;
        List<Item> items;
        public Test() {
            InitializeComponent();
            parser = new SetkParser();
        }

        private async void button1_Click(object sender, EventArgs e) {
            items = await parser.GetItemsFromUri("https://set-k.ru/catalog/vse_dlya_doma/sistemy_khraneniya_i_poryadok_v_dome/?SHOWALL_2=1");
            listBox1.Items.Add(items.Count.ToString());
        }
    }
}

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
        public Test() {
            InitializeComponent();
            parser = new SetkParser();
        }

        private async void button1_Click(object sender, EventArgs e) {
            productCategories = await parser.GetProductCategories();
            listBox1.Items.Add(productCategories.Count.ToString());
        }
    }
}

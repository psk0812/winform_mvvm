﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_mvvm
{
    

    public partial class Form1 : Form
    {
        private CustomerViewModel vm;

        public Form1()
        {
            InitializeComponent();
            vm = new CustomerViewModel();
            vm.CustomerBindingSource = customersBindingSource;

            this.Load += delegate { vm.Load(); };
            btnNew.Click += delegate { vm.New(); };
            btnDelete.Click += delegate { vm.Delete(); };
            btnSave.Click += delegate { vm.Save(); };
            this.FormClosing += delegate { vm.Dispose(); };
        }
    }
}

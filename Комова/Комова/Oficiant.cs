﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Комова
{
    public partial class Oficiant : Form
    {
        public Oficiant(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        public SqlConnection con;
    }
}

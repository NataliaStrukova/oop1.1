using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oop1._1
{
    public partial class FormSubList : Form
    {
        public FormSubList(string[] s)
        {
            InitializeComponent();
            textBoxSubList.Lines = s;
        }
    }
}

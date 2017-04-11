using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ListLib;

namespace oop1._1
{
    public partial class UserControlStr : UserControl
    {
        IList<string> list;
        public delegate void PrintDelegate();
        PrintDelegate print;
        short sort;
        public UserControlStr(IList<string> list, PrintDelegate pd)
        {
            InitializeComponent();
            this.list = list;
            print = pd;
            radioButtonAlph1.Checked = true;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            try
            {
                ListUtils.Sort(list, (x, y) => sort * x.CompareTo(y));
                print();
            }
            catch (ListException le)
            {
                MessageBox.Show(le.Message);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int num;
            string s = textBoxLetter.Text;
            if(Int32.TryParse(textBoxNumber.Text, out num) && num >-1 && s.Length == 1)
            {
                char ch = s[0];
                s = ListUtils.Find<string>(list, (x) => (x.Length >= num + 1 && ch.Equals(x[num])));
                if (s == default(string))
                    labelCheckRes.Text = "Not Found";
                else
                    labelCheckRes.Text = s;
            }
        }

        private void buttonFindLast_Click(object sender, EventArgs e)
        {
            int num;
            string s = textBoxLetter.Text;
            if (Int32.TryParse(textBoxNumber.Text, out num) && num > -1 && s.Length == 1)
            {
                char ch = s[0];
                s = ListUtils.FindLast<string>(list, (x) => (x.Length >= num + 1 && ch.Equals(x[num])));
                if (s == default(string))
                    labelCheckRes.Text = "Not Found";
                else
                    labelCheckRes.Text = s;
            }
        }

        private void buttonFindIndex_Click(object sender, EventArgs e)
        {
            int num;
            int index;
            string s = textBoxLetter.Text;
            if (Int32.TryParse(textBoxNumber.Text, out num) && num > -1 && s.Length == 1)
            {
                char ch = s[0];
                index = ListUtils.FindIndex<string>(list, (x) => (x.Length >= num + 1 && ch.Equals(x[num])));
                if (index == -1)
                    labelCheckRes.Text = "Not Found";
                else
                    labelCheckRes.Text = index.ToString();
            }
        }

        private void buttonFindLastIndex_Click(object sender, EventArgs e)
        {
            int num;
            int index;
            string s = textBoxLetter.Text;
            if (Int32.TryParse(textBoxNumber.Text, out num) && num > -1 && s.Length == 1)
            {
                char ch = s[0];
                index = ListUtils.FindLastIndex<string>(list, (x) => (x.Length >= num + 1 && ch.Equals(x[num])));
                if (index == -1)
                    labelCheckRes.Text = "Not Found";
                else
                    labelCheckRes.Text = index.ToString();
            }
        }

        private void buttonFindAll_Click(object sender, EventArgs e)
        {
            IList<string> result;
            int num;
            string s = textBoxLetter.Text;
            if (Int32.TryParse(textBoxNumber.Text, out num) && num > -1 && s.Length == 1)
            {
                char ch = s[0];
                result = ListUtils.FindAll<string>(list, (x) => (x.Length >= num + 1 && ch.Equals(x[num])), () => new ArrayList<string>());
                FormSubList formSL = new FormSubList(ListToArr<string>(result));
                formSL.ShowDialog();
            }
        }

        private void buttonExists_Click(object sender, EventArgs e)
        {
            int num;
            string s = textBoxLetter.Text;
            if (Int32.TryParse(textBoxNumber.Text, out num) && num > -1 && s.Length == 1)
            {
                char ch = s[0];
                labelCheckRes.Text = ListUtils.Exists<string>(list, (x) => (x.Length >= num + 1 && ch.Equals(x[num]))).ToString();
            }
        }

        private void buttonCheckForAll_Click(object sender, EventArgs e)
        {
            int num;
            string s = textBoxLetter.Text;
            if (Int32.TryParse(textBoxNumber.Text, out num) && num > -1 && s.Length == 1)
            {
                char ch = s[0];
                labelCheckRes.Text = ListUtils.CheckForAll<string>(list, (x) => (x.Length >= num + 1 && ch.Equals(x[num]))).ToString();
            }
        }

        private void radioButtonAlph1_CheckedChanged(object sender, EventArgs e)
        {
            Int16.TryParse(((RadioButton)sender).Tag.ToString(), out sort);
        }

        private void buttonConvertAll_Click(object sender, EventArgs e)
        {
            IList<int> result = ListUtils.ConvertAll<string, int>(list,
                (inp) => { int outp; if (Int32.TryParse(inp, out outp)) return outp; else return 0; },
                () => new ArrayList<int>());
            FormSubList formSL = new FormSubList(ListToArr<int>(result));
            formSL.ShowDialog();
        }

        private string[] ListToArr<T>(IList<T> list)
        {
            int count = list.Count;
            string[] s = new string[count];
            for (int i = 0; i < count; i++)
                s[i] = list[i].ToString();
            return s;
        }

    }
}

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
    public partial class UserControlInt : UserControl
    {
        IList<int> list;
        public delegate void PrintDelegate();
        PrintDelegate print;
        short sort;
        public UserControlInt(IList<int> list, PrintDelegate pd)
        {
            InitializeComponent();
            this.list = list;
            print = pd;
            radioButtonAscending.Checked = true;
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
            int divisor;
            int res;
            if (Int32.TryParse(textBoxDivisor.Text, out divisor) && divisor != 0)
            {
                res = ListUtils.Find<int>(list, (x) => (x % divisor == 0));
                if (res == default(int) && !list.Contains(default(int)))
                    labelCheckRes.Text = "Not Found";
                else
                    labelCheckRes.Text = res.ToString();
            }
        }

        private void buttonFindLast_Click(object sender, EventArgs e)
        {
            int divisor;
            int res;
            if (Int32.TryParse(textBoxDivisor.Text, out divisor) && divisor != 0)
            {
                res = ListUtils.FindLast<int>(list, (x) => (x % divisor == 0));
                if (res == default(int) && !list.Contains(default(int)))
                    labelCheckRes.Text = "Not Found";
                else
                    labelCheckRes.Text = res.ToString();
            }
        }

        private void buttonFindIndex_Click(object sender, EventArgs e)
        {
            int divisor;
            int res;
            if (Int32.TryParse(textBoxDivisor.Text, out divisor) && divisor != 0)
            {
                res = ListUtils.FindIndex<int>(list, (x) => (x % divisor == 0));
                if (res == -1)
                    labelCheckRes.Text = "Not Found";
                else
                    labelCheckRes.Text = res.ToString();
            }
        }

        private void buttonFindLastIndex_Click(object sender, EventArgs e)
        {
            int divisor;
            int res;
            if (Int32.TryParse(textBoxDivisor.Text, out divisor) && divisor != 0)
            {
                res = ListUtils.FindLastIndex<int>(list, (x) => (x % divisor == 0));
                if (res == -1)
                    labelCheckRes.Text = "Not Found";
                else
                    labelCheckRes.Text = res.ToString();
            }
        }

        private void buttonExists_Click(object sender, EventArgs e)
        {
            int divisor;
            if (Int32.TryParse(textBoxDivisor.Text, out divisor) && divisor != 0)
                labelCheckRes.Text = ListUtils.Exists<int>(list, (x) => (x % divisor == 0)).ToString();
        }

        private void buttonCheckForAll_Click(object sender, EventArgs e)
        {
            int divisor;
            if (Int32.TryParse(textBoxDivisor.Text, out divisor) && divisor != 0)
                labelCheckRes.Text = ListUtils.CheckForAll<int>(list, (x) => (x % divisor == 0)).ToString();
        }

        private void buttonFindAll_Click(object sender, EventArgs e)
        {
            IList<int> result;
            int divisor;
            if (Int32.TryParse(textBoxDivisor.Text, out divisor) && divisor != 0)
            {
                result = ListUtils.FindAll<int>(list, (x) => ((x % divisor == 0)), () => new ArrayList<int>());
                int count = result.Count;
                string[] ArrResult = new string[count];
                for (int i = 0; i < count; i++)
                    ArrResult[i] = result[i].ToString();
                FormSubList formSL = new FormSubList(ArrResult);
                formSL.ShowDialog();
            }
        }

        private void radioButtonSort_CheckedChanged(object sender, EventArgs e)
        {
            Int16.TryParse(((RadioButton)sender).Tag.ToString(), out sort);
        }
    }
}

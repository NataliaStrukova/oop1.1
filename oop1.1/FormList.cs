using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ListLib;

namespace oop1._1
{
    public partial class FormList : Form
    {
        IList<string> listString;
        IList<int> listInt;
        short listType, dataType;
        public FormList()
        {
            InitializeComponent();
            radioButtonArrayList.Checked = true;
            radioButtonString.Checked = true;
            listType = 0;
            dataType = 3;
            ChangeControls();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                switch (dataType)
                {
                    case 3: listString.Add(textBoxValue.Text); break;
                    case 4:
                        int value;
                        if (Int32.TryParse(textBoxValue.Text, out value))
                            listInt.Add(value);
                        break;
                }
                PrintList();
            }
            catch (ListException le)
            {
                MessageBox.Show(le.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                switch (dataType)
                {
                    case 3: listString.Clear(); break;
                    case 4: listInt.Clear(); break;
                }
                PrintList();
            }
            catch (ListException le)
            {
                MessageBox.Show(le.Message);
            }
        }

        private void buttonIndexOf_Click(object sender, EventArgs e)
        {
            switch (dataType)
            {
                case 3:
                    labelResult.Text = listString.IndexOf(textBoxValue.Text).ToString();
                    break;
                case 4:
                    int value;
                    if (Int32.TryParse(textBoxValue.Text, out value))
                        labelResult.Text = listInt.IndexOf(value).ToString();
                    break;
            }
        }

        private void ChangeControls()
        {
            switch (dataType)
            {
                case 3:
                    listInt = null;
                    panelControls.Controls.Clear();
                    UserControlStr ucStr = new UserControlStr(listString, () => PrintList());
                    panelControls.Controls.Add(ucStr);
                    break;
                case 4:
                    listString = null;
                    panelControls.Controls.Clear();
                    UserControlInt ucInt = new UserControlInt(listInt, () => PrintList());
                    panelControls.Controls.Add(ucInt);
                    break;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            switch (listType)
            {
                case 0:
                    switch (dataType)
                    {
                        case 3:
                            listString = new ArrayList<string>();
                            labelListType.Text = "ArrayList<string>";
                            break;
                        case 4:
                            listInt = new ArrayList<int>();
                            labelListType.Text = "ArrayList<int>";
                            break;
                    }
                    break;
                case 1:
                    switch (dataType)
                    {
                        case 3:
                            listString = new LinkedList<string>();
                            listInt = null;
                            labelListType.Text = "LinkedList<string>";
                            break;
                        case 4:
                            listInt = new LinkedList<int>();
                            listString = null;
                            labelListType.Text = "LinkedList<int>";
                            break;
                    }
                    break;
                case 2:
                    if (listString != null)
                    {
                        listString = new UnmutableList<string>(listString);
                        dataType = 3;
                        radioButtonString.Checked = true;
                        labelListType.Text = "UnmutableList<string>";
                    }
                    else
                        if (listInt != null)
                        {
                            listInt = new UnmutableList<int>(listInt);
                            dataType = 4;
                            radioButtonInt.Checked = true;
                            labelListType.Text = "UnmutableList<int>";
                        }
                    break;
            }
            ChangeControls();
            PrintList();
        }


        private void PrintList()
        {
            {
                switch (dataType)
                {
                    case 3: textBoxList.Lines = ListToArr<string>(listString, 0); break;
                    case 4: textBoxList.Lines = ListToArr<int>(listInt, 0); break;
                }

            }
        }


        private void radioButtonDataType(object sender, EventArgs e)
        {
            Int16.TryParse(((RadioButton)sender).Tag.ToString(), out dataType);
        }

        private void radioButtonListType(object sender, EventArgs e)
        {
            Int16.TryParse(((RadioButton)sender).Tag.ToString(), out listType);
        }


        private void buttonExists_Click(object sender, EventArgs e)
        {
            ListUtils.CheckDelegate<string> d = s => (s[0] == 'a');
            labelResult.Text = ListUtils.Exists<string>(listString, d).ToString();
        }

        private void buttonContains_Click(object sender, EventArgs e)
        {
            switch (dataType)
            {
                case 3:
                    labelResult.Text = listString.Contains(textBoxValue.Text).ToString();
                    break;
                case 4:
                    int value;
                    if (Int32.TryParse(textBoxValue.Text, out value))
                        labelResult.Text = listInt.Contains(value).ToString();
                    break;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int index;
            int value;
            try
            {
                switch (dataType)
                {
                    case 3:
                        if (Int32.TryParse(textBoxIndex.Text, out index))
                            listString.Insert(index, textBoxValue.Text);
                        break;
                    case 4:
                        if (Int32.TryParse(textBoxValue.Text, out value) && Int32.TryParse(textBoxIndex.Text, out index))
                            listInt.Insert(index, value);
                        break;
                }
                PrintList();
            }
            catch (ListException le)
            {
                MessageBox.Show(le.Message);
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                switch (dataType)
                {
                    case 3: listString.Remove(textBoxValue.Text); break;
                    case 4:
                        int value;
                        if (Int32.TryParse(textBoxValue.Text, out value))
                            listInt.Remove(value);
                        break;
                }
                PrintList();
            }
            catch (ListException le)
            {
                MessageBox.Show(le.Message);
            }
        }

        private void buttonRemoveAt_Click(object sender, EventArgs e)
        {
            int index;
            if (Int32.TryParse(textBoxIndex.Text, out index))
            {
                try
                {
                    switch (dataType)
                    {
                        case 3: listString.RemoveAt(index); break;
                        case 4: listInt.RemoveAt(index); break;
                    }
                    PrintList();
                }
                catch (ListException le)
                {
                    MessageBox.Show(le.Message);
                }
            }
        }

        private void buttonSubList_Click(object sender, EventArgs e)
        {
            int fromIndex, toIndex;
            FormSubList formSubList;
            if (Int32.TryParse(textBoxFromIndex.Text, out fromIndex) && Int32.TryParse(textBoxToIndex.Text, out toIndex))
            {
                try
                {
                    switch (dataType)
                    {
                        case 3:
                            formSubList = new FormSubList(ListToArr<string>(listString.subList(fromIndex, toIndex), fromIndex));
                            formSubList.ShowDialog();
                            break;
                        case 4:
                            formSubList = new FormSubList(ListToArr<int>(listInt.subList(fromIndex, toIndex), fromIndex));
                            formSubList.ShowDialog();
                            break;
                    }
                }
                catch (ListException le)
                {
                    MessageBox.Show(le.Message);
                }
            }
        }

        private string[] ListToArr<T>(IList<T> list, int delta)
        {
            int count = list.Count;
            string[] s = new string[count];
            for (int i = 0; i < count; i++)
                s[i] = (i + delta).ToString() + ". " + list[i].ToString();
            return s;
        }



    }
}

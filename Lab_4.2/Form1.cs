using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lab_4._2
{
    public partial class Form1 : Form
    {
        string path = @"D:\Project\Лабы по ООП\Lab_4.2\Lab_4.2\SaveData.txt";
        Checker checker;

        public Form1()
        {
            InitializeComponent();
            loadFile();
            checker.observer += new System.EventHandler(this.UpdateFromModel);
            checker.Update();
        }

        private void UpdateFromModel(object sender, EventArgs e) //Обновляем все объекты
        {
            textBoxA.Text = checker.getValue(0).ToString();
            textBoxB.Text = checker.getValue(1).ToString();
            textBoxC.Text = checker.getValue(2).ToString();

            numericA.Value = checker.getValue(0);
            numericB.Value = checker.getValue(1);
            numericC.Value = checker.getValue(2);

            trackBarA.Value = checker.getValue(0);
            trackBarB.Value = checker.getValue(1);
            trackBarC.Value = checker.getValue(2);
        }

        public void loadFile() //Загрузка
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                StreamReader reader = new StreamReader(path);
                string tmp = reader.ReadLine();
                List<int> loadlist = new List<int>();
                string[] arr = tmp.Split(' ');
                for (int i = 0; i < arr.Length; i++)
                {
                    loadlist.Add(Int32.Parse(arr[i]));
                }
                checker = new Checker(loadlist);
                reader.Close();
            }
            else
            {
                checker = new Checker(3);
            }
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checker.setValue(Int32.Parse(textBoxA.Text),0);
            }
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checker.setValue(Int32.Parse(textBoxB.Text), 1);
            }
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checker.setValue(Int32.Parse(textBoxC.Text), 2);
            }
        }

        private void numericA_ValueChanged(object sender, EventArgs e)
        {
            checker.setValue((int)(numericA.Value), 0);
        }

        private void numericB_ValueChanged(object sender, EventArgs e)
        {
            checker.setValue((int)(numericB.Value), 1);
        }

        private void numericC_ValueChanged(object sender, EventArgs e)
        {
            checker.setValue((int)(numericC.Value), 2);
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            checker.setValue(trackBarA.Value, 0);
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            checker.setValue(trackBarB.Value, 1);
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            checker.setValue(trackBarC.Value, 2);
        }
    }
}

using System.IO;
using System.Collections.Generic;

namespace Lab_4._2
{
    public class Value
    {
        private int value;

        public Value(int value)
        {
            this.value = value;
        }
        public void setValue(int value)
        {
            this.value = value;
        }
        public int getValue()
        {
            return value;
        }
    }
    public class Checker
    {
        private List<Value> list;

        public System.EventHandler observer;

        public Checker(int size)//Создание
        {
            list = new List<Value>();
            for (int i = 0; i < size; i++)
            {
                list.Add(new Value(0));
            }
        }
        public Checker(List<int> load)//Загрузка из файла
        {
            int size = load[0];
            list = new List<Value>();
            for (int i = 1; i < load.Count; i++)
            {
                list.Add(new Value(load[i]));
            }
        }
        public void setValue(int value, int index) //Внесение значения
        {
            if (value >= 0 && value <= 100)
            {
                if ((index != 0 && index < list.Count - 1) && //Значение находится в середине
                (list[index - 1].getValue() <= value && value <= list[index + 1].getValue())) //Значение меньше следующего и больше предыдущего
                {
                    list[index].setValue(value);
                }
                else if ((index == 0 && list.Count > 1) && value <= list[index + 1].getValue()) //Значение в середине и оно меньше или равно следующему
                {
                    list[index].setValue(value);
                }
                else if (index == list.Count - 1 && list[index - 1].getValue() <= value) //Значение в конце и оно больше или равно предыдущего
                {
                    list[index].setValue(value);
                }
            }

            Update();
            SaveFile(@"D:\Project\Лабы по ООП\Lab_4.2\Lab_4.2\SaveData.txt");
        }
        public int getValue(int index) //Получчение значения
        {
            return list[index].getValue();
        }

        public void SaveFile(string path) //Сохранить
        {
            string saveStr = list.Count.ToString();
            for (int i = 0; i < list.Count; i++)
            {
                saveStr += " ";
                saveStr += list[i].getValue().ToString();
            }
            StreamWriter writer = new StreamWriter(path, false);
            writer.WriteLine(saveStr);
            writer.Close();
        }

        public void Update()
        {
            observer.Invoke(this, null); //Вызов observe
        }
    }
}

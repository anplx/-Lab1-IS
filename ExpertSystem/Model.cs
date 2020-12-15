using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExpertSystem
{
    
    public class Model
    {
        public int Sum;
        Dictionary<int, Configuration> ConfigDict = new Dictionary<int, Configuration>();

        public Configuration[] Config = new Configuration[18];
        
        public Model()
        {
            Sum = 0;

            for (int i =0;i<Config.Length;i++)
            {
                Config[i] = new Configuration();
            }
            
            CreateConfiguration();
        }

        
        public void GetOneQ(String temp)
        {
            switch (temp)
            {
                case "Ноутбук":
                    Sum = Sum + 100;
                    break;
                case "Стационарный ПК":
                    Sum = Sum + 0;
                    break;
            }
        }

        public void GetTwoQ(decimal temp)
        {

            if (temp <= 50000)
                Sum += 10;

            else if (temp <= 90000 && temp > 50000)
                Sum += 20;

            else if (temp > 90000)
                Sum += 30;
       
        }

        public void GetThreeQ(String temp)
        {
            switch (temp)
            {
                case "Программирование":
                    Sum = Sum + 1;
                    break;
                case "Игры":
                    Sum = Sum + 2;
                    break;
                case "Монтаж видео":
                    Sum = Sum + 2;
                    break;
                case "Звукорежиссура":
                    Sum = Sum + 2;
                    break;
                case "Рисование":
                    Sum = Sum + 1;
                    break;
                case "Работа с документами":
                    Sum = Sum + 3;
                    break;

            }
        }

        public Configuration PickUpConfiguration()
        {
            return ConfigDict[Sum];
        }
        private void CreateConfiguration()
        {
            string contents = File.ReadAllText(@"ConfigSource.xml");
            Debug.WriteLine(contents);
            ConfigDict = XmlParser.Desirialize(contents);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Search_.NeuralNet;



namespace Search_.NeuralNet
{
    // это по сути контейнер для массива нейронов neironArray
    // загружет его при создании из файла и сохраняет при выходе

    class NetOfNeuron
    {
        
        public  const int          neironInArrayWidth  =           20; // количество по горизонтали
        public  const int          neironInArrayHeight =           20; // количество по вертикали
        private const string       memory              = "memory.txt"; // имя файла хранения сети
        private       List<Neuron> neironArray         =         null; // массив нейронов

        // конструктор
        public NetOfNeuron()
        {
            neironArray = InitWeb();            
        }

        // функция открывает текстовой файл и преобразовывает его в массив нейронов
        private static List<Neuron> InitWeb()
        {
            if (!File.Exists(memory)) return new List<Neuron>();
            string[] lines = File.ReadAllLines(memory);
            if (lines.Length == 0)    return new List<Neuron>();
            string jStr = lines[0];
            JavaScriptSerializer json = new JavaScriptSerializer();
            List<Object> objects = json.Deserialize<List<Object>>(jStr);
            List<Neuron> res = new List<Neuron>();
            foreach (var o in objects) res.Add(NeironCreate((Dictionary<string,Object>)o));
            return res;
        }

        // преобразовать структуру данных в клас нейрона
        private static Neuron NeironCreate(Dictionary<string, object> o)
        {
            Neuron res = new Neuron();
            res.name = (string)o["name"];
            res.countTrainig = (int)o["countTrainig"];
            Object[] veightData = (Object[])o["veight"];
            int arrSize = (int)Math.Sqrt(veightData.Length);
            res.veight = new double[arrSize, arrSize];
            int index = 0;
            for (int n = 0; n < res.veight.GetLength(0); n++)
                for (int m = 0; m < res.veight.GetLength(1); m++)
                {
                    res.veight[n, m] = Double.Parse(veightData[index].ToString());
                    index++;
                }
            return res;
        }

        // функция сравнивает входной массив с каждым нейроном из сети и 
        // возвращает имя нейрона наиболее похожего на него
        // именно эта функция отвечает за распознавание образа

        public string CheckLitera(int[,] arr)
        {
            string res = null;
            double max = 0;
            foreach (var n in neironArray)
            {
                double d = n.GetRes(arr);
                if (d > max)
                {
                    max = d;
                    res = n.GetName();
                }
            }
            return res;
        }

        // функция сохраняет массив нейронов в файл
        public void SaveState()
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            string jStr = json.Serialize(neironArray);
            System.IO.StreamWriter file = new System.IO.StreamWriter(memory);
            file.WriteLine(jStr);
            file.Close();
        }      

        // получить список имён образов, имеющихся в памяти
        public string[] GetLiteras()
        {
            var res = new List<string>();
            for (int i = 0; i < neironArray.Count; i++) res.Add(neironArray[i].GetName());
            res.Sort();
            return res.ToArray();
        }

        // эта функция заносит в память нейрона с именем trainingName
        // новый вариант образа data
        
        public void SetTraining(string trainingName, int[,] data)
        {
            Neuron neuron = neironArray.Find(v => v.name.Equals(trainingName));
            if (neuron == null) // если нейрона с таким именем не существует, создадим новыи и добавим
            {                   // его в массив нейронов
                neuron = new Neuron();
                neuron.Clear(trainingName, neironInArrayWidth, neironInArrayHeight);
                neironArray.Add(neuron);
            }
            int countTrainig = neuron.Training(data); // обучим нейрон новому образу          
                       
        }

       
    }
}

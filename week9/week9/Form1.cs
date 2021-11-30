using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week9.Entities;

namespace week9
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
        public Form1()
        {
            InitializeComponent();

            Population = ReadPopulaiton(@"C:\Temp\nép.csv");
            BirthProbabilities = ReadBirth(@"C:\Temp\születés.csv");
            DeathProbabilities = ReadDeath(@"C:\Temp\halál.csv");
        }

        public List<DeathProbability> ReadDeath(string filename)
        {
            List<DeathProbability> deathProbabilities = new List<DeathProbability>();
            using (StreamReader sr = new StreamReader(filename, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    deathProbabilities.Add(new DeathProbability()
                    {
                        Age = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        P = double.Parse(line[3])
                    });
                }    
            }
            return deathProbabilities;
        }

        public List<BirthProbability> ReadBirth(string filename)
        {
            List<BirthProbability> birthProbabilities = new List<BirthProbability>();
            using(StreamReader sr = new StreamReader(filename, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    birthProbabilities.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        P = double.Parse(line[3])
                    });
                }
            }
            return birthProbabilities;
        }

        public List<Person> ReadPopulaiton(string filename)
        {
            List<Person> population = new List<Person>();
            using(StreamReader sr = new StreamReader(filename, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(';');
                        population.Add(new Person()
                        {
                            BirthYear = int.Parse(line[0]),
                            Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                            NbrOfChildren = int.Parse(line[2])
                        });
                    }
                }
            }
            return population;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NewspaperSellerModels
{
    public class Inputs_Read
    {
        private SimulationSystem system;

        public Inputs_Read() { system = new SimulationSystem(); }

        public SimulationSystem Read_fromFile()
        {
            string w = "";
            FileStream fs = new FileStream("TestCase3.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while ((w = sr.ReadLine()) != null)
            {
                if (w == "") continue;

                if (w == "NumOfNewspapers")
                    system.NumOfNewspapers = int.Parse(sr.ReadLine());
                else if (w == "NumOfRecords")
                    system.NumOfRecords = int.Parse(sr.ReadLine());
                else if (w == "PurchasePrice")
                    system.PurchasePrice = decimal.Parse(sr.ReadLine());
                else if (w == "ScrapPrice")
                    system.ScrapPrice = decimal.Parse(sr.ReadLine());
                else if (w == "SellingPrice")
                    system.SellingPrice = decimal.Parse(sr.ReadLine());
                else if (w == "DayTypeDistributions")
                {
                    decimal Cum_Propability = 0; int Prev_min = 0;
                    string[] spliter = new string[3];

                    spliter = sr.ReadLine().Split(',');
                    for (int j = 0; j < 3; j++)
                    {
                        DayTypeDistribution day = new DayTypeDistribution();

                        if (j == 0)
                        {
                            day.DayType = Enums.DayType.Good;
                            day.Probability = decimal.Parse(spliter[0]);
                        }
                        else if (j == 1)
                        {
                            day.DayType = Enums.DayType.Fair;
                            day.Probability = decimal.Parse(spliter[1]);
                        }
                        else
                        {
                            day.DayType = Enums.DayType.Poor;
                            day.Probability = decimal.Parse(spliter[2]);
                        }

                        day.CummProbability = (decimal)Cum_Propability + day.Probability;
                        day.MinRange = Prev_min + 1;
                        day.MaxRange = (int)(day.CummProbability * 100);
                        Cum_Propability = day.CummProbability;
                        Prev_min = day.MaxRange;

                        system.DayTypeDistributions.Add(day);
                    }
                }
                else
                {
                    decimal Cum_PropG = 0, Cum_PropF = 0, Cum_PropP = 0;
                    int Prev_minG = 0, Prev_minF = 0, Prev_minP = 0;

                    while ((w = sr.ReadLine()) != null)
                    {
                        string[] spliter = new string[4];
                        spliter = w.Split(',');

                        DemandDistribution demand = new DemandDistribution();
                        demand.Demand = int.Parse(spliter[0]);

                        for (int j = 0; j < 3; j++)
                        {
                            DayTypeDistribution day = new DayTypeDistribution();

                            if (j == 0)
                            {
                                day.DayType = Enums.DayType.Good;
                                day.Probability = decimal.Parse(spliter[1]);
                                day.CummProbability = (decimal)Cum_PropG + day.Probability;
                                day.MinRange = Prev_minG + 1;
                                day.MaxRange = (int)(day.CummProbability * 100);
                                Prev_minG = day.MaxRange;
                                Cum_PropG = day.CummProbability;
                            }
                            else if (j == 1)
                            {
                                day.DayType = Enums.DayType.Fair;
                                day.Probability = decimal.Parse(spliter[2]);
                                day.CummProbability = (decimal)Cum_PropF + day.Probability;
                                day.MinRange = Prev_minF + 1;
                                day.MaxRange = (int)(day.CummProbability * 100);
                                Prev_minF = day.MaxRange;
                                Cum_PropF = day.CummProbability;
                            }
                            else
                            {
                                day.DayType = Enums.DayType.Poor;
                                day.Probability = decimal.Parse(spliter[3]);
                                day.CummProbability = (decimal)Cum_PropP + day.Probability;
                                day.MinRange = Prev_minP + 1;
                                day.MaxRange = (int)(day.CummProbability * 100);
                                Prev_minP = day.MaxRange;
                                Cum_PropP = day.CummProbability;
                            }

                            demand.DayTypeDistributions.Add(day);
                        }
                        system.DemandDistributions.Add(demand);
                    }
                    break;
                }

            }

            sr.Close();
            fs.Close();
            return system;
        }
    }
}

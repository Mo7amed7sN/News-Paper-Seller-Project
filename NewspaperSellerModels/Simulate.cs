using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class Simulate
    {
        private List<SimulationCase> cases;
        private PerformanceMeasures measures;
        private decimal total_sales, total_cost, total_lost, total_profit_scraps, Net_profit;
        private int NumOfDays_unsold, NumOfDays_needs;

        public Simulate()
        {
            cases = new List<SimulationCase>();
            measures = new PerformanceMeasures();
            total_sales = total_cost = total_lost = total_profit_scraps = Net_profit = 0;
            NumOfDays_needs = NumOfDays_unsold = 0;
        }

        public List<SimulationCase> simulate_now(SimulationSystem s)
        {
            Random rd = new Random(); int rInt, ind = 0;
            for (int i = 1; i <= s.NumOfRecords; i++)
            {
                SimulationCase cs = new SimulationCase();

                cs.DayNo = i;
                rInt = rd.Next(1, 101);
                cs.RandomNewsDayType = rInt;
                for (int j = 0; j < 3; j++)
                {
                    if(rInt >= s.DayTypeDistributions[j].MinRange && rInt <= s.DayTypeDistributions[j].MaxRange)
                    {
                        cs.NewsDayType = s.DayTypeDistributions[j].DayType;
                        ind = j;
                        break;
                    }
                }

                rInt = rd.Next(1, 101);
                cs.RandomDemand = rInt;
                for (int j = 0; j < s.DemandDistributions.Count(); j++)
                {
                    if(rInt >= s.DemandDistributions[j].DayTypeDistributions[ind].MinRange && rInt <= s.DemandDistributions[j].DayTypeDistributions[ind].MaxRange)
                    {
                        cs.Demand = s.DemandDistributions[j].Demand;
                        break;
                    }
                }

                cs.DailyCost = (decimal)s.NumOfNewspapers * s.PurchasePrice;
                if(cs.Demand > s.NumOfNewspapers)
                {
                    NumOfDays_needs++;
                    cs.SalesProfit = (decimal)s.NumOfNewspapers * s.SellingPrice;
                    cs.LostProfit = (decimal)(((cs.Demand - s.NumOfNewspapers) * s.SellingPrice) - ((cs.Demand - s.NumOfNewspapers) * s.PurchasePrice));
                    cs.ScrapProfit = 0;                   
                }
                else if(cs.Demand < s.NumOfNewspapers)
                {
                    NumOfDays_unsold++;
                    cs.SalesProfit = (decimal)cs.Demand * s.SellingPrice;
                    cs.LostProfit = 0;
                    cs.ScrapProfit = (decimal)((s.NumOfNewspapers - cs.Demand) * s.ScrapPrice);

                }
                else
                {
                    cs.SalesProfit = (decimal)cs.Demand * s.SellingPrice;
                    cs.LostProfit = 0;
                    cs.ScrapProfit = (decimal)((s.NumOfNewspapers - cs.Demand) * s.ScrapPrice);
                }
                cs.DailyNetProfit = cs.SalesProfit - cs.DailyCost - cs.LostProfit + cs.ScrapProfit;
                total_sales += cs.SalesProfit;
                total_cost += cs.DailyCost;
                total_lost += cs.LostProfit;
                total_profit_scraps += cs.ScrapProfit;
                Net_profit += cs.DailyNetProfit;
                cases.Add(cs);
            }
            return cases;
        }

        public PerformanceMeasures GetPerformance()
        {
            measures.TotalSalesProfit = (decimal)total_sales;
            measures.TotalCost = (decimal)total_cost;
            measures.TotalLostProfit = (decimal)total_lost;
            measures.TotalNetProfit = (decimal)Net_profit;
            measures.TotalScrapProfit = (decimal)total_profit_scraps;
            measures.DaysWithMoreDemand = NumOfDays_needs;
            measures.DaysWithUnsoldPapers = NumOfDays_unsold;
            return measures;
        }
    }
}

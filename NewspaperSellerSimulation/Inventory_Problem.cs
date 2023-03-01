using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;
using System.IO;

namespace NewspaperSellerSimulation
{
    public partial class Inventory_Problem : Form
    {
        public Inventory_Problem()
        {
            InitializeComponent();
        }

        SimulationSystem sys;
        private void Inventory_Problem_Load(object sender, EventArgs e)
        {
            sys = new SimulationSystem();
        }

        private void rd_data_Click(object sender, EventArgs e)
        {
            Inputs_Read File_Obj = new Inputs_Read();
            sys = File_Obj.Read_fromFile();

            MessageBox.Show("Done");
        }

        private void run_program_Click(object sender, EventArgs e)
        {
            Simulate sim = new Simulate();
            sys.SimulationTable = sim.simulate_now(sys);
            sys.PerformanceMeasures = sim.GetPerformance();
            MessageBox.Show("Done");
        }

        private void show_outputs_Click(object sender, EventArgs e)
        {
            sim_table.DataSource = sys.SimulationTable;
            tot_sales_profit.Text = sys.PerformanceMeasures.TotalSalesProfit.ToString();
            tot_costx.Text = sys.PerformanceMeasures.TotalCost.ToString();
            tot_lostx.Text = sys.PerformanceMeasures.TotalLostProfit.ToString();
            tot_salvage_scrapsx.Text = sys.PerformanceMeasures.TotalScrapProfit.ToString();
            Net_profitx.Text = sys.PerformanceMeasures.TotalNetProfit.ToString();
            days_needsx.Text = sys.PerformanceMeasures.DaysWithMoreDemand.ToString();
            days_unsoldx.Text = sys.PerformanceMeasures.DaysWithUnsoldPapers.ToString();

            string test = TestingManager.Test(sys, Constants.FileNames.TestCase3);
            MessageBox.Show(test);
        }
    }
}

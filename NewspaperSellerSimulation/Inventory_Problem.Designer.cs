namespace NewspaperSellerSimulation
{
    partial class Inventory_Problem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.show_outputs = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tot_lostx = new System.Windows.Forms.TextBox();
            this.tot_costx = new System.Windows.Forms.TextBox();
            this.tot_sales_profit = new System.Windows.Forms.TextBox();
            this.tot_cost = new System.Windows.Forms.Label();
            this.tot_lost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sim_table = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rd_data = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.run_program = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tot_salvage_scrapsx = new System.Windows.Forms.TextBox();
            this.tot_salvage_scraps = new System.Windows.Forms.Label();
            this.Net_profit = new System.Windows.Forms.Label();
            this.Net_profitx = new System.Windows.Forms.TextBox();
            this.days_needs = new System.Windows.Forms.Label();
            this.days_needsx = new System.Windows.Forms.TextBox();
            this.days_unsold = new System.Windows.Forms.Label();
            this.days_unsoldx = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sim_table)).BeginInit();
            this.SuspendLayout();
            // 
            // show_outputs
            // 
            this.show_outputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.show_outputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_outputs.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_outputs.ForeColor = System.Drawing.Color.Navy;
            this.show_outputs.Location = new System.Drawing.Point(785, 472);
            this.show_outputs.Name = "show_outputs";
            this.show_outputs.Size = new System.Drawing.Size(218, 43);
            this.show_outputs.TabIndex = 82;
            this.show_outputs.Text = "Show Outputs";
            this.show_outputs.UseVisualStyleBackColor = false;
            this.show_outputs.Click += new System.EventHandler(this.show_outputs_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(324, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 27);
            this.label10.TabIndex = 81;
            this.label10.Text = "Performance Measures";
            // 
            // tot_lostx
            // 
            this.tot_lostx.Location = new System.Drawing.Point(571, 342);
            this.tot_lostx.Name = "tot_lostx";
            this.tot_lostx.ReadOnly = true;
            this.tot_lostx.Size = new System.Drawing.Size(202, 20);
            this.tot_lostx.TabIndex = 80;
            // 
            // tot_costx
            // 
            this.tot_costx.Location = new System.Drawing.Point(571, 316);
            this.tot_costx.Name = "tot_costx";
            this.tot_costx.ReadOnly = true;
            this.tot_costx.Size = new System.Drawing.Size(202, 20);
            this.tot_costx.TabIndex = 79;
            // 
            // tot_sales_profit
            // 
            this.tot_sales_profit.Location = new System.Drawing.Point(571, 290);
            this.tot_sales_profit.Name = "tot_sales_profit";
            this.tot_sales_profit.ReadOnly = true;
            this.tot_sales_profit.Size = new System.Drawing.Size(202, 20);
            this.tot_sales_profit.TabIndex = 78;
            // 
            // tot_cost
            // 
            this.tot_cost.AutoSize = true;
            this.tot_cost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tot_cost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tot_cost.Location = new System.Drawing.Point(382, 319);
            this.tot_cost.Name = "tot_cost";
            this.tot_cost.Size = new System.Drawing.Size(70, 17);
            this.tot_cost.TabIndex = 77;
            this.tot_cost.Text = "Total Cost";
            // 
            // tot_lost
            // 
            this.tot_lost.AutoSize = true;
            this.tot_lost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tot_lost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_lost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tot_lost.Location = new System.Drawing.Point(382, 345);
            this.tot_lost.Name = "tot_lost";
            this.tot_lost.Size = new System.Drawing.Size(180, 17);
            this.tot_lost.TabIndex = 76;
            this.tot_lost.Text = "Total Lost(Excess Demands)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(382, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 75;
            this.label7.Text = "Total Sales Profit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(324, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 74;
            this.label5.Text = "Simulation Table";
            // 
            // sim_table
            // 
            this.sim_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sim_table.Location = new System.Drawing.Point(327, 85);
            this.sim_table.Name = "sim_table";
            this.sim_table.Size = new System.Drawing.Size(676, 165);
            this.sim_table.TabIndex = 73;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(351, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(652, 32);
            this.panel4.TabIndex = 72;
            // 
            // rd_data
            // 
            this.rd_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rd_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rd_data.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_data.ForeColor = System.Drawing.Color.Navy;
            this.rd_data.Location = new System.Drawing.Point(58, 116);
            this.rd_data.Name = "rd_data";
            this.rd_data.Size = new System.Drawing.Size(213, 48);
            this.rd_data.TabIndex = 70;
            this.rd_data.Text = "Read Data";
            this.rd_data.UseVisualStyleBackColor = false;
            this.rd_data.Click += new System.EventHandler(this.rd_data_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(9, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Click to Run the Simulation";
            // 
            // run_program
            // 
            this.run_program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.run_program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run_program.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_program.ForeColor = System.Drawing.Color.Navy;
            this.run_program.Location = new System.Drawing.Point(58, 445);
            this.run_program.Name = "run_program";
            this.run_program.Size = new System.Drawing.Size(213, 48);
            this.run_program.TabIndex = 68;
            this.run_program.Text = "Run";
            this.run_program.UseVisualStyleBackColor = false;
            this.run_program.Click += new System.EventHandler(this.run_program_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(15, 473);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 46);
            this.panel3.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Click to Read Data from file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 64;
            this.label1.Text = "Input Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 32);
            this.panel2.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(293, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 513);
            this.panel1.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 83;
            this.label4.Text = "Output Data";
            // 
            // tot_salvage_scrapsx
            // 
            this.tot_salvage_scrapsx.Location = new System.Drawing.Point(571, 368);
            this.tot_salvage_scrapsx.Name = "tot_salvage_scrapsx";
            this.tot_salvage_scrapsx.ReadOnly = true;
            this.tot_salvage_scrapsx.Size = new System.Drawing.Size(202, 20);
            this.tot_salvage_scrapsx.TabIndex = 85;
            // 
            // tot_salvage_scraps
            // 
            this.tot_salvage_scraps.AutoSize = true;
            this.tot_salvage_scraps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tot_salvage_scraps.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_salvage_scraps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tot_salvage_scraps.Location = new System.Drawing.Point(382, 371);
            this.tot_salvage_scraps.Name = "tot_salvage_scraps";
            this.tot_salvage_scraps.Size = new System.Drawing.Size(139, 17);
            this.tot_salvage_scraps.TabIndex = 84;
            this.tot_salvage_scraps.Text = "Total Salvage(Scraps)";
            // 
            // Net_profit
            // 
            this.Net_profit.AutoSize = true;
            this.Net_profit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Net_profit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Net_profit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Net_profit.Location = new System.Drawing.Point(383, 395);
            this.Net_profit.Name = "Net_profit";
            this.Net_profit.Size = new System.Drawing.Size(69, 17);
            this.Net_profit.TabIndex = 88;
            this.Net_profit.Text = "Net Profit";
            // 
            // Net_profitx
            // 
            this.Net_profitx.Location = new System.Drawing.Point(571, 395);
            this.Net_profitx.Name = "Net_profitx";
            this.Net_profitx.ReadOnly = true;
            this.Net_profitx.Size = new System.Drawing.Size(202, 20);
            this.Net_profitx.TabIndex = 89;
            // 
            // days_needs
            // 
            this.days_needs.AutoSize = true;
            this.days_needs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.days_needs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days_needs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.days_needs.Location = new System.Drawing.Point(383, 423);
            this.days_needs.Name = "days_needs";
            this.days_needs.Size = new System.Drawing.Size(191, 17);
            this.days_needs.TabIndex = 90;
            this.days_needs.Text = "#Days having Excess Demand";
            // 
            // days_needsx
            // 
            this.days_needsx.Location = new System.Drawing.Point(571, 420);
            this.days_needsx.Name = "days_needsx";
            this.days_needsx.ReadOnly = true;
            this.days_needsx.Size = new System.Drawing.Size(202, 20);
            this.days_needsx.TabIndex = 91;
            // 
            // days_unsold
            // 
            this.days_unsold.AutoSize = true;
            this.days_unsold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.days_unsold.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days_unsold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.days_unsold.Location = new System.Drawing.Point(382, 449);
            this.days_unsold.Name = "days_unsold";
            this.days_unsold.Size = new System.Drawing.Size(192, 17);
            this.days_unsold.TabIndex = 92;
            this.days_unsold.Text = "#Days having Non Sold Paper";
            // 
            // days_unsoldx
            // 
            this.days_unsoldx.Location = new System.Drawing.Point(571, 446);
            this.days_unsoldx.Name = "days_unsoldx";
            this.days_unsoldx.ReadOnly = true;
            this.days_unsoldx.Size = new System.Drawing.Size(202, 20);
            this.days_unsoldx.TabIndex = 93;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(9, 278);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 24);
            this.panel5.TabIndex = 64;
            // 
            // Inventory_Problem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 527);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.days_unsoldx);
            this.Controls.Add(this.days_unsold);
            this.Controls.Add(this.days_needsx);
            this.Controls.Add(this.days_needs);
            this.Controls.Add(this.Net_profitx);
            this.Controls.Add(this.Net_profit);
            this.Controls.Add(this.tot_salvage_scrapsx);
            this.Controls.Add(this.tot_salvage_scraps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.show_outputs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tot_lostx);
            this.Controls.Add(this.tot_costx);
            this.Controls.Add(this.tot_sales_profit);
            this.Controls.Add(this.tot_cost);
            this.Controls.Add(this.tot_lost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sim_table);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.rd_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.run_program);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Inventory_Problem";
            this.Text = "Inventory Problem";
            this.Load += new System.EventHandler(this.Inventory_Problem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sim_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_outputs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tot_lostx;
        private System.Windows.Forms.TextBox tot_costx;
        private System.Windows.Forms.TextBox tot_sales_profit;
        private System.Windows.Forms.Label tot_cost;
        private System.Windows.Forms.Label tot_lost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView sim_table;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button rd_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button run_program;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tot_salvage_scrapsx;
        private System.Windows.Forms.Label tot_salvage_scraps;
        private System.Windows.Forms.Label Net_profit;
        private System.Windows.Forms.TextBox Net_profitx;
        private System.Windows.Forms.Label days_needs;
        private System.Windows.Forms.TextBox days_needsx;
        private System.Windows.Forms.Label days_unsold;
        private System.Windows.Forms.TextBox days_unsoldx;
        private System.Windows.Forms.Panel panel5;
    }
}
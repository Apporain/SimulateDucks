namespace DuckSimulator
{
    partial class DuckSim
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDuckSim = new System.Windows.Forms.Label();
            this.gpbDuckType = new System.Windows.Forms.GroupBox();
            this.rdbDecoy = new System.Windows.Forms.RadioButton();
            this.rdbRubber = new System.Windows.Forms.RadioButton();
            this.rdbRedhead = new System.Windows.Forms.RadioButton();
            this.rdbMallard = new System.Windows.Forms.RadioButton();
            this.lblDuckData = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnFly = new System.Windows.Forms.Button();
            this.btnQuack = new System.Windows.Forms.Button();
            this.gpbDuckType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDuckSim
            // 
            this.lblDuckSim.AutoSize = true;
            this.lblDuckSim.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuckSim.Location = new System.Drawing.Point(94, 45);
            this.lblDuckSim.Name = "lblDuckSim";
            this.lblDuckSim.Size = new System.Drawing.Size(150, 25);
            this.lblDuckSim.TabIndex = 0;
            this.lblDuckSim.Text = "Duck Simulator";
            // 
            // gpbDuckType
            // 
            this.gpbDuckType.Controls.Add(this.rdbDecoy);
            this.gpbDuckType.Controls.Add(this.rdbRubber);
            this.gpbDuckType.Controls.Add(this.rdbRedhead);
            this.gpbDuckType.Controls.Add(this.rdbMallard);
            this.gpbDuckType.Location = new System.Drawing.Point(33, 104);
            this.gpbDuckType.Name = "gpbDuckType";
            this.gpbDuckType.Size = new System.Drawing.Size(109, 165);
            this.gpbDuckType.TabIndex = 1;
            this.gpbDuckType.TabStop = false;
            this.gpbDuckType.Text = "Duck Type";
            // 
            // rdbDecoy
            // 
            this.rdbDecoy.AutoSize = true;
            this.rdbDecoy.Location = new System.Drawing.Point(6, 97);
            this.rdbDecoy.Name = "rdbDecoy";
            this.rdbDecoy.Size = new System.Drawing.Size(88, 19);
            this.rdbDecoy.TabIndex = 3;
            this.rdbDecoy.TabStop = true;
            this.rdbDecoy.Text = "Decoy Duck";
            this.rdbDecoy.UseVisualStyleBackColor = true;
            this.rdbDecoy.CheckedChanged += new System.EventHandler(this.rdbDecoy_CheckedChanged);
            // 
            // rdbRubber
            // 
            this.rdbRubber.AutoSize = true;
            this.rdbRubber.Location = new System.Drawing.Point(6, 72);
            this.rdbRubber.Name = "rdbRubber";
            this.rdbRubber.Size = new System.Drawing.Size(93, 19);
            this.rdbRubber.TabIndex = 2;
            this.rdbRubber.TabStop = true;
            this.rdbRubber.Text = "Rubber Duck";
            this.rdbRubber.UseVisualStyleBackColor = true;
            this.rdbRubber.CheckedChanged += new System.EventHandler(this.rdbRubber_CheckedChanged);
            // 
            // rdbRedhead
            // 
            this.rdbRedhead.AutoSize = true;
            this.rdbRedhead.Location = new System.Drawing.Point(6, 47);
            this.rdbRedhead.Name = "rdbRedhead";
            this.rdbRedhead.Size = new System.Drawing.Size(71, 19);
            this.rdbRedhead.TabIndex = 1;
            this.rdbRedhead.TabStop = true;
            this.rdbRedhead.Text = "Redhead";
            this.rdbRedhead.UseVisualStyleBackColor = true;
            this.rdbRedhead.CheckedChanged += new System.EventHandler(this.rdbRedhead_CheckedChanged);
            // 
            // rdbMallard
            // 
            this.rdbMallard.AutoSize = true;
            this.rdbMallard.Location = new System.Drawing.Point(6, 22);
            this.rdbMallard.Name = "rdbMallard";
            this.rdbMallard.Size = new System.Drawing.Size(65, 19);
            this.rdbMallard.TabIndex = 0;
            this.rdbMallard.TabStop = true;
            this.rdbMallard.Text = "Mallard";
            this.rdbMallard.UseVisualStyleBackColor = true;
            this.rdbMallard.CheckedChanged += new System.EventHandler(this.rdbMallard_CheckedChanged);
            // 
            // lblDuckData
            // 
            this.lblDuckData.AutoSize = true;
            this.lblDuckData.Location = new System.Drawing.Point(94, 315);
            this.lblDuckData.Name = "lblDuckData";
            this.lblDuckData.Size = new System.Drawing.Size(72, 15);
            this.lblDuckData.TabIndex = 2;
            this.lblDuckData.Text = "_____________";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(185, 122);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnFly
            // 
            this.btnFly.Location = new System.Drawing.Point(185, 172);
            this.btnFly.Name = "btnFly";
            this.btnFly.Size = new System.Drawing.Size(75, 23);
            this.btnFly.TabIndex = 4;
            this.btnFly.Text = "Fly";
            this.btnFly.UseVisualStyleBackColor = true;
            this.btnFly.Click += new System.EventHandler(this.btnFly_Click);
            // 
            // btnQuack
            // 
            this.btnQuack.Location = new System.Drawing.Point(185, 220);
            this.btnQuack.Name = "btnQuack";
            this.btnQuack.Size = new System.Drawing.Size(75, 23);
            this.btnQuack.TabIndex = 5;
            this.btnQuack.Text = "Quack";
            this.btnQuack.UseVisualStyleBackColor = true;
            this.btnQuack.Click += new System.EventHandler(this.btnQuack_Click);
            // 
            // DuckSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 415);
            this.Controls.Add(this.btnQuack);
            this.Controls.Add(this.btnFly);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblDuckData);
            this.Controls.Add(this.gpbDuckType);
            this.Controls.Add(this.lblDuckSim);
            this.Name = "DuckSim";
            this.Text = "Form1";
            this.gpbDuckType.ResumeLayout(false);
            this.gpbDuckType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDuckSim;
        private GroupBox gpbDuckType;
        private RadioButton rdbDecoy;
        private RadioButton rdbRubber;
        private RadioButton rdbRedhead;
        private RadioButton rdbMallard;
        private Label lblDuckData;
        private Button btnDisplay;
        private Button btnFly;
        private Button btnQuack;
    }
}
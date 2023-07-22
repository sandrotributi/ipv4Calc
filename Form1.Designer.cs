namespace ipCalc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCidr = new System.Windows.Forms.NumericUpDown();
            this.labelDescr1 = new System.Windows.Forms.Label();
            this.labelDescr2 = new System.Windows.Forms.Label();
            this.labelDescr3 = new System.Windows.Forms.Label();
            this.labelDescr4 = new System.Windows.Forms.Label();
            this.labelDescr5 = new System.Windows.Forms.Label();
            this.labelDescr6 = new System.Windows.Forms.Label();
            this.labelDescr7 = new System.Windows.Forms.Label();
            this.labelDescr8 = new System.Windows.Forms.Label();
            this.labelIpAddress = new System.Windows.Forms.Label();
            this.labelNetmask = new System.Windows.Forms.Label();
            this.labelWildcardMask = new System.Windows.Forms.Label();
            this.labelIpAddressBin = new System.Windows.Forms.Label();
            this.labelWildcardMaskBin = new System.Windows.Forms.Label();
            this.labelNetmaskBin = new System.Windows.Forms.Label();
            this.labelNetworkAddress = new System.Windows.Forms.Label();
            this.labelNetworkAddressBin = new System.Windows.Forms.Label();
            this.labelIpClass = new System.Windows.Forms.Label();
            this.labelHostNet = new System.Windows.Forms.Label();
            this.labelBcastAddress = new System.Windows.Forms.Label();
            this.labelBcastAddressBin = new System.Windows.Forms.Label();
            this.labelHostMin = new System.Windows.Forms.Label();
            this.labelHostMinBin = new System.Windows.Forms.Label();
            this.labelHostMax = new System.Windows.Forms.Label();
            this.labelHostMaxBin = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCidr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(12, 42);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 23);
            this.textBoxAddress.TabIndex = 1;
            this.textBoxAddress.Text = "192.168.0.1";
            this.textBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Host or Network)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(136, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mask";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(12, 71);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(100, 23);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(555, 43);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(648, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "(CIDR)";
            // 
            // numericUpDownCidr
            // 
            this.numericUpDownCidr.Location = new System.Drawing.Point(136, 43);
            this.numericUpDownCidr.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownCidr.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownCidr.Name = "numericUpDownCidr";
            this.numericUpDownCidr.Size = new System.Drawing.Size(49, 23);
            this.numericUpDownCidr.TabIndex = 12;
            this.numericUpDownCidr.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // labelDescr1
            // 
            this.labelDescr1.AutoSize = true;
            this.labelDescr1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescr1.Location = new System.Drawing.Point(14, 123);
            this.labelDescr1.Name = "labelDescr1";
            this.labelDescr1.Size = new System.Drawing.Size(71, 16);
            this.labelDescr1.TabIndex = 13;
            this.labelDescr1.Text = "Address:";
            // 
            // labelDescr2
            // 
            this.labelDescr2.AutoSize = true;
            this.labelDescr2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescr2.Location = new System.Drawing.Point(14, 139);
            this.labelDescr2.Name = "labelDescr2";
            this.labelDescr2.Size = new System.Drawing.Size(71, 16);
            this.labelDescr2.TabIndex = 14;
            this.labelDescr2.Text = "Netmask:";
            // 
            // labelDescr3
            // 
            this.labelDescr3.AutoSize = true;
            this.labelDescr3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescr3.Location = new System.Drawing.Point(14, 155);
            this.labelDescr3.Name = "labelDescr3";
            this.labelDescr3.Size = new System.Drawing.Size(79, 16);
            this.labelDescr3.TabIndex = 15;
            this.labelDescr3.Text = "Wildcard:";
            // 
            // labelDescr4
            // 
            this.labelDescr4.AutoSize = true;
            this.labelDescr4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescr4.Location = new System.Drawing.Point(14, 186);
            this.labelDescr4.Name = "labelDescr4";
            this.labelDescr4.Size = new System.Drawing.Size(71, 16);
            this.labelDescr4.TabIndex = 16;
            this.labelDescr4.Text = "Network:";
            // 
            // labelDescr5
            // 
            this.labelDescr5.AutoSize = true;
            this.labelDescr5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescr5.Location = new System.Drawing.Point(14, 202);
            this.labelDescr5.Name = "labelDescr5";
            this.labelDescr5.Size = new System.Drawing.Size(87, 16);
            this.labelDescr5.TabIndex = 17;
            this.labelDescr5.Text = "Broadcast:";
            // 
            // labelDescr6
            // 
            this.labelDescr6.AutoSize = true;
            this.labelDescr6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescr6.Location = new System.Drawing.Point(14, 218);
            this.labelDescr6.Name = "labelDescr6";
            this.labelDescr6.Size = new System.Drawing.Size(71, 16);
            this.labelDescr6.TabIndex = 18;
            this.labelDescr6.Text = "HostMin:";
            // 
            // labelDescr7
            // 
            this.labelDescr7.AutoSize = true;
            this.labelDescr7.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescr7.Location = new System.Drawing.Point(14, 234);
            this.labelDescr7.Name = "labelDescr7";
            this.labelDescr7.Size = new System.Drawing.Size(71, 16);
            this.labelDescr7.TabIndex = 19;
            this.labelDescr7.Text = "HostMax:";
            // 
            // labelDescr8
            // 
            this.labelDescr8.AutoSize = true;
            this.labelDescr8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescr8.Location = new System.Drawing.Point(14, 250);
            this.labelDescr8.Name = "labelDescr8";
            this.labelDescr8.Size = new System.Drawing.Size(87, 16);
            this.labelDescr8.TabIndex = 20;
            this.labelDescr8.Text = "Hosts/Net:";
            // 
            // labelIpAddress
            // 
            this.labelIpAddress.AutoSize = true;
            this.labelIpAddress.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIpAddress.ForeColor = System.Drawing.Color.Blue;
            this.labelIpAddress.Location = new System.Drawing.Point(103, 123);
            this.labelIpAddress.Name = "labelIpAddress";
            this.labelIpAddress.Size = new System.Drawing.Size(119, 16);
            this.labelIpAddress.TabIndex = 21;
            this.labelIpAddress.Text = "labelIpAddress";
            // 
            // labelNetmask
            // 
            this.labelNetmask.AutoSize = true;
            this.labelNetmask.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNetmask.ForeColor = System.Drawing.Color.Blue;
            this.labelNetmask.Location = new System.Drawing.Point(103, 139);
            this.labelNetmask.Name = "labelNetmask";
            this.labelNetmask.Size = new System.Drawing.Size(103, 16);
            this.labelNetmask.TabIndex = 22;
            this.labelNetmask.Text = "labelNetmask";
            // 
            // labelWildcardMask
            // 
            this.labelWildcardMask.AutoSize = true;
            this.labelWildcardMask.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWildcardMask.ForeColor = System.Drawing.Color.Blue;
            this.labelWildcardMask.Location = new System.Drawing.Point(103, 155);
            this.labelWildcardMask.Name = "labelWildcardMask";
            this.labelWildcardMask.Size = new System.Drawing.Size(143, 16);
            this.labelWildcardMask.TabIndex = 23;
            this.labelWildcardMask.Text = "labelWildcardMask";
            // 
            // labelIpAddressBin
            // 
            this.labelIpAddressBin.AutoSize = true;
            this.labelIpAddressBin.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIpAddressBin.ForeColor = System.Drawing.Color.Blue;
            this.labelIpAddressBin.Location = new System.Drawing.Point(270, 123);
            this.labelIpAddressBin.Name = "labelIpAddressBin";
            this.labelIpAddressBin.Size = new System.Drawing.Size(143, 16);
            this.labelIpAddressBin.TabIndex = 24;
            this.labelIpAddressBin.Text = "labelIpAddressBin";
            // 
            // labelWildcardMaskBin
            // 
            this.labelWildcardMaskBin.AutoSize = true;
            this.labelWildcardMaskBin.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWildcardMaskBin.ForeColor = System.Drawing.Color.Blue;
            this.labelWildcardMaskBin.Location = new System.Drawing.Point(270, 155);
            this.labelWildcardMaskBin.Name = "labelWildcardMaskBin";
            this.labelWildcardMaskBin.Size = new System.Drawing.Size(167, 16);
            this.labelWildcardMaskBin.TabIndex = 25;
            this.labelWildcardMaskBin.Text = "labelWildcardMaskBin";
            // 
            // labelNetmaskBin
            // 
            this.labelNetmaskBin.AutoSize = true;
            this.labelNetmaskBin.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNetmaskBin.ForeColor = System.Drawing.Color.Red;
            this.labelNetmaskBin.Location = new System.Drawing.Point(270, 139);
            this.labelNetmaskBin.Name = "labelNetmaskBin";
            this.labelNetmaskBin.Size = new System.Drawing.Size(127, 16);
            this.labelNetmaskBin.TabIndex = 26;
            this.labelNetmaskBin.Text = "labelNetmaskBin";
            // 
            // labelNetworkAddress
            // 
            this.labelNetworkAddress.AutoSize = true;
            this.labelNetworkAddress.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNetworkAddress.ForeColor = System.Drawing.Color.Blue;
            this.labelNetworkAddress.Location = new System.Drawing.Point(103, 186);
            this.labelNetworkAddress.Name = "labelNetworkAddress";
            this.labelNetworkAddress.Size = new System.Drawing.Size(159, 16);
            this.labelNetworkAddress.TabIndex = 27;
            this.labelNetworkAddress.Text = "labelNetworkAddress";
            // 
            // labelNetworkAddressBin
            // 
            this.labelNetworkAddressBin.AutoSize = true;
            this.labelNetworkAddressBin.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNetworkAddressBin.Location = new System.Drawing.Point(270, 186);
            this.labelNetworkAddressBin.Name = "labelNetworkAddressBin";
            this.labelNetworkAddressBin.Size = new System.Drawing.Size(183, 16);
            this.labelNetworkAddressBin.TabIndex = 28;
            this.labelNetworkAddressBin.Text = "labelNetworkAddressBin";
            // 
            // labelIpClass
            // 
            this.labelIpClass.AutoSize = true;
            this.labelIpClass.ForeColor = System.Drawing.Color.Green;
            this.labelIpClass.Location = new System.Drawing.Point(555, 186);
            this.labelIpClass.Name = "labelIpClass";
            this.labelIpClass.Size = new System.Drawing.Size(69, 15);
            this.labelIpClass.TabIndex = 29;
            this.labelIpClass.Text = "labelIpClass";
            // 
            // labelHostNet
            // 
            this.labelHostNet.AutoSize = true;
            this.labelHostNet.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHostNet.ForeColor = System.Drawing.Color.Blue;
            this.labelHostNet.Location = new System.Drawing.Point(103, 250);
            this.labelHostNet.Name = "labelHostNet";
            this.labelHostNet.Size = new System.Drawing.Size(103, 16);
            this.labelHostNet.TabIndex = 30;
            this.labelHostNet.Text = "labelHostNet";
            // 
            // labelBcastAddress
            // 
            this.labelBcastAddress.AutoSize = true;
            this.labelBcastAddress.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBcastAddress.ForeColor = System.Drawing.Color.Blue;
            this.labelBcastAddress.Location = new System.Drawing.Point(103, 202);
            this.labelBcastAddress.Name = "labelBcastAddress";
            this.labelBcastAddress.Size = new System.Drawing.Size(143, 16);
            this.labelBcastAddress.TabIndex = 31;
            this.labelBcastAddress.Text = "labelBcastAddress";
            // 
            // labelBcastAddressBin
            // 
            this.labelBcastAddressBin.AutoSize = true;
            this.labelBcastAddressBin.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBcastAddressBin.Location = new System.Drawing.Point(270, 202);
            this.labelBcastAddressBin.Name = "labelBcastAddressBin";
            this.labelBcastAddressBin.Size = new System.Drawing.Size(167, 16);
            this.labelBcastAddressBin.TabIndex = 32;
            this.labelBcastAddressBin.Text = "labelBcastAddressBin";
            // 
            // labelHostMin
            // 
            this.labelHostMin.AutoSize = true;
            this.labelHostMin.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHostMin.ForeColor = System.Drawing.Color.Blue;
            this.labelHostMin.Location = new System.Drawing.Point(103, 218);
            this.labelHostMin.Name = "labelHostMin";
            this.labelHostMin.Size = new System.Drawing.Size(103, 16);
            this.labelHostMin.TabIndex = 33;
            this.labelHostMin.Text = "labelHostMin";
            // 
            // labelHostMinBin
            // 
            this.labelHostMinBin.AutoSize = true;
            this.labelHostMinBin.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHostMinBin.Location = new System.Drawing.Point(270, 218);
            this.labelHostMinBin.Name = "labelHostMinBin";
            this.labelHostMinBin.Size = new System.Drawing.Size(127, 16);
            this.labelHostMinBin.TabIndex = 34;
            this.labelHostMinBin.Text = "labelHostMinBin";
            // 
            // labelHostMax
            // 
            this.labelHostMax.AutoSize = true;
            this.labelHostMax.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHostMax.ForeColor = System.Drawing.Color.Blue;
            this.labelHostMax.Location = new System.Drawing.Point(103, 234);
            this.labelHostMax.Name = "labelHostMax";
            this.labelHostMax.Size = new System.Drawing.Size(103, 16);
            this.labelHostMax.TabIndex = 35;
            this.labelHostMax.Text = "labelHostMax";
            // 
            // labelHostMaxBin
            // 
            this.labelHostMaxBin.AutoSize = true;
            this.labelHostMaxBin.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHostMaxBin.Location = new System.Drawing.Point(270, 234);
            this.labelHostMaxBin.Name = "labelHostMaxBin";
            this.labelHostMaxBin.Size = new System.Drawing.Size(127, 16);
            this.labelHostMaxBin.TabIndex = 36;
            this.labelHostMaxBin.Text = "labelHostMaxBin";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.labelHostMaxBin);
            this.Controls.Add(this.labelHostMax);
            this.Controls.Add(this.labelHostMinBin);
            this.Controls.Add(this.labelHostMin);
            this.Controls.Add(this.labelBcastAddressBin);
            this.Controls.Add(this.labelBcastAddress);
            this.Controls.Add(this.labelHostNet);
            this.Controls.Add(this.labelIpClass);
            this.Controls.Add(this.labelNetworkAddressBin);
            this.Controls.Add(this.labelNetworkAddress);
            this.Controls.Add(this.labelNetmaskBin);
            this.Controls.Add(this.labelWildcardMaskBin);
            this.Controls.Add(this.labelIpAddressBin);
            this.Controls.Add(this.labelWildcardMask);
            this.Controls.Add(this.labelNetmask);
            this.Controls.Add(this.labelIpAddress);
            this.Controls.Add(this.labelDescr8);
            this.Controls.Add(this.labelDescr7);
            this.Controls.Add(this.labelDescr6);
            this.Controls.Add(this.labelDescr5);
            this.Controls.Add(this.labelDescr4);
            this.Controls.Add(this.labelDescr3);
            this.Controls.Add(this.labelDescr2);
            this.Controls.Add(this.labelDescr1);
            this.Controls.Add(this.numericUpDownCidr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IP Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCidr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxAddress;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCalc;
        private Button buttonExit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label5;
        private NumericUpDown numericUpDownCidr;
        private Label labelDescr1;
        private Label labelDescr2;
        private Label labelDescr3;
        private Label labelDescr4;
        private Label labelDescr5;
        private Label labelDescr6;
        private Label labelDescr7;
        private Label labelDescr8;
        private Label labelIpAddress;
        private Label labelNetmask;
        private Label labelWildcardMask;
        private Label labelIpAddressBin;
        private Label labelWildcardMaskBin;
        private Label labelNetmaskBin;
        private Label labelNetworkAddress;
        private Label labelNetworkAddressBin;
        private Label labelIpClass;
        private Label labelHostNet;
        private Label labelBcastAddress;
        private Label labelBcastAddressBin;
        private Label labelHostMin;
        private Label labelHostMinBin;
        private Label labelHostMax;
        private Label labelHostMaxBin;
        private Label label6;
    }
}
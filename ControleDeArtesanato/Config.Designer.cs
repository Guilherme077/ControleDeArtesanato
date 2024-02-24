namespace ControleDeArtesanato
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            groupBox2 = new GroupBox();
            comboBox4 = new ComboBox();
            label3 = new Label();
            comboBox5 = new ComboBox();
            label5 = new Label();
            comboBox6 = new ComboBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2"), resources.GetString("comboBox1.Items3"), resources.GetString("comboBox1.Items4"), resources.GetString("comboBox1.Items5") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            resources.ApplyResources(comboBox2, "comboBox2");
            comboBox2.Name = "comboBox2";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            resources.ApplyResources(comboBox3, "comboBox3");
            comboBox3.Name = "comboBox3";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox6);
            groupBox2.Controls.Add(label6);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            resources.ApplyResources(comboBox4, "comboBox4");
            comboBox4.Name = "comboBox4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            resources.ApplyResources(comboBox5, "comboBox5");
            comboBox5.Name = "comboBox5";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            resources.ApplyResources(comboBox6, "comboBox6");
            comboBox6.Name = "comboBox6";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // Config
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Config";
            FormClosing += Config_FormClosing;
            Load += Config_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private GroupBox groupBox2;
        private ComboBox comboBox4;
        private Label label3;
        private ComboBox comboBox5;
        private Label label5;
        private ComboBox comboBox6;
        private Label label6;
    }
}
namespace lab4
{
    partial class FORMMAIN
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMMAIN));
            toolStrip1 = new ToolStrip();
            btnADD = new ToolStripButton();
            btnEDIT = new ToolStripButton();
            separator1 = new ToolStripSeparator();
            btnDEL = new ToolStripButton();
            btnCLEAR = new ToolStripButton();
            separator2 = new ToolStripSeparator();
            btnEXIT = new ToolStripButton();
            bindSRCDOC = new BindingSource(components);
            gvDOCS = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindSRCDOC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDOCS).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnADD, btnEDIT, separator1, btnDEL, btnCLEAR, separator2, btnEXIT });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(954, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnADD
            // 
            btnADD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnADD.Image = (Image)resources.GetObject("btnADD.Image");
            btnADD.ImageTransparentColor = Color.Magenta;
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(23, 22);
            btnADD.Text = "Додати";
            btnADD.Click += btnADD_Click;
            // 
            // btnEDIT
            // 
            btnEDIT.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEDIT.Image = (Image)resources.GetObject("btnEDIT.Image");
            btnEDIT.ImageTransparentColor = Color.Magenta;
            btnEDIT.Name = "btnEDIT";
            btnEDIT.Size = new Size(23, 22);
            btnEDIT.Text = "Редагувати";
            btnEDIT.Click += btnEDIT_Click;
            // 
            // separator1
            // 
            separator1.Name = "separator1";
            separator1.Size = new Size(6, 25);
            // 
            // btnDEL
            // 
            btnDEL.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDEL.Image = (Image)resources.GetObject("btnDEL.Image");
            btnDEL.ImageTransparentColor = Color.Magenta;
            btnDEL.Name = "btnDEL";
            btnDEL.Size = new Size(23, 22);
            btnDEL.Text = "Видалити";
            btnDEL.Click += btnDEL_Click;
            // 
            // btnCLEAR
            // 
            btnCLEAR.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCLEAR.Image = (Image)resources.GetObject("btnCLEAR.Image");
            btnCLEAR.ImageTransparentColor = Color.Magenta;
            btnCLEAR.Name = "btnCLEAR";
            btnCLEAR.Size = new Size(23, 22);
            btnCLEAR.Text = "Очистити дані";
            btnCLEAR.Click += btnCLEAR_Click;
            // 
            // separator2
            // 
            separator2.Name = "separator2";
            separator2.Size = new Size(6, 25);
            // 
            // btnEXIT
            // 
            btnEXIT.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEXIT.Image = (Image)resources.GetObject("btnEXIT.Image");
            btnEXIT.ImageTransparentColor = Color.Magenta;
            btnEXIT.Margin = new Padding(800, 1, 0, 2);
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(23, 22);
            btnEXIT.Text = "Вийти з програми";
            btnEXIT.Click += btnEXIT_Click;
            // 
            // gvDOCS
            // 
            gvDOCS.AllowUserToAddRows = false;
            gvDOCS.AllowUserToDeleteRows = false;
            gvDOCS.AutoGenerateColumns = false;
            gvDOCS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvDOCS.DataSource = bindSRCDOC;
            gvDOCS.Dock = DockStyle.Fill;
            gvDOCS.Location = new Point(0, 25);
            gvDOCS.Name = "gvDOCS";
            gvDOCS.ReadOnly = true;
            gvDOCS.Size = new Size(954, 425);
            gvDOCS.TabIndex = 1;
            // 
            // FORMMAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 450);
            Controls.Add(gvDOCS);
            Controls.Add(toolStrip1);
            Name = "FORMMAIN";
            Text = "Form1";
            Load += FORMMAIN_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindSRCDOC).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDOCS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnADD;
        private ToolStripButton btnEDIT;
        private ToolStripSeparator separator1;
        private ToolStripButton btnDEL;
        private ToolStripButton btnCLEAR;
        private ToolStripSeparator separator2;
        private ToolStripButton btnEXIT;
        private BindingSource bindSRCDOC;
        private DataGridView gvDOCS;
    }
}

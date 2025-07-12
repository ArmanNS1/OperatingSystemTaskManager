namespace OSTaskManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView processGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnKill;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.processGridView = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.processGridView)).BeginInit();
            this.SuspendLayout();

            this.processGridView.AllowUserToAddRows = false;
            this.processGridView.AllowUserToDeleteRows = false;
            this.processGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processGridView.Location = new System.Drawing.Point(12, 12);
            this.processGridView.MultiSelect = false;
            this.processGridView.Name = "processGridView";
            this.processGridView.ReadOnly = true;
            this.processGridView.RowHeadersVisible = false;
            this.processGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.processGridView.Size = new System.Drawing.Size(560, 350);
            this.processGridView.TabIndex = 0;

            this.btnRefresh.Location = new System.Drawing.Point(12, 375);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnKill.Location = new System.Drawing.Point(472, 375);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(100, 30);
            this.btnKill.TabIndex = 2;
            this.btnKill.Text = "Kill Process";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);

            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.processGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Task Manager";

            ((System.ComponentModel.ISupportInitialize)(this.processGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

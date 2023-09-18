namespace QueingForm
{
    partial class QueuingForm
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
            bntCashier = new Button();
            lblQueue = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // bntCashier
            // 
            bntCashier.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bntCashier.Location = new Point(30, 95);
            bntCashier.Name = "bntCashier";
            bntCashier.Size = new Size(115, 114);
            bntCashier.TabIndex = 0;
            bntCashier.Text = "Cashier";
            bntCashier.UseVisualStyleBackColor = true;
            bntCashier.Click += bntCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Consolas", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(207, 161);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(159, 34);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "P - 10007";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(204, 109);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 2;
            label1.Text = "Position in Queue";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 300);
            Controls.Add(label1);
            Controls.Add(lblQueue);
            Controls.Add(bntCashier);
            Name = "QueuingForm";
            Text = "QueuingForm";
            Load += QueuingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntCashier;
        private Label lblQueue;
        private Label label1;
    }
}
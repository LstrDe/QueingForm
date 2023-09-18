namespace QueingForm
{
    partial class CashierWindowQueueForm
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
            components = new System.ComponentModel.Container();
            bntRefresh = new Button();
            bntNext = new Button();
            listCashierQueue = new ListView();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // bntRefresh
            // 
            bntRefresh.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bntRefresh.Location = new Point(32, 65);
            bntRefresh.Name = "bntRefresh";
            bntRefresh.Size = new Size(116, 33);
            bntRefresh.TabIndex = 0;
            bntRefresh.Text = "Refresh";
            bntRefresh.UseVisualStyleBackColor = true;
            bntRefresh.Click += bntRefresh_Click;
            // 
            // bntNext
            // 
            bntNext.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bntNext.Location = new Point(32, 114);
            bntNext.Name = "bntNext";
            bntNext.Size = new Size(116, 38);
            bntNext.TabIndex = 1;
            bntNext.Text = "Next";
            bntNext.UseVisualStyleBackColor = true;
            bntNext.Click += bntNext_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.Location = new Point(206, 65);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(230, 283);
            listCashierQueue.TabIndex = 2;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 384);
            Controls.Add(listCashierQueue);
            Controls.Add(bntNext);
            Controls.Add(bntRefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            Load += CashierWindowQueueForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bntRefresh;
        private Button bntNext;
        private ListView listCashierQueue;
        private System.Windows.Forms.Timer timer1;
    }
}
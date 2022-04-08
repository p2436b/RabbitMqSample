namespace RabbitMqSample
{
    partial class MainForm
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
            this.btnConnectToRabbitMq = new System.Windows.Forms.Button();
            this.btnCreateExchange = new System.Windows.Forms.Button();
            this.btnCreateQueues = new System.Windows.Forms.Button();
            this.btnBindQueues = new System.Windows.Forms.Button();
            this.btnPublishEmail = new System.Windows.Forms.Button();
            this.txtPublishEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPublishSms = new System.Windows.Forms.TextBox();
            this.btnPublishSms = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEmailMessages = new System.Windows.Forms.ListBox();
            this.btnSubscribeEmailQueue = new System.Windows.Forms.Button();
            this.btnSubscribeSmsQueue = new System.Windows.Forms.Button();
            this.lstSmsMessages = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnectToRabbitMq
            // 
            this.btnConnectToRabbitMq.Location = new System.Drawing.Point(12, 12);
            this.btnConnectToRabbitMq.Name = "btnConnectToRabbitMq";
            this.btnConnectToRabbitMq.Size = new System.Drawing.Size(269, 40);
            this.btnConnectToRabbitMq.TabIndex = 0;
            this.btnConnectToRabbitMq.Text = "Connect to RabbitMQ";
            this.btnConnectToRabbitMq.UseVisualStyleBackColor = true;
            this.btnConnectToRabbitMq.Click += new System.EventHandler(this.btnConnectToRabbitMq_Click);
            // 
            // btnCreateExchange
            // 
            this.btnCreateExchange.Location = new System.Drawing.Point(12, 58);
            this.btnCreateExchange.Name = "btnCreateExchange";
            this.btnCreateExchange.Size = new System.Drawing.Size(269, 40);
            this.btnCreateExchange.TabIndex = 1;
            this.btnCreateExchange.Text = "Create Exchange";
            this.btnCreateExchange.UseVisualStyleBackColor = true;
            this.btnCreateExchange.Click += new System.EventHandler(this.btnCreateExchange_Click);
            // 
            // btnCreateQueues
            // 
            this.btnCreateQueues.Location = new System.Drawing.Point(12, 104);
            this.btnCreateQueues.Name = "btnCreateQueues";
            this.btnCreateQueues.Size = new System.Drawing.Size(269, 40);
            this.btnCreateQueues.TabIndex = 2;
            this.btnCreateQueues.Text = "Create Queues";
            this.btnCreateQueues.UseVisualStyleBackColor = true;
            this.btnCreateQueues.Click += new System.EventHandler(this.btnCreateQueues_Click);
            // 
            // btnBindQueues
            // 
            this.btnBindQueues.Location = new System.Drawing.Point(12, 150);
            this.btnBindQueues.Name = "btnBindQueues";
            this.btnBindQueues.Size = new System.Drawing.Size(269, 40);
            this.btnBindQueues.TabIndex = 3;
            this.btnBindQueues.Text = "Bind Queues";
            this.btnBindQueues.UseVisualStyleBackColor = true;
            this.btnBindQueues.Click += new System.EventHandler(this.btnBindQueues_Click);
            // 
            // btnPublishEmail
            // 
            this.btnPublishEmail.Location = new System.Drawing.Point(12, 318);
            this.btnPublishEmail.Name = "btnPublishEmail";
            this.btnPublishEmail.Size = new System.Drawing.Size(269, 40);
            this.btnPublishEmail.TabIndex = 4;
            this.btnPublishEmail.Text = "Publish Email";
            this.btnPublishEmail.UseVisualStyleBackColor = true;
            this.btnPublishEmail.Click += new System.EventHandler(this.btnPublishEmail_Click);
            // 
            // txtPublishEmail
            // 
            this.txtPublishEmail.Location = new System.Drawing.Point(12, 232);
            this.txtPublishEmail.Multiline = true;
            this.txtPublishEmail.Name = "txtPublishEmail";
            this.txtPublishEmail.Size = new System.Drawing.Size(269, 80);
            this.txtPublishEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Publish Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Publish Sms";
            // 
            // txtPublishSms
            // 
            this.txtPublishSms.Location = new System.Drawing.Point(12, 422);
            this.txtPublishSms.Multiline = true;
            this.txtPublishSms.Name = "txtPublishSms";
            this.txtPublishSms.Size = new System.Drawing.Size(269, 80);
            this.txtPublishSms.TabIndex = 8;
            // 
            // btnPublishSms
            // 
            this.btnPublishSms.Location = new System.Drawing.Point(12, 508);
            this.btnPublishSms.Name = "btnPublishSms";
            this.btnPublishSms.Size = new System.Drawing.Size(269, 40);
            this.btnPublishSms.TabIndex = 7;
            this.btnPublishSms.Text = "Publish Sms";
            this.btnPublishSms.UseVisualStyleBackColor = true;
            this.btnPublishSms.Click += new System.EventHandler(this.btnPublishSms_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // lstEmailMessages
            // 
            this.lstEmailMessages.FormattingEnabled = true;
            this.lstEmailMessages.ItemHeight = 15;
            this.lstEmailMessages.Location = new System.Drawing.Point(332, 30);
            this.lstEmailMessages.Name = "lstEmailMessages";
            this.lstEmailMessages.Size = new System.Drawing.Size(269, 184);
            this.lstEmailMessages.TabIndex = 11;
            // 
            // btnSubscribeEmailQueue
            // 
            this.btnSubscribeEmailQueue.Location = new System.Drawing.Point(332, 220);
            this.btnSubscribeEmailQueue.Name = "btnSubscribeEmailQueue";
            this.btnSubscribeEmailQueue.Size = new System.Drawing.Size(269, 40);
            this.btnSubscribeEmailQueue.TabIndex = 12;
            this.btnSubscribeEmailQueue.Text = "Subscribe Email Queue";
            this.btnSubscribeEmailQueue.UseVisualStyleBackColor = true;
            this.btnSubscribeEmailQueue.Click += new System.EventHandler(this.btnSubscribeEmailQueue_Click);
            // 
            // btnSubscribeSmsQueue
            // 
            this.btnSubscribeSmsQueue.Location = new System.Drawing.Point(332, 508);
            this.btnSubscribeSmsQueue.Name = "btnSubscribeSmsQueue";
            this.btnSubscribeSmsQueue.Size = new System.Drawing.Size(269, 40);
            this.btnSubscribeSmsQueue.TabIndex = 15;
            this.btnSubscribeSmsQueue.Text = "Subscribe Sms Queue";
            this.btnSubscribeSmsQueue.UseVisualStyleBackColor = true;
            this.btnSubscribeSmsQueue.Click += new System.EventHandler(this.btnSubscribeSmsQueue_Click);
            // 
            // lstSmsMessages
            // 
            this.lstSmsMessages.FormattingEnabled = true;
            this.lstSmsMessages.ItemHeight = 15;
            this.lstSmsMessages.Location = new System.Drawing.Point(332, 318);
            this.lstSmsMessages.Name = "lstSmsMessages";
            this.lstSmsMessages.Size = new System.Drawing.Size(269, 184);
            this.lstSmsMessages.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 560);
            this.Controls.Add(this.btnSubscribeSmsQueue);
            this.Controls.Add(this.lstSmsMessages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubscribeEmailQueue);
            this.Controls.Add(this.lstEmailMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPublishSms);
            this.Controls.Add(this.btnPublishSms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPublishEmail);
            this.Controls.Add(this.btnPublishEmail);
            this.Controls.Add(this.btnBindQueues);
            this.Controls.Add(this.btnCreateQueues);
            this.Controls.Add(this.btnCreateExchange);
            this.Controls.Add(this.btnConnectToRabbitMq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "RabbitMQ Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConnectToRabbitMq;
        private Button btnCreateExchange;
        private Button btnCreateQueues;
        private Button btnBindQueues;
        private Button btnPublishEmail;
        private TextBox txtPublishEmail;
        private Label label1;
        private Label label2;
        private TextBox txtPublishSms;
        private Button btnPublishSms;
        private Label label3;
        private ListBox lstEmailMessages;
        private Button btnSubscribeEmailQueue;
        private Button btnSubscribeSmsQueue;
        private ListBox lstSmsMessages;
        private Label label4;
    }
}
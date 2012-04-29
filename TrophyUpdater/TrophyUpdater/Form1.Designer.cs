namespace TrophyUpdater
{
    partial class Ps3trophyupdater
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
            this.components = new System.ComponentModel.Container();
            this.btnManualRun = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetNextTask = new System.Windows.Forms.Button();
            this.tmrExecuteTask = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblAppStarted = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExecutions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManualRun
            // 
            this.btnManualRun.Location = new System.Drawing.Point(307, 201);
            this.btnManualRun.Name = "btnManualRun";
            this.btnManualRun.Size = new System.Drawing.Size(134, 58);
            this.btnManualRun.TabIndex = 0;
            this.btnManualRun.Text = "Manual Run";
            this.btnManualRun.UseVisualStyleBackColor = true;
            this.btnManualRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(307, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PSNID";
            // 
            // btnGetNextTask
            // 
            this.btnGetNextTask.Location = new System.Drawing.Point(307, 54);
            this.btnGetNextTask.Name = "btnGetNextTask";
            this.btnGetNextTask.Size = new System.Drawing.Size(134, 59);
            this.btnGetNextTask.TabIndex = 3;
            this.btnGetNextTask.Text = "get the next task";
            this.btnGetNextTask.UseVisualStyleBackColor = true;
            this.btnGetNextTask.Click += new System.EventHandler(this.btnGetNextTask_Click);
            // 
            // tmrExecuteTask
            // 
            this.tmrExecuteTask.Enabled = true;
            this.tmrExecuteTask.Interval = 60000;
            this.tmrExecuteTask.Tick += new System.EventHandler(this.tmrExecuteTask_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "App started on";
            // 
            // lblAppStarted
            // 
            this.lblAppStarted.AutoSize = true;
            this.lblAppStarted.Location = new System.Drawing.Point(304, 310);
            this.lblAppStarted.Name = "lblAppStarted";
            this.lblAppStarted.Size = new System.Drawing.Size(52, 13);
            this.lblAppStarted.TabIndex = 5;
            this.lblAppStarted.Text = "StartTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(304, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Executions";
            // 
            // lblExecutions
            // 
            this.lblExecutions.AutoSize = true;
            this.lblExecutions.Location = new System.Drawing.Point(304, 362);
            this.lblExecutions.Name = "lblExecutions";
            this.lblExecutions.Size = new System.Drawing.Size(59, 13);
            this.lblExecutions.TabIndex = 7;
            this.lblExecutions.Text = "Executions";
            // 
            // Ps3trophyupdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 384);
            this.Controls.Add(this.lblExecutions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAppStarted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetNextTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnManualRun);
            this.Name = "Ps3trophyupdater";
            this.Text = "PS3Trophy Updater";
            this.Load += new System.EventHandler(this.Ps3trophyupdater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManualRun;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetNextTask;
        private System.Windows.Forms.Timer tmrExecuteTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAppStarted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExecutions;
    }
}


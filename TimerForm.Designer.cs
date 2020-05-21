namespace Timers_CSharp
{
    partial class TimerForm
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
            this.btnFlash = new System.Windows.Forms.Button();
            this.lblFlash = new System.Windows.Forms.Label();
            this.tmrFlashText = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTimePassed = new System.Windows.Forms.Label();
            this.tmrStopWatch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnFlash
            // 
            this.btnFlash.Location = new System.Drawing.Point(49, 12);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(75, 23);
            this.btnFlash.TabIndex = 0;
            this.btnFlash.Text = "Flash Text";
            this.btnFlash.UseVisualStyleBackColor = true;
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // lblFlash
            // 
            this.lblFlash.AutoSize = true;
            this.lblFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlash.Location = new System.Drawing.Point(12, 48);
            this.lblFlash.Name = "lblFlash";
            this.lblFlash.Size = new System.Drawing.Size(160, 24);
            this.lblFlash.TabIndex = 1;
            this.lblFlash.Text = "Flashing is Fun!";
            // 
            // tmrFlashText
            // 
            this.tmrFlashText.Interval = 300;
            this.tmrFlashText.Tick += new System.EventHandler(this.tmrFlashText_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(203, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Timer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(203, 70);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Timer";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(203, 41);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop Timer";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTimePassed
            // 
            this.lblTimePassed.AutoSize = true;
            this.lblTimePassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePassed.Location = new System.Drawing.Point(295, 38);
            this.lblTimePassed.Name = "lblTimePassed";
            this.lblTimePassed.Size = new System.Drawing.Size(21, 24);
            this.lblTimePassed.TabIndex = 5;
            this.lblTimePassed.Text = "0";
            // 
            // tmrStopWatch
            // 
            this.tmrStopWatch.Interval = 1000;
            this.tmrStopWatch.Tick += new System.EventHandler(this.tmrStopWatch_Tick);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 116);
            this.Controls.Add(this.lblTimePassed);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblFlash);
            this.Controls.Add(this.btnFlash);
            this.Name = "TimerForm";
            this.Text = "Timers Demo";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlash;
        private System.Windows.Forms.Label lblFlash;
        private System.Windows.Forms.Timer tmrFlashText;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTimePassed;
        private System.Windows.Forms.Timer tmrStopWatch;
    }
}


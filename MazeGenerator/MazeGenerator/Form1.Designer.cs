namespace MazeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer 

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.picMaze = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WIDTH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HEIGHT";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(12, 116);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(73, 20);
            this.txtWidth.TabIndex = 2;
            this.txtWidth.Text = "10";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(12, 156);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(73, 20);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.Text = "10";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 13);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 75);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "CREATE";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // picMaze
            // 
            this.picMaze.Location = new System.Drawing.Point(90, 13);
            this.picMaze.MinimumSize = new System.Drawing.Size(420, 260);
            this.picMaze.Name = "picMaze";
            this.picMaze.Size = new System.Drawing.Size(420, 260);
            this.picMaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMaze.TabIndex = 4;
            this.picMaze.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 280);
            this.Controls.Add(this.picMaze);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MazeGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.PictureBox picMaze;
    }
}


namespace lab8
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.yesOrNoLabel = new System.Windows.Forms.Label();
            this.predictionLabel = new System.Windows.Forms.Label();
            this.predictionButton = new System.Windows.Forms.Button();
            this.yesOrNoButton = new System.Windows.Forms.Button();
            this.yesOrNoAnswerLabel = new System.Windows.Forms.Label();
            this.predictionAnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yesOrNoLabel
            // 
            this.yesOrNoLabel.AutoSize = true;
            this.yesOrNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yesOrNoLabel.Location = new System.Drawing.Point(33, 37);
            this.yesOrNoLabel.Name = "yesOrNoLabel";
            this.yesOrNoLabel.Size = new System.Drawing.Size(191, 20);
            this.yesOrNoLabel.TabIndex = 0;
            this.yesOrNoLabel.Text = "Получить ответ да/нет:";
            // 
            // predictionLabel
            // 
            this.predictionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predictionLabel.Location = new System.Drawing.Point(305, 24);
            this.predictionLabel.Name = "predictionLabel";
            this.predictionLabel.Size = new System.Drawing.Size(221, 46);
            this.predictionLabel.TabIndex = 1;
            this.predictionLabel.Text = "Получить одно из двадцати предсказаний:";
            // 
            // predictionButton
            // 
            this.predictionButton.Location = new System.Drawing.Point(355, 75);
            this.predictionButton.Name = "predictionButton";
            this.predictionButton.Size = new System.Drawing.Size(75, 23);
            this.predictionButton.TabIndex = 3;
            this.predictionButton.Text = "Получить";
            this.predictionButton.UseVisualStyleBackColor = true;
            this.predictionButton.Click += new System.EventHandler(this.predictionButton_Click);
            // 
            // yesOrNoButton
            // 
            this.yesOrNoButton.Location = new System.Drawing.Point(88, 75);
            this.yesOrNoButton.Name = "yesOrNoButton";
            this.yesOrNoButton.Size = new System.Drawing.Size(75, 23);
            this.yesOrNoButton.TabIndex = 4;
            this.yesOrNoButton.Text = "Получить";
            this.yesOrNoButton.UseVisualStyleBackColor = true;
            this.yesOrNoButton.Click += new System.EventHandler(this.yesOrNoButton_Click);
            // 
            // yesOrNoAnswerLabel
            // 
            this.yesOrNoAnswerLabel.AutoSize = true;
            this.yesOrNoAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yesOrNoAnswerLabel.Location = new System.Drawing.Point(91, 126);
            this.yesOrNoAnswerLabel.Name = "yesOrNoAnswerLabel";
            this.yesOrNoAnswerLabel.Size = new System.Drawing.Size(0, 37);
            this.yesOrNoAnswerLabel.TabIndex = 5;
            // 
            // predictionAnswerLabel
            // 
            this.predictionAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predictionAnswerLabel.Location = new System.Drawing.Point(287, 126);
            this.predictionAnswerLabel.Name = "predictionAnswerLabel";
            this.predictionAnswerLabel.Size = new System.Drawing.Size(224, 102);
            this.predictionAnswerLabel.TabIndex = 6;
            this.predictionAnswerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 237);
            this.Controls.Add(this.predictionAnswerLabel);
            this.Controls.Add(this.yesOrNoAnswerLabel);
            this.Controls.Add(this.yesOrNoButton);
            this.Controls.Add(this.predictionButton);
            this.Controls.Add(this.predictionLabel);
            this.Controls.Add(this.yesOrNoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yesOrNoLabel;
        private System.Windows.Forms.Label predictionLabel;
        private System.Windows.Forms.Button predictionButton;
        private System.Windows.Forms.Button yesOrNoButton;
        private System.Windows.Forms.Label yesOrNoAnswerLabel;
        private System.Windows.Forms.Label predictionAnswerLabel;
    }
}


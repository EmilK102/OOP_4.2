
namespace Lab_4._2
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
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.numericC = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).BeginInit();
            this.SuspendLayout();
            // 
            // numericA
            // 
            this.numericA.Location = new System.Drawing.Point(12, 130);
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(120, 22);
            this.numericA.TabIndex = 0;
            this.numericA.ValueChanged += new System.EventHandler(this.numericA_ValueChanged);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(12, 101);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(120, 22);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(12, 158);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(120, 56);
            this.trackBarA.TabIndex = 5;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(138, 157);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(120, 56);
            this.trackBarB.TabIndex = 5;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(138, 101);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(120, 22);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxB_KeyDown);
            // 
            // numericB
            // 
            this.numericB.Location = new System.Drawing.Point(138, 129);
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(120, 22);
            this.numericB.TabIndex = 3;
            this.numericB.ValueChanged += new System.EventHandler(this.numericB_ValueChanged);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(264, 157);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(120, 56);
            this.trackBarC.TabIndex = 8;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBarC_Scroll);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(264, 101);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(120, 22);
            this.textBoxC.TabIndex = 7;
            this.textBoxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            // 
            // numericC
            // 
            this.numericC.Location = new System.Drawing.Point(264, 129);
            this.numericC.Name = "numericC";
            this.numericC.Size = new System.Drawing.Size(120, 22);
            this.numericC.TabIndex = 6;
            this.numericC.ValueChanged += new System.EventHandler(this.numericC_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 67);
            this.label1.TabIndex = 9;
            this.label1.Text = "A <= B <= C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.numericC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.numericB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.numericA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.NumericUpDown numericC;
        private System.Windows.Forms.Label label1;
    }
}


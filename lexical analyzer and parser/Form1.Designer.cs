namespace lexical_analyzer_and_parser
{
    partial class Form1
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
            this.ST = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.CodeOutput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ST
            // 
            this.ST.Location = new System.Drawing.Point(227, 230);
            this.ST.Name = "ST";
            this.ST.Size = new System.Drawing.Size(363, 109);
            this.ST.TabIndex = 1;
            this.ST.Text = "";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(93, 68);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(249, 99);
            this.Input.TabIndex = 2;
            this.Input.Text = "";
            // 
            // CodeOutput
            // 
            this.CodeOutput.Location = new System.Drawing.Point(496, 68);
            this.CodeOutput.Name = "CodeOutput";
            this.CodeOutput.Size = new System.Drawing.Size(249, 99);
            this.CodeOutput.TabIndex = 3;
            this.CodeOutput.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Code Output";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(385, 401);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(10, 10);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Symbol Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CodeOutput);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox ST;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.RichTextBox CodeOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label label2;
    }
}


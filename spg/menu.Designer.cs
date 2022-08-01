
namespace spg
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.trainBox = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.trainLabel = new System.Windows.Forms.Label();
            this.sidingBox = new System.Windows.Forms.ListBox();
            this.optionsBox = new System.Windows.Forms.GroupBox();
            this.newPuzzleBtn = new System.Windows.Forms.Button();
            this.checkSortByIndustry = new System.Windows.Forms.CheckBox();
            this.checkSortTrain = new System.Windows.Forms.CheckBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.trainLengthControl = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.optionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainLengthControl)).BeginInit();
            this.SuspendLayout();
            // 
            // trainBox
            // 
            this.trainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainBox.Location = new System.Drawing.Point(12, 73);
            this.trainBox.Name = "trainBox";
            this.trainBox.Size = new System.Drawing.Size(776, 29);
            this.trainBox.TabIndex = 0;
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.InitialImage = null;
            this.logoBox.Location = new System.Drawing.Point(12, 13);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(213, 37);
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // trainLabel
            // 
            this.trainLabel.AutoSize = true;
            this.trainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainLabel.Location = new System.Drawing.Point(12, 53);
            this.trainLabel.Name = "trainLabel";
            this.trainLabel.Size = new System.Drawing.Size(64, 16);
            this.trainLabel.TabIndex = 2;
            this.trainLabel.Text = "your train:";
            // 
            // sidingBox
            // 
            this.sidingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sidingBox.FormattingEnabled = true;
            this.sidingBox.ItemHeight = 24;
            this.sidingBox.Location = new System.Drawing.Point(13, 160);
            this.sidingBox.Name = "sidingBox";
            this.sidingBox.Size = new System.Drawing.Size(500, 268);
            this.sidingBox.TabIndex = 3;
            // 
            // optionsBox
            // 
            this.optionsBox.Controls.Add(this.label1);
            this.optionsBox.Controls.Add(this.trainLengthControl);
            this.optionsBox.Controls.Add(this.editBtn);
            this.optionsBox.Controls.Add(this.checkSortTrain);
            this.optionsBox.Controls.Add(this.checkSortByIndustry);
            this.optionsBox.Controls.Add(this.newPuzzleBtn);
            this.optionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionsBox.Location = new System.Drawing.Point(519, 109);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Padding = new System.Windows.Forms.Padding(6);
            this.optionsBox.Size = new System.Drawing.Size(268, 318);
            this.optionsBox.TabIndex = 5;
            this.optionsBox.TabStop = false;
            this.optionsBox.Text = "options for puzzle generation";
            // 
            // newPuzzleBtn
            // 
            this.newPuzzleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPuzzleBtn.Location = new System.Drawing.Point(16, 274);
            this.newPuzzleBtn.Margin = new System.Windows.Forms.Padding(10);
            this.newPuzzleBtn.Name = "newPuzzleBtn";
            this.newPuzzleBtn.Size = new System.Drawing.Size(236, 28);
            this.newPuzzleBtn.TabIndex = 0;
            this.newPuzzleBtn.Text = "generate new puzzle";
            this.newPuzzleBtn.UseVisualStyleBackColor = true;
            this.newPuzzleBtn.Click += new System.EventHandler(this.newPuzzleBtn_Click);
            // 
            // checkSortByIndustry
            // 
            this.checkSortByIndustry.AutoSize = true;
            this.checkSortByIndustry.Checked = true;
            this.checkSortByIndustry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSortByIndustry.Location = new System.Drawing.Point(9, 22);
            this.checkSortByIndustry.Name = "checkSortByIndustry";
            this.checkSortByIndustry.Size = new System.Drawing.Size(182, 20);
            this.checkSortByIndustry.TabIndex = 2;
            this.checkSortByIndustry.Text = "sort distribution by industry";
            this.checkSortByIndustry.UseVisualStyleBackColor = true;
            this.checkSortByIndustry.CheckedChanged += new System.EventHandler(this.checkSortByIndustry_CheckedChanged);
            // 
            // checkSortTrain
            // 
            this.checkSortTrain.AutoSize = true;
            this.checkSortTrain.Location = new System.Drawing.Point(9, 45);
            this.checkSortTrain.Name = "checkSortTrain";
            this.checkSortTrain.Size = new System.Drawing.Size(169, 20);
            this.checkSortTrain.TabIndex = 3;
            this.checkSortTrain.Text = "sort train by vehicle type";
            this.checkSortTrain.UseVisualStyleBackColor = true;
            this.checkSortTrain.CheckedChanged += new System.EventHandler(this.checkSortTrain_CheckedChanged);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBtn.Location = new System.Drawing.Point(16, 238);
            this.editBtn.Margin = new System.Windows.Forms.Padding(10);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(236, 28);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "edit vehicles/sidings";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // trainLengthControl
            // 
            this.trainLengthControl.Location = new System.Drawing.Point(9, 68);
            this.trainLengthControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trainLengthControl.Name = "trainLengthControl";
            this.trainLengthControl.Size = new System.Drawing.Size(32, 22);
            this.trainLengthControl.TabIndex = 6;
            this.trainLengthControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trainLengthControl.ValueChanged += new System.EventHandler(this.trainLengthControl_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "maximum train length (vehicles)";
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.SystemColors.Menu;
            this.instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructions.Location = new System.Drawing.Point(12, 105);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(500, 53);
            this.instructions.TabIndex = 6;
            this.instructions.Text = resources.GetString("instructions.Text");
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.sidingBox);
            this.Controls.Add(this.trainLabel);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.trainBox);
            this.Name = "menu";
            this.Text = "Shunt Puzzle Generator";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.optionsBox.ResumeLayout(false);
            this.optionsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainLengthControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox trainBox;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label trainLabel;
        private System.Windows.Forms.ListBox sidingBox;
        private System.Windows.Forms.GroupBox optionsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown trainLengthControl;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.CheckBox checkSortTrain;
        private System.Windows.Forms.CheckBox checkSortByIndustry;
        private System.Windows.Forms.Button newPuzzleBtn;
        private System.Windows.Forms.RichTextBox instructions;
    }
}


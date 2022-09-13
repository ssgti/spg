
namespace spg
{
    partial class setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setup));
            this.itemList = new System.Windows.Forms.ListBox();
            this.createBox = new System.Windows.Forms.GroupBox();
            this.lengthInfoBox = new System.Windows.Forms.RichTextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.industryBox = new System.Windows.Forms.TextBox();
            this.industryLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.vehicleRBtn = new System.Windows.Forms.RadioButton();
            this.sidingRBtn = new System.Windows.Forms.RadioButton();
            this.editLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.createBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemList
            // 
            this.itemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 24;
            this.itemList.Location = new System.Drawing.Point(408, 12);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(380, 412);
            this.itemList.TabIndex = 0;
            // 
            // createBox
            // 
            this.createBox.Controls.Add(this.errorLabel);
            this.createBox.Controls.Add(this.lengthInfoBox);
            this.createBox.Controls.Add(this.lengthBox);
            this.createBox.Controls.Add(this.lengthLabel);
            this.createBox.Controls.Add(this.industryBox);
            this.createBox.Controls.Add(this.industryLabel);
            this.createBox.Controls.Add(this.nameBox);
            this.createBox.Controls.Add(this.nameLabel);
            this.createBox.Controls.Add(this.removeBtn);
            this.createBox.Controls.Add(this.addBtn);
            this.createBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createBox.Location = new System.Drawing.Point(12, 114);
            this.createBox.Name = "createBox";
            this.createBox.Padding = new System.Windows.Forms.Padding(6);
            this.createBox.Size = new System.Drawing.Size(379, 309);
            this.createBox.TabIndex = 1;
            this.createBox.TabStop = false;
            this.createBox.Text = "create new";
            // 
            // lengthInfoBox
            // 
            this.lengthInfoBox.BackColor = System.Drawing.SystemColors.Menu;
            this.lengthInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lengthInfoBox.Location = new System.Drawing.Point(9, 171);
            this.lengthInfoBox.Name = "lengthInfoBox";
            this.lengthInfoBox.Size = new System.Drawing.Size(361, 95);
            this.lengthInfoBox.TabIndex = 8;
            this.lengthInfoBox.Text = resources.GetString("lengthInfoBox.Text");
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(9, 142);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 22);
            this.lengthBox.TabIndex = 7;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(10, 123);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(51, 16);
            this.lengthLabel.TabIndex = 6;
            this.lengthLabel.Text = "length*:";
            // 
            // industryBox
            // 
            this.industryBox.Location = new System.Drawing.Point(9, 94);
            this.industryBox.Name = "industryBox";
            this.industryBox.Size = new System.Drawing.Size(361, 22);
            this.industryBox.TabIndex = 5;
            // 
            // industryLabel
            // 
            this.industryLabel.AutoSize = true;
            this.industryLabel.Location = new System.Drawing.Point(10, 74);
            this.industryLabel.Name = "industryLabel";
            this.industryLabel.Size = new System.Drawing.Size(85, 16);
            this.industryLabel.TabIndex = 4;
            this.industryLabel.Text = "industry type:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(9, 45);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(361, 22);
            this.nameBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "name/identifier:";
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeBtn.Location = new System.Drawing.Point(193, 272);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(177, 28);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "remove selected";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(9, 272);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(177, 28);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "add new";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // vehicleRBtn
            // 
            this.vehicleRBtn.AutoSize = true;
            this.vehicleRBtn.Checked = true;
            this.vehicleRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicleRBtn.Location = new System.Drawing.Point(316, 31);
            this.vehicleRBtn.Name = "vehicleRBtn";
            this.vehicleRBtn.Size = new System.Drawing.Size(75, 20);
            this.vehicleRBtn.TabIndex = 2;
            this.vehicleRBtn.TabStop = true;
            this.vehicleRBtn.Text = "vehicles";
            this.vehicleRBtn.UseVisualStyleBackColor = true;
            this.vehicleRBtn.CheckedChanged += new System.EventHandler(this.vehicleRBtn_CheckedChanged);
            // 
            // sidingRBtn
            // 
            this.sidingRBtn.AutoSize = true;
            this.sidingRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sidingRBtn.Location = new System.Drawing.Point(316, 57);
            this.sidingRBtn.Name = "sidingRBtn";
            this.sidingRBtn.Size = new System.Drawing.Size(68, 20);
            this.sidingRBtn.TabIndex = 3;
            this.sidingRBtn.Text = "sidings";
            this.sidingRBtn.UseVisualStyleBackColor = true;
            this.sidingRBtn.CheckedChanged += new System.EventHandler(this.sidingRBtn_CheckedChanged);
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editLabel.Location = new System.Drawing.Point(332, 12);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(50, 16);
            this.editLabel.TabIndex = 4;
            this.editLabel.Text = "editing:";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(316, 83);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 25);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.Menu;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoBox.Location = new System.Drawing.Point(22, 22);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(269, 68);
            this.infoBox.TabIndex = 6;
            this.infoBox.Text = "use this menu to create and remove vehicles and sidings for use in puzzle generat" +
    "ion.\nyou can switch between editing vehicles and editing sidings using the butto" +
    "ns to the right.";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(9, 250);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(10, 16);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = " ";
            // 
            // setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.sidingRBtn);
            this.Controls.Add(this.vehicleRBtn);
            this.Controls.Add(this.createBox);
            this.Controls.Add(this.itemList);
            this.Name = "setup";
            this.Text = "Shunt Puzzle Generator";
            this.createBox.ResumeLayout(false);
            this.createBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.GroupBox createBox;
        private System.Windows.Forms.RadioButton vehicleRBtn;
        private System.Windows.Forms.RadioButton sidingRBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.RichTextBox lengthInfoBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox industryBox;
        private System.Windows.Forms.Label industryLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Label errorLabel;
    }
}
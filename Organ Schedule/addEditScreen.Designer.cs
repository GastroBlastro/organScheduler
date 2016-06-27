namespace Organ_Schedule
{
    partial class addEditScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLabel = new System.Windows.Forms.Label();
            this.churchBox = new System.Windows.Forms.TextBox();
            this.churchLabel = new System.Windows.Forms.Label();
            this.hymnAddLabel = new System.Windows.Forms.Label();
            this.hymnBox = new System.Windows.Forms.TextBox();
            this.hymnAddList = new System.Windows.Forms.ListView();
            this.hymnAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.preludeBox = new System.Windows.Forms.TextBox();
            this.offertoryBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.postludeBox = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.otherAddButton = new System.Windows.Forms.Button();
            this.otherAddList = new System.Windows.Forms.ListView();
            this.otherAddLabel = new System.Windows.Forms.Label();
            this.otherBox = new System.Windows.Forms.TextBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(35, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(128, 78);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Add/Edit\r\nService";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // churchBox
            // 
            this.churchBox.Location = new System.Drawing.Point(72, 83);
            this.churchBox.Name = "churchBox";
            this.churchBox.Size = new System.Drawing.Size(100, 20);
            this.churchBox.TabIndex = 1;
            // 
            // churchLabel
            // 
            this.churchLabel.AutoSize = true;
            this.churchLabel.Location = new System.Drawing.Point(19, 86);
            this.churchLabel.Name = "churchLabel";
            this.churchLabel.Size = new System.Drawing.Size(44, 13);
            this.churchLabel.TabIndex = 2;
            this.churchLabel.Text = "Church:";
            // 
            // hymnAddLabel
            // 
            this.hymnAddLabel.AutoSize = true;
            this.hymnAddLabel.Location = new System.Drawing.Point(19, 121);
            this.hymnAddLabel.Name = "hymnAddLabel";
            this.hymnAddLabel.Size = new System.Drawing.Size(42, 13);
            this.hymnAddLabel.TabIndex = 4;
            this.hymnAddLabel.Text = "Hymns:";
            // 
            // hymnBox
            // 
            this.hymnBox.Location = new System.Drawing.Point(72, 118);
            this.hymnBox.Name = "hymnBox";
            this.hymnBox.Size = new System.Drawing.Size(100, 20);
            this.hymnBox.TabIndex = 3;
            // 
            // hymnAddList
            // 
            this.hymnAddList.Location = new System.Drawing.Point(22, 176);
            this.hymnAddList.Name = "hymnAddList";
            this.hymnAddList.Size = new System.Drawing.Size(150, 33);
            this.hymnAddList.TabIndex = 5;
            this.hymnAddList.UseCompatibleStateImageBehavior = false;
            // 
            // hymnAddButton
            // 
            this.hymnAddButton.Location = new System.Drawing.Point(57, 144);
            this.hymnAddButton.Name = "hymnAddButton";
            this.hymnAddButton.Size = new System.Drawing.Size(75, 23);
            this.hymnAddButton.TabIndex = 6;
            this.hymnAddButton.Text = "Add";
            this.hymnAddButton.UseVisualStyleBackColor = true;
            this.hymnAddButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prelude:";
            // 
            // preludeBox
            // 
            this.preludeBox.Location = new System.Drawing.Point(72, 224);
            this.preludeBox.Name = "preludeBox";
            this.preludeBox.Size = new System.Drawing.Size(100, 20);
            this.preludeBox.TabIndex = 7;
            // 
            // offertoryBox
            // 
            this.offertoryBox.AutoSize = true;
            this.offertoryBox.Location = new System.Drawing.Point(19, 262);
            this.offertoryBox.Name = "offertoryBox";
            this.offertoryBox.Size = new System.Drawing.Size(50, 13);
            this.offertoryBox.TabIndex = 10;
            this.offertoryBox.Text = "Offertory:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // postludeBox
            // 
            this.postludeBox.AutoSize = true;
            this.postludeBox.Location = new System.Drawing.Point(19, 297);
            this.postludeBox.Name = "postludeBox";
            this.postludeBox.Size = new System.Drawing.Size(51, 13);
            this.postludeBox.TabIndex = 12;
            this.postludeBox.Text = "Postlude:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // otherAddButton
            // 
            this.otherAddButton.Location = new System.Drawing.Point(57, 355);
            this.otherAddButton.Name = "otherAddButton";
            this.otherAddButton.Size = new System.Drawing.Size(75, 23);
            this.otherAddButton.TabIndex = 16;
            this.otherAddButton.Text = "Add";
            this.otherAddButton.UseVisualStyleBackColor = true;
            this.otherAddButton.Click += new System.EventHandler(this.otherAddButton_Click);
            // 
            // otherAddList
            // 
            this.otherAddList.Location = new System.Drawing.Point(22, 387);
            this.otherAddList.Name = "otherAddList";
            this.otherAddList.Size = new System.Drawing.Size(150, 33);
            this.otherAddList.TabIndex = 15;
            this.otherAddList.UseCompatibleStateImageBehavior = false;
            // 
            // otherAddLabel
            // 
            this.otherAddLabel.AutoSize = true;
            this.otherAddLabel.Location = new System.Drawing.Point(19, 332);
            this.otherAddLabel.Name = "otherAddLabel";
            this.otherAddLabel.Size = new System.Drawing.Size(36, 13);
            this.otherAddLabel.TabIndex = 14;
            this.otherAddLabel.Text = "Other:";
            // 
            // otherBox
            // 
            this.otherBox.Location = new System.Drawing.Point(72, 329);
            this.otherBox.Name = "otherBox";
            this.otherBox.Size = new System.Drawing.Size(100, 20);
            this.otherBox.TabIndex = 13;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(57, 426);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 17;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // addEditScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.otherAddButton);
            this.Controls.Add(this.otherAddList);
            this.Controls.Add(this.otherAddLabel);
            this.Controls.Add(this.otherBox);
            this.Controls.Add(this.postludeBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.offertoryBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preludeBox);
            this.Controls.Add(this.hymnAddButton);
            this.Controls.Add(this.hymnAddList);
            this.Controls.Add(this.hymnAddLabel);
            this.Controls.Add(this.hymnBox);
            this.Controls.Add(this.churchLabel);
            this.Controls.Add(this.churchBox);
            this.Controls.Add(this.mainLabel);
            this.Name = "addEditScreen";
            this.Size = new System.Drawing.Size(199, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.TextBox churchBox;
        private System.Windows.Forms.Label churchLabel;
        private System.Windows.Forms.Label hymnAddLabel;
        private System.Windows.Forms.ListView hymnAddList;
        private System.Windows.Forms.Button hymnAddButton;
        private System.Windows.Forms.TextBox hymnBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox preludeBox;
        private System.Windows.Forms.Label offertoryBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label postludeBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button otherAddButton;
        private System.Windows.Forms.ListView otherAddList;
        private System.Windows.Forms.Label otherAddLabel;
        private System.Windows.Forms.TextBox otherBox;
        private System.Windows.Forms.Button finishButton;
    }
}

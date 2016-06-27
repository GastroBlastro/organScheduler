namespace Organ_Schedule
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
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.logoLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.churchLabel = new System.Windows.Forms.Label();
            this.hymnTitleLabel = new System.Windows.Forms.Label();
            this.preTitleLabel = new System.Windows.Forms.Label();
            this.preLabel = new System.Windows.Forms.Label();
            this.offTitleLabel = new System.Windows.Forms.Label();
            this.offLabel = new System.Windows.Forms.Label();
            this.postLabel = new System.Windows.Forms.Label();
            this.postTitleLabel = new System.Windows.Forms.Label();
            this.otherTitleLabel = new System.Windows.Forms.Label();
            this.addEditPlacementLabel = new System.Windows.Forms.Label();
            this.hymnList = new System.Windows.Forms.ListView();
            this.otherList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // calender
            // 
            this.calender.BackColor = System.Drawing.SystemColors.Control;
            this.calender.CalendarDimensions = new System.Drawing.Size(2, 3);
            this.calender.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.calender.Location = new System.Drawing.Point(3, 3);
            this.calender.MaxSelectionCount = 1;
            this.calender.Name = "calender";
            this.calender.ShowWeekNumbers = true;
            this.calender.TabIndex = 0;
            this.calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(528, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(170, 45);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "Organ-izer";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.Location = new System.Drawing.Point(524, 54);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(179, 7);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "© Prodigium Music Inc. MMXVI ~ All Rights Reserved";
            // 
            // churchLabel
            // 
            this.churchLabel.AutoSize = true;
            this.churchLabel.Location = new System.Drawing.Point(526, 82);
            this.churchLabel.Name = "churchLabel";
            this.churchLabel.Size = new System.Drawing.Size(66, 13);
            this.churchLabel.TabIndex = 3;
            this.churchLabel.Text = "churchLabel";
            // 
            // hymnTitleLabel
            // 
            this.hymnTitleLabel.AutoSize = true;
            this.hymnTitleLabel.Location = new System.Drawing.Point(526, 110);
            this.hymnTitleLabel.Name = "hymnTitleLabel";
            this.hymnTitleLabel.Size = new System.Drawing.Size(42, 13);
            this.hymnTitleLabel.TabIndex = 4;
            this.hymnTitleLabel.Text = "Hymns:";
            // 
            // preTitleLabel
            // 
            this.preTitleLabel.AutoSize = true;
            this.preTitleLabel.Location = new System.Drawing.Point(526, 234);
            this.preTitleLabel.Name = "preTitleLabel";
            this.preTitleLabel.Size = new System.Drawing.Size(46, 13);
            this.preTitleLabel.TabIndex = 6;
            this.preTitleLabel.Text = "Prelude:";
            // 
            // preLabel
            // 
            this.preLabel.AutoSize = true;
            this.preLabel.Location = new System.Drawing.Point(526, 247);
            this.preLabel.Name = "preLabel";
            this.preLabel.Size = new System.Drawing.Size(84, 13);
            this.preLabel.TabIndex = 7;
            this.preLabel.Text = "Prelude - person";
            // 
            // offTitleLabel
            // 
            this.offTitleLabel.AutoSize = true;
            this.offTitleLabel.Location = new System.Drawing.Point(526, 273);
            this.offTitleLabel.Name = "offTitleLabel";
            this.offTitleLabel.Size = new System.Drawing.Size(50, 13);
            this.offTitleLabel.TabIndex = 8;
            this.offTitleLabel.Text = "Offertory:";
            // 
            // offLabel
            // 
            this.offLabel.AutoSize = true;
            this.offLabel.Location = new System.Drawing.Point(526, 286);
            this.offLabel.Name = "offLabel";
            this.offLabel.Size = new System.Drawing.Size(88, 13);
            this.offLabel.TabIndex = 9;
            this.offLabel.Text = "Offertory - person";
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Location = new System.Drawing.Point(526, 323);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(89, 13);
            this.postLabel.TabIndex = 11;
            this.postLabel.Text = "Postlude - person";
            // 
            // postTitleLabel
            // 
            this.postTitleLabel.AutoSize = true;
            this.postTitleLabel.Location = new System.Drawing.Point(526, 310);
            this.postTitleLabel.Name = "postTitleLabel";
            this.postTitleLabel.Size = new System.Drawing.Size(51, 13);
            this.postTitleLabel.TabIndex = 10;
            this.postTitleLabel.Text = "Postlude:";
            // 
            // otherTitleLabel
            // 
            this.otherTitleLabel.AutoSize = true;
            this.otherTitleLabel.Location = new System.Drawing.Point(526, 347);
            this.otherTitleLabel.Name = "otherTitleLabel";
            this.otherTitleLabel.Size = new System.Drawing.Size(36, 13);
            this.otherTitleLabel.TabIndex = 12;
            this.otherTitleLabel.Text = "Other:";
            // 
            // addEditPlacementLabel
            // 
            this.addEditPlacementLabel.Location = new System.Drawing.Point(514, 3);
            this.addEditPlacementLabel.Name = "addEditPlacementLabel";
            this.addEditPlacementLabel.Size = new System.Drawing.Size(199, 460);
            this.addEditPlacementLabel.TabIndex = 14;
            // 
            // hymnList
            // 
            this.hymnList.Location = new System.Drawing.Point(529, 127);
            this.hymnList.Name = "hymnList";
            this.hymnList.Size = new System.Drawing.Size(169, 97);
            this.hymnList.TabIndex = 15;
            this.hymnList.UseCompatibleStateImageBehavior = false;
            // 
            // otherList
            // 
            this.otherList.Location = new System.Drawing.Point(529, 363);
            this.otherList.Name = "otherList";
            this.otherList.Size = new System.Drawing.Size(169, 97);
            this.otherList.TabIndex = 16;
            this.otherList.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(725, 466);
            this.Controls.Add(this.otherList);
            this.Controls.Add(this.hymnList);
            this.Controls.Add(this.otherTitleLabel);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.postTitleLabel);
            this.Controls.Add(this.offLabel);
            this.Controls.Add(this.offTitleLabel);
            this.Controls.Add(this.preLabel);
            this.Controls.Add(this.preTitleLabel);
            this.Controls.Add(this.hymnTitleLabel);
            this.Controls.Add(this.churchLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.addEditPlacementLabel);
            this.Name = "Form1";
            this.Text = "Organ-izer";
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Form1_ControlRemoved);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calender;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label churchLabel;
        private System.Windows.Forms.Label hymnTitleLabel;
        private System.Windows.Forms.Label preTitleLabel;
        private System.Windows.Forms.Label preLabel;
        private System.Windows.Forms.Label offTitleLabel;
        private System.Windows.Forms.Label offLabel;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Label postTitleLabel;
        private System.Windows.Forms.Label otherTitleLabel;
        private System.Windows.Forms.Label addEditPlacementLabel;
        private System.Windows.Forms.ListView hymnList;
        private System.Windows.Forms.ListView otherList;
    }
}


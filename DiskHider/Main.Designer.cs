
namespace DiskHider
{
    partial class Main
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
            if(disposing && (components != null))
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
            this.drivesList = new System.Windows.Forms.CheckedListBox();
            this.showAllDrives = new DiskHider.CommandLink();
            this.hideAllDrives = new DiskHider.CommandLink();
            this.applyButton = new DiskHider.CommandLink();
            this.SuspendLayout();
            // 
            // drivesList
            // 
            this.drivesList.FormattingEnabled = true;
            this.drivesList.Location = new System.Drawing.Point(-1, 3);
            this.drivesList.MultiColumn = true;
            this.drivesList.Name = "drivesList";
            this.drivesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drivesList.Size = new System.Drawing.Size(245, 199);
            this.drivesList.TabIndex = 0;
            // 
            // showAllDrives
            // 
            this.showAllDrives.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showAllDrives.Location = new System.Drawing.Point(250, 142);
            this.showAllDrives.Name = "showAllDrives";
            this.showAllDrives.Size = new System.Drawing.Size(240, 48);
            this.showAllDrives.TabIndex = 5;
            this.showAllDrives.Text = "Показать все диски";
            this.showAllDrives.UseVisualStyleBackColor = true;
            this.showAllDrives.Click += new System.EventHandler(this.showAllDrives_Click);
            // 
            // hideAllDrives
            // 
            this.hideAllDrives.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hideAllDrives.Location = new System.Drawing.Point(250, 73);
            this.hideAllDrives.Name = "hideAllDrives";
            this.hideAllDrives.Size = new System.Drawing.Size(240, 50);
            this.hideAllDrives.TabIndex = 4;
            this.hideAllDrives.Text = "Скрыть все диски";
            this.hideAllDrives.UseVisualStyleBackColor = true;
            this.hideAllDrives.Click += new System.EventHandler(this.hideAllDrives_Click);
            // 
            // applyButton
            // 
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.applyButton.Location = new System.Drawing.Point(250, 12);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(240, 40);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 202);
            this.Controls.Add(this.showAllDrives);
            this.Controls.Add(this.hideAllDrives);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.drivesList);
            this.Name = "Main";
            this.Text = "DiskHider";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox drivesList;
        private DiskHider.CommandLink applyButton;
        private DiskHider.CommandLink hideAllDrives;
        private DiskHider.CommandLink showAllDrives;
    }
}


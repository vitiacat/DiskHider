
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
            this.commandLink3 = new DiskHider.CommandLink();
            this.commandLink2 = new DiskHider.CommandLink();
            this.commandLink1 = new DiskHider.CommandLink();
            this.hideSelectedDrivesButton = new DiskHider.CommandLink();
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
            // commandLink3
            // 
            this.commandLink3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink3.Location = new System.Drawing.Point(250, 142);
            this.commandLink3.Name = "commandLink3";
            this.commandLink3.Size = new System.Drawing.Size(240, 48);
            this.commandLink3.TabIndex = 5;
            this.commandLink3.Text = "Показать все диски";
            this.commandLink3.UseVisualStyleBackColor = true;
            // 
            // commandLink2
            // 
            this.commandLink2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink2.Location = new System.Drawing.Point(250, 98);
            this.commandLink2.Name = "commandLink2";
            this.commandLink2.Size = new System.Drawing.Size(240, 38);
            this.commandLink2.TabIndex = 4;
            this.commandLink2.Text = "Скрыть все диски";
            this.commandLink2.UseVisualStyleBackColor = true;
            // 
            // commandLink1
            // 
            this.commandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink1.Location = new System.Drawing.Point(250, 48);
            this.commandLink1.Name = "commandLink1";
            this.commandLink1.Size = new System.Drawing.Size(240, 44);
            this.commandLink1.TabIndex = 3;
            this.commandLink1.Text = "Показать выбранные диски";
            this.commandLink1.UseVisualStyleBackColor = true;
            // 
            // hideSelectedDrivesButton
            // 
            this.hideSelectedDrivesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hideSelectedDrivesButton.Location = new System.Drawing.Point(250, 3);
            this.hideSelectedDrivesButton.Name = "hideSelectedDrivesButton";
            this.hideSelectedDrivesButton.Size = new System.Drawing.Size(240, 41);
            this.hideSelectedDrivesButton.TabIndex = 2;
            this.hideSelectedDrivesButton.Text = "Скрыть выбранные диски";
            this.hideSelectedDrivesButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 202);
            this.Controls.Add(this.commandLink3);
            this.Controls.Add(this.commandLink2);
            this.Controls.Add(this.commandLink1);
            this.Controls.Add(this.hideSelectedDrivesButton);
            this.Controls.Add(this.drivesList);
            this.Name = "Main";
            this.Text = "DiskHider";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox drivesList;
        private DiskHider.CommandLink hideSelectedDrivesButton;
        private DiskHider.CommandLink commandLink1;
        private DiskHider.CommandLink commandLink2;
        private DiskHider.CommandLink commandLink3;
    }
}


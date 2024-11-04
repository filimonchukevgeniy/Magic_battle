
namespace Magic_battle
{
    partial class Defeat
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
            this.Back_win = new System.Windows.Forms.Button();
            this.point_hp_result = new System.Windows.Forms.Label();
            this.point_ph_dmg_result = new System.Windows.Forms.Label();
            this.point_hp_label = new System.Windows.Forms.Label();
            this.point_ph_dmg_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_win
            // 
            this.Back_win.Location = new System.Drawing.Point(323, 325);
            this.Back_win.Name = "Back_win";
            this.Back_win.Size = new System.Drawing.Size(117, 58);
            this.Back_win.TabIndex = 11;
            this.Back_win.Text = "Back";
            this.Back_win.UseVisualStyleBackColor = true;
            this.Back_win.Click += new System.EventHandler(this.Back_win_Click);
            // 
            // point_hp_result
            // 
            this.point_hp_result.AutoSize = true;
            this.point_hp_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point_hp_result.Location = new System.Drawing.Point(320, 182);
            this.point_hp_result.Name = "point_hp_result";
            this.point_hp_result.Size = new System.Drawing.Size(16, 17);
            this.point_hp_result.TabIndex = 10;
            this.point_hp_result.Text = "0";
            // 
            // point_ph_dmg_result
            // 
            this.point_ph_dmg_result.AutoSize = true;
            this.point_ph_dmg_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point_ph_dmg_result.Location = new System.Drawing.Point(320, 148);
            this.point_ph_dmg_result.Name = "point_ph_dmg_result";
            this.point_ph_dmg_result.Size = new System.Drawing.Size(16, 17);
            this.point_ph_dmg_result.TabIndex = 9;
            this.point_ph_dmg_result.Text = "0";
            // 
            // point_hp_label
            // 
            this.point_hp_label.AutoSize = true;
            this.point_hp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point_hp_label.Location = new System.Drawing.Point(157, 182);
            this.point_hp_label.Name = "point_hp_label";
            this.point_hp_label.Size = new System.Drawing.Size(146, 17);
            this.point_hp_label.TabIndex = 8;
            this.point_hp_label.Text = "Кількість очків життя";
            // 
            // point_ph_dmg_label
            // 
            this.point_ph_dmg_label.AutoSize = true;
            this.point_ph_dmg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point_ph_dmg_label.Location = new System.Drawing.Point(157, 148);
            this.point_ph_dmg_label.Name = "point_ph_dmg_label";
            this.point_ph_dmg_label.Size = new System.Drawing.Size(138, 17);
            this.point_ph_dmg_label.TabIndex = 7;
            this.point_ph_dmg_label.Text = "Кількість очків сили";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(287, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "You Defeat!!!";
            // 
            // Defeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_win);
            this.Controls.Add(this.point_hp_result);
            this.Controls.Add(this.point_ph_dmg_result);
            this.Controls.Add(this.point_hp_label);
            this.Controls.Add(this.point_ph_dmg_label);
            this.Controls.Add(this.label1);
            this.Name = "Defeat";
            this.Text = "Defeat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_win;
        private System.Windows.Forms.Label point_hp_result;
        private System.Windows.Forms.Label point_ph_dmg_result;
        private System.Windows.Forms.Label point_hp_label;
        private System.Windows.Forms.Label point_ph_dmg_label;
        private System.Windows.Forms.Label label1;
    }
}
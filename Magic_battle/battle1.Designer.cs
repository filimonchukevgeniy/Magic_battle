﻿
namespace Magic_battle
{
    partial class LVL_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LVL_1));
            this.Hero = new System.Windows.Forms.Panel();
            this.hero_magic_dmg_result_label = new System.Windows.Forms.Label();
            this.hero_ph_dmg_result_label = new System.Windows.Forms.Label();
            this.hero_hp_result_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.M_damage = new System.Windows.Forms.Label();
            this.F_damage = new System.Windows.Forms.Label();
            this.HP = new System.Windows.Forms.Label();
            this.NameFire = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enemy_magic_dmg_result_label = new System.Windows.Forms.Label();
            this.enemy_ph_dmg_result_label = new System.Windows.Forms.Label();
            this.enemy_hp_label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameWater = new System.Windows.Forms.Label();
            this.enemy_image = new System.Windows.Forms.PictureBox();
            this.Hero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_image)).BeginInit();
            this.SuspendLayout();
            // 
            // Hero
            // 
            this.Hero.Controls.Add(this.hero_magic_dmg_result_label);
            this.Hero.Controls.Add(this.hero_ph_dmg_result_label);
            this.Hero.Controls.Add(this.hero_hp_result_label);
            this.Hero.Controls.Add(this.button2);
            this.Hero.Controls.Add(this.button1);
            this.Hero.Controls.Add(this.M_damage);
            this.Hero.Controls.Add(this.F_damage);
            this.Hero.Controls.Add(this.HP);
            this.Hero.Controls.Add(this.NameFire);
            this.Hero.Controls.Add(this.pictureBox1);
            this.Hero.Location = new System.Drawing.Point(30, 23);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(249, 389);
            this.Hero.TabIndex = 0;
            // 
            // hero_magic_dmg_result_label
            // 
            this.hero_magic_dmg_result_label.AutoSize = true;
            this.hero_magic_dmg_result_label.Location = new System.Drawing.Point(102, 292);
            this.hero_magic_dmg_result_label.Name = "hero_magic_dmg_result_label";
            this.hero_magic_dmg_result_label.Size = new System.Drawing.Size(19, 13);
            this.hero_magic_dmg_result_label.TabIndex = 10;
            this.hero_magic_dmg_result_label.Text = "10";
            // 
            // hero_ph_dmg_result_label
            // 
            this.hero_ph_dmg_result_label.AutoSize = true;
            this.hero_ph_dmg_result_label.Location = new System.Drawing.Point(102, 270);
            this.hero_ph_dmg_result_label.Name = "hero_ph_dmg_result_label";
            this.hero_ph_dmg_result_label.Size = new System.Drawing.Size(19, 13);
            this.hero_ph_dmg_result_label.TabIndex = 9;
            this.hero_ph_dmg_result_label.Text = "10";
            // 
            // hero_hp_result_label
            // 
            this.hero_hp_result_label.AutoSize = true;
            this.hero_hp_result_label.Location = new System.Drawing.Point(102, 248);
            this.hero_hp_result_label.Name = "hero_hp_result_label";
            this.hero_hp_result_label.Size = new System.Drawing.Size(25, 13);
            this.hero_hp_result_label.TabIndex = 8;
            this.hero_hp_result_label.Text = "100";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Магічний удар";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Фізичний удар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // M_damage
            // 
            this.M_damage.AutoSize = true;
            this.M_damage.Location = new System.Drawing.Point(19, 292);
            this.M_damage.Name = "M_damage";
            this.M_damage.Size = new System.Drawing.Size(81, 13);
            this.M_damage.TabIndex = 5;
            this.M_damage.Text = "Магічний урон:";
            // 
            // F_damage
            // 
            this.F_damage.AutoSize = true;
            this.F_damage.Location = new System.Drawing.Point(19, 270);
            this.F_damage.Name = "F_damage";
            this.F_damage.Size = new System.Drawing.Size(84, 13);
            this.F_damage.TabIndex = 4;
            this.F_damage.Text = "Фізичний урон:";
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.Location = new System.Drawing.Point(19, 248);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(25, 13);
            this.HP.TabIndex = 3;
            this.HP.Text = "HP:";
            // 
            // NameFire
            // 
            this.NameFire.AutoSize = true;
            this.NameFire.Location = new System.Drawing.Point(78, 228);
            this.NameFire.Name = "NameFire";
            this.NameFire.Size = new System.Drawing.Size(95, 13);
            this.NameFire.TabIndex = 2;
            this.NameFire.Text = "Вогнний майстер";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 211);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enemy_magic_dmg_result_label);
            this.panel1.Controls.Add(this.enemy_ph_dmg_result_label);
            this.panel1.Controls.Add(this.enemy_hp_label);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.NameWater);
            this.panel1.Controls.Add(this.enemy_image);
            this.panel1.Location = new System.Drawing.Point(519, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 389);
            this.panel1.TabIndex = 11;
            // 
            // enemy_magic_dmg_result_label
            // 
            this.enemy_magic_dmg_result_label.AutoSize = true;
            this.enemy_magic_dmg_result_label.Location = new System.Drawing.Point(102, 292);
            this.enemy_magic_dmg_result_label.Name = "enemy_magic_dmg_result_label";
            this.enemy_magic_dmg_result_label.Size = new System.Drawing.Size(19, 13);
            this.enemy_magic_dmg_result_label.TabIndex = 10;
            this.enemy_magic_dmg_result_label.Text = "10";
            // 
            // enemy_ph_dmg_result_label
            // 
            this.enemy_ph_dmg_result_label.AutoSize = true;
            this.enemy_ph_dmg_result_label.Location = new System.Drawing.Point(102, 270);
            this.enemy_ph_dmg_result_label.Name = "enemy_ph_dmg_result_label";
            this.enemy_ph_dmg_result_label.Size = new System.Drawing.Size(19, 13);
            this.enemy_ph_dmg_result_label.TabIndex = 9;
            this.enemy_ph_dmg_result_label.Text = "10";
            // 
            // enemy_hp_label
            // 
            this.enemy_hp_label.AutoSize = true;
            this.enemy_hp_label.Location = new System.Drawing.Point(102, 248);
            this.enemy_hp_label.Name = "enemy_hp_label";
            this.enemy_hp_label.Size = new System.Drawing.Size(25, 13);
            this.enemy_hp_label.TabIndex = 8;
            this.enemy_hp_label.Text = "100";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "Магічний удар";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 53);
            this.button4.TabIndex = 6;
            this.button4.Text = "Фізичний удар";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Магічний урон:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Фізичний урон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "HP:";
            // 
            // NameWater
            // 
            this.NameWater.AutoSize = true;
            this.NameWater.Location = new System.Drawing.Point(78, 228);
            this.NameWater.Name = "NameWater";
            this.NameWater.Size = new System.Drawing.Size(90, 13);
            this.NameWater.TabIndex = 2;
            this.NameWater.Text = "Водний майстер";
            // 
            // enemy_image
            // 
            this.enemy_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_image.BackgroundImage")));
            this.enemy_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemy_image.Location = new System.Drawing.Point(13, 14);
            this.enemy_image.Name = "enemy_image";
            this.enemy_image.Size = new System.Drawing.Size(224, 211);
            this.enemy_image.TabIndex = 1;
            this.enemy_image.TabStop = false;
            // 
            // LVL_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Hero);
            this.Name = "LVL_1";
            this.Text = "battle1";
            this.Load += new System.EventHandler(this.battle1_Load);
            this.Hero.ResumeLayout(false);
            this.Hero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Hero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameFire;
        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.Label hero_magic_dmg_result_label;
        private System.Windows.Forms.Label hero_ph_dmg_result_label;
        private System.Windows.Forms.Label hero_hp_result_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label M_damage;
        private System.Windows.Forms.Label F_damage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label enemy_magic_dmg_result_label;
        private System.Windows.Forms.Label enemy_ph_dmg_result_label;
        private System.Windows.Forms.Label enemy_hp_label;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NameWater;
        private System.Windows.Forms.PictureBox enemy_image;
    }
}
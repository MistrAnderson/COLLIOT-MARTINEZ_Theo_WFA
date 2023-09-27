using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace MacacoGearSolid
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.foe2PathVert = new System.Windows.Forms.PictureBox();
            this.foe2PathHoriz = new System.Windows.Forms.PictureBox();
            this.foe1PathHoriz = new System.Windows.Forms.PictureBox();
            this.foe1PathVert = new System.Windows.Forms.PictureBox();
            this.foe2 = new MacacoGearSolid.Enemy();
            this.foe1 = new MacacoGearSolid.Enemy();
            this.foe3 = new MacacoGearSolid.Enemy();
            this.foe4 = new MacacoGearSolid.Enemy();
            this.foe4PathVert = new System.Windows.Forms.PictureBox();
            this.foe3PathVert = new System.Windows.Forms.PictureBox();
            this.foe5 = new MacacoGearSolid.Enemy();
            this.foe5PathHoriz = new System.Windows.Forms.PictureBox();
            this.foe5PathVert = new System.Windows.Forms.PictureBox();
            this.foe3PathHoriz = new System.Windows.Forms.PictureBox();
            this.foe4PathHoriz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe2PathVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe2PathHoriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe1PathHoriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe1PathVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe4PathVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe3PathVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe5PathHoriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe5PathVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe3PathHoriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe4PathHoriz)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox1.Location = new System.Drawing.Point(97, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "plateforme";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox2.Location = new System.Drawing.Point(243, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "plateforme";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox3.Location = new System.Drawing.Point(302, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "plateforme";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox4.Location = new System.Drawing.Point(97, 310);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(160, 100);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "plateforme";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox5.Location = new System.Drawing.Point(450, 310);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "plateforme";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox6.Location = new System.Drawing.Point(390, 159);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(160, 100);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "plateforme";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(166)))), ((int)(((byte)(235)))));
            this.player.Location = new System.Drawing.Point(85, 562);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(16, 16);
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(132)))), ((int)(((byte)(176)))));
            this.exit.Location = new System.Drawing.Point(815, 115);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 30);
            this.exit.TabIndex = 8;
            this.exit.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox7.Location = new System.Drawing.Point(243, 461);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 100);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "plateforme";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox8.Location = new System.Drawing.Point(391, 461);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(316, 100);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "plateforme";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox9.Location = new System.Drawing.Point(607, 310);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 156);
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "plateforme";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox10.Location = new System.Drawing.Point(841, -6);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 637);
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "plateforme";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox11.Location = new System.Drawing.Point(-27, 610);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(959, 100);
            this.pictureBox11.TabIndex = 14;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "plateforme";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox12.Location = new System.Drawing.Point(-27, -59);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(959, 168);
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "plateforme";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pictureBox13.Location = new System.Drawing.Point(-56, 21);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(100, 610);
            this.pictureBox13.TabIndex = 17;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "plateforme";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(31)))));
            this.pictureBox14.Location = new System.Drawing.Point(418, 428);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(10, 10);
            this.pictureBox14.TabIndex = 18;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "coin";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(31)))));
            this.pictureBox15.Location = new System.Drawing.Point(494, 278);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(10, 10);
            this.pictureBox15.TabIndex = 19;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "coin";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(31)))));
            this.pictureBox16.Location = new System.Drawing.Point(275, 278);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(10, 10);
            this.pictureBox16.TabIndex = 20;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "coin";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(648, 35);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(197, 59);
            this.txtScore.TabIndex = 21;
            this.txtScore.Text = "Score:0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // foe2PathVert
            // 
            this.foe2PathVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.foe2PathVert.Location = new System.Drawing.Point(212, 131);
            this.foe2PathVert.Name = "foe2PathVert";
            this.foe2PathVert.Size = new System.Drawing.Size(10, 157);
            this.foe2PathVert.TabIndex = 22;
            this.foe2PathVert.TabStop = false;
            this.foe2PathVert.Tag = "path";
            // 
            // foe2PathHoriz
            // 
            this.foe2PathHoriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.foe2PathHoriz.Location = new System.Drawing.Point(65, 278);
            this.foe2PathHoriz.Name = "foe2PathHoriz";
            this.foe2PathHoriz.Size = new System.Drawing.Size(303, 11);
            this.foe2PathHoriz.TabIndex = 23;
            this.foe2PathHoriz.TabStop = false;
            this.foe2PathHoriz.Tag = "path";
            // 
            // foe1PathHoriz
            // 
            this.foe1PathHoriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.foe1PathHoriz.Location = new System.Drawing.Point(418, 283);
            this.foe1PathHoriz.Name = "foe1PathHoriz";
            this.foe1PathHoriz.Size = new System.Drawing.Size(169, 11);
            this.foe1PathHoriz.TabIndex = 24;
            this.foe1PathHoriz.TabStop = false;
            this.foe1PathHoriz.Tag = "path";
            // 
            // foe1PathVert
            // 
            this.foe1PathVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.foe1PathVert.Location = new System.Drawing.Point(577, 278);
            this.foe1PathVert.Name = "foe1PathVert";
            this.foe1PathVert.Size = new System.Drawing.Size(10, 157);
            this.foe1PathVert.TabIndex = 25;
            this.foe1PathVert.TabStop = false;
            this.foe1PathVert.Tag = "path";
            // 
            // foe2
            // 
            this.foe2.BackColor = System.Drawing.Color.Red;
            this.foe2.horizSpeed = 0;
            this.foe2.Location = new System.Drawing.Point(212, 131);
            this.foe2.Name = "foe2";
            this.foe2.Size = new System.Drawing.Size(16, 16);
            this.foe2.TabIndex = 26;
            this.foe2.TabStop = false;
            this.foe2.Tag = "enemy";
            this.foe2.vertSpeed = 2;
            // 
            // foe1
            // 
            this.foe1.BackColor = System.Drawing.Color.Red;
            this.foe1.horizSpeed = 0;
            this.foe1.Location = new System.Drawing.Point(571, 278);
            this.foe1.Name = "foe1";
            this.foe1.Size = new System.Drawing.Size(16, 16);
            this.foe1.TabIndex = 27;
            this.foe1.TabStop = false;
            this.foe1.Tag = "enemy";
            this.foe1.vertSpeed = 2;
            // 
            // foe3
            // 
            this.foe3.BackColor = System.Drawing.Color.Red;
            this.foe3.horizSpeed = 0;
            this.foe3.Location = new System.Drawing.Point(718, 310);
            this.foe3.Name = "foe3";
            this.foe3.Size = new System.Drawing.Size(16, 16);
            this.foe3.TabIndex = 28;
            this.foe3.TabStop = false;
            this.foe3.Tag = "enemy";
            this.foe3.vertSpeed = 2;
            // 
            // foe4
            // 
            this.foe4.BackColor = System.Drawing.Color.Red;
            this.foe4.horizSpeed = 0;
            this.foe4.Location = new System.Drawing.Point(793, 310);
            this.foe4.Name = "foe4";
            this.foe4.Size = new System.Drawing.Size(16, 16);
            this.foe4.TabIndex = 29;
            this.foe4.TabStop = false;
            this.foe4.Tag = "enemy";
            this.foe4.vertSpeed = 2;
            // 
            // foe4PathVert
            // 
            this.foe4PathVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.foe4PathVert.Location = new System.Drawing.Point(799, 131);
            this.foe4PathVert.Name = "foe4PathVert";
            this.foe4PathVert.Size = new System.Drawing.Size(10, 403);
            this.foe4PathVert.TabIndex = 30;
            this.foe4PathVert.TabStop = false;
            this.foe4PathVert.Tag = "path";
            // 
            // foe3PathVert
            // 
            this.foe3PathVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.foe3PathVert.Location = new System.Drawing.Point(718, 310);
            this.foe3PathVert.Name = "foe3PathVert";
            this.foe3PathVert.Size = new System.Drawing.Size(10, 276);
            this.foe3PathVert.TabIndex = 31;
            this.foe3PathVert.TabStop = false;
            this.foe3PathVert.Tag = "path";
            // 
            // foe5
            // 
            this.foe5.BackColor = System.Drawing.Color.Red;
            this.foe5.horizSpeed = 0;
            this.foe5.Location = new System.Drawing.Point(275, 422);
            this.foe5.Name = "foe5";
            this.foe5.Size = new System.Drawing.Size(16, 16);
            this.foe5.TabIndex = 32;
            this.foe5.TabStop = false;
            this.foe5.Tag = "enemy";
            this.foe5.vertSpeed = 2;
            // 
            // foe5PathHoriz
            // 
            this.foe5PathHoriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.foe5PathHoriz.Location = new System.Drawing.Point(65, 427);
            this.foe5PathHoriz.Name = "foe5PathHoriz";
            this.foe5PathHoriz.Size = new System.Drawing.Size(303, 11);
            this.foe5PathHoriz.TabIndex = 33;
            this.foe5PathHoriz.TabStop = false;
            this.foe5PathHoriz.Tag = "path";
            // 
            // foe5PathVert
            // 
            this.foe5PathVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.foe5PathVert.Location = new System.Drawing.Point(358, 427);
            this.foe5PathVert.Name = "foe5PathVert";
            this.foe5PathVert.Size = new System.Drawing.Size(10, 157);
            this.foe5PathVert.TabIndex = 34;
            this.foe5PathVert.TabStop = false;
            this.foe5PathVert.Tag = "path";
            // 
            // foe3PathHoriz
            // 
            this.foe3PathHoriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.foe3PathHoriz.Location = new System.Drawing.Point(718, 575);
            this.foe3PathHoriz.Name = "foe3PathHoriz";
            this.foe3PathHoriz.Size = new System.Drawing.Size(27, 11);
            this.foe3PathHoriz.TabIndex = 35;
            this.foe3PathHoriz.TabStop = false;
            this.foe3PathHoriz.Tag = "path";
            // 
            // foe4PathHoriz
            // 
            this.foe4PathHoriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.foe4PathHoriz.Location = new System.Drawing.Point(782, 523);
            this.foe4PathHoriz.Name = "foe4PathHoriz";
            this.foe4PathHoriz.Size = new System.Drawing.Size(27, 11);
            this.foe4PathHoriz.TabIndex = 36;
            this.foe4PathHoriz.TabStop = false;
            this.foe4PathHoriz.Tag = "path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.foe4PathHoriz);
            this.Controls.Add(this.foe3PathHoriz);
            this.Controls.Add(this.foe5PathVert);
            this.Controls.Add(this.foe5PathHoriz);
            this.Controls.Add(this.foe5);
            this.Controls.Add(this.foe3PathVert);
            this.Controls.Add(this.foe4PathVert);
            this.Controls.Add(this.foe4);
            this.Controls.Add(this.foe3);
            this.Controls.Add(this.foe1);
            this.Controls.Add(this.foe2);
            this.Controls.Add(this.foe1PathVert);
            this.Controls.Add(this.foe1PathHoriz);
            this.Controls.Add(this.foe2PathHoriz);
            this.Controls.Add(this.foe2PathVert);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Macaco Gear Solid";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe2PathVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe2PathHoriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe1PathHoriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe1PathVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe4PathVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe3PathVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe5PathHoriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe5PathVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe3PathHoriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foe4PathHoriz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtScore;
        private PictureBox foe2PathVert;
        private PictureBox foe2PathHoriz;
        private PictureBox foe1PathHoriz;
        private PictureBox foe1PathVert;
        private Enemy foe2;
        private Enemy foe1;
        private Enemy foe3;
        private Enemy foe4;
        private PictureBox foe4PathVert;
        private PictureBox foe3PathVert;
        private Enemy foe5;
        private PictureBox foe5PathHoriz;
        private PictureBox foe5PathVert;
        private PictureBox foe3PathHoriz;
        private PictureBox foe4PathHoriz;
    }
}


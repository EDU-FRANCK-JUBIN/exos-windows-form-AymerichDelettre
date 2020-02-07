namespace DemoApplication
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(245, 63);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(19, 29);
            this.lblResult.TabIndex = 45;
            this.lblResult.Text = " ";
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(41, 20);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(12, 17);
            this.lblHistory.TabIndex = 44;
            this.lblHistory.Text = " ";
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(298, 444);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(65, 61);
            this.button37.TabIndex = 42;
            this.button37.Text = "=";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.HandleCalcul);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(213, 444);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(65, 61);
            this.button38.TabIndex = 41;
            this.button38.Text = ",";
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(127, 444);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(65, 61);
            this.button39.TabIndex = 40;
            this.button39.Text = "0";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.handleClick);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(44, 444);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(65, 61);
            this.button40.TabIndex = 39;
            this.button40.Text = "+-";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(298, 130);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(65, 61);
            this.button33.TabIndex = 38;
            this.button33.Text = "/";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.HandleOpe);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(213, 130);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(65, 61);
            this.button34.TabIndex = 37;
            this.button34.Text = "<--";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(127, 130);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(65, 61);
            this.button35.TabIndex = 36;
            this.button35.Text = "C";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.handleUtils);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(44, 130);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(65, 61);
            this.button36.TabIndex = 35;
            this.button36.Text = "CE";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.handleUtils);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(298, 364);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(65, 61);
            this.button29.TabIndex = 34;
            this.button29.Text = "+";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.HandleOpe);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(213, 364);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(65, 61);
            this.button30.TabIndex = 33;
            this.button30.Text = "9";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.handleClick);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(127, 364);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(65, 61);
            this.button31.TabIndex = 32;
            this.button31.Text = "8";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.handleClick);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(44, 364);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 61);
            this.btn7.TabIndex = 31;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.handleClick);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(298, 287);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(65, 61);
            this.button25.TabIndex = 30;
            this.button25.Text = "-";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.HandleOpe);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(213, 287);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(65, 61);
            this.button26.TabIndex = 29;
            this.button26.Text = "6";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.handleClick);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(127, 287);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(65, 61);
            this.button27.TabIndex = 28;
            this.button27.Text = "5";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.handleClick);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(44, 287);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(65, 61);
            this.button28.TabIndex = 27;
            this.button28.Text = "4";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.handleClick);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(298, 209);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(65, 61);
            this.button24.TabIndex = 26;
            this.button24.Text = "*";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.HandleOpe);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(213, 209);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(65, 61);
            this.button23.TabIndex = 25;
            this.button23.Text = "3";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.handleClick);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(127, 209);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(65, 61);
            this.button22.TabIndex = 24;
            this.button22.Text = "2";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.handleClick);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(44, 209);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(65, 61);
            this.button21.TabIndex = 23;
            this.button21.Text = "1";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.handleClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(406, 518);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
    }
}


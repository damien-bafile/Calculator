namespace Calculator
{
    partial class FrmCalculator
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
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnTangent = new System.Windows.Forms.Button();
            this.btnSine = new System.Windows.Forms.Button();
            this.btnCosine = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnCubeRoot = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(69, 277);
            this.btnOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(160, 134);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(333, 489);
            this.btnFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(160, 134);
            this.btnFive.TabIndex = 1;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(333, 277);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(160, 134);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(69, 713);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(160, 134);
            this.btnSeven.TabIndex = 3;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(581, 911);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(160, 134);
            this.btnPoint.TabIndex = 4;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(333, 911);
            this.btnZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(160, 134);
            this.btnZero.TabIndex = 5;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(69, 911);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 134);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(581, 713);
            this.btnNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(160, 134);
            this.btnNine.TabIndex = 7;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(581, 489);
            this.btnSix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(160, 134);
            this.btnSix.TabIndex = 8;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(581, 277);
            this.btnThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(160, 134);
            this.btnThree.TabIndex = 9;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(333, 713);
            this.btnEight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(160, 134);
            this.btnEight.TabIndex = 10;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(69, 489);
            this.btnFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(160, 134);
            this.btnFour.TabIndex = 11;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(835, 727);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(160, 315);
            this.btnEquals.TabIndex = 12;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(835, 546);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(160, 134);
            this.btnDivide.TabIndex = 13;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(835, 377);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(160, 134);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(835, 222);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(160, 134);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(835, 48);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(160, 134);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Location = new System.Drawing.Point(1075, 556);
            this.btnSquareRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(160, 134);
            this.btnSquareRoot.TabIndex = 17;
            this.btnSquareRoot.Text = "S&QRT";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(69, 61);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(672, 121);
            this.txtDisplay.TabIndex = 18;
            // 
            // btnTangent
            // 
            this.btnTangent.Location = new System.Drawing.Point(1075, 48);
            this.btnTangent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTangent.Name = "btnTangent";
            this.btnTangent.Size = new System.Drawing.Size(160, 134);
            this.btnTangent.TabIndex = 19;
            this.btnTangent.Text = "&Tan";
            this.btnTangent.UseVisualStyleBackColor = true;
            this.btnTangent.Click += new System.EventHandler(this.btnTangent_Click);
            // 
            // btnSine
            // 
            this.btnSine.Location = new System.Drawing.Point(1075, 227);
            this.btnSine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSine.Name = "btnSine";
            this.btnSine.Size = new System.Drawing.Size(160, 134);
            this.btnSine.TabIndex = 20;
            this.btnSine.Text = "&Sin";
            this.btnSine.UseVisualStyleBackColor = true;
            this.btnSine.Click += new System.EventHandler(this.btnSine_Click);
            // 
            // btnCosine
            // 
            this.btnCosine.Location = new System.Drawing.Point(1075, 401);
            this.btnCosine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCosine.Name = "btnCosine";
            this.btnCosine.Size = new System.Drawing.Size(160, 134);
            this.btnCosine.TabIndex = 21;
            this.btnCosine.Text = "&Cos";
            this.btnCosine.UseVisualStyleBackColor = true;
            this.btnCosine.Click += new System.EventHandler(this.btnCosine_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(1075, 909);
            this.btnInverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(160, 134);
            this.btnInverse.TabIndex = 24;
            this.btnInverse.Text = "&Inverse";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnCubeRoot
            // 
            this.btnCubeRoot.Location = new System.Drawing.Point(1075, 734);
            this.btnCubeRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCubeRoot.Name = "btnCubeRoot";
            this.btnCubeRoot.Size = new System.Drawing.Size(160, 134);
            this.btnCubeRoot.TabIndex = 23;
            this.btnCubeRoot.Text = "Cube &Root";
            this.btnCubeRoot.UseVisualStyleBackColor = true;
            this.btnCubeRoot.Click += new System.EventHandler(this.btnCubeRoot_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1276, 1112);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnCubeRoot);
            this.Controls.Add(this.btnCosine);
            this.Controls.Add(this.btnSine);
            this.Controls.Add(this.btnTangent);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCalculator_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCalculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnTangent;
        private System.Windows.Forms.Button btnSine;
        private System.Windows.Forms.Button btnCosine;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnCubeRoot;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


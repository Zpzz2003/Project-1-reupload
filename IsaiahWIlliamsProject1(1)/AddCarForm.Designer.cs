namespace IsaiahWIlliamsProject1_1_
{
    partial class AddCarForm
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
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtMpg = new TextBox();
            txtPrice = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtMake
            // 
            txtMake.Location = new Point(34, 88);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 0;
            txtMake.Text = "Make";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(292, 88);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 1;
            txtModel.Text = "Model";
            // 
            // txtMpg
            // 
            txtMpg.Location = new Point(580, 88);
            txtMpg.Name = "txtMpg";
            txtMpg.Size = new Size(125, 27);
            txtMpg.TabIndex = 2;
            txtMpg.Text = "MPG";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(34, 200);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 3;
            txtPrice.Text = "Price";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(206, 337);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 4;
            btnOK.Text = "Okay";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(472, 337);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtPrice);
            Controls.Add(txtMpg);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Name = "AddCarForm";
            Text = "Car type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtMpg;
        private TextBox txtPrice;
        private Button btnOK;
        private Button btnCancel;
    }
}
namespace IsaiahWIlliamsProject1_1_
{
    partial class CarLotForm
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
            menuMain = new MenuStrip();
            btnCreateShopper = new Button();
            btnPurchaseCar = new Button();
            lblShopperInfo = new Label();
            lstInventory = new ListBox();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(800, 24);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // btnCreateShopper
            // 
            btnCreateShopper.Location = new Point(55, 199);
            btnCreateShopper.Name = "btnCreateShopper";
            btnCreateShopper.Size = new Size(156, 29);
            btnCreateShopper.TabIndex = 1;
            btnCreateShopper.Text = "Create Shopper";
            btnCreateShopper.UseVisualStyleBackColor = true;
            btnCreateShopper.Click += btnCreateShopper_Click;
            // 
            // btnPurchaseCar
            // 
            btnPurchaseCar.Location = new Point(66, 289);
            btnPurchaseCar.Name = "btnPurchaseCar";
            btnPurchaseCar.Size = new Size(145, 29);
            btnPurchaseCar.TabIndex = 2;
            btnPurchaseCar.Text = "Purchase Car";
            btnPurchaseCar.UseVisualStyleBackColor = true;
            btnPurchaseCar.Click += btnPurchaseCar_Click;
            // 
            // lblShopperInfo
            // 
            lblShopperInfo.Location = new Point(531, 84);
            lblShopperInfo.Name = "lblShopperInfo";
            lblShopperInfo.Size = new Size(170, 25);
            lblShopperInfo.TabIndex = 3;
            lblShopperInfo.Text = "Name:";
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.Location = new Point(440, 131);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(314, 244);
            lstInventory.TabIndex = 4;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstInventory);
            Controls.Add(lblShopperInfo);
            Controls.Add(btnPurchaseCar);
            Controls.Add(btnCreateShopper);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "CarLotForm";
            Text = "CarLotForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMain;
        private Button btnCreateShopper;
        private Button btnPurchaseCar;
        private Label lblShopperInfo;
        private ListBox lstInventory;
    }
}
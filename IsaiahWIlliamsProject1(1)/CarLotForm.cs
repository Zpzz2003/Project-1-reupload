using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsaiahWIlliamsProject1_1_
{
    public partial class CarLotForm : Form
    {
        private CarLot carLot;
        private Shopper shopper;

        public CarLotForm()
        {
            InitializeComponent();
            carLot = new CarLot();
            LoadInventoryDisplay();
        }

        // Lists cars
        private void LoadInventoryDisplay()
        {
            lstInventory.Items.Clear();
            foreach (var car in carLot.Inventory)
            {
                string display = $"{car.Make} {car.Model} {car.Price:C2} {car.Mpg:F1}mpg";
                lstInventory.Items.Add(display);
            }
        }

        // Add car menu opens
        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddCarForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        carLot.AddCar(dialog.Make, dialog.Model, dialog.Mpg, dialog.Price);
                        LoadInventoryDisplay();
                        MessageBox.Show("Car successfully added to inventory.", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Adding Car");
                    }
                }
            }
        }

        // Create shopper button
        private void btnCreateShopper_Click(object sender, EventArgs e)
        {
            using (var dialog = new ShopperForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    shopper = dialog.CreatedShopper;
                    lblShopperInfo.Text = $"{shopper.Name} - Balance: {shopper.MoneyAvailable:C2}";
                    MessageBox.Show($"Welcome, {shopper.Name}! You have {shopper.MoneyAvailable:C2} to spend.");
                }
            }
        }

        // Purchase car button
        private void btnPurchaseCar_Click(object sender, EventArgs e)
        {
            if (shopper == null)
            {
                MessageBox.Show("Please create a shopper first.");
                return;
            }

            if (lstInventory.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a car to purchase.");
                return;
            }

            
            Car selectedCar = carLot.Inventory[lstInventory.SelectedIndex];

            if (!shopper.CanPurchase(selectedCar))
            {
                MessageBox.Show($"{shopper.Name} does not have enough funds to buy this car.", "Insufficient Funds");
                return;
            }

            // Purchase 
            var purchasedCar = carLot.PurchaseCar(selectedCar.Make, selectedCar.Model);
            shopper.PurchaseCar(purchasedCar);

            MessageBox.Show($"Congrats {shopper.Name}! You bought a {purchasedCar.Make} {purchasedCar.Model} " +
                            $"for {purchasedCar.Price:C2}. You now have {shopper.MoneyAvailable:C2} left.",
                            "Purchase Successful");

            lblShopperInfo.Text = $"{shopper.Name} - Balance: {shopper.MoneyAvailable:C2}";
            LoadInventoryDisplay();
        }

        // View Inventory 
        private void viewInventoryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var details = $"Inventory of {carLot.Count} cars.\n";

            foreach (var car in carLot.Inventory)
            {
                details += $"{car.Make} {car.Model} {car.Price:C2} {car.Mpg:F1}mpg\n";
            }

            var mostExpensive = carLot.FindMostExpensiveCar();
            var leastExpensive = carLot.FindLeastExpensiveCar();
            var bestMpg = carLot.FindBestMPGCar();
            var worstMpg = carLot.FindWorstMPGCar();

            details += $"\nMost Expensive:\n{mostExpensive.Make} {mostExpensive.Model} {mostExpensive.Price:C2} {mostExpensive.Mpg:F1}mpg\n";
            details += $"Least Expensive:\n{leastExpensive.Make} {leastExpensive.Model} {leastExpensive.Price:C2} {leastExpensive.Mpg:F1}mpg\n";
            details += $"Best MPG:\n{bestMpg.Make} {bestMpg.Model} {bestMpg.Price:C2} {bestMpg.Mpg:F1}mpg\n";
            details += $"Worst MPG:\n{worstMpg.Make} {worstMpg.Model} {worstMpg.Price:C2} {worstMpg.Mpg:F1}mpg\n";

            MessageBox.Show(details, "Inventory Details");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

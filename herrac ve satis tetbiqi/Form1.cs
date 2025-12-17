namespace herrac_ve_satis_tetbiqi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        List<Product> products = new List<Product>();
        Product selectedProduct = null;

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            decimal basePrice;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Məhsul adını daxil edin");
                return;
            }
            try
            {
                basePrice = Convert.ToDecimal(txtBasePrice.Text);
            }
            catch
            {
                MessageBox.Show("Başlanğıc qiymət düzgün deyil");
                return;
            }

            Product p = new Product
            {
                Name = name,
                BasePrice = basePrice,
                CurrentBid = basePrice,
                Buyer = ""
            };

            products.Add(p);
            listBoxProducts.Items.Add(p);

            txtBasePrice.Clear();
            txtProductName.Clear();

            MessageBox.Show("Məhsul əlavə olundu.");
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                selectedProduct = (Product)listBoxProducts.SelectedItem;
            }
        }
        private void btnMakeBid_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Zəhmət olmasa məhsul seçin");
                return;
            }

            decimal newBid;
            string buyer = txtBuyerName.Text.Trim();

            try
            {
                newBid = Convert.ToDecimal(txtNewBid.Text);
            }
            catch
            {
                MessageBox.Show("Təklif düzgün deyil");
                return;
            }
                if (string.IsNullOrEmpty(buyer))
            {
                MessageBox.Show("Alıcı adını daxil edin");
                return;
            }

            if (newBid <= selectedProduct.CurrentBid)
            {
                MessageBox.Show("Yeni təklif hazırkından böyük olmalıdır");
                return;
            }

            selectedProduct.CurrentBid = newBid;
            selectedProduct.Buyer = buyer;

            int index = listBoxProducts.SelectedIndex;
            listBoxProducts.Items[index] = selectedProduct;

            txtNewBid.Clear();
            txtBuyerName.Clear();

            MessageBox.Show("Təklif qəbul edildi");
        }
        private void btnFinishAuction_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Məhsul seçilməyib");
                return;
            }

            if (string.IsNullOrEmpty(selectedProduct.Buyer))
            {
                lblResult.Text = "Bu məhsula heç bir təklif olmadı.";
            }
            else
            {
                lblResult.Text = $"Məhsulu {selectedProduct.Buyer} {selectedProduct.CurrentBid} AZN-ə aldı.";
            }
        }
    }
}

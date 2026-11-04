
namespace Md_app
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            бүртгэлToolStripMenuItem = new ToolStripMenuItem();
            хэрэглэгчийнБүртгэлToolStripMenuItem = new ToolStripMenuItem();
            хөрөнгийнТөрөлToolStripMenuItem = new ToolStripMenuItem();
            гарахToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem = new ToolStripMenuItem();
            файлНээхToolStripMenuItem = new ToolStripMenuItem();
            цонхToolStripMenuItem = new ToolStripMenuItem();
            хэвтээToolStripMenuItem = new ToolStripMenuItem();
            босооToolStripMenuItem = new ToolStripMenuItem();
            жагсаахToolStripMenuItem = new ToolStripMenuItem();
            хаахToolStripMenuItem = new ToolStripMenuItem();

            menuStrip1.SuspendLayout();
            SuspendLayout();

            // menuStrip1
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                бүртгэлToolStripMenuItem,
                файлToolStripMenuItem,
                цонхToolStripMenuItem
            });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";

            // бүртгэлToolStripMenuItem
            бүртгэлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                хэрэглэгчийнБүртгэлToolStripMenuItem,
                хөрөнгийнТөрөлToolStripMenuItem,
                гарахToolStripMenuItem
            });
            бүртгэлToolStripMenuItem.Name = "бүртгэлToolStripMenuItem";
            бүртгэлToolStripMenuItem.Size = new Size(94, 29);
            бүртгэлToolStripMenuItem.Text = "Бүртгэл";

            // хэрэглэгчийнБүртгэлToolStripMenuItem
            хэрэглэгчийнБүртгэлToolStripMenuItem.Name = "хэрэглэгчийнБүртгэлToolStripMenuItem";
            хэрэглэгчийнБүртгэлToolStripMenuItem.Size = new Size(289, 34);
            хэрэглэгчийнБүртгэлToolStripMenuItem.Text = "Хэрэглэгчийн бүртгэл";

            // хөрөнгийнТөрөлToolStripMenuItem
            хөрөнгийнТөрөлToolStripMenuItem.Name = "хөрөнгийнТөрөлToolStripMenuItem";
            хөрөнгийнТөрөлToolStripMenuItem.Size = new Size(289, 34);
            хөрөнгийнТөрөлToolStripMenuItem.Text = "Хөрөнгийн төрөл";

            // гарахToolStripMenuItem
            гарахToolStripMenuItem.Name = "гарахToolStripMenuItem";
            гарахToolStripMenuItem.Size = new Size(289, 34);
            гарахToolStripMenuItem.Text = "Гарах";
            гарахToolStripMenuItem.Click += гарахToolStripMenuItem_Click;

            // файлToolStripMenuItem
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                файлНээхToolStripMenuItem
            });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(69, 29);
            файлToolStripMenuItem.Text = "Файл";

            // файлНээхToolStripMenuItem
            файлНээхToolStripMenuItem.Name = "файлНээхToolStripMenuItem";
            файлНээхToolStripMenuItem.Size = new Size(270, 34);
            файлНээхToolStripMenuItem.Text = "Файл нээх";
            файлНээхToolStripMenuItem.Click += файлНээхToolStripMenuItem_Click;

            // цонхToolStripMenuItem
            цонхToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                хэвтээToolStripMenuItem,
                босооToolStripMenuItem,
                жагсаахToolStripMenuItem,
                хаахToolStripMenuItem
            });
            цонхToolStripMenuItem.Name = "цонхToolStripMenuItem";
            цонхToolStripMenuItem.Size = new Size(70, 29);
            цонхToolStripMenuItem.Text = "Цонх";

            // хэвтээToolStripMenuItem
            хэвтээToolStripMenuItem.Name = "хэвтээToolStripMenuItem";
            хэвтээToolStripMenuItem.Size = new Size(180, 34);
            хэвтээToolStripMenuItem.Text = "Хэвтээ";
            хэвтээToolStripMenuItem.Click += хэвтээToolStripMenuItem_Click;

            // босооToolStripMenuItem
            босооToolStripMenuItem.Name = "босооToolStripMenuItem";
            босооToolStripMenuItem.Size = new Size(180, 34);
            босооToolStripMenuItem.Text = "Босоо";
            босооToolStripMenuItem.Click += босооToolStripMenuItem_Click;

            // жагсаахToolStripMenuItem
            жагсаахToolStripMenuItem.Name = "жагсаахToolStripMenuItem";
            жагсаахToolStripMenuItem.Size = new Size(180, 34);
            жагсаахToolStripMenuItem.Text = "Жагсаах";
            жагсаахToolStripMenuItem.Click += жагсаахToolStripMenuItem_Click;

            // хаахToolStripMenuItem
            хаахToolStripMenuItem.Name = "хаахToolStripMenuItem";
            хаахToolStripMenuItem.Size = new Size(180, 34);
            хаахToolStripMenuItem.Text = "Хаах";
            хаахToolStripMenuItem.Click += хаахToolStripMenuItem_Click;

            // Form1
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MDI Application";

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem бүртгэлToolStripMenuItem;
        private ToolStripMenuItem хэрэглэгчийнБүртгэлToolStripMenuItem;
        private ToolStripMenuItem хөрөнгийнТөрөлToolStripMenuItem;
        private ToolStripMenuItem гарахToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem файлНээхToolStripMenuItem;
        private ToolStripMenuItem цонхToolStripMenuItem;
        private ToolStripMenuItem хэвтээToolStripMenuItem;
        private ToolStripMenuItem босооToolStripMenuItem;
        private ToolStripMenuItem жагсаахToolStripMenuItem;
        private ToolStripMenuItem хаахToolStripMenuItem;
    }
}

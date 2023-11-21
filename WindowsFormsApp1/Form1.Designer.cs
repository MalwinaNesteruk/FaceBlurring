using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pojedynczyObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.załadujObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wymażTwarzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderZObrazamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.załadujObrazyZFolderuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wymażTwarzeNaPojedynczymObrazieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wymażTwarzeWeWszystkichObrazachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszPojedynczyObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszWszystkieObrazyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pojedynczyObrazToolStripMenuItem,
            this.folderZObrazamiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pojedynczyObrazToolStripMenuItem
            // 
            this.pojedynczyObrazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.załadujObrazToolStripMenuItem,
            this.wymażTwarzeToolStripMenuItem,
            this.zapiszObrazToolStripMenuItem});
            this.pojedynczyObrazToolStripMenuItem.Name = "pojedynczyObrazToolStripMenuItem";
            this.pojedynczyObrazToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.pojedynczyObrazToolStripMenuItem.Text = "Pojedynczy obraz";
            // 
            // załadujObrazToolStripMenuItem
            // 
            this.załadujObrazToolStripMenuItem.Name = "załadujObrazToolStripMenuItem";
            this.załadujObrazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.załadujObrazToolStripMenuItem.Text = "Załaduj obraz";
            this.załadujObrazToolStripMenuItem.Click += new System.EventHandler(this.załadujObrazToolStripMenuItem_Click);
            // 
            // wymażTwarzeToolStripMenuItem
            // 
            this.wymażTwarzeToolStripMenuItem.Name = "wymażTwarzeToolStripMenuItem";
            this.wymażTwarzeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wymażTwarzeToolStripMenuItem.Text = "Wymaż twarze";
            this.wymażTwarzeToolStripMenuItem.Click += new System.EventHandler(this.wymażTwarzeToolStripMenuItem_Click);
            // 
            // zapiszObrazToolStripMenuItem
            // 
            this.zapiszObrazToolStripMenuItem.Name = "zapiszObrazToolStripMenuItem";
            this.zapiszObrazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszObrazToolStripMenuItem.Text = "Zapisz obraz";
            this.zapiszObrazToolStripMenuItem.Click += new System.EventHandler(this.zapiszObrazToolStripMenuItem_Click);
            // 
            // folderZObrazamiToolStripMenuItem
            // 
            this.folderZObrazamiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.załadujObrazyZFolderuToolStripMenuItem,
            this.wymażTwarzeNaPojedynczymObrazieToolStripMenuItem,
            this.wymażTwarzeWeWszystkichObrazachToolStripMenuItem,
            this.zapiszPojedynczyObrazToolStripMenuItem,
            this.zapiszWszystkieObrazyToolStripMenuItem});
            this.folderZObrazamiToolStripMenuItem.Name = "folderZObrazamiToolStripMenuItem";
            this.folderZObrazamiToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.folderZObrazamiToolStripMenuItem.Text = "Folder z obrazami";
            // 
            // załadujObrazyZFolderuToolStripMenuItem
            // 
            this.załadujObrazyZFolderuToolStripMenuItem.Name = "załadujObrazyZFolderuToolStripMenuItem";
            this.załadujObrazyZFolderuToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.załadujObrazyZFolderuToolStripMenuItem.Text = "Załaduj obrazy z folderu";
            // 
            // wymażTwarzeNaPojedynczymObrazieToolStripMenuItem
            // 
            this.wymażTwarzeNaPojedynczymObrazieToolStripMenuItem.Name = "wymażTwarzeNaPojedynczymObrazieToolStripMenuItem";
            this.wymażTwarzeNaPojedynczymObrazieToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.wymażTwarzeNaPojedynczymObrazieToolStripMenuItem.Text = "Wymaż twarze na pojedynczym obrazie";
            // 
            // wymażTwarzeWeWszystkichObrazachToolStripMenuItem
            // 
            this.wymażTwarzeWeWszystkichObrazachToolStripMenuItem.Name = "wymażTwarzeWeWszystkichObrazachToolStripMenuItem";
            this.wymażTwarzeWeWszystkichObrazachToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.wymażTwarzeWeWszystkichObrazachToolStripMenuItem.Text = "Wymaż twarze we wszystkich obrazach";
            // 
            // zapiszPojedynczyObrazToolStripMenuItem
            // 
            this.zapiszPojedynczyObrazToolStripMenuItem.Name = "zapiszPojedynczyObrazToolStripMenuItem";
            this.zapiszPojedynczyObrazToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.zapiszPojedynczyObrazToolStripMenuItem.Text = "Zapisz pojedynczy obraz";
            // 
            // zapiszWszystkieObrazyToolStripMenuItem
            // 
            this.zapiszWszystkieObrazyToolStripMenuItem.Name = "zapiszWszystkieObrazyToolStripMenuItem";
            this.zapiszWszystkieObrazyToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.zapiszWszystkieObrazyToolStripMenuItem.Text = "Zapisz wszystkie obrazy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 369);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp;";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPeg Image|*.jpg;*.jpeg|Bitmap Image|*.bmp|PNG Image|*.png;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Face Blurring";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pojedynczyObrazToolStripMenuItem;
        private ToolStripMenuItem załadujObrazToolStripMenuItem;
        private ToolStripMenuItem wymażTwarzeToolStripMenuItem;
        private ToolStripMenuItem zapiszObrazToolStripMenuItem;
        private ToolStripMenuItem folderZObrazamiToolStripMenuItem;
        private ToolStripMenuItem załadujObrazyZFolderuToolStripMenuItem;
        private ToolStripMenuItem wymażTwarzeNaPojedynczymObrazieToolStripMenuItem;
        private ToolStripMenuItem wymażTwarzeWeWszystkichObrazachToolStripMenuItem;
        private ToolStripMenuItem zapiszPojedynczyObrazToolStripMenuItem;
        private ToolStripMenuItem zapiszWszystkieObrazyToolStripMenuItem;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }

}


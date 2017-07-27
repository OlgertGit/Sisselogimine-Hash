namespace SisseLogimine
{
partial class MainForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        this.lbl_Login = new System.Windows.Forms.Label();
        this.lbl_Passwd = new System.Windows.Forms.Label();
        this.tb_Login = new System.Windows.Forms.TextBox();
        this.tb_Passwd = new System.Windows.Forms.TextBox();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.label1 = new System.Windows.Forms.Label();
        this.btn_Sisene = new System.Windows.Forms.Button();
        this.btn_Registreeru = new System.Windows.Forms.Button();
        this.btn_Exit = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        //
        // lbl_Login
        //
        this.lbl_Login.AutoSize = true;
        this.lbl_Login.Location = new System.Drawing.Point(243, 84);
        this.lbl_Login.Name = "lbl_Login";
        this.lbl_Login.Size = new System.Drawing.Size(48, 13);
        this.lbl_Login.TabIndex = 0;
        this.lbl_Login.Text = "Kasutaja";
        //
        // lbl_Passwd
        //
        this.lbl_Passwd.AutoSize = true;
        this.lbl_Passwd.Location = new System.Drawing.Point(243, 113);
        this.lbl_Passwd.Name = "lbl_Passwd";
        this.lbl_Passwd.Size = new System.Drawing.Size(37, 13);
        this.lbl_Passwd.TabIndex = 1;
        this.lbl_Passwd.Text = "Parool";
        //
        // tb_Login
        //
        this.tb_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
        this.tb_Login.Location = new System.Drawing.Point(313, 81);
        this.tb_Login.Name = "tb_Login";
        this.tb_Login.Size = new System.Drawing.Size(161, 20);
        this.tb_Login.TabIndex = 2;
        //
        // tb_Passwd
        //
        this.tb_Passwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
        this.tb_Passwd.Location = new System.Drawing.Point(313, 110);
        this.tb_Passwd.Name = "tb_Passwd";
        this.tb_Passwd.PasswordChar = '*';
        this.tb_Passwd.Size = new System.Drawing.Size(161, 20);
        this.tb_Passwd.TabIndex = 3;
        //
        // pictureBox1
        //
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(73, 52);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(104, 138);
        this.pictureBox1.TabIndex = 6;
        this.pictureBox1.TabStop = false;
        //
        // label1
        //
        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label1.Location = new System.Drawing.Point(318, 18);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(145, 29);
        this.label1.TabIndex = 7;
        this.label1.Text = "LOGI SISSE";
        //
        // btn_Sisene
        //
        this.btn_Sisene.Location = new System.Drawing.Point(313, 136);
        this.btn_Sisene.Name = "btn_Sisene";
        this.btn_Sisene.Size = new System.Drawing.Size(75, 23);
        this.btn_Sisene.TabIndex = 8;
        this.btn_Sisene.Text = "Sisene";
        this.btn_Sisene.UseVisualStyleBackColor = true;
        //
        // btn_Registreeru
        //
        this.btn_Registreeru.Location = new System.Drawing.Point(399, 136);
        this.btn_Registreeru.Name = "btn_Registreeru";
        this.btn_Registreeru.Size = new System.Drawing.Size(75, 23);
        this.btn_Registreeru.TabIndex = 9;
        this.btn_Registreeru.Text = "Registreeru";
        this.btn_Registreeru.UseVisualStyleBackColor = true;
        //
        // btn_Exit
        //
        this.btn_Exit.Location = new System.Drawing.Point(399, 215);
        this.btn_Exit.Name = "btn_Exit";
        this.btn_Exit.Size = new System.Drawing.Size(75, 23);
        this.btn_Exit.TabIndex = 10;
        this.btn_Exit.Text = "Välju";
        this.btn_Exit.UseVisualStyleBackColor = true;
        //
        // MainForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
        this.ClientSize = new System.Drawing.Size(519, 250);
        this.Controls.Add(this.btn_Exit);
        this.Controls.Add(this.btn_Registreeru);
        this.Controls.Add(this.btn_Sisene);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.tb_Passwd);
        this.Controls.Add(this.tb_Login);
        this.Controls.Add(this.lbl_Passwd);
        this.Controls.Add(this.lbl_Login);
        this.MinimumSize = new System.Drawing.Size(535, 289);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Sisselogimine";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_Login;
    private System.Windows.Forms.Label lbl_Passwd;
    private System.Windows.Forms.TextBox tb_Login;
    private System.Windows.Forms.TextBox tb_Passwd;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn_Sisene;
    private System.Windows.Forms.Button btn_Registreeru;
    private System.Windows.Forms.Button btn_Exit;
}
}


namespace WinFormsApp4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbFont = new Label();
            grpFont = new GroupBox();
            grpTreeList = new GroupBox();
            btnAddChild = new Button();
            btnAddRoot = new Button();
            LvDummy = new ListView();
            tvDummy = new TreeView();
            grpForm = new GroupBox();
            btnMsgBox = new Button();
            btnModaless = new Button();
            btnModal = new Button();
            grpBar = new GroupBox();
            pgDummy = new ProgressBar();
            tbDummy = new TrackBar();
            chkltalic = new CheckBox();
            chkBlod = new CheckBox();
            cboFont = new ComboBox();
            txtSampleText = new TextBox();
            grpFont.SuspendLayout();
            grpTreeList.SuspendLayout();
            grpForm.SuspendLayout();
            grpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbDummy).BeginInit();
            SuspendLayout();
            // 
            // lbFont
            // 
            lbFont.AutoSize = true;
            lbFont.Location = new Point(25, 54);
            lbFont.Name = "lbFont";
            lbFont.Size = new Size(38, 15);
            lbFont.TabIndex = 0;
            lbFont.Text = "Font :";
            // 
            // grpFont
            // 
            grpFont.Controls.Add(grpTreeList);
            grpFont.Controls.Add(grpForm);
            grpFont.Controls.Add(grpBar);
            grpFont.Controls.Add(chkltalic);
            grpFont.Controls.Add(chkBlod);
            grpFont.Controls.Add(cboFont);
            grpFont.Controls.Add(txtSampleText);
            grpFont.Controls.Add(lbFont);
            grpFont.Location = new Point(12, 12);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(337, 638);
            grpFont.TabIndex = 1;
            grpFont.TabStop = false;
            grpFont.Text = "ComboBox, CheckBox, TextBox";
            // 
            // grpTreeList
            // 
            grpTreeList.Controls.Add(btnAddChild);
            grpTreeList.Controls.Add(btnAddRoot);
            grpTreeList.Controls.Add(LvDummy);
            grpTreeList.Controls.Add(tvDummy);
            grpTreeList.Location = new Point(25, 308);
            grpTreeList.Name = "grpTreeList";
            grpTreeList.Size = new Size(284, 258);
            grpTreeList.TabIndex = 7;
            grpTreeList.TabStop = false;
            grpTreeList.Text = "TreeView && ListView";
            grpTreeList.Enter += grpTreeList_Enter;
            // 
            // btnAddChild
            // 
            btnAddChild.Location = new Point(87, 171);
            btnAddChild.Name = "btnAddChild";
            btnAddChild.Size = new Size(75, 23);
            btnAddChild.TabIndex = 3;
            btnAddChild.Text = "자식 추가";
            btnAddChild.UseVisualStyleBackColor = true;
            btnAddChild.Click += btnAddChild_Click;
            // 
            // btnAddRoot
            // 
            btnAddRoot.Location = new Point(6, 171);
            btnAddRoot.Name = "btnAddRoot";
            btnAddRoot.Size = new Size(75, 23);
            btnAddRoot.TabIndex = 2;
            btnAddRoot.Text = "루트 추가";
            btnAddRoot.UseVisualStyleBackColor = true;
            btnAddRoot.Click += btnAddRoot_Click;
            // 
            // LvDummy
            // 
            LvDummy.Location = new Point(148, 35);
            LvDummy.Name = "LvDummy";
            LvDummy.Size = new Size(130, 121);
            LvDummy.TabIndex = 1;
            LvDummy.UseCompatibleStateImageBehavior = false;
            LvDummy.View = View.Details;
            // 
            // tvDummy
            // 
            tvDummy.Location = new Point(6, 35);
            tvDummy.Name = "tvDummy";
            tvDummy.Size = new Size(136, 121);
            tvDummy.TabIndex = 0;
            // 
            // grpForm
            // 
            grpForm.Controls.Add(btnMsgBox);
            grpForm.Controls.Add(btnModaless);
            grpForm.Controls.Add(btnModal);
            grpForm.Location = new Point(25, 246);
            grpForm.Name = "grpForm";
            grpForm.Size = new Size(284, 56);
            grpForm.TabIndex = 6;
            grpForm.TabStop = false;
            grpForm.Text = "Modal & Modaless";
            // 
            // btnMsgBox
            // 
            btnMsgBox.Location = new Point(168, 22);
            btnMsgBox.Name = "btnMsgBox";
            btnMsgBox.Size = new Size(101, 23);
            btnMsgBox.TabIndex = 4;
            btnMsgBox.Text = "MessageBox";
            btnMsgBox.UseVisualStyleBackColor = true;
            btnMsgBox.Click += btnMsgBox_Click;
            // 
            // btnModaless
            // 
            btnModaless.Location = new Point(87, 22);
            btnModaless.Name = "btnModaless";
            btnModaless.Size = new Size(75, 23);
            btnModaless.TabIndex = 3;
            btnModaless.Text = "Modaless";
            btnModaless.UseVisualStyleBackColor = true;
            btnModaless.Click += btnModaless_Click;
            // 
            // btnModal
            // 
            btnModal.Location = new Point(6, 22);
            btnModal.Name = "btnModal";
            btnModal.Size = new Size(75, 23);
            btnModal.TabIndex = 2;
            btnModal.Text = "Modal";
            btnModal.UseVisualStyleBackColor = true;
            btnModal.Click += btnModal_Click;
            // 
            // grpBar
            // 
            grpBar.Controls.Add(pgDummy);
            grpBar.Controls.Add(tbDummy);
            grpBar.Location = new Point(25, 121);
            grpBar.Name = "grpBar";
            grpBar.Size = new Size(284, 100);
            grpBar.TabIndex = 5;
            grpBar.TabStop = false;
            grpBar.Text = "TrackVar조각 && 프로sess바";
            // 
            // pgDummy
            // 
            pgDummy.Location = new Point(6, 61);
            pgDummy.Name = "pgDummy";
            pgDummy.Size = new Size(272, 23);
            pgDummy.TabIndex = 1;
            // 
            // tbDummy
            // 
            tbDummy.Location = new Point(6, 22);
            tbDummy.Maximum = 20;
            tbDummy.Name = "tbDummy";
            tbDummy.Size = new Size(272, 45);
            tbDummy.TabIndex = 0;
            tbDummy.Scroll += tbDummy_Scroll;
            // 
            // chkltalic
            // 
            chkltalic.AutoSize = true;
            chkltalic.Location = new Point(259, 56);
            chkltalic.Name = "chkltalic";
            chkltalic.Size = new Size(62, 19);
            chkltalic.TabIndex = 4;
            chkltalic.Text = "이탤릭";
            chkltalic.UseVisualStyleBackColor = true;
            chkltalic.CheckedChanged += chkItalic_checkedchanged;
            // 
            // chkBlod
            // 
            chkBlod.AutoSize = true;
            chkBlod.Location = new Point(203, 56);
            chkBlod.Name = "chkBlod";
            chkBlod.Size = new Size(50, 19);
            chkBlod.TabIndex = 3;
            chkBlod.Text = "굵게";
            chkBlod.UseVisualStyleBackColor = true;
            chkBlod.CheckedChanged += chkBold_checkedchanged;
            // 
            // cboFont
            // 
            cboFont.FormattingEnabled = true;
            cboFont.Location = new Point(76, 54);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(121, 23);
            cboFont.TabIndex = 2;
            cboFont.SelectedIndexChanged += cboFont_SelectedIndexChanged;
            // 
            // txtSampleText
            // 
            txtSampleText.Location = new Point(25, 83);
            txtSampleText.Name = "txtSampleText";
            txtSampleText.Size = new Size(284, 23);
            txtSampleText.TabIndex = 1;
            txtSampleText.Text = "Hello, C#";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 673);
            Controls.Add(grpFont);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            grpTreeList.ResumeLayout(false);
            grpForm.ResumeLayout(false);
            grpBar.ResumeLayout(false);
            grpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbDummy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbFont;
        private GroupBox grpFont;
        private TextBox txtSampleText;
        private ComboBox cboFont;
        private CheckBox chkBlod;
        private CheckBox chkltalic;
        private GroupBox grpBar;
        private TrackBar tbDummy;
        private ProgressBar pgDummy;
        private Button btnModal;
        private GroupBox grpForm;
        private Button btnMsgBox;
        private Button btnModaless;
        private GroupBox grpTreeList;
        private TreeView tvDummy;
        private ListView LvDummy;
        private Button btnAddRoot;
        private Button btnAddChild;
    }
}

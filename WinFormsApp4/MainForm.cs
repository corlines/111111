using System.Drawing.Text;

namespace WinFormsApp4
{
    public partial class MainForm : Form
    {
        Random random = new Random(37);
        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
            {
                cboFont.Items.Add(font.Name);
            }


        }
        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)
            {
                return;
            }
            FontStyle style = FontStyle.Regular;
            if (chkBlod.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (chkltalic.Checked)
                style |= FontStyle.Italic;
            txtSampleText.Font =
                new Font((string)cboFont.SelectedItem, 10, style);

        }
        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void chkBold_checkedchanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void chkItalic_checkedchanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void cboFont_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void grpFont_Enter(object sender, EventArgs e)
        {

        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value * 5;
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog();

        }
        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Green;
            frm.Show();
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text,
                "messageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public partial class Mainform : Form
        {
            Random random = new Random(37);
        }
        public MainForm()
        {
            InitializeComponent();

            LvDummy.Columns.Add("Name");
            LvDummy.Columns.Add("Depth");
        }

        void TreeToList()
        {
            LvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes)
            {
                TreeToList(node);
            }
        }
        void TreeToList(TreeNode Node)
        {
            LvDummy.Items.Add(new ListViewItem(new string[] { Node.Text, Node.FullPath.Count(f => f == '\\').ToString() }));
            foreach (TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void grpTreeList_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddChild_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }
    }
}

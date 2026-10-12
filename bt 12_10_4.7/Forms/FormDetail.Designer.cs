namespace Bai47_MDI.Forms;

partial class FormDetail
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel tblInfo;
    private Button btnClose;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tblInfo = new TableLayoutPanel();
        btnClose = new Button();
        SuspendLayout();

        tblInfo.ColumnCount = 2;
        tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
        tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tblInfo.Dock = DockStyle.Fill;
        tblInfo.Location = new Point(16, 16);
        tblInfo.Name = "tblInfo";
        tblInfo.Padding = new Padding(8);

        btnClose.DialogResult = DialogResult.OK;
        btnClose.Dock = DockStyle.Bottom;
        btnClose.Location = new Point(16, 200);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(90, 30);
        btnClose.Text = "Đóng";

        AcceptButton = btnClose;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(420, 250);
        Controls.Add(tblInfo);
        Controls.Add(btnClose);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormDetail";
        Padding = new Padding(16);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Chi tiết";

        ResumeLayout(false);
    }
}

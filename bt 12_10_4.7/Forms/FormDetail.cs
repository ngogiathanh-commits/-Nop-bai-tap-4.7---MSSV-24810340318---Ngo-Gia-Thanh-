namespace Bai47_MDI.Forms;

public partial class FormDetail : Form
{
    public FormDetail(string title, IReadOnlyList<(string Label, string Value)> rows)
    {
        InitializeComponent();
        Text = title;
        BindRows(rows);
    }

    private void BindRows(IReadOnlyList<(string Label, string Value)> rows)
    {
        tblInfo.Controls.Clear();
        tblInfo.RowStyles.Clear();
        tblInfo.RowCount = rows.Count;

        for (var i = 0; i < rows.Count; i++)
        {
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblInfo.Controls.Add(new Label
            {
                Text = rows[i].Label + ":",
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            }, 0, i);
            tblInfo.Controls.Add(new Label
            {
                Text = rows[i].Value,
                AutoSize = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            }, 1, i);
        }

        ClientSize = new Size(420, 80 + rows.Count * 28);
    }
}

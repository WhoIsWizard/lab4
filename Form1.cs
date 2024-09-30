using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;

namespace lab4
{
    public partial class FORMMAIN : Form
    {

        private BindingList<DOCDATACLASS> dataSource;

        public FORMMAIN()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            DOCDATACLASS data = new DOCDATACLASS();

            FDoc fd = new FDoc(data);
            if (fd.ShowDialog() == DialogResult.OK)
            {
                dataSource.Add(data);
            }

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (gvDOCS.CurrentRow != null)
            {
                DOCDATACLASS data = (DOCDATACLASS)gvDOCS.CurrentRow.DataBoundItem;

                FDoc fd = new FDoc(data);
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    gvDOCS.Refresh();
                }
            }
            
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (gvDOCS.CurrentRow != null)
            {
                if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DOCDATACLASS data = (DOCDATACLASS)gvDOCS.CurrentRow.DataBoundItem;
                    dataSource.Remove(data);
                }
            }
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dataSource.Clear();
            }

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void FORMMAIN_Load(object sender, EventArgs e)
        {
            gvDOCS.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn column;

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ID";
            column.Name = "Id";
            gvDOCS.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Ім'я";
            gvDOCS.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Surname";
            column.Name = "Прізвище";
            gvDOCS.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Date_Of_Birth";
            column.Name = "Дата народження";
            gvDOCS.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Nationality";
            column.Name = "Національність";
            gvDOCS.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SexString";
            column.Name = "Стать";
            gvDOCS.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Date_Of_Issue";
            column.Name = "Дата видачі";
            gvDOCS.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Date_Of_expire";
            column.Name = "Дата закінчення";
            gvDOCS.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Individual_tax_number";
            column.Name = "ІПН";
            gvDOCS.Columns.Add(column);

            dataSource = new BindingList<DOCDATACLASS>();

            dataSource.Add(new DOCDATACLASS("123456", "Іван", "Рево", "01-01-1990", "Україна", true, "01-01-2015", "01-01-2025", "1234567890"));

            gvDOCS.DataSource = dataSource;

            gvDOCS.AutoResizeColumns();

            EventArgs args = new EventArgs();
            OnResize(args);

        }
    }
}

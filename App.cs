using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Flare
{
    public partial class App : Form
    {
        private Timer connectionCheckTimer = new Timer();
        private SqlConnection FlareConnection = null;
        string FlareDB = "Data Source=LAKSHITHA-DELL;Initial Catalog=Flare;Integrated Security=True";
        private static bool DBLoadedFirstTime = false;
        private int QueryType = 0;
        private int QueryCount = 0;
        private int ProblemCount = 0;

        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            connectionCheckTimer = new Timer();
            connectionCheckTimer.Interval = 1000;
            connectionCheckTimer.Tick += async (sender, e) => await CheckConnection();
            connectionCheckTimer.Tick += async (sender, e) => await UpdateUI();
            connectionCheckTimer.Start();
        }

        private async Task UpdateUI()
        {
            Queries.Text = $"({QueryCount}) Queries executed";
            ProblemQueries.Text = $"({ProblemCount}) Problem queries";
            SuccessQueries.Text = $"({QueryCount - ProblemCount}) Success queries";
        }

        private async Task CheckConnection()
        {
            using (FlareConnection = new SqlConnection(FlareDB))
            {
                try
                {
                    await FlareConnection.OpenAsync();
                    DBStatus.Text = "⚫ Connected";
                    DBStatus.ForeColor = Color.Green;
                    if (!DBLoadedFirstTime)
                    {
                        SearchISBN.Text = "";
                        CheckForSearch();
                        DBLoadedFirstTime = true;
                    }
                }
                catch (SqlException)
                {
                    PushSqlComment($"\nDatabase connection inturrupted.\n");
                    DBStatus.Text = "⚫ Not Connected";
                    DBStatus.ForeColor = Color.Red;
                    DBLoadedFirstTime = false;
                }
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            QueryStatusProgress.Value = 0;
            QueryCount++;

            if (QueryType == 0)
            {
                CheckForNew();
            }
            else if (QueryType == 1)
            {
                CheckForUpdate();
            }
            else if (QueryType == 2)
            {
                CheckForSearch();

            }
            else
            {
                DeleteRow();
            }
            ClearFields();
        }

        private void CheckForNew()
        {
            string title = NewTitle.Text.Trim();
            string isbn = NewISBN.Text.Trim().ToLower();
            string author = NewAuthor.Text.Trim();
            int quantity = (int)NewQnt.Value;

            if (title.Length > 0 && isbn.Length > 0 && author.Length > 0)
            {
                using (FlareConnection = new SqlConnection(FlareDB))
                {
                    try
                    {
                        FlareConnection.Open();
                    }
                    catch (Exception)
                    {
                        PushSqlComment($"\nSomething went wrong, try fixing errors.\n");
                        ProblemCount++;
                        return;
                    }

                    string query = $"INSERT INTO BookInventory(ISBN, Title, Author, Quantity) VALUES('{isbn.ToUpper()}', '{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title)}', '{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(author)}', {quantity})";
                    using (SqlCommand command = new SqlCommand(query, FlareConnection))
                    {
                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            QueryStatusProgress.Value = 100;

                            SearchISBN.Text = "";
                            CheckForSearch();
                            PushSqlComment($"{query}");
                            PushSqlComment($"\n{rowsAffected} row(s) inserted.\n");
                        }
                        catch (Exception ex)
                        {
                            ProblemCount++;
                            PushSqlComment($"{query}");
                            PushSqlComment($"\n{ex}\n");
                            return;
                        }
                    }
                }
            }
        }

        private void CheckForUpdate()
        {
            using (FlareConnection = new SqlConnection(FlareDB))
            {
                try
                {
                    FlareConnection.Open();
                }
                catch (Exception)
                {
                    PushSqlComment($"\nSomething went wrong, try fixing errors.\n");
                    ProblemCount++;
                    return;
                }

                string query = $"SELECT ISBN FROM BookInventory";
                using (SqlCommand command = new SqlCommand(query, FlareConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (UpdateISBN.Text.Trim().ToUpper() == (string)reader["ISBN"])
                            {
                                string title = UpdateTitle.Text.Trim();
                                string author = UpdateAuthor.Text.Trim();
                                int quantity = (int)UpdateQnt.Value;

                                if (title.Length > 0 && author.Length > 0)
                                {
                                    using (FlareConnection = new SqlConnection(FlareDB))
                                    {
                                        FlareConnection.Open();
                                        string query_2 = $"UPDATE BookInventory SET ISBN = '{UpdateISBN.Text.Trim().ToUpper()}', Title = '{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title)}', Author = '{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(author)}', Quantity = {quantity} WHERE ISBN = '{UpdateISBN.Text.Trim().ToUpper()}'";
                                        using (SqlCommand command_2 = new SqlCommand(query_2, FlareConnection))
                                        {
                                            try
                                            {
                                                int rowsAffected = command_2.ExecuteNonQuery();
                                                QueryStatusProgress.Value = 100;

                                                SearchISBN.Text = "";
                                                CheckForSearch();
                                                PushSqlComment(query_2);
                                                PushSqlComment($"\n{rowsAffected} row(s) inserted.\n");
                                            }
                                            catch (Exception ex)
                                            {
                                                ProblemCount++;
                                                PushSqlComment($"{query}");
                                                PushSqlComment($"\n{ex}\n");
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void FindISBN_Click(object sender, EventArgs e)
        {
            using (FlareConnection = new SqlConnection(FlareDB))
            {
                try
                {
                    FlareConnection.Open();
                }
                catch (Exception)
                {
                    PushSqlComment($"\nSomething went wrong, try fixing errors.\n");
                    ProblemCount++;
                    return;
                }

                string isbn = UpdateISBN.Text.Trim().ToUpper();
                string query = $"SELECT ISBN, Title, Author, Quantity FROM BookInventory WHERE ISBN = '{isbn}'";
                if (isbn.Length > 0)
                {
                    using (SqlCommand command = new SqlCommand(query, FlareConnection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int count = 0;

                            while (reader.Read())
                            {
                                string isbn_2 = (string)reader[0];
                                string title = (string)reader[1];
                                string author = (string)reader[2];
                                int quantity = (int)reader[3];

                                UpdateISBN.Text = isbn_2;
                                UpdateTitle.Text = title;
                                UpdateAuthor.Text = author;
                                UpdateQnt.Value = quantity;

                                UpdateTitle.Enabled = true;
                                UpdateAuthor.Enabled = true;
                                UpdateQnt.Enabled = true;

                                count++;
                            }

                            PushSqlComment(query);
                            PushSqlComment($"\n{count} row is ready to update.\n");
                            if (isbn.Length > 0 && count == 0)
                            {
                                ProblemCount++;
                            }
                            else
                            {
                                QueryStatusProgress.Value = 100;
                            }
                        }
                    }
                }
                else
                {
                    PushSqlComment(query);
                    PushSqlComment($"\n0 row is ready to update.\n");
                    ProblemCount++;
                }

            }
        }

        private void CheckForSearch()
        {
            using (FlareConnection = new SqlConnection(FlareDB))
            {
                try
                {
                    FlareConnection.Open();
                }
                catch (Exception)
                {
                    PushSqlComment($"\nSomething went wrong, try fixing errors.\n");
                    ProblemCount++;
                    return;
                }

                string isbn = SearchISBN.Text.Trim().ToUpper();
                string query = null;

                if (isbn.Length > 0)
                {
                    query = $"SELECT ISBN, Title, Author, Quantity FROM BookInventory WHERE ISBN = '{isbn}'";
                }
                else
                {
                    query = $"SELECT ISBN, Title, Author, Quantity FROM BookInventory";
                }
                using (SqlCommand command = new SqlCommand(query, FlareConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int count = 0;
                        DataBaseView.Rows.Clear();
                        QueryStatusProgress.Value = 100;
                        while (reader.Read())
                        {
                            string isbn_2 = (string)reader[0];
                            string title = (string)reader[1];
                            string author = (string)reader[2];
                            int quantity = (int)reader[3];

                            DataBaseView.Rows.Add();
                            DataBaseView.Rows[count].Cells[0].Value = count + 1;
                            DataBaseView.Rows[count].Cells[1].Value = isbn_2;
                            DataBaseView.Rows[count].Cells[2].Value = title;
                            DataBaseView.Rows[count].Cells[3].Value = author;
                            DataBaseView.Rows[count].Cells[4].Value = quantity;

                            count++;
                        }

                        PushSqlComment(query);
                        PushSqlComment($"\n{count} row(s) added. \n");
                        if (isbn.Length > 0 && count == 0)
                        {
                            ProblemCount++;
                        }
                    }
                }
            }
        }

        private void DeleteRow()
        {
            string isbn = DeleteISBN.Text.Trim().ToUpper();

            if (isbn.Length > 0)
            {
                DialogResult DeleteConfirmation = MessageBox.Show($"Are you sure to remove {isbn} book if recorded already?", "Flare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DeleteConfirmation == DialogResult.Yes)
                {
                    using (FlareConnection = new SqlConnection(FlareDB))
                    {
                        try
                        {
                            FlareConnection.Open();
                        }
                        catch (Exception)
                        {
                            PushSqlComment($"\nSomething went wrong, try fixing errors.\n");
                            ProblemCount++;
                            return;
                        }

                        string query = $"DELETE FROM BookInventory WHERE ISBN = '{isbn}'";
                        using (SqlCommand command = new SqlCommand(query, FlareConnection))
                        {
                            try
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                QueryStatusProgress.Value = 100;

                                SearchISBN.Text = "";
                                CheckForSearch();
                                PushSqlComment($"{query}");
                                PushSqlComment($"\n{rowsAffected} row(s) deleted.\n");
                                if (rowsAffected == 0)
                                {
                                    ProblemCount++;
                                }
                            }
                            catch (Exception ex)
                            {
                                ProblemCount++;
                                PushSqlComment($"{query}");
                                PushSqlComment($"\n{ex}\n");
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void PushSqlComment(string comment)
        {
            SqlComments.Text = $"{comment}\n" + SqlComments.Text;
        }

        private void ActionsPane_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ActionsPane.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    QueryType = 0;
                    break;
                case 1:
                    QueryType = 1;
                    break;
                case 2:
                    QueryType = 2;
                    break;
                case 3:
                    QueryType = 3;
                    break;
            }
        }

        private void ClearFields()
        {
            NewISBN.Text = "";
            NewTitle.Text = "";
            NewAuthor.Text = "";
            NewQnt.Value = 0;

            UpdateISBN.Text = "";
            UpdateTitle.Text = "";
            UpdateAuthor.Text = "";
            UpdateQnt.Value = 0;
            UpdateTitle.Enabled = false;
            UpdateAuthor.Enabled = false;
            UpdateQnt.Enabled = false;

            SearchISBN.Text = "";

            DeleteISBN.Text = "";
        }

        private void CellDataToClipboard(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                object cellValue = DataBaseView.Rows[e.RowIndex].Cells[1].Value;

                if (cellValue != null)
                {
                    UpdateISBN.Text = cellValue.ToString();
                    SearchISBN.Text = cellValue.ToString();
                    DeleteISBN.Text = cellValue.ToString();
                }
            }
        }
    }

}
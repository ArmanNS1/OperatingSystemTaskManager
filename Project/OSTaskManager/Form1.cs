using System.Diagnostics;

namespace OSTaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadProcesses();
        }

        private void LoadProcesses()
        {
            processGridView.Rows.Clear();
            processGridView.Columns.Clear();

            processGridView.Columns.Add("PID", "PID");
            processGridView.Columns.Add("Memory", "Memory (MB)");
            processGridView.Columns.Add("Name", "Process Name");

            foreach (Process proc in Process.GetProcesses())
            {
                try
                {
                    int pid = proc.Id;
                    string name = proc.ProcessName;
                    double memory = proc.WorkingSet64 / (1024.0 * 1024.0);

                    processGridView.Rows.Add(pid, memory.ToString("F2"), name);
                }
                catch
                {
                    // Skip inaccessible processes
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            if (processGridView.SelectedRows.Count > 0)
            {
                int pid = Convert.ToInt32(processGridView.SelectedRows[0].Cells[0].Value);
                try
                {
                    Process proc = Process.GetProcessById(pid);
                    proc.Kill();
                    MessageBox.Show($"Process {proc.ProcessName} (PID {pid}) killed.");
                    LoadProcesses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to kill process: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a process to kill.");
            }
        }
    }
}

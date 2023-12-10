using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_dataGridView_Test
{
    public partial class Realtime_dataGridView_Test : Form
    {
        /// <summary>
        /// DataGridView List Class 선언
        /// </summary>
        List<Balance_Realtime> gBalanceRealtime = new List<Balance_Realtime>();

        /// <summary>
        /// 전역 변수 / 상수 선언
        /// </summary>
        int itemNo = 0;
        int cur_cnt = 0;

        public readonly int MAX_VISIBLE_LIST_COUNT;

        public Realtime_dataGridView_Test()
        {
            MAX_VISIBLE_LIST_COUNT = 20;

            InitializeComponent();
        }

        private void Realtime_dataGridView_Test_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MAX_VISIBLE_LIST_COUNT; i++)
            {
                dgvRealtimeBalance.Rows.Add();
            }
            dgvRealtimeBalance.CurrentCell = null;

            tbCurCount.Text = "0";
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            cur_cnt = int.Parse(tbCurCount.Text);
            itemNo = itemNo + 1; // itemNo++;

            dgvRealtimeBalance.AutoGenerateColumns = false;
            dgvRealtimeBalance.DataSource = null;
            dgvRealtimeBalance.Rows.Clear();

            string name = "카카오뱅크" + Convert.ToString((int)itemNo);
            if (cur_cnt == 0)
            {
                gBalanceRealtime.Insert(cur_cnt, new Balance_Realtime(name, 26000, 3000, 1.57, 25600, 25000));
                int count = MAX_VISIBLE_LIST_COUNT - gBalanceRealtime.Count;
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        gBalanceRealtime.Add(new Balance_Realtime("", 0m, 0m, 0d, 0m, 0m));
                    }
                }
            }
            else if (cur_cnt > 0)
            {
                if (cur_cnt < MAX_VISIBLE_LIST_COUNT)
                {
                    gBalanceRealtime.RemoveAt(MAX_VISIBLE_LIST_COUNT - 1);
                    gBalanceRealtime.Insert(cur_cnt, new Balance_Realtime(name, 26000, 3000, 1.57, 25600, 25000));
                }
                else if (cur_cnt >= MAX_VISIBLE_LIST_COUNT)
                {
                    gBalanceRealtime.Add(new Balance_Realtime(name, 26000, 3000, 1.57, 25600, 25000));
                }
            }
            cur_cnt = cur_cnt + 1;
            tbCurCount.Text = Convert.ToString((int)cur_cnt);
            dgvRealtimeBalance.DataSource = gBalanceRealtime;
            if (cur_cnt >= 15)
                dgvRealtimeBalance.FirstDisplayedScrollingRowIndex = dgvRealtimeBalance.Rows.Count - 1;
        }

        private void btnDelData_Click(object sender, EventArgs e)
        {
            int index = 0;

            if (tbIndexInfo.Text == "")
            {
                if (MessageBox.Show("삭제할 아이템의 인덱스를 입력하세요.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                if (cur_cnt == 0)
                {
                    if (MessageBox.Show("삭제할 아이템이 없습니다..", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    try
                    {
                        index = int.Parse(tbIndexInfo.Text);
                        index = index - 1;
                        if (gBalanceRealtime[index].CodeName == "")
                        {
                            if (MessageBox.Show("삭제할 아이템이 없습니다..", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            gBalanceRealtime.RemoveAt(index);
                            cur_cnt = cur_cnt - 1;
                            tbCurCount.Text = Convert.ToString((int)cur_cnt);
                            if (gBalanceRealtime.Count < MAX_VISIBLE_LIST_COUNT)
                            {
                                for (int i = 0; i < MAX_VISIBLE_LIST_COUNT - gBalanceRealtime.Count; i++)
                                {
                                    gBalanceRealtime.Add(new Balance_Realtime("", 0m, 0m, 0d, 0m, 0m));
                                }
                            }

                            // reload Item list
                            dgvRealtimeBalance.AutoGenerateColumns = false;
                            dgvRealtimeBalance.DataSource = null;
                            dgvRealtimeBalance.Rows.Clear();
                            dgvRealtimeBalance.DataSource = gBalanceRealtime;
                        }
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("Attempted access out of range");                        
                    }
                }
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            dgvRealtimeBalance.AutoGenerateColumns = false;
            dgvRealtimeBalance.DataSource = null;
            dgvRealtimeBalance.Rows.Clear();
            gBalanceRealtime.Clear();

            for (int i = 0; i < MAX_VISIBLE_LIST_COUNT; i++)
            {
                dgvRealtimeBalance.Rows.Add();
            }
            dgvRealtimeBalance.CurrentCell = null;

            tbCurCount.Text = "0";
            itemNo = 0;
        }
    }
}

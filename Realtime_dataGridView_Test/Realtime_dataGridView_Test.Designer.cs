
namespace Realtime_dataGridView_Test
{
    partial class Realtime_dataGridView_Test
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dgvRealtimeBalance = new System.Windows.Forms.DataGridView();
            this.CodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stoploss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnDelData = new System.Windows.Forms.Button();
            this.tbIndexInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearData = new System.Windows.Forms.Button();
            this.tbCurCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealtimeBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox9.Location = new System.Drawing.Point(187, 12);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(82, 21);
            this.textBox9.TabIndex = 25;
            this.textBox9.Text = "평가손익";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox11.Location = new System.Drawing.Point(399, 12);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(71, 21);
            this.textBox11.TabIndex = 24;
            this.textBox11.Text = "스탑로스";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox14.Location = new System.Drawing.Point(268, 12);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(62, 21);
            this.textBox14.TabIndex = 23;
            this.textBox14.Text = "손익률";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox16.Location = new System.Drawing.Point(329, 12);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(71, 21);
            this.textBox16.TabIndex = 22;
            this.textBox16.Text = "기준가";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox6.Location = new System.Drawing.Point(11, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(96, 21);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "종목명";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox10.Location = new System.Drawing.Point(106, 12);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(82, 21);
            this.textBox10.TabIndex = 20;
            this.textBox10.Text = "현재가";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvRealtimeBalance
            // 
            this.dgvRealtimeBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRealtimeBalance.ColumnHeadersVisible = false;
            this.dgvRealtimeBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeName,
            this.CurPrice,
            this.EvalPrice,
            this.EvalRate,
            this.BasePrice,
            this.Stoploss});
            this.dgvRealtimeBalance.Location = new System.Drawing.Point(12, 30);
            this.dgvRealtimeBalance.Name = "dgvRealtimeBalance";
            this.dgvRealtimeBalance.ReadOnly = true;
            this.dgvRealtimeBalance.RowHeadersVisible = false;
            this.dgvRealtimeBalance.RowTemplate.Height = 23;
            this.dgvRealtimeBalance.Size = new System.Drawing.Size(473, 348);
            this.dgvRealtimeBalance.TabIndex = 26;
            // 
            // CodeName
            // 
            this.CodeName.DataPropertyName = "CodeName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodeName.DefaultCellStyle = dataGridViewCellStyle1;
            this.CodeName.HeaderText = "종목명";
            this.CodeName.Name = "CodeName";
            this.CodeName.ReadOnly = true;
            this.CodeName.Width = 92;
            // 
            // CurPrice
            // 
            this.CurPrice.DataPropertyName = "CurPrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.CurPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.CurPrice.HeaderText = "현재가";
            this.CurPrice.Name = "CurPrice";
            this.CurPrice.ReadOnly = true;
            this.CurPrice.Width = 80;
            // 
            // EvalPrice
            // 
            this.EvalPrice.DataPropertyName = "EvalPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.EvalPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.EvalPrice.HeaderText = "평가손익";
            this.EvalPrice.Name = "EvalPrice";
            this.EvalPrice.ReadOnly = true;
            this.EvalPrice.Width = 81;
            // 
            // EvalRate
            // 
            this.EvalRate.DataPropertyName = "EvalRate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.EvalRate.DefaultCellStyle = dataGridViewCellStyle4;
            this.EvalRate.HeaderText = "손익률";
            this.EvalRate.Name = "EvalRate";
            this.EvalRate.ReadOnly = true;
            this.EvalRate.Width = 61;
            // 
            // BasePrice
            // 
            this.BasePrice.DataPropertyName = "BasePrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.BasePrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.BasePrice.HeaderText = "기준가";
            this.BasePrice.Name = "BasePrice";
            this.BasePrice.ReadOnly = true;
            this.BasePrice.ToolTipText = "매수 이후 최고가";
            this.BasePrice.Width = 70;
            // 
            // Stoploss
            // 
            this.Stoploss.DataPropertyName = "Stoploss";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.Stoploss.DefaultCellStyle = dataGridViewCellStyle6;
            this.Stoploss.HeaderText = "스탑로스";
            this.Stoploss.Name = "Stoploss";
            this.Stoploss.ReadOnly = true;
            this.Stoploss.Width = 69;
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(513, 30);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(171, 33);
            this.btnAddData.TabIndex = 27;
            this.btnAddData.Text = "데이터 추가";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnDelData
            // 
            this.btnDelData.Location = new System.Drawing.Point(574, 69);
            this.btnDelData.Name = "btnDelData";
            this.btnDelData.Size = new System.Drawing.Size(110, 33);
            this.btnDelData.TabIndex = 28;
            this.btnDelData.Text = "데이터 삭제";
            this.btnDelData.UseVisualStyleBackColor = true;
            this.btnDelData.Click += new System.EventHandler(this.btnDelData_Click);
            // 
            // tbIndexInfo
            // 
            this.tbIndexInfo.Font = new System.Drawing.Font("굴림", 9F);
            this.tbIndexInfo.Location = new System.Drawing.Point(513, 76);
            this.tbIndexInfo.Name = "tbIndexInfo";
            this.tbIndexInfo.Size = new System.Drawing.Size(26, 21);
            this.tbIndexInfo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "번째";
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(513, 108);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(171, 33);
            this.btnClearData.TabIndex = 31;
            this.btnClearData.Text = "데이터 초기화";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // tbCurCount
            // 
            this.tbCurCount.Location = new System.Drawing.Point(602, 147);
            this.tbCurCount.Name = "tbCurCount";
            this.tbCurCount.Size = new System.Drawing.Size(82, 21);
            this.tbCurCount.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "현재 잔고 갯수";
            // 
            // Realtime_dataGridView_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCurCount);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIndexInfo);
            this.Controls.Add(this.btnDelData);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.dgvRealtimeBalance);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox10);
            this.Name = "Realtime_dataGridView_Test";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Realtime_dataGridView_Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealtimeBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DataGridView dgvRealtimeBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvalRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stoploss;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnDelData;
        private System.Windows.Forms.TextBox tbIndexInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.TextBox tbCurCount;
        private System.Windows.Forms.Label label2;
    }
}


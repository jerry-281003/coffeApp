namespace coffeApp
{
	partial class Management
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
			TableShowOrder = new DataGridView();
			btnShowOrder = new Button();
			btnCalculateRevenue = new Button();
			labelRevenue = new Label();
			TableShowStaff = new DataGridView();
			btnShowStaff = new Button();
			inputStatus = new ComboBox();
			inputStaffId = new TextBox();
			btnAddAtendance = new Button();
			inputDateTime = new DateTimePicker();
			labelProfit = new Label();
			btnCalculateProfit = new Button();
			((System.ComponentModel.ISupportInitialize)TableShowOrder).BeginInit();
			((System.ComponentModel.ISupportInitialize)TableShowStaff).BeginInit();
			SuspendLayout();
			// 
			// TableShowOrder
			// 
			TableShowOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TableShowOrder.Location = new Point(334, 74);
			TableShowOrder.Name = "TableShowOrder";
			TableShowOrder.RowHeadersWidth = 62;
			TableShowOrder.RowTemplate.Height = 33;
			TableShowOrder.Size = new Size(910, 303);
			TableShowOrder.TabIndex = 0;
			// 
			// btnShowOrder
			// 
			btnShowOrder.Location = new Point(334, 408);
			btnShowOrder.Name = "btnShowOrder";
			btnShowOrder.Size = new Size(151, 34);
			btnShowOrder.TabIndex = 1;
			btnShowOrder.Text = "Show Order";
			btnShowOrder.UseVisualStyleBackColor = true;
			btnShowOrder.Click += btnShowOrder_Click;
			// 
			// btnCalculateRevenue
			// 
			btnCalculateRevenue.Location = new Point(552, 408);
			btnCalculateRevenue.Name = "btnCalculateRevenue";
			btnCalculateRevenue.Size = new Size(149, 34);
			btnCalculateRevenue.TabIndex = 2;
			btnCalculateRevenue.Text = "Revenue";
			btnCalculateRevenue.UseVisualStyleBackColor = true;
			btnCalculateRevenue.Click += btnCalculateRevenue_Click;
			// 
			// labelRevenue
			// 
			labelRevenue.AutoSize = true;
			labelRevenue.Location = new Point(707, 413);
			labelRevenue.Name = "labelRevenue";
			labelRevenue.Size = new Size(0, 25);
			labelRevenue.TabIndex = 3;
			// 
			// TableShowStaff
			// 
			TableShowStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TableShowStaff.Location = new Point(350, 480);
			TableShowStaff.Name = "TableShowStaff";
			TableShowStaff.RowHeadersWidth = 62;
			TableShowStaff.RowTemplate.Height = 33;
			TableShowStaff.Size = new Size(910, 237);
			TableShowStaff.TabIndex = 4;
			TableShowStaff.RowHeaderMouseClick += ShowStaff_RowHeaderMouseClick;
			// 
			// btnShowStaff
			// 
			btnShowStaff.Location = new Point(334, 766);
			btnShowStaff.Name = "btnShowStaff";
			btnShowStaff.Size = new Size(151, 34);
			btnShowStaff.TabIndex = 5;
			btnShowStaff.Text = "Show Staff";
			btnShowStaff.UseVisualStyleBackColor = true;
			btnShowStaff.Click += btnShowStaff_Click;
			// 
			// inputStatus
			// 
			inputStatus.FormattingEnabled = true;
			inputStatus.Location = new Point(28, 596);
			inputStatus.Name = "inputStatus";
			inputStatus.Size = new Size(182, 33);
			inputStatus.TabIndex = 15;
			// 
			// inputStaffId
			// 
			inputStaffId.Location = new Point(28, 529);
			inputStaffId.Name = "inputStaffId";
			inputStaffId.Size = new Size(150, 31);
			inputStaffId.TabIndex = 13;
			// 
			// btnAddAtendance
			// 
			btnAddAtendance.Location = new Point(84, 767);
			btnAddAtendance.Name = "btnAddAtendance";
			btnAddAtendance.Size = new Size(177, 34);
			btnAddAtendance.TabIndex = 12;
			btnAddAtendance.Text = "Add Atendance";
			btnAddAtendance.UseVisualStyleBackColor = true;
			btnAddAtendance.Click += btnAddAtendance_Click;
			// 
			// inputDateTime
			// 
			inputDateTime.Location = new Point(28, 677);
			inputDateTime.Name = "inputDateTime";
			inputDateTime.Size = new Size(300, 31);
			inputDateTime.TabIndex = 16;
			// 
			// labelProfit
			// 
			labelProfit.AutoSize = true;
			labelProfit.Location = new Point(982, 413);
			labelProfit.Name = "labelProfit";
			labelProfit.Size = new Size(0, 25);
			labelProfit.TabIndex = 18;
			// 
			// btnCalculateProfit
			// 
			btnCalculateProfit.Location = new Point(864, 408);
			btnCalculateProfit.Name = "btnCalculateProfit";
			btnCalculateProfit.Size = new Size(112, 34);
			btnCalculateProfit.TabIndex = 17;
			btnCalculateProfit.Text = "Profit";
			btnCalculateProfit.UseVisualStyleBackColor = true;
			btnCalculateProfit.Click += btnCalculateProfit_Click;
			// 
			// Management
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1779, 862);
			Controls.Add(labelProfit);
			Controls.Add(btnCalculateProfit);
			Controls.Add(inputDateTime);
			Controls.Add(inputStatus);
			Controls.Add(inputStaffId);
			Controls.Add(btnAddAtendance);
			Controls.Add(btnShowStaff);
			Controls.Add(TableShowStaff);
			Controls.Add(labelRevenue);
			Controls.Add(btnCalculateRevenue);
			Controls.Add(btnShowOrder);
			Controls.Add(TableShowOrder);
			Name = "Management";
			Text = "Management";
			((System.ComponentModel.ISupportInitialize)TableShowOrder).EndInit();
			((System.ComponentModel.ISupportInitialize)TableShowStaff).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView TableShowOrder;
		private Button btnShowOrder;
		private Button btnCalculateRevenue;
		private Label labelRevenue;
		private DataGridView TableShowStaff;
		private Button btnShowStaff;
		private ComboBox inputStatus;
		private TextBox inputStaffId;
		private Button btnAddAtendance;
		private DateTimePicker inputDateTime;
		private Label labelProfit;
		private Button btnCalculateProfit;
	}
}
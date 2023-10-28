namespace coffeApp
{
	partial class ManagementAll
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
			btnAddStaff = new Button();
			inputName = new TextBox();
			inputSalary = new TextBox();
			inputShift = new ComboBox();
			inputUserId = new ComboBox();
			labelProfit = new Label();
			btnCalculateProfit = new Button();
			((System.ComponentModel.ISupportInitialize)TableShowOrder).BeginInit();
			((System.ComponentModel.ISupportInitialize)TableShowStaff).BeginInit();
			SuspendLayout();
			// 
			// TableShowOrder
			// 
			TableShowOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TableShowOrder.Location = new Point(319, 47);
			TableShowOrder.Name = "TableShowOrder";
			TableShowOrder.RowHeadersWidth = 62;
			TableShowOrder.RowTemplate.Height = 33;
			TableShowOrder.Size = new Size(724, 325);
			TableShowOrder.TabIndex = 0;
			// 
			// btnShowOrder
			// 
			btnShowOrder.Location = new Point(384, 404);
			btnShowOrder.Name = "btnShowOrder";
			btnShowOrder.Size = new Size(112, 34);
			btnShowOrder.TabIndex = 1;
			btnShowOrder.Text = "Show ";
			btnShowOrder.UseVisualStyleBackColor = true;
			btnShowOrder.Click += btnShowOrder_Click_1;
			// 
			// btnCalculateRevenue
			// 
			btnCalculateRevenue.Location = new Point(624, 404);
			btnCalculateRevenue.Name = "btnCalculateRevenue";
			btnCalculateRevenue.Size = new Size(112, 34);
			btnCalculateRevenue.TabIndex = 2;
			btnCalculateRevenue.Text = "Revenue";
			btnCalculateRevenue.UseVisualStyleBackColor = true;
			btnCalculateRevenue.Click += btnCalculateRevenue_Click;
			// 
			// labelRevenue
			// 
			labelRevenue.AutoSize = true;
			labelRevenue.Location = new Point(742, 413);
			labelRevenue.Name = "labelRevenue";
			labelRevenue.Size = new Size(0, 25);
			labelRevenue.TabIndex = 3;
			// 
			// TableShowStaff
			// 
			TableShowStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TableShowStaff.Location = new Point(319, 459);
			TableShowStaff.Name = "TableShowStaff";
			TableShowStaff.RowHeadersWidth = 62;
			TableShowStaff.RowTemplate.Height = 33;
			TableShowStaff.Size = new Size(724, 337);
			TableShowStaff.TabIndex = 4;
			TableShowStaff.RowHeaderMouseClick += TableShowStaff_RowHeaderMouseClick;
			// 
			// btnAddStaff
			// 
			btnAddStaff.Location = new Point(112, 762);
			btnAddStaff.Name = "btnAddStaff";
			btnAddStaff.Size = new Size(112, 34);
			btnAddStaff.TabIndex = 5;
			btnAddStaff.Text = "Add Staff";
			btnAddStaff.UseVisualStyleBackColor = true;
			btnAddStaff.Click += btnAddStaff_Click;
			// 
			// inputName
			// 
			inputName.Location = new Point(112, 496);
			inputName.Name = "inputName";
			inputName.Size = new Size(150, 31);
			inputName.TabIndex = 6;
			// 
			// inputSalary
			// 
			inputSalary.Location = new Point(112, 633);
			inputSalary.Name = "inputSalary";
			inputSalary.Size = new Size(150, 31);
			inputSalary.TabIndex = 8;
			// 
			// inputShift
			// 
			inputShift.FormattingEnabled = true;
			inputShift.Location = new Point(112, 562);
			inputShift.Name = "inputShift";
			inputShift.Size = new Size(182, 33);
			inputShift.TabIndex = 10;
			// 
			// inputUserId
			// 
			inputUserId.FormattingEnabled = true;
			inputUserId.Location = new Point(112, 697);
			inputUserId.Name = "inputUserId";
			inputUserId.Size = new Size(182, 33);
			inputUserId.TabIndex = 11;
			// 
			// labelProfit
			// 
			labelProfit.AutoSize = true;
			labelProfit.Location = new Point(979, 409);
			labelProfit.Name = "labelProfit";
			labelProfit.Size = new Size(0, 25);
			labelProfit.TabIndex = 13;
			// 
			// btnCalculateProfit
			// 
			btnCalculateProfit.Location = new Point(861, 404);
			btnCalculateProfit.Name = "btnCalculateProfit";
			btnCalculateProfit.Size = new Size(112, 34);
			btnCalculateProfit.TabIndex = 12;
			btnCalculateProfit.Text = "Profit";
			btnCalculateProfit.UseVisualStyleBackColor = true;
			btnCalculateProfit.Click += btnCalculateProfit_Click;
			// 
			// ManagementAll
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1836, 887);
			Controls.Add(labelProfit);
			Controls.Add(btnCalculateProfit);
			Controls.Add(inputUserId);
			Controls.Add(inputShift);
			Controls.Add(inputSalary);
			Controls.Add(inputName);
			Controls.Add(btnAddStaff);
			Controls.Add(TableShowStaff);
			Controls.Add(labelRevenue);
			Controls.Add(btnCalculateRevenue);
			Controls.Add(btnShowOrder);
			Controls.Add(TableShowOrder);
			Name = "ManagementAll";
			Text = "ManagementAll";
			
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
		private Button btnAddStaff;
		private TextBox inputName;
		private TextBox inputSalary;
		private ComboBox inputShift;
		private ComboBox inputUserId;
		private Label labelProfit;
		private Button btnCalculateProfit;
	}
}
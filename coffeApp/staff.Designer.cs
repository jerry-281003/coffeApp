namespace coffeApp
{
	partial class staff
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
			TableUserOrder = new DataGridView();
			btnDeleteRows = new Button();
			NumberOrderComplete = new TextBox();
			Number = new DataGridViewTextBoxColumn();
			DrinkName = new DataGridViewTextBoxColumn();
			Quantity = new DataGridViewTextBoxColumn();
			Price = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)TableUserOrder).BeginInit();
			SuspendLayout();
			// 
			// TableUserOrder
			// 
			TableUserOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TableUserOrder.Columns.AddRange(new DataGridViewColumn[] { Number, DrinkName, Quantity, Price });
			TableUserOrder.Location = new Point(389, 113);
			TableUserOrder.Name = "TableUserOrder";
			TableUserOrder.RowHeadersWidth = 62;
			TableUserOrder.RowTemplate.Height = 33;
			TableUserOrder.Size = new Size(696, 321);
			TableUserOrder.TabIndex = 0;
			// 
			// btnDeleteRows
			// 
			btnDeleteRows.Location = new Point(575, 465);
			btnDeleteRows.Name = "btnDeleteRows";
			btnDeleteRows.Size = new Size(112, 34);
			btnDeleteRows.TabIndex = 1;
			btnDeleteRows.Text = "Complete";
			btnDeleteRows.UseVisualStyleBackColor = true;
			btnDeleteRows.Click += btnDeleteRows_Click;
			// 
			// NumberOrderComplete
			// 
			NumberOrderComplete.Location = new Point(389, 465);
			NumberOrderComplete.Name = "NumberOrderComplete";
			NumberOrderComplete.Size = new Size(150, 31);
			NumberOrderComplete.TabIndex = 2;
			
			// 
			// Number
			// 
			Number.DataPropertyName = "None";
			Number.HeaderText = "Number Order";
			Number.MinimumWidth = 8;
			Number.Name = "Number";
			Number.Width = 150;
			// 
			// DrinkName
			// 
			DrinkName.HeaderText = "Drink Name";
			DrinkName.MinimumWidth = 8;
			DrinkName.Name = "DrinkName";
			DrinkName.Width = 150;
			// 
			// Quantity
			// 
			Quantity.HeaderText = "Quantity";
			Quantity.MinimumWidth = 8;
			Quantity.Name = "Quantity";
			Quantity.Width = 150;
			// 
			// Price
			// 
			Price.HeaderText = "Price";
			Price.MinimumWidth = 8;
			Price.Name = "Price";
			Price.Width = 150;
			// 
			// staff
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1376, 802);
			Controls.Add(NumberOrderComplete);
			Controls.Add(btnDeleteRows);
			Controls.Add(TableUserOrder);
			Name = "staff";
			Text = "staff";
			((System.ComponentModel.ISupportInitialize)TableUserOrder).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView TableUserOrder;
		private DataGridViewTextBoxColumn Number;
		private DataGridViewTextBoxColumn DrinkName;
		private DataGridViewTextBoxColumn Quantity;
		private DataGridViewTextBoxColumn Price;
		private Button btnDeleteRows;
		private TextBox NumberOrderComplete;
	}
}
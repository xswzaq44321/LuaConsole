namespace WindowsFormLuaConsole
{
	partial class LuaConsole
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button_submit = new System.Windows.Forms.Button();
			this.richTextBox_message = new System.Windows.Forms.RichTextBox();
			this.textbox_command = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button_submit
			// 
			this.button_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_submit.BackColor = System.Drawing.Color.MidnightBlue;
			this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_submit.Font = new System.Drawing.Font("DejaVu Sans Mono", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_submit.ForeColor = System.Drawing.Color.White;
			this.button_submit.Location = new System.Drawing.Point(639, 554);
			this.button_submit.Margin = new System.Windows.Forms.Padding(15, 15, 30, 30);
			this.button_submit.MaximumSize = new System.Drawing.Size(100, 28);
			this.button_submit.MinimumSize = new System.Drawing.Size(100, 28);
			this.button_submit.Name = "button_submit";
			this.button_submit.Size = new System.Drawing.Size(100, 28);
			this.button_submit.TabIndex = 6;
			this.button_submit.Text = "submit";
			this.button_submit.UseVisualStyleBackColor = false;
			this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
			// 
			// richTextBox_message
			// 
			this.richTextBox_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox_message.BackColor = System.Drawing.Color.MidnightBlue;
			this.richTextBox_message.Font = new System.Drawing.Font("DejaVu Sans Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox_message.ForeColor = System.Drawing.Color.White;
			this.richTextBox_message.Location = new System.Drawing.Point(39, 39);
			this.richTextBox_message.Margin = new System.Windows.Forms.Padding(30, 30, 30, 0);
			this.richTextBox_message.Name = "richTextBox_message";
			this.richTextBox_message.ReadOnly = true;
			this.richTextBox_message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBox_message.Size = new System.Drawing.Size(700, 500);
			this.richTextBox_message.TabIndex = 5;
			this.richTextBox_message.Text = "";
			// 
			// textbox_command
			// 
			this.textbox_command.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textbox_command.BackColor = System.Drawing.Color.MidnightBlue;
			this.textbox_command.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textbox_command.Font = new System.Drawing.Font("DejaVu Sans Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textbox_command.ForeColor = System.Drawing.Color.White;
			this.textbox_command.Location = new System.Drawing.Point(39, 554);
			this.textbox_command.Margin = new System.Windows.Forms.Padding(30, 15, 0, 30);
			this.textbox_command.Name = "textbox_command";
			this.textbox_command.Size = new System.Drawing.Size(585, 28);
			this.textbox_command.TabIndex = 4;
			this.textbox_command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandBox_KeyDown);
			// 
			// LuaConsole
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 621);
			this.Controls.Add(this.button_submit);
			this.Controls.Add(this.richTextBox_message);
			this.Controls.Add(this.textbox_command);
			this.Name = "LuaConsole";
			this.Text = "LuaConsole";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_submit;
		private System.Windows.Forms.RichTextBox richTextBox_message;
		private System.Windows.Forms.TextBox textbox_command;
	}
}


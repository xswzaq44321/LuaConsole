using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoonSharp.Interpreter;

namespace WindowsFormLuaConsole
{
	public partial class LuaConsole : Form
	{
		public LuaConsole()
		{
			InitializeComponent();
			// redirect lua stderr to richtextbox_message
			script.Options.DebugPrint = s => richTextBox_message.AppendText(s + "\r\n");
			// initial notation character
			richTextBox_message.AppendText("> ");
			this.ActiveControl = textbox_command;
		}

		Script script = new Script();
		List<string> prevCommands = new List<string>();
		int prevCommandsIter = 0;

		private void commandBox_KeyDown(object sender, KeyEventArgs e)
		{
			TextBox command = sender as TextBox;
			if (e.KeyCode == Keys.Enter)
			{
				submitCommand(command);
			}
			else if (e.KeyCode == Keys.Up)
			{
				if (prevCommands.Count == 0)
					return;
				command.Text = prevCommands[prevCommandsIter == 0 ? 0 : --prevCommandsIter];
				command.SelectionStart = command.TextLength;
			}
			else if (e.KeyCode == Keys.Down)
			{
				if (prevCommands.Count == 0)
					return;
				command.Text = prevCommandsIter >= prevCommands.Count - 1 ? "" : prevCommands[++prevCommandsIter];
				command.SelectionStart = command.TextLength;
			}
		}

		private void button_submit_Click(object sender, EventArgs e)
		{
			submitCommand(textbox_command);
		}

		private void submitCommand(TextBox me)
		{
			// add user input to records
			if (me.Text != "")
			{
				prevCommands.Add(me.Text);
				prevCommandsIter = prevCommands.Count;
			}
			// print user input after notation character
			richTextBox_message.AppendText(me.Text + "\r\n");

			if (me.Text == "clear") // special defined commands
			{
				richTextBox_message.Text = "";
			}
			else // execute lua script
			{
				try
				{
					script.DoString(me.Text);
				}
				catch (Exception err)
				{
					printMessage("Error: " + err.Message + "\r\n\r\n", Color.Red);
				}
			}
			// insert next notation character after execution regardless of success or not
			richTextBox_message.AppendText("> ");
			// clear user input
			me.Text = "";
		}

		public void printMessage(string message)
		{
			richTextBox_message.AppendText("\r\n" + message);
			// scroll richTextBox_message to bottom
			richTextBox_message.ScrollToCaret();
		}

		public void printMessage(string message, Color color)
		{
			// print message in designate color
			Color temp = richTextBox_message.ForeColor;
			richTextBox_message.SelectionColor = color;
			richTextBox_message.AppendText("\r\n" + message);
			richTextBox_message.SelectionColor = temp;
			richTextBox_message.ScrollToCaret();
		}
	}
}

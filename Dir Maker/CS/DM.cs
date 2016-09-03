using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Dir_Maker
{
	public partial class DM : System.Windows.Forms.Form, IMessageFilter
	{
		public DM()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
		#region Default Instance
		
		private static DM defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static DM Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new DM();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
		#endregion
		const int WM_DROPFILES = 0x233;
		[DllImport("shell32.dll")]public static  extern void DragFinish(int hDrop);
		[DllImport("shell32.dll")]public static  extern void DragAcceptFiles(int hwnd, bool fAccept);
		[DllImport("shell32.dll")]public static  extern int DragQueryFile(int HDROP, int UINT, System.Text.StringBuilder lpStr, int ch);
		ListBox listbox1;
		public bool PreFilterMessage(ref Message m)
		{
			if (m.Msg == WM_DROPFILES)
			{
				short nfiles;
				nfiles =  (@) (DragQueryFile(m.WParam.ToInt32(), - 1, null, 0)));
				short i;
				System.Text.StringBuilder sb = new System.Text.StringBuilder(256);
				string sFirstFileName;
				int bbint = 0;
				for (i = 0; i <= nfiles - 1; i++)
				{
					DragQueryFile(m.WParam.ToInt32(), i, sb, 256);
					if (i == 0)
					{
						sFirstFileName = sb.ToString();
					}
					if ((new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DirectoryExists(sb.ToString()) == true)
					{
						TextBox1.Text = sb.ToString();
						TextBox2.Text = "";
						fol(TextBox2);
						run(sb.ToString(), TextBox2.Text);
					}
				}
				DragFinish(m.WParam.ToInt32());
			}
			return false;
		}
		private void DM_Load(System.Object sender, System.EventArgs e)
		{
			//On Error Resume Next VBConversions Warning: On Error Resume Next not supported in C#
			if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).CommandLineArgs.Count != 0)
			{
				if ((new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DirectoryExists((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).CommandLineArgs.Item[0].Trim()) == true)
				{
					TextBox1.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).CommandLineArgs.Item[0].Trim();
				}
				else
				{
					TextBox1.Text = "";
				}
				if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).CommandLineArgs.Item[0].Trim() == "/")
				{
					Interaction.MsgBox("命令行：[DirMaker] [参照路径] [目标路径] [0/1]" + "\r\n" + "\r\n" + "[0/1]表示是否只是目录根下,0不是,1是", MsgBoxStyle.Information, "Dir Maker命令行！！！");
				}
				if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).CommandLineArgs.Count == 3)
				{
					if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).CommandLineArgs.Item[2].Trim().ToLower() == "1")
					{
						CheckBox1.Checked = true;
					}
					else
					{
						CheckBox1.Checked = false;
					}
				}
				else
				{
					CheckBox1.Checked = false;
				}
				TextBox2.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).CommandLineArgs.Item[1].Trim();
				if ((new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DirectoryExists(TextBox2.Text) == false)
				{
					//On Error Goto w VBConversions Warning: On Error Goto not supported in C#
					FileSystem.MkDir(TextBox2.Text);
				}
				if (TextBox1.Text != "" && TextBox2.Text != "")
				{
					run(TextBox1.Text, TextBox2.Text);
					ProjectData.EndApp();
				}
			}
			Application.AddMessageFilter(this);
			DragAcceptFiles(TextBox1.Handle.ToInt32(), true);
			return;
w:
			ProjectData.EndApp();
		}
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			fol(TextBox1);
		}
		public object fol(TextBox txt)
		{
			//On Error Resume Next VBConversions Warning: On Error Resume Next not supported in C#
			FolderBrowserDialog1.SelectedPath = "";
			FolderBrowserDialog1.ShowDialog();
			if (FolderBrowserDialog1.SelectedPath != "")
			{
				txt.Text = FolderBrowserDialog1.SelectedPath;
			}
			return null;
		}
		public object run(string path, string chu)
		{
			if (TextBox1.Text != "" && TextBox2.Text != "" && (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DirectoryExists(TextBox1.Text) == true && (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DirectoryExists(TextBox2.Text) == true)
			{
				var k;
				if (CheckBox1.Checked == true)
				{
					k = (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.GetDirectories(path, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, null);
				}
				else
				{
					k = (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.GetDirectories(path, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, null);
				}
				for (var d = 0; d <= k.count - 1; d++)
				{
					//On Error Resume Next VBConversions Warning: On Error Resume Next not supported in C#
					FileSystem.MkDir(k(d).ToString().Replace(path, chu + "\\"));
				}
			}
		}
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			fol(TextBox2);
		}
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text != "" && TextBox2.Text != "" && (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DirectoryExists(TextBox1.Text) == true && (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DirectoryExists(TextBox2.Text) == true)
			{
				run(TextBox1.Text, TextBox2.Text);
				Interaction.MsgBox("成功！！！", MsgBoxStyle.Information, "温馨提示！！！");
				Interaction.Shell("explorer " + TextBox2.Text, 1, 0, -1);
			}
			else
			{
				Interaction.MsgBox("请确定参照路径和目标路径的正确！！！", MsgBoxStyle.Information, "温馨提示！！！");
			}
		}
		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			ProjectData.EndApp();
		}
		private void TextBox1_DoubleClick(object sender, System.EventArgs e)
		{
			fol(TextBox1);
		}
		private void TextBox2_DoubleClick(object sender, System.EventArgs e)
		{
			fol(TextBox2);
		}
	}
}

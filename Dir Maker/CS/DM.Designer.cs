using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace Dir_Maker
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class DM : System.Windows.Forms.Form
	{
		//Form 重写 Dispose，以清理组件列表。
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && (components != null))
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DM));
			this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			base.Load += new System.EventHandler(DM_Load);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(Button2_Click);
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox1.DoubleClick += new System.EventHandler(TextBox1_DoubleClick);
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox2.DoubleClick += new System.EventHandler(TextBox2_DoubleClick);
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(Button3_Click);
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(Button4_Click);
			this.SuspendLayout();
			//
			//FolderBrowserDialog1
			//
			this.FolderBrowserDialog1.Description = "请选择文件夹:";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(290, 10);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "参照";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(290, 39);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "目标";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(12, 12);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(272, 21);
			this.TextBox1.TabIndex = 2;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(12, 39);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(272, 21);
			this.TextBox2.TabIndex = 3;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(290, 68);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 23);
			this.Button3.TabIndex = 4;
			this.Button3.Text = "创建";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//CheckBox1
			//
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new System.Drawing.Point(212, 72);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(72, 16);
			this.CheckBox1.TabIndex = 5;
			this.CheckBox1.Text = "目录根下";
			this.CheckBox1.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(12, 68);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(75, 23);
			this.Button4.TabIndex = 6;
			this.Button4.Text = "退出";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//DM
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0, 12.0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 99);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "文件夹系统建立器";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.Button Button4;
	}
}

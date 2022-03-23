using CryptoNite_Faucet_Collector.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CryptoNite_Faucet_Collector
{
	[DesignerGenerated]
	public class Form4 : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form4 form4 = this;
				EventHandler eventHandler = new EventHandler(form4.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= eventHandler;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form4 form4 = this;
				EventHandler eventHandler = new EventHandler(form4.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= eventHandler;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += eventHandler;
				}
			}
		}

		internal virtual CheckBox CheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form4 form4 = this;
				EventHandler eventHandler = new EventHandler(form4.CheckBox17_CheckedChanged);
				if (this._CheckBox1 != null)
				{
					this._CheckBox1.CheckedChanged -= eventHandler;
				}
				this._CheckBox1 = value;
				if (this._CheckBox1 != null)
				{
					this._CheckBox1.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		internal virtual TextBox TextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		[DebuggerNonUserCode]
		static Form4()
		{
			Form4.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public Form4()
		{
			Form4 form4 = this;
			base.Load += new EventHandler(form4.Form4_Load);
			Form4.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (Form4.__ENCList)
			{
				if (Form4.__ENCList.Count == Form4.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(Form4.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (Form4.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								Form4.__ENCList[item] = Form4.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					Form4.__ENCList.RemoveRange(item, checked(Form4.__ENCList.Count - item));
					Form4.__ENCList.Capacity = Form4.__ENCList.Count;
				}
				Form4.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Form5.Show();
			this.Hide();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Form6.Show();
		}

		private void CheckBox17_CheckedChanged(object sender, EventArgs e)
		{
			if (this.CheckBox1.Checked)
			{
				this.TextBox2.Text = Conversions.ToString(0.0163);
			}
			else if (!this.CheckBox1.Checked)
			{
				this.TextBox2.Text = Conversions.ToString(0);
			}
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if ((!disposing || this.components == null ? false : true))
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		private void Form4_Load(object sender, EventArgs e)
		{
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form4));
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.Label3 = new Label();
			this.GroupBox1 = new GroupBox();
			this.CheckBox1 = new CheckBox();
			this.TextBox2 = new TextBox();
			this.Label7 = new Label();
			this.Label6 = new Label();
			this.Label5 = new Label();
			this.Button1 = new Button();
			this.TextBox1 = new TextBox();
			this.Label4 = new Label();
			this.Button2 = new Button();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			Point point = new Point(12, 8);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(66, 16);
			label.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "License:";
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label2.ForeColor = Color.Red;
			Label label2 = this.Label2;
			point = new Point(73, 9);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(40, 16);
			label21.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Free";
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(113, 11);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(150, 13);
			label31.Size = size;
			this.Label3.TabIndex = 2;
			this.Label3.Text = "(need withdraw fee to be paid)";
			this.GroupBox1.Controls.Add(this.CheckBox1);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			GroupBox groupBox1 = this.GroupBox1;
			point = new Point(12, 28);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = this.GroupBox1;
			size = new System.Drawing.Size(431, 158);
			groupBox.Size = size;
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Withdraw details";
			this.CheckBox1.AutoSize = true;
			CheckBox checkBox1 = this.CheckBox1;
			point = new Point(122, 89);
			checkBox1.Location = point;
			this.CheckBox1.Name = "CheckBox1";
			CheckBox checkBox = this.CheckBox1;
			size = new System.Drawing.Size(91, 20);
			checkBox.Size = size;
			this.CheckBox1.TabIndex = 7;
			this.CheckBox1.Text = "Maximum";
			this.CheckBox1.UseVisualStyleBackColor = true;
			TextBox textBox2 = this.TextBox2;
			point = new Point(6, 89);
			textBox2.Location = point;
			this.TextBox2.Name = "TextBox2";
			TextBox textBox = this.TextBox2;
			size = new System.Drawing.Size(110, 22);
			textBox.Size = size;
			this.TextBox2.TabIndex = 6;
			this.TextBox2.Text = "0";
			this.Label7.AutoSize = true;
			Label label7 = this.Label7;
			point = new Point(9, 70);
			label7.Location = point;
			this.Label7.Name = "Label7";
			Label label71 = this.Label7;
			size = new System.Drawing.Size(63, 16);
			label71.Size = size;
			this.Label7.TabIndex = 5;
			this.Label7.Text = "Amount:";
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = Color.FromArgb(255, 128, 0);
			Label label6 = this.Label6;
			point = new Point(119, 130);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(86, 16);
			label61.Size = size;
			this.Label6.TabIndex = 4;
			this.Label6.Text = "0.0163 BTC";
			this.Label5.AutoSize = true;
			Label label5 = this.Label5;
			point = new Point(9, 129);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(107, 16);
			label51.Size = size;
			this.Label5.TabIndex = 3;
			this.Label5.Text = "BTC Ballance:";
			Button button1 = this.Button1;
			point = new Point(304, 45);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new System.Drawing.Size(121, 22);
			button.Size = size;
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Withdraw";
			this.Button1.UseVisualStyleBackColor = true;
			TextBox textBox1 = this.TextBox1;
			point = new Point(6, 45);
			textBox1.Location = point;
			this.TextBox1.Name = "TextBox1";
			TextBox textBox11 = this.TextBox1;
			size = new System.Drawing.Size(292, 22);
			textBox11.Size = size;
			this.TextBox1.TabIndex = 1;
			this.TextBox1.TextAlign = HorizontalAlignment.Center;
			this.Label4.AutoSize = true;
			Label label4 = this.Label4;
			point = new Point(9, 25);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(237, 16);
			label41.Size = size;
			this.Label4.TabIndex = 0;
			this.Label4.Text = "Enter your bitcoin wallet address:";
			Button button2 = this.Button2;
			point = new Point(316, 9);
			button2.Location = point;
			this.Button2.Name = "Button2";
			Button button21 = this.Button2;
			size = new System.Drawing.Size(121, 22);
			button21.Size = size;
			this.Button2.TabIndex = 4;
			this.Button2.Text = "Buy Premium License";
			this.Button2.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.White;
			size = new System.Drawing.Size(455, 197);
			this.ClientSize = size;
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form4";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Withdraw";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
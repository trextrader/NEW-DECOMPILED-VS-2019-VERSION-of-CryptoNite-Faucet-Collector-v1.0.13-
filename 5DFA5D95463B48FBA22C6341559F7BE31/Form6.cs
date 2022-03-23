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
	public class Form6 : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

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
				this._Button1 = value;
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
				this._Button2 = value;
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

		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
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

		internal virtual TextBox TextBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox3 = value;
			}
		}

		[DebuggerNonUserCode]
		static Form6()
		{
			Form6.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public Form6()
		{
			Form6.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (Form6.__ENCList)
			{
				if (Form6.__ENCList.Count == Form6.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(Form6.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (Form6.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								Form6.__ENCList[item] = Form6.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					Form6.__ENCList.RemoveRange(item, checked(Form6.__ENCList.Count - item));
					Form6.__ENCList.Capacity = Form6.__ENCList.Count;
				}
				Form6.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form6));
			this.GroupBox1 = new GroupBox();
			this.Button1 = new Button();
			this.TextBox1 = new TextBox();
			this.Label8 = new Label();
			this.PictureBox1 = new PictureBox();
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.Label3 = new Label();
			this.TextBox2 = new TextBox();
			this.Label4 = new Label();
			this.TextBox3 = new TextBox();
			this.Button2 = new Button();
			this.GroupBox1.SuspendLayout();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.PictureBox1);
			GroupBox groupBox1 = this.GroupBox1;
			Point point = new Point(12, 40);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = this.GroupBox1;
			System.Drawing.Size size = new System.Drawing.Size(570, 208);
			groupBox.Size = size;
			this.GroupBox1.TabIndex = 4;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Buy premium license";
			Button button1 = this.Button1;
			point = new Point(281, 135);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new System.Drawing.Size(171, 50);
			button.Size = size;
			this.Button1.TabIndex = 3;
			this.Button1.Text = "Send me license";
			this.Button1.UseVisualStyleBackColor = true;
			TextBox textBox1 = this.TextBox1;
			point = new Point(185, 60);
			textBox1.Location = point;
			this.TextBox1.Name = "TextBox1";
			TextBox textBox = this.TextBox1;
			size = new System.Drawing.Size(368, 20);
			textBox.Size = size;
			this.TextBox1.TabIndex = 2;
			this.TextBox1.Text = "1CCkEpNoqAY6mWZtV9VTq6BbxF1fqdJhWe";
			this.TextBox1.TextAlign = HorizontalAlignment.Center;
			this.Label8.AutoSize = true;
			Label label8 = this.Label8;
			point = new Point(182, 31);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label = this.Label8;
			size = new System.Drawing.Size(356, 26);
			label.Size = size;
			this.Label8.TabIndex = 1;
			this.Label8.Text = "Send 0.01 BTC to this BTC address,enter your email address and click on \r\n\"Send me license\" button to get your license at your email address.";
			this.PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(16, 31);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new System.Drawing.Size(160, 160);
			pictureBox.Size = size;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(9, 9);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new System.Drawing.Size(112, 16);
			label11.Size = size;
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Premium Price:";
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label2.ForeColor = Color.FromArgb(255, 128, 0);
			Label label2 = this.Label2;
			point = new Point(121, 9);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(70, 16);
			label21.Size = size;
			this.Label2.TabIndex = 6;
			this.Label2.Text = "0.01 BTC";
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(182, 95);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(35, 13);
			label31.Size = size;
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Email:";
			TextBox textBox2 = this.TextBox2;
			point = new Point(223, 92);
			textBox2.Location = point;
			this.TextBox2.Name = "TextBox2";
			TextBox textBox21 = this.TextBox2;
			size = new System.Drawing.Size(330, 20);
			textBox21.Size = size;
			this.TextBox2.TabIndex = 5;
			this.TextBox2.TextAlign = HorizontalAlignment.Center;
			this.Label4.AutoSize = true;
			Label label4 = this.Label4;
			point = new Point(9, 266);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(118, 13);
			label41.Size = size;
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Enter your license here:";
			TextBox textBox3 = this.TextBox3;
			point = new Point(12, 282);
			textBox3.Location = point;
			this.TextBox3.Name = "TextBox3";
			TextBox textBox31 = this.TextBox3;
			size = new System.Drawing.Size(423, 20);
			textBox31.Size = size;
			this.TextBox3.TabIndex = 8;
			Button button2 = this.Button2;
			point = new Point(458, 282);
			button2.Location = point;
			this.Button2.Name = "Button2";
			Button button21 = this.Button2;
			size = new System.Drawing.Size(124, 20);
			button21.Size = size;
			this.Button2.TabIndex = 9;
			this.Button2.Text = "Verify";
			this.Button2.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.White;
			size = new System.Drawing.Size(595, 315);
			this.ClientSize = size;
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.GroupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form6";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Buy Premium";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
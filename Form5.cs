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
	public class Form5 : Form
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

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

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

		[DebuggerNonUserCode]
		static Form5()
		{
			Form5.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public Form5()
		{
			Form5.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (Form5.__ENCList)
			{
				if (Form5.__ENCList.Count == Form5.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(Form5.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (Form5.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								Form5.__ENCList[item] = Form5.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					Form5.__ENCList.RemoveRange(item, checked(Form5.__ENCList.Count - item));
					Form5.__ENCList.Capacity = Form5.__ENCList.Count;
				}
				Form5.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form5));
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.Label3 = new Label();
			this.GroupBox1 = new GroupBox();
			this.Label4 = new Label();
			this.Label5 = new Label();
			this.Label6 = new Label();
			this.Label7 = new Label();
			this.PictureBox1 = new PictureBox();
			this.Label8 = new Label();
			this.TextBox1 = new TextBox();
			this.Button1 = new Button();
			this.GroupBox1.SuspendLayout();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			Point point = new Point(101, 9);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(392, 16);
			label.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "All bitcoin tranzactions need a fee to be confirmed by the network.";
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(80, 25);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(434, 16);
			label21.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "The withdraw fee can't be deducted from your amount with a free license.";
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(29, 41);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(536, 16);
			label31.Size = size;
			this.Label3.TabIndex = 2;
			this.Label3.Text = "You need a premium license if you don't want to pay the fee any time you want to withdraw.";
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.PictureBox1);
			GroupBox groupBox1 = this.GroupBox1;
			point = new Point(12, 123);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = this.GroupBox1;
			size = new System.Drawing.Size(570, 208);
			groupBox.Size = size;
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Withdraw details";
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label4 = this.Label4;
			point = new Point(25, 76);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(124, 16);
			label41.Size = size;
			this.Label4.TabIndex = 4;
			this.Label4.Text = "Fee for withdraw:";
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label5.ForeColor = Color.FromArgb(255, 128, 0);
			Label label5 = this.Label5;
			point = new Point(147, 76);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(86, 16);
			label51.Size = size;
			this.Label5.TabIndex = 5;
			this.Label5.Text = "0.0016 BTC";
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label6 = this.Label6;
			point = new Point(25, 94);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(91, 16);
			label61.Size = size;
			this.Label6.TabIndex = 6;
			this.Label6.Text = "You will get:";
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label7.ForeColor = Color.FromArgb(255, 128, 0);
			Label label7 = this.Label7;
			point = new Point(116, 94);
			label7.Location = point;
			this.Label7.Name = "Label7";
			Label label71 = this.Label7;
			size = new System.Drawing.Size(86, 16);
			label71.Size = size;
			this.Label7.TabIndex = 7;
			this.Label7.Text = "0.0163 BTC";
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
			this.Label8.AutoSize = true;
			Label label8 = this.Label8;
			point = new Point(182, 31);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label81 = this.Label8;
			size = new System.Drawing.Size(323, 48);
			label81.Size = size;
			this.Label8.TabIndex = 1;
			this.Label8.Text = "Send the fee to this BTC address and click on \r\n\"I sent the fee\" button to finish your withdraw process\r\nand then refresh your wallet to see your new ballance.";
			TextBox textBox1 = this.TextBox1;
			point = new Point(185, 92);
			textBox1.Location = point;
			this.TextBox1.Name = "TextBox1";
			TextBox textBox = this.TextBox1;
			size = new System.Drawing.Size(368, 22);
			textBox.Size = size;
			this.TextBox1.TabIndex = 2;
			this.TextBox1.Text = "1CCkEpNoqAY6mWZtV9VTq6BbxF1fqdJhWe";
			this.TextBox1.TextAlign = HorizontalAlignment.Center;
			Button button1 = this.Button1;
			point = new Point(281, 135);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new System.Drawing.Size(171, 50);
			button.Size = size;
			this.Button1.TabIndex = 3;
			this.Button1.Text = "I sent the fee";
			this.Button1.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new SizeF(8f, 16f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.White;
			size = new System.Drawing.Size(594, 343);
			this.ClientSize = size;
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form5";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Withdraw";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
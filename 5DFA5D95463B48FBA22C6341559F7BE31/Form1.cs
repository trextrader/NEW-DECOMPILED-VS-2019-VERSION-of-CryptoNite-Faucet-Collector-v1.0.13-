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
	public class Form1 : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Button4")]
		private Button _Button4;

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
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button1_Click);
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
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button2_Click);
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

		internal virtual Button Button3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button3_Click);
				if (this._Button3 != null)
				{
					this._Button3.Click -= eventHandler;
				}
				this._Button3 = value;
				if (this._Button3 != null)
				{
					this._Button3.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button4_Click);
				if (this._Button4 != null)
				{
					this._Button4.Click -= eventHandler;
				}
				this._Button4 = value;
				if (this._Button4 != null)
				{
					this._Button4.Click += eventHandler;
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

		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
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

		internal virtual ProgressBar ProgressBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ProgressBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar1 = value;
			}
		}

		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Timer1_Tick);
				if (this._Timer1 != null)
				{
					this._Timer1.Tick -= eventHandler;
				}
				this._Timer1 = value;
				if (this._Timer1 != null)
				{
					this._Timer1.Tick += eventHandler;
				}
			}
		}

		[DebuggerNonUserCode]
		static Form1()
		{
			Form1.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public Form1()
		{
			Form1.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (Form1.__ENCList)
			{
				if (Form1.__ENCList.Count == Form1.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(Form1.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (Form1.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								Form1.__ENCList[item] = Form1.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					Form1.__ENCList.RemoveRange(item, checked(Form1.__ENCList.Count - item));
					Form1.__ENCList.Capacity = Form1.__ENCList.Count;
				}
				Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Timer1.Start();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Form2.Show();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			this.ProgressBar1.Value = this.ProgressBar1.Minimum;
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Form4.Show();
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
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.Label1 = new Label();
			this.Button1 = new Button();
			this.Button2 = new Button();
			this.GroupBox1 = new GroupBox();
			this.Label9 = new Label();
			this.Button3 = new Button();
			this.Label8 = new Label();
			this.Label7 = new Label();
			this.Label6 = new Label();
			this.Label5 = new Label();
			this.Label4 = new Label();
			this.Label3 = new Label();
			this.Label2 = new Label();
			this.ProgressBar1 = new ProgressBar();
			this.Timer1 = new Timer(this.components);
			this.PictureBox1 = new PictureBox();
			this.Button4 = new Button();
			this.GroupBox1.SuspendLayout();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Impact", 21.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label1.ForeColor = Color.MediumSeaGreen;
			Label label1 = this.Label1;
			Point point = new Point(434, 9);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(210, 36);
			label.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Faucet Collector";
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Button1.ForeColor = Color.FromArgb(0, 192, 0);
			Button button1 = this.Button1;
			point = new Point(339, 182);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new System.Drawing.Size(149, 45);
			button.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Start";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button button2 = this.Button2;
			point = new Point(3, 104);
			button2.Location = point;
			this.Button2.Name = "Button2";
			Button button21 = this.Button2;
			size = new System.Drawing.Size(149, 45);
			button21.Size = size;
			this.Button2.TabIndex = 2;
			this.Button2.Text = "Settings";
			this.Button2.UseVisualStyleBackColor = true;
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.Button3);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox groupBox1 = this.GroupBox1;
			point = new Point(12, 12);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = this.GroupBox1;
			size = new System.Drawing.Size(304, 164);
			groupBox.Size = size;
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Status";
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = Color.Green;
			Label label9 = this.Label9;
			point = new Point(170, 55);
			label9.Location = point;
			this.Label9.Name = "Label9";
			Label label91 = this.Label9;
			size = new System.Drawing.Size(103, 16);
			label91.Size = size;
			this.Label9.TabIndex = 9;
			this.Label9.Text = "Decap Enabled";
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Button button3 = this.Button3;
			point = new Point(152, 104);
			button3.Location = point;
			this.Button3.Name = "Button3";
			Button button31 = this.Button3;
			size = new System.Drawing.Size(149, 45);
			button31.Size = size;
			this.Button3.TabIndex = 6;
			this.Button3.Text = "Reset";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = Color.Green;
			Label label8 = this.Label8;
			point = new Point(170, 29);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label81 = this.Label8;
			size = new System.Drawing.Size(128, 16);
			label81.Size = size;
			this.Label8.TabIndex = 8;
			this.Label8.Text = "Decaptcha Enabled";
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = Color.Green;
			Label label7 = this.Label7;
			point = new Point(123, 80);
			label7.Location = point;
			this.Label7.Name = "Label7";
			Label label71 = this.Label7;
			size = new System.Drawing.Size(46, 16);
			label71.Size = size;
			this.Label7.TabIndex = 7;
			this.Label7.Text = "Online";
			this.Label6.AutoSize = true;
			Label label6 = this.Label6;
			point = new Point(7, 80);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(121, 16);
			label61.Size = size;
			this.Label6.TabIndex = 6;
			this.Label6.Text = "Faucet Bot Server: ";
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label5 = this.Label5;
			point = new Point(109, 55);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(48, 16);
			label51.Size = size;
			this.Label5.TabIndex = 3;
			this.Label5.Text = "11389";
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label4 = this.Label4;
			point = new Point(108, 29);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(48, 16);
			label41.Size = size;
			this.Label4.TabIndex = 2;
			this.Label4.Text = "11389";
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(7, 55);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(93, 16);
			label31.Size = size;
			this.Label3.TabIndex = 1;
			this.Label3.Text = "Faucets to-do:";
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(7, 29);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(105, 16);
			label21.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "Faucets loaded:";
			ProgressBar progressBar1 = this.ProgressBar1;
			point = new Point(339, 60);
			progressBar1.Location = point;
			this.ProgressBar1.Maximum = 10000;
			this.ProgressBar1.Name = "ProgressBar1";
			ProgressBar progressBar = this.ProgressBar1;
			size = new System.Drawing.Size(305, 116);
			progressBar.Size = size;
			this.ProgressBar1.TabIndex = 4;
			this.PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(-4, 196);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new System.Drawing.Size(201, 50);
			pictureBox.Size = size;
			this.PictureBox1.TabIndex = 7;
			this.PictureBox1.TabStop = false;
			this.Button4.Enabled = false;
			this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Button4.ForeColor = Color.Blue;
			Button button4 = this.Button4;
			point = new Point(495, 182);
			button4.Location = point;
			this.Button4.Name = "Button4";
			Button button41 = this.Button4;
			size = new System.Drawing.Size(149, 44);
			button41.Size = size;
			this.Button4.TabIndex = 8;
			this.Button4.Text = "Withdraw";
			this.Button4.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.White;
			size = new System.Drawing.Size(656, 238);
			this.ClientSize = size;
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "CryptoNite Faucet Collector   v1.0.13";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.ProgressBar1.Increment(1);
			if (this.ProgressBar1.Value == 10000)
			{
				this.Timer1.Stop();
				MyProject.Forms.Form3.Show();
				this.Button4.Enabled = true;
			}
		}
	}
}
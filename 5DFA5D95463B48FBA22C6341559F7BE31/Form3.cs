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
	public class Form3 : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

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
				Form3 form3 = this;
				EventHandler eventHandler = new EventHandler(form3.Button1_Click);
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

		[DebuggerNonUserCode]
		static Form3()
		{
			Form3.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public Form3()
		{
			Form3.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (Form3.__ENCList)
			{
				if (Form3.__ENCList.Count == Form3.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(Form3.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (Form3.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								Form3.__ENCList[item] = Form3.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					Form3.__ENCList.RemoveRange(item, checked(Form3.__ENCList.Count - item));
					Form3.__ENCList.Capacity = Form3.__ENCList.Count;
				}
				Form3.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.Button1 = new Button();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label1.ForeColor = Color.Green;
			Label label1 = this.Label1;
			Point point = new Point(128, 9);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(111, 24);
			label.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "SUCCESS!";
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label2 = this.Label2;
			point = new Point(46, 33);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(275, 20);
			label21.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "All faucets are collected with success!";
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Button button1 = this.Button1;
			point = new Point(116, 66);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new System.Drawing.Size(135, 23);
			button.Size = size;
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Ok";
			this.Button1.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.White;
			size = new System.Drawing.Size(366, 111);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form3";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Success";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
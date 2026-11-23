using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualStyles
{
	public class VIForm : Form
	{
		public VIForm()
		{
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
			this.ForeColor = System.Drawing.Color.White;

			//this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			//this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
			////this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
			//this.ForeColor = System.Drawing.Color.White;
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// VIForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "VIForm";
			this.ResumeLayout(false);

		}
	}
}

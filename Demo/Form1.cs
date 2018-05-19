// Form1.cs
// 
// Copyright (c) 2007-2010, OpenPainter.org
// 
// The contents of this file are subject to the Mozilla Public License
// Version 1.1 (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
// 
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS"
// basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See
// the License for the specific language governing rights and limitations
// under the License.
// 
// The Original Code is OpenPainter.
// 
// The Initial Developer of the Original Code is OpenPainter.org.
// All Rights Reserved.

using System;
using System.Windows.Forms;

namespace PsColorPicker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnChoose_Click(object sender, EventArgs e)
		{
			this.SelectColor();
		}

		private void PnlColor_MouseClick(object sender, MouseEventArgs e)
		{
			this.SelectColor();
		}

		private void SelectColor()
		{
			var frm = new OpenPainter.ColorPicker.PsColorPicker(this.PnlColor.BackColor);

			if (frm.ShowDialog() == DialogResult.OK)
				this.PnlColor.BackColor = frm.Color;
		}
	}
}

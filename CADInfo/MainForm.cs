﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CADInfo.Elements;

namespace CADInfo
{
	public partial class MainForm : Form
	{
		public MainForm ( )
		{
			InitializeComponent( );

			CaesarCypherPage.Controls.Add( new CaesarCrypt( ) );
			MorzeCodePage.Controls.Add( new CodeMorze( ) );
		}

		private void MainForm_Shown ( object sender, EventArgs e )
		{
			tabControl.SelectedIndex = 0;

			foreach ( TabPage page in tabControl.TabPages )
			{
				contentDataGrid.Rows.Add( page.Text );
			}

			contentDataGrid.Rows.Add( "О программе" );
		}

		private void ContentDataGrid_CellClick ( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.RowIndex < tabControl.TabPages.Count )
			{
				tabControl.SelectedIndex = e.RowIndex;
			}
			else
			{
				new AboutForm( ).ShowDialog( );
			}
		}
	}
}

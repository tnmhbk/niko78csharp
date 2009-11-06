using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace MySQLHelloWorld
{
	/// <summary>
	/// Main form of application
	/// </summary>
	public class FormMain : System.Windows.Forms.Form
	{
		#region "Automatic Private fields"

		private System.Windows.Forms.GroupBox gbxConnection;
		private System.Windows.Forms.Button Connect;
		private System.Windows.Forms.TextBox texUserName;
		private System.Windows.Forms.TextBox texPassword;
		private System.Windows.Forms.TextBox texHost;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblHost;
		private System.Windows.Forms.GroupBox gbxDatabases;
		private System.Windows.Forms.ComboBox cbxDataBases;
		private System.Data.DataSet dstDataBases;
		private System.Data.DataTable Tabla_DataBase;
		private System.Data.DataColumn colDatabase;


		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#endregion

		#region "Constructor and Destructor"

		/// <summary>
		/// Constructor
		/// </summary>
		public FormMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbxConnection = new System.Windows.Forms.GroupBox();
			this.Connect = new System.Windows.Forms.Button();
			this.texUserName = new System.Windows.Forms.TextBox();
			this.texPassword = new System.Windows.Forms.TextBox();
			this.texHost = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblHost = new System.Windows.Forms.Label();
			this.gbxDatabases = new System.Windows.Forms.GroupBox();
			this.cbxDataBases = new System.Windows.Forms.ComboBox();
			this.dstDataBases = new System.Data.DataSet();
			this.Tabla_DataBase = new System.Data.DataTable();
			this.colDatabase = new System.Data.DataColumn();
			this.gbxConnection.SuspendLayout();
			this.gbxDatabases.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dstDataBases)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Tabla_DataBase)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxConnection
			// 
			this.gbxConnection.Controls.Add(this.lblHost);
			this.gbxConnection.Controls.Add(this.lblPassword);
			this.gbxConnection.Controls.Add(this.lblUserName);
			this.gbxConnection.Controls.Add(this.texHost);
			this.gbxConnection.Controls.Add(this.texPassword);
			this.gbxConnection.Controls.Add(this.texUserName);
			this.gbxConnection.Controls.Add(this.Connect);
			this.gbxConnection.Location = new System.Drawing.Point(8, 8);
			this.gbxConnection.Name = "gbxConnection";
			this.gbxConnection.Size = new System.Drawing.Size(208, 160);
			this.gbxConnection.TabIndex = 0;
			this.gbxConnection.TabStop = false;
			this.gbxConnection.Text = "Connection Info ";
			// 
			// Connect
			// 
			this.Connect.BackColor = System.Drawing.Color.Silver;
			this.Connect.Location = new System.Drawing.Point(56, 120);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(96, 24);
			this.Connect.TabIndex = 0;
			this.Connect.Text = "Connect";
			this.Connect.Click += new System.EventHandler(this.Connect_Click);
			// 
			// texUserName
			// 
			this.texUserName.Location = new System.Drawing.Point(88, 24);
			this.texUserName.Name = "texUserName";
			this.texUserName.TabIndex = 1;
			this.texUserName.Text = "root";
			// 
			// texPassword
			// 
			this.texPassword.Location = new System.Drawing.Point(88, 56);
			this.texPassword.Name = "texPassword";
			this.texPassword.PasswordChar = '*';
			this.texPassword.TabIndex = 2;
			this.texPassword.Text = "";
			// 
			// texHost
			// 
			this.texHost.Location = new System.Drawing.Point(88, 88);
			this.texHost.Name = "texHost";
			this.texHost.TabIndex = 3;
			this.texHost.Text = "localhost";
			// 
			// lblUserName
			// 
			this.lblUserName.Location = new System.Drawing.Point(16, 26);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(32, 16);
			this.lblUserName.TabIndex = 4;
			this.lblUserName.Text = "User";
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(16, 58);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 16);
			this.lblPassword.TabIndex = 5;
			this.lblPassword.Text = "Password";
			// 
			// lblHost
			// 
			this.lblHost.Location = new System.Drawing.Point(16, 90);
			this.lblHost.Name = "lblHost";
			this.lblHost.Size = new System.Drawing.Size(56, 16);
			this.lblHost.TabIndex = 6;
			this.lblHost.Text = "Host";
			// 
			// gbxDatabases
			// 
			this.gbxDatabases.Controls.Add(this.cbxDataBases);
			this.gbxDatabases.Location = new System.Drawing.Point(224, 8);
			this.gbxDatabases.Name = "gbxDatabases";
			this.gbxDatabases.Size = new System.Drawing.Size(184, 64);
			this.gbxDatabases.TabIndex = 1;
			this.gbxDatabases.TabStop = false;
			this.gbxDatabases.Text = "Data Bases";
			// 
			// cbxDataBases
			// 
			this.cbxDataBases.DataSource = this.dstDataBases;
			this.cbxDataBases.DisplayMember = "Table.Database";
			this.cbxDataBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDataBases.Location = new System.Drawing.Point(16, 24);
			this.cbxDataBases.Name = "cbxDataBases";
			this.cbxDataBases.Size = new System.Drawing.Size(144, 21);
			this.cbxDataBases.TabIndex = 0;
			// 
			// dstDataBases
			// 
			this.dstDataBases.DataSetName = "MySql";
			this.dstDataBases.Locale = new System.Globalization.CultureInfo("es-AR");
			this.dstDataBases.Tables.AddRange(new System.Data.DataTable[] {
																			  this.Tabla_DataBase});
			// 
			// Tabla_DataBase
			// 
			this.Tabla_DataBase.Columns.AddRange(new System.Data.DataColumn[] {
																				  this.colDatabase});
			this.Tabla_DataBase.TableName = "Table";
			// 
			// colDatabase
			// 
			this.colDatabase.ColumnMapping = System.Data.MappingType.Attribute;
			this.colDatabase.ColumnName = "Database";
			// 
			// FormMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(648, 376);
			this.Controls.Add(this.gbxDatabases);
			this.Controls.Add(this.gbxConnection);
			this.Name = "FormMain";
			this.Text = "niko78csharp - MySQL Hello World";
			this.gbxConnection.ResumeLayout(false);
			this.gbxDatabases.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dstDataBases)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Tabla_DataBase)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region "Entry point for Application"

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormMain());
		}

		#endregion

		#region "Private Methods"

		private void ProcessExcepction(string userMessaje, Exception exception)
		{
			MessageBox.Show(userMessaje+"\n"+exception.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

		private string GetConnectionString()
		{
			return String.Format("server={0};user id={1}; password={2}; database=mysql; pooling=false",
				texHost.Text, texUserName.Text, texPassword.Text );
		}

		#endregion

		#region "Form Events"

		private void Connect_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor=Cursors.WaitCursor;
				MySqlConnection connection= new MySqlConnection(GetConnectionString());
				connection.Open();
				try
				{
					MySqlDataAdapter dataAdapter= new MySqlDataAdapter("SHOW DATABASES",connection);
					dstDataBases.Tables[0].Rows.Clear();
					dataAdapter.Fill(dstDataBases);
					this.Cursor=Cursors.Default;
				}
				finally
				{
					connection.Close();
				}
				
				MessageBox.Show("Connection Success!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			catch(Exception er)
			{
				this.Cursor=Cursors.Default;
				ProcessExcepction("Can't connect to databse",er);
			}
		}

		#endregion
	}
}

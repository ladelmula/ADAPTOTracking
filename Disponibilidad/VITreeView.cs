using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursosExternos = VisualStyles.Properties.Resources;
using Disponibilidad.DataBase;

namespace Disponibilidad
{
	public partial class VITreeView : UserControl
	{
		Arbol dsArbol;
		
		public VITreeView()
		{
			try
			{
				InitializeComponent();
				this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
				//this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
				this.ForeColor = System.Drawing.Color.White;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView", ex);
			}
			
		}
		private string CrearTextoNodo(Arbol.NodosArbolRow nar)
		{
			try
			{
				string texto = $"{nar.Description} ";
				if (nar.Operation != "-")
				{
					texto += $"({nar.Operation}) ";
				}
				if (nar.Ponderation != 1)
					texto += $"{nar.Ponderation * 100}%";
				return texto;
			}
			catch (Exception ex)
			{

				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:CrearTextoNodo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:CrearTextoNodo", ex);
				return null;
			}
		}
		private TreeNode CrearNodo(Arbol.NodosArbolRow nar)
		{
			try
			{
				TreeNode n = new TreeNode();
				n.Text = CrearTextoNodo(nar);
				if (nar.Operation == "-")
				{
					if (DataBaseUtils.ComponentesEspeciales.Contains(nar.Description))
					{
						n.ImageIndex = 2; n.SelectedImageIndex = 2;
					}
					else
					{
						n.ImageIndex = 1; n.SelectedImageIndex = 1;
					}
				}
				
				n.Tag = nar.Id;
				return n;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:CrearNodo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:CrearNodo", ex);
				return null;
			}
		}
		
		private void CargarArbol()
		{
			try
			{
				Hashtable ht = new Hashtable();
				DataBaseUtils.CargarAlbol(ref dsArbol);
				dsArbol.NodosArbol.DefaultView.Sort = "IdParent";
				treeView1.Nodes.Clear();
				foreach (Arbol.NodosArbolRow nar in dsArbol.NodosArbol)
				{
					TreeNode n = CrearNodo(nar);
					if (nar.IdParent == -1)
					{
						treeView1.Nodes.Add(n);
					}
					else
					{
						TreeNode parent = (TreeNode)ht[nar.IdParent];
						parent.Nodes.Add(n);
					}
					ht.Add(nar.Id, n);

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:CargarArbol", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:CargarArbol", ex);
			}


		}
		public void LoadData(ref Arbol DSArbol)
		{
			try
			{
				this.dsArbol = DSArbol;
				CargarArbol();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:LoadData", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:LoadData", ex);
			}
		}
		

		private void cmdADD_Click(object sender, EventArgs e)
		{
			try
			{
				TreeNode parent = treeView1.SelectedNode;
				Arbol.NodosArbolRow nar = dsArbol.NodosArbol.NewNodosArbolRow();
				nar.IdParent = (int)parent.Tag;
				VITreeViewEdit tve = new VITreeViewEdit("Añadir hijo", ref nar);
				if (tve.ShowDialog() == DialogResult.OK)
				{
					dsArbol.NodosArbol.AddNodosArbolRow(nar);
					TreeNode n = CrearNodo(nar);
					parent.Nodes.Add(n);
					DataBaseUtils.GuardarArbol(dsArbol);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:cmdADD_Click", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:cmdADD_Click", ex);
			}
		}

		private void cmdCopy_Click(object sender, EventArgs e)
		{
			try
			{
				TreeNode parent = treeView1.SelectedNode.Parent;
				Arbol.NodosArbolRow nar = dsArbol.NodosArbol.FindById((int)treeView1.SelectedNode.Tag);
				Arbol.NodosArbolRow newNar = dsArbol.NodosArbol.NewNodosArbolRow();
				newNar.IdParent = nar.IdParent;
				newNar.Description = nar.Description;
				newNar.Operation = nar.Operation;
				newNar.Ponderation = nar.Ponderation;
				VITreeViewEdit tve = new VITreeViewEdit("Copiar nodo", ref newNar);
				if (tve.ShowDialog() == DialogResult.OK)
				{
					dsArbol.NodosArbol.AddNodosArbolRow(newNar);
					TreeNode n = CrearNodo(newNar);
					parent.Nodes.Add(n);
					DataBaseUtils.GuardarArbol(dsArbol);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:cmdCopy_Click", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:cmdCopy_Click", ex);
			}
		}

		private void cmdMOD_Click(object sender, EventArgs e)
		{
			try
			{
				TreeNode parent = treeView1.SelectedNode;
				Arbol.NodosArbolRow nar = dsArbol.NodosArbol.FindById((int)treeView1.SelectedNode.Tag);
				VITreeViewEdit tve = new VITreeViewEdit("Modificar nodo", ref nar);
				if (tve.ShowDialog() == DialogResult.OK)
				{
					parent.Text = CrearTextoNodo(nar);
					DataBaseUtils.GuardarArbol( dsArbol);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:cmdMOD_Click", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:cmdMOD_Click", ex);
			}
		}

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (treeView1.SelectedNode.Nodes.Count == 0)
				{
					if (MessageBox.Show($"Eliminando nodo {dsArbol.NodosArbol.FindById((int)treeView1.SelectedNode.Tag).Description} ¿Está seguro?", "Eliminar nodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						dsArbol.NodosArbol.FindById((int)treeView1.SelectedNode.Tag).Delete();
						TreeNode parent = treeView1.SelectedNode.Parent;
						parent.Nodes.Remove(treeView1.SelectedNode);
						DataBaseUtils.GuardarArbol( dsArbol);
					}
				}
				else
					MessageBox.Show($"No se pueden eliminar nodos mientras tengan hijos en el árbol", "Eliminar nodo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:cmdDelete_Click", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:cmdDelete_Click", ex);
			}
		}

		private void cmdUP_Click(object sender, EventArgs e)
		{
			try
			{
				TreeNode n = treeView1.SelectedNode;
				TreeNode parent = n.Parent;
				int i = parent.Nodes.IndexOf(n);
				if (i > 0)
				{
					parent.Nodes.RemoveAt(i);
					parent.Nodes.Insert(i - 1, n);
					Arbol.NodosArbolRow nar = dsArbol.NodosArbol.FindById((int)n.Tag);
					int j = dsArbol.NodosArbol.Rows.IndexOf(nar);
					for (int p = j - 1; p > 0; p--)
					{
						if (((Arbol.NodosArbolRow)dsArbol.NodosArbol.Rows[p]).IdParent == nar.IdParent)
						{
							DataRow newRow = dsArbol.NodosArbol.NewRow();
							newRow.ItemArray = nar.ItemArray;
							dsArbol.NodosArbol.Rows.Remove(nar);
							dsArbol.NodosArbol.Rows.InsertAt(newRow, p);
							break;
						}
					}
					DataBaseUtils.GuardarArbol( dsArbol);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:cmdUP_Click", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:cmdUP_Click", ex);
			}
		}

		private void cmdDOWN_Click(object sender, EventArgs e)
		{
			try
			{
				TreeNode n = treeView1.SelectedNode;
				TreeNode parent = n.Parent;
				int i = parent.Nodes.IndexOf(n);
				if (i < parent.Nodes.Count)
				{
					parent.Nodes.RemoveAt(i);
					parent.Nodes.Insert(i + 1, n);
					Arbol.NodosArbolRow nar = dsArbol.NodosArbol.FindById((int)n.Tag);
					int j = dsArbol.NodosArbol.Rows.IndexOf(nar);
					for (int p = j + 1; p < dsArbol.NodosArbol.Rows.Count; p++)
					{
						if (((Arbol.NodosArbolRow)dsArbol.NodosArbol.Rows[p]).IdParent == nar.IdParent)
						{
							DataRow newRow = dsArbol.NodosArbol.NewRow();
							// We "clone" the row
							newRow.ItemArray = nar.ItemArray;
							dsArbol.NodosArbol.Rows.Remove(nar);
							dsArbol.NodosArbol.Rows.InsertAt(newRow, p);
							break;
						}
					}
					DataBaseUtils.GuardarArbol( dsArbol);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:cmdDOWN_Click", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:cmdDOWN_Click", ex);
			}
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			try
			{
				if (treeView1.SelectedNode.Parent != null)
				{
					cmdDelete.Enabled = cmdCopy.Enabled = true;
					int pos = treeView1.SelectedNode.Parent.Nodes.IndexOf(treeView1.SelectedNode);
					cmdUP.Enabled = (pos > 0);
					cmdDOWN.Enabled = (pos < treeView1.SelectedNode.Parent.Nodes.Count - 1);
				}
				else
				{
					cmdDOWN.Enabled = cmdUP.Enabled = cmdDelete.Enabled = cmdCopy.Enabled = false;
				}
				cmdADD.Enabled = true;
				cmdMOD.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:treeView1_AfterSelect", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:treeView1_AfterSelect", ex);
			}
		}
		Random r = new Random();
		private void CalculaDisponibilidad(TreeNode parent)
		{
			try
			{
				foreach (TreeNode nodo in parent.Nodes)
					CalculaDisponibilidad(nodo);

				Arbol.NodosArbolRow nar = dsArbol.NodosArbol.FindById((int)parent.Tag);
				switch (nar.Operation)
				{
					case "-": nar.Calculo = 0.9 + r.Next(100) / 1000.0; break;
					case "Multiplica":
						nar.Calculo = 1.0;
						foreach (TreeNode n in parent.Nodes)
						{
							Arbol.NodosArbolRow nar2 = dsArbol.NodosArbol.FindById((int)n.Tag);
							nar.Calculo *= nar2.Calculo;
						}
						break;
					case "Media":
						nar.Calculo = 0.0;
						foreach (TreeNode n in parent.Nodes)
						{
							Arbol.NodosArbolRow nar2 = dsArbol.NodosArbol.FindById((int)n.Tag);
							nar.Calculo += nar2.Calculo;
						}
						if (parent.Nodes.Count > 0)
							nar.Calculo = nar.Calculo / parent.Nodes.Count;
						break;
					case "Suma":
						nar.Calculo = 0.0;
						foreach (TreeNode n in parent.Nodes)
						{
							Arbol.NodosArbolRow nar2 = dsArbol.NodosArbol.FindById((int)n.Tag);
							nar.Calculo += (nar2.Calculo * nar2.Ponderation);
						}
						break;
				}
				parent.Text += $" = {nar.Calculo}";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message} {ex.StackTrace}", "VITreeView:CalculaDisponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Program.errorLogFile.WriteError("VITreeView:CalculaDisponibilidad", ex);
			}
		}

		private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node.ImageIndex==1)
			{
				DefineLinea dl = new DefineLinea((int)e.Node.Tag, ref dsArbol);
				dl.ShowDialog();
			}
		}
	}
}

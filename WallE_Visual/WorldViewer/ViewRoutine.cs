using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WallE.Errors;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallE.Tools;
using WallE.Routine;

namespace WallE_Visual.WorldViewer
{
    public partial class ViewRoutineForm : Form
    {
        #region Fields
        private IProgrammable wallE;
        private int countRepetitions;
        private bool CreateNew;
        #endregion

        #region Constructors
        public ViewRoutineForm( )
        {
            InitializeComponent( );

            HideTrackBar( );

            this.btnAdd.Enabled = false;
            
            this.lblRutName.Text = string.Empty;
        }
        public ViewRoutineForm(IProgrammable wObjects) : this( )
        {
            this.wallE = wObjects;
            if ( wallE.ListRoutine.Count != 0 )
                this.btnDelete.Enabled = true;
            else
                this.btnDelete.Enabled = false;
            RefreshCombos( );
        }
        #endregion

        #region Events
        private void btnLoad_Click(object sender,EventArgs e)
        {
            LoadRut( );
        }
        private void btnNew_Click(object sender,EventArgs e)
        {
            NewRut( );
        }
        private void btnDelete_Click(object sender,EventArgs e)
        {
            DeleteRut( );
        }
        private void cboxList_SelectedIndexChanged(object sender,EventArgs e)
        {
            if ( !CreateNew )
                ShowSelectedRoutine( );
        }
        private void btnAdd_Click(object sender,EventArgs e)
        {
            AddRut( );
        }
        private void btnSave_Click(object sender,EventArgs e)
        {
            SaveRut( );
        }
        private void tbarZoom_Scroll(object sender,EventArgs e)
        {
            Zoom_Scroll( );
        }
        #endregion

        #region Methods
        private void SaveRut( )
        {
            if ( this.rutView.Routine == null )
            {
                string message = "No existe rutina seleccionada que exportar.";

                message += this.cboxList.Items.Count == 0 ? " Porque no ha creado ninguna rutina" : "\nSeleccione una de la lista de rutinas, y luego expórtela.";
                MessageBox.Show(message,"No existe rutina",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if ( this.folderBrowser.ShowDialog( ) == DialogResult.OK )
                {
                    string path = this.folderBrowser.SelectedPath;
                    try { ControllerRoutine.SaveRoutine(this.rutView.Routine,path); }
                    catch(Exception e )
                    {
                        MessageBox.Show(e.Message,"Instrucciones inexistentes.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
        }
        private void AddRut( )
        {
            if ( !Rut.ValidateRut(rutView.Routine) )
            {
                Error error = new Error("La rutina: \"" + rutView.Routine.Name + "\" no tiene un {start}, por tanto no se puede añadir esta rutina.");
                MessageBox.Show(error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            foreach ( var item in wallE.ListRoutine )
            {
                if ( item.Name == rutView.Routine.Name )
                    rutView.Routine.Name += " " + ++countRepetitions;
            }
            this.wallE.ListRoutine.AddRoutine(this.rutView.Routine);
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            CreateNew = false;
            this.lblRutName.Text = this.rutView.Routine.Name;
            RefreshCombos( );
        }
        private void DeleteRut( )
        {
            string rutToDeleteByName = (string) this.cboxList.SelectedItem;

            foreach ( var ruts in wallE.ListRoutine )
                if ( ruts.Name == rutToDeleteByName )
                {
                    wallE.ListRoutine.RemoveRoutineAt(ruts.Index);
                    break;
                }

            RefreshCombos( );

            this.rutView = new RutViews( );
            this.pnlRutineView.Controls.Clear( );
            this.rutView.Parent = this.pnlRutineView;
            this.rutView.Refresh( );
            this.pnlRutineView.Refresh( );

            if ( this.cboxList.Items.Count == 0 )
            {
                this.btnDelete.Enabled = false;
                this.btnAdd.Enabled = false;
                HideTrackBar( );
                this.lblRutName.Text = string.Empty;
                return;
            }
            ShowSelectedRoutine( );
        }
        private bool IsNumber(string word)
        {
            for ( int i = 0; i < word.Length; i++ )
                if ( !Char.IsLetter(word[i]) )
                    return true;
            return false;
        }
        private void LoadRut( )
        {
            if ( this.ofileLoadRut.ShowDialog( ) == DialogResult.OK )
            {
                foreach ( var file in this.ofileLoadRut.FileNames )
                {
                    Rut rut = null;
                    bool loadOk = false;
                    try
                    {
                        var tempRut = ControllerRoutine.LoadRoutine(file,out loadOk);
                        if ( loadOk )
                            rut = tempRut;
                    }
                    catch ( Exception e )
                    {
                        MessageBox.Show(e.Message + "\nPor tanto, no es posible cargar esa rutina.","Error en la importación de la rutina.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }

                    bool exist = false;
                    foreach ( var item in wallE.ListRoutine )
                        if ( item.Equals(rut) )
                        {
                            exist = true;
                            break;
                        }
                    if ( !exist )
                        wallE.ListRoutine.AddRoutine(rut);
                }
            }
            this.btnDelete.Enabled = true;
            RefreshCombos( );
        }
        private void RefreshCombos( )
        {
            this.cboxList.Items.Clear( );

            var list = wallE.ListRoutine.Select(new Func<Rut,object>(c =>
          {
              if ( c.Name == null || c.Name == string.Empty )
                  return c.Index;
              return c.Name;
          })).ToList( );

            if ( list != null )
            {
                this.cboxList.Items.AddRange(list.ToArray( ));

                if ( list.Count != 0 )
                    this.cboxList.SelectedItem = list.ToArray( )[0];
            }
        }
        private void NewRut( )
        {
            AddRutForm add = new AddRutForm( );

            if ( add.ShowDialog( ) == DialogResult.OK )
            {
                this.pnlRutineView.Controls.Clear( );

                CreateNew = true;
                this.rutView = new RutViews( );
                this.rutView.SetRut(add.Row,add.Column);
                this.rutView.Routine.Name = add.Name;

                this.rutView.Parent = this.pnlRutineView;
                this.rutView.Refresh( );

                this.pnlRutineView.Refresh( );
                this.btnAdd.Enabled = true;
                this.lblZoom.Visible = true;
                this.lblMin.Visible = true;
                this.lblMax.Visible = true;
                this.tbarZoom.Visible = true;
                RefreshCombos( );
                this.rutView.Refresh( );
                ViewTrackBar( );
                this.lblRutName.Text = rutView.Routine.Name;
            }
        }
        private void ShowSelectedRoutine( )
        {
            Rut selectedRut = wallE.ListRoutine.Where(c => ( c.Name == (string) this.cboxList.SelectedItem )).Take(1).ToArray( )[0];

            this.rutView.SetRut(selectedRut);
            this.pnlRutineView.Controls.Clear( );
            this.rutView.Parent = this.pnlRutineView;
            this.rutView.Refresh( );
            this.pnlRutineView.Refresh( );

            this.lblRutName.Text = rutView.Routine.Name;

            ViewTrackBar( );
        }
        private void ViewTrackBar( )
        {
            this.lblZoom.Visible = true;
            this.lblMin.Visible = true;
            this.lblMax.Visible = true;
            this.tbarZoom.Visible = true;
        }
        private void HideTrackBar( )
        {
            this.tbarZoom.Visible = false;
            this.lblZoom.Visible = false;
            this.lblMax.Visible = false;
            this.lblMin.Visible = false;
        }
        private void Zoom_Scroll( )
        {
            this.rutView.ModifySize(this.tbarZoom.Value,this.tbarZoom.Maximum);
        }

        #endregion

        private void ayudaToolStripMenuItem_Click(object sender,EventArgs e)
        {
            new HelpViewRoutine( ).ShowDialog( );
        }
    }
}

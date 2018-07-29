using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;

namespace Building
{
    public partial class Form1 : Form
    {
        private Mesh baseMesh;
        private Mesh colOneMesh;
        private Mesh colTwoMesh;

        private bool colOneVisible;
        private bool colTwoVisible;


        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // Creates a mesh with the shape of a box
            //baseMesh = Mesh.CreateBox(0, 0, 0);
            colOneMesh = Mesh.CreateBox(50, 50, 1);
            colTwoMesh = Mesh.CreateBox(50, 50, 1);

            colOneMesh.Translate(0, 0, 50);
            colTwoMesh.Translate(0, 0, 50);

            colOneMesh.Visible = false;
            colTwoMesh.Visible = false;

            //viewportLayout1.Entities.Add(baseMesh, Color.DarkGray);
            //viewportLayout1.Entities.Add(colOneMesh, Color.DarkGray);
            //viewportLayout1.Entities.Add(colTwoMesh, Color.DarkGray);

            colOneVisible = false;
            colTwoVisible = false;


            //foreach (Entity entity in viewportLayout1.Entities)
            //entity.Visible = false;

            viewportLayout1.ZoomFit();

            base.OnLoad(e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValidDimention(string dimension)
        {
            if (String.IsNullOrEmpty(dimension) || dimension.StartsWith("-") || Double.Parse(dimension) == 0)
                return false;
            else
                return true;
        }

        private bool baseDimensionsValid()
        {
            if (isValidDimention(txtBaseDepth.Text) && isValidDimention(txtBaseWidth.Text) && isValidDimention(txtBaseDepth.Text))
                return true;
            else
                return false;
        }

        private bool columnDimensionsValid()
        {
            if (isValidDimention(txtColHeight.Text) && isValidDimention(txtColLength.Text) && isValidDimention(txtColWidth.Text))
                return true;
            else
                return false;
        }

        private void generateBaseMesh()
        {

            if(viewportLayout1.Entities.Contains(baseMesh))
                viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(baseMesh));

            baseMesh = Mesh.CreateBox(Double.Parse(txtBaseLength.Text), Double.Parse(txtBaseWidth.Text), Double.Parse(txtBaseDepth.Text));
            baseMesh.Translate(0, 0, 50 + (-1 * Double.Parse(txtBaseDepth.Text)));

            viewportLayout1.Entities.Add(baseMesh, Color.DarkGray);

            viewportLayout1.Invalidate();
        }

        private void generateColumns()
        {
            if(viewportLayout1.Entities.Contains(colOneMesh))
                viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colOneMesh));

            colOneMesh = Mesh.CreateBox(Double.Parse(txtColLength.Text), Double.Parse(txtColWidth.Text),  Double.Parse(txtColHeight.Text));
            colOneMesh.Translate(0, 0, 50);
            colOneMesh.Visible = colOneVisible;

            if (viewportLayout1.Entities.Contains(colTwoMesh))
                viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colTwoMesh));

            colTwoMesh = Mesh.CreateBox(Double.Parse(txtColLength.Text), Double.Parse(txtColWidth.Text), Double.Parse(txtColHeight.Text));
            colTwoMesh.Translate(0, 50, 50);
            colTwoMesh.Visible = colTwoVisible;

            viewportLayout1.Entities.Add(colOneMesh, Color.DarkGray);
            viewportLayout1.Entities.Add(colTwoMesh, Color.DarkGray);

            viewportLayout1.Invalidate();
        }


        private void txtBaseLength_TextChanged(object sender, EventArgs e)
        {
            if (baseDimensionsValid())
                generateBaseMesh();
            else if (viewportLayout1.Entities.Contains(baseMesh))
            {
                viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(baseMesh));
                viewportLayout1.Invalidate();
            }
        }

        private void txtBaseWidth_TextChanged(object sender, EventArgs e)
        {
            if (baseDimensionsValid())
                generateBaseMesh();
            else 
            {
                if (viewportLayout1.Entities.Contains(baseMesh))
                {
                    viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(baseMesh));
                    viewportLayout1.Invalidate();
                }
            }
        }

        private void txtBaseDepth_TextChanged(object sender, EventArgs e)
        {
            if (baseDimensionsValid())
                generateBaseMesh();
            else 
            {
                if (viewportLayout1.Entities.Contains(baseMesh))
                {
                    viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(baseMesh));
                    viewportLayout1.Invalidate();
                }
            }
        }

        private void txtColLength_TextChanged(object sender, EventArgs e)
        {
            if (columnDimensionsValid())
                generateColumns();
            else
            {
                if (viewportLayout1.Entities.Contains(colOneMesh))
                {
                    viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colOneMesh));
                    viewportLayout1.Invalidate();
                }

                if (viewportLayout1.Entities.Contains(colTwoMesh))
                {
                    viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colTwoMesh));
                    viewportLayout1.Invalidate();
                }
            }

        }

        private void txtColWidth_TextChanged(object sender, EventArgs e)
        {
            if (columnDimensionsValid())
                generateColumns();
            else
            {
                if (viewportLayout1.Entities.Contains(colOneMesh))
                {
                    viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colOneMesh));
                    viewportLayout1.Invalidate();
                }

                if (viewportLayout1.Entities.Contains(colTwoMesh))
                {
                    viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colTwoMesh));
                    viewportLayout1.Invalidate();
                }
            }
        }

        private void txtColHeight_TextChanged(object sender, EventArgs e)
        {
            if (columnDimensionsValid())
                generateColumns();
            else
            {
                if (viewportLayout1.Entities.Contains(colOneMesh))
                {
                    viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colOneMesh));
                    viewportLayout1.Invalidate();
                }

                if (viewportLayout1.Entities.Contains(colTwoMesh))
                {
                    viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colTwoMesh));
                    viewportLayout1.Invalidate();
                }
            }
        }

        private void txtCol1XOffset_TextChanged(object sender, EventArgs e)
        {
            double offsetX, offsetY = 0;

            Double.TryParse(txtCol1XOffset.Text, out offsetX);
            Double.TryParse(txtCol1YOffset.Text, out offsetY);
            
                if (viewportLayout1.Entities.Contains(colOneMesh))
                    viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colOneMesh));

                colOneMesh = Mesh.CreateBox(Double.Parse(txtColLength.Text), Double.Parse(txtColWidth.Text), Double.Parse(txtColHeight.Text));
                colOneMesh.Translate(offsetX, offsetY, 50);
                colOneMesh.Visible = colOneVisible;

                viewportLayout1.Entities.Add(colOneMesh, Color.DarkGray);

                viewportLayout1.Invalidate();            
        }

        private void txtCol1YOffset_TextChanged(object sender, EventArgs e)
        {
            double offsetX, offsetY = 0;

            Double.TryParse(txtCol1XOffset.Text, out offsetX);
            Double.TryParse(txtCol1YOffset.Text, out offsetY);

            if (viewportLayout1.Entities.Contains(colOneMesh))
                viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colOneMesh));

            colOneMesh = Mesh.CreateBox(Double.Parse(txtColLength.Text), Double.Parse(txtColWidth.Text), Double.Parse(txtColHeight.Text));
            colOneMesh.Translate(offsetX, offsetY, 50);
            colOneMesh.Visible = colOneVisible;

            viewportLayout1.Entities.Add(colOneMesh, Color.DarkGray);

            viewportLayout1.Invalidate();
        }

        private void txtCol2XOffset_TextChanged(object sender, EventArgs e)
        {
            double offsetX, offsetY = 0;

            Double.TryParse(txtCol2XOffset.Text, out offsetX);
            Double.TryParse(txtCol2YOffset.Text, out offsetY);

            if (viewportLayout1.Entities.Contains(colTwoMesh))
                viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colTwoMesh));

            colTwoMesh = Mesh.CreateBox(Double.Parse(txtColLength.Text), Double.Parse(txtColWidth.Text), Double.Parse(txtColHeight.Text));
            colTwoMesh.Translate(offsetX, 50 + offsetY, 50);
            colTwoMesh.Visible = colTwoVisible;

            viewportLayout1.Entities.Add(colTwoMesh, Color.DarkGray);

            viewportLayout1.Invalidate();
        }

        private void txtCol2YOffset_TextChanged(object sender, EventArgs e)
        {
            double offsetX, offsetY = 0;

            Double.TryParse(txtCol2XOffset.Text, out offsetX);
            Double.TryParse(txtCol2YOffset.Text, out offsetY);

            if (viewportLayout1.Entities.Contains(colTwoMesh))
                viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colTwoMesh));

            colTwoMesh = Mesh.CreateBox(Double.Parse(txtColLength.Text), Double.Parse(txtColWidth.Text), Double.Parse(txtColHeight.Text));
            colTwoMesh.Translate(offsetX, 50 + offsetY, 50);
            colTwoMesh.Visible = colTwoVisible;

            viewportLayout1.Entities.Add(colTwoMesh, Color.DarkGray);

            viewportLayout1.Invalidate();
        }

        private void chkCol1_CheckedChanged(object sender, EventArgs e)
        {
            if (colOneVisible == false)
                colOneVisible = true;
            else
                colOneVisible = false;

            colOneMesh.Visible = colOneVisible;

            if(viewportLayout1.Entities.Contains(colOneMesh))
                viewportLayout1.Entities.RemoveAt(viewportLayout1.Entities.IndexOf(colOneMesh));

            viewportLayout1.Entities.Add(colOneMesh, Color.DarkGray);
            viewportLayout1.Invalidate();
        }

        private void chkCol2_CheckedChanged(object sender, EventArgs e)
        {
            if (colTwoVisible == false)
                colTwoVisible = true;
            else
                colTwoVisible = false;

            if (viewportLayout1.Entities.Contains(colTwoMesh))
                viewportLayout1.Entities[viewportLayout1.Entities.IndexOf(colTwoMesh)].Visible = colTwoVisible;

            viewportLayout1.Entities.Add(colTwoMesh, Color.DarkGray);
            viewportLayout1.Invalidate();
        }
    }
}

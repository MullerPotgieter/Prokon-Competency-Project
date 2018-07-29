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
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // Creates a mesh with the shape of a box
            Mesh m = Mesh.CreateBox(3, 2, 1);
            Mesh m2 = Mesh.CreateBox(30, 20, 10);

            // Adds the mesh to the master entity collection
            viewportLayout1.Entities.Add(m, Color.DarkRed);
            viewportLayout1.Entities.Add(m2, Color.AliceBlue);


            int a =  viewportLayout1.Entities.IndexOf(m2);


            // Fits the drawing in the viewport
            viewportLayout1.ZoomFit();

            base.OnLoad(e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}

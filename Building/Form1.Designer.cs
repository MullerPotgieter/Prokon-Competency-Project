namespace Building
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton13 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar13 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton13, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings13 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.3D);
            devDept.Eyeshot.Camera camera13 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 50D), 600D, new devDept.Geometry.Quaternion(0.086824088833465166D, 0.15038373318043533D, 0.492403876506104D, 0.85286853195244339D), devDept.Graphics.projectionType.Perspective, 50D, 2.9500008021220028D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton13 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton13 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton13 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton13 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton13 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton13 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton13 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar13 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton13)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton13)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton13)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton13)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton13)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton13)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton13))});
            devDept.Eyeshot.Grid grid13 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 5D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))), false, true, false, false, 10, 100, 5, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings13 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings13 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.DeepSkyBlue, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings13 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings13 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager13 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport13 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(389, 295), backgroundSettings13, camera13, new devDept.Eyeshot.ToolBar[] {
            toolBar13}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid13}, false, rotateSettings13, zoomSettings13, panSettings13, navigationSettings13, savedViewsManager13, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon13 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol13 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon13 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(43)))), ((int)(((byte)(226))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            this.chkCol1 = new System.Windows.Forms.CheckBox();
            this.chkCol2 = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBaseLength = new System.Windows.Forms.TextBox();
            this.txtBaseWidth = new System.Windows.Forms.TextBox();
            this.txtBaseDepth = new System.Windows.Forms.TextBox();
            this.txtColLength = new System.Windows.Forms.TextBox();
            this.txtColWidth = new System.Windows.Forms.TextBox();
            this.txtColHeight = new System.Windows.Forms.TextBox();
            this.txtCol1XOffset = new System.Windows.Forms.TextBox();
            this.txtCol1YOffset = new System.Windows.Forms.TextBox();
            this.txtCol2XOffset = new System.Windows.Forms.TextBox();
            this.txtCol2YOffset = new System.Windows.Forms.TextBox();
            this.viewportLayout1 = new devDept.Eyeshot.ViewportLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewportLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkCol1
            // 
            this.chkCol1.AutoSize = true;
            this.chkCol1.Location = new System.Drawing.Point(433, 104);
            this.chkCol1.Name = "chkCol1";
            this.chkCol1.Size = new System.Drawing.Size(70, 17);
            this.chkCol1.TabIndex = 1;
            this.chkCol1.Text = "Column 1";
            this.chkCol1.UseVisualStyleBackColor = true;
            this.chkCol1.CheckedChanged += new System.EventHandler(this.chkCol1_CheckedChanged);
            // 
            // chkCol2
            // 
            this.chkCol2.AutoSize = true;
            this.chkCol2.Location = new System.Drawing.Point(531, 104);
            this.chkCol2.Name = "chkCol2";
            this.chkCol2.Size = new System.Drawing.Size(70, 17);
            this.chkCol2.TabIndex = 2;
            this.chkCol2.Text = "Column 2";
            this.chkCol2.UseVisualStyleBackColor = true;
            this.chkCol2.CheckedChanged += new System.EventHandler(this.chkCol2_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(536, 347);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 34);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base Lenght:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base Depth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Col Lenght:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Col Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Col Height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Col 1 X offset:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Col 1 Y offset:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Col 2 X offset:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Col 2 Y offset:";
            // 
            // txtBaseLength
            // 
            this.txtBaseLength.Location = new System.Drawing.Point(516, 26);
            this.txtBaseLength.Name = "txtBaseLength";
            this.txtBaseLength.Size = new System.Drawing.Size(100, 20);
            this.txtBaseLength.TabIndex = 14;
            this.txtBaseLength.TextChanged += new System.EventHandler(this.txtBaseLength_TextChanged);
            // 
            // txtBaseWidth
            // 
            this.txtBaseWidth.Location = new System.Drawing.Point(516, 52);
            this.txtBaseWidth.Name = "txtBaseWidth";
            this.txtBaseWidth.Size = new System.Drawing.Size(100, 20);
            this.txtBaseWidth.TabIndex = 15;
            this.txtBaseWidth.TextChanged += new System.EventHandler(this.txtBaseWidth_TextChanged);
            // 
            // txtBaseDepth
            // 
            this.txtBaseDepth.Location = new System.Drawing.Point(516, 78);
            this.txtBaseDepth.Name = "txtBaseDepth";
            this.txtBaseDepth.Size = new System.Drawing.Size(100, 20);
            this.txtBaseDepth.TabIndex = 16;
            this.txtBaseDepth.TextChanged += new System.EventHandler(this.txtBaseDepth_TextChanged);
            // 
            // txtColLength
            // 
            this.txtColLength.Location = new System.Drawing.Point(516, 131);
            this.txtColLength.Name = "txtColLength";
            this.txtColLength.Size = new System.Drawing.Size(100, 20);
            this.txtColLength.TabIndex = 17;
            this.txtColLength.TextChanged += new System.EventHandler(this.txtColLength_TextChanged);
            // 
            // txtColWidth
            // 
            this.txtColWidth.Location = new System.Drawing.Point(516, 157);
            this.txtColWidth.Name = "txtColWidth";
            this.txtColWidth.Size = new System.Drawing.Size(100, 20);
            this.txtColWidth.TabIndex = 18;
            this.txtColWidth.TextChanged += new System.EventHandler(this.txtColWidth_TextChanged);
            // 
            // txtColHeight
            // 
            this.txtColHeight.Location = new System.Drawing.Point(516, 183);
            this.txtColHeight.Name = "txtColHeight";
            this.txtColHeight.Size = new System.Drawing.Size(100, 20);
            this.txtColHeight.TabIndex = 19;
            this.txtColHeight.TextChanged += new System.EventHandler(this.txtColHeight_TextChanged);
            // 
            // txtCol1XOffset
            // 
            this.txtCol1XOffset.Location = new System.Drawing.Point(516, 209);
            this.txtCol1XOffset.Name = "txtCol1XOffset";
            this.txtCol1XOffset.Size = new System.Drawing.Size(100, 20);
            this.txtCol1XOffset.TabIndex = 20;
            this.txtCol1XOffset.TextChanged += new System.EventHandler(this.txtCol1XOffset_TextChanged);
            // 
            // txtCol1YOffset
            // 
            this.txtCol1YOffset.Location = new System.Drawing.Point(516, 235);
            this.txtCol1YOffset.Name = "txtCol1YOffset";
            this.txtCol1YOffset.Size = new System.Drawing.Size(100, 20);
            this.txtCol1YOffset.TabIndex = 21;
            this.txtCol1YOffset.TextChanged += new System.EventHandler(this.txtCol1YOffset_TextChanged);
            // 
            // txtCol2XOffset
            // 
            this.txtCol2XOffset.Location = new System.Drawing.Point(516, 261);
            this.txtCol2XOffset.Name = "txtCol2XOffset";
            this.txtCol2XOffset.Size = new System.Drawing.Size(100, 20);
            this.txtCol2XOffset.TabIndex = 22;
            this.txtCol2XOffset.TextChanged += new System.EventHandler(this.txtCol2XOffset_TextChanged);
            // 
            // txtCol2YOffset
            // 
            this.txtCol2YOffset.Location = new System.Drawing.Point(516, 287);
            this.txtCol2YOffset.Name = "txtCol2YOffset";
            this.txtCol2YOffset.Size = new System.Drawing.Size(100, 20);
            this.txtCol2YOffset.TabIndex = 23;
            this.txtCol2YOffset.TextChanged += new System.EventHandler(this.txtCol2YOffset_TextChanged);
            // 
            // viewportLayout1
            // 
            this.viewportLayout1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewportLayout1.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewportLayout1.FastZPR = false;
            this.viewportLayout1.Location = new System.Drawing.Point(12, 12);
            this.viewportLayout1.Name = "viewportLayout1";
            this.viewportLayout1.ProgressBar = progressBar13;
            this.viewportLayout1.Size = new System.Drawing.Size(389, 295);
            this.viewportLayout1.TabIndex = 24;
            this.viewportLayout1.Text = "viewportLayout1";
            coordinateSystemIcon13.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewport13.CoordinateSystemIcon = coordinateSystemIcon13;
            viewport13.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol13.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewport13.OriginSymbol = originSymbol13;
            viewCubeIcon13.Font = null;
            viewCubeIcon13.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport13.ViewCubeIcon = viewCubeIcon13;
            this.viewportLayout1.Viewports.Add(viewport13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 393);
            this.Controls.Add(this.viewportLayout1);
            this.Controls.Add(this.txtCol2YOffset);
            this.Controls.Add(this.txtCol2XOffset);
            this.Controls.Add(this.txtCol1YOffset);
            this.Controls.Add(this.txtCol1XOffset);
            this.Controls.Add(this.txtColHeight);
            this.Controls.Add(this.txtColWidth);
            this.Controls.Add(this.txtColLength);
            this.Controls.Add(this.txtBaseDepth);
            this.Controls.Add(this.txtBaseWidth);
            this.Controls.Add(this.txtBaseLength);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkCol2);
            this.Controls.Add(this.chkCol1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.viewportLayout1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.CheckBox chkCol1;
        private System.Windows.Forms.CheckBox chkCol2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBaseLength;
        private System.Windows.Forms.TextBox txtBaseWidth;
        private System.Windows.Forms.TextBox txtBaseDepth;
        private System.Windows.Forms.TextBox txtColLength;
        private System.Windows.Forms.TextBox txtColWidth;
        private System.Windows.Forms.TextBox txtColHeight;
        private System.Windows.Forms.TextBox txtCol1XOffset;
        private System.Windows.Forms.TextBox txtCol1YOffset;
        private System.Windows.Forms.TextBox txtCol2XOffset;
        private System.Windows.Forms.TextBox txtCol2YOffset;
        private devDept.Eyeshot.ViewportLayout viewportLayout1;
    }
}


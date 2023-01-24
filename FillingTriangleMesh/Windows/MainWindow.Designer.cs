
namespace FillingTriangleMesh
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.LambertModelGroupBox = new System.Windows.Forms.GroupBox();
            this.LambertModelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.coefficientsGroupBox = new System.Windows.Forms.GroupBox();
            this.coefficientsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ksValueLabel = new System.Windows.Forms.Label();
            this.kdLabel = new System.Windows.Forms.Label();
            this.ksLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.kdTrackBar = new System.Windows.Forms.TrackBar();
            this.kdValueLabel = new System.Windows.Forms.Label();
            this.mValueLabel = new System.Windows.Forms.Label();
            this.ksTrackBar = new System.Windows.Forms.TrackBar();
            this.mTrackBar = new System.Windows.Forms.TrackBar();
            this.triangleMeshGroupBox = new System.Windows.Forms.GroupBox();
            this.triangleMeshTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.showTriangleMeshCheckBox = new System.Windows.Forms.CheckBox();
            this.shadingGroupBox = new System.Windows.Forms.GroupBox();
            this.shadingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.constantShadingRadioButton = new System.Windows.Forms.RadioButton();
            this.PhongShadingRadioButton = new System.Windows.Forms.RadioButton();
            this.GouraudShadingRadioButton = new System.Windows.Forms.RadioButton();
            this.lightGroupBox = new System.Windows.Forms.GroupBox();
            this.lightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.animationGroupBox = new System.Windows.Forms.GroupBox();
            this.animationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startAnimationButton = new System.Windows.Forms.Button();
            this.stopAnimationButton = new System.Windows.Forms.Button();
            this.changeLightColorButton = new System.Windows.Forms.Button();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.colorChangeButton = new System.Windows.Forms.Button();
            this.cameraGroupBox = new System.Windows.Forms.GroupBox();
            this.cameraTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cameraTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.switchCameraButton = new System.Windows.Forms.Button();
            this.FOVGroupBox = new System.Windows.Forms.GroupBox();
            this.FOVTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FOVLabel = new System.Windows.Forms.Label();
            this.FOVValueLabel = new System.Windows.Forms.Label();
            this.FOVTrackBar = new System.Windows.Forms.TrackBar();
            this.vibrationGroupBox = new System.Windows.Forms.GroupBox();
            this.vibrationCheckBox = new System.Windows.Forms.CheckBox();
            this.SpotlightGroupBox = new System.Windows.Forms.GroupBox();
            this.spotlightDirectionButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lightColorDialog = new System.Windows.Forms.ColorDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.LambertModelGroupBox.SuspendLayout();
            this.LambertModelTableLayoutPanel.SuspendLayout();
            this.coefficientsGroupBox.SuspendLayout();
            this.coefficientsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).BeginInit();
            this.triangleMeshGroupBox.SuspendLayout();
            this.triangleMeshTableLayoutPanel.SuspendLayout();
            this.shadingGroupBox.SuspendLayout();
            this.shadingTableLayoutPanel.SuspendLayout();
            this.lightGroupBox.SuspendLayout();
            this.lightTableLayoutPanel.SuspendLayout();
            this.animationGroupBox.SuspendLayout();
            this.animationTableLayoutPanel.SuspendLayout();
            this.colorGroupBox.SuspendLayout();
            this.cameraGroupBox.SuspendLayout();
            this.cameraTableLayoutPanel.SuspendLayout();
            this.cameraTypeGroupBox.SuspendLayout();
            this.FOVGroupBox.SuspendLayout();
            this.FOVTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOVTrackBar)).BeginInit();
            this.vibrationGroupBox.SuspendLayout();
            this.SpotlightGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.LambertModelGroupBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lightGroupBox, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.colorGroupBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.cameraGroupBox, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.vibrationGroupBox, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.SpotlightGroupBox, 0, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1835, 853);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(203, 3);
            this.pictureBox.Name = "pictureBox";
            this.tableLayoutPanel.SetRowSpan(this.pictureBox, 7);
            this.pictureBox.Size = new System.Drawing.Size(1629, 801);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // LambertModelGroupBox
            // 
            this.LambertModelGroupBox.Controls.Add(this.LambertModelTableLayoutPanel);
            this.LambertModelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LambertModelGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LambertModelGroupBox.Location = new System.Drawing.Point(3, 54);
            this.LambertModelGroupBox.Name = "LambertModelGroupBox";
            this.LambertModelGroupBox.Size = new System.Drawing.Size(194, 326);
            this.LambertModelGroupBox.TabIndex = 2;
            this.LambertModelGroupBox.TabStop = false;
            this.LambertModelGroupBox.Text = "Lambert model";
            // 
            // LambertModelTableLayoutPanel
            // 
            this.LambertModelTableLayoutPanel.ColumnCount = 1;
            this.LambertModelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LambertModelTableLayoutPanel.Controls.Add(this.coefficientsGroupBox, 0, 1);
            this.LambertModelTableLayoutPanel.Controls.Add(this.triangleMeshGroupBox, 0, 0);
            this.LambertModelTableLayoutPanel.Controls.Add(this.shadingGroupBox, 0, 2);
            this.LambertModelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LambertModelTableLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.LambertModelTableLayoutPanel.Name = "LambertModelTableLayoutPanel";
            this.LambertModelTableLayoutPanel.RowCount = 3;
            this.LambertModelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.LambertModelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.LambertModelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.LambertModelTableLayoutPanel.Size = new System.Drawing.Size(188, 297);
            this.LambertModelTableLayoutPanel.TabIndex = 0;
            // 
            // coefficientsGroupBox
            // 
            this.coefficientsGroupBox.Controls.Add(this.coefficientsTableLayoutPanel);
            this.coefficientsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coefficientsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coefficientsGroupBox.Location = new System.Drawing.Point(3, 50);
            this.coefficientsGroupBox.Name = "coefficientsGroupBox";
            this.coefficientsGroupBox.Size = new System.Drawing.Size(185, 151);
            this.coefficientsGroupBox.TabIndex = 2;
            this.coefficientsGroupBox.TabStop = false;
            this.coefficientsGroupBox.Text = "Coefficients";
            // 
            // coefficientsTableLayoutPanel
            // 
            this.coefficientsTableLayoutPanel.ColumnCount = 2;
            this.coefficientsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.coefficientsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.coefficientsTableLayoutPanel.Controls.Add(this.ksValueLabel, 1, 2);
            this.coefficientsTableLayoutPanel.Controls.Add(this.kdLabel, 0, 0);
            this.coefficientsTableLayoutPanel.Controls.Add(this.ksLabel, 0, 2);
            this.coefficientsTableLayoutPanel.Controls.Add(this.mLabel, 0, 4);
            this.coefficientsTableLayoutPanel.Controls.Add(this.kdTrackBar, 0, 1);
            this.coefficientsTableLayoutPanel.Controls.Add(this.kdValueLabel, 1, 0);
            this.coefficientsTableLayoutPanel.Controls.Add(this.mValueLabel, 1, 4);
            this.coefficientsTableLayoutPanel.Controls.Add(this.ksTrackBar, 0, 3);
            this.coefficientsTableLayoutPanel.Controls.Add(this.mTrackBar, 0, 5);
            this.coefficientsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coefficientsTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.coefficientsTableLayoutPanel.Name = "coefficientsTableLayoutPanel";
            this.coefficientsTableLayoutPanel.RowCount = 6;
            this.coefficientsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.001F));
            this.coefficientsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.coefficientsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.001F));
            this.coefficientsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.coefficientsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.001F));
            this.coefficientsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.coefficientsTableLayoutPanel.Size = new System.Drawing.Size(179, 125);
            this.coefficientsTableLayoutPanel.TabIndex = 0;
            // 
            // ksValueLabel
            // 
            this.ksValueLabel.AutoSize = true;
            this.ksValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ksValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ksValueLabel.Location = new System.Drawing.Point(92, 41);
            this.ksValueLabel.Name = "ksValueLabel";
            this.ksValueLabel.Size = new System.Drawing.Size(84, 12);
            this.ksValueLabel.TabIndex = 5;
            this.ksValueLabel.Text = "0,5";
            // 
            // kdLabel
            // 
            this.kdLabel.AutoSize = true;
            this.kdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kdLabel.Location = new System.Drawing.Point(3, 0);
            this.kdLabel.Name = "kdLabel";
            this.kdLabel.Size = new System.Drawing.Size(83, 12);
            this.kdLabel.TabIndex = 0;
            this.kdLabel.Text = "kd:";
            // 
            // ksLabel
            // 
            this.ksLabel.AutoSize = true;
            this.ksLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ksLabel.Location = new System.Drawing.Point(3, 41);
            this.ksLabel.Name = "ksLabel";
            this.ksLabel.Size = new System.Drawing.Size(27, 12);
            this.ksLabel.TabIndex = 1;
            this.ksLabel.Text = "ks:";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mLabel.Location = new System.Drawing.Point(3, 82);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(26, 12);
            this.mLabel.TabIndex = 2;
            this.mLabel.Text = "m:";
            // 
            // kdTrackBar
            // 
            this.coefficientsTableLayoutPanel.SetColumnSpan(this.kdTrackBar, 2);
            this.kdTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdTrackBar.Location = new System.Drawing.Point(3, 15);
            this.kdTrackBar.Maximum = 100;
            this.kdTrackBar.Name = "kdTrackBar";
            this.kdTrackBar.Size = new System.Drawing.Size(173, 23);
            this.kdTrackBar.TabIndex = 3;
            this.kdTrackBar.Value = 50;
            this.kdTrackBar.Scroll += new System.EventHandler(this.kdTrackBar_Scroll);
            this.kdTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kdTrackBar_MouseUp);
            // 
            // kdValueLabel
            // 
            this.kdValueLabel.AutoSize = true;
            this.kdValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kdValueLabel.Location = new System.Drawing.Point(92, 0);
            this.kdValueLabel.Name = "kdValueLabel";
            this.kdValueLabel.Size = new System.Drawing.Size(84, 12);
            this.kdValueLabel.TabIndex = 4;
            this.kdValueLabel.Text = "0,5";
            // 
            // mValueLabel
            // 
            this.mValueLabel.AutoSize = true;
            this.mValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mValueLabel.Location = new System.Drawing.Point(92, 82);
            this.mValueLabel.Name = "mValueLabel";
            this.mValueLabel.Size = new System.Drawing.Size(84, 12);
            this.mValueLabel.TabIndex = 7;
            this.mValueLabel.Text = "1";
            // 
            // ksTrackBar
            // 
            this.coefficientsTableLayoutPanel.SetColumnSpan(this.ksTrackBar, 2);
            this.ksTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ksTrackBar.Location = new System.Drawing.Point(3, 56);
            this.ksTrackBar.Maximum = 100;
            this.ksTrackBar.Name = "ksTrackBar";
            this.ksTrackBar.Size = new System.Drawing.Size(173, 23);
            this.ksTrackBar.TabIndex = 8;
            this.ksTrackBar.Value = 50;
            this.ksTrackBar.Scroll += new System.EventHandler(this.ksTrackBar_Scroll);
            this.ksTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ksTrackBar_MouseUp);
            // 
            // mTrackBar
            // 
            this.coefficientsTableLayoutPanel.SetColumnSpan(this.mTrackBar, 2);
            this.mTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTrackBar.Location = new System.Drawing.Point(3, 97);
            this.mTrackBar.Maximum = 100;
            this.mTrackBar.Minimum = 1;
            this.mTrackBar.Name = "mTrackBar";
            this.mTrackBar.Size = new System.Drawing.Size(173, 25);
            this.mTrackBar.TabIndex = 9;
            this.mTrackBar.Value = 1;
            this.mTrackBar.Scroll += new System.EventHandler(this.mTrackBar_Scroll);
            this.mTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mTrackBar_MouseUp);
            // 
            // triangleMeshGroupBox
            // 
            this.triangleMeshGroupBox.Controls.Add(this.triangleMeshTableLayoutPanel);
            this.triangleMeshGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triangleMeshGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.triangleMeshGroupBox.Location = new System.Drawing.Point(3, 3);
            this.triangleMeshGroupBox.Name = "triangleMeshGroupBox";
            this.triangleMeshGroupBox.Size = new System.Drawing.Size(185, 41);
            this.triangleMeshGroupBox.TabIndex = 5;
            this.triangleMeshGroupBox.TabStop = false;
            this.triangleMeshGroupBox.Text = "Triangle mesh";
            // 
            // triangleMeshTableLayoutPanel
            // 
            this.triangleMeshTableLayoutPanel.ColumnCount = 2;
            this.triangleMeshTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.triangleMeshTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.triangleMeshTableLayoutPanel.Controls.Add(this.showTriangleMeshCheckBox, 0, 0);
            this.triangleMeshTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triangleMeshTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.triangleMeshTableLayoutPanel.Name = "triangleMeshTableLayoutPanel";
            this.triangleMeshTableLayoutPanel.RowCount = 1;
            this.triangleMeshTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.triangleMeshTableLayoutPanel.Size = new System.Drawing.Size(179, 15);
            this.triangleMeshTableLayoutPanel.TabIndex = 0;
            // 
            // showTriangleMeshCheckBox
            // 
            this.showTriangleMeshCheckBox.AutoSize = true;
            this.showTriangleMeshCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showTriangleMeshCheckBox.Location = new System.Drawing.Point(3, 3);
            this.showTriangleMeshCheckBox.Name = "showTriangleMeshCheckBox";
            this.showTriangleMeshCheckBox.Size = new System.Drawing.Size(83, 24);
            this.showTriangleMeshCheckBox.TabIndex = 0;
            this.showTriangleMeshCheckBox.Text = "Show";
            this.showTriangleMeshCheckBox.UseVisualStyleBackColor = true;
            this.showTriangleMeshCheckBox.CheckedChanged += new System.EventHandler(this.showTriangleMeshCheckBox_CheckedChanged);
            // 
            // shadingGroupBox
            // 
            this.shadingGroupBox.Controls.Add(this.shadingTableLayoutPanel);
            this.shadingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shadingGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shadingGroupBox.Location = new System.Drawing.Point(3, 207);
            this.shadingGroupBox.Name = "shadingGroupBox";
            this.shadingGroupBox.Size = new System.Drawing.Size(185, 87);
            this.shadingGroupBox.TabIndex = 6;
            this.shadingGroupBox.TabStop = false;
            this.shadingGroupBox.Text = "Shading";
            // 
            // shadingTableLayoutPanel
            // 
            this.shadingTableLayoutPanel.ColumnCount = 1;
            this.shadingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.shadingTableLayoutPanel.Controls.Add(this.constantShadingRadioButton, 0, 0);
            this.shadingTableLayoutPanel.Controls.Add(this.PhongShadingRadioButton, 0, 1);
            this.shadingTableLayoutPanel.Controls.Add(this.GouraudShadingRadioButton, 0, 2);
            this.shadingTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shadingTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.shadingTableLayoutPanel.Name = "shadingTableLayoutPanel";
            this.shadingTableLayoutPanel.RowCount = 3;
            this.shadingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.shadingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.shadingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.shadingTableLayoutPanel.Size = new System.Drawing.Size(179, 61);
            this.shadingTableLayoutPanel.TabIndex = 0;
            // 
            // constantShadingRadioButton
            // 
            this.constantShadingRadioButton.AutoSize = true;
            this.constantShadingRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constantShadingRadioButton.Location = new System.Drawing.Point(3, 3);
            this.constantShadingRadioButton.Name = "constantShadingRadioButton";
            this.constantShadingRadioButton.Size = new System.Drawing.Size(173, 14);
            this.constantShadingRadioButton.TabIndex = 0;
            this.constantShadingRadioButton.Text = "Constant";
            this.constantShadingRadioButton.UseVisualStyleBackColor = true;
            this.constantShadingRadioButton.CheckedChanged += new System.EventHandler(this.constantShadingRadioButton_CheckedChanged);
            // 
            // PhongShadingRadioButton
            // 
            this.PhongShadingRadioButton.AutoSize = true;
            this.PhongShadingRadioButton.Checked = true;
            this.PhongShadingRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhongShadingRadioButton.Location = new System.Drawing.Point(3, 23);
            this.PhongShadingRadioButton.Name = "PhongShadingRadioButton";
            this.PhongShadingRadioButton.Size = new System.Drawing.Size(173, 14);
            this.PhongShadingRadioButton.TabIndex = 1;
            this.PhongShadingRadioButton.TabStop = true;
            this.PhongShadingRadioButton.Text = "Phong";
            this.PhongShadingRadioButton.UseVisualStyleBackColor = true;
            this.PhongShadingRadioButton.CheckedChanged += new System.EventHandler(this.PhongShadingRadioButton_CheckedChanged);
            // 
            // GouraudShadingRadioButton
            // 
            this.GouraudShadingRadioButton.AutoSize = true;
            this.GouraudShadingRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GouraudShadingRadioButton.Location = new System.Drawing.Point(3, 43);
            this.GouraudShadingRadioButton.Name = "GouraudShadingRadioButton";
            this.GouraudShadingRadioButton.Size = new System.Drawing.Size(173, 15);
            this.GouraudShadingRadioButton.TabIndex = 2;
            this.GouraudShadingRadioButton.Text = "Gouraud";
            this.GouraudShadingRadioButton.UseVisualStyleBackColor = true;
            this.GouraudShadingRadioButton.CheckedChanged += new System.EventHandler(this.GouraudShadingRadioButton_CheckedChanged);
            // 
            // lightGroupBox
            // 
            this.lightGroupBox.Controls.Add(this.lightTableLayoutPanel);
            this.lightGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lightGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lightGroupBox.Location = new System.Drawing.Point(3, 386);
            this.lightGroupBox.Name = "lightGroupBox";
            this.lightGroupBox.Size = new System.Drawing.Size(194, 113);
            this.lightGroupBox.TabIndex = 3;
            this.lightGroupBox.TabStop = false;
            this.lightGroupBox.Text = "Light";
            // 
            // lightTableLayoutPanel
            // 
            this.lightTableLayoutPanel.ColumnCount = 2;
            this.lightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lightTableLayoutPanel.Controls.Add(this.animationGroupBox, 0, 1);
            this.lightTableLayoutPanel.Controls.Add(this.changeLightColorButton, 0, 0);
            this.lightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lightTableLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.lightTableLayoutPanel.Name = "lightTableLayoutPanel";
            this.lightTableLayoutPanel.RowCount = 2;
            this.lightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.lightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.lightTableLayoutPanel.Size = new System.Drawing.Size(188, 84);
            this.lightTableLayoutPanel.TabIndex = 0;
            // 
            // animationGroupBox
            // 
            this.lightTableLayoutPanel.SetColumnSpan(this.animationGroupBox, 2);
            this.animationGroupBox.Controls.Add(this.animationTableLayoutPanel);
            this.animationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animationGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.animationGroupBox.Location = new System.Drawing.Point(3, 32);
            this.animationGroupBox.Name = "animationGroupBox";
            this.animationGroupBox.Size = new System.Drawing.Size(182, 49);
            this.animationGroupBox.TabIndex = 0;
            this.animationGroupBox.TabStop = false;
            this.animationGroupBox.Text = "Animation";
            // 
            // animationTableLayoutPanel
            // 
            this.animationTableLayoutPanel.ColumnCount = 2;
            this.animationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.animationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.animationTableLayoutPanel.Controls.Add(this.startAnimationButton, 0, 0);
            this.animationTableLayoutPanel.Controls.Add(this.stopAnimationButton, 1, 0);
            this.animationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animationTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.animationTableLayoutPanel.Name = "animationTableLayoutPanel";
            this.animationTableLayoutPanel.RowCount = 1;
            this.animationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.animationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.animationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.animationTableLayoutPanel.Size = new System.Drawing.Size(176, 23);
            this.animationTableLayoutPanel.TabIndex = 0;
            // 
            // startAnimationButton
            // 
            this.startAnimationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startAnimationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startAnimationButton.ForeColor = System.Drawing.Color.PaleGreen;
            this.startAnimationButton.Location = new System.Drawing.Point(3, 3);
            this.startAnimationButton.Name = "startAnimationButton";
            this.startAnimationButton.Size = new System.Drawing.Size(82, 17);
            this.startAnimationButton.TabIndex = 3;
            this.startAnimationButton.UseVisualStyleBackColor = true;
            this.startAnimationButton.Click += new System.EventHandler(this.startAnimationButton_Click);
            // 
            // stopAnimationButton
            // 
            this.stopAnimationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopAnimationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopAnimationButton.ForeColor = System.Drawing.Color.Red;
            this.stopAnimationButton.Location = new System.Drawing.Point(91, 3);
            this.stopAnimationButton.Name = "stopAnimationButton";
            this.stopAnimationButton.Size = new System.Drawing.Size(82, 17);
            this.stopAnimationButton.TabIndex = 4;
            this.stopAnimationButton.UseVisualStyleBackColor = true;
            this.stopAnimationButton.Click += new System.EventHandler(this.stopAnimationButton_Click);
            // 
            // changeLightColorButton
            // 
            this.lightTableLayoutPanel.SetColumnSpan(this.changeLightColorButton, 2);
            this.changeLightColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeLightColorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeLightColorButton.Location = new System.Drawing.Point(3, 3);
            this.changeLightColorButton.Name = "changeLightColorButton";
            this.changeLightColorButton.Size = new System.Drawing.Size(182, 23);
            this.changeLightColorButton.TabIndex = 2;
            this.changeLightColorButton.Text = "Change color";
            this.changeLightColorButton.UseVisualStyleBackColor = true;
            this.changeLightColorButton.Click += new System.EventHandler(this.changeLightColorButton_Click);
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.colorChangeButton);
            this.colorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.colorGroupBox.Location = new System.Drawing.Point(3, 3);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(194, 45);
            this.colorGroupBox.TabIndex = 4;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // colorChangeButton
            // 
            this.colorChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorChangeButton.Location = new System.Drawing.Point(3, 23);
            this.colorChangeButton.Name = "colorChangeButton";
            this.colorChangeButton.Size = new System.Drawing.Size(188, 19);
            this.colorChangeButton.TabIndex = 0;
            this.colorChangeButton.Text = "Change color";
            this.colorChangeButton.UseVisualStyleBackColor = true;
            this.colorChangeButton.Click += new System.EventHandler(this.colorChangeButton_Click);
            // 
            // cameraGroupBox
            // 
            this.cameraGroupBox.Controls.Add(this.cameraTableLayoutPanel);
            this.cameraGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cameraGroupBox.Location = new System.Drawing.Point(3, 505);
            this.cameraGroupBox.Name = "cameraGroupBox";
            this.cameraGroupBox.Size = new System.Drawing.Size(194, 164);
            this.cameraGroupBox.TabIndex = 3;
            this.cameraGroupBox.TabStop = false;
            this.cameraGroupBox.Text = "Camera";
            // 
            // cameraTableLayoutPanel
            // 
            this.cameraTableLayoutPanel.ColumnCount = 1;
            this.cameraTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cameraTableLayoutPanel.Controls.Add(this.cameraTypeGroupBox, 0, 1);
            this.cameraTableLayoutPanel.Controls.Add(this.FOVGroupBox, 0, 0);
            this.cameraTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraTableLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.cameraTableLayoutPanel.Name = "cameraTableLayoutPanel";
            this.cameraTableLayoutPanel.RowCount = 2;
            this.cameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.cameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.cameraTableLayoutPanel.Size = new System.Drawing.Size(188, 135);
            this.cameraTableLayoutPanel.TabIndex = 0;
            // 
            // cameraTypeGroupBox
            // 
            this.cameraTypeGroupBox.Controls.Add(this.switchCameraButton);
            this.cameraTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraTypeGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cameraTypeGroupBox.Location = new System.Drawing.Point(3, 84);
            this.cameraTypeGroupBox.Name = "cameraTypeGroupBox";
            this.cameraTypeGroupBox.Size = new System.Drawing.Size(182, 48);
            this.cameraTypeGroupBox.TabIndex = 2;
            this.cameraTypeGroupBox.TabStop = false;
            this.cameraTypeGroupBox.Text = "Camera type";
            // 
            // switchCameraButton
            // 
            this.switchCameraButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switchCameraButton.Location = new System.Drawing.Point(3, 23);
            this.switchCameraButton.Name = "switchCameraButton";
            this.switchCameraButton.Size = new System.Drawing.Size(176, 22);
            this.switchCameraButton.TabIndex = 0;
            this.switchCameraButton.Text = "Switch";
            this.switchCameraButton.UseVisualStyleBackColor = true;
            this.switchCameraButton.Click += new System.EventHandler(this.switchCameraButton_Click);
            // 
            // FOVGroupBox
            // 
            this.FOVGroupBox.Controls.Add(this.FOVTableLayout);
            this.FOVGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FOVGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FOVGroupBox.Location = new System.Drawing.Point(3, 3);
            this.FOVGroupBox.Name = "FOVGroupBox";
            this.FOVGroupBox.Size = new System.Drawing.Size(182, 75);
            this.FOVGroupBox.TabIndex = 0;
            this.FOVGroupBox.TabStop = false;
            this.FOVGroupBox.Text = "FOV";
            // 
            // FOVTableLayout
            // 
            this.FOVTableLayout.ColumnCount = 2;
            this.FOVTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FOVTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FOVTableLayout.Controls.Add(this.FOVLabel, 0, 0);
            this.FOVTableLayout.Controls.Add(this.FOVValueLabel, 1, 0);
            this.FOVTableLayout.Controls.Add(this.FOVTrackBar, 0, 1);
            this.FOVTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FOVTableLayout.Location = new System.Drawing.Point(3, 23);
            this.FOVTableLayout.Name = "FOVTableLayout";
            this.FOVTableLayout.RowCount = 2;
            this.FOVTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FOVTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FOVTableLayout.Size = new System.Drawing.Size(176, 49);
            this.FOVTableLayout.TabIndex = 0;
            // 
            // FOVLabel
            // 
            this.FOVLabel.AutoSize = true;
            this.FOVLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FOVLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FOVLabel.Location = new System.Drawing.Point(3, 0);
            this.FOVLabel.Name = "FOVLabel";
            this.FOVLabel.Size = new System.Drawing.Size(82, 24);
            this.FOVLabel.TabIndex = 0;
            this.FOVLabel.Text = "FOV:";
            this.FOVLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FOVValueLabel
            // 
            this.FOVValueLabel.AutoSize = true;
            this.FOVValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FOVValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FOVValueLabel.Location = new System.Drawing.Point(91, 0);
            this.FOVValueLabel.Name = "FOVValueLabel";
            this.FOVValueLabel.Size = new System.Drawing.Size(82, 24);
            this.FOVValueLabel.TabIndex = 1;
            this.FOVValueLabel.Text = "75";
            this.FOVValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FOVTrackBar
            // 
            this.FOVTableLayout.SetColumnSpan(this.FOVTrackBar, 2);
            this.FOVTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FOVTrackBar.Location = new System.Drawing.Point(3, 27);
            this.FOVTrackBar.Maximum = 120;
            this.FOVTrackBar.Minimum = 75;
            this.FOVTrackBar.Name = "FOVTrackBar";
            this.FOVTrackBar.Size = new System.Drawing.Size(170, 19);
            this.FOVTrackBar.TabIndex = 2;
            this.FOVTrackBar.Value = 75;
            this.FOVTrackBar.Scroll += new System.EventHandler(this.FOVTrackBar_Scroll);
            // 
            // vibrationGroupBox
            // 
            this.vibrationGroupBox.Controls.Add(this.vibrationCheckBox);
            this.vibrationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vibrationGroupBox.Location = new System.Drawing.Point(3, 675);
            this.vibrationGroupBox.Name = "vibrationGroupBox";
            this.vibrationGroupBox.Size = new System.Drawing.Size(194, 36);
            this.vibrationGroupBox.TabIndex = 5;
            this.vibrationGroupBox.TabStop = false;
            this.vibrationGroupBox.Text = "Vibrations";
            // 
            // vibrationCheckBox
            // 
            this.vibrationCheckBox.AutoSize = true;
            this.vibrationCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vibrationCheckBox.Location = new System.Drawing.Point(3, 23);
            this.vibrationCheckBox.Name = "vibrationCheckBox";
            this.vibrationCheckBox.Size = new System.Drawing.Size(188, 10);
            this.vibrationCheckBox.TabIndex = 0;
            this.vibrationCheckBox.Text = "On/Off";
            this.vibrationCheckBox.UseVisualStyleBackColor = true;
            this.vibrationCheckBox.CheckedChanged += new System.EventHandler(this.vibrationCheckBox_CheckedChanged);
            // 
            // SpotlightGroupBox
            // 
            this.SpotlightGroupBox.Controls.Add(this.spotlightDirectionButton);
            this.SpotlightGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpotlightGroupBox.Location = new System.Drawing.Point(3, 717);
            this.SpotlightGroupBox.Name = "SpotlightGroupBox";
            this.SpotlightGroupBox.Size = new System.Drawing.Size(194, 45);
            this.SpotlightGroupBox.TabIndex = 6;
            this.SpotlightGroupBox.TabStop = false;
            this.SpotlightGroupBox.Text = "Spotlight ";
            // 
            // spotlightDirectionButton
            // 
            this.spotlightDirectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spotlightDirectionButton.Location = new System.Drawing.Point(3, 23);
            this.spotlightDirectionButton.Name = "spotlightDirectionButton";
            this.spotlightDirectionButton.Size = new System.Drawing.Size(188, 19);
            this.spotlightDirectionButton.TabIndex = 0;
            this.spotlightDirectionButton.Text = "Change direction";
            this.spotlightDirectionButton.UseVisualStyleBackColor = true;
            this.spotlightDirectionButton.Click += new System.EventHandler(this.spotlightDirectionButton_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.White;
            // 
            // lightColorDialog
            // 
            this.lightColorDialog.Color = System.Drawing.Color.White;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(194, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Picture";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(3, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(194, 64);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Constant";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 94);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(103, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 94);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 853);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Filling Triangle Mesh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.LambertModelGroupBox.ResumeLayout(false);
            this.LambertModelTableLayoutPanel.ResumeLayout(false);
            this.coefficientsGroupBox.ResumeLayout(false);
            this.coefficientsTableLayoutPanel.ResumeLayout(false);
            this.coefficientsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).EndInit();
            this.triangleMeshGroupBox.ResumeLayout(false);
            this.triangleMeshTableLayoutPanel.ResumeLayout(false);
            this.triangleMeshTableLayoutPanel.PerformLayout();
            this.shadingGroupBox.ResumeLayout(false);
            this.shadingTableLayoutPanel.ResumeLayout(false);
            this.shadingTableLayoutPanel.PerformLayout();
            this.lightGroupBox.ResumeLayout(false);
            this.lightTableLayoutPanel.ResumeLayout(false);
            this.animationGroupBox.ResumeLayout(false);
            this.animationTableLayoutPanel.ResumeLayout(false);
            this.colorGroupBox.ResumeLayout(false);
            this.cameraGroupBox.ResumeLayout(false);
            this.cameraTableLayoutPanel.ResumeLayout(false);
            this.cameraTypeGroupBox.ResumeLayout(false);
            this.FOVGroupBox.ResumeLayout(false);
            this.FOVTableLayout.ResumeLayout(false);
            this.FOVTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOVTrackBar)).EndInit();
            this.vibrationGroupBox.ResumeLayout(false);
            this.vibrationGroupBox.PerformLayout();
            this.SpotlightGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox LambertModelGroupBox;
        private System.Windows.Forms.GroupBox lightGroupBox;
        private System.Windows.Forms.TableLayoutPanel LambertModelTableLayoutPanel;
        private System.Windows.Forms.GroupBox coefficientsGroupBox;
        private System.Windows.Forms.TableLayoutPanel coefficientsTableLayoutPanel;
        private System.Windows.Forms.Label kdLabel;
        private System.Windows.Forms.Label ksLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.TrackBar kdTrackBar;
        private System.Windows.Forms.Label ksValueLabel;
        private System.Windows.Forms.Label kdValueLabel;
        private System.Windows.Forms.Label mValueLabel;
        private System.Windows.Forms.TrackBar ksTrackBar;
        private System.Windows.Forms.TrackBar mTrackBar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TableLayoutPanel lightTableLayoutPanel;
        private System.Windows.Forms.GroupBox animationGroupBox;
        private System.Windows.Forms.TableLayoutPanel animationTableLayoutPanel;
        private System.Windows.Forms.Button changeLightColorButton;
        private System.Windows.Forms.ColorDialog lightColorDialog;
        private System.Windows.Forms.GroupBox triangleMeshGroupBox;
        private System.Windows.Forms.TableLayoutPanel triangleMeshTableLayoutPanel;
        private System.Windows.Forms.CheckBox showTriangleMeshCheckBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.Button colorChangeButton;
        private System.Windows.Forms.GroupBox cameraGroupBox;
        private System.Windows.Forms.TableLayoutPanel cameraTableLayoutPanel;
        private System.Windows.Forms.GroupBox FOVGroupBox;
        private System.Windows.Forms.TableLayoutPanel FOVTableLayout;
        private System.Windows.Forms.Label FOVLabel;
        private System.Windows.Forms.Label FOVValueLabel;
        private System.Windows.Forms.TrackBar FOVTrackBar;
        private System.Windows.Forms.GroupBox cameraTypeGroupBox;
        private System.Windows.Forms.GroupBox shadingGroupBox;
        private System.Windows.Forms.TableLayoutPanel shadingTableLayoutPanel;
        private System.Windows.Forms.RadioButton constantShadingRadioButton;
        private System.Windows.Forms.RadioButton PhongShadingRadioButton;
        private System.Windows.Forms.RadioButton GouraudShadingRadioButton;
        private System.Windows.Forms.Button switchCameraButton;
        private System.Windows.Forms.Button startAnimationButton;
        private System.Windows.Forms.Button stopAnimationButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox vibrationGroupBox;
        private System.Windows.Forms.CheckBox vibrationCheckBox;
        private System.Windows.Forms.GroupBox SpotlightGroupBox;
        private System.Windows.Forms.Button spotlightDirectionButton;
    }
}


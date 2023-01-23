using NetTopologySuite.Mathematics;
using ObjLoader.Loader.Loaders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Media.Imaging;

namespace FillingTriangleMesh
{
    public partial class MainWindow : Form
    {
        private Filling filling;

        // Default obj file
        private const string defaultPlanePath = "..\\..\\..\\Resources\\Plane.obj";
        private const string defaultSpherePath = "..\\..\\..\\Resources\\sphere.obj";
        private const string defaultCloud1Path = "..\\..\\..\\Resources\\cloud.obj";

        private int planeSizeUnit = 3;
        private int staticObjectSizeUnit = 5;
        private (int x, int y, int z) planeShift = (-600, 150, 0);
        private (int x, int y, int z) sphereShift = (320, -300, 300);
        private (int x, int y, int z) cloud1Shift = (-300, -300, -200);
        private (int x, int y, int z) cloud2Shift = (-500, 0, -100);
        private (int x, int y, int z) cloud3Shift = (-200, 0, 100);

        public MainWindow()
        {
            InitializeComponent();

            // Initialize button's text
            startAnimationButton.Text = "\u25B6";
            stopAnimationButton.Text = "\u2B24";

            // Initialize pictureBox
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

            // Load obj files
            var planeObjData = loadObj(defaultPlanePath);
            var sphereObjData = loadObj(defaultSpherePath);
            var cloud1ObjData = loadObj(defaultCloud1Path);

            // Initialize filling object
            LambertModel lambertModel = new LambertModel( (double) kdTrackBar.Value / 100 , (double) ksTrackBar.Value / 100, 
                (double) mTrackBar.Value);
            TriangleMesh planeTriangleMesh = new TriangleMesh(pictureBox.Width, pictureBox.Height, planeObjData, planeSizeUnit);
            TriangleMesh sphereTriangleMesh = new TriangleMesh(pictureBox.Width, pictureBox.Height, sphereObjData, staticObjectSizeUnit, sphereShift.x, sphereShift.y, sphereShift.z);
            TriangleMesh cloud1TriangleMesh = new TriangleMesh(pictureBox.Width, pictureBox.Height, cloud1ObjData, staticObjectSizeUnit, cloud1Shift.x, cloud1Shift.y, cloud1Shift.z);
            TriangleMesh cloud2TriangleMesh = new TriangleMesh(pictureBox.Width, pictureBox.Height, cloud1ObjData, staticObjectSizeUnit, cloud2Shift.x, cloud2Shift.y, cloud2Shift.z);
            TriangleMesh cloud3TriangleMesh = new TriangleMesh(pictureBox.Width, pictureBox.Height, cloud1ObjData, staticObjectSizeUnit, cloud3Shift.x, cloud3Shift.y, cloud3Shift.z);
            filling = new Filling(lambertModel, planeTriangleMesh, sphereTriangleMesh, cloud1TriangleMesh,
                cloud2TriangleMesh, cloud3TriangleMesh, pictureBox);
            filling.transformStaticObjects();

            // draw
            redraw();
        }

        private LoadResult loadObj(string path)
        {
            var objLoaderFactory = new ObjLoaderFactory();
            var objLoader = objLoaderFactory.Create();
            var fileStream = new FileStream(path, FileMode.Open);
            var objData = objLoader.Load(fileStream);
            fileStream.Close();
            return objData;
        }

        // Events

        private void kdTrackBar_Scroll(object sender, EventArgs e)
        {
            filling.lambertModel.kd = (double) kdTrackBar.Value / 100;
            kdValueLabel.Text = filling.lambertModel.kd.ToString();
        }

        private void ksTrackBar_Scroll(object sender, EventArgs e)
        {
            filling.lambertModel.ks = (double) ksTrackBar.Value / 100;
            ksValueLabel.Text = filling.lambertModel.ks.ToString();
        }

        private void mTrackBar_Scroll(object sender, EventArgs e)
        {
            filling.lambertModel.m = (double)mTrackBar.Value;
            mValueLabel.Text = filling.lambertModel.m.ToString();
        }

        private void changeLightColorButton_Click(object sender, EventArgs e)
        {
            lightColorDialog.ShowDialog();
            filling.lambertModel.lightColor = lightColorDialog.Color;
            redraw();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (showTriangleMeshCheckBox.Checked)
                filling.drawMesh(pictureBox);
        }

        private void showTriangleMeshCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            redraw();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            // Create triangle mesh
            loadMeshes();

            filling.transformStaticObjects();
            // redrawing
            redraw();
        }

        private void loadMeshes()
        {
            filling.planeTriangleMesh = new TriangleMesh(pictureBox.Width, pictureBox.Height, loadObj(defaultPlanePath), planeSizeUnit, planeShift.x, planeShift.y);
            filling.sphereTriangleMesh = new TriangleMesh(pictureBox.Width, pictureBox.Height, loadObj(defaultSpherePath), staticObjectSizeUnit, sphereShift.x, sphereShift.y, sphereShift.z);
            filling.cloud1TriangleMesh = new TriangleMesh(pictureBox.Width, pictureBox.Height, loadObj(defaultCloud1Path), staticObjectSizeUnit, cloud1Shift.x, cloud1Shift.y, cloud1Shift.z);
            filling.cloud2TriangleMesh = new TriangleMesh(pictureBox.Width, pictureBox.Height, loadObj(defaultCloud1Path), staticObjectSizeUnit, cloud2Shift.x, cloud2Shift.y, cloud2Shift.z);
            filling.cloud3TriangleMesh = new TriangleMesh(pictureBox.Width, pictureBox.Height, loadObj(defaultCloud1Path), staticObjectSizeUnit, cloud3Shift.x, cloud3Shift.y, cloud3Shift.z);
        }

        private void kdTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            redraw();
        }

        private void ksTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            redraw();
        }

        private void mTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            redraw();
        }

        private void z_positionTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            redraw();
        }

        private void redraw()
        {
            filling.redraw(pictureBox);
            if(showTriangleMeshCheckBox.Checked)
                filling.drawMesh(pictureBox);
            pictureBox.Refresh();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!filling.animation.end())
            {
                filling.animation.moveObject(filling.planeTriangleMesh.triangles);
                filling.moveCameraTarget();
                redraw();
            }
            else
            {
                timer.Stop();
                filling.planeAngleY = 0;
                loadMeshes();
                filling.animation = new Animation();
                if (vibrationCheckBox.Checked)
                    filling.animation.vibrations = true;
                MessageBox.Show("Animation ended!");
            }
        }

        private void startAnimationButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            filling.animation.isPlaying = true;
        }

        private void stopAnimationButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void colorChangeButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            filling.lambertModel.objectColor = colorDialog.Color;
            redraw();
        }

        private void FOVTrackBar_Scroll(object sender, EventArgs e)
        {
            FOVValueLabel.Text = FOVTrackBar.Value.ToString();
            filling.FOV = FOVTrackBar.Value;
            filling.transformStaticObjects();
            redraw();
        }

        private void constantShadingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            filling.shading = Filling.Shading.Constant;
            redraw();
        }

        private void PhongShadingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            filling.shading = Filling.Shading.Phong;
            redraw();
        }

        private void GouraudShadingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            filling.shading = Filling.Shading.Gouraud;
            redraw();
        }

        private void switchCameraButton_Click(object sender, EventArgs e)
        {
            filling.switchCameraType();
            redraw();
        }

        private void vibrationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vibrationCheckBox.Checked)
                filling.turnOnVibrations();
            else
                filling.turnOffVibrations();
        }
    }
}

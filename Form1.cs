using Compunet.YoloSharp;
using Compunet.YoloSharp.Data;
using Compunet.YoloSharp.Metadata;
using Compunet.YoloSharp.Plotting;
using SixLabors.ImageSharp;
using System.Diagnostics;
using System.Windows.Forms;
using Clipper2Lib;
using YoloMainApp;
using ImageInfo = YoloMainApp.ImageInfo;
using Image = System.Drawing.Image;

namespace YoloFormsApp
{
    public partial class Yolo : Form
    {
        YoloPredictor predictor;
        
        private object plotted;

        public Yolo()
        {
            InitializeComponent();

            this.menuStrip1.Visible = false;

            var imageInfos = new DirectoryImageReader().Analyze(@".\images");
            this.dataGridViewFiles.DataSource = imageInfos.ToList();
        }

        private ImageInfo GetCurrentImage()
        {
            var item = this.dataGridViewFiles.CurrentRow?.DataBoundItem as ImageInfo;
            return item;
        }
        private void DetectSelectedImage()
        {
            //var items = this.Detect();
            //this.dataGridViewResult.DataSource = items;
            //this.DrawBoundingBoxes(items);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Model_Case = 0;
            List<YoloItem> items = new List<YoloItem>();

            // Load the YOLO predictor
            if (!string.IsNullOrEmpty(tb_model_path.Text) && tb_model_path.Text== "yolo11n-pose.onnx")  
            {
                predictor = new YoloPredictor(tb_model_path.Text);
                Model_Case = 1;
            }
            else if (!string.IsNullOrEmpty(tb_model_path.Text) && tb_model_path.Text == "yolo11n-seg.onnx")  
            {
                predictor = new YoloPredictor(tb_model_path.Text);
                Model_Case = 2;
            }
            else if (!string.IsNullOrEmpty(tb_model_path.Text) && tb_model_path.Text == "yolo11n-obb.onnx")  
            {
                predictor = new YoloPredictor(tb_model_path.Text);
                Model_Case = 3;
            }
            else if (!string.IsNullOrEmpty(tb_model_path.Text) && tb_model_path.Text == "yolo11n-cls.onnx") 
            {
                predictor = new YoloPredictor(tb_model_path.Text);
                Model_Case = 4;
            }
            else
            {
                predictor = new YoloPredictor("yolo11n.onnx");
                Model_Case = 0;
            }


            //using var predictor = new YoloPredictor("Multitask_ADAS.onnx");
            // Load the target image

            if (this.pictureBox2.Image != null)
            {
                this.pictureBox2.Image.Dispose();
                this.pictureBox2.Image = null;
            }

            var imageInfo = this.GetCurrentImage();//imageInfo.Path
            using var image = SixLabors.ImageSharp.Image.Load(imageInfo.Path);
            
            if (Model_Case == 0)
            {
                var result = predictor.Detect(image);
                this.groupBoxResult.Text = $"Result [ {result.Speed:0} ms ]";

                foreach (var pred in result)
                {
                    var yoloItem = new YoloItem();
                    var originalImageHeight = image.Height;
                    var originalImageWidth = image.Width;

                    var x = Math.Max(pred.Bounds.X, 0);
                    var y = Math.Max(pred.Bounds.Y, 0);
                    var width = Math.Min(originalImageWidth - x, pred.Bounds.Width);
                    var height = Math.Min(originalImageHeight - y, pred.Bounds.Height);

                    yoloItem.Type = pred.Name.Name.ToString();
                    yoloItem.Confidence = Math.Round(pred.Confidence, 3);
                    yoloItem.X = x;
                    yoloItem.Y = y;
                    yoloItem.Width = width;
                    yoloItem.Height = height;

                    items.Add(yoloItem);

                    Debug.WriteLine("====================");
                    Debug.WriteLine(pred.Name);
                    Debug.WriteLine(pred.Confidence);
                    Debug.WriteLine(pred.Bounds);
                }
                // Create plotted image from model results
                //using var plotted = await result.PlotImageAsync(image);
                using var plotted = result.PlotImage(image);
                plotted.Save(imageInfo.Name);
            }
            else if (Model_Case == 1)
            {
                var result = predictor.Pose(image);
                foreach (var pred in result)
                {
                    var yoloItem = new YoloItem();
                    var originalImageHeight = image.Height;
                    var originalImageWidth = image.Width;

                    var x = Math.Max(pred.Bounds.X, 0);
                    var y = Math.Max(pred.Bounds.Y, 0);
                    var width = Math.Min(originalImageWidth - x, pred.Bounds.Width);
                    var height = Math.Min(originalImageHeight - y, pred.Bounds.Height);

                    yoloItem.Type = pred.Name.ToString();
                    yoloItem.Confidence = Math.Round(pred.Confidence, 3);
                    yoloItem.X = x;
                    yoloItem.Y = y;
                    yoloItem.Width = width;
                    yoloItem.Height = height;

                    items.Add(yoloItem);

                    Debug.WriteLine("====================");
                    Debug.WriteLine(pred.Name);
                    Debug.WriteLine(pred.Confidence);
                    Debug.WriteLine(pred.Bounds);
                }
                // Create plotted image from model results
                using var plotted = result.PlotImage(image);
                plotted.Save(imageInfo.Name);
            }
            else if (Model_Case == 2)
            {
                var result = predictor.Segment(image);
                foreach (var pred in result)
                {
                    var yoloItem = new YoloItem();
                    var originalImageHeight = image.Height;
                    var originalImageWidth = image.Width;

                    var x = Math.Max(pred.Bounds.X, 0);
                    var y = Math.Max(pred.Bounds.Y, 0);
                    var width = Math.Min(originalImageWidth - x, pred.Bounds.Width);
                    var height = Math.Min(originalImageHeight - y, pred.Bounds.Height);

                    //yoloItem.Type = pred.Name.ToString();
                    yoloItem.Type = pred.Name.Name.ToString();
                    yoloItem.Confidence = Math.Round(pred.Confidence, 3);
                    yoloItem.X = x;
                    yoloItem.Y = y;
                    yoloItem.Width = width;
                    yoloItem.Height = height;

                    items.Add(yoloItem);

                    Debug.WriteLine("====================");
                    Debug.WriteLine(pred.Name.Name);
                    Debug.WriteLine(pred.Confidence);
                    Debug.WriteLine(pred.Bounds);
                }
                // Create plotted image from model results
    
                using var plotted = result.PlotImage(image);
                plotted.Save(imageInfo.Name);
            }
            else if (Model_Case == 3)
            {
                var result = predictor.DetectObb(image);
                foreach (var pred in result)
                {
                    var yoloItem = new YoloItem();
                    var originalImageHeight = image.Height;
                    var originalImageWidth = image.Width;

                    var x = Math.Max(pred.Bounds.X, 0);
                    var y = Math.Max(pred.Bounds.Y, 0);
                    var width = Math.Min(originalImageWidth - x, pred.Bounds.Width);
                    var height = Math.Min(originalImageHeight - y, pred.Bounds.Height);

                    yoloItem.Type = pred.Name.ToString();
                    yoloItem.Confidence = Math.Round(pred.Confidence, 3);
                    yoloItem.X = x;
                    yoloItem.Y = y;
                    yoloItem.Width = width;
                    yoloItem.Height = height;

                    items.Add(yoloItem);

                    Debug.WriteLine("====================");
                    Debug.WriteLine(pred.Name);
                    Debug.WriteLine(pred.Confidence);
                    Debug.WriteLine(pred.Bounds);
                }
                // Create plotted image from model results
           
                using var plotted = result.PlotImage(image);
                plotted.Save(imageInfo.Name);
            }
            else if (Model_Case == 4)
            {
                var result = predictor.Classify(image);
                
                this.groupBoxResult.Text = $"Result [ processed in {result.Speed:0} ms ]";

                foreach (var pred in result)
                {
                    var yoloItem = new YoloItem();
                    var originalImageHeight = image.Height;
                    var originalImageWidth = image.Width;                 

                    yoloItem.Type = pred.Name.ToString();
                    yoloItem.Confidence = Math.Round(pred.Confidence, 3);

                    items.Add(yoloItem);

                    Debug.WriteLine("====================");
                    Debug.WriteLine(pred.Name);
                    Debug.WriteLine(pred.Confidence);
                    //Debug.WriteLine(pred.Bounds);
                }
                // Create plotted image from model results
                //using var plotted = await result.PlotImageAsync(image);
                using var plotted = result.PlotImage(image);
                plotted.Save(imageInfo.Name);
            }



            
            this.dataGridViewResult.DataSource = items.ToList();
            // Write the plotted image to file
            this.pictureBox2.Image = Image.FromFile(imageInfo.Name);
        }

        private void dataGridViewFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.DetectSelectedImage();
            }
        }

        private void dataGridViewFiles_SelectionChanged(object sender, EventArgs e)
        {
            var oldImage = this.pictureBox1.Image;
            var imageInfo = this.GetCurrentImage();
            this.pictureBox1.Image = Image.FromFile(imageInfo.Path);
            oldImage?.Dispose();

            this.groupBoxResult.Text = " ";

            if (this.pictureBox2.Image != null)
            {
                this.pictureBox2.Image.Dispose();
                this.pictureBox2.Image = null;
            }

            this.dataGridViewResult.DataSource = null;
            this.dataGridViewResult.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridViewFiles.DataSource = null;
            this.dataGridViewFiles.Refresh();


            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var imageInfos = new DirectoryImageReader().Analyze(folderBrowserDialog1.SelectedPath);

            DirectoryInfo folder = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            this.textBox1.Text = folderBrowserDialog1.SelectedPath;
            //textBox1.Text =folder.Name;

            this.dataGridViewFiles.DataSource = imageInfos.ToList();
        }

        private void btn_model_select_Click(object sender, EventArgs e)
        {
            if (this.pictureBox2.Image != null)
            {
                this.pictureBox2.Image.Dispose();
                this.pictureBox2.Image = null;
            }

            OpenFileDialog opdlg = new OpenFileDialog();
            opdlg.Filter = "ONNX files (*.ONNX,*.onnx)|*.ONNX;*.onnx | All files(*.*) | *.*";
            opdlg.InitialDirectory = @".\images";

            if (opdlg.ShowDialog() == DialogResult.OK)
            {
                string csvPath = opdlg.FileName;                
                tb_model_path.Text = opdlg.SafeFileName;
            }
        }
    }
}

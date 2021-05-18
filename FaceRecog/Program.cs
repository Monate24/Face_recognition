using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;

namespace FaceRecog
{
	public partial class btnCapture : Form {

		private Capture videoCapture = null;
		private Image<Bgr, Byte> currentFrame = null;
	    Mat frame = new Mat(0);

#endregion

		public btnCapture() {
			InitializeComponent();
		}

		private void btnCapture_Click(object sender, EventArgs e) {
			videoCapture = new Capture();
			videoCapture.ImageGrabbed += ProcessFrame;
			videoCapture.Start();
		}

		private void ProcessFrame(object sender, EventArgs e) {
			Step 1 : video capture
				videoCapture.Retrieve(frame, 0);
			currentFrame = frame.ToImage<Bgr,Byte>().Resize(picCapture.Width,picCapture.Height, Inter.Cubic)

				Step 2 : render the video capture into the picture box
				picCapture.Image = currentFrame.Bitmap; 
			throw new NotImplementedException();
		}
	}
}
















		/*
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
*/
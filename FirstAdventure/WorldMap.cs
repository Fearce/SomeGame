using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FirstAdventure
{
    public partial class WorldMap : Form
    {
        readonly Assembly _thisAssembly = Assembly.GetExecutingAssembly();

        public WorldMap()
        {
            InitializeComponent();
            SetImage(pic_0_1, "BloodMoor");
            SetImage(pic_0_2, "BloodMoor");
            SetImage(pic_1_1, "BloodMoor");
            SetImage(pic_1_2, "BloodMoor");
            SetImage(pic_1_3, "BloodMoor");
            SetImage(pic_2_1, "BloodMoor");
            SetImage(pic_2_2, "BloodMoor");
            SetImage(pic_2_3, "BloodMoor");
            SetImage(pic_3_1, "BloodMoor");
            SetImage(pic_3_2, "BloodMoor");
            SetImage(pic_3_3, "BloodMoor");
            SetImage(pic_4_2, "Home");


        }

        private void SetImage(PictureBox pictureBox, string imageName)
        {
            using (Stream resourceStream =
                _thisAssembly.GetManifestResourceStream(
                    _thisAssembly.GetName().Name + ".Images." + imageName + ".jpg"))
            {
                if (resourceStream != null)
                {
                    pictureBox.Image = new Bitmap(resourceStream);
                }
            }
        }
    }
}
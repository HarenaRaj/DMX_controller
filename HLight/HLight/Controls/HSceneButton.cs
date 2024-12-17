using HLight.Models;
using System.Windows.Forms;

namespace HLight.Controls
{
    public partial class HSceneButton : MetroFramework.Controls.MetroButton
    {
        public Scene Scene { get; set; }
        public HSceneButton()
        {
            this.Size = new System.Drawing.Size(20, 20);
            this.TabIndex = 1;
            this.UseSelectable = true;
        }
    }
}

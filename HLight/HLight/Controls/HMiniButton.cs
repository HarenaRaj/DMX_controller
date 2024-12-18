using HLight.Models;
using System.Windows.Forms;

namespace HLight.Controls
{
    public partial class HMiniButton : MetroFramework.Controls.MetroButton
    {
        public HMiniButton()
        {
            this.Size = new System.Drawing.Size(20, 20);
            this.TabIndex = 1;
            this.UseSelectable = true;
        }
    }
}

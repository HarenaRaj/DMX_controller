using HLight.Models;

namespace HLight.Controls
{
    public partial class HAnimationButton : HMiniButton
    {
        public Animation Animation { get; set; }
        public HAnimationButton()
        {
            this.Size = new System.Drawing.Size(20, 20);
            this.TabIndex = 1;
            this.UseSelectable = true;
        }
    }
}

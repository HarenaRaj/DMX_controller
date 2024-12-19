namespace HLight.Controls
{
    public partial class HLedLabel : MetroFramework.Controls.MetroLabel
    {
        public HLedControl LedControl { get; set; }
        public HLedLabel()
        {
            this.UseSelectable = true;
            this.AutoSize = true;
            this.FontSize = MetroFramework.MetroLabelSize.Small;
            this.TabIndex = 4;
            this.UseCustomBackColor = true;
        }
    }
}

namespace LaraServe.Components
{
    public class CustomToolStrip : System.Windows.Forms.ToolStrip
    {
        public CustomToolStrip()
        {
            this.Renderer = new ToolStripRenderder();
        }
    }

    internal class ToolStripRenderder : System.Windows.Forms.ToolStripSystemRenderer
    {
        protected override void OnRenderToolStripBorder(System.Windows.Forms.ToolStripRenderEventArgs e)
        {
            // do not render border
            //base.OnRenderToolStripBorder(e);
        }

        protected override void OnRenderButtonBackground(System.Windows.Forms.ToolStripItemRenderEventArgs e)
        {
            // do not render button backgroud
            //base.OnRenderButtonBackground(e);
        }
    }
}

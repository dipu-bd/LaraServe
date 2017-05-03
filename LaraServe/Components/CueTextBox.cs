using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LaraServe.Helper;

namespace LaraServe.Components
{
    class CueTextBox : System.Windows.Forms.TextBox
    {
        private string mCue;

        [Localizable(true)]
        public string Cue
        {
            get { return mCue; }
            set { mCue = value; updateCue(); }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            updateCue();
        }

        private void updateCue()
        {
            if (this.IsHandleCreated && mCue != null)
            {
                WinAPI.SendMessage(this.Handle, 0x1501, 1, mCue);
            }
        }
    }
}

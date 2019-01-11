using System;
using System.Windows.Forms;

namespace Ctrl_f_u {
    public partial class Form1 : Form {

        KeyboardHook hook = new KeyboardHook();

        public Form1() {
            InitializeComponent();

            // register the event that is fired after the key press.
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(Ctrl_f_u.ModifierKeys.Control, Keys.U);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e) {
            // show the keys pressed in a label.
            MessageBox.Show("Jazz killed Danny again *sigh*", "Team kill report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

using System;
using System.Windows.Forms;

namespace Puerto_Serie_Arduino {
    public static class Program {
        /// <summary>
        /// Método Main.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interfaz());
        }
    }
}

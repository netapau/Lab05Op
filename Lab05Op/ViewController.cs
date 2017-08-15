using System;
using System.Collections.Generic;
using UIKit;

namespace Lab05Op
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Después de cargar la vista 
            // recuperamos los botones en un array
            // iteramos para añadir los manejadores de evento.
            UIButton[] Botones = new UIButton[] { Btn_zero, Btn_1, Btn_2, Btn_3, Btn_4, Btn_5, Btn_6, Btn_7, Btn_8, Btn_9 };

            foreach (var item in Botones)
            {
                item.TouchUpInside += (object sender, EventArgs e) =>
                {
                    LblAffichage.Text = (LblAffichage.Text == "0")? (LblAffichage.Text + item.TitleLabel.Text).Substring(1) : LblAffichage.Text + item.TitleLabel.Text;
                };
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
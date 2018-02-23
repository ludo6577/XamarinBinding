using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using UIKit;
using XamarinBindingLibrary;


namespace SampleUsing
{
    public partial class ViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            lblText.Text = "Start";
            try
            {
                var _instance = XamarinBindingLibrary.ATInternet.SharedInstance;
                //var _tracker = _instance.DefaultTracker;
            }
            catch (Exception ex)
            {
                lblText.Text = ex.ToString();
            }
        }
    }
}


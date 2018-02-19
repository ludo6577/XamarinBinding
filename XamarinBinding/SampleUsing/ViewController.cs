using System;
using UIKit;

namespace SampleUsing
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle) {}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

		    var _instance = XamarinBindingLibrary.ATInternet.SharedInstance();
		    //var _tracker = _instance.DefaultTracker; // <<== DefaultTracker is always null
        }
    }
}


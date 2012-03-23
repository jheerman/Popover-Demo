using MonoTouch.UIKit;
using System.Drawing;
using System;
using MonoTouch.Foundation;

namespace PopoverDemo
{
	public partial class PopoverDetailController : UIViewController
	{
		public PopoverDetailController () : base ("PopoverDetailController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			//any additional setup after loading the view, typically from a nib.
			base.ViewDidUnload ();
			var label = new UILabel(new RectangleF(25f, 25f, 150f, 25f));
			label.Text = "This is a popover";
			label.TextAlignment = UITextAlignment.Center;
			View.AddSubview (label);
			
			var button = UIButton.FromType (UIButtonType.RoundedRect);
			button.Frame = new RectangleF(25f, 75f, 150f, 50f);
			button.SetTitle ("Ok", UIControlState.Normal);
			View.AddSubview (button);
		}
		
		public override void ViewDidUnload ()
		{
			// Release any retained subviews of the main view.
			// e.g. this.myOutlet = null;
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return true;
		}
	}
}


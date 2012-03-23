using MonoTouch.UIKit;
using System.Drawing;
using System;
using MonoTouch.Foundation;

namespace PopoverDemo
{
	public partial class PopoverDemoViewController : UIViewController
	{
		PopoverDetailController _contentController; 
		UIPopoverController _popUp;
		
		public PopoverDemoViewController () : base ("PopoverDemoViewController", null)
		{
			_contentController = new PopoverDetailController();
			_contentController.ButtonClicked += (sender, e) => { _popUp.Dismiss (true); };
			_popUp = new UIPopoverController(_contentController);
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
			cmdPop1.TouchUpInside += (sender, e) => { ShowPopover(cmdPop1); };
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Release any retained subviews of the main view.
			// e.g. this.myOutlet = null;
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return true;
		}
		
		private void ShowPopover(UIButton cmd)
		{
			_popUp.PopoverContentSize = new SizeF(250f, 250f);
			_popUp.PresentFromRect (cmd.Frame, View, UIPopoverArrowDirection.Up, true);
		}
		
		partial void cmdPop1_TouchUpInside (MonoTouch.Foundation.NSObject sender)
		{ }
	}
}

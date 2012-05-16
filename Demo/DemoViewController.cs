using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Demo
{
	public partial class DemoViewController : UIViewController
	{
		public DemoViewController (string nibName, NSBundle bundle) : base (nibName, bundle)
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
			//navigation
			NavigationItem.RightBarButtonItem = new UIBarButtonItem("Menu",UIBarButtonItemStyle.Plain, MenuSelected);
			NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;
			//menuView
			viewMenu.BackgroundColor = UIColor.Clear;
			viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);
			btnClearSearch.SetBackgroundImage(UIImage.FromFile("image/btn_clearsearches.png"),UIControlState.Normal);
			btnClearFavorite.SetBackgroundImage(UIImage.FromFile("image/btn_clearfavorites.png"),UIControlState.Normal);
			btnAbout.SetBackgroundImage(UIImage.FromFile("image/btn_about.png"),UIControlState.Normal);
			btnRefreshNew.SetBackgroundImage(UIImage.FromFile("image/btn_refreshnews.png"),UIControlState.Normal);
			btnSearch.SetBackgroundImage(UIImage.FromFile("image/btn_search.png"),UIControlState.Normal);
			btnSetting.SetBackgroundImage(UIImage.FromFile("image/btn_settings.png"),UIControlState.Normal);
			
			//three button search,save and news
			imageLogo.Image = UIImage.FromFile("image/main_logo.png");
			View.BackgroundColor = UIColor.Black;
			btnRecent.SetTitle("Recent Searches", UIControlState.Normal);
			btnRecent.SetBackgroundImage(UIImage.FromFile("image/btn_back.png"),UIControlState.Normal);
			btnRecent.SetTitleColor(UIColor.Black,UIControlState.Normal);
			btnRecent.Font = UIFont.SystemFontOfSize(14.0f);
			btnSaveFavorites.SetTitle("Saved Favorites",UIControlState.Normal);
			btnSaveFavorites.SetBackgroundImage(UIImage.FromFile("image/btn_back.png"),UIControlState.Normal);
			btnSaveFavorites.SetTitleColor(UIColor.Black,UIControlState.Normal);
			btnSaveFavorites.Font = UIFont.SystemFontOfSize(14.0f);
			btnNews.SetTitle("News",UIControlState.Normal);
			btnNews.SetBackgroundImage(UIImage.FromFile("image/btn_back.png"),UIControlState.Normal);
			btnNews.SetTitleColor(UIColor.Black,UIControlState.Normal);
			btnNews.Font = UIFont.SystemFontOfSize(14.0f);

			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		//menu selected
		private void MenuSelected(Object o, EventArgs args)
		{
			if(viewMenu.Frame == new System.Drawing.RectangleF(0f,260f,320f,140f))
			{
				viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);
			}
			else
			{
				viewMenu.Frame = new System.Drawing.RectangleF(0f,260f,320f,140f);
			}
			Console.WriteLine("menu selected");
		}
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
		partial void btnRecentClicked (MonoTouch.Foundation.NSObject sender)
		{
			if(viewMenu.Frame == new System.Drawing.RectangleF(0f,260f,320f,140f))
			{
				viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);
			}
			else
			{
			if(btnSaveFavorites.Frame == new System.Drawing.RectangleF(25f, 126f, 275f, 37f) && btnNews.Frame == new System.Drawing.RectangleF(25f,171f,275f,37f))
			{
				btnSaveFavorites.Frame = new System.Drawing.RectangleF(25f, 315f, 275f, 37f);
				btnNews.Frame = new System.Drawing.RectangleF(25f,361f,275f,37f);
			}
			}
		}
		partial void btnSaveFavoritesClicked (MonoTouch.Foundation.NSObject sender)
		{
			if(viewMenu.Frame == new System.Drawing.RectangleF(0f,260f,320f,140f))
			{
				viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);
			}
			else
			{
			if(btnNews.Frame== new System.Drawing.RectangleF(25f,171f,275f,37f))
			{
				btnNews.Frame =new System.Drawing.RectangleF(25f,361f,275f,37f);
			}
			if(btnSaveFavorites.Frame == new System.Drawing.RectangleF(25f, 315f, 275f, 37f))
			{
				btnSaveFavorites.Frame = new System.Drawing.RectangleF(25f, 126f, 275f, 37f);
			}
			}
		}
		partial void btnNewsClicked (MonoTouch.Foundation.NSObject sender)
		{
			if(viewMenu.Frame == new System.Drawing.RectangleF(0f,260f,320f,140f))
			{
				viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);
			}
			else
			{
			if(btnNews.Frame== new System.Drawing.RectangleF(25f,361f,275f,37f) && btnSaveFavorites.Frame != new System.Drawing.RectangleF(25f, 315f, 275f, 37f))
			{
				btnNews.Frame = new System.Drawing.RectangleF(25f,171f,275f,37f);
			}
			if(btnNews.Frame== new System.Drawing.RectangleF(25f,361f,275f,37f) && btnSaveFavorites.Frame == new System.Drawing.RectangleF(25f, 315f, 275f, 37f) )
			{
				btnNews.Frame = new System.Drawing.RectangleF(25f,171f,275f,37f);
				btnSaveFavorites.Frame = new System.Drawing.RectangleF(25f,126f,275f,37f);
			}
			}
		}
		partial void btnClearSearchClicked (MonoTouch.Foundation.NSObject sender)
		{
			viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);

		}
		partial void btnClearFavoriteClicked (MonoTouch.Foundation.NSObject sender)
		{
			viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);
		}
		partial void btnRefreshNewClicked (MonoTouch.Foundation.NSObject sender)
		{
			viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);
		}
		
		AboutViewController aboutViewControll;
		partial void btnAboutClicked (MonoTouch.Foundation.NSObject sender)
		{
			if(aboutViewControll == null)
				aboutViewControll = new AboutViewController("AboutViewController",null);
			NavigationController.PushViewController(aboutViewControll,true);
			viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);
			
		}
		
		SettingsViewController settingViewController;
		partial void btnSettingClicked (MonoTouch.Foundation.NSObject sender)
		{
			if(settingViewController == null)
				settingViewController = new SettingsViewController("SettingsViewController",null);
			NavigationController.PushViewController(settingViewController,true);
			viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);
		}
		partial void btnSearchClicked (MonoTouch.Foundation.NSObject sender)
		{
			viewMenu.Frame = new System.Drawing.RectangleF(0f,480f,320f,140f);
		}
		
	}
}


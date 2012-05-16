// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Demo
{
	[Register ("DemoViewController")]
	partial class DemoViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIView viewMenu { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView imageLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnRecent { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnSaveFavorites { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnNews { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnClearSearch { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnClearFavorite { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnRefreshNew { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnAbout { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnSetting { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnSearch { get; set; }

		[Action ("btnClearSearchClicked:")]
		partial void btnClearSearchClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("btnClearFavoriteClicked:")]
		partial void btnClearFavoriteClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("btnRefreshNewClicked:")]
		partial void btnRefreshNewClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("btnAboutClicked:")]
		partial void btnAboutClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("btnSettingClicked:")]
		partial void btnSettingClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("btnSearchClicked:")]
		partial void btnSearchClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("btnSaveFavoritesClicked:")]
		partial void btnSaveFavoritesClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("btnNewsClicked:")]
		partial void btnNewsClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("btnRecentClicked:")]
		partial void btnRecentClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (viewMenu != null) {
				viewMenu.Dispose ();
				viewMenu = null;
			}

			if (imageLogo != null) {
				imageLogo.Dispose ();
				imageLogo = null;
			}

			if (btnRecent != null) {
				btnRecent.Dispose ();
				btnRecent = null;
			}

			if (btnSaveFavorites != null) {
				btnSaveFavorites.Dispose ();
				btnSaveFavorites = null;
			}

			if (btnNews != null) {
				btnNews.Dispose ();
				btnNews = null;
			}

			if (btnClearSearch != null) {
				btnClearSearch.Dispose ();
				btnClearSearch = null;
			}

			if (btnClearFavorite != null) {
				btnClearFavorite.Dispose ();
				btnClearFavorite = null;
			}

			if (btnRefreshNew != null) {
				btnRefreshNew.Dispose ();
				btnRefreshNew = null;
			}

			if (btnAbout != null) {
				btnAbout.Dispose ();
				btnAbout = null;
			}

			if (btnSetting != null) {
				btnSetting.Dispose ();
				btnSetting = null;
			}

			if (btnSearch != null) {
				btnSearch.Dispose ();
				btnSearch = null;
			}
		}
	}
}

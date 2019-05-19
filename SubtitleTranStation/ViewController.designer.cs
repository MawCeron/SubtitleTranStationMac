// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SubtitleTranStation
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton btFst { get; set; }

		[Outlet]
		AppKit.NSButton btLst { get; set; }

		[Outlet]
		AppKit.NSButton btNxt { get; set; }

		[Outlet]
		AppKit.NSButton btPrv { get; set; }

		[Outlet]
		AppKit.NSButton btTrans { get; set; }

		[Outlet]
		AppKit.NSTextField lbCharacter { get; set; }

		[Outlet]
		AppKit.NSTextField lbEnd { get; set; }

		[Outlet]
		AppKit.NSTextField lbFile { get; set; }

		[Outlet]
		AppKit.NSTextField lbNum { get; set; }

		[Outlet]
		AppKit.NSTextField lbStart { get; set; }

		[Outlet]
		AppKit.NSTextField txDialog { get; set; }

		[Outlet]
		AppKit.NSTextField txTrans { get; set; }

		[Action ("GetTranslate:")]
		partial void GetTranslate (Foundation.NSObject sender);

		[Action ("MoveToFirst:")]
		partial void MoveToFirst (Foundation.NSObject sender);

		[Action ("MoveToLast:")]
		partial void MoveToLast (Foundation.NSObject sender);

		[Action ("MoveToNext:")]
		partial void MoveToNext (Foundation.NSObject sender);

		[Action ("MoveToPrevious:")]
		partial void MoveToPrevious (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txDialog != null) {
				txDialog.Dispose ();
				txDialog = null;
			}

			if (txTrans != null) {
				txTrans.Dispose ();
				txTrans = null;
			}

			if (lbFile != null) {
				lbFile.Dispose ();
				lbFile = null;
			}

			if (lbNum != null) {
				lbNum.Dispose ();
				lbNum = null;
			}

			if (lbCharacter != null) {
				lbCharacter.Dispose ();
				lbCharacter = null;
			}

			if (lbStart != null) {
				lbStart.Dispose ();
				lbStart = null;
			}

			if (lbEnd != null) {
				lbEnd.Dispose ();
				lbEnd = null;
			}

			if (btTrans != null) {
				btTrans.Dispose ();
				btTrans = null;
			}

			if (btFst != null) {
				btFst.Dispose ();
				btFst = null;
			}

			if (btPrv != null) {
				btPrv.Dispose ();
				btPrv = null;
			}

			if (btNxt != null) {
				btNxt.Dispose ();
				btNxt = null;
			}

			if (btLst != null) {
				btLst.Dispose ();
				btLst = null;
			}
		}
	}
}

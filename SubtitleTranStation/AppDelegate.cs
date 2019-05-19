using AppKit;
using Foundation;

namespace SubtitleTranStation
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        #region Override Methods
        public override void DidFinishLaunching(NSNotification notification)
        {

        }

        public override bool OpenFile(NSApplication sender, string fileName)
        {
            try
            {
                fileName = fileName.Replace(" ", "%20");
                var url = new NSUrl("file://" + fileName);
                return OpenFile(url);
            } catch
            {
                return false;
            }
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
        #endregion

        #region Private Methods
        private bool OpenFile(NSUrl url)
        {

        }
        #endregion

        #region Actions
        [Export("openDocument:")]
        void OpenDialog(NSObject sender)
        {
            var dlg = NSOpenPanel.OpenPanel;
            dlg.CanChooseFiles = true;
            dlg.CanChooseDirectories = false;
            dlg.AllowedFileTypes = new string[] { "srt", "txt", "ass" };
            dlg.AllowsMultipleSelection = false;

            if (dlg.RunModal() == 1)
            {
                var url = dlg.Urls[0];

                if (url != null)
                    OpenFile(url);
            }
        }
        #endregion
    }
}

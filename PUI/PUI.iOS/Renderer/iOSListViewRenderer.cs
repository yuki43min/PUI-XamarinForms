using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PUI.iOS.Renderer;

[assembly: ExportRenderer(typeof(ListView), typeof(iOSListViewRenderer))]
namespace PUI.iOS.Renderer
{
    public class iOSListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);
            if (this.Control != null)
            {
                var tbl = new UITableView(this.Bounds, UITableViewStyle.Grouped)
                {
                    Source = this.Control.Source
                };
                this.SetNativeControl(tbl);
            }
        }
    }
}

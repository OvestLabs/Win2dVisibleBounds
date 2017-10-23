using System.Diagnostics;
using Windows.UI;
using Microsoft.Graphics.Canvas.UI.Xaml;

namespace Win2dVisibleBounds
{
	public sealed partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnRegionsInvalidated(CanvasVirtualControl sender, CanvasRegionsInvalidatedEventArgs e)
		{
			Debug.WriteLine(e.VisibleRegion);

			foreach (var r in e.InvalidatedRegions)
			{
				using (var ds = sender.CreateDrawingSession(r))
				{
					ds.Clear(Colors.DeepSkyBlue);
				}
			}
		}
	}
}

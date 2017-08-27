using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DragCoordinatesUITestRepro.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
			app.Screenshot("First screen.");
        }

        [Test]
        public void PullToRefresh_DragDropCoordinates()
        {

            var listViewQuery = app.Query(x=>x.Marked("ListView")).FirstOrDefault();

			var topYCoordinate = listViewQuery.Rect.Y;
			var bottomYCoordinate = listViewQuery.Rect.Y + listViewQuery.Rect.Height;
			var centerXCoordinate = listViewQuery.Rect.CenterX;

			app.DragCoordinates(centerXCoordinate, topYCoordinate + 20, centerXCoordinate, bottomYCoordinate - 20);

			app.Screenshot("Pull To Refresh Triggered");
        }
    }
}

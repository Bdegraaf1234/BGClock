using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoardGameCloclTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Constructor()
		{
			var clock = new BoardGameClock.Clock(3);

			Assert.AreEqual(3, clock.UserClocks.Count);
			Assert.AreEqual(0, clock.UserNames.Count);
		}

		[TestMethod]
		public void WithNames()
		{
			var clock = new BoardGameClock.Clock(2, new List<string> { "Bastiaan", "Annemiek" });

			Assert.AreEqual(2, clock.UserClocks.Count);
			Assert.AreEqual(2, clock.UserNames.Count);
		}

		[TestMethod]
		public void Start()
		{
			var clock = new BoardGameClock.Clock(2, new List<string> { "Bastiaan", "Annemiek" });
			clock.Start();
		}

		[TestMethod]
		public void Stop()
		{
			var clock = new BoardGameClock.Clock(2, new List<string> { "Bastiaan", "Annemiek" });
			clock.Start();
			clock.Stop();
		}

		[TestMethod]
		public void Next()
		{
			var clock = new BoardGameClock.Clock(2, new List<string> { "Bastiaan", "Annemiek" });
			clock.Start();
			clock.Next();
		}

		[TestMethod]
		public void Integration()
		{
			var clock = new BoardGameClock.Clock(2, new List<string> { "Bastiaan", "Annemiek" });
			clock.Start();

			var random = new Random(12345);

			for (int i = 0; i < 100; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					System.Threading.Thread.Sleep(random.Next(3, 10));
					clock.Next();
				}
			}

			clock.Stop();

			var total = clock.GetUserTotalTime(1);
			var min = clock.GetUserMin(1);
			var max = clock.GetUserMax(1);
			var average = clock.GetUserAverage(1);

			Assert.AreEqual(665, total, 10);
			Assert.AreEqual(3, min);
			Assert.AreEqual(10, max);
		}
	}
}

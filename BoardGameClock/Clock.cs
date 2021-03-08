using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameClock
{
    public class Clock
    {
		public List<Stopwatch> UserClocks = new List<Stopwatch>();
		public int RunningIndex = 0;
		public List<string> UserNames = new List<string>();
		public List<List<long>> UserTurnTimes = new List<List<long>>();
		public int NumUsers { get { return UserClocks.Count; } }
		public bool IsRunning = false;

		public Clock(int numUsers)
		{
			for (int i = 0; i < numUsers; i++)
			{
				UserClocks.Add(new Stopwatch());
				UserTurnTimes.Add(new List<long>());
			}
		}

		public Clock(int numUsers, List<string> names)
		{
			for (int i = 0; i < numUsers; i++)
			{
				UserClocks.Add(new Stopwatch());
				UserTurnTimes.Add(new List<long>());
			}

			UserNames = names;
		}

		public void Start()
		{
			IsRunning = true;
			UserClocks[RunningIndex].Start();
		}

		/// <summary>
		/// Returns number of milliseconds of current user;
		/// </summary>
		/// <returns></returns>
		public long Next()
		{
			Stop();
			RunningIndex++;
			if (RunningIndex == NumUsers)
				RunningIndex = 0;

			int prevIndex = RunningIndex - 1 < 0 ? NumUsers - 1 : RunningIndex - 1;
			
			UserClocks[RunningIndex].Start();
			return UserClocks[prevIndex].ElapsedMilliseconds;
		}

		/// <summary>
		/// Stop.
		/// </summary>
		/// <returns></returns>
		public void Stop()
		{
			IsRunning = false;
			UserClocks[RunningIndex].Stop();
			var lastTotal = UserTurnTimes[RunningIndex].Sum();
			UserTurnTimes[RunningIndex].Add(UserClocks[RunningIndex].ElapsedMilliseconds - lastTotal);
		}

		public void Pause()
		{
			IsRunning = false;
			UserClocks[RunningIndex].Stop();
		}

		public double GetUserTotalTime(int index)
		{
			return UserTurnTimes[index].Sum();
		}

		public double GetUserAverage(int index)
		{
			return UserTurnTimes[index].Average();
		}

		public double GetUserMin(int index)
		{
			return UserTurnTimes[index].Min();
		}

		public double GetUserMax(int index)
		{
			return UserTurnTimes[index].Max();
		}
	}
}

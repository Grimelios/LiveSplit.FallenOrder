using System.Diagnostics;
using LiveSplit.FallenOrder.Data;

namespace LiveSplit.FallenOrder.Memory
{
	public class JediMemory
	{
		private const string ProcessName = "starwarsjedifallenorder";

		private Process process;
		private JediPointers pointers;

		public JediMemory()
		{
			pointers = new JediPointers();
		}

		public bool Hook()
		{
			if (IsHooked)
			{
				if (process.HasExited)
				{
					IsHooked = false;
					process = null;

					return false;
				}
			}
			else
			{
				Process[] processes = Process.GetProcessesByName(ProcessName);

				if (processes.Length > 0)
				{
					process = processes[0];

					if (process.HasExited)
					{
						return false;
					}

					IsHooked = true;
				}
			}

			if (IsHooked)
			{
				pointers.Refresh(process);
			}

			return IsHooked;
		}

		public bool IsHooked { get; private set; }

		public bool IsBossDefeated(Bosses boss)
		{
			return false;
		}
	}
}

private sealed class Timer.Scheduler // TypeDefIndex: 834
{
	// Fields
	private static Timer.Scheduler instance; // 0x0
	private SortedList list; // 0x10
	private ManualResetEvent changed; // 0x18

	// Properties
	public static Timer.Scheduler Instance { get; }

	// Methods

	// RVA: 0x158DA40 Offset: 0x158DB41 VA: 0x158DA40
	private static void .cctor() { }

	// RVA: 0x158DC80 Offset: 0x158DD81 VA: 0x158DC80
	public static Timer.Scheduler get_Instance() { }

	// RVA: 0x158DAB0 Offset: 0x158DBB1 VA: 0x158DAB0
	private void .ctor() { }

	// RVA: 0x158D660 Offset: 0x158D761 VA: 0x158D660
	public void Remove(Timer timer) { }

	// RVA: 0x158D760 Offset: 0x158D861 VA: 0x158D760
	public void Change(Timer timer, long new_next_run) { }

	// RVA: 0x158DEF0 Offset: 0x158DFF1 VA: 0x158DEF0
	private int FindByDueTime(long nr) { }

	// RVA: 0x158DD60 Offset: 0x158DE61 VA: 0x158DD60
	private void Add(Timer timer) { }

	// RVA: 0x158DD00 Offset: 0x158DE01 VA: 0x158DD00
	private int InternalRemove(Timer timer) { }

	// RVA: 0x158E070 Offset: 0x158E171 VA: 0x158E070
	private static void TimerCB(object o) { }

	// RVA: 0x158E4C0 Offset: 0x158E5C1 VA: 0x158E4C0
	private void SchedulerThread() { }

	// RVA: 0x158ED70 Offset: 0x158EE71 VA: 0x158ED70
	private void ShrinkIfNeeded(List<Timer> list, int initial) { }
}


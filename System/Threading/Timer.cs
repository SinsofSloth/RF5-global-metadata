[ComVisibleAttribute] // RVA: 0xAF620 Offset: 0xAF721 VA: 0xAF620
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 832
{
	// Fields
	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40

	// Methods

	// RVA: 0x1584C70 Offset: 0x1584D71 VA: 0x1584C70
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x158D320 Offset: 0x158D421 VA: 0x158D320
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x158D250 Offset: 0x158D351 VA: 0x158D250
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x158D5F0 Offset: 0x158D6F1 VA: 0x158D5F0
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1585BB0 Offset: 0x1585CB1 VA: 0x1585BB0 Slot: 6
	public void Dispose() { }

	// RVA: 0x158D3C0 Offset: 0x158D4C1 VA: 0x158D3C0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x1584CD0 Offset: 0x1584DD1 VA: 0x1584CD0
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x158D750 Offset: 0x158D851 VA: 0x158D750
	private static long GetTimeMonotonic() { }

	// RVA: 0x158D960 Offset: 0x158DA61 VA: 0x158D960
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAF620 Offset: 0xAF721 VA: 0xAF620
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 832
{
	// Fields
	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40

	// Methods

	// RVA: 0x1584C70 Offset: 0x1584D71 VA: 0x1584C70
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x158D320 Offset: 0x158D421 VA: 0x158D320
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x158D250 Offset: 0x158D351 VA: 0x158D250
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x158D5F0 Offset: 0x158D6F1 VA: 0x158D5F0
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1585BB0 Offset: 0x1585CB1 VA: 0x1585BB0 Slot: 6
	public void Dispose() { }

	// RVA: 0x158D3C0 Offset: 0x158D4C1 VA: 0x158D3C0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x1584CD0 Offset: 0x1584DD1 VA: 0x1584CD0
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x158D750 Offset: 0x158D851 VA: 0x158D750
	private static long GetTimeMonotonic() { }

	// RVA: 0x158D960 Offset: 0x158DA61 VA: 0x158D960
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAF620 Offset: 0xAF721 VA: 0xAF620
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 832
{
	// Fields
	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40

	// Methods

	// RVA: 0x1584C70 Offset: 0x1584D71 VA: 0x1584C70
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x158D320 Offset: 0x158D421 VA: 0x158D320
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x158D250 Offset: 0x158D351 VA: 0x158D250
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x158D5F0 Offset: 0x158D6F1 VA: 0x158D5F0
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1585BB0 Offset: 0x1585CB1 VA: 0x1585BB0 Slot: 6
	public void Dispose() { }

	// RVA: 0x158D3C0 Offset: 0x158D4C1 VA: 0x158D3C0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x1584CD0 Offset: 0x1584DD1 VA: 0x1584CD0
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x158D750 Offset: 0x158D851 VA: 0x158D750
	private static long GetTimeMonotonic() { }

	// RVA: 0x158D960 Offset: 0x158DA61 VA: 0x158D960
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAF620 Offset: 0xAF721 VA: 0xAF620
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 832
{
	// Fields
	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40

	// Methods

	// RVA: 0x1584C70 Offset: 0x1584D71 VA: 0x1584C70
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x158D320 Offset: 0x158D421 VA: 0x158D320
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x158D250 Offset: 0x158D351 VA: 0x158D250
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x158D5F0 Offset: 0x158D6F1 VA: 0x158D5F0
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1585BB0 Offset: 0x1585CB1 VA: 0x1585BB0 Slot: 6
	public void Dispose() { }

	// RVA: 0x158D3C0 Offset: 0x158D4C1 VA: 0x158D3C0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x1584CD0 Offset: 0x1584DD1 VA: 0x1584CD0
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x158D750 Offset: 0x158D851 VA: 0x158D750
	private static long GetTimeMonotonic() { }

	// RVA: 0x158D960 Offset: 0x158DA61 VA: 0x158D960
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAF620 Offset: 0xAF721 VA: 0xAF620
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 832
{
	// Fields
	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40

	// Methods

	// RVA: 0x1584C70 Offset: 0x1584D71 VA: 0x1584C70
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x158D320 Offset: 0x158D421 VA: 0x158D320
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x158D250 Offset: 0x158D351 VA: 0x158D250
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x158D5F0 Offset: 0x158D6F1 VA: 0x158D5F0
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1585BB0 Offset: 0x1585CB1 VA: 0x1585BB0 Slot: 6
	public void Dispose() { }

	// RVA: 0x158D3C0 Offset: 0x158D4C1 VA: 0x158D3C0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x1584CD0 Offset: 0x1584DD1 VA: 0x1584CD0
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x158D750 Offset: 0x158D851 VA: 0x158D750
	private static long GetTimeMonotonic() { }

	// RVA: 0x158D960 Offset: 0x158DA61 VA: 0x158D960
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAF620 Offset: 0xAF721 VA: 0xAF620
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 832
{
	// Fields
	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40

	// Methods

	// RVA: 0x1584C70 Offset: 0x1584D71 VA: 0x1584C70
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x158D320 Offset: 0x158D421 VA: 0x158D320
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x158D250 Offset: 0x158D351 VA: 0x158D250
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x158D5F0 Offset: 0x158D6F1 VA: 0x158D5F0
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1585BB0 Offset: 0x1585CB1 VA: 0x1585BB0 Slot: 6
	public void Dispose() { }

	// RVA: 0x158D3C0 Offset: 0x158D4C1 VA: 0x158D3C0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x1584CD0 Offset: 0x1584DD1 VA: 0x1584CD0
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x158D750 Offset: 0x158D851 VA: 0x158D750
	private static long GetTimeMonotonic() { }

	// RVA: 0x158D960 Offset: 0x158DA61 VA: 0x158D960
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAF620 Offset: 0xAF721 VA: 0xAF620
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 832
{
	// Fields
	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40

	// Methods

	// RVA: 0x1584C70 Offset: 0x1584D71 VA: 0x1584C70
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x158D320 Offset: 0x158D421 VA: 0x158D320
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x158D250 Offset: 0x158D351 VA: 0x158D250
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x158D5F0 Offset: 0x158D6F1 VA: 0x158D5F0
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1585BB0 Offset: 0x1585CB1 VA: 0x1585BB0 Slot: 6
	public void Dispose() { }

	// RVA: 0x158D3C0 Offset: 0x158D4C1 VA: 0x158D3C0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x1584CD0 Offset: 0x1584DD1 VA: 0x1584CD0
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x158D750 Offset: 0x158D851 VA: 0x158D750
	private static long GetTimeMonotonic() { }

	// RVA: 0x158D960 Offset: 0x158DA61 VA: 0x158D960
	private static void .cctor() { }
}


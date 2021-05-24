public sealed class NotificationQueue : IDisposable // TypeDefIndex: 11672
{
	// Fields
	private IntPtr queue; // 0x10

	// Methods

	// RVA: 0x26AC7C0 Offset: 0x26AC8C1 VA: 0x26AC7C0
	public void .ctor() { }

	// RVA: 0x26AC830 Offset: 0x26AC931 VA: 0x26AC830 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26AC940 Offset: 0x26ACA41 VA: 0x26AC940 Slot: 4
	public void Dispose() { }

	// RVA: 0x26AC8E0 Offset: 0x26AC9E1 VA: 0x26AC8E0
	private void Dispose(bool disposing) { }

	// RVA: 0x26ACA00 Offset: 0x26ACB01 VA: 0x26ACA00
	public Result Initialize(Uid uid) { }

	// RVA: 0x26ACA40 Offset: 0x26ACB41 VA: 0x26ACA40
	public Result Initialize() { }

	// RVA: 0x26ACA80 Offset: 0x26ACB81 VA: 0x26ACA80
	public void Terminate() { }

	// RVA: 0x26ACAA0 Offset: 0x26ACBA1 VA: 0x26ACAA0
	public Uid GetUid() { }

	// RVA: 0x26ACAC0 Offset: 0x26ACBC1 VA: 0x26ACAC0
	public Result Clear() { }

	// RVA: 0x26ACB00 Offset: 0x26ACC01 VA: 0x26ACB00
	public Result Pop(ref NotificationInfo outInfo) { }

	// RVA: 0x26ACB40 Offset: 0x26ACC41 VA: 0x26ACB40
	public bool Exists() { }

	// RVA: 0x26AC820 Offset: 0x26AC921 VA: 0x26AC820
	private static extern IntPtr Create() { }

	// RVA: 0x26AC9F0 Offset: 0x26ACAF1 VA: 0x26AC9F0
	private static extern void Destroy(IntPtr pQueue) { }

	// RVA: 0x26ACA20 Offset: 0x26ACB21 VA: 0x26ACA20
	private static extern Result Initialize(IntPtr pQueue, Uid uid) { }

	// RVA: 0x26ACA60 Offset: 0x26ACB61 VA: 0x26ACA60
	private static extern Result Initialize(IntPtr pQueue) { }

	// RVA: 0x26ACA90 Offset: 0x26ACB91 VA: 0x26ACA90
	private static extern void Terminate(IntPtr pQueue) { }

	// RVA: 0x26ACAB0 Offset: 0x26ACBB1 VA: 0x26ACAB0
	private static extern Uid GetUid(IntPtr pQueue) { }

	// RVA: 0x26ACAE0 Offset: 0x26ACBE1 VA: 0x26ACAE0
	private static extern Result Clear(IntPtr pQueue) { }

	// RVA: 0x26ACB20 Offset: 0x26ACC21 VA: 0x26ACB20
	private static extern Result Pop(IntPtr pQueue, ref NotificationInfo outInfo) { }

	// RVA: 0x26ACB60 Offset: 0x26ACC61 VA: 0x26ACB60
	private static extern bool Exists(IntPtr pQueue) { }
}

public sealed class NotificationQueue : IDisposable // TypeDefIndex: 11672
{
	// Fields
	private IntPtr queue; // 0x10

	// Methods

	// RVA: 0x26AC7C0 Offset: 0x26AC8C1 VA: 0x26AC7C0
	public void .ctor() { }

	// RVA: 0x26AC830 Offset: 0x26AC931 VA: 0x26AC830 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26AC940 Offset: 0x26ACA41 VA: 0x26AC940 Slot: 4
	public void Dispose() { }

	// RVA: 0x26AC8E0 Offset: 0x26AC9E1 VA: 0x26AC8E0
	private void Dispose(bool disposing) { }

	// RVA: 0x26ACA00 Offset: 0x26ACB01 VA: 0x26ACA00
	public Result Initialize(Uid uid) { }

	// RVA: 0x26ACA40 Offset: 0x26ACB41 VA: 0x26ACA40
	public Result Initialize() { }

	// RVA: 0x26ACA80 Offset: 0x26ACB81 VA: 0x26ACA80
	public void Terminate() { }

	// RVA: 0x26ACAA0 Offset: 0x26ACBA1 VA: 0x26ACAA0
	public Uid GetUid() { }

	// RVA: 0x26ACAC0 Offset: 0x26ACBC1 VA: 0x26ACAC0
	public Result Clear() { }

	// RVA: 0x26ACB00 Offset: 0x26ACC01 VA: 0x26ACB00
	public Result Pop(ref NotificationInfo outInfo) { }

	// RVA: 0x26ACB40 Offset: 0x26ACC41 VA: 0x26ACB40
	public bool Exists() { }

	// RVA: 0x26AC820 Offset: 0x26AC921 VA: 0x26AC820
	private static extern IntPtr Create() { }

	// RVA: 0x26AC9F0 Offset: 0x26ACAF1 VA: 0x26AC9F0
	private static extern void Destroy(IntPtr pQueue) { }

	// RVA: 0x26ACA20 Offset: 0x26ACB21 VA: 0x26ACA20
	private static extern Result Initialize(IntPtr pQueue, Uid uid) { }

	// RVA: 0x26ACA60 Offset: 0x26ACB61 VA: 0x26ACA60
	private static extern Result Initialize(IntPtr pQueue) { }

	// RVA: 0x26ACA90 Offset: 0x26ACB91 VA: 0x26ACA90
	private static extern void Terminate(IntPtr pQueue) { }

	// RVA: 0x26ACAB0 Offset: 0x26ACBB1 VA: 0x26ACAB0
	private static extern Uid GetUid(IntPtr pQueue) { }

	// RVA: 0x26ACAE0 Offset: 0x26ACBE1 VA: 0x26ACAE0
	private static extern Result Clear(IntPtr pQueue) { }

	// RVA: 0x26ACB20 Offset: 0x26ACC21 VA: 0x26ACB20
	private static extern Result Pop(IntPtr pQueue, ref NotificationInfo outInfo) { }

	// RVA: 0x26ACB60 Offset: 0x26ACC61 VA: 0x26ACB60
	private static extern bool Exists(IntPtr pQueue) { }
}

public sealed class NotificationQueue : IDisposable // TypeDefIndex: 11672
{
	// Fields
	private IntPtr queue; // 0x10

	// Methods

	// RVA: 0x26AC7C0 Offset: 0x26AC8C1 VA: 0x26AC7C0
	public void .ctor() { }

	// RVA: 0x26AC830 Offset: 0x26AC931 VA: 0x26AC830 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26AC940 Offset: 0x26ACA41 VA: 0x26AC940 Slot: 4
	public void Dispose() { }

	// RVA: 0x26AC8E0 Offset: 0x26AC9E1 VA: 0x26AC8E0
	private void Dispose(bool disposing) { }

	// RVA: 0x26ACA00 Offset: 0x26ACB01 VA: 0x26ACA00
	public Result Initialize(Uid uid) { }

	// RVA: 0x26ACA40 Offset: 0x26ACB41 VA: 0x26ACA40
	public Result Initialize() { }

	// RVA: 0x26ACA80 Offset: 0x26ACB81 VA: 0x26ACA80
	public void Terminate() { }

	// RVA: 0x26ACAA0 Offset: 0x26ACBA1 VA: 0x26ACAA0
	public Uid GetUid() { }

	// RVA: 0x26ACAC0 Offset: 0x26ACBC1 VA: 0x26ACAC0
	public Result Clear() { }

	// RVA: 0x26ACB00 Offset: 0x26ACC01 VA: 0x26ACB00
	public Result Pop(ref NotificationInfo outInfo) { }

	// RVA: 0x26ACB40 Offset: 0x26ACC41 VA: 0x26ACB40
	public bool Exists() { }

	// RVA: 0x26AC820 Offset: 0x26AC921 VA: 0x26AC820
	private static extern IntPtr Create() { }

	// RVA: 0x26AC9F0 Offset: 0x26ACAF1 VA: 0x26AC9F0
	private static extern void Destroy(IntPtr pQueue) { }

	// RVA: 0x26ACA20 Offset: 0x26ACB21 VA: 0x26ACA20
	private static extern Result Initialize(IntPtr pQueue, Uid uid) { }

	// RVA: 0x26ACA60 Offset: 0x26ACB61 VA: 0x26ACA60
	private static extern Result Initialize(IntPtr pQueue) { }

	// RVA: 0x26ACA90 Offset: 0x26ACB91 VA: 0x26ACA90
	private static extern void Terminate(IntPtr pQueue) { }

	// RVA: 0x26ACAB0 Offset: 0x26ACBB1 VA: 0x26ACAB0
	private static extern Uid GetUid(IntPtr pQueue) { }

	// RVA: 0x26ACAE0 Offset: 0x26ACBE1 VA: 0x26ACAE0
	private static extern Result Clear(IntPtr pQueue) { }

	// RVA: 0x26ACB20 Offset: 0x26ACC21 VA: 0x26ACB20
	private static extern Result Pop(IntPtr pQueue, ref NotificationInfo outInfo) { }

	// RVA: 0x26ACB60 Offset: 0x26ACC61 VA: 0x26ACB60
	private static extern bool Exists(IntPtr pQueue) { }
}

public sealed class NotificationQueue : IDisposable // TypeDefIndex: 11672
{
	// Fields
	private IntPtr queue; // 0x10

	// Methods

	// RVA: 0x26AC7C0 Offset: 0x26AC8C1 VA: 0x26AC7C0
	public void .ctor() { }

	// RVA: 0x26AC830 Offset: 0x26AC931 VA: 0x26AC830 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26AC940 Offset: 0x26ACA41 VA: 0x26AC940 Slot: 4
	public void Dispose() { }

	// RVA: 0x26AC8E0 Offset: 0x26AC9E1 VA: 0x26AC8E0
	private void Dispose(bool disposing) { }

	// RVA: 0x26ACA00 Offset: 0x26ACB01 VA: 0x26ACA00
	public Result Initialize(Uid uid) { }

	// RVA: 0x26ACA40 Offset: 0x26ACB41 VA: 0x26ACA40
	public Result Initialize() { }

	// RVA: 0x26ACA80 Offset: 0x26ACB81 VA: 0x26ACA80
	public void Terminate() { }

	// RVA: 0x26ACAA0 Offset: 0x26ACBA1 VA: 0x26ACAA0
	public Uid GetUid() { }

	// RVA: 0x26ACAC0 Offset: 0x26ACBC1 VA: 0x26ACAC0
	public Result Clear() { }

	// RVA: 0x26ACB00 Offset: 0x26ACC01 VA: 0x26ACB00
	public Result Pop(ref NotificationInfo outInfo) { }

	// RVA: 0x26ACB40 Offset: 0x26ACC41 VA: 0x26ACB40
	public bool Exists() { }

	// RVA: 0x26AC820 Offset: 0x26AC921 VA: 0x26AC820
	private static extern IntPtr Create() { }

	// RVA: 0x26AC9F0 Offset: 0x26ACAF1 VA: 0x26AC9F0
	private static extern void Destroy(IntPtr pQueue) { }

	// RVA: 0x26ACA20 Offset: 0x26ACB21 VA: 0x26ACA20
	private static extern Result Initialize(IntPtr pQueue, Uid uid) { }

	// RVA: 0x26ACA60 Offset: 0x26ACB61 VA: 0x26ACA60
	private static extern Result Initialize(IntPtr pQueue) { }

	// RVA: 0x26ACA90 Offset: 0x26ACB91 VA: 0x26ACA90
	private static extern void Terminate(IntPtr pQueue) { }

	// RVA: 0x26ACAB0 Offset: 0x26ACBB1 VA: 0x26ACAB0
	private static extern Uid GetUid(IntPtr pQueue) { }

	// RVA: 0x26ACAE0 Offset: 0x26ACBE1 VA: 0x26ACAE0
	private static extern Result Clear(IntPtr pQueue) { }

	// RVA: 0x26ACB20 Offset: 0x26ACC21 VA: 0x26ACB20
	private static extern Result Pop(IntPtr pQueue, ref NotificationInfo outInfo) { }

	// RVA: 0x26ACB60 Offset: 0x26ACC61 VA: 0x26ACB60
	private static extern bool Exists(IntPtr pQueue) { }
}

public sealed class NotificationQueue : IDisposable // TypeDefIndex: 11672
{
	// Fields
	private IntPtr queue; // 0x10

	// Methods

	// RVA: 0x26AC7C0 Offset: 0x26AC8C1 VA: 0x26AC7C0
	public void .ctor() { }

	// RVA: 0x26AC830 Offset: 0x26AC931 VA: 0x26AC830 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26AC940 Offset: 0x26ACA41 VA: 0x26AC940 Slot: 4
	public void Dispose() { }

	// RVA: 0x26AC8E0 Offset: 0x26AC9E1 VA: 0x26AC8E0
	private void Dispose(bool disposing) { }

	// RVA: 0x26ACA00 Offset: 0x26ACB01 VA: 0x26ACA00
	public Result Initialize(Uid uid) { }

	// RVA: 0x26ACA40 Offset: 0x26ACB41 VA: 0x26ACA40
	public Result Initialize() { }

	// RVA: 0x26ACA80 Offset: 0x26ACB81 VA: 0x26ACA80
	public void Terminate() { }

	// RVA: 0x26ACAA0 Offset: 0x26ACBA1 VA: 0x26ACAA0
	public Uid GetUid() { }

	// RVA: 0x26ACAC0 Offset: 0x26ACBC1 VA: 0x26ACAC0
	public Result Clear() { }

	// RVA: 0x26ACB00 Offset: 0x26ACC01 VA: 0x26ACB00
	public Result Pop(ref NotificationInfo outInfo) { }

	// RVA: 0x26ACB40 Offset: 0x26ACC41 VA: 0x26ACB40
	public bool Exists() { }

	// RVA: 0x26AC820 Offset: 0x26AC921 VA: 0x26AC820
	private static extern IntPtr Create() { }

	// RVA: 0x26AC9F0 Offset: 0x26ACAF1 VA: 0x26AC9F0
	private static extern void Destroy(IntPtr pQueue) { }

	// RVA: 0x26ACA20 Offset: 0x26ACB21 VA: 0x26ACA20
	private static extern Result Initialize(IntPtr pQueue, Uid uid) { }

	// RVA: 0x26ACA60 Offset: 0x26ACB61 VA: 0x26ACA60
	private static extern Result Initialize(IntPtr pQueue) { }

	// RVA: 0x26ACA90 Offset: 0x26ACB91 VA: 0x26ACA90
	private static extern void Terminate(IntPtr pQueue) { }

	// RVA: 0x26ACAB0 Offset: 0x26ACBB1 VA: 0x26ACAB0
	private static extern Uid GetUid(IntPtr pQueue) { }

	// RVA: 0x26ACAE0 Offset: 0x26ACBE1 VA: 0x26ACAE0
	private static extern Result Clear(IntPtr pQueue) { }

	// RVA: 0x26ACB20 Offset: 0x26ACC21 VA: 0x26ACB20
	private static extern Result Pop(IntPtr pQueue, ref NotificationInfo outInfo) { }

	// RVA: 0x26ACB60 Offset: 0x26ACC61 VA: 0x26ACB60
	private static extern bool Exists(IntPtr pQueue) { }
}


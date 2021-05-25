internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 3036
{
	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x1B79990 Offset: 0x1B79A91 VA: 0x1B79990
	private void .ctor(int mainThreadID) { }

	// RVA: 0x1B79A60 Offset: 0x1B79B61 VA: 0x1B79A60
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x1B79B10 Offset: 0x1B79C11 VA: 0x1B79B10 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x1B79E10 Offset: 0x1B79F11 VA: 0x1B79E10 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x1B79F30 Offset: 0x1B7A031 VA: 0x1B79F30 Slot: 6
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x1B7A020 Offset: 0x1B7A121 VA: 0x1B7A020
	private void Exec() { }

	// RVA: 0x1B7A2A0 Offset: 0x1B7A3A1 VA: 0x1B7A2A0
	private bool HasPendingTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD7640 Offset: 0xD7741 VA: 0xD7640
	// RVA: 0x1B7A310 Offset: 0x1B7A411 VA: 0x1B7A310
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD7650 Offset: 0xD7751 VA: 0xD7650
	// RVA: 0x1B7A390 Offset: 0x1B7A491 VA: 0x1B7A390
	private static void ExecuteTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD7660 Offset: 0xD7761 VA: 0xD7660
	// RVA: 0x1B7A410 Offset: 0x1B7A511 VA: 0x1B7A410
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }
}


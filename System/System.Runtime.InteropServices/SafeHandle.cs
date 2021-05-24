public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1320
{
	// Fields
	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0xB95D0 Offset: 0xB96D1 VA: 0xB95D0
	// RVA: 0x18053E0 Offset: 0x18054E1 VA: 0x18053E0
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0x1805490 Offset: 0x1805591 VA: 0x1805490 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0xB95F0 Offset: 0xB96F1 VA: 0xB95F0
	// RVA: 0x1805510 Offset: 0x1805611 VA: 0x1805510
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0xB9610 Offset: 0xB9711 VA: 0xB9610
	// RVA: 0x1805520 Offset: 0x1805621 VA: 0x1805520
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContractAttribute] // RVA: 0xB9630 Offset: 0xB9731 VA: 0xB9630
	// RVA: 0x1805530 Offset: 0x1805631 VA: 0x1805530
	public bool get_IsClosed() { }

	[ReliabilityContractAttribute] // RVA: 0xB9650 Offset: 0xB9751 VA: 0xB9650
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid() { }

	[ReliabilityContractAttribute] // RVA: 0xB9670 Offset: 0xB9771 VA: 0xB9670
	// RVA: 0x1805540 Offset: 0x1805641 VA: 0x1805540
	public void Close() { }

	[ReliabilityContractAttribute] // RVA: 0xB9690 Offset: 0xB9791 VA: 0xB9690
	// RVA: 0x1805550 Offset: 0x1805651 VA: 0x1805550 Slot: 4
	public void Dispose() { }

	[ReliabilityContractAttribute] // RVA: 0xB96B0 Offset: 0xB97B1 VA: 0xB96B0
	// RVA: 0x1805560 Offset: 0x1805661 VA: 0x1805560 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0xB96D0 Offset: 0xB97D1 VA: 0xB96D0
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle() { }

	[ReliabilityContractAttribute] // RVA: 0xB96F0 Offset: 0xB97F1 VA: 0xB96F0
	// RVA: 0x1805650 Offset: 0x1805751 VA: 0x1805650
	public void SetHandleAsInvalid() { }

	[ReliabilityContractAttribute] // RVA: 0xB9710 Offset: 0xB9811 VA: 0xB9710
	// RVA: 0x1805260 Offset: 0x1805361 VA: 0x1805260
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContractAttribute] // RVA: 0xB9730 Offset: 0xB9831 VA: 0xB9730
	// RVA: 0x18053D0 Offset: 0x18054D1 VA: 0x18053D0
	public void DangerousRelease() { }

	// RVA: 0x1805580 Offset: 0x1805681 VA: 0x1805580
	private void InternalDispose() { }

	// RVA: 0x1805630 Offset: 0x1805731 VA: 0x1805630
	private void InternalFinalize() { }

	// RVA: 0x18056F0 Offset: 0x18057F1 VA: 0x18056F0
	private void DangerousReleaseInternal(bool dispose) { }
}


internal abstract class AsyncProtocolRequest // TypeDefIndex: 1705
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBCDA0 Offset: 0xBCEA1 VA: 0xBCDA0
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBCDB0 Offset: 0xBCEB1 VA: 0xBCDB0
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBCDC0 Offset: 0xBCEC1 VA: 0xBCDC0
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBD260 Offset: 0xBD361 VA: 0xBD260
	// RVA: 0x16EECE0 Offset: 0x16EEDE1 VA: 0x16EECE0
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD270 Offset: 0xBD371 VA: 0xBD270
	// RVA: 0x16EECF0 Offset: 0x16EEDF1 VA: 0x16EECF0
	public bool get_RunSynchronously() { }

	// RVA: 0x16EED00 Offset: 0x16EEE01 VA: 0x16EED00
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD280 Offset: 0xBD381 VA: 0xBD280
	// RVA: 0x16EED30 Offset: 0x16EEE31 VA: 0x16EED30
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD290 Offset: 0xBD391 VA: 0xBD290
	// RVA: 0x16EED40 Offset: 0x16EEE41 VA: 0x16EED40
	protected void set_UserResult(int value) { }

	// RVA: 0x16EEA00 Offset: 0x16EEB01 VA: 0x16EEA00
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x16EED50 Offset: 0x16EEE51 VA: 0x16EED50
	internal void RequestRead(int size) { }

	// RVA: 0x16EEDF0 Offset: 0x16EEEF1 VA: 0x16EEDF0
	internal void RequestWrite() { }

	[AsyncStateMachineAttribute] // RVA: 0xBD2A0 Offset: 0xBD3A1 VA: 0xBD2A0
	// RVA: 0x16EEE00 Offset: 0x16EEF01 VA: 0x16EEE00
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD310 Offset: 0xBD411 VA: 0xBD310
	// RVA: 0x16EEF50 Offset: 0x16EF051 VA: 0x16EEF50
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD380 Offset: 0xBD481 VA: 0xBD380
	// RVA: 0x16EF0B0 Offset: 0x16EF1B1 VA: 0x16EF0B0
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0x16EF210 Offset: 0x16EF311 VA: 0x16EF210 Slot: 3
	public override string ToString() { }
}

internal abstract class AsyncProtocolRequest // TypeDefIndex: 1705
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBCDA0 Offset: 0xBCEA1 VA: 0xBCDA0
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBCDB0 Offset: 0xBCEB1 VA: 0xBCDB0
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBCDC0 Offset: 0xBCEC1 VA: 0xBCDC0
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBD260 Offset: 0xBD361 VA: 0xBD260
	// RVA: 0x16EECE0 Offset: 0x16EEDE1 VA: 0x16EECE0
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD270 Offset: 0xBD371 VA: 0xBD270
	// RVA: 0x16EECF0 Offset: 0x16EEDF1 VA: 0x16EECF0
	public bool get_RunSynchronously() { }

	// RVA: 0x16EED00 Offset: 0x16EEE01 VA: 0x16EED00
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD280 Offset: 0xBD381 VA: 0xBD280
	// RVA: 0x16EED30 Offset: 0x16EEE31 VA: 0x16EED30
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD290 Offset: 0xBD391 VA: 0xBD290
	// RVA: 0x16EED40 Offset: 0x16EEE41 VA: 0x16EED40
	protected void set_UserResult(int value) { }

	// RVA: 0x16EEA00 Offset: 0x16EEB01 VA: 0x16EEA00
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x16EED50 Offset: 0x16EEE51 VA: 0x16EED50
	internal void RequestRead(int size) { }

	// RVA: 0x16EEDF0 Offset: 0x16EEEF1 VA: 0x16EEDF0
	internal void RequestWrite() { }

	[AsyncStateMachineAttribute] // RVA: 0xBD2A0 Offset: 0xBD3A1 VA: 0xBD2A0
	// RVA: 0x16EEE00 Offset: 0x16EEF01 VA: 0x16EEE00
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD310 Offset: 0xBD411 VA: 0xBD310
	// RVA: 0x16EEF50 Offset: 0x16EF051 VA: 0x16EEF50
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD380 Offset: 0xBD481 VA: 0xBD380
	// RVA: 0x16EF0B0 Offset: 0x16EF1B1 VA: 0x16EF0B0
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0x16EF210 Offset: 0x16EF311 VA: 0x16EF210 Slot: 3
	public override string ToString() { }
}

internal abstract class AsyncProtocolRequest // TypeDefIndex: 1705
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBCDA0 Offset: 0xBCEA1 VA: 0xBCDA0
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBCDB0 Offset: 0xBCEB1 VA: 0xBCDB0
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBCDC0 Offset: 0xBCEC1 VA: 0xBCDC0
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBD260 Offset: 0xBD361 VA: 0xBD260
	// RVA: 0x16EECE0 Offset: 0x16EEDE1 VA: 0x16EECE0
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD270 Offset: 0xBD371 VA: 0xBD270
	// RVA: 0x16EECF0 Offset: 0x16EEDF1 VA: 0x16EECF0
	public bool get_RunSynchronously() { }

	// RVA: 0x16EED00 Offset: 0x16EEE01 VA: 0x16EED00
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD280 Offset: 0xBD381 VA: 0xBD280
	// RVA: 0x16EED30 Offset: 0x16EEE31 VA: 0x16EED30
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD290 Offset: 0xBD391 VA: 0xBD290
	// RVA: 0x16EED40 Offset: 0x16EEE41 VA: 0x16EED40
	protected void set_UserResult(int value) { }

	// RVA: 0x16EEA00 Offset: 0x16EEB01 VA: 0x16EEA00
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x16EED50 Offset: 0x16EEE51 VA: 0x16EED50
	internal void RequestRead(int size) { }

	// RVA: 0x16EEDF0 Offset: 0x16EEEF1 VA: 0x16EEDF0
	internal void RequestWrite() { }

	[AsyncStateMachineAttribute] // RVA: 0xBD2A0 Offset: 0xBD3A1 VA: 0xBD2A0
	// RVA: 0x16EEE00 Offset: 0x16EEF01 VA: 0x16EEE00
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD310 Offset: 0xBD411 VA: 0xBD310
	// RVA: 0x16EEF50 Offset: 0x16EF051 VA: 0x16EEF50
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD380 Offset: 0xBD481 VA: 0xBD380
	// RVA: 0x16EF0B0 Offset: 0x16EF1B1 VA: 0x16EF0B0
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0x16EF210 Offset: 0x16EF311 VA: 0x16EF210 Slot: 3
	public override string ToString() { }
}

internal abstract class AsyncProtocolRequest // TypeDefIndex: 1705
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBCDA0 Offset: 0xBCEA1 VA: 0xBCDA0
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBCDB0 Offset: 0xBCEB1 VA: 0xBCDB0
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBCDC0 Offset: 0xBCEC1 VA: 0xBCDC0
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBD260 Offset: 0xBD361 VA: 0xBD260
	// RVA: 0x16EECE0 Offset: 0x16EEDE1 VA: 0x16EECE0
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD270 Offset: 0xBD371 VA: 0xBD270
	// RVA: 0x16EECF0 Offset: 0x16EEDF1 VA: 0x16EECF0
	public bool get_RunSynchronously() { }

	// RVA: 0x16EED00 Offset: 0x16EEE01 VA: 0x16EED00
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD280 Offset: 0xBD381 VA: 0xBD280
	// RVA: 0x16EED30 Offset: 0x16EEE31 VA: 0x16EED30
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD290 Offset: 0xBD391 VA: 0xBD290
	// RVA: 0x16EED40 Offset: 0x16EEE41 VA: 0x16EED40
	protected void set_UserResult(int value) { }

	// RVA: 0x16EEA00 Offset: 0x16EEB01 VA: 0x16EEA00
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x16EED50 Offset: 0x16EEE51 VA: 0x16EED50
	internal void RequestRead(int size) { }

	// RVA: 0x16EEDF0 Offset: 0x16EEEF1 VA: 0x16EEDF0
	internal void RequestWrite() { }

	[AsyncStateMachineAttribute] // RVA: 0xBD2A0 Offset: 0xBD3A1 VA: 0xBD2A0
	// RVA: 0x16EEE00 Offset: 0x16EEF01 VA: 0x16EEE00
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD310 Offset: 0xBD411 VA: 0xBD310
	// RVA: 0x16EEF50 Offset: 0x16EF051 VA: 0x16EEF50
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD380 Offset: 0xBD481 VA: 0xBD380
	// RVA: 0x16EF0B0 Offset: 0x16EF1B1 VA: 0x16EF0B0
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0x16EF210 Offset: 0x16EF311 VA: 0x16EF210 Slot: 3
	public override string ToString() { }
}

internal abstract class AsyncProtocolRequest // TypeDefIndex: 1705
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBCDA0 Offset: 0xBCEA1 VA: 0xBCDA0
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBCDB0 Offset: 0xBCEB1 VA: 0xBCDB0
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBCDC0 Offset: 0xBCEC1 VA: 0xBCDC0
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBD260 Offset: 0xBD361 VA: 0xBD260
	// RVA: 0x16EECE0 Offset: 0x16EEDE1 VA: 0x16EECE0
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD270 Offset: 0xBD371 VA: 0xBD270
	// RVA: 0x16EECF0 Offset: 0x16EEDF1 VA: 0x16EECF0
	public bool get_RunSynchronously() { }

	// RVA: 0x16EED00 Offset: 0x16EEE01 VA: 0x16EED00
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD280 Offset: 0xBD381 VA: 0xBD280
	// RVA: 0x16EED30 Offset: 0x16EEE31 VA: 0x16EED30
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD290 Offset: 0xBD391 VA: 0xBD290
	// RVA: 0x16EED40 Offset: 0x16EEE41 VA: 0x16EED40
	protected void set_UserResult(int value) { }

	// RVA: 0x16EEA00 Offset: 0x16EEB01 VA: 0x16EEA00
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x16EED50 Offset: 0x16EEE51 VA: 0x16EED50
	internal void RequestRead(int size) { }

	// RVA: 0x16EEDF0 Offset: 0x16EEEF1 VA: 0x16EEDF0
	internal void RequestWrite() { }

	[AsyncStateMachineAttribute] // RVA: 0xBD2A0 Offset: 0xBD3A1 VA: 0xBD2A0
	// RVA: 0x16EEE00 Offset: 0x16EEF01 VA: 0x16EEE00
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD310 Offset: 0xBD411 VA: 0xBD310
	// RVA: 0x16EEF50 Offset: 0x16EF051 VA: 0x16EEF50
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD380 Offset: 0xBD481 VA: 0xBD380
	// RVA: 0x16EF0B0 Offset: 0x16EF1B1 VA: 0x16EF0B0
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0x16EF210 Offset: 0x16EF311 VA: 0x16EF210 Slot: 3
	public override string ToString() { }
}

internal abstract class AsyncProtocolRequest // TypeDefIndex: 1705
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBCDA0 Offset: 0xBCEA1 VA: 0xBCDA0
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBCDB0 Offset: 0xBCEB1 VA: 0xBCDB0
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBCDC0 Offset: 0xBCEC1 VA: 0xBCDC0
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBD260 Offset: 0xBD361 VA: 0xBD260
	// RVA: 0x16EECE0 Offset: 0x16EEDE1 VA: 0x16EECE0
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD270 Offset: 0xBD371 VA: 0xBD270
	// RVA: 0x16EECF0 Offset: 0x16EEDF1 VA: 0x16EECF0
	public bool get_RunSynchronously() { }

	// RVA: 0x16EED00 Offset: 0x16EEE01 VA: 0x16EED00
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD280 Offset: 0xBD381 VA: 0xBD280
	// RVA: 0x16EED30 Offset: 0x16EEE31 VA: 0x16EED30
	public int get_UserResult() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD290 Offset: 0xBD391 VA: 0xBD290
	// RVA: 0x16EED40 Offset: 0x16EEE41 VA: 0x16EED40
	protected void set_UserResult(int value) { }

	// RVA: 0x16EEA00 Offset: 0x16EEB01 VA: 0x16EEA00
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x16EED50 Offset: 0x16EEE51 VA: 0x16EED50
	internal void RequestRead(int size) { }

	// RVA: 0x16EEDF0 Offset: 0x16EEEF1 VA: 0x16EEDF0
	internal void RequestWrite() { }

	[AsyncStateMachineAttribute] // RVA: 0xBD2A0 Offset: 0xBD3A1 VA: 0xBD2A0
	// RVA: 0x16EEE00 Offset: 0x16EEF01 VA: 0x16EEE00
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD310 Offset: 0xBD411 VA: 0xBD310
	// RVA: 0x16EEF50 Offset: 0x16EF051 VA: 0x16EEF50
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD380 Offset: 0xBD481 VA: 0xBD380
	// RVA: 0x16EF0B0 Offset: 0x16EF1B1 VA: 0x16EF0B0
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0x16EF210 Offset: 0x16EF311 VA: 0x16EF210 Slot: 3
	public override string ToString() { }
}


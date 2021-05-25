internal struct ExecutionContext.Reader // TypeDefIndex: 787
{
	// Fields
	private ExecutionContext m_ec; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool IsFlowSuppressed { get; }
	public SynchronizationContext SynchronizationContext { get; }
	public SynchronizationContext SynchronizationContextNoFlow { get; }
	public LogicalCallContext.Reader LogicalCallContext { get; }

	// Methods

	// RVA: 0x174B0 Offset: 0x175B1 VA: 0x174B0
	public void .ctor(ExecutionContext ec) { }

	// RVA: 0x174C0 Offset: 0x175C1 VA: 0x174C0
	public ExecutionContext DangerousGetRawExecutionContext() { }

	// RVA: 0x174D0 Offset: 0x175D1 VA: 0x174D0
	public bool get_IsNull() { }

	// RVA: 0x174E0 Offset: 0x175E1 VA: 0x174E0
	public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x17570 Offset: 0x17671 VA: 0x17570
	public bool get_IsFlowSuppressed() { }

	// RVA: 0x17590 Offset: 0x17691 VA: 0x17590
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x175B0 Offset: 0x176B1 VA: 0x175B0
	public SynchronizationContext get_SynchronizationContextNoFlow() { }

	// RVA: 0x175D0 Offset: 0x176D1 VA: 0x175D0
	public LogicalCallContext.Reader get_LogicalCallContext() { }

	// RVA: 0x17670 Offset: 0x17771 VA: 0x17670
	public bool HasSameLocalValues(ExecutionContext other) { }
}


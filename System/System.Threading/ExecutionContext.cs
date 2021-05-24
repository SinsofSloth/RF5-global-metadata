[Serializable]
public sealed class ExecutionContext : IDisposable, ISerializable // TypeDefIndex: 785
{
	// Fields
	private SynchronizationContext _syncContext; // 0x10
	private SynchronizationContext _syncContextNoFlow; // 0x18
	private LogicalCallContext _logicalCallContext; // 0x20
	private IllogicalCallContext _illogicalCallContext; // 0x28
	private ExecutionContext.Flags _flags; // 0x30
	private Dictionary<IAsyncLocal, object> _localValues; // 0x38
	private List<IAsyncLocal> _localChangeNotifications; // 0x40
	private static readonly ExecutionContext s_dummyDefaultEC; // 0x0

	// Properties
	internal bool isNewCapture { get; set; }
	internal bool isFlowSuppressed { get; set; }
	internal static ExecutionContext PreAllocatedDefault { get; }
	internal bool IsPreAllocatedDefault { get; }
	internal LogicalCallContext LogicalCallContext { get; set; }
	internal IllogicalCallContext IllogicalCallContext { get; set; }
	internal SynchronizationContext SynchronizationContext { get; set; }
	internal SynchronizationContext SynchronizationContextNoFlow { get; set; }

	// Methods

	// RVA: 0x1A0DCA0 Offset: 0x1A0DDA1 VA: 0x1A0DCA0
	internal bool get_isNewCapture() { }

	// RVA: 0x1A0DCC0 Offset: 0x1A0DDC1 VA: 0x1A0DCC0
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x1A0DCE0 Offset: 0x1A0DDE1 VA: 0x1A0DCE0
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x1A0DCF0 Offset: 0x1A0DDF1 VA: 0x1A0DCF0
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x1A0DD10 Offset: 0x1A0DE11 VA: 0x1A0DD10
	internal static ExecutionContext get_PreAllocatedDefault() { }

	// RVA: 0x1A0DD80 Offset: 0x1A0DE81 VA: 0x1A0DD80
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContractAttribute] // RVA: 0xB8A70 Offset: 0xB8B71 VA: 0xB8A70
	// RVA: 0x1A0DD90 Offset: 0x1A0DE91 VA: 0x1A0DD90
	internal void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0xB8A90 Offset: 0xB8B91 VA: 0xB8A90
	// RVA: 0x1A0DDA0 Offset: 0x1A0DEA1 VA: 0x1A0DDA0
	internal void .ctor(bool isPreAllocatedDefault) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0xB8AB0 Offset: 0xB8BB1 VA: 0xB8AB0
	// RVA: 0x1A0DDE0 Offset: 0x1A0DEE1 VA: 0x1A0DDE0
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x1A0E3A0 Offset: 0x1A0E4A1 VA: 0x1A0E3A0
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x1A0E430 Offset: 0x1A0E531 VA: 0x1A0E430
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x1A0E440 Offset: 0x1A0E541 VA: 0x1A0E440
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x1A0E4D0 Offset: 0x1A0E5D1 VA: 0x1A0E4D0
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContractAttribute] // RVA: 0xB8AC0 Offset: 0xB8BC1 VA: 0xB8AC0
	// RVA: 0x1A0E4E0 Offset: 0x1A0E5E1 VA: 0x1A0E4E0
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContractAttribute] // RVA: 0xB8AE0 Offset: 0xB8BE1 VA: 0xB8AE0
	// RVA: 0x1A0E4F0 Offset: 0x1A0E5F1 VA: 0x1A0E4F0
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContractAttribute] // RVA: 0xB8B00 Offset: 0xB8C01 VA: 0xB8B00
	// RVA: 0x1A0E500 Offset: 0x1A0E601 VA: 0x1A0E500
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContractAttribute] // RVA: 0xB8B20 Offset: 0xB8C21 VA: 0xB8B20
	// RVA: 0x1A0E510 Offset: 0x1A0E611 VA: 0x1A0E510
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x1A0E520 Offset: 0x1A0E621 VA: 0x1A0E520 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A0A7D0 Offset: 0x1A0A8D1 VA: 0x1A0A7D0
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB8B40 Offset: 0xB8C41 VA: 0xB8B40
	// RVA: 0x1A0E530 Offset: 0x1A0E631 VA: 0x1A0E530
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0xB8B50 Offset: 0xB8C51 VA: 0xB8B50
	// RVA: 0x1A0E5C0 Offset: 0x1A0E6C1 VA: 0x1A0E5C0
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x1A0ED20 Offset: 0x1A0EE21 VA: 0x1A0ED20
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x1A0E9F0 Offset: 0x1A0EAF1 VA: 0x1A0E9F0
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0xB8B60 Offset: 0xB8C61 VA: 0xB8B60
	// RVA: 0x1A0EA60 Offset: 0x1A0EB61 VA: 0x1A0EA60
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x1A0EEF0 Offset: 0x1A0EFF1 VA: 0x1A0EEF0
	public ExecutionContext CreateCopy() { }

	// RVA: 0x1A0F0C0 Offset: 0x1A0F1C1 VA: 0x1A0F0C0
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x1A0F2C0 Offset: 0x1A0F3C1 VA: 0x1A0F2C0
	public static bool IsFlowSuppressed() { }

	// RVA: 0x1A0F300 Offset: 0x1A0F401 VA: 0x1A0F300
	public static ExecutionContext Capture() { }

	[FriendAccessAllowedAttribute] // RVA: 0xB8B70 Offset: 0xB8C71 VA: 0xB8B70
	// RVA: 0x1A0F370 Offset: 0x1A0F471 VA: 0x1A0F370
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x1A0AE40 Offset: 0x1A0AF41 VA: 0x1A0AE40
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x1A0F480 Offset: 0x1A0F581 VA: 0x1A0F480 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A0F580 Offset: 0x1A0F681 VA: 0x1A0F580
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A0E930 Offset: 0x1A0EA31 VA: 0x1A0E930
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x1A0F680 Offset: 0x1A0F781 VA: 0x1A0F680
	private static void .cctor() { }
}


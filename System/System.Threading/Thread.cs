[ComDefaultInterfaceAttribute] // RVA: 0xAF3D0 Offset: 0xAF4D1 VA: 0xAF3D0
[ClassInterfaceAttribute] // RVA: 0xAF3D0 Offset: 0xAF4D1 VA: 0xAF3D0
[ComVisibleAttribute] // RVA: 0xAF3D0 Offset: 0xAF4D1 VA: 0xAF3D0
public sealed class Thread : CriticalFinalizerObject, _Thread // TypeDefIndex: 804
{
	// Fields
	private static LocalDataStoreMgr s_LocalDataStoreMgr; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB5470 Offset: 0xB5571 VA: 0xB5470
	private static LocalDataStoreHolder s_LocalDataStore; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB5480 Offset: 0xB5581 VA: 0xB5480
	internal static CultureInfo m_CurrentCulture; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0xB5490 Offset: 0xB5591 VA: 0xB5490
	internal static CultureInfo m_CurrentUICulture; // 0x80000010
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; // 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
	private InternalThread internal_thread; // 0x10
	private object m_ThreadStartArg; // 0x18
	private object pending_exception; // 0x20
	private IPrincipal principal; // 0x28
	private int principal_version; // 0x30
	[ThreadStaticAttribute] // RVA: 0xB54A0 Offset: 0xB55A1 VA: 0xB54A0
	private static Thread current_thread; // 0x80000018
	private MulticastDelegate m_Delegate; // 0x38
	private ExecutionContext m_ExecutionContext; // 0x40
	private bool m_ExecutionContextBelongsToOuterScope; // 0x48

	// Properties
	internal bool ExecutionContextBelongsToCurrentScope { get; set; }
	public CultureInfo CurrentUICulture { get; }
	public CultureInfo CurrentCulture { get; }
	private InternalThread Internal { get; }
	public static Context CurrentContext { get; }
	public static Thread CurrentThread { get; }
	public bool IsThreadPoolThread { get; }
	internal bool IsThreadPoolThreadInternal { get; }
	public bool IsAlive { get; }
	public bool IsBackground { set; }
	public string Name { set; }
	public ThreadState ThreadState { get; }
	public int ManagedThreadId { get; }

	// Methods

	// RVA: 0x1589010 Offset: 0x1589111 VA: 0x1589010
	public void .ctor(ThreadStart start) { }

	// RVA: 0x1588AD0 Offset: 0x1588BD1 VA: 0x1588AD0
	public void .ctor(ParameterizedThreadStart start) { }

	// RVA: 0x1589200 Offset: 0x1589301 VA: 0x1589200
	public void Start() { }

	// RVA: 0x1588BE0 Offset: 0x1588CE1 VA: 0x1588BE0
	public void Start(object parameter) { }

	// RVA: 0x1589230 Offset: 0x1589331 VA: 0x1589230
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContractAttribute] // RVA: 0xB8C20 Offset: 0xB8D21 VA: 0xB8C20
	// RVA: 0x157A720 Offset: 0x157A821 VA: 0x157A720
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x15893D0 Offset: 0x15894D1 VA: 0x15893D0
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x15893E0 Offset: 0x15894E1 VA: 0x15893E0
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContractAttribute] // RVA: 0xB8C40 Offset: 0xB8D41 VA: 0xB8C40
	// RVA: 0x157A580 Offset: 0x157A681 VA: 0x157A580
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContractAttribute] // RVA: 0xB8C60 Offset: 0xB8D61 VA: 0xB8C60
	// RVA: 0x15893F0 Offset: 0x15894F1 VA: 0x15893F0
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContractAttribute] // RVA: 0xB8C80 Offset: 0xB8D81 VA: 0xB8C80
	// RVA: 0x1589430 Offset: 0x1589531 VA: 0x1589430
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x1589470 Offset: 0x1589571 VA: 0x1589470
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x1579F70 Offset: 0x157A071 VA: 0x1579F70
	public static void Sleep(int millisecondsTimeout) { }

	[ReliabilityContractAttribute] // RVA: 0xB8CA0 Offset: 0xB8DA1 VA: 0xB8CA0
	// RVA: 0x1589480 Offset: 0x1589581 VA: 0x1589480
	private static bool YieldInternal() { }

	[ReliabilityContractAttribute] // RVA: 0xB8CC0 Offset: 0xB8DC1 VA: 0xB8CC0
	// RVA: 0x157A020 Offset: 0x157A121 VA: 0x157A020
	public static bool Yield() { }

	// RVA: 0x15890C0 Offset: 0x15891C1 VA: 0x15890C0
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x1589610 Offset: 0x1589711 VA: 0x1589610
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x1589620 Offset: 0x1589721 VA: 0x1589620
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x15896F0 Offset: 0x15897F1 VA: 0x15896F0
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x1589700 Offset: 0x1589801 VA: 0x1589700
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x15897D0 Offset: 0x15898D1 VA: 0x15897D0
	public static void MemoryBarrier() { }

	// RVA: 0x15897E0 Offset: 0x15898E1 VA: 0x15897E0
	private void ConstructInternalThread() { }

	// RVA: 0x15897F0 Offset: 0x15898F1 VA: 0x15897F0
	private InternalThread get_Internal() { }

	// RVA: 0x1589830 Offset: 0x1589931 VA: 0x1589830
	public static Context get_CurrentContext() { }

	// RVA: 0x1589840 Offset: 0x1589941 VA: 0x1589840
	private static Thread GetCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0xB8CE0 Offset: 0xB8DE1 VA: 0xB8CE0
	// RVA: 0x157A030 Offset: 0x157A131 VA: 0x157A030
	public static Thread get_CurrentThread() { }

	// RVA: 0x1589850 Offset: 0x1589951 VA: 0x1589850
	public static int GetDomainID() { }

	// RVA: 0x1589860 Offset: 0x1589961 VA: 0x1589860
	private IntPtr Thread_internal(MulticastDelegate start) { }

	[ReliabilityContractAttribute] // RVA: 0xB8D00 Offset: 0xB8E01 VA: 0xB8D00
	// RVA: 0x1589870 Offset: 0x1589971 VA: 0x1589870 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1587FB0 Offset: 0x15880B1 VA: 0x1587FB0
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x1589880 Offset: 0x1589981 VA: 0x1589880
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x15898C0 Offset: 0x15899C1 VA: 0x15898C0
	public bool get_IsAlive() { }

	// RVA: 0x1588B80 Offset: 0x1588C81 VA: 0x1588B80
	public void set_IsBackground(bool value) { }

	// RVA: 0x1589A10 Offset: 0x1589B11 VA: 0x1589A10
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x1589A20 Offset: 0x1589B21 VA: 0x1589A20
	public void set_Name(string value) { }

	// RVA: 0x1583CC0 Offset: 0x1583DC1 VA: 0x1583CC0
	public ThreadState get_ThreadState() { }

	// RVA: 0x1589A70 Offset: 0x1589B71 VA: 0x1589A70
	private static void Abort_internal(InternalThread thread, object stateInfo) { }

	// RVA: 0x1589A80 Offset: 0x1589B81 VA: 0x1589A80
	public void Abort() { }

	// RVA: 0x1589AD0 Offset: 0x1589BD1 VA: 0x1589AD0
	private static void SpinWait_nop() { }

	[ReliabilityContractAttribute] // RVA: 0xB8D20 Offset: 0xB8E21 VA: 0xB8D20
	// RVA: 0x1579F30 Offset: 0x157A031 VA: 0x1579F30
	public static void SpinWait(int iterations) { }

	// RVA: 0x1589320 Offset: 0x1589421 VA: 0x1589320
	private void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x15899F0 Offset: 0x1589AF1 VA: 0x15899F0
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x1589A00 Offset: 0x1589B01 VA: 0x1589A00
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x1589930 Offset: 0x1589A31 VA: 0x1589930
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x1589AE0 Offset: 0x1589BE1 VA: 0x1589AE0
	private static int SystemMaxStackStize() { }

	// RVA: 0x1589490 Offset: 0x1589591 VA: 0x1589490
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x15895B0 Offset: 0x15896B1 VA: 0x15895B0
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContractAttribute] // RVA: 0xB8D40 Offset: 0xB8E41 VA: 0xB8D40
	// RVA: 0x157A0A0 Offset: 0x157A1A1 VA: 0x157A0A0
	public int get_ManagedThreadId() { }

	[ReliabilityContractAttribute] // RVA: 0xB8D60 Offset: 0xB8E61 VA: 0xB8D60
	// RVA: 0x15793D0 Offset: 0x15794D1 VA: 0x15793D0
	public static void BeginCriticalRegion() { }

	[ReliabilityContractAttribute] // RVA: 0xB8D80 Offset: 0xB8E81 VA: 0xB8D80
	// RVA: 0x1579BB0 Offset: 0x1579CB1 VA: 0x1579BB0
	public static void EndCriticalRegion() { }

	[ComVisibleAttribute] // RVA: 0xB8DA0 Offset: 0xB8EA1 VA: 0xB8DA0
	// RVA: 0x1589AF0 Offset: 0x1589BF1 VA: 0x1589AF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1589940 Offset: 0x1589A41 VA: 0x1589940
	private ThreadState ValidateThreadState() { }
}


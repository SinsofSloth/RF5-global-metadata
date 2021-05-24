internal class TaskExceptionHolder // TypeDefIndex: 873
{
	// Fields
	private static readonly bool s_failFastOnUnobservedException; // 0x0
	private static bool s_domainUnloadStarted; // 0x1
	private static EventHandler s_adUnloadEventHandler; // 0x8
	private readonly Task m_task; // 0x10
	private List<ExceptionDispatchInfo> m_faultExceptions; // 0x18
	private ExceptionDispatchInfo m_cancellationException; // 0x20
	private bool m_isHandled; // 0x28

	// Properties
	internal bool ContainsFaultList { get; }

	// Methods

	// RVA: 0x1580410 Offset: 0x1580511 VA: 0x1580410
	internal void .ctor(Task task) { }

	// RVA: 0x1585E00 Offset: 0x1585F01 VA: 0x1585E00
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x1585CD0 Offset: 0x1585DD1 VA: 0x1585CD0
	private static void EnsureADUnloadCallbackRegistered() { }

	// RVA: 0x1585E10 Offset: 0x1585F11 VA: 0x1585E10
	private static void AppDomainUnloadCallback(object sender, EventArgs e) { }

	// RVA: 0x1585E80 Offset: 0x1585F81 VA: 0x1585E80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x157F820 Offset: 0x157F921 VA: 0x157F820
	internal bool get_ContainsFaultList() { }

	// RVA: 0x15804B0 Offset: 0x15805B1 VA: 0x15804B0
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x15866D0 Offset: 0x15867D1 VA: 0x15866D0
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x1586820 Offset: 0x1586921 VA: 0x1586820
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x1586F90 Offset: 0x1587091 VA: 0x1586F90
	private void MarkAsUnhandled() { }

	// RVA: 0x15800C0 Offset: 0x15801C1 VA: 0x15800C0
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x1580570 Offset: 0x1580671 VA: 0x1580570
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x1580890 Offset: 0x1580991 VA: 0x1580890
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x1587010 Offset: 0x1587111 VA: 0x1587010
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x1587020 Offset: 0x1587121 VA: 0x1587020
	private static void .cctor() { }
}


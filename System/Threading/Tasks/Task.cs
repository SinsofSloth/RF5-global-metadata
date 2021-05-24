[DebuggerDisplayAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
[DebuggerTypeProxyAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 849
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0xB54E0 Offset: 0xB55E1 VA: 0xB54E0
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB54F0 Offset: 0xB55F1 VA: 0xB54F0
	private static StackGuard t_stackGuard; // 0x80000008
	internal static int s_taskIdCounter; // 0x0
	private static readonly TaskFactory s_factory; // 0x8
	private int m_taskId; // 0x10
	internal object m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x10
	[FriendAccessAllowedAttribute] // RVA: 0xB5500 Offset: 0xB5601 VA: 0xB5500
	internal static bool s_asyncDebuggingEnabled; // 0x18
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x20
	private static readonly object s_activeTasksLock; // 0x28
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x30
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x38
	private static Task s_completedTask; // 0x40
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x48
	private static ContextCallback s_ecCallback; // 0x50
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	internal bool IsRanToCompletion { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool IsSelfReplicatingRoot { get; }
	internal bool IsChildReplica { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }
	internal virtual object SavedStateForNextReplica { get; }
	internal virtual object SavedStateFromPreviousReplica { set; }
	internal virtual Task HandedOverChildReplica { get; set; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0xB9110 Offset: 0xB9211 VA: 0xB9110
	// RVA: 0x157C4C0 Offset: 0x157C5C1 VA: 0x157C4C0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9120 Offset: 0xB9221 VA: 0xB9120
	// RVA: 0x157D720 Offset: 0x157D821 VA: 0x157D720
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x157D850 Offset: 0x157D951 VA: 0x157D850
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x157D970 Offset: 0x157DA71 VA: 0x157D970
	internal void .ctor() { }

	// RVA: 0x157ACC0 Offset: 0x157ADC1 VA: 0x157ACC0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157D9B0 Offset: 0x157DAB1 VA: 0x157D9B0
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157DD90 Offset: 0x157DE91 VA: 0x157DD90
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x157E350 Offset: 0x157E451 VA: 0x157E350
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x157C050 Offset: 0x157C151 VA: 0x157C050
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x157E220 Offset: 0x157E321 VA: 0x157E220
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x157E6A0 Offset: 0x157E7A1 VA: 0x157E6A0
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x157E6B0 Offset: 0x157E7B1 VA: 0x157E6B0
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x157E740 Offset: 0x157E841 VA: 0x157E740
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x157E7E0 Offset: 0x157E8E1 VA: 0x157E7E0
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x157C1F0 Offset: 0x157C2F1 VA: 0x157C1F0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x157E910 Offset: 0x157EA11 VA: 0x157E910
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x157E950 Offset: 0x157EA51 VA: 0x157E950 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E8B0 Offset: 0x157E9B1 VA: 0x157E8B0
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x157E8E0 Offset: 0x157E9E1 VA: 0x157E8E0
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E980 Offset: 0x157EA81 VA: 0x157E980
	internal bool MarkStarted() { }

	// RVA: 0x157EA20 Offset: 0x157EB21 VA: 0x157EA20
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x157DC30 Offset: 0x157DD31 VA: 0x157DC30
	internal void AddNewChild() { }

	// RVA: 0x157E2A0 Offset: 0x157E3A1 VA: 0x157E2A0
	internal void DisregardChild() { }

	// RVA: 0x157EAB0 Offset: 0x157EBB1 VA: 0x157EAB0
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x157EC20 Offset: 0x157ED21 VA: 0x157EC20
	internal static int NewId() { }

	// RVA: 0x157C3C0 Offset: 0x157C4C1 VA: 0x157C3C0
	public int get_Id() { }

	// RVA: 0x157ECB0 Offset: 0x157EDB1 VA: 0x157ECB0
	internal static Task get_InternalCurrent() { }

	// RVA: 0x157BF70 Offset: 0x157C071 VA: 0x157BF70
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x157ED20 Offset: 0x157EE21 VA: 0x157ED20
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x157EE00 Offset: 0x157EF01 VA: 0x157EE00
	public AggregateException get_Exception() { }

	// RVA: 0x157EFF0 Offset: 0x157F0F1 VA: 0x157EFF0
	public TaskStatus get_Status() { }

	// RVA: 0x157C800 Offset: 0x157C901 VA: 0x157C800
	public bool get_IsCanceled() { }

	// RVA: 0x157F090 Offset: 0x157F191 VA: 0x157F090
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x157E1D0 Offset: 0x157E2D1 VA: 0x157E1D0
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x157F0F0 Offset: 0x157F1F1 VA: 0x157F0F0
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x157F1E0 Offset: 0x157F2E1 VA: 0x157F1E0
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x157F220 Offset: 0x157F321 VA: 0x157F220
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x157F250 Offset: 0x157F351 VA: 0x157F250 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x157F2D0 Offset: 0x157F3D1 VA: 0x157F2D0
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x157C7C0 Offset: 0x157C8C1 VA: 0x157C7C0
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x157DBB0 Offset: 0x157DCB1 VA: 0x157DBB0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x157F2E0 Offset: 0x157F3E1 VA: 0x157F2E0 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x157F590 Offset: 0x157F691 VA: 0x157F590 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x157F5A0 Offset: 0x157F6A1 VA: 0x157F5A0 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x157F5B0 Offset: 0x157F6B1 VA: 0x157F5B0
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x157F5C0 Offset: 0x157F6C1 VA: 0x157F5C0
	public static TaskFactory get_Factory() { }

	// RVA: 0x157F630 Offset: 0x157F731 VA: 0x157F630
	public static Task get_CompletedTask() { }

	// RVA: 0x157F390 Offset: 0x157F491 VA: 0x157F390
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x157EA30 Offset: 0x157EB31 VA: 0x157EA30
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x157F730 Offset: 0x157F831 VA: 0x157F730
	internal bool get_IsChildReplica() { }

	// RVA: 0x157F7B0 Offset: 0x157F8B1 VA: 0x157F7B0
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x157EE40 Offset: 0x157EF41 VA: 0x157EE40
	public bool get_IsFaulted() { }

	// RVA: 0x157F850 Offset: 0x157F951 VA: 0x157F850
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x157ADD0 Offset: 0x157AED1 VA: 0x157ADD0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x157F960 Offset: 0x157FA61 VA: 0x157F960
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x157FA70 Offset: 0x157FB71 VA: 0x157FA70 Slot: 10
	public void Dispose() { }

	// RVA: 0x157FAF0 Offset: 0x157FBF1 VA: 0x157FAF0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x157CAC0 Offset: 0x157CBC1 VA: 0x157CAC0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x157FCC0 Offset: 0x157FDC1 VA: 0x157FCC0
	internal void AddException(object exceptionObject) { }

	// RVA: 0x1580170 Offset: 0x1580271 VA: 0x1580170
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x157EE70 Offset: 0x157EF71 VA: 0x157EE70
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580790 Offset: 0x1580891 VA: 0x1580790
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x1580980 Offset: 0x1580A81 VA: 0x1580980
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x15809E0 Offset: 0x1580AE1 VA: 0x15809E0
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580A60 Offset: 0x1580B61 VA: 0x1580A60
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x1580BF0 Offset: 0x1580CF1 VA: 0x1580BF0
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x1580C20 Offset: 0x1580D21 VA: 0x1580C20
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x157FEA0 Offset: 0x157FFA1 VA: 0x157FEA0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x1580C50 Offset: 0x1580D51 VA: 0x1580C50
	internal void FinishStageTwo() { }

	// RVA: 0x1581230 Offset: 0x1581331 VA: 0x1581230
	internal void FinishStageThree() { }

	// RVA: 0x15812F0 Offset: 0x15813F1 VA: 0x15812F0
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x1580EA0 Offset: 0x1580FA1 VA: 0x1580EA0
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x157FCD0 Offset: 0x157FDD1 VA: 0x157FCD0
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x1581B60 Offset: 0x1581C61 VA: 0x1581B60
	private void Execute() { }

	// RVA: 0x1582020 Offset: 0x1582121 VA: 0x1582020 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x1582030 Offset: 0x1582131 VA: 0x1582030 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x15820F0 Offset: 0x15821F1 VA: 0x15820F0 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x1582100 Offset: 0x1582201 VA: 0x1582100 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x1582110 Offset: 0x1582211 VA: 0x1582110 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x1582120 Offset: 0x1582221 VA: 0x1582120 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x1581D80 Offset: 0x1581E81 VA: 0x1581D80
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x1582140 Offset: 0x1582241 VA: 0x1582140 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1582340 Offset: 0x1582441 VA: 0x1582340 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1582150 Offset: 0x1582251 VA: 0x1582150
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x1582400 Offset: 0x1582501 VA: 0x1582400
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x1582800 Offset: 0x1582901 VA: 0x1582800
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x1582880 Offset: 0x1582981 VA: 0x1582880 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x1582930 Offset: 0x1582A31 VA: 0x1582930
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x1581EE0 Offset: 0x1581FE1 VA: 0x1581EE0
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x1582990 Offset: 0x1582A91 VA: 0x1582990
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x15829C0 Offset: 0x1582AC1 VA: 0x15829C0
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x1582A00 Offset: 0x1582B01 VA: 0x1582A00
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x1582DD0 Offset: 0x1582ED1 VA: 0x1582DD0
	public void Wait() { }

	// RVA: 0x1582DE0 Offset: 0x1582EE1 VA: 0x1582DE0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583220 Offset: 0x1583321 VA: 0x1583220
	private bool WrappedTryRunInline() { }

	// RVA: 0x1582F80 Offset: 0x1583081 VA: 0x1582F80
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x15835A0 Offset: 0x15836A1 VA: 0x15835A0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583820 Offset: 0x1583921 VA: 0x1583820
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x157CE50 Offset: 0x157CF51 VA: 0x157CE50
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x1583B10 Offset: 0x1583C11 VA: 0x1583B10
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x1583BC0 Offset: 0x1583CC1 VA: 0x1583BC0
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x1583C80 Offset: 0x1583D81 VA: 0x1583C80
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x1582700 Offset: 0x1582801 VA: 0x1582700
	internal void CancellationCleanupLogic() { }

	// RVA: 0x1582960 Offset: 0x1582A61 VA: 0x1582960
	private void SetCancellationAcknowledged() { }

	// RVA: 0x1581480 Offset: 0x1581581 VA: 0x1581480
	internal void FinishContinuations() { }

	// RVA: 0x1583D00 Offset: 0x1583E01 VA: 0x1583D00
	private void LogFinishCompletionNotification() { }

	// RVA: 0x1583D10 Offset: 0x1583E11 VA: 0x1583D10
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x1583EB0 Offset: 0x1583FB1 VA: 0x1583EB0
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584350 Offset: 0x1584451 VA: 0x1584350
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1584390 Offset: 0x1584491 VA: 0x1584390
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584010 Offset: 0x1584111 VA: 0x1584010
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x1584150 Offset: 0x1584251 VA: 0x1584150
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x1584500 Offset: 0x1584601 VA: 0x1584500
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x1583A20 Offset: 0x1583B21 VA: 0x1583A20
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x1584510 Offset: 0x1584611 VA: 0x1584510
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x1582CE0 Offset: 0x1582DE1 VA: 0x1582CE0
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x157E420 Offset: 0x157E521 VA: 0x157E420
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC600 Offset: 0x21CC701 VA: 0x21CC600
	|-Task.FromResult<bool>
	|
	|-RVA: 0x21CC670 Offset: 0x21CC771 VA: 0x21CC670
	|-Task.FromResult<int>
	|
	|-RVA: 0x21CC6E0 Offset: 0x21CC7E1 VA: 0x21CC6E0
	|-Task.FromResult<long>
	|
	|-RVA: 0x21CC750 Offset: 0x21CC851 VA: 0x21CC750
	|-Task.FromResult<object>
	|
	|-RVA: 0x21CC7C0 Offset: 0x21CC8C1 VA: 0x21CC7C0
	|-Task.FromResult<SceneInstance>
	*/

	// RVA: 0x1584880 Offset: 0x1584981 VA: 0x1584880
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC330 Offset: 0x21CC431 VA: 0x21CC330
	|-Task.FromException<int>
	|
	|-RVA: 0x21CC420 Offset: 0x21CC521 VA: 0x21CC420
	|-Task.FromException<object>
	|
	|-RVA: 0x21CC510 Offset: 0x21CC611 VA: 0x21CC510
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0xB9130 Offset: 0xB9231 VA: 0xB9130
	// RVA: 0x15848F0 Offset: 0x15849F1 VA: 0x15848F0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9140 Offset: 0xB9241 VA: 0xB9140
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBD90 Offset: 0x21CBE91 VA: 0x21CBD90
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x21CBF70 Offset: 0x21CC071 VA: 0x21CBF70
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC150 Offset: 0x21CC251 VA: 0x21CC150
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBE80 Offset: 0x21CBF81 VA: 0x21CBE80
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC060 Offset: 0x21CC161 VA: 0x21CC060
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x21CC240 Offset: 0x21CC341 VA: 0x21CC240
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x15849B0 Offset: 0x1584AB1 VA: 0x15849B0
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC830 Offset: 0x21CC931 VA: 0x21CC830
	|-Task.Run<int>
	|
	|-RVA: 0x21CC9B0 Offset: 0x21CCAB1 VA: 0x21CC9B0
	|-Task.Run<object>
	*/

	// RVA: 0x1584AE0 Offset: 0x1584BE1 VA: 0x1584AE0
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x1578910 Offset: 0x1578A11 VA: 0x1578910
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x1578C40 Offset: 0x1578D41 VA: 0x1578C40
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x1585030 Offset: 0x1585131 VA: 0x1585030
	private static void .cctor() { }
}

[DebuggerDisplayAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
[DebuggerTypeProxyAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 849
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0xB54E0 Offset: 0xB55E1 VA: 0xB54E0
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB54F0 Offset: 0xB55F1 VA: 0xB54F0
	private static StackGuard t_stackGuard; // 0x80000008
	internal static int s_taskIdCounter; // 0x0
	private static readonly TaskFactory s_factory; // 0x8
	private int m_taskId; // 0x10
	internal object m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x10
	[FriendAccessAllowedAttribute] // RVA: 0xB5500 Offset: 0xB5601 VA: 0xB5500
	internal static bool s_asyncDebuggingEnabled; // 0x18
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x20
	private static readonly object s_activeTasksLock; // 0x28
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x30
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x38
	private static Task s_completedTask; // 0x40
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x48
	private static ContextCallback s_ecCallback; // 0x50
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	internal bool IsRanToCompletion { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool IsSelfReplicatingRoot { get; }
	internal bool IsChildReplica { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }
	internal virtual object SavedStateForNextReplica { get; }
	internal virtual object SavedStateFromPreviousReplica { set; }
	internal virtual Task HandedOverChildReplica { get; set; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0xB9110 Offset: 0xB9211 VA: 0xB9110
	// RVA: 0x157C4C0 Offset: 0x157C5C1 VA: 0x157C4C0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9120 Offset: 0xB9221 VA: 0xB9120
	// RVA: 0x157D720 Offset: 0x157D821 VA: 0x157D720
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x157D850 Offset: 0x157D951 VA: 0x157D850
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x157D970 Offset: 0x157DA71 VA: 0x157D970
	internal void .ctor() { }

	// RVA: 0x157ACC0 Offset: 0x157ADC1 VA: 0x157ACC0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157D9B0 Offset: 0x157DAB1 VA: 0x157D9B0
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157DD90 Offset: 0x157DE91 VA: 0x157DD90
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x157E350 Offset: 0x157E451 VA: 0x157E350
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x157C050 Offset: 0x157C151 VA: 0x157C050
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x157E220 Offset: 0x157E321 VA: 0x157E220
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x157E6A0 Offset: 0x157E7A1 VA: 0x157E6A0
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x157E6B0 Offset: 0x157E7B1 VA: 0x157E6B0
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x157E740 Offset: 0x157E841 VA: 0x157E740
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x157E7E0 Offset: 0x157E8E1 VA: 0x157E7E0
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x157C1F0 Offset: 0x157C2F1 VA: 0x157C1F0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x157E910 Offset: 0x157EA11 VA: 0x157E910
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x157E950 Offset: 0x157EA51 VA: 0x157E950 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E8B0 Offset: 0x157E9B1 VA: 0x157E8B0
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x157E8E0 Offset: 0x157E9E1 VA: 0x157E8E0
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E980 Offset: 0x157EA81 VA: 0x157E980
	internal bool MarkStarted() { }

	// RVA: 0x157EA20 Offset: 0x157EB21 VA: 0x157EA20
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x157DC30 Offset: 0x157DD31 VA: 0x157DC30
	internal void AddNewChild() { }

	// RVA: 0x157E2A0 Offset: 0x157E3A1 VA: 0x157E2A0
	internal void DisregardChild() { }

	// RVA: 0x157EAB0 Offset: 0x157EBB1 VA: 0x157EAB0
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x157EC20 Offset: 0x157ED21 VA: 0x157EC20
	internal static int NewId() { }

	// RVA: 0x157C3C0 Offset: 0x157C4C1 VA: 0x157C3C0
	public int get_Id() { }

	// RVA: 0x157ECB0 Offset: 0x157EDB1 VA: 0x157ECB0
	internal static Task get_InternalCurrent() { }

	// RVA: 0x157BF70 Offset: 0x157C071 VA: 0x157BF70
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x157ED20 Offset: 0x157EE21 VA: 0x157ED20
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x157EE00 Offset: 0x157EF01 VA: 0x157EE00
	public AggregateException get_Exception() { }

	// RVA: 0x157EFF0 Offset: 0x157F0F1 VA: 0x157EFF0
	public TaskStatus get_Status() { }

	// RVA: 0x157C800 Offset: 0x157C901 VA: 0x157C800
	public bool get_IsCanceled() { }

	// RVA: 0x157F090 Offset: 0x157F191 VA: 0x157F090
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x157E1D0 Offset: 0x157E2D1 VA: 0x157E1D0
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x157F0F0 Offset: 0x157F1F1 VA: 0x157F0F0
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x157F1E0 Offset: 0x157F2E1 VA: 0x157F1E0
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x157F220 Offset: 0x157F321 VA: 0x157F220
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x157F250 Offset: 0x157F351 VA: 0x157F250 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x157F2D0 Offset: 0x157F3D1 VA: 0x157F2D0
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x157C7C0 Offset: 0x157C8C1 VA: 0x157C7C0
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x157DBB0 Offset: 0x157DCB1 VA: 0x157DBB0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x157F2E0 Offset: 0x157F3E1 VA: 0x157F2E0 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x157F590 Offset: 0x157F691 VA: 0x157F590 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x157F5A0 Offset: 0x157F6A1 VA: 0x157F5A0 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x157F5B0 Offset: 0x157F6B1 VA: 0x157F5B0
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x157F5C0 Offset: 0x157F6C1 VA: 0x157F5C0
	public static TaskFactory get_Factory() { }

	// RVA: 0x157F630 Offset: 0x157F731 VA: 0x157F630
	public static Task get_CompletedTask() { }

	// RVA: 0x157F390 Offset: 0x157F491 VA: 0x157F390
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x157EA30 Offset: 0x157EB31 VA: 0x157EA30
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x157F730 Offset: 0x157F831 VA: 0x157F730
	internal bool get_IsChildReplica() { }

	// RVA: 0x157F7B0 Offset: 0x157F8B1 VA: 0x157F7B0
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x157EE40 Offset: 0x157EF41 VA: 0x157EE40
	public bool get_IsFaulted() { }

	// RVA: 0x157F850 Offset: 0x157F951 VA: 0x157F850
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x157ADD0 Offset: 0x157AED1 VA: 0x157ADD0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x157F960 Offset: 0x157FA61 VA: 0x157F960
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x157FA70 Offset: 0x157FB71 VA: 0x157FA70 Slot: 10
	public void Dispose() { }

	// RVA: 0x157FAF0 Offset: 0x157FBF1 VA: 0x157FAF0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x157CAC0 Offset: 0x157CBC1 VA: 0x157CAC0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x157FCC0 Offset: 0x157FDC1 VA: 0x157FCC0
	internal void AddException(object exceptionObject) { }

	// RVA: 0x1580170 Offset: 0x1580271 VA: 0x1580170
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x157EE70 Offset: 0x157EF71 VA: 0x157EE70
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580790 Offset: 0x1580891 VA: 0x1580790
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x1580980 Offset: 0x1580A81 VA: 0x1580980
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x15809E0 Offset: 0x1580AE1 VA: 0x15809E0
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580A60 Offset: 0x1580B61 VA: 0x1580A60
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x1580BF0 Offset: 0x1580CF1 VA: 0x1580BF0
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x1580C20 Offset: 0x1580D21 VA: 0x1580C20
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x157FEA0 Offset: 0x157FFA1 VA: 0x157FEA0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x1580C50 Offset: 0x1580D51 VA: 0x1580C50
	internal void FinishStageTwo() { }

	// RVA: 0x1581230 Offset: 0x1581331 VA: 0x1581230
	internal void FinishStageThree() { }

	// RVA: 0x15812F0 Offset: 0x15813F1 VA: 0x15812F0
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x1580EA0 Offset: 0x1580FA1 VA: 0x1580EA0
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x157FCD0 Offset: 0x157FDD1 VA: 0x157FCD0
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x1581B60 Offset: 0x1581C61 VA: 0x1581B60
	private void Execute() { }

	// RVA: 0x1582020 Offset: 0x1582121 VA: 0x1582020 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x1582030 Offset: 0x1582131 VA: 0x1582030 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x15820F0 Offset: 0x15821F1 VA: 0x15820F0 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x1582100 Offset: 0x1582201 VA: 0x1582100 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x1582110 Offset: 0x1582211 VA: 0x1582110 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x1582120 Offset: 0x1582221 VA: 0x1582120 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x1581D80 Offset: 0x1581E81 VA: 0x1581D80
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x1582140 Offset: 0x1582241 VA: 0x1582140 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1582340 Offset: 0x1582441 VA: 0x1582340 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1582150 Offset: 0x1582251 VA: 0x1582150
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x1582400 Offset: 0x1582501 VA: 0x1582400
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x1582800 Offset: 0x1582901 VA: 0x1582800
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x1582880 Offset: 0x1582981 VA: 0x1582880 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x1582930 Offset: 0x1582A31 VA: 0x1582930
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x1581EE0 Offset: 0x1581FE1 VA: 0x1581EE0
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x1582990 Offset: 0x1582A91 VA: 0x1582990
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x15829C0 Offset: 0x1582AC1 VA: 0x15829C0
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x1582A00 Offset: 0x1582B01 VA: 0x1582A00
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x1582DD0 Offset: 0x1582ED1 VA: 0x1582DD0
	public void Wait() { }

	// RVA: 0x1582DE0 Offset: 0x1582EE1 VA: 0x1582DE0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583220 Offset: 0x1583321 VA: 0x1583220
	private bool WrappedTryRunInline() { }

	// RVA: 0x1582F80 Offset: 0x1583081 VA: 0x1582F80
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x15835A0 Offset: 0x15836A1 VA: 0x15835A0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583820 Offset: 0x1583921 VA: 0x1583820
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x157CE50 Offset: 0x157CF51 VA: 0x157CE50
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x1583B10 Offset: 0x1583C11 VA: 0x1583B10
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x1583BC0 Offset: 0x1583CC1 VA: 0x1583BC0
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x1583C80 Offset: 0x1583D81 VA: 0x1583C80
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x1582700 Offset: 0x1582801 VA: 0x1582700
	internal void CancellationCleanupLogic() { }

	// RVA: 0x1582960 Offset: 0x1582A61 VA: 0x1582960
	private void SetCancellationAcknowledged() { }

	// RVA: 0x1581480 Offset: 0x1581581 VA: 0x1581480
	internal void FinishContinuations() { }

	// RVA: 0x1583D00 Offset: 0x1583E01 VA: 0x1583D00
	private void LogFinishCompletionNotification() { }

	// RVA: 0x1583D10 Offset: 0x1583E11 VA: 0x1583D10
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x1583EB0 Offset: 0x1583FB1 VA: 0x1583EB0
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584350 Offset: 0x1584451 VA: 0x1584350
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1584390 Offset: 0x1584491 VA: 0x1584390
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584010 Offset: 0x1584111 VA: 0x1584010
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x1584150 Offset: 0x1584251 VA: 0x1584150
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x1584500 Offset: 0x1584601 VA: 0x1584500
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x1583A20 Offset: 0x1583B21 VA: 0x1583A20
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x1584510 Offset: 0x1584611 VA: 0x1584510
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x1582CE0 Offset: 0x1582DE1 VA: 0x1582CE0
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x157E420 Offset: 0x157E521 VA: 0x157E420
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC600 Offset: 0x21CC701 VA: 0x21CC600
	|-Task.FromResult<bool>
	|
	|-RVA: 0x21CC670 Offset: 0x21CC771 VA: 0x21CC670
	|-Task.FromResult<int>
	|
	|-RVA: 0x21CC6E0 Offset: 0x21CC7E1 VA: 0x21CC6E0
	|-Task.FromResult<long>
	|
	|-RVA: 0x21CC750 Offset: 0x21CC851 VA: 0x21CC750
	|-Task.FromResult<object>
	|
	|-RVA: 0x21CC7C0 Offset: 0x21CC8C1 VA: 0x21CC7C0
	|-Task.FromResult<SceneInstance>
	*/

	// RVA: 0x1584880 Offset: 0x1584981 VA: 0x1584880
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC330 Offset: 0x21CC431 VA: 0x21CC330
	|-Task.FromException<int>
	|
	|-RVA: 0x21CC420 Offset: 0x21CC521 VA: 0x21CC420
	|-Task.FromException<object>
	|
	|-RVA: 0x21CC510 Offset: 0x21CC611 VA: 0x21CC510
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0xB9130 Offset: 0xB9231 VA: 0xB9130
	// RVA: 0x15848F0 Offset: 0x15849F1 VA: 0x15848F0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9140 Offset: 0xB9241 VA: 0xB9140
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBD90 Offset: 0x21CBE91 VA: 0x21CBD90
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x21CBF70 Offset: 0x21CC071 VA: 0x21CBF70
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC150 Offset: 0x21CC251 VA: 0x21CC150
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBE80 Offset: 0x21CBF81 VA: 0x21CBE80
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC060 Offset: 0x21CC161 VA: 0x21CC060
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x21CC240 Offset: 0x21CC341 VA: 0x21CC240
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x15849B0 Offset: 0x1584AB1 VA: 0x15849B0
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC830 Offset: 0x21CC931 VA: 0x21CC830
	|-Task.Run<int>
	|
	|-RVA: 0x21CC9B0 Offset: 0x21CCAB1 VA: 0x21CC9B0
	|-Task.Run<object>
	*/

	// RVA: 0x1584AE0 Offset: 0x1584BE1 VA: 0x1584AE0
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x1578910 Offset: 0x1578A11 VA: 0x1578910
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x1578C40 Offset: 0x1578D41 VA: 0x1578C40
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x1585030 Offset: 0x1585131 VA: 0x1585030
	private static void .cctor() { }
}

[DebuggerDisplayAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
[DebuggerTypeProxyAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 849
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0xB54E0 Offset: 0xB55E1 VA: 0xB54E0
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB54F0 Offset: 0xB55F1 VA: 0xB54F0
	private static StackGuard t_stackGuard; // 0x80000008
	internal static int s_taskIdCounter; // 0x0
	private static readonly TaskFactory s_factory; // 0x8
	private int m_taskId; // 0x10
	internal object m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x10
	[FriendAccessAllowedAttribute] // RVA: 0xB5500 Offset: 0xB5601 VA: 0xB5500
	internal static bool s_asyncDebuggingEnabled; // 0x18
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x20
	private static readonly object s_activeTasksLock; // 0x28
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x30
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x38
	private static Task s_completedTask; // 0x40
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x48
	private static ContextCallback s_ecCallback; // 0x50
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	internal bool IsRanToCompletion { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool IsSelfReplicatingRoot { get; }
	internal bool IsChildReplica { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }
	internal virtual object SavedStateForNextReplica { get; }
	internal virtual object SavedStateFromPreviousReplica { set; }
	internal virtual Task HandedOverChildReplica { get; set; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0xB9110 Offset: 0xB9211 VA: 0xB9110
	// RVA: 0x157C4C0 Offset: 0x157C5C1 VA: 0x157C4C0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9120 Offset: 0xB9221 VA: 0xB9120
	// RVA: 0x157D720 Offset: 0x157D821 VA: 0x157D720
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x157D850 Offset: 0x157D951 VA: 0x157D850
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x157D970 Offset: 0x157DA71 VA: 0x157D970
	internal void .ctor() { }

	// RVA: 0x157ACC0 Offset: 0x157ADC1 VA: 0x157ACC0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157D9B0 Offset: 0x157DAB1 VA: 0x157D9B0
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157DD90 Offset: 0x157DE91 VA: 0x157DD90
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x157E350 Offset: 0x157E451 VA: 0x157E350
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x157C050 Offset: 0x157C151 VA: 0x157C050
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x157E220 Offset: 0x157E321 VA: 0x157E220
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x157E6A0 Offset: 0x157E7A1 VA: 0x157E6A0
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x157E6B0 Offset: 0x157E7B1 VA: 0x157E6B0
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x157E740 Offset: 0x157E841 VA: 0x157E740
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x157E7E0 Offset: 0x157E8E1 VA: 0x157E7E0
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x157C1F0 Offset: 0x157C2F1 VA: 0x157C1F0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x157E910 Offset: 0x157EA11 VA: 0x157E910
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x157E950 Offset: 0x157EA51 VA: 0x157E950 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E8B0 Offset: 0x157E9B1 VA: 0x157E8B0
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x157E8E0 Offset: 0x157E9E1 VA: 0x157E8E0
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E980 Offset: 0x157EA81 VA: 0x157E980
	internal bool MarkStarted() { }

	// RVA: 0x157EA20 Offset: 0x157EB21 VA: 0x157EA20
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x157DC30 Offset: 0x157DD31 VA: 0x157DC30
	internal void AddNewChild() { }

	// RVA: 0x157E2A0 Offset: 0x157E3A1 VA: 0x157E2A0
	internal void DisregardChild() { }

	// RVA: 0x157EAB0 Offset: 0x157EBB1 VA: 0x157EAB0
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x157EC20 Offset: 0x157ED21 VA: 0x157EC20
	internal static int NewId() { }

	// RVA: 0x157C3C0 Offset: 0x157C4C1 VA: 0x157C3C0
	public int get_Id() { }

	// RVA: 0x157ECB0 Offset: 0x157EDB1 VA: 0x157ECB0
	internal static Task get_InternalCurrent() { }

	// RVA: 0x157BF70 Offset: 0x157C071 VA: 0x157BF70
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x157ED20 Offset: 0x157EE21 VA: 0x157ED20
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x157EE00 Offset: 0x157EF01 VA: 0x157EE00
	public AggregateException get_Exception() { }

	// RVA: 0x157EFF0 Offset: 0x157F0F1 VA: 0x157EFF0
	public TaskStatus get_Status() { }

	// RVA: 0x157C800 Offset: 0x157C901 VA: 0x157C800
	public bool get_IsCanceled() { }

	// RVA: 0x157F090 Offset: 0x157F191 VA: 0x157F090
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x157E1D0 Offset: 0x157E2D1 VA: 0x157E1D0
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x157F0F0 Offset: 0x157F1F1 VA: 0x157F0F0
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x157F1E0 Offset: 0x157F2E1 VA: 0x157F1E0
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x157F220 Offset: 0x157F321 VA: 0x157F220
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x157F250 Offset: 0x157F351 VA: 0x157F250 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x157F2D0 Offset: 0x157F3D1 VA: 0x157F2D0
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x157C7C0 Offset: 0x157C8C1 VA: 0x157C7C0
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x157DBB0 Offset: 0x157DCB1 VA: 0x157DBB0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x157F2E0 Offset: 0x157F3E1 VA: 0x157F2E0 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x157F590 Offset: 0x157F691 VA: 0x157F590 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x157F5A0 Offset: 0x157F6A1 VA: 0x157F5A0 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x157F5B0 Offset: 0x157F6B1 VA: 0x157F5B0
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x157F5C0 Offset: 0x157F6C1 VA: 0x157F5C0
	public static TaskFactory get_Factory() { }

	// RVA: 0x157F630 Offset: 0x157F731 VA: 0x157F630
	public static Task get_CompletedTask() { }

	// RVA: 0x157F390 Offset: 0x157F491 VA: 0x157F390
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x157EA30 Offset: 0x157EB31 VA: 0x157EA30
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x157F730 Offset: 0x157F831 VA: 0x157F730
	internal bool get_IsChildReplica() { }

	// RVA: 0x157F7B0 Offset: 0x157F8B1 VA: 0x157F7B0
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x157EE40 Offset: 0x157EF41 VA: 0x157EE40
	public bool get_IsFaulted() { }

	// RVA: 0x157F850 Offset: 0x157F951 VA: 0x157F850
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x157ADD0 Offset: 0x157AED1 VA: 0x157ADD0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x157F960 Offset: 0x157FA61 VA: 0x157F960
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x157FA70 Offset: 0x157FB71 VA: 0x157FA70 Slot: 10
	public void Dispose() { }

	// RVA: 0x157FAF0 Offset: 0x157FBF1 VA: 0x157FAF0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x157CAC0 Offset: 0x157CBC1 VA: 0x157CAC0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x157FCC0 Offset: 0x157FDC1 VA: 0x157FCC0
	internal void AddException(object exceptionObject) { }

	// RVA: 0x1580170 Offset: 0x1580271 VA: 0x1580170
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x157EE70 Offset: 0x157EF71 VA: 0x157EE70
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580790 Offset: 0x1580891 VA: 0x1580790
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x1580980 Offset: 0x1580A81 VA: 0x1580980
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x15809E0 Offset: 0x1580AE1 VA: 0x15809E0
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580A60 Offset: 0x1580B61 VA: 0x1580A60
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x1580BF0 Offset: 0x1580CF1 VA: 0x1580BF0
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x1580C20 Offset: 0x1580D21 VA: 0x1580C20
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x157FEA0 Offset: 0x157FFA1 VA: 0x157FEA0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x1580C50 Offset: 0x1580D51 VA: 0x1580C50
	internal void FinishStageTwo() { }

	// RVA: 0x1581230 Offset: 0x1581331 VA: 0x1581230
	internal void FinishStageThree() { }

	// RVA: 0x15812F0 Offset: 0x15813F1 VA: 0x15812F0
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x1580EA0 Offset: 0x1580FA1 VA: 0x1580EA0
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x157FCD0 Offset: 0x157FDD1 VA: 0x157FCD0
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x1581B60 Offset: 0x1581C61 VA: 0x1581B60
	private void Execute() { }

	// RVA: 0x1582020 Offset: 0x1582121 VA: 0x1582020 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x1582030 Offset: 0x1582131 VA: 0x1582030 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x15820F0 Offset: 0x15821F1 VA: 0x15820F0 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x1582100 Offset: 0x1582201 VA: 0x1582100 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x1582110 Offset: 0x1582211 VA: 0x1582110 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x1582120 Offset: 0x1582221 VA: 0x1582120 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x1581D80 Offset: 0x1581E81 VA: 0x1581D80
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x1582140 Offset: 0x1582241 VA: 0x1582140 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1582340 Offset: 0x1582441 VA: 0x1582340 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1582150 Offset: 0x1582251 VA: 0x1582150
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x1582400 Offset: 0x1582501 VA: 0x1582400
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x1582800 Offset: 0x1582901 VA: 0x1582800
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x1582880 Offset: 0x1582981 VA: 0x1582880 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x1582930 Offset: 0x1582A31 VA: 0x1582930
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x1581EE0 Offset: 0x1581FE1 VA: 0x1581EE0
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x1582990 Offset: 0x1582A91 VA: 0x1582990
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x15829C0 Offset: 0x1582AC1 VA: 0x15829C0
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x1582A00 Offset: 0x1582B01 VA: 0x1582A00
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x1582DD0 Offset: 0x1582ED1 VA: 0x1582DD0
	public void Wait() { }

	// RVA: 0x1582DE0 Offset: 0x1582EE1 VA: 0x1582DE0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583220 Offset: 0x1583321 VA: 0x1583220
	private bool WrappedTryRunInline() { }

	// RVA: 0x1582F80 Offset: 0x1583081 VA: 0x1582F80
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x15835A0 Offset: 0x15836A1 VA: 0x15835A0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583820 Offset: 0x1583921 VA: 0x1583820
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x157CE50 Offset: 0x157CF51 VA: 0x157CE50
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x1583B10 Offset: 0x1583C11 VA: 0x1583B10
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x1583BC0 Offset: 0x1583CC1 VA: 0x1583BC0
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x1583C80 Offset: 0x1583D81 VA: 0x1583C80
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x1582700 Offset: 0x1582801 VA: 0x1582700
	internal void CancellationCleanupLogic() { }

	// RVA: 0x1582960 Offset: 0x1582A61 VA: 0x1582960
	private void SetCancellationAcknowledged() { }

	// RVA: 0x1581480 Offset: 0x1581581 VA: 0x1581480
	internal void FinishContinuations() { }

	// RVA: 0x1583D00 Offset: 0x1583E01 VA: 0x1583D00
	private void LogFinishCompletionNotification() { }

	// RVA: 0x1583D10 Offset: 0x1583E11 VA: 0x1583D10
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x1583EB0 Offset: 0x1583FB1 VA: 0x1583EB0
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584350 Offset: 0x1584451 VA: 0x1584350
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1584390 Offset: 0x1584491 VA: 0x1584390
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584010 Offset: 0x1584111 VA: 0x1584010
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x1584150 Offset: 0x1584251 VA: 0x1584150
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x1584500 Offset: 0x1584601 VA: 0x1584500
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x1583A20 Offset: 0x1583B21 VA: 0x1583A20
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x1584510 Offset: 0x1584611 VA: 0x1584510
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x1582CE0 Offset: 0x1582DE1 VA: 0x1582CE0
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x157E420 Offset: 0x157E521 VA: 0x157E420
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC600 Offset: 0x21CC701 VA: 0x21CC600
	|-Task.FromResult<bool>
	|
	|-RVA: 0x21CC670 Offset: 0x21CC771 VA: 0x21CC670
	|-Task.FromResult<int>
	|
	|-RVA: 0x21CC6E0 Offset: 0x21CC7E1 VA: 0x21CC6E0
	|-Task.FromResult<long>
	|
	|-RVA: 0x21CC750 Offset: 0x21CC851 VA: 0x21CC750
	|-Task.FromResult<object>
	|
	|-RVA: 0x21CC7C0 Offset: 0x21CC8C1 VA: 0x21CC7C0
	|-Task.FromResult<SceneInstance>
	*/

	// RVA: 0x1584880 Offset: 0x1584981 VA: 0x1584880
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC330 Offset: 0x21CC431 VA: 0x21CC330
	|-Task.FromException<int>
	|
	|-RVA: 0x21CC420 Offset: 0x21CC521 VA: 0x21CC420
	|-Task.FromException<object>
	|
	|-RVA: 0x21CC510 Offset: 0x21CC611 VA: 0x21CC510
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0xB9130 Offset: 0xB9231 VA: 0xB9130
	// RVA: 0x15848F0 Offset: 0x15849F1 VA: 0x15848F0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9140 Offset: 0xB9241 VA: 0xB9140
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBD90 Offset: 0x21CBE91 VA: 0x21CBD90
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x21CBF70 Offset: 0x21CC071 VA: 0x21CBF70
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC150 Offset: 0x21CC251 VA: 0x21CC150
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBE80 Offset: 0x21CBF81 VA: 0x21CBE80
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC060 Offset: 0x21CC161 VA: 0x21CC060
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x21CC240 Offset: 0x21CC341 VA: 0x21CC240
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x15849B0 Offset: 0x1584AB1 VA: 0x15849B0
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC830 Offset: 0x21CC931 VA: 0x21CC830
	|-Task.Run<int>
	|
	|-RVA: 0x21CC9B0 Offset: 0x21CCAB1 VA: 0x21CC9B0
	|-Task.Run<object>
	*/

	// RVA: 0x1584AE0 Offset: 0x1584BE1 VA: 0x1584AE0
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x1578910 Offset: 0x1578A11 VA: 0x1578910
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x1578C40 Offset: 0x1578D41 VA: 0x1578C40
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x1585030 Offset: 0x1585131 VA: 0x1585030
	private static void .cctor() { }
}

[DebuggerDisplayAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
[DebuggerTypeProxyAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 849
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0xB54E0 Offset: 0xB55E1 VA: 0xB54E0
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB54F0 Offset: 0xB55F1 VA: 0xB54F0
	private static StackGuard t_stackGuard; // 0x80000008
	internal static int s_taskIdCounter; // 0x0
	private static readonly TaskFactory s_factory; // 0x8
	private int m_taskId; // 0x10
	internal object m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x10
	[FriendAccessAllowedAttribute] // RVA: 0xB5500 Offset: 0xB5601 VA: 0xB5500
	internal static bool s_asyncDebuggingEnabled; // 0x18
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x20
	private static readonly object s_activeTasksLock; // 0x28
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x30
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x38
	private static Task s_completedTask; // 0x40
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x48
	private static ContextCallback s_ecCallback; // 0x50
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	internal bool IsRanToCompletion { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool IsSelfReplicatingRoot { get; }
	internal bool IsChildReplica { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }
	internal virtual object SavedStateForNextReplica { get; }
	internal virtual object SavedStateFromPreviousReplica { set; }
	internal virtual Task HandedOverChildReplica { get; set; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0xB9110 Offset: 0xB9211 VA: 0xB9110
	// RVA: 0x157C4C0 Offset: 0x157C5C1 VA: 0x157C4C0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9120 Offset: 0xB9221 VA: 0xB9120
	// RVA: 0x157D720 Offset: 0x157D821 VA: 0x157D720
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x157D850 Offset: 0x157D951 VA: 0x157D850
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x157D970 Offset: 0x157DA71 VA: 0x157D970
	internal void .ctor() { }

	// RVA: 0x157ACC0 Offset: 0x157ADC1 VA: 0x157ACC0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157D9B0 Offset: 0x157DAB1 VA: 0x157D9B0
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157DD90 Offset: 0x157DE91 VA: 0x157DD90
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x157E350 Offset: 0x157E451 VA: 0x157E350
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x157C050 Offset: 0x157C151 VA: 0x157C050
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x157E220 Offset: 0x157E321 VA: 0x157E220
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x157E6A0 Offset: 0x157E7A1 VA: 0x157E6A0
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x157E6B0 Offset: 0x157E7B1 VA: 0x157E6B0
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x157E740 Offset: 0x157E841 VA: 0x157E740
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x157E7E0 Offset: 0x157E8E1 VA: 0x157E7E0
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x157C1F0 Offset: 0x157C2F1 VA: 0x157C1F0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x157E910 Offset: 0x157EA11 VA: 0x157E910
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x157E950 Offset: 0x157EA51 VA: 0x157E950 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E8B0 Offset: 0x157E9B1 VA: 0x157E8B0
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x157E8E0 Offset: 0x157E9E1 VA: 0x157E8E0
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E980 Offset: 0x157EA81 VA: 0x157E980
	internal bool MarkStarted() { }

	// RVA: 0x157EA20 Offset: 0x157EB21 VA: 0x157EA20
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x157DC30 Offset: 0x157DD31 VA: 0x157DC30
	internal void AddNewChild() { }

	// RVA: 0x157E2A0 Offset: 0x157E3A1 VA: 0x157E2A0
	internal void DisregardChild() { }

	// RVA: 0x157EAB0 Offset: 0x157EBB1 VA: 0x157EAB0
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x157EC20 Offset: 0x157ED21 VA: 0x157EC20
	internal static int NewId() { }

	// RVA: 0x157C3C0 Offset: 0x157C4C1 VA: 0x157C3C0
	public int get_Id() { }

	// RVA: 0x157ECB0 Offset: 0x157EDB1 VA: 0x157ECB0
	internal static Task get_InternalCurrent() { }

	// RVA: 0x157BF70 Offset: 0x157C071 VA: 0x157BF70
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x157ED20 Offset: 0x157EE21 VA: 0x157ED20
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x157EE00 Offset: 0x157EF01 VA: 0x157EE00
	public AggregateException get_Exception() { }

	// RVA: 0x157EFF0 Offset: 0x157F0F1 VA: 0x157EFF0
	public TaskStatus get_Status() { }

	// RVA: 0x157C800 Offset: 0x157C901 VA: 0x157C800
	public bool get_IsCanceled() { }

	// RVA: 0x157F090 Offset: 0x157F191 VA: 0x157F090
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x157E1D0 Offset: 0x157E2D1 VA: 0x157E1D0
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x157F0F0 Offset: 0x157F1F1 VA: 0x157F0F0
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x157F1E0 Offset: 0x157F2E1 VA: 0x157F1E0
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x157F220 Offset: 0x157F321 VA: 0x157F220
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x157F250 Offset: 0x157F351 VA: 0x157F250 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x157F2D0 Offset: 0x157F3D1 VA: 0x157F2D0
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x157C7C0 Offset: 0x157C8C1 VA: 0x157C7C0
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x157DBB0 Offset: 0x157DCB1 VA: 0x157DBB0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x157F2E0 Offset: 0x157F3E1 VA: 0x157F2E0 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x157F590 Offset: 0x157F691 VA: 0x157F590 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x157F5A0 Offset: 0x157F6A1 VA: 0x157F5A0 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x157F5B0 Offset: 0x157F6B1 VA: 0x157F5B0
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x157F5C0 Offset: 0x157F6C1 VA: 0x157F5C0
	public static TaskFactory get_Factory() { }

	// RVA: 0x157F630 Offset: 0x157F731 VA: 0x157F630
	public static Task get_CompletedTask() { }

	// RVA: 0x157F390 Offset: 0x157F491 VA: 0x157F390
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x157EA30 Offset: 0x157EB31 VA: 0x157EA30
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x157F730 Offset: 0x157F831 VA: 0x157F730
	internal bool get_IsChildReplica() { }

	// RVA: 0x157F7B0 Offset: 0x157F8B1 VA: 0x157F7B0
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x157EE40 Offset: 0x157EF41 VA: 0x157EE40
	public bool get_IsFaulted() { }

	// RVA: 0x157F850 Offset: 0x157F951 VA: 0x157F850
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x157ADD0 Offset: 0x157AED1 VA: 0x157ADD0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x157F960 Offset: 0x157FA61 VA: 0x157F960
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x157FA70 Offset: 0x157FB71 VA: 0x157FA70 Slot: 10
	public void Dispose() { }

	// RVA: 0x157FAF0 Offset: 0x157FBF1 VA: 0x157FAF0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x157CAC0 Offset: 0x157CBC1 VA: 0x157CAC0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x157FCC0 Offset: 0x157FDC1 VA: 0x157FCC0
	internal void AddException(object exceptionObject) { }

	// RVA: 0x1580170 Offset: 0x1580271 VA: 0x1580170
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x157EE70 Offset: 0x157EF71 VA: 0x157EE70
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580790 Offset: 0x1580891 VA: 0x1580790
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x1580980 Offset: 0x1580A81 VA: 0x1580980
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x15809E0 Offset: 0x1580AE1 VA: 0x15809E0
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580A60 Offset: 0x1580B61 VA: 0x1580A60
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x1580BF0 Offset: 0x1580CF1 VA: 0x1580BF0
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x1580C20 Offset: 0x1580D21 VA: 0x1580C20
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x157FEA0 Offset: 0x157FFA1 VA: 0x157FEA0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x1580C50 Offset: 0x1580D51 VA: 0x1580C50
	internal void FinishStageTwo() { }

	// RVA: 0x1581230 Offset: 0x1581331 VA: 0x1581230
	internal void FinishStageThree() { }

	// RVA: 0x15812F0 Offset: 0x15813F1 VA: 0x15812F0
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x1580EA0 Offset: 0x1580FA1 VA: 0x1580EA0
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x157FCD0 Offset: 0x157FDD1 VA: 0x157FCD0
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x1581B60 Offset: 0x1581C61 VA: 0x1581B60
	private void Execute() { }

	// RVA: 0x1582020 Offset: 0x1582121 VA: 0x1582020 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x1582030 Offset: 0x1582131 VA: 0x1582030 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x15820F0 Offset: 0x15821F1 VA: 0x15820F0 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x1582100 Offset: 0x1582201 VA: 0x1582100 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x1582110 Offset: 0x1582211 VA: 0x1582110 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x1582120 Offset: 0x1582221 VA: 0x1582120 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x1581D80 Offset: 0x1581E81 VA: 0x1581D80
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x1582140 Offset: 0x1582241 VA: 0x1582140 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1582340 Offset: 0x1582441 VA: 0x1582340 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1582150 Offset: 0x1582251 VA: 0x1582150
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x1582400 Offset: 0x1582501 VA: 0x1582400
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x1582800 Offset: 0x1582901 VA: 0x1582800
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x1582880 Offset: 0x1582981 VA: 0x1582880 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x1582930 Offset: 0x1582A31 VA: 0x1582930
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x1581EE0 Offset: 0x1581FE1 VA: 0x1581EE0
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x1582990 Offset: 0x1582A91 VA: 0x1582990
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x15829C0 Offset: 0x1582AC1 VA: 0x15829C0
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x1582A00 Offset: 0x1582B01 VA: 0x1582A00
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x1582DD0 Offset: 0x1582ED1 VA: 0x1582DD0
	public void Wait() { }

	// RVA: 0x1582DE0 Offset: 0x1582EE1 VA: 0x1582DE0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583220 Offset: 0x1583321 VA: 0x1583220
	private bool WrappedTryRunInline() { }

	// RVA: 0x1582F80 Offset: 0x1583081 VA: 0x1582F80
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x15835A0 Offset: 0x15836A1 VA: 0x15835A0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583820 Offset: 0x1583921 VA: 0x1583820
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x157CE50 Offset: 0x157CF51 VA: 0x157CE50
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x1583B10 Offset: 0x1583C11 VA: 0x1583B10
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x1583BC0 Offset: 0x1583CC1 VA: 0x1583BC0
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x1583C80 Offset: 0x1583D81 VA: 0x1583C80
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x1582700 Offset: 0x1582801 VA: 0x1582700
	internal void CancellationCleanupLogic() { }

	// RVA: 0x1582960 Offset: 0x1582A61 VA: 0x1582960
	private void SetCancellationAcknowledged() { }

	// RVA: 0x1581480 Offset: 0x1581581 VA: 0x1581480
	internal void FinishContinuations() { }

	// RVA: 0x1583D00 Offset: 0x1583E01 VA: 0x1583D00
	private void LogFinishCompletionNotification() { }

	// RVA: 0x1583D10 Offset: 0x1583E11 VA: 0x1583D10
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x1583EB0 Offset: 0x1583FB1 VA: 0x1583EB0
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584350 Offset: 0x1584451 VA: 0x1584350
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1584390 Offset: 0x1584491 VA: 0x1584390
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584010 Offset: 0x1584111 VA: 0x1584010
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x1584150 Offset: 0x1584251 VA: 0x1584150
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x1584500 Offset: 0x1584601 VA: 0x1584500
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x1583A20 Offset: 0x1583B21 VA: 0x1583A20
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x1584510 Offset: 0x1584611 VA: 0x1584510
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x1582CE0 Offset: 0x1582DE1 VA: 0x1582CE0
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x157E420 Offset: 0x157E521 VA: 0x157E420
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC600 Offset: 0x21CC701 VA: 0x21CC600
	|-Task.FromResult<bool>
	|
	|-RVA: 0x21CC670 Offset: 0x21CC771 VA: 0x21CC670
	|-Task.FromResult<int>
	|
	|-RVA: 0x21CC6E0 Offset: 0x21CC7E1 VA: 0x21CC6E0
	|-Task.FromResult<long>
	|
	|-RVA: 0x21CC750 Offset: 0x21CC851 VA: 0x21CC750
	|-Task.FromResult<object>
	|
	|-RVA: 0x21CC7C0 Offset: 0x21CC8C1 VA: 0x21CC7C0
	|-Task.FromResult<SceneInstance>
	*/

	// RVA: 0x1584880 Offset: 0x1584981 VA: 0x1584880
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC330 Offset: 0x21CC431 VA: 0x21CC330
	|-Task.FromException<int>
	|
	|-RVA: 0x21CC420 Offset: 0x21CC521 VA: 0x21CC420
	|-Task.FromException<object>
	|
	|-RVA: 0x21CC510 Offset: 0x21CC611 VA: 0x21CC510
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0xB9130 Offset: 0xB9231 VA: 0xB9130
	// RVA: 0x15848F0 Offset: 0x15849F1 VA: 0x15848F0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9140 Offset: 0xB9241 VA: 0xB9140
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBD90 Offset: 0x21CBE91 VA: 0x21CBD90
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x21CBF70 Offset: 0x21CC071 VA: 0x21CBF70
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC150 Offset: 0x21CC251 VA: 0x21CC150
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBE80 Offset: 0x21CBF81 VA: 0x21CBE80
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC060 Offset: 0x21CC161 VA: 0x21CC060
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x21CC240 Offset: 0x21CC341 VA: 0x21CC240
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x15849B0 Offset: 0x1584AB1 VA: 0x15849B0
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC830 Offset: 0x21CC931 VA: 0x21CC830
	|-Task.Run<int>
	|
	|-RVA: 0x21CC9B0 Offset: 0x21CCAB1 VA: 0x21CC9B0
	|-Task.Run<object>
	*/

	// RVA: 0x1584AE0 Offset: 0x1584BE1 VA: 0x1584AE0
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x1578910 Offset: 0x1578A11 VA: 0x1578910
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x1578C40 Offset: 0x1578D41 VA: 0x1578C40
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x1585030 Offset: 0x1585131 VA: 0x1585030
	private static void .cctor() { }
}

[DebuggerDisplayAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
[DebuggerTypeProxyAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 849
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0xB54E0 Offset: 0xB55E1 VA: 0xB54E0
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB54F0 Offset: 0xB55F1 VA: 0xB54F0
	private static StackGuard t_stackGuard; // 0x80000008
	internal static int s_taskIdCounter; // 0x0
	private static readonly TaskFactory s_factory; // 0x8
	private int m_taskId; // 0x10
	internal object m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x10
	[FriendAccessAllowedAttribute] // RVA: 0xB5500 Offset: 0xB5601 VA: 0xB5500
	internal static bool s_asyncDebuggingEnabled; // 0x18
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x20
	private static readonly object s_activeTasksLock; // 0x28
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x30
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x38
	private static Task s_completedTask; // 0x40
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x48
	private static ContextCallback s_ecCallback; // 0x50
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	internal bool IsRanToCompletion { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool IsSelfReplicatingRoot { get; }
	internal bool IsChildReplica { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }
	internal virtual object SavedStateForNextReplica { get; }
	internal virtual object SavedStateFromPreviousReplica { set; }
	internal virtual Task HandedOverChildReplica { get; set; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0xB9110 Offset: 0xB9211 VA: 0xB9110
	// RVA: 0x157C4C0 Offset: 0x157C5C1 VA: 0x157C4C0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9120 Offset: 0xB9221 VA: 0xB9120
	// RVA: 0x157D720 Offset: 0x157D821 VA: 0x157D720
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x157D850 Offset: 0x157D951 VA: 0x157D850
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x157D970 Offset: 0x157DA71 VA: 0x157D970
	internal void .ctor() { }

	// RVA: 0x157ACC0 Offset: 0x157ADC1 VA: 0x157ACC0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157D9B0 Offset: 0x157DAB1 VA: 0x157D9B0
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157DD90 Offset: 0x157DE91 VA: 0x157DD90
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x157E350 Offset: 0x157E451 VA: 0x157E350
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x157C050 Offset: 0x157C151 VA: 0x157C050
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x157E220 Offset: 0x157E321 VA: 0x157E220
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x157E6A0 Offset: 0x157E7A1 VA: 0x157E6A0
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x157E6B0 Offset: 0x157E7B1 VA: 0x157E6B0
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x157E740 Offset: 0x157E841 VA: 0x157E740
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x157E7E0 Offset: 0x157E8E1 VA: 0x157E7E0
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x157C1F0 Offset: 0x157C2F1 VA: 0x157C1F0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x157E910 Offset: 0x157EA11 VA: 0x157E910
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x157E950 Offset: 0x157EA51 VA: 0x157E950 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E8B0 Offset: 0x157E9B1 VA: 0x157E8B0
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x157E8E0 Offset: 0x157E9E1 VA: 0x157E8E0
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E980 Offset: 0x157EA81 VA: 0x157E980
	internal bool MarkStarted() { }

	// RVA: 0x157EA20 Offset: 0x157EB21 VA: 0x157EA20
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x157DC30 Offset: 0x157DD31 VA: 0x157DC30
	internal void AddNewChild() { }

	// RVA: 0x157E2A0 Offset: 0x157E3A1 VA: 0x157E2A0
	internal void DisregardChild() { }

	// RVA: 0x157EAB0 Offset: 0x157EBB1 VA: 0x157EAB0
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x157EC20 Offset: 0x157ED21 VA: 0x157EC20
	internal static int NewId() { }

	// RVA: 0x157C3C0 Offset: 0x157C4C1 VA: 0x157C3C0
	public int get_Id() { }

	// RVA: 0x157ECB0 Offset: 0x157EDB1 VA: 0x157ECB0
	internal static Task get_InternalCurrent() { }

	// RVA: 0x157BF70 Offset: 0x157C071 VA: 0x157BF70
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x157ED20 Offset: 0x157EE21 VA: 0x157ED20
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x157EE00 Offset: 0x157EF01 VA: 0x157EE00
	public AggregateException get_Exception() { }

	// RVA: 0x157EFF0 Offset: 0x157F0F1 VA: 0x157EFF0
	public TaskStatus get_Status() { }

	// RVA: 0x157C800 Offset: 0x157C901 VA: 0x157C800
	public bool get_IsCanceled() { }

	// RVA: 0x157F090 Offset: 0x157F191 VA: 0x157F090
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x157E1D0 Offset: 0x157E2D1 VA: 0x157E1D0
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x157F0F0 Offset: 0x157F1F1 VA: 0x157F0F0
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x157F1E0 Offset: 0x157F2E1 VA: 0x157F1E0
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x157F220 Offset: 0x157F321 VA: 0x157F220
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x157F250 Offset: 0x157F351 VA: 0x157F250 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x157F2D0 Offset: 0x157F3D1 VA: 0x157F2D0
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x157C7C0 Offset: 0x157C8C1 VA: 0x157C7C0
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x157DBB0 Offset: 0x157DCB1 VA: 0x157DBB0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x157F2E0 Offset: 0x157F3E1 VA: 0x157F2E0 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x157F590 Offset: 0x157F691 VA: 0x157F590 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x157F5A0 Offset: 0x157F6A1 VA: 0x157F5A0 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x157F5B0 Offset: 0x157F6B1 VA: 0x157F5B0
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x157F5C0 Offset: 0x157F6C1 VA: 0x157F5C0
	public static TaskFactory get_Factory() { }

	// RVA: 0x157F630 Offset: 0x157F731 VA: 0x157F630
	public static Task get_CompletedTask() { }

	// RVA: 0x157F390 Offset: 0x157F491 VA: 0x157F390
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x157EA30 Offset: 0x157EB31 VA: 0x157EA30
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x157F730 Offset: 0x157F831 VA: 0x157F730
	internal bool get_IsChildReplica() { }

	// RVA: 0x157F7B0 Offset: 0x157F8B1 VA: 0x157F7B0
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x157EE40 Offset: 0x157EF41 VA: 0x157EE40
	public bool get_IsFaulted() { }

	// RVA: 0x157F850 Offset: 0x157F951 VA: 0x157F850
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x157ADD0 Offset: 0x157AED1 VA: 0x157ADD0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x157F960 Offset: 0x157FA61 VA: 0x157F960
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x157FA70 Offset: 0x157FB71 VA: 0x157FA70 Slot: 10
	public void Dispose() { }

	// RVA: 0x157FAF0 Offset: 0x157FBF1 VA: 0x157FAF0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x157CAC0 Offset: 0x157CBC1 VA: 0x157CAC0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x157FCC0 Offset: 0x157FDC1 VA: 0x157FCC0
	internal void AddException(object exceptionObject) { }

	// RVA: 0x1580170 Offset: 0x1580271 VA: 0x1580170
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x157EE70 Offset: 0x157EF71 VA: 0x157EE70
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580790 Offset: 0x1580891 VA: 0x1580790
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x1580980 Offset: 0x1580A81 VA: 0x1580980
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x15809E0 Offset: 0x1580AE1 VA: 0x15809E0
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580A60 Offset: 0x1580B61 VA: 0x1580A60
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x1580BF0 Offset: 0x1580CF1 VA: 0x1580BF0
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x1580C20 Offset: 0x1580D21 VA: 0x1580C20
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x157FEA0 Offset: 0x157FFA1 VA: 0x157FEA0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x1580C50 Offset: 0x1580D51 VA: 0x1580C50
	internal void FinishStageTwo() { }

	// RVA: 0x1581230 Offset: 0x1581331 VA: 0x1581230
	internal void FinishStageThree() { }

	// RVA: 0x15812F0 Offset: 0x15813F1 VA: 0x15812F0
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x1580EA0 Offset: 0x1580FA1 VA: 0x1580EA0
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x157FCD0 Offset: 0x157FDD1 VA: 0x157FCD0
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x1581B60 Offset: 0x1581C61 VA: 0x1581B60
	private void Execute() { }

	// RVA: 0x1582020 Offset: 0x1582121 VA: 0x1582020 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x1582030 Offset: 0x1582131 VA: 0x1582030 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x15820F0 Offset: 0x15821F1 VA: 0x15820F0 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x1582100 Offset: 0x1582201 VA: 0x1582100 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x1582110 Offset: 0x1582211 VA: 0x1582110 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x1582120 Offset: 0x1582221 VA: 0x1582120 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x1581D80 Offset: 0x1581E81 VA: 0x1581D80
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x1582140 Offset: 0x1582241 VA: 0x1582140 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1582340 Offset: 0x1582441 VA: 0x1582340 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1582150 Offset: 0x1582251 VA: 0x1582150
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x1582400 Offset: 0x1582501 VA: 0x1582400
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x1582800 Offset: 0x1582901 VA: 0x1582800
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x1582880 Offset: 0x1582981 VA: 0x1582880 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x1582930 Offset: 0x1582A31 VA: 0x1582930
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x1581EE0 Offset: 0x1581FE1 VA: 0x1581EE0
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x1582990 Offset: 0x1582A91 VA: 0x1582990
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x15829C0 Offset: 0x1582AC1 VA: 0x15829C0
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x1582A00 Offset: 0x1582B01 VA: 0x1582A00
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x1582DD0 Offset: 0x1582ED1 VA: 0x1582DD0
	public void Wait() { }

	// RVA: 0x1582DE0 Offset: 0x1582EE1 VA: 0x1582DE0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583220 Offset: 0x1583321 VA: 0x1583220
	private bool WrappedTryRunInline() { }

	// RVA: 0x1582F80 Offset: 0x1583081 VA: 0x1582F80
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x15835A0 Offset: 0x15836A1 VA: 0x15835A0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583820 Offset: 0x1583921 VA: 0x1583820
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x157CE50 Offset: 0x157CF51 VA: 0x157CE50
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x1583B10 Offset: 0x1583C11 VA: 0x1583B10
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x1583BC0 Offset: 0x1583CC1 VA: 0x1583BC0
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x1583C80 Offset: 0x1583D81 VA: 0x1583C80
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x1582700 Offset: 0x1582801 VA: 0x1582700
	internal void CancellationCleanupLogic() { }

	// RVA: 0x1582960 Offset: 0x1582A61 VA: 0x1582960
	private void SetCancellationAcknowledged() { }

	// RVA: 0x1581480 Offset: 0x1581581 VA: 0x1581480
	internal void FinishContinuations() { }

	// RVA: 0x1583D00 Offset: 0x1583E01 VA: 0x1583D00
	private void LogFinishCompletionNotification() { }

	// RVA: 0x1583D10 Offset: 0x1583E11 VA: 0x1583D10
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x1583EB0 Offset: 0x1583FB1 VA: 0x1583EB0
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584350 Offset: 0x1584451 VA: 0x1584350
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1584390 Offset: 0x1584491 VA: 0x1584390
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584010 Offset: 0x1584111 VA: 0x1584010
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x1584150 Offset: 0x1584251 VA: 0x1584150
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x1584500 Offset: 0x1584601 VA: 0x1584500
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x1583A20 Offset: 0x1583B21 VA: 0x1583A20
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x1584510 Offset: 0x1584611 VA: 0x1584510
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x1582CE0 Offset: 0x1582DE1 VA: 0x1582CE0
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x157E420 Offset: 0x157E521 VA: 0x157E420
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC600 Offset: 0x21CC701 VA: 0x21CC600
	|-Task.FromResult<bool>
	|
	|-RVA: 0x21CC670 Offset: 0x21CC771 VA: 0x21CC670
	|-Task.FromResult<int>
	|
	|-RVA: 0x21CC6E0 Offset: 0x21CC7E1 VA: 0x21CC6E0
	|-Task.FromResult<long>
	|
	|-RVA: 0x21CC750 Offset: 0x21CC851 VA: 0x21CC750
	|-Task.FromResult<object>
	|
	|-RVA: 0x21CC7C0 Offset: 0x21CC8C1 VA: 0x21CC7C0
	|-Task.FromResult<SceneInstance>
	*/

	// RVA: 0x1584880 Offset: 0x1584981 VA: 0x1584880
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC330 Offset: 0x21CC431 VA: 0x21CC330
	|-Task.FromException<int>
	|
	|-RVA: 0x21CC420 Offset: 0x21CC521 VA: 0x21CC420
	|-Task.FromException<object>
	|
	|-RVA: 0x21CC510 Offset: 0x21CC611 VA: 0x21CC510
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0xB9130 Offset: 0xB9231 VA: 0xB9130
	// RVA: 0x15848F0 Offset: 0x15849F1 VA: 0x15848F0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9140 Offset: 0xB9241 VA: 0xB9140
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBD90 Offset: 0x21CBE91 VA: 0x21CBD90
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x21CBF70 Offset: 0x21CC071 VA: 0x21CBF70
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC150 Offset: 0x21CC251 VA: 0x21CC150
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBE80 Offset: 0x21CBF81 VA: 0x21CBE80
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC060 Offset: 0x21CC161 VA: 0x21CC060
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x21CC240 Offset: 0x21CC341 VA: 0x21CC240
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x15849B0 Offset: 0x1584AB1 VA: 0x15849B0
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC830 Offset: 0x21CC931 VA: 0x21CC830
	|-Task.Run<int>
	|
	|-RVA: 0x21CC9B0 Offset: 0x21CCAB1 VA: 0x21CC9B0
	|-Task.Run<object>
	*/

	// RVA: 0x1584AE0 Offset: 0x1584BE1 VA: 0x1584AE0
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x1578910 Offset: 0x1578A11 VA: 0x1578910
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x1578C40 Offset: 0x1578D41 VA: 0x1578C40
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x1585030 Offset: 0x1585131 VA: 0x1585030
	private static void .cctor() { }
}

[DebuggerDisplayAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
[DebuggerTypeProxyAttribute] // RVA: 0xAF730 Offset: 0xAF831 VA: 0xAF730
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 849
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0xB54E0 Offset: 0xB55E1 VA: 0xB54E0
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB54F0 Offset: 0xB55F1 VA: 0xB54F0
	private static StackGuard t_stackGuard; // 0x80000008
	internal static int s_taskIdCounter; // 0x0
	private static readonly TaskFactory s_factory; // 0x8
	private int m_taskId; // 0x10
	internal object m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x10
	[FriendAccessAllowedAttribute] // RVA: 0xB5500 Offset: 0xB5601 VA: 0xB5500
	internal static bool s_asyncDebuggingEnabled; // 0x18
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x20
	private static readonly object s_activeTasksLock; // 0x28
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x30
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x38
	private static Task s_completedTask; // 0x40
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x48
	private static ContextCallback s_ecCallback; // 0x50
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	internal bool IsRanToCompletion { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool IsSelfReplicatingRoot { get; }
	internal bool IsChildReplica { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }
	internal virtual object SavedStateForNextReplica { get; }
	internal virtual object SavedStateFromPreviousReplica { set; }
	internal virtual Task HandedOverChildReplica { get; set; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0xB9110 Offset: 0xB9211 VA: 0xB9110
	// RVA: 0x157C4C0 Offset: 0x157C5C1 VA: 0x157C4C0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9120 Offset: 0xB9221 VA: 0xB9120
	// RVA: 0x157D720 Offset: 0x157D821 VA: 0x157D720
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x157D850 Offset: 0x157D951 VA: 0x157D850
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x157D970 Offset: 0x157DA71 VA: 0x157D970
	internal void .ctor() { }

	// RVA: 0x157ACC0 Offset: 0x157ADC1 VA: 0x157ACC0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157D9B0 Offset: 0x157DAB1 VA: 0x157D9B0
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x157DD90 Offset: 0x157DE91 VA: 0x157DD90
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x157E350 Offset: 0x157E451 VA: 0x157E350
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x157C050 Offset: 0x157C151 VA: 0x157C050
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x157E220 Offset: 0x157E321 VA: 0x157E220
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x157E6A0 Offset: 0x157E7A1 VA: 0x157E6A0
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x157E6B0 Offset: 0x157E7B1 VA: 0x157E6B0
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x157E740 Offset: 0x157E841 VA: 0x157E740
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x157E7E0 Offset: 0x157E8E1 VA: 0x157E7E0
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x157C1F0 Offset: 0x157C2F1 VA: 0x157C1F0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x157E910 Offset: 0x157EA11 VA: 0x157E910
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x157E950 Offset: 0x157EA51 VA: 0x157E950 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E8B0 Offset: 0x157E9B1 VA: 0x157E8B0
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x157E8E0 Offset: 0x157E9E1 VA: 0x157E8E0
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x157E980 Offset: 0x157EA81 VA: 0x157E980
	internal bool MarkStarted() { }

	// RVA: 0x157EA20 Offset: 0x157EB21 VA: 0x157EA20
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x157DC30 Offset: 0x157DD31 VA: 0x157DC30
	internal void AddNewChild() { }

	// RVA: 0x157E2A0 Offset: 0x157E3A1 VA: 0x157E2A0
	internal void DisregardChild() { }

	// RVA: 0x157EAB0 Offset: 0x157EBB1 VA: 0x157EAB0
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x157EC20 Offset: 0x157ED21 VA: 0x157EC20
	internal static int NewId() { }

	// RVA: 0x157C3C0 Offset: 0x157C4C1 VA: 0x157C3C0
	public int get_Id() { }

	// RVA: 0x157ECB0 Offset: 0x157EDB1 VA: 0x157ECB0
	internal static Task get_InternalCurrent() { }

	// RVA: 0x157BF70 Offset: 0x157C071 VA: 0x157BF70
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x157ED20 Offset: 0x157EE21 VA: 0x157ED20
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x157EE00 Offset: 0x157EF01 VA: 0x157EE00
	public AggregateException get_Exception() { }

	// RVA: 0x157EFF0 Offset: 0x157F0F1 VA: 0x157EFF0
	public TaskStatus get_Status() { }

	// RVA: 0x157C800 Offset: 0x157C901 VA: 0x157C800
	public bool get_IsCanceled() { }

	// RVA: 0x157F090 Offset: 0x157F191 VA: 0x157F090
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x157E1D0 Offset: 0x157E2D1 VA: 0x157E1D0
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x157F0F0 Offset: 0x157F1F1 VA: 0x157F0F0
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x157F1E0 Offset: 0x157F2E1 VA: 0x157F1E0
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x157F220 Offset: 0x157F321 VA: 0x157F220
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x157F250 Offset: 0x157F351 VA: 0x157F250 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x157F2D0 Offset: 0x157F3D1 VA: 0x157F2D0
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x157C7C0 Offset: 0x157C8C1 VA: 0x157C7C0
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x157DBB0 Offset: 0x157DCB1 VA: 0x157DBB0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x157F2E0 Offset: 0x157F3E1 VA: 0x157F2E0 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x157F590 Offset: 0x157F691 VA: 0x157F590 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x157F5A0 Offset: 0x157F6A1 VA: 0x157F5A0 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x157F5B0 Offset: 0x157F6B1 VA: 0x157F5B0
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x157F5C0 Offset: 0x157F6C1 VA: 0x157F5C0
	public static TaskFactory get_Factory() { }

	// RVA: 0x157F630 Offset: 0x157F731 VA: 0x157F630
	public static Task get_CompletedTask() { }

	// RVA: 0x157F390 Offset: 0x157F491 VA: 0x157F390
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x157EA30 Offset: 0x157EB31 VA: 0x157EA30
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x157F730 Offset: 0x157F831 VA: 0x157F730
	internal bool get_IsChildReplica() { }

	// RVA: 0x157F7B0 Offset: 0x157F8B1 VA: 0x157F7B0
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x157EE40 Offset: 0x157EF41 VA: 0x157EE40
	public bool get_IsFaulted() { }

	// RVA: 0x157F850 Offset: 0x157F951 VA: 0x157F850
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x157ADD0 Offset: 0x157AED1 VA: 0x157ADD0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x157F960 Offset: 0x157FA61 VA: 0x157F960
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x157FA70 Offset: 0x157FB71 VA: 0x157FA70 Slot: 10
	public void Dispose() { }

	// RVA: 0x157FAF0 Offset: 0x157FBF1 VA: 0x157FAF0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x157CAC0 Offset: 0x157CBC1 VA: 0x157CAC0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x157FCC0 Offset: 0x157FDC1 VA: 0x157FCC0
	internal void AddException(object exceptionObject) { }

	// RVA: 0x1580170 Offset: 0x1580271 VA: 0x1580170
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x157EE70 Offset: 0x157EF71 VA: 0x157EE70
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580790 Offset: 0x1580891 VA: 0x1580790
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x1580980 Offset: 0x1580A81 VA: 0x1580980
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x15809E0 Offset: 0x1580AE1 VA: 0x15809E0
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1580A60 Offset: 0x1580B61 VA: 0x1580A60
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x1580BF0 Offset: 0x1580CF1 VA: 0x1580BF0
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x1580C20 Offset: 0x1580D21 VA: 0x1580C20
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x157FEA0 Offset: 0x157FFA1 VA: 0x157FEA0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x1580C50 Offset: 0x1580D51 VA: 0x1580C50
	internal void FinishStageTwo() { }

	// RVA: 0x1581230 Offset: 0x1581331 VA: 0x1581230
	internal void FinishStageThree() { }

	// RVA: 0x15812F0 Offset: 0x15813F1 VA: 0x15812F0
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x1580EA0 Offset: 0x1580FA1 VA: 0x1580EA0
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x157FCD0 Offset: 0x157FDD1 VA: 0x157FCD0
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x1581B60 Offset: 0x1581C61 VA: 0x1581B60
	private void Execute() { }

	// RVA: 0x1582020 Offset: 0x1582121 VA: 0x1582020 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x1582030 Offset: 0x1582131 VA: 0x1582030 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x15820F0 Offset: 0x15821F1 VA: 0x15820F0 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x1582100 Offset: 0x1582201 VA: 0x1582100 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x1582110 Offset: 0x1582211 VA: 0x1582110 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x1582120 Offset: 0x1582221 VA: 0x1582120 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x1581D80 Offset: 0x1581E81 VA: 0x1581D80
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x1582140 Offset: 0x1582241 VA: 0x1582140 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1582340 Offset: 0x1582441 VA: 0x1582340 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1582150 Offset: 0x1582251 VA: 0x1582150
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x1582400 Offset: 0x1582501 VA: 0x1582400
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x1582800 Offset: 0x1582901 VA: 0x1582800
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x1582880 Offset: 0x1582981 VA: 0x1582880 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x1582930 Offset: 0x1582A31 VA: 0x1582930
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x1581EE0 Offset: 0x1581FE1 VA: 0x1581EE0
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x1582990 Offset: 0x1582A91 VA: 0x1582990
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x15829C0 Offset: 0x1582AC1 VA: 0x15829C0
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x1582A00 Offset: 0x1582B01 VA: 0x1582A00
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x1582DD0 Offset: 0x1582ED1 VA: 0x1582DD0
	public void Wait() { }

	// RVA: 0x1582DE0 Offset: 0x1582EE1 VA: 0x1582DE0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583220 Offset: 0x1583321 VA: 0x1583220
	private bool WrappedTryRunInline() { }

	// RVA: 0x1582F80 Offset: 0x1583081 VA: 0x1582F80
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x15835A0 Offset: 0x15836A1 VA: 0x15835A0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1583820 Offset: 0x1583921 VA: 0x1583820
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x157CE50 Offset: 0x157CF51 VA: 0x157CE50
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x1583B10 Offset: 0x1583C11 VA: 0x1583B10
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x1583BC0 Offset: 0x1583CC1 VA: 0x1583BC0
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x1583C80 Offset: 0x1583D81 VA: 0x1583C80
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x1582700 Offset: 0x1582801 VA: 0x1582700
	internal void CancellationCleanupLogic() { }

	// RVA: 0x1582960 Offset: 0x1582A61 VA: 0x1582960
	private void SetCancellationAcknowledged() { }

	// RVA: 0x1581480 Offset: 0x1581581 VA: 0x1581480
	internal void FinishContinuations() { }

	// RVA: 0x1583D00 Offset: 0x1583E01 VA: 0x1583D00
	private void LogFinishCompletionNotification() { }

	// RVA: 0x1583D10 Offset: 0x1583E11 VA: 0x1583D10
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x1583EB0 Offset: 0x1583FB1 VA: 0x1583EB0
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584350 Offset: 0x1584451 VA: 0x1584350
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1584390 Offset: 0x1584491 VA: 0x1584390
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1584010 Offset: 0x1584111 VA: 0x1584010
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x1584150 Offset: 0x1584251 VA: 0x1584150
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x1584500 Offset: 0x1584601 VA: 0x1584500
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x1583A20 Offset: 0x1583B21 VA: 0x1583A20
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x1584510 Offset: 0x1584611 VA: 0x1584510
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x1582CE0 Offset: 0x1582DE1 VA: 0x1582CE0
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x157E420 Offset: 0x157E521 VA: 0x157E420
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC600 Offset: 0x21CC701 VA: 0x21CC600
	|-Task.FromResult<bool>
	|
	|-RVA: 0x21CC670 Offset: 0x21CC771 VA: 0x21CC670
	|-Task.FromResult<int>
	|
	|-RVA: 0x21CC6E0 Offset: 0x21CC7E1 VA: 0x21CC6E0
	|-Task.FromResult<long>
	|
	|-RVA: 0x21CC750 Offset: 0x21CC851 VA: 0x21CC750
	|-Task.FromResult<object>
	|
	|-RVA: 0x21CC7C0 Offset: 0x21CC8C1 VA: 0x21CC7C0
	|-Task.FromResult<SceneInstance>
	*/

	// RVA: 0x1584880 Offset: 0x1584981 VA: 0x1584880
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC330 Offset: 0x21CC431 VA: 0x21CC330
	|-Task.FromException<int>
	|
	|-RVA: 0x21CC420 Offset: 0x21CC521 VA: 0x21CC420
	|-Task.FromException<object>
	|
	|-RVA: 0x21CC510 Offset: 0x21CC611 VA: 0x21CC510
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0xB9130 Offset: 0xB9231 VA: 0xB9130
	// RVA: 0x15848F0 Offset: 0x15849F1 VA: 0x15848F0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB9140 Offset: 0xB9241 VA: 0xB9140
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBD90 Offset: 0x21CBE91 VA: 0x21CBD90
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x21CBF70 Offset: 0x21CC071 VA: 0x21CBF70
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC150 Offset: 0x21CC251 VA: 0x21CC150
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CBE80 Offset: 0x21CBF81 VA: 0x21CBE80
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x21CC060 Offset: 0x21CC161 VA: 0x21CC060
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x21CC240 Offset: 0x21CC341 VA: 0x21CC240
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x15849B0 Offset: 0x1584AB1 VA: 0x15849B0
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CC830 Offset: 0x21CC931 VA: 0x21CC830
	|-Task.Run<int>
	|
	|-RVA: 0x21CC9B0 Offset: 0x21CCAB1 VA: 0x21CC9B0
	|-Task.Run<object>
	*/

	// RVA: 0x1584AE0 Offset: 0x1584BE1 VA: 0x1584AE0
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x1578910 Offset: 0x1578A11 VA: 0x1578910
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x1578C40 Offset: 0x1578D41 VA: 0x1578C40
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x1585030 Offset: 0x1585131 VA: 0x1585030
	private static void .cctor() { }
}


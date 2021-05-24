public class TaskFactory // TypeDefIndex: 874
{
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x10
	private TaskScheduler m_defaultScheduler; // 0x18
	private TaskCreationOptions m_defaultCreationOptions; // 0x20
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x24

	// Methods

	// RVA: 0x1587080 Offset: 0x1587181 VA: 0x1587080
	private TaskScheduler GetDefaultScheduler(Task currTask) { }

	// RVA: 0x1585310 Offset: 0x1585411 VA: 0x1585310
	public void .ctor() { }

	// RVA: 0x15871C0 Offset: 0x15872C1 VA: 0x15871C0
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x15873B0 Offset: 0x15874B1 VA: 0x15873B0
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CCB30 Offset: 0x21CCC31 VA: 0x21CCB30
	|-TaskFactory.StartNew<bool>
	|
	|-RVA: 0x21CCCF0 Offset: 0x21CCDF1 VA: 0x21CCCF0
	|-TaskFactory.StartNew<long>
	|
	|-RVA: 0x21CCEB0 Offset: 0x21CCFB1 VA: 0x21CCEB0
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0x21CD1B0 Offset: 0x21CD2B1 VA: 0x21CD1B0
	|-TaskFactory.StartNew<SceneInstance>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CD070 Offset: 0x21CD171 VA: 0x21CD070
	|-TaskFactory.StartNew<object>
	*/

	// RVA: 0x1584CE0 Offset: 0x1584DE1 VA: 0x1584CE0
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	// RVA: 0x15872A0 Offset: 0x15873A1 VA: 0x15872A0
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }
}


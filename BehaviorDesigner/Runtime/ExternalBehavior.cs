[Serializable]
public abstract class ExternalBehavior : ScriptableObject, IBehavior // TypeDefIndex: 4670
{
	// Fields
	[SerializeField] // RVA: 0x12D540 Offset: 0x12D641 VA: 0x12D540
	private BehaviorSource mBehaviorSource; // 0x18
	private bool mInitialized; // 0x20

	// Properties
	public BehaviorSource BehaviorSource { get; set; }
	public bool Initialized { get; }

	// Methods

	// RVA: 0x17719F0 Offset: 0x1771AF1 VA: 0x17719F0
	protected void .ctor() { }

	// RVA: 0x1771A00 Offset: 0x1771B01 VA: 0x1771A00
	public BehaviorSource get_BehaviorSource() { }

	// RVA: 0x1771A10 Offset: 0x1771B11 VA: 0x1771A10
	public void set_BehaviorSource(BehaviorSource value) { }

	// RVA: 0x1771A20 Offset: 0x1771B21 VA: 0x1771A20 Slot: 7
	public BehaviorSource GetBehaviorSource() { }

	// RVA: 0x1771A30 Offset: 0x1771B31 VA: 0x1771A30 Slot: 8
	public void SetBehaviorSource(BehaviorSource behaviorSource) { }

	// RVA: 0x1771A40 Offset: 0x1771B41 VA: 0x1771A40 Slot: 6
	public Object GetObject() { }

	// RVA: 0x1771A50 Offset: 0x1771B51 VA: 0x1771A50 Slot: 4
	public string GetOwnerName() { }

	// RVA: 0x1771A60 Offset: 0x1771B61 VA: 0x1771A60
	public bool get_Initialized() { }

	// RVA: 0x1771A70 Offset: 0x1771B71 VA: 0x1771A70
	public void Init() { }

	// RVA: 0x1771B10 Offset: 0x1771C11 VA: 0x1771B10 Slot: 9
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x1771B70 Offset: 0x1771C71 VA: 0x1771B70 Slot: 10
	public void SetVariable(string name, SharedVariable item) { }

	// RVA: 0x1771BE0 Offset: 0x1771CE1 VA: 0x1771BE0 Slot: 11
	public void SetVariableValue(string name, object value) { }

	// RVA: -1 Offset: -1
	public T FindTask<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BE0C0 Offset: 0x23BE1C1 VA: 0x23BE0C0
	|-ExternalBehavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	private T FindTask<T>(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BE110 Offset: 0x23BE211 VA: 0x23BE110
	|-ExternalBehavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	public List<T> FindTasks<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AA660 Offset: 0x21AA761 VA: 0x21AA660
	|-ExternalBehavior.FindTasks<object>
	*/

	// RVA: -1 Offset: -1
	private void FindTasks<T>(Task task, ref List<T> taskList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE410 Offset: 0x21CE511 VA: 0x21CE410
	|-ExternalBehavior.FindTasks<object>
	*/

	// RVA: 0x1771C80 Offset: 0x1771D81 VA: 0x1771C80
	public Task FindTaskWithName(string taskName) { }

	// RVA: 0x1771AC0 Offset: 0x1771BC1 VA: 0x1771AC0
	private void CheckForSerialization() { }

	// RVA: 0x1771CE0 Offset: 0x1771DE1 VA: 0x1771CE0
	private Task FindTaskWithName(string taskName, Task task) { }

	// RVA: 0x1771E10 Offset: 0x1771F11 VA: 0x1771E10
	public List<Task> FindTasksWithName(string taskName) { }

	// RVA: 0x1771EE0 Offset: 0x1771FE1 VA: 0x1771EE0
	private void FindTasksWithName(string taskName, Task task, ref List<Task> taskList) { }

	// RVA: 0x1772020 Offset: 0x1772121 VA: 0x1772020 Slot: 12
	virtual int BehaviorDesigner.Runtime.IBehavior.GetInstanceID() { }
}


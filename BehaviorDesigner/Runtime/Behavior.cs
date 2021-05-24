[Serializable]
public abstract class Behavior : MonoBehaviour, IBehavior // TypeDefIndex: 4646
{
	// Fields
	[TooltipAttribute] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	[SerializeField] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	private bool startWhenEnabled; // 0x18
	[TooltipAttribute] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	[SerializeField] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	private bool asynchronousLoad; // 0x19
	[SerializeField] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	[TooltipAttribute] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	private bool pauseWhenDisabled; // 0x1A
	[SerializeField] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	[TooltipAttribute] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	private bool restartWhenComplete; // 0x1B
	[SerializeField] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	[TooltipAttribute] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	private bool logTaskChanges; // 0x1C
	[SerializeField] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	[TooltipAttribute] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	private int group; // 0x20
	[TooltipAttribute] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	[SerializeField] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	private bool resetValuesOnRestart; // 0x24
	[TooltipAttribute] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	[SerializeField] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	private ExternalBehavior externalBehavior; // 0x28
	private bool hasInheritedVariables; // 0x30
	[SerializeField] // RVA: 0x12D4D0 Offset: 0x12D5D1 VA: 0x12D4D0
	private BehaviorSource mBehaviorSource; // 0x38
	private bool isPaused; // 0x40
	private TaskStatus executionStatus; // 0x44
	private bool initialized; // 0x48
	private Dictionary<Task, Dictionary<string, object>> defaultValues; // 0x50
	private Dictionary<SharedVariable, object> defaultVariableValues; // 0x58
	private bool[] hasEvent; // 0x60
	private Dictionary<string, List<TaskCoroutine>> activeTaskCoroutines; // 0x68
	private Dictionary<Type, Dictionary<string, Delegate>> eventTable; // 0x70
	public Behavior.GizmoViewMode gizmoViewMode; // 0x78
	public bool showBehaviorDesignerGizmo; // 0x7C
	private Behavior.BehaviorHandler OnBehaviorStart; // 0x80
	private Behavior.BehaviorHandler OnBehaviorRestart; // 0x88
	private Behavior.BehaviorHandler OnBehaviorEnd; // 0x90

	// Properties
	public bool StartWhenEnabled { get; set; }
	public bool AsynchronousLoad { get; set; }
	public bool PauseWhenDisabled { get; set; }
	public bool RestartWhenComplete { get; set; }
	public bool LogTaskChanges { get; set; }
	public int Group { get; set; }
	public bool ResetValuesOnRestart { get; set; }
	public ExternalBehavior ExternalBehavior { get; set; }
	public bool HasInheritedVariables { get; set; }
	public string BehaviorName { get; set; }
	public string BehaviorDescription { get; set; }
	public TaskStatus ExecutionStatus { get; set; }
	public bool[] HasEvent { get; }

	// Methods

	// RVA: 0x175E000 Offset: 0x175E101 VA: 0x175E000
	public void .ctor() { }

	// RVA: 0x175E1D0 Offset: 0x175E2D1 VA: 0x175E1D0
	public void add_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E260 Offset: 0x175E361 VA: 0x175E260
	public void remove_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E2F0 Offset: 0x175E3F1 VA: 0x175E2F0
	public void add_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E380 Offset: 0x175E481 VA: 0x175E380
	public void remove_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E410 Offset: 0x175E511 VA: 0x175E410
	public void add_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E4A0 Offset: 0x175E5A1 VA: 0x175E4A0
	public void remove_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E530 Offset: 0x175E631 VA: 0x175E530
	public bool get_StartWhenEnabled() { }

	// RVA: 0x175E540 Offset: 0x175E641 VA: 0x175E540
	public void set_StartWhenEnabled(bool value) { }

	// RVA: 0x175E550 Offset: 0x175E651 VA: 0x175E550
	public bool get_AsynchronousLoad() { }

	// RVA: 0x175E560 Offset: 0x175E661 VA: 0x175E560
	public void set_AsynchronousLoad(bool value) { }

	// RVA: 0x175E570 Offset: 0x175E671 VA: 0x175E570
	public bool get_PauseWhenDisabled() { }

	// RVA: 0x175E580 Offset: 0x175E681 VA: 0x175E580
	public void set_PauseWhenDisabled(bool value) { }

	// RVA: 0x175E590 Offset: 0x175E691 VA: 0x175E590
	public bool get_RestartWhenComplete() { }

	// RVA: 0x175E5A0 Offset: 0x175E6A1 VA: 0x175E5A0
	public void set_RestartWhenComplete(bool value) { }

	// RVA: 0x175E5B0 Offset: 0x175E6B1 VA: 0x175E5B0
	public bool get_LogTaskChanges() { }

	// RVA: 0x175E5C0 Offset: 0x175E6C1 VA: 0x175E5C0
	public void set_LogTaskChanges(bool value) { }

	// RVA: 0x175E5D0 Offset: 0x175E6D1 VA: 0x175E5D0
	public int get_Group() { }

	// RVA: 0x175E5E0 Offset: 0x175E6E1 VA: 0x175E5E0
	public void set_Group(int value) { }

	// RVA: 0x175E5F0 Offset: 0x175E6F1 VA: 0x175E5F0
	public bool get_ResetValuesOnRestart() { }

	// RVA: 0x175E600 Offset: 0x175E701 VA: 0x175E600
	public void set_ResetValuesOnRestart(bool value) { }

	// RVA: 0x175E610 Offset: 0x175E711 VA: 0x175E610
	public ExternalBehavior get_ExternalBehavior() { }

	// RVA: 0x175E620 Offset: 0x175E721 VA: 0x175E620
	public void set_ExternalBehavior(ExternalBehavior value) { }

	// RVA: 0x175ECC0 Offset: 0x175EDC1 VA: 0x175ECC0
	public bool get_HasInheritedVariables() { }

	// RVA: 0x175ECD0 Offset: 0x175EDD1 VA: 0x175ECD0
	public void set_HasInheritedVariables(bool value) { }

	// RVA: 0x175ECE0 Offset: 0x175EDE1 VA: 0x175ECE0
	public string get_BehaviorName() { }

	// RVA: 0x175ED00 Offset: 0x175EE01 VA: 0x175ED00
	public void set_BehaviorName(string value) { }

	// RVA: 0x175ED20 Offset: 0x175EE21 VA: 0x175ED20
	public string get_BehaviorDescription() { }

	// RVA: 0x175ED40 Offset: 0x175EE41 VA: 0x175ED40
	public void set_BehaviorDescription(string value) { }

	// RVA: 0x175ED60 Offset: 0x175EE61 VA: 0x175ED60 Slot: 7
	public BehaviorSource GetBehaviorSource() { }

	// RVA: 0x175ED70 Offset: 0x175EE71 VA: 0x175ED70 Slot: 8
	public void SetBehaviorSource(BehaviorSource behaviorSource) { }

	// RVA: 0x175ED80 Offset: 0x175EE81 VA: 0x175ED80 Slot: 6
	public Object GetObject() { }

	// RVA: 0x175ED90 Offset: 0x175EE91 VA: 0x175ED90 Slot: 4
	public string GetOwnerName() { }

	// RVA: 0x175EDC0 Offset: 0x175EEC1 VA: 0x175EDC0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x175EDD0 Offset: 0x175EED1 VA: 0x175EDD0
	public void set_ExecutionStatus(TaskStatus value) { }

	// RVA: 0x175EDE0 Offset: 0x175EEE1 VA: 0x175EDE0
	public bool[] get_HasEvent() { }

	// RVA: 0x175EDF0 Offset: 0x175EEF1 VA: 0x175EDF0
	public void Start() { }

	// RVA: 0x175EE00 Offset: 0x175EF01 VA: 0x175EE00
	private bool TaskContainsMethod(string methodName, Task task) { }

	// RVA: 0x175EBD0 Offset: 0x175ECD1 VA: 0x175EBD0
	public void EnableBehavior() { }

	// RVA: 0x175F3C0 Offset: 0x175F4C1 VA: 0x175F3C0
	public void DisableBehavior() { }

	// RVA: 0x175F4C0 Offset: 0x175F5C1 VA: 0x175F4C0
	public void DisableBehavior(bool pause) { }

	// RVA: 0x175F5B0 Offset: 0x175F6B1 VA: 0x175F5B0
	public void OnEnable() { }

	// RVA: 0x175F6C0 Offset: 0x175F7C1 VA: 0x175F6C0
	public void OnDisable() { }

	// RVA: 0x175F6D0 Offset: 0x175F7D1 VA: 0x175F6D0
	public void OnDestroy() { }

	// RVA: 0x175F7D0 Offset: 0x175F8D1 VA: 0x175F7D0 Slot: 9
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175F950 Offset: 0x175FA51 VA: 0x175F950 Slot: 10
	public void SetVariable(string name, SharedVariable item) { }

	// RVA: 0x175F9A0 Offset: 0x175FAA1 VA: 0x175F9A0 Slot: 11
	public void SetVariableValue(string name, object value) { }

	// RVA: 0x175FCD0 Offset: 0x175FDD1 VA: 0x175FCD0
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175F810 Offset: 0x175F911 VA: 0x175F810
	public void CheckForSerialization() { }

	// RVA: 0x175FD20 Offset: 0x175FE21 VA: 0x175FD20
	public void CheckForSerialization(bool forceSerialization) { }

	// RVA: 0x1760060 Offset: 0x1760161 VA: 0x1760060
	public void OnCollisionEnter(Collision collision) { }

	// RVA: 0x1760450 Offset: 0x1760551 VA: 0x1760450
	public void OnCollisionExit(Collision collision) { }

	// RVA: 0x1760840 Offset: 0x1760941 VA: 0x1760840
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x1760C30 Offset: 0x1760D31 VA: 0x1760C30
	public void OnTriggerExit(Collider other) { }

	// RVA: 0x1761020 Offset: 0x1761121 VA: 0x1761020
	public void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x1761410 Offset: 0x1761511 VA: 0x1761410
	public void OnCollisionExit2D(Collision2D collision) { }

	// RVA: 0x1761800 Offset: 0x1761901 VA: 0x1761800
	public void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1761BF0 Offset: 0x1761CF1 VA: 0x1761BF0
	public void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x1761FE0 Offset: 0x17620E1 VA: 0x1761FE0
	public void OnControllerColliderHit(ControllerColliderHit hit) { }

	// RVA: 0x17623D0 Offset: 0x17624D1 VA: 0x17623D0
	public void OnAnimatorIK() { }

	// RVA: 0x17627A0 Offset: 0x17628A1 VA: 0x17627A0
	public void OnDrawGizmos() { }

	// RVA: 0x17628C0 Offset: 0x17629C1 VA: 0x17628C0
	public void OnDrawGizmosSelected() { }

	// RVA: 0x17627B0 Offset: 0x17628B1 VA: 0x17627B0
	private void DrawTaskGizmos(bool selected) { }

	// RVA: 0x1762940 Offset: 0x1762A41 VA: 0x1762940
	private void DrawTaskGizmos(Task task) { }

	// RVA: -1 Offset: -1
	public T FindTask<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDE80 Offset: 0x23BDF81 VA: 0x23BDE80
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	private T FindTask<T>(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDED0 Offset: 0x23BDFD1 VA: 0x23BDED0
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	public List<T> FindTasks<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AA5C0 Offset: 0x21AA6C1 VA: 0x21AA5C0
	|-Behavior.FindTasks<object>
	*/

	// RVA: -1 Offset: -1
	private void FindTasks<T>(Task task, ref List<T> taskList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CDE70 Offset: 0x21CDF71 VA: 0x21CDE70
	|-Behavior.FindTasks<object>
	*/

	// RVA: 0x1762A50 Offset: 0x1762B51 VA: 0x1762A50
	public Task FindTaskWithName(string taskName) { }

	// RVA: 0x1762A90 Offset: 0x1762B91 VA: 0x1762A90
	private Task FindTaskWithName(string taskName, Task task) { }

	// RVA: 0x1762BC0 Offset: 0x1762CC1 VA: 0x1762BC0
	public List<Task> FindTasksWithName(string taskName) { }

	// RVA: 0x1762C70 Offset: 0x1762D71 VA: 0x1762C70
	private void FindTasksWithName(string taskName, Task task, ref List<Task> taskList) { }

	// RVA: 0x1762DB0 Offset: 0x1762EB1 VA: 0x1762DB0
	public List<Task> GetActiveTasks() { }

	// RVA: 0x1763100 Offset: 0x1763201 VA: 0x1763100
	public Coroutine StartTaskCoroutine(Task task, string methodName) { }

	// RVA: 0x17633A0 Offset: 0x17634A1 VA: 0x17633A0
	public Coroutine StartTaskCoroutine(Task task, string methodName, object value) { }

	// RVA: 0x1763690 Offset: 0x1763791 VA: 0x1763690
	public void StopTaskCoroutine(string methodName) { }

	// RVA: 0x1763770 Offset: 0x1763871 VA: 0x1763770
	public void StopAllTaskCoroutines() { }

	// RVA: 0x1763920 Offset: 0x1763A21 VA: 0x1763920
	public void TaskCoroutineEnded(TaskCoroutine taskCoroutine, string coroutineName) { }

	// RVA: 0x1763A30 Offset: 0x1763B31 VA: 0x1763A30
	public void OnBehaviorStarted() { }

	// RVA: 0x1763EF0 Offset: 0x1763FF1 VA: 0x1763EF0
	public void OnBehaviorRestarted() { }

	// RVA: 0x1763F10 Offset: 0x1764011 VA: 0x1763F10
	public void OnBehaviorEnded() { }

	// RVA: 0x1763F30 Offset: 0x1764031 VA: 0x1763F30
	private void RegisterEvent(string name, Delegate handler) { }

	// RVA: 0x17640F0 Offset: 0x17641F1 VA: 0x17640F0
	public void RegisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void RegisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE060 Offset: 0x21CE161 VA: 0x21CE060
	|-Behavior.RegisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE040 Offset: 0x21CE141 VA: 0x21CE040
	|-Behavior.RegisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE020 Offset: 0x21CE121 VA: 0x21CE020
	|-Behavior.RegisterEvent<object, object, object>
	*/

	// RVA: 0x1764100 Offset: 0x1764201 VA: 0x1764100
	private Delegate GetDelegate(string name, Type type) { }

	// RVA: 0x17641C0 Offset: 0x17642C1 VA: 0x17641C0
	public void SendEvent(string name) { }

	// RVA: -1 Offset: -1
	public void SendEvent<T>(string name, T arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE2B0 Offset: 0x21CE3B1 VA: 0x21CE2B0
	|-Behavior.SendEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U>(string name, T arg1, U arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE1A0 Offset: 0x21CE2A1 VA: 0x21CE1A0
	|-Behavior.SendEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U, V>(string name, T arg1, U arg2, V arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE080 Offset: 0x21CE181 VA: 0x21CE080
	|-Behavior.SendEvent<object, object, object>
	*/

	// RVA: 0x1764300 Offset: 0x1764401 VA: 0x1764300
	private void UnregisterEvent(string name, Delegate handler) { }

	// RVA: 0x17643F0 Offset: 0x17644F1 VA: 0x17643F0
	public void UnregisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3F0 Offset: 0x21CE4F1 VA: 0x21CE3F0
	|-Behavior.UnregisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3D0 Offset: 0x21CE4D1 VA: 0x21CE3D0
	|-Behavior.UnregisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3B0 Offset: 0x21CE4B1 VA: 0x21CE3B0
	|-Behavior.UnregisterEvent<object, object, object>
	*/

	// RVA: 0x1764400 Offset: 0x1764501 VA: 0x1764400
	public void SaveResetValues() { }

	// RVA: 0x17644E0 Offset: 0x17645E1 VA: 0x17644E0
	private void SaveValues() { }

	// RVA: 0x1764770 Offset: 0x1764871 VA: 0x1764770
	private void SaveValue(Task task) { }

	// RVA: 0x1764600 Offset: 0x1764701 VA: 0x1764600
	private void ResetValues() { }

	// RVA: 0x1764AD0 Offset: 0x1764BD1 VA: 0x1764AD0
	private void ResetValue(Task task) { }

	// RVA: 0x1764D30 Offset: 0x1764E31 VA: 0x1764D30 Slot: 3
	public override string ToString() { }

	// RVA: 0x175EF60 Offset: 0x175F061 VA: 0x175EF60
	public static BehaviorManager CreateBehaviorManager() { }

	// RVA: 0x1764D50 Offset: 0x1764E51 VA: 0x1764D50 Slot: 12
	virtual int BehaviorDesigner.Runtime.IBehavior.GetInstanceID() { }
}

[Serializable]
public abstract class Behavior : MonoBehaviour, IBehavior // TypeDefIndex: 4646
{
	// Fields
	[TooltipAttribute] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	[SerializeField] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	private bool startWhenEnabled; // 0x18
	[TooltipAttribute] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	[SerializeField] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	private bool asynchronousLoad; // 0x19
	[SerializeField] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	[TooltipAttribute] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	private bool pauseWhenDisabled; // 0x1A
	[SerializeField] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	[TooltipAttribute] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	private bool restartWhenComplete; // 0x1B
	[SerializeField] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	[TooltipAttribute] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	private bool logTaskChanges; // 0x1C
	[SerializeField] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	[TooltipAttribute] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	private int group; // 0x20
	[TooltipAttribute] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	[SerializeField] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	private bool resetValuesOnRestart; // 0x24
	[TooltipAttribute] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	[SerializeField] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	private ExternalBehavior externalBehavior; // 0x28
	private bool hasInheritedVariables; // 0x30
	[SerializeField] // RVA: 0x12D4D0 Offset: 0x12D5D1 VA: 0x12D4D0
	private BehaviorSource mBehaviorSource; // 0x38
	private bool isPaused; // 0x40
	private TaskStatus executionStatus; // 0x44
	private bool initialized; // 0x48
	private Dictionary<Task, Dictionary<string, object>> defaultValues; // 0x50
	private Dictionary<SharedVariable, object> defaultVariableValues; // 0x58
	private bool[] hasEvent; // 0x60
	private Dictionary<string, List<TaskCoroutine>> activeTaskCoroutines; // 0x68
	private Dictionary<Type, Dictionary<string, Delegate>> eventTable; // 0x70
	public Behavior.GizmoViewMode gizmoViewMode; // 0x78
	public bool showBehaviorDesignerGizmo; // 0x7C
	private Behavior.BehaviorHandler OnBehaviorStart; // 0x80
	private Behavior.BehaviorHandler OnBehaviorRestart; // 0x88
	private Behavior.BehaviorHandler OnBehaviorEnd; // 0x90

	// Properties
	public bool StartWhenEnabled { get; set; }
	public bool AsynchronousLoad { get; set; }
	public bool PauseWhenDisabled { get; set; }
	public bool RestartWhenComplete { get; set; }
	public bool LogTaskChanges { get; set; }
	public int Group { get; set; }
	public bool ResetValuesOnRestart { get; set; }
	public ExternalBehavior ExternalBehavior { get; set; }
	public bool HasInheritedVariables { get; set; }
	public string BehaviorName { get; set; }
	public string BehaviorDescription { get; set; }
	public TaskStatus ExecutionStatus { get; set; }
	public bool[] HasEvent { get; }

	// Methods

	// RVA: 0x175E000 Offset: 0x175E101 VA: 0x175E000
	public void .ctor() { }

	// RVA: 0x175E1D0 Offset: 0x175E2D1 VA: 0x175E1D0
	public void add_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E260 Offset: 0x175E361 VA: 0x175E260
	public void remove_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E2F0 Offset: 0x175E3F1 VA: 0x175E2F0
	public void add_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E380 Offset: 0x175E481 VA: 0x175E380
	public void remove_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E410 Offset: 0x175E511 VA: 0x175E410
	public void add_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E4A0 Offset: 0x175E5A1 VA: 0x175E4A0
	public void remove_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E530 Offset: 0x175E631 VA: 0x175E530
	public bool get_StartWhenEnabled() { }

	// RVA: 0x175E540 Offset: 0x175E641 VA: 0x175E540
	public void set_StartWhenEnabled(bool value) { }

	// RVA: 0x175E550 Offset: 0x175E651 VA: 0x175E550
	public bool get_AsynchronousLoad() { }

	// RVA: 0x175E560 Offset: 0x175E661 VA: 0x175E560
	public void set_AsynchronousLoad(bool value) { }

	// RVA: 0x175E570 Offset: 0x175E671 VA: 0x175E570
	public bool get_PauseWhenDisabled() { }

	// RVA: 0x175E580 Offset: 0x175E681 VA: 0x175E580
	public void set_PauseWhenDisabled(bool value) { }

	// RVA: 0x175E590 Offset: 0x175E691 VA: 0x175E590
	public bool get_RestartWhenComplete() { }

	// RVA: 0x175E5A0 Offset: 0x175E6A1 VA: 0x175E5A0
	public void set_RestartWhenComplete(bool value) { }

	// RVA: 0x175E5B0 Offset: 0x175E6B1 VA: 0x175E5B0
	public bool get_LogTaskChanges() { }

	// RVA: 0x175E5C0 Offset: 0x175E6C1 VA: 0x175E5C0
	public void set_LogTaskChanges(bool value) { }

	// RVA: 0x175E5D0 Offset: 0x175E6D1 VA: 0x175E5D0
	public int get_Group() { }

	// RVA: 0x175E5E0 Offset: 0x175E6E1 VA: 0x175E5E0
	public void set_Group(int value) { }

	// RVA: 0x175E5F0 Offset: 0x175E6F1 VA: 0x175E5F0
	public bool get_ResetValuesOnRestart() { }

	// RVA: 0x175E600 Offset: 0x175E701 VA: 0x175E600
	public void set_ResetValuesOnRestart(bool value) { }

	// RVA: 0x175E610 Offset: 0x175E711 VA: 0x175E610
	public ExternalBehavior get_ExternalBehavior() { }

	// RVA: 0x175E620 Offset: 0x175E721 VA: 0x175E620
	public void set_ExternalBehavior(ExternalBehavior value) { }

	// RVA: 0x175ECC0 Offset: 0x175EDC1 VA: 0x175ECC0
	public bool get_HasInheritedVariables() { }

	// RVA: 0x175ECD0 Offset: 0x175EDD1 VA: 0x175ECD0
	public void set_HasInheritedVariables(bool value) { }

	// RVA: 0x175ECE0 Offset: 0x175EDE1 VA: 0x175ECE0
	public string get_BehaviorName() { }

	// RVA: 0x175ED00 Offset: 0x175EE01 VA: 0x175ED00
	public void set_BehaviorName(string value) { }

	// RVA: 0x175ED20 Offset: 0x175EE21 VA: 0x175ED20
	public string get_BehaviorDescription() { }

	// RVA: 0x175ED40 Offset: 0x175EE41 VA: 0x175ED40
	public void set_BehaviorDescription(string value) { }

	// RVA: 0x175ED60 Offset: 0x175EE61 VA: 0x175ED60 Slot: 7
	public BehaviorSource GetBehaviorSource() { }

	// RVA: 0x175ED70 Offset: 0x175EE71 VA: 0x175ED70 Slot: 8
	public void SetBehaviorSource(BehaviorSource behaviorSource) { }

	// RVA: 0x175ED80 Offset: 0x175EE81 VA: 0x175ED80 Slot: 6
	public Object GetObject() { }

	// RVA: 0x175ED90 Offset: 0x175EE91 VA: 0x175ED90 Slot: 4
	public string GetOwnerName() { }

	// RVA: 0x175EDC0 Offset: 0x175EEC1 VA: 0x175EDC0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x175EDD0 Offset: 0x175EED1 VA: 0x175EDD0
	public void set_ExecutionStatus(TaskStatus value) { }

	// RVA: 0x175EDE0 Offset: 0x175EEE1 VA: 0x175EDE0
	public bool[] get_HasEvent() { }

	// RVA: 0x175EDF0 Offset: 0x175EEF1 VA: 0x175EDF0
	public void Start() { }

	// RVA: 0x175EE00 Offset: 0x175EF01 VA: 0x175EE00
	private bool TaskContainsMethod(string methodName, Task task) { }

	// RVA: 0x175EBD0 Offset: 0x175ECD1 VA: 0x175EBD0
	public void EnableBehavior() { }

	// RVA: 0x175F3C0 Offset: 0x175F4C1 VA: 0x175F3C0
	public void DisableBehavior() { }

	// RVA: 0x175F4C0 Offset: 0x175F5C1 VA: 0x175F4C0
	public void DisableBehavior(bool pause) { }

	// RVA: 0x175F5B0 Offset: 0x175F6B1 VA: 0x175F5B0
	public void OnEnable() { }

	// RVA: 0x175F6C0 Offset: 0x175F7C1 VA: 0x175F6C0
	public void OnDisable() { }

	// RVA: 0x175F6D0 Offset: 0x175F7D1 VA: 0x175F6D0
	public void OnDestroy() { }

	// RVA: 0x175F7D0 Offset: 0x175F8D1 VA: 0x175F7D0 Slot: 9
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175F950 Offset: 0x175FA51 VA: 0x175F950 Slot: 10
	public void SetVariable(string name, SharedVariable item) { }

	// RVA: 0x175F9A0 Offset: 0x175FAA1 VA: 0x175F9A0 Slot: 11
	public void SetVariableValue(string name, object value) { }

	// RVA: 0x175FCD0 Offset: 0x175FDD1 VA: 0x175FCD0
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175F810 Offset: 0x175F911 VA: 0x175F810
	public void CheckForSerialization() { }

	// RVA: 0x175FD20 Offset: 0x175FE21 VA: 0x175FD20
	public void CheckForSerialization(bool forceSerialization) { }

	// RVA: 0x1760060 Offset: 0x1760161 VA: 0x1760060
	public void OnCollisionEnter(Collision collision) { }

	// RVA: 0x1760450 Offset: 0x1760551 VA: 0x1760450
	public void OnCollisionExit(Collision collision) { }

	// RVA: 0x1760840 Offset: 0x1760941 VA: 0x1760840
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x1760C30 Offset: 0x1760D31 VA: 0x1760C30
	public void OnTriggerExit(Collider other) { }

	// RVA: 0x1761020 Offset: 0x1761121 VA: 0x1761020
	public void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x1761410 Offset: 0x1761511 VA: 0x1761410
	public void OnCollisionExit2D(Collision2D collision) { }

	// RVA: 0x1761800 Offset: 0x1761901 VA: 0x1761800
	public void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1761BF0 Offset: 0x1761CF1 VA: 0x1761BF0
	public void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x1761FE0 Offset: 0x17620E1 VA: 0x1761FE0
	public void OnControllerColliderHit(ControllerColliderHit hit) { }

	// RVA: 0x17623D0 Offset: 0x17624D1 VA: 0x17623D0
	public void OnAnimatorIK() { }

	// RVA: 0x17627A0 Offset: 0x17628A1 VA: 0x17627A0
	public void OnDrawGizmos() { }

	// RVA: 0x17628C0 Offset: 0x17629C1 VA: 0x17628C0
	public void OnDrawGizmosSelected() { }

	// RVA: 0x17627B0 Offset: 0x17628B1 VA: 0x17627B0
	private void DrawTaskGizmos(bool selected) { }

	// RVA: 0x1762940 Offset: 0x1762A41 VA: 0x1762940
	private void DrawTaskGizmos(Task task) { }

	// RVA: -1 Offset: -1
	public T FindTask<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDE80 Offset: 0x23BDF81 VA: 0x23BDE80
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	private T FindTask<T>(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDED0 Offset: 0x23BDFD1 VA: 0x23BDED0
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	public List<T> FindTasks<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AA5C0 Offset: 0x21AA6C1 VA: 0x21AA5C0
	|-Behavior.FindTasks<object>
	*/

	// RVA: -1 Offset: -1
	private void FindTasks<T>(Task task, ref List<T> taskList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CDE70 Offset: 0x21CDF71 VA: 0x21CDE70
	|-Behavior.FindTasks<object>
	*/

	// RVA: 0x1762A50 Offset: 0x1762B51 VA: 0x1762A50
	public Task FindTaskWithName(string taskName) { }

	// RVA: 0x1762A90 Offset: 0x1762B91 VA: 0x1762A90
	private Task FindTaskWithName(string taskName, Task task) { }

	// RVA: 0x1762BC0 Offset: 0x1762CC1 VA: 0x1762BC0
	public List<Task> FindTasksWithName(string taskName) { }

	// RVA: 0x1762C70 Offset: 0x1762D71 VA: 0x1762C70
	private void FindTasksWithName(string taskName, Task task, ref List<Task> taskList) { }

	// RVA: 0x1762DB0 Offset: 0x1762EB1 VA: 0x1762DB0
	public List<Task> GetActiveTasks() { }

	// RVA: 0x1763100 Offset: 0x1763201 VA: 0x1763100
	public Coroutine StartTaskCoroutine(Task task, string methodName) { }

	// RVA: 0x17633A0 Offset: 0x17634A1 VA: 0x17633A0
	public Coroutine StartTaskCoroutine(Task task, string methodName, object value) { }

	// RVA: 0x1763690 Offset: 0x1763791 VA: 0x1763690
	public void StopTaskCoroutine(string methodName) { }

	// RVA: 0x1763770 Offset: 0x1763871 VA: 0x1763770
	public void StopAllTaskCoroutines() { }

	// RVA: 0x1763920 Offset: 0x1763A21 VA: 0x1763920
	public void TaskCoroutineEnded(TaskCoroutine taskCoroutine, string coroutineName) { }

	// RVA: 0x1763A30 Offset: 0x1763B31 VA: 0x1763A30
	public void OnBehaviorStarted() { }

	// RVA: 0x1763EF0 Offset: 0x1763FF1 VA: 0x1763EF0
	public void OnBehaviorRestarted() { }

	// RVA: 0x1763F10 Offset: 0x1764011 VA: 0x1763F10
	public void OnBehaviorEnded() { }

	// RVA: 0x1763F30 Offset: 0x1764031 VA: 0x1763F30
	private void RegisterEvent(string name, Delegate handler) { }

	// RVA: 0x17640F0 Offset: 0x17641F1 VA: 0x17640F0
	public void RegisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void RegisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE060 Offset: 0x21CE161 VA: 0x21CE060
	|-Behavior.RegisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE040 Offset: 0x21CE141 VA: 0x21CE040
	|-Behavior.RegisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE020 Offset: 0x21CE121 VA: 0x21CE020
	|-Behavior.RegisterEvent<object, object, object>
	*/

	// RVA: 0x1764100 Offset: 0x1764201 VA: 0x1764100
	private Delegate GetDelegate(string name, Type type) { }

	// RVA: 0x17641C0 Offset: 0x17642C1 VA: 0x17641C0
	public void SendEvent(string name) { }

	// RVA: -1 Offset: -1
	public void SendEvent<T>(string name, T arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE2B0 Offset: 0x21CE3B1 VA: 0x21CE2B0
	|-Behavior.SendEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U>(string name, T arg1, U arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE1A0 Offset: 0x21CE2A1 VA: 0x21CE1A0
	|-Behavior.SendEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U, V>(string name, T arg1, U arg2, V arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE080 Offset: 0x21CE181 VA: 0x21CE080
	|-Behavior.SendEvent<object, object, object>
	*/

	// RVA: 0x1764300 Offset: 0x1764401 VA: 0x1764300
	private void UnregisterEvent(string name, Delegate handler) { }

	// RVA: 0x17643F0 Offset: 0x17644F1 VA: 0x17643F0
	public void UnregisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3F0 Offset: 0x21CE4F1 VA: 0x21CE3F0
	|-Behavior.UnregisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3D0 Offset: 0x21CE4D1 VA: 0x21CE3D0
	|-Behavior.UnregisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3B0 Offset: 0x21CE4B1 VA: 0x21CE3B0
	|-Behavior.UnregisterEvent<object, object, object>
	*/

	// RVA: 0x1764400 Offset: 0x1764501 VA: 0x1764400
	public void SaveResetValues() { }

	// RVA: 0x17644E0 Offset: 0x17645E1 VA: 0x17644E0
	private void SaveValues() { }

	// RVA: 0x1764770 Offset: 0x1764871 VA: 0x1764770
	private void SaveValue(Task task) { }

	// RVA: 0x1764600 Offset: 0x1764701 VA: 0x1764600
	private void ResetValues() { }

	// RVA: 0x1764AD0 Offset: 0x1764BD1 VA: 0x1764AD0
	private void ResetValue(Task task) { }

	// RVA: 0x1764D30 Offset: 0x1764E31 VA: 0x1764D30 Slot: 3
	public override string ToString() { }

	// RVA: 0x175EF60 Offset: 0x175F061 VA: 0x175EF60
	public static BehaviorManager CreateBehaviorManager() { }

	// RVA: 0x1764D50 Offset: 0x1764E51 VA: 0x1764D50 Slot: 12
	virtual int BehaviorDesigner.Runtime.IBehavior.GetInstanceID() { }
}

[Serializable]
public abstract class Behavior : MonoBehaviour, IBehavior // TypeDefIndex: 4646
{
	// Fields
	[TooltipAttribute] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	[SerializeField] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	private bool startWhenEnabled; // 0x18
	[TooltipAttribute] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	[SerializeField] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	private bool asynchronousLoad; // 0x19
	[SerializeField] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	[TooltipAttribute] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	private bool pauseWhenDisabled; // 0x1A
	[SerializeField] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	[TooltipAttribute] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	private bool restartWhenComplete; // 0x1B
	[SerializeField] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	[TooltipAttribute] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	private bool logTaskChanges; // 0x1C
	[SerializeField] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	[TooltipAttribute] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	private int group; // 0x20
	[TooltipAttribute] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	[SerializeField] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	private bool resetValuesOnRestart; // 0x24
	[TooltipAttribute] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	[SerializeField] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	private ExternalBehavior externalBehavior; // 0x28
	private bool hasInheritedVariables; // 0x30
	[SerializeField] // RVA: 0x12D4D0 Offset: 0x12D5D1 VA: 0x12D4D0
	private BehaviorSource mBehaviorSource; // 0x38
	private bool isPaused; // 0x40
	private TaskStatus executionStatus; // 0x44
	private bool initialized; // 0x48
	private Dictionary<Task, Dictionary<string, object>> defaultValues; // 0x50
	private Dictionary<SharedVariable, object> defaultVariableValues; // 0x58
	private bool[] hasEvent; // 0x60
	private Dictionary<string, List<TaskCoroutine>> activeTaskCoroutines; // 0x68
	private Dictionary<Type, Dictionary<string, Delegate>> eventTable; // 0x70
	public Behavior.GizmoViewMode gizmoViewMode; // 0x78
	public bool showBehaviorDesignerGizmo; // 0x7C
	private Behavior.BehaviorHandler OnBehaviorStart; // 0x80
	private Behavior.BehaviorHandler OnBehaviorRestart; // 0x88
	private Behavior.BehaviorHandler OnBehaviorEnd; // 0x90

	// Properties
	public bool StartWhenEnabled { get; set; }
	public bool AsynchronousLoad { get; set; }
	public bool PauseWhenDisabled { get; set; }
	public bool RestartWhenComplete { get; set; }
	public bool LogTaskChanges { get; set; }
	public int Group { get; set; }
	public bool ResetValuesOnRestart { get; set; }
	public ExternalBehavior ExternalBehavior { get; set; }
	public bool HasInheritedVariables { get; set; }
	public string BehaviorName { get; set; }
	public string BehaviorDescription { get; set; }
	public TaskStatus ExecutionStatus { get; set; }
	public bool[] HasEvent { get; }

	// Methods

	// RVA: 0x175E000 Offset: 0x175E101 VA: 0x175E000
	public void .ctor() { }

	// RVA: 0x175E1D0 Offset: 0x175E2D1 VA: 0x175E1D0
	public void add_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E260 Offset: 0x175E361 VA: 0x175E260
	public void remove_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E2F0 Offset: 0x175E3F1 VA: 0x175E2F0
	public void add_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E380 Offset: 0x175E481 VA: 0x175E380
	public void remove_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E410 Offset: 0x175E511 VA: 0x175E410
	public void add_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E4A0 Offset: 0x175E5A1 VA: 0x175E4A0
	public void remove_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E530 Offset: 0x175E631 VA: 0x175E530
	public bool get_StartWhenEnabled() { }

	// RVA: 0x175E540 Offset: 0x175E641 VA: 0x175E540
	public void set_StartWhenEnabled(bool value) { }

	// RVA: 0x175E550 Offset: 0x175E651 VA: 0x175E550
	public bool get_AsynchronousLoad() { }

	// RVA: 0x175E560 Offset: 0x175E661 VA: 0x175E560
	public void set_AsynchronousLoad(bool value) { }

	// RVA: 0x175E570 Offset: 0x175E671 VA: 0x175E570
	public bool get_PauseWhenDisabled() { }

	// RVA: 0x175E580 Offset: 0x175E681 VA: 0x175E580
	public void set_PauseWhenDisabled(bool value) { }

	// RVA: 0x175E590 Offset: 0x175E691 VA: 0x175E590
	public bool get_RestartWhenComplete() { }

	// RVA: 0x175E5A0 Offset: 0x175E6A1 VA: 0x175E5A0
	public void set_RestartWhenComplete(bool value) { }

	// RVA: 0x175E5B0 Offset: 0x175E6B1 VA: 0x175E5B0
	public bool get_LogTaskChanges() { }

	// RVA: 0x175E5C0 Offset: 0x175E6C1 VA: 0x175E5C0
	public void set_LogTaskChanges(bool value) { }

	// RVA: 0x175E5D0 Offset: 0x175E6D1 VA: 0x175E5D0
	public int get_Group() { }

	// RVA: 0x175E5E0 Offset: 0x175E6E1 VA: 0x175E5E0
	public void set_Group(int value) { }

	// RVA: 0x175E5F0 Offset: 0x175E6F1 VA: 0x175E5F0
	public bool get_ResetValuesOnRestart() { }

	// RVA: 0x175E600 Offset: 0x175E701 VA: 0x175E600
	public void set_ResetValuesOnRestart(bool value) { }

	// RVA: 0x175E610 Offset: 0x175E711 VA: 0x175E610
	public ExternalBehavior get_ExternalBehavior() { }

	// RVA: 0x175E620 Offset: 0x175E721 VA: 0x175E620
	public void set_ExternalBehavior(ExternalBehavior value) { }

	// RVA: 0x175ECC0 Offset: 0x175EDC1 VA: 0x175ECC0
	public bool get_HasInheritedVariables() { }

	// RVA: 0x175ECD0 Offset: 0x175EDD1 VA: 0x175ECD0
	public void set_HasInheritedVariables(bool value) { }

	// RVA: 0x175ECE0 Offset: 0x175EDE1 VA: 0x175ECE0
	public string get_BehaviorName() { }

	// RVA: 0x175ED00 Offset: 0x175EE01 VA: 0x175ED00
	public void set_BehaviorName(string value) { }

	// RVA: 0x175ED20 Offset: 0x175EE21 VA: 0x175ED20
	public string get_BehaviorDescription() { }

	// RVA: 0x175ED40 Offset: 0x175EE41 VA: 0x175ED40
	public void set_BehaviorDescription(string value) { }

	// RVA: 0x175ED60 Offset: 0x175EE61 VA: 0x175ED60 Slot: 7
	public BehaviorSource GetBehaviorSource() { }

	// RVA: 0x175ED70 Offset: 0x175EE71 VA: 0x175ED70 Slot: 8
	public void SetBehaviorSource(BehaviorSource behaviorSource) { }

	// RVA: 0x175ED80 Offset: 0x175EE81 VA: 0x175ED80 Slot: 6
	public Object GetObject() { }

	// RVA: 0x175ED90 Offset: 0x175EE91 VA: 0x175ED90 Slot: 4
	public string GetOwnerName() { }

	// RVA: 0x175EDC0 Offset: 0x175EEC1 VA: 0x175EDC0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x175EDD0 Offset: 0x175EED1 VA: 0x175EDD0
	public void set_ExecutionStatus(TaskStatus value) { }

	// RVA: 0x175EDE0 Offset: 0x175EEE1 VA: 0x175EDE0
	public bool[] get_HasEvent() { }

	// RVA: 0x175EDF0 Offset: 0x175EEF1 VA: 0x175EDF0
	public void Start() { }

	// RVA: 0x175EE00 Offset: 0x175EF01 VA: 0x175EE00
	private bool TaskContainsMethod(string methodName, Task task) { }

	// RVA: 0x175EBD0 Offset: 0x175ECD1 VA: 0x175EBD0
	public void EnableBehavior() { }

	// RVA: 0x175F3C0 Offset: 0x175F4C1 VA: 0x175F3C0
	public void DisableBehavior() { }

	// RVA: 0x175F4C0 Offset: 0x175F5C1 VA: 0x175F4C0
	public void DisableBehavior(bool pause) { }

	// RVA: 0x175F5B0 Offset: 0x175F6B1 VA: 0x175F5B0
	public void OnEnable() { }

	// RVA: 0x175F6C0 Offset: 0x175F7C1 VA: 0x175F6C0
	public void OnDisable() { }

	// RVA: 0x175F6D0 Offset: 0x175F7D1 VA: 0x175F6D0
	public void OnDestroy() { }

	// RVA: 0x175F7D0 Offset: 0x175F8D1 VA: 0x175F7D0 Slot: 9
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175F950 Offset: 0x175FA51 VA: 0x175F950 Slot: 10
	public void SetVariable(string name, SharedVariable item) { }

	// RVA: 0x175F9A0 Offset: 0x175FAA1 VA: 0x175F9A0 Slot: 11
	public void SetVariableValue(string name, object value) { }

	// RVA: 0x175FCD0 Offset: 0x175FDD1 VA: 0x175FCD0
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175F810 Offset: 0x175F911 VA: 0x175F810
	public void CheckForSerialization() { }

	// RVA: 0x175FD20 Offset: 0x175FE21 VA: 0x175FD20
	public void CheckForSerialization(bool forceSerialization) { }

	// RVA: 0x1760060 Offset: 0x1760161 VA: 0x1760060
	public void OnCollisionEnter(Collision collision) { }

	// RVA: 0x1760450 Offset: 0x1760551 VA: 0x1760450
	public void OnCollisionExit(Collision collision) { }

	// RVA: 0x1760840 Offset: 0x1760941 VA: 0x1760840
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x1760C30 Offset: 0x1760D31 VA: 0x1760C30
	public void OnTriggerExit(Collider other) { }

	// RVA: 0x1761020 Offset: 0x1761121 VA: 0x1761020
	public void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x1761410 Offset: 0x1761511 VA: 0x1761410
	public void OnCollisionExit2D(Collision2D collision) { }

	// RVA: 0x1761800 Offset: 0x1761901 VA: 0x1761800
	public void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1761BF0 Offset: 0x1761CF1 VA: 0x1761BF0
	public void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x1761FE0 Offset: 0x17620E1 VA: 0x1761FE0
	public void OnControllerColliderHit(ControllerColliderHit hit) { }

	// RVA: 0x17623D0 Offset: 0x17624D1 VA: 0x17623D0
	public void OnAnimatorIK() { }

	// RVA: 0x17627A0 Offset: 0x17628A1 VA: 0x17627A0
	public void OnDrawGizmos() { }

	// RVA: 0x17628C0 Offset: 0x17629C1 VA: 0x17628C0
	public void OnDrawGizmosSelected() { }

	// RVA: 0x17627B0 Offset: 0x17628B1 VA: 0x17627B0
	private void DrawTaskGizmos(bool selected) { }

	// RVA: 0x1762940 Offset: 0x1762A41 VA: 0x1762940
	private void DrawTaskGizmos(Task task) { }

	// RVA: -1 Offset: -1
	public T FindTask<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDE80 Offset: 0x23BDF81 VA: 0x23BDE80
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	private T FindTask<T>(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDED0 Offset: 0x23BDFD1 VA: 0x23BDED0
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	public List<T> FindTasks<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AA5C0 Offset: 0x21AA6C1 VA: 0x21AA5C0
	|-Behavior.FindTasks<object>
	*/

	// RVA: -1 Offset: -1
	private void FindTasks<T>(Task task, ref List<T> taskList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CDE70 Offset: 0x21CDF71 VA: 0x21CDE70
	|-Behavior.FindTasks<object>
	*/

	// RVA: 0x1762A50 Offset: 0x1762B51 VA: 0x1762A50
	public Task FindTaskWithName(string taskName) { }

	// RVA: 0x1762A90 Offset: 0x1762B91 VA: 0x1762A90
	private Task FindTaskWithName(string taskName, Task task) { }

	// RVA: 0x1762BC0 Offset: 0x1762CC1 VA: 0x1762BC0
	public List<Task> FindTasksWithName(string taskName) { }

	// RVA: 0x1762C70 Offset: 0x1762D71 VA: 0x1762C70
	private void FindTasksWithName(string taskName, Task task, ref List<Task> taskList) { }

	// RVA: 0x1762DB0 Offset: 0x1762EB1 VA: 0x1762DB0
	public List<Task> GetActiveTasks() { }

	// RVA: 0x1763100 Offset: 0x1763201 VA: 0x1763100
	public Coroutine StartTaskCoroutine(Task task, string methodName) { }

	// RVA: 0x17633A0 Offset: 0x17634A1 VA: 0x17633A0
	public Coroutine StartTaskCoroutine(Task task, string methodName, object value) { }

	// RVA: 0x1763690 Offset: 0x1763791 VA: 0x1763690
	public void StopTaskCoroutine(string methodName) { }

	// RVA: 0x1763770 Offset: 0x1763871 VA: 0x1763770
	public void StopAllTaskCoroutines() { }

	// RVA: 0x1763920 Offset: 0x1763A21 VA: 0x1763920
	public void TaskCoroutineEnded(TaskCoroutine taskCoroutine, string coroutineName) { }

	// RVA: 0x1763A30 Offset: 0x1763B31 VA: 0x1763A30
	public void OnBehaviorStarted() { }

	// RVA: 0x1763EF0 Offset: 0x1763FF1 VA: 0x1763EF0
	public void OnBehaviorRestarted() { }

	// RVA: 0x1763F10 Offset: 0x1764011 VA: 0x1763F10
	public void OnBehaviorEnded() { }

	// RVA: 0x1763F30 Offset: 0x1764031 VA: 0x1763F30
	private void RegisterEvent(string name, Delegate handler) { }

	// RVA: 0x17640F0 Offset: 0x17641F1 VA: 0x17640F0
	public void RegisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void RegisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE060 Offset: 0x21CE161 VA: 0x21CE060
	|-Behavior.RegisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE040 Offset: 0x21CE141 VA: 0x21CE040
	|-Behavior.RegisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE020 Offset: 0x21CE121 VA: 0x21CE020
	|-Behavior.RegisterEvent<object, object, object>
	*/

	// RVA: 0x1764100 Offset: 0x1764201 VA: 0x1764100
	private Delegate GetDelegate(string name, Type type) { }

	// RVA: 0x17641C0 Offset: 0x17642C1 VA: 0x17641C0
	public void SendEvent(string name) { }

	// RVA: -1 Offset: -1
	public void SendEvent<T>(string name, T arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE2B0 Offset: 0x21CE3B1 VA: 0x21CE2B0
	|-Behavior.SendEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U>(string name, T arg1, U arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE1A0 Offset: 0x21CE2A1 VA: 0x21CE1A0
	|-Behavior.SendEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U, V>(string name, T arg1, U arg2, V arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE080 Offset: 0x21CE181 VA: 0x21CE080
	|-Behavior.SendEvent<object, object, object>
	*/

	// RVA: 0x1764300 Offset: 0x1764401 VA: 0x1764300
	private void UnregisterEvent(string name, Delegate handler) { }

	// RVA: 0x17643F0 Offset: 0x17644F1 VA: 0x17643F0
	public void UnregisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3F0 Offset: 0x21CE4F1 VA: 0x21CE3F0
	|-Behavior.UnregisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3D0 Offset: 0x21CE4D1 VA: 0x21CE3D0
	|-Behavior.UnregisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3B0 Offset: 0x21CE4B1 VA: 0x21CE3B0
	|-Behavior.UnregisterEvent<object, object, object>
	*/

	// RVA: 0x1764400 Offset: 0x1764501 VA: 0x1764400
	public void SaveResetValues() { }

	// RVA: 0x17644E0 Offset: 0x17645E1 VA: 0x17644E0
	private void SaveValues() { }

	// RVA: 0x1764770 Offset: 0x1764871 VA: 0x1764770
	private void SaveValue(Task task) { }

	// RVA: 0x1764600 Offset: 0x1764701 VA: 0x1764600
	private void ResetValues() { }

	// RVA: 0x1764AD0 Offset: 0x1764BD1 VA: 0x1764AD0
	private void ResetValue(Task task) { }

	// RVA: 0x1764D30 Offset: 0x1764E31 VA: 0x1764D30 Slot: 3
	public override string ToString() { }

	// RVA: 0x175EF60 Offset: 0x175F061 VA: 0x175EF60
	public static BehaviorManager CreateBehaviorManager() { }

	// RVA: 0x1764D50 Offset: 0x1764E51 VA: 0x1764D50 Slot: 12
	virtual int BehaviorDesigner.Runtime.IBehavior.GetInstanceID() { }
}

[Serializable]
public abstract class Behavior : MonoBehaviour, IBehavior // TypeDefIndex: 4646
{
	// Fields
	[TooltipAttribute] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	[SerializeField] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	private bool startWhenEnabled; // 0x18
	[TooltipAttribute] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	[SerializeField] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	private bool asynchronousLoad; // 0x19
	[SerializeField] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	[TooltipAttribute] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	private bool pauseWhenDisabled; // 0x1A
	[SerializeField] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	[TooltipAttribute] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	private bool restartWhenComplete; // 0x1B
	[SerializeField] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	[TooltipAttribute] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	private bool logTaskChanges; // 0x1C
	[SerializeField] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	[TooltipAttribute] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	private int group; // 0x20
	[TooltipAttribute] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	[SerializeField] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	private bool resetValuesOnRestart; // 0x24
	[TooltipAttribute] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	[SerializeField] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	private ExternalBehavior externalBehavior; // 0x28
	private bool hasInheritedVariables; // 0x30
	[SerializeField] // RVA: 0x12D4D0 Offset: 0x12D5D1 VA: 0x12D4D0
	private BehaviorSource mBehaviorSource; // 0x38
	private bool isPaused; // 0x40
	private TaskStatus executionStatus; // 0x44
	private bool initialized; // 0x48
	private Dictionary<Task, Dictionary<string, object>> defaultValues; // 0x50
	private Dictionary<SharedVariable, object> defaultVariableValues; // 0x58
	private bool[] hasEvent; // 0x60
	private Dictionary<string, List<TaskCoroutine>> activeTaskCoroutines; // 0x68
	private Dictionary<Type, Dictionary<string, Delegate>> eventTable; // 0x70
	public Behavior.GizmoViewMode gizmoViewMode; // 0x78
	public bool showBehaviorDesignerGizmo; // 0x7C
	private Behavior.BehaviorHandler OnBehaviorStart; // 0x80
	private Behavior.BehaviorHandler OnBehaviorRestart; // 0x88
	private Behavior.BehaviorHandler OnBehaviorEnd; // 0x90

	// Properties
	public bool StartWhenEnabled { get; set; }
	public bool AsynchronousLoad { get; set; }
	public bool PauseWhenDisabled { get; set; }
	public bool RestartWhenComplete { get; set; }
	public bool LogTaskChanges { get; set; }
	public int Group { get; set; }
	public bool ResetValuesOnRestart { get; set; }
	public ExternalBehavior ExternalBehavior { get; set; }
	public bool HasInheritedVariables { get; set; }
	public string BehaviorName { get; set; }
	public string BehaviorDescription { get; set; }
	public TaskStatus ExecutionStatus { get; set; }
	public bool[] HasEvent { get; }

	// Methods

	// RVA: 0x175E000 Offset: 0x175E101 VA: 0x175E000
	public void .ctor() { }

	// RVA: 0x175E1D0 Offset: 0x175E2D1 VA: 0x175E1D0
	public void add_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E260 Offset: 0x175E361 VA: 0x175E260
	public void remove_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E2F0 Offset: 0x175E3F1 VA: 0x175E2F0
	public void add_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E380 Offset: 0x175E481 VA: 0x175E380
	public void remove_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E410 Offset: 0x175E511 VA: 0x175E410
	public void add_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E4A0 Offset: 0x175E5A1 VA: 0x175E4A0
	public void remove_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E530 Offset: 0x175E631 VA: 0x175E530
	public bool get_StartWhenEnabled() { }

	// RVA: 0x175E540 Offset: 0x175E641 VA: 0x175E540
	public void set_StartWhenEnabled(bool value) { }

	// RVA: 0x175E550 Offset: 0x175E651 VA: 0x175E550
	public bool get_AsynchronousLoad() { }

	// RVA: 0x175E560 Offset: 0x175E661 VA: 0x175E560
	public void set_AsynchronousLoad(bool value) { }

	// RVA: 0x175E570 Offset: 0x175E671 VA: 0x175E570
	public bool get_PauseWhenDisabled() { }

	// RVA: 0x175E580 Offset: 0x175E681 VA: 0x175E580
	public void set_PauseWhenDisabled(bool value) { }

	// RVA: 0x175E590 Offset: 0x175E691 VA: 0x175E590
	public bool get_RestartWhenComplete() { }

	// RVA: 0x175E5A0 Offset: 0x175E6A1 VA: 0x175E5A0
	public void set_RestartWhenComplete(bool value) { }

	// RVA: 0x175E5B0 Offset: 0x175E6B1 VA: 0x175E5B0
	public bool get_LogTaskChanges() { }

	// RVA: 0x175E5C0 Offset: 0x175E6C1 VA: 0x175E5C0
	public void set_LogTaskChanges(bool value) { }

	// RVA: 0x175E5D0 Offset: 0x175E6D1 VA: 0x175E5D0
	public int get_Group() { }

	// RVA: 0x175E5E0 Offset: 0x175E6E1 VA: 0x175E5E0
	public void set_Group(int value) { }

	// RVA: 0x175E5F0 Offset: 0x175E6F1 VA: 0x175E5F0
	public bool get_ResetValuesOnRestart() { }

	// RVA: 0x175E600 Offset: 0x175E701 VA: 0x175E600
	public void set_ResetValuesOnRestart(bool value) { }

	// RVA: 0x175E610 Offset: 0x175E711 VA: 0x175E610
	public ExternalBehavior get_ExternalBehavior() { }

	// RVA: 0x175E620 Offset: 0x175E721 VA: 0x175E620
	public void set_ExternalBehavior(ExternalBehavior value) { }

	// RVA: 0x175ECC0 Offset: 0x175EDC1 VA: 0x175ECC0
	public bool get_HasInheritedVariables() { }

	// RVA: 0x175ECD0 Offset: 0x175EDD1 VA: 0x175ECD0
	public void set_HasInheritedVariables(bool value) { }

	// RVA: 0x175ECE0 Offset: 0x175EDE1 VA: 0x175ECE0
	public string get_BehaviorName() { }

	// RVA: 0x175ED00 Offset: 0x175EE01 VA: 0x175ED00
	public void set_BehaviorName(string value) { }

	// RVA: 0x175ED20 Offset: 0x175EE21 VA: 0x175ED20
	public string get_BehaviorDescription() { }

	// RVA: 0x175ED40 Offset: 0x175EE41 VA: 0x175ED40
	public void set_BehaviorDescription(string value) { }

	// RVA: 0x175ED60 Offset: 0x175EE61 VA: 0x175ED60 Slot: 7
	public BehaviorSource GetBehaviorSource() { }

	// RVA: 0x175ED70 Offset: 0x175EE71 VA: 0x175ED70 Slot: 8
	public void SetBehaviorSource(BehaviorSource behaviorSource) { }

	// RVA: 0x175ED80 Offset: 0x175EE81 VA: 0x175ED80 Slot: 6
	public Object GetObject() { }

	// RVA: 0x175ED90 Offset: 0x175EE91 VA: 0x175ED90 Slot: 4
	public string GetOwnerName() { }

	// RVA: 0x175EDC0 Offset: 0x175EEC1 VA: 0x175EDC0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x175EDD0 Offset: 0x175EED1 VA: 0x175EDD0
	public void set_ExecutionStatus(TaskStatus value) { }

	// RVA: 0x175EDE0 Offset: 0x175EEE1 VA: 0x175EDE0
	public bool[] get_HasEvent() { }

	// RVA: 0x175EDF0 Offset: 0x175EEF1 VA: 0x175EDF0
	public void Start() { }

	// RVA: 0x175EE00 Offset: 0x175EF01 VA: 0x175EE00
	private bool TaskContainsMethod(string methodName, Task task) { }

	// RVA: 0x175EBD0 Offset: 0x175ECD1 VA: 0x175EBD0
	public void EnableBehavior() { }

	// RVA: 0x175F3C0 Offset: 0x175F4C1 VA: 0x175F3C0
	public void DisableBehavior() { }

	// RVA: 0x175F4C0 Offset: 0x175F5C1 VA: 0x175F4C0
	public void DisableBehavior(bool pause) { }

	// RVA: 0x175F5B0 Offset: 0x175F6B1 VA: 0x175F5B0
	public void OnEnable() { }

	// RVA: 0x175F6C0 Offset: 0x175F7C1 VA: 0x175F6C0
	public void OnDisable() { }

	// RVA: 0x175F6D0 Offset: 0x175F7D1 VA: 0x175F6D0
	public void OnDestroy() { }

	// RVA: 0x175F7D0 Offset: 0x175F8D1 VA: 0x175F7D0 Slot: 9
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175F950 Offset: 0x175FA51 VA: 0x175F950 Slot: 10
	public void SetVariable(string name, SharedVariable item) { }

	// RVA: 0x175F9A0 Offset: 0x175FAA1 VA: 0x175F9A0 Slot: 11
	public void SetVariableValue(string name, object value) { }

	// RVA: 0x175FCD0 Offset: 0x175FDD1 VA: 0x175FCD0
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175F810 Offset: 0x175F911 VA: 0x175F810
	public void CheckForSerialization() { }

	// RVA: 0x175FD20 Offset: 0x175FE21 VA: 0x175FD20
	public void CheckForSerialization(bool forceSerialization) { }

	// RVA: 0x1760060 Offset: 0x1760161 VA: 0x1760060
	public void OnCollisionEnter(Collision collision) { }

	// RVA: 0x1760450 Offset: 0x1760551 VA: 0x1760450
	public void OnCollisionExit(Collision collision) { }

	// RVA: 0x1760840 Offset: 0x1760941 VA: 0x1760840
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x1760C30 Offset: 0x1760D31 VA: 0x1760C30
	public void OnTriggerExit(Collider other) { }

	// RVA: 0x1761020 Offset: 0x1761121 VA: 0x1761020
	public void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x1761410 Offset: 0x1761511 VA: 0x1761410
	public void OnCollisionExit2D(Collision2D collision) { }

	// RVA: 0x1761800 Offset: 0x1761901 VA: 0x1761800
	public void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1761BF0 Offset: 0x1761CF1 VA: 0x1761BF0
	public void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x1761FE0 Offset: 0x17620E1 VA: 0x1761FE0
	public void OnControllerColliderHit(ControllerColliderHit hit) { }

	// RVA: 0x17623D0 Offset: 0x17624D1 VA: 0x17623D0
	public void OnAnimatorIK() { }

	// RVA: 0x17627A0 Offset: 0x17628A1 VA: 0x17627A0
	public void OnDrawGizmos() { }

	// RVA: 0x17628C0 Offset: 0x17629C1 VA: 0x17628C0
	public void OnDrawGizmosSelected() { }

	// RVA: 0x17627B0 Offset: 0x17628B1 VA: 0x17627B0
	private void DrawTaskGizmos(bool selected) { }

	// RVA: 0x1762940 Offset: 0x1762A41 VA: 0x1762940
	private void DrawTaskGizmos(Task task) { }

	// RVA: -1 Offset: -1
	public T FindTask<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDE80 Offset: 0x23BDF81 VA: 0x23BDE80
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	private T FindTask<T>(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDED0 Offset: 0x23BDFD1 VA: 0x23BDED0
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	public List<T> FindTasks<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AA5C0 Offset: 0x21AA6C1 VA: 0x21AA5C0
	|-Behavior.FindTasks<object>
	*/

	// RVA: -1 Offset: -1
	private void FindTasks<T>(Task task, ref List<T> taskList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CDE70 Offset: 0x21CDF71 VA: 0x21CDE70
	|-Behavior.FindTasks<object>
	*/

	// RVA: 0x1762A50 Offset: 0x1762B51 VA: 0x1762A50
	public Task FindTaskWithName(string taskName) { }

	// RVA: 0x1762A90 Offset: 0x1762B91 VA: 0x1762A90
	private Task FindTaskWithName(string taskName, Task task) { }

	// RVA: 0x1762BC0 Offset: 0x1762CC1 VA: 0x1762BC0
	public List<Task> FindTasksWithName(string taskName) { }

	// RVA: 0x1762C70 Offset: 0x1762D71 VA: 0x1762C70
	private void FindTasksWithName(string taskName, Task task, ref List<Task> taskList) { }

	// RVA: 0x1762DB0 Offset: 0x1762EB1 VA: 0x1762DB0
	public List<Task> GetActiveTasks() { }

	// RVA: 0x1763100 Offset: 0x1763201 VA: 0x1763100
	public Coroutine StartTaskCoroutine(Task task, string methodName) { }

	// RVA: 0x17633A0 Offset: 0x17634A1 VA: 0x17633A0
	public Coroutine StartTaskCoroutine(Task task, string methodName, object value) { }

	// RVA: 0x1763690 Offset: 0x1763791 VA: 0x1763690
	public void StopTaskCoroutine(string methodName) { }

	// RVA: 0x1763770 Offset: 0x1763871 VA: 0x1763770
	public void StopAllTaskCoroutines() { }

	// RVA: 0x1763920 Offset: 0x1763A21 VA: 0x1763920
	public void TaskCoroutineEnded(TaskCoroutine taskCoroutine, string coroutineName) { }

	// RVA: 0x1763A30 Offset: 0x1763B31 VA: 0x1763A30
	public void OnBehaviorStarted() { }

	// RVA: 0x1763EF0 Offset: 0x1763FF1 VA: 0x1763EF0
	public void OnBehaviorRestarted() { }

	// RVA: 0x1763F10 Offset: 0x1764011 VA: 0x1763F10
	public void OnBehaviorEnded() { }

	// RVA: 0x1763F30 Offset: 0x1764031 VA: 0x1763F30
	private void RegisterEvent(string name, Delegate handler) { }

	// RVA: 0x17640F0 Offset: 0x17641F1 VA: 0x17640F0
	public void RegisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void RegisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE060 Offset: 0x21CE161 VA: 0x21CE060
	|-Behavior.RegisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE040 Offset: 0x21CE141 VA: 0x21CE040
	|-Behavior.RegisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE020 Offset: 0x21CE121 VA: 0x21CE020
	|-Behavior.RegisterEvent<object, object, object>
	*/

	// RVA: 0x1764100 Offset: 0x1764201 VA: 0x1764100
	private Delegate GetDelegate(string name, Type type) { }

	// RVA: 0x17641C0 Offset: 0x17642C1 VA: 0x17641C0
	public void SendEvent(string name) { }

	// RVA: -1 Offset: -1
	public void SendEvent<T>(string name, T arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE2B0 Offset: 0x21CE3B1 VA: 0x21CE2B0
	|-Behavior.SendEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U>(string name, T arg1, U arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE1A0 Offset: 0x21CE2A1 VA: 0x21CE1A0
	|-Behavior.SendEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U, V>(string name, T arg1, U arg2, V arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE080 Offset: 0x21CE181 VA: 0x21CE080
	|-Behavior.SendEvent<object, object, object>
	*/

	// RVA: 0x1764300 Offset: 0x1764401 VA: 0x1764300
	private void UnregisterEvent(string name, Delegate handler) { }

	// RVA: 0x17643F0 Offset: 0x17644F1 VA: 0x17643F0
	public void UnregisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3F0 Offset: 0x21CE4F1 VA: 0x21CE3F0
	|-Behavior.UnregisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3D0 Offset: 0x21CE4D1 VA: 0x21CE3D0
	|-Behavior.UnregisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3B0 Offset: 0x21CE4B1 VA: 0x21CE3B0
	|-Behavior.UnregisterEvent<object, object, object>
	*/

	// RVA: 0x1764400 Offset: 0x1764501 VA: 0x1764400
	public void SaveResetValues() { }

	// RVA: 0x17644E0 Offset: 0x17645E1 VA: 0x17644E0
	private void SaveValues() { }

	// RVA: 0x1764770 Offset: 0x1764871 VA: 0x1764770
	private void SaveValue(Task task) { }

	// RVA: 0x1764600 Offset: 0x1764701 VA: 0x1764600
	private void ResetValues() { }

	// RVA: 0x1764AD0 Offset: 0x1764BD1 VA: 0x1764AD0
	private void ResetValue(Task task) { }

	// RVA: 0x1764D30 Offset: 0x1764E31 VA: 0x1764D30 Slot: 3
	public override string ToString() { }

	// RVA: 0x175EF60 Offset: 0x175F061 VA: 0x175EF60
	public static BehaviorManager CreateBehaviorManager() { }

	// RVA: 0x1764D50 Offset: 0x1764E51 VA: 0x1764D50 Slot: 12
	virtual int BehaviorDesigner.Runtime.IBehavior.GetInstanceID() { }
}

[Serializable]
public abstract class Behavior : MonoBehaviour, IBehavior // TypeDefIndex: 4646
{
	// Fields
	[TooltipAttribute] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	[SerializeField] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	private bool startWhenEnabled; // 0x18
	[TooltipAttribute] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	[SerializeField] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	private bool asynchronousLoad; // 0x19
	[SerializeField] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	[TooltipAttribute] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	private bool pauseWhenDisabled; // 0x1A
	[SerializeField] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	[TooltipAttribute] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	private bool restartWhenComplete; // 0x1B
	[SerializeField] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	[TooltipAttribute] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	private bool logTaskChanges; // 0x1C
	[SerializeField] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	[TooltipAttribute] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	private int group; // 0x20
	[TooltipAttribute] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	[SerializeField] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	private bool resetValuesOnRestart; // 0x24
	[TooltipAttribute] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	[SerializeField] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	private ExternalBehavior externalBehavior; // 0x28
	private bool hasInheritedVariables; // 0x30
	[SerializeField] // RVA: 0x12D4D0 Offset: 0x12D5D1 VA: 0x12D4D0
	private BehaviorSource mBehaviorSource; // 0x38
	private bool isPaused; // 0x40
	private TaskStatus executionStatus; // 0x44
	private bool initialized; // 0x48
	private Dictionary<Task, Dictionary<string, object>> defaultValues; // 0x50
	private Dictionary<SharedVariable, object> defaultVariableValues; // 0x58
	private bool[] hasEvent; // 0x60
	private Dictionary<string, List<TaskCoroutine>> activeTaskCoroutines; // 0x68
	private Dictionary<Type, Dictionary<string, Delegate>> eventTable; // 0x70
	public Behavior.GizmoViewMode gizmoViewMode; // 0x78
	public bool showBehaviorDesignerGizmo; // 0x7C
	private Behavior.BehaviorHandler OnBehaviorStart; // 0x80
	private Behavior.BehaviorHandler OnBehaviorRestart; // 0x88
	private Behavior.BehaviorHandler OnBehaviorEnd; // 0x90

	// Properties
	public bool StartWhenEnabled { get; set; }
	public bool AsynchronousLoad { get; set; }
	public bool PauseWhenDisabled { get; set; }
	public bool RestartWhenComplete { get; set; }
	public bool LogTaskChanges { get; set; }
	public int Group { get; set; }
	public bool ResetValuesOnRestart { get; set; }
	public ExternalBehavior ExternalBehavior { get; set; }
	public bool HasInheritedVariables { get; set; }
	public string BehaviorName { get; set; }
	public string BehaviorDescription { get; set; }
	public TaskStatus ExecutionStatus { get; set; }
	public bool[] HasEvent { get; }

	// Methods

	// RVA: 0x175E000 Offset: 0x175E101 VA: 0x175E000
	public void .ctor() { }

	// RVA: 0x175E1D0 Offset: 0x175E2D1 VA: 0x175E1D0
	public void add_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E260 Offset: 0x175E361 VA: 0x175E260
	public void remove_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E2F0 Offset: 0x175E3F1 VA: 0x175E2F0
	public void add_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E380 Offset: 0x175E481 VA: 0x175E380
	public void remove_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E410 Offset: 0x175E511 VA: 0x175E410
	public void add_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E4A0 Offset: 0x175E5A1 VA: 0x175E4A0
	public void remove_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E530 Offset: 0x175E631 VA: 0x175E530
	public bool get_StartWhenEnabled() { }

	// RVA: 0x175E540 Offset: 0x175E641 VA: 0x175E540
	public void set_StartWhenEnabled(bool value) { }

	// RVA: 0x175E550 Offset: 0x175E651 VA: 0x175E550
	public bool get_AsynchronousLoad() { }

	// RVA: 0x175E560 Offset: 0x175E661 VA: 0x175E560
	public void set_AsynchronousLoad(bool value) { }

	// RVA: 0x175E570 Offset: 0x175E671 VA: 0x175E570
	public bool get_PauseWhenDisabled() { }

	// RVA: 0x175E580 Offset: 0x175E681 VA: 0x175E580
	public void set_PauseWhenDisabled(bool value) { }

	// RVA: 0x175E590 Offset: 0x175E691 VA: 0x175E590
	public bool get_RestartWhenComplete() { }

	// RVA: 0x175E5A0 Offset: 0x175E6A1 VA: 0x175E5A0
	public void set_RestartWhenComplete(bool value) { }

	// RVA: 0x175E5B0 Offset: 0x175E6B1 VA: 0x175E5B0
	public bool get_LogTaskChanges() { }

	// RVA: 0x175E5C0 Offset: 0x175E6C1 VA: 0x175E5C0
	public void set_LogTaskChanges(bool value) { }

	// RVA: 0x175E5D0 Offset: 0x175E6D1 VA: 0x175E5D0
	public int get_Group() { }

	// RVA: 0x175E5E0 Offset: 0x175E6E1 VA: 0x175E5E0
	public void set_Group(int value) { }

	// RVA: 0x175E5F0 Offset: 0x175E6F1 VA: 0x175E5F0
	public bool get_ResetValuesOnRestart() { }

	// RVA: 0x175E600 Offset: 0x175E701 VA: 0x175E600
	public void set_ResetValuesOnRestart(bool value) { }

	// RVA: 0x175E610 Offset: 0x175E711 VA: 0x175E610
	public ExternalBehavior get_ExternalBehavior() { }

	// RVA: 0x175E620 Offset: 0x175E721 VA: 0x175E620
	public void set_ExternalBehavior(ExternalBehavior value) { }

	// RVA: 0x175ECC0 Offset: 0x175EDC1 VA: 0x175ECC0
	public bool get_HasInheritedVariables() { }

	// RVA: 0x175ECD0 Offset: 0x175EDD1 VA: 0x175ECD0
	public void set_HasInheritedVariables(bool value) { }

	// RVA: 0x175ECE0 Offset: 0x175EDE1 VA: 0x175ECE0
	public string get_BehaviorName() { }

	// RVA: 0x175ED00 Offset: 0x175EE01 VA: 0x175ED00
	public void set_BehaviorName(string value) { }

	// RVA: 0x175ED20 Offset: 0x175EE21 VA: 0x175ED20
	public string get_BehaviorDescription() { }

	// RVA: 0x175ED40 Offset: 0x175EE41 VA: 0x175ED40
	public void set_BehaviorDescription(string value) { }

	// RVA: 0x175ED60 Offset: 0x175EE61 VA: 0x175ED60 Slot: 7
	public BehaviorSource GetBehaviorSource() { }

	// RVA: 0x175ED70 Offset: 0x175EE71 VA: 0x175ED70 Slot: 8
	public void SetBehaviorSource(BehaviorSource behaviorSource) { }

	// RVA: 0x175ED80 Offset: 0x175EE81 VA: 0x175ED80 Slot: 6
	public Object GetObject() { }

	// RVA: 0x175ED90 Offset: 0x175EE91 VA: 0x175ED90 Slot: 4
	public string GetOwnerName() { }

	// RVA: 0x175EDC0 Offset: 0x175EEC1 VA: 0x175EDC0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x175EDD0 Offset: 0x175EED1 VA: 0x175EDD0
	public void set_ExecutionStatus(TaskStatus value) { }

	// RVA: 0x175EDE0 Offset: 0x175EEE1 VA: 0x175EDE0
	public bool[] get_HasEvent() { }

	// RVA: 0x175EDF0 Offset: 0x175EEF1 VA: 0x175EDF0
	public void Start() { }

	// RVA: 0x175EE00 Offset: 0x175EF01 VA: 0x175EE00
	private bool TaskContainsMethod(string methodName, Task task) { }

	// RVA: 0x175EBD0 Offset: 0x175ECD1 VA: 0x175EBD0
	public void EnableBehavior() { }

	// RVA: 0x175F3C0 Offset: 0x175F4C1 VA: 0x175F3C0
	public void DisableBehavior() { }

	// RVA: 0x175F4C0 Offset: 0x175F5C1 VA: 0x175F4C0
	public void DisableBehavior(bool pause) { }

	// RVA: 0x175F5B0 Offset: 0x175F6B1 VA: 0x175F5B0
	public void OnEnable() { }

	// RVA: 0x175F6C0 Offset: 0x175F7C1 VA: 0x175F6C0
	public void OnDisable() { }

	// RVA: 0x175F6D0 Offset: 0x175F7D1 VA: 0x175F6D0
	public void OnDestroy() { }

	// RVA: 0x175F7D0 Offset: 0x175F8D1 VA: 0x175F7D0 Slot: 9
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175F950 Offset: 0x175FA51 VA: 0x175F950 Slot: 10
	public void SetVariable(string name, SharedVariable item) { }

	// RVA: 0x175F9A0 Offset: 0x175FAA1 VA: 0x175F9A0 Slot: 11
	public void SetVariableValue(string name, object value) { }

	// RVA: 0x175FCD0 Offset: 0x175FDD1 VA: 0x175FCD0
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175F810 Offset: 0x175F911 VA: 0x175F810
	public void CheckForSerialization() { }

	// RVA: 0x175FD20 Offset: 0x175FE21 VA: 0x175FD20
	public void CheckForSerialization(bool forceSerialization) { }

	// RVA: 0x1760060 Offset: 0x1760161 VA: 0x1760060
	public void OnCollisionEnter(Collision collision) { }

	// RVA: 0x1760450 Offset: 0x1760551 VA: 0x1760450
	public void OnCollisionExit(Collision collision) { }

	// RVA: 0x1760840 Offset: 0x1760941 VA: 0x1760840
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x1760C30 Offset: 0x1760D31 VA: 0x1760C30
	public void OnTriggerExit(Collider other) { }

	// RVA: 0x1761020 Offset: 0x1761121 VA: 0x1761020
	public void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x1761410 Offset: 0x1761511 VA: 0x1761410
	public void OnCollisionExit2D(Collision2D collision) { }

	// RVA: 0x1761800 Offset: 0x1761901 VA: 0x1761800
	public void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1761BF0 Offset: 0x1761CF1 VA: 0x1761BF0
	public void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x1761FE0 Offset: 0x17620E1 VA: 0x1761FE0
	public void OnControllerColliderHit(ControllerColliderHit hit) { }

	// RVA: 0x17623D0 Offset: 0x17624D1 VA: 0x17623D0
	public void OnAnimatorIK() { }

	// RVA: 0x17627A0 Offset: 0x17628A1 VA: 0x17627A0
	public void OnDrawGizmos() { }

	// RVA: 0x17628C0 Offset: 0x17629C1 VA: 0x17628C0
	public void OnDrawGizmosSelected() { }

	// RVA: 0x17627B0 Offset: 0x17628B1 VA: 0x17627B0
	private void DrawTaskGizmos(bool selected) { }

	// RVA: 0x1762940 Offset: 0x1762A41 VA: 0x1762940
	private void DrawTaskGizmos(Task task) { }

	// RVA: -1 Offset: -1
	public T FindTask<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDE80 Offset: 0x23BDF81 VA: 0x23BDE80
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	private T FindTask<T>(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDED0 Offset: 0x23BDFD1 VA: 0x23BDED0
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	public List<T> FindTasks<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AA5C0 Offset: 0x21AA6C1 VA: 0x21AA5C0
	|-Behavior.FindTasks<object>
	*/

	// RVA: -1 Offset: -1
	private void FindTasks<T>(Task task, ref List<T> taskList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CDE70 Offset: 0x21CDF71 VA: 0x21CDE70
	|-Behavior.FindTasks<object>
	*/

	// RVA: 0x1762A50 Offset: 0x1762B51 VA: 0x1762A50
	public Task FindTaskWithName(string taskName) { }

	// RVA: 0x1762A90 Offset: 0x1762B91 VA: 0x1762A90
	private Task FindTaskWithName(string taskName, Task task) { }

	// RVA: 0x1762BC0 Offset: 0x1762CC1 VA: 0x1762BC0
	public List<Task> FindTasksWithName(string taskName) { }

	// RVA: 0x1762C70 Offset: 0x1762D71 VA: 0x1762C70
	private void FindTasksWithName(string taskName, Task task, ref List<Task> taskList) { }

	// RVA: 0x1762DB0 Offset: 0x1762EB1 VA: 0x1762DB0
	public List<Task> GetActiveTasks() { }

	// RVA: 0x1763100 Offset: 0x1763201 VA: 0x1763100
	public Coroutine StartTaskCoroutine(Task task, string methodName) { }

	// RVA: 0x17633A0 Offset: 0x17634A1 VA: 0x17633A0
	public Coroutine StartTaskCoroutine(Task task, string methodName, object value) { }

	// RVA: 0x1763690 Offset: 0x1763791 VA: 0x1763690
	public void StopTaskCoroutine(string methodName) { }

	// RVA: 0x1763770 Offset: 0x1763871 VA: 0x1763770
	public void StopAllTaskCoroutines() { }

	// RVA: 0x1763920 Offset: 0x1763A21 VA: 0x1763920
	public void TaskCoroutineEnded(TaskCoroutine taskCoroutine, string coroutineName) { }

	// RVA: 0x1763A30 Offset: 0x1763B31 VA: 0x1763A30
	public void OnBehaviorStarted() { }

	// RVA: 0x1763EF0 Offset: 0x1763FF1 VA: 0x1763EF0
	public void OnBehaviorRestarted() { }

	// RVA: 0x1763F10 Offset: 0x1764011 VA: 0x1763F10
	public void OnBehaviorEnded() { }

	// RVA: 0x1763F30 Offset: 0x1764031 VA: 0x1763F30
	private void RegisterEvent(string name, Delegate handler) { }

	// RVA: 0x17640F0 Offset: 0x17641F1 VA: 0x17640F0
	public void RegisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void RegisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE060 Offset: 0x21CE161 VA: 0x21CE060
	|-Behavior.RegisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE040 Offset: 0x21CE141 VA: 0x21CE040
	|-Behavior.RegisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE020 Offset: 0x21CE121 VA: 0x21CE020
	|-Behavior.RegisterEvent<object, object, object>
	*/

	// RVA: 0x1764100 Offset: 0x1764201 VA: 0x1764100
	private Delegate GetDelegate(string name, Type type) { }

	// RVA: 0x17641C0 Offset: 0x17642C1 VA: 0x17641C0
	public void SendEvent(string name) { }

	// RVA: -1 Offset: -1
	public void SendEvent<T>(string name, T arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE2B0 Offset: 0x21CE3B1 VA: 0x21CE2B0
	|-Behavior.SendEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U>(string name, T arg1, U arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE1A0 Offset: 0x21CE2A1 VA: 0x21CE1A0
	|-Behavior.SendEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U, V>(string name, T arg1, U arg2, V arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE080 Offset: 0x21CE181 VA: 0x21CE080
	|-Behavior.SendEvent<object, object, object>
	*/

	// RVA: 0x1764300 Offset: 0x1764401 VA: 0x1764300
	private void UnregisterEvent(string name, Delegate handler) { }

	// RVA: 0x17643F0 Offset: 0x17644F1 VA: 0x17643F0
	public void UnregisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3F0 Offset: 0x21CE4F1 VA: 0x21CE3F0
	|-Behavior.UnregisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3D0 Offset: 0x21CE4D1 VA: 0x21CE3D0
	|-Behavior.UnregisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3B0 Offset: 0x21CE4B1 VA: 0x21CE3B0
	|-Behavior.UnregisterEvent<object, object, object>
	*/

	// RVA: 0x1764400 Offset: 0x1764501 VA: 0x1764400
	public void SaveResetValues() { }

	// RVA: 0x17644E0 Offset: 0x17645E1 VA: 0x17644E0
	private void SaveValues() { }

	// RVA: 0x1764770 Offset: 0x1764871 VA: 0x1764770
	private void SaveValue(Task task) { }

	// RVA: 0x1764600 Offset: 0x1764701 VA: 0x1764600
	private void ResetValues() { }

	// RVA: 0x1764AD0 Offset: 0x1764BD1 VA: 0x1764AD0
	private void ResetValue(Task task) { }

	// RVA: 0x1764D30 Offset: 0x1764E31 VA: 0x1764D30 Slot: 3
	public override string ToString() { }

	// RVA: 0x175EF60 Offset: 0x175F061 VA: 0x175EF60
	public static BehaviorManager CreateBehaviorManager() { }

	// RVA: 0x1764D50 Offset: 0x1764E51 VA: 0x1764D50 Slot: 12
	virtual int BehaviorDesigner.Runtime.IBehavior.GetInstanceID() { }
}

[Serializable]
public abstract class Behavior : MonoBehaviour, IBehavior // TypeDefIndex: 4646
{
	// Fields
	[TooltipAttribute] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	[SerializeField] // RVA: 0x12D250 Offset: 0x12D351 VA: 0x12D250
	private bool startWhenEnabled; // 0x18
	[TooltipAttribute] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	[SerializeField] // RVA: 0x12D2A0 Offset: 0x12D3A1 VA: 0x12D2A0
	private bool asynchronousLoad; // 0x19
	[SerializeField] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	[TooltipAttribute] // RVA: 0x12D2F0 Offset: 0x12D3F1 VA: 0x12D2F0
	private bool pauseWhenDisabled; // 0x1A
	[SerializeField] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	[TooltipAttribute] // RVA: 0x12D340 Offset: 0x12D441 VA: 0x12D340
	private bool restartWhenComplete; // 0x1B
	[SerializeField] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	[TooltipAttribute] // RVA: 0x12D390 Offset: 0x12D491 VA: 0x12D390
	private bool logTaskChanges; // 0x1C
	[SerializeField] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	[TooltipAttribute] // RVA: 0x12D3E0 Offset: 0x12D4E1 VA: 0x12D3E0
	private int group; // 0x20
	[TooltipAttribute] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	[SerializeField] // RVA: 0x12D430 Offset: 0x12D531 VA: 0x12D430
	private bool resetValuesOnRestart; // 0x24
	[TooltipAttribute] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	[SerializeField] // RVA: 0x12D480 Offset: 0x12D581 VA: 0x12D480
	private ExternalBehavior externalBehavior; // 0x28
	private bool hasInheritedVariables; // 0x30
	[SerializeField] // RVA: 0x12D4D0 Offset: 0x12D5D1 VA: 0x12D4D0
	private BehaviorSource mBehaviorSource; // 0x38
	private bool isPaused; // 0x40
	private TaskStatus executionStatus; // 0x44
	private bool initialized; // 0x48
	private Dictionary<Task, Dictionary<string, object>> defaultValues; // 0x50
	private Dictionary<SharedVariable, object> defaultVariableValues; // 0x58
	private bool[] hasEvent; // 0x60
	private Dictionary<string, List<TaskCoroutine>> activeTaskCoroutines; // 0x68
	private Dictionary<Type, Dictionary<string, Delegate>> eventTable; // 0x70
	public Behavior.GizmoViewMode gizmoViewMode; // 0x78
	public bool showBehaviorDesignerGizmo; // 0x7C
	private Behavior.BehaviorHandler OnBehaviorStart; // 0x80
	private Behavior.BehaviorHandler OnBehaviorRestart; // 0x88
	private Behavior.BehaviorHandler OnBehaviorEnd; // 0x90

	// Properties
	public bool StartWhenEnabled { get; set; }
	public bool AsynchronousLoad { get; set; }
	public bool PauseWhenDisabled { get; set; }
	public bool RestartWhenComplete { get; set; }
	public bool LogTaskChanges { get; set; }
	public int Group { get; set; }
	public bool ResetValuesOnRestart { get; set; }
	public ExternalBehavior ExternalBehavior { get; set; }
	public bool HasInheritedVariables { get; set; }
	public string BehaviorName { get; set; }
	public string BehaviorDescription { get; set; }
	public TaskStatus ExecutionStatus { get; set; }
	public bool[] HasEvent { get; }

	// Methods

	// RVA: 0x175E000 Offset: 0x175E101 VA: 0x175E000
	public void .ctor() { }

	// RVA: 0x175E1D0 Offset: 0x175E2D1 VA: 0x175E1D0
	public void add_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E260 Offset: 0x175E361 VA: 0x175E260
	public void remove_OnBehaviorStart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E2F0 Offset: 0x175E3F1 VA: 0x175E2F0
	public void add_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E380 Offset: 0x175E481 VA: 0x175E380
	public void remove_OnBehaviorRestart(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E410 Offset: 0x175E511 VA: 0x175E410
	public void add_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E4A0 Offset: 0x175E5A1 VA: 0x175E4A0
	public void remove_OnBehaviorEnd(Behavior.BehaviorHandler value) { }

	// RVA: 0x175E530 Offset: 0x175E631 VA: 0x175E530
	public bool get_StartWhenEnabled() { }

	// RVA: 0x175E540 Offset: 0x175E641 VA: 0x175E540
	public void set_StartWhenEnabled(bool value) { }

	// RVA: 0x175E550 Offset: 0x175E651 VA: 0x175E550
	public bool get_AsynchronousLoad() { }

	// RVA: 0x175E560 Offset: 0x175E661 VA: 0x175E560
	public void set_AsynchronousLoad(bool value) { }

	// RVA: 0x175E570 Offset: 0x175E671 VA: 0x175E570
	public bool get_PauseWhenDisabled() { }

	// RVA: 0x175E580 Offset: 0x175E681 VA: 0x175E580
	public void set_PauseWhenDisabled(bool value) { }

	// RVA: 0x175E590 Offset: 0x175E691 VA: 0x175E590
	public bool get_RestartWhenComplete() { }

	// RVA: 0x175E5A0 Offset: 0x175E6A1 VA: 0x175E5A0
	public void set_RestartWhenComplete(bool value) { }

	// RVA: 0x175E5B0 Offset: 0x175E6B1 VA: 0x175E5B0
	public bool get_LogTaskChanges() { }

	// RVA: 0x175E5C0 Offset: 0x175E6C1 VA: 0x175E5C0
	public void set_LogTaskChanges(bool value) { }

	// RVA: 0x175E5D0 Offset: 0x175E6D1 VA: 0x175E5D0
	public int get_Group() { }

	// RVA: 0x175E5E0 Offset: 0x175E6E1 VA: 0x175E5E0
	public void set_Group(int value) { }

	// RVA: 0x175E5F0 Offset: 0x175E6F1 VA: 0x175E5F0
	public bool get_ResetValuesOnRestart() { }

	// RVA: 0x175E600 Offset: 0x175E701 VA: 0x175E600
	public void set_ResetValuesOnRestart(bool value) { }

	// RVA: 0x175E610 Offset: 0x175E711 VA: 0x175E610
	public ExternalBehavior get_ExternalBehavior() { }

	// RVA: 0x175E620 Offset: 0x175E721 VA: 0x175E620
	public void set_ExternalBehavior(ExternalBehavior value) { }

	// RVA: 0x175ECC0 Offset: 0x175EDC1 VA: 0x175ECC0
	public bool get_HasInheritedVariables() { }

	// RVA: 0x175ECD0 Offset: 0x175EDD1 VA: 0x175ECD0
	public void set_HasInheritedVariables(bool value) { }

	// RVA: 0x175ECE0 Offset: 0x175EDE1 VA: 0x175ECE0
	public string get_BehaviorName() { }

	// RVA: 0x175ED00 Offset: 0x175EE01 VA: 0x175ED00
	public void set_BehaviorName(string value) { }

	// RVA: 0x175ED20 Offset: 0x175EE21 VA: 0x175ED20
	public string get_BehaviorDescription() { }

	// RVA: 0x175ED40 Offset: 0x175EE41 VA: 0x175ED40
	public void set_BehaviorDescription(string value) { }

	// RVA: 0x175ED60 Offset: 0x175EE61 VA: 0x175ED60 Slot: 7
	public BehaviorSource GetBehaviorSource() { }

	// RVA: 0x175ED70 Offset: 0x175EE71 VA: 0x175ED70 Slot: 8
	public void SetBehaviorSource(BehaviorSource behaviorSource) { }

	// RVA: 0x175ED80 Offset: 0x175EE81 VA: 0x175ED80 Slot: 6
	public Object GetObject() { }

	// RVA: 0x175ED90 Offset: 0x175EE91 VA: 0x175ED90 Slot: 4
	public string GetOwnerName() { }

	// RVA: 0x175EDC0 Offset: 0x175EEC1 VA: 0x175EDC0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x175EDD0 Offset: 0x175EED1 VA: 0x175EDD0
	public void set_ExecutionStatus(TaskStatus value) { }

	// RVA: 0x175EDE0 Offset: 0x175EEE1 VA: 0x175EDE0
	public bool[] get_HasEvent() { }

	// RVA: 0x175EDF0 Offset: 0x175EEF1 VA: 0x175EDF0
	public void Start() { }

	// RVA: 0x175EE00 Offset: 0x175EF01 VA: 0x175EE00
	private bool TaskContainsMethod(string methodName, Task task) { }

	// RVA: 0x175EBD0 Offset: 0x175ECD1 VA: 0x175EBD0
	public void EnableBehavior() { }

	// RVA: 0x175F3C0 Offset: 0x175F4C1 VA: 0x175F3C0
	public void DisableBehavior() { }

	// RVA: 0x175F4C0 Offset: 0x175F5C1 VA: 0x175F4C0
	public void DisableBehavior(bool pause) { }

	// RVA: 0x175F5B0 Offset: 0x175F6B1 VA: 0x175F5B0
	public void OnEnable() { }

	// RVA: 0x175F6C0 Offset: 0x175F7C1 VA: 0x175F6C0
	public void OnDisable() { }

	// RVA: 0x175F6D0 Offset: 0x175F7D1 VA: 0x175F6D0
	public void OnDestroy() { }

	// RVA: 0x175F7D0 Offset: 0x175F8D1 VA: 0x175F7D0 Slot: 9
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175F950 Offset: 0x175FA51 VA: 0x175F950 Slot: 10
	public void SetVariable(string name, SharedVariable item) { }

	// RVA: 0x175F9A0 Offset: 0x175FAA1 VA: 0x175F9A0 Slot: 11
	public void SetVariableValue(string name, object value) { }

	// RVA: 0x175FCD0 Offset: 0x175FDD1 VA: 0x175FCD0
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175F810 Offset: 0x175F911 VA: 0x175F810
	public void CheckForSerialization() { }

	// RVA: 0x175FD20 Offset: 0x175FE21 VA: 0x175FD20
	public void CheckForSerialization(bool forceSerialization) { }

	// RVA: 0x1760060 Offset: 0x1760161 VA: 0x1760060
	public void OnCollisionEnter(Collision collision) { }

	// RVA: 0x1760450 Offset: 0x1760551 VA: 0x1760450
	public void OnCollisionExit(Collision collision) { }

	// RVA: 0x1760840 Offset: 0x1760941 VA: 0x1760840
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x1760C30 Offset: 0x1760D31 VA: 0x1760C30
	public void OnTriggerExit(Collider other) { }

	// RVA: 0x1761020 Offset: 0x1761121 VA: 0x1761020
	public void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x1761410 Offset: 0x1761511 VA: 0x1761410
	public void OnCollisionExit2D(Collision2D collision) { }

	// RVA: 0x1761800 Offset: 0x1761901 VA: 0x1761800
	public void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1761BF0 Offset: 0x1761CF1 VA: 0x1761BF0
	public void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x1761FE0 Offset: 0x17620E1 VA: 0x1761FE0
	public void OnControllerColliderHit(ControllerColliderHit hit) { }

	// RVA: 0x17623D0 Offset: 0x17624D1 VA: 0x17623D0
	public void OnAnimatorIK() { }

	// RVA: 0x17627A0 Offset: 0x17628A1 VA: 0x17627A0
	public void OnDrawGizmos() { }

	// RVA: 0x17628C0 Offset: 0x17629C1 VA: 0x17628C0
	public void OnDrawGizmosSelected() { }

	// RVA: 0x17627B0 Offset: 0x17628B1 VA: 0x17627B0
	private void DrawTaskGizmos(bool selected) { }

	// RVA: 0x1762940 Offset: 0x1762A41 VA: 0x1762940
	private void DrawTaskGizmos(Task task) { }

	// RVA: -1 Offset: -1
	public T FindTask<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDE80 Offset: 0x23BDF81 VA: 0x23BDE80
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	private T FindTask<T>(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDED0 Offset: 0x23BDFD1 VA: 0x23BDED0
	|-Behavior.FindTask<object>
	*/

	// RVA: -1 Offset: -1
	public List<T> FindTasks<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AA5C0 Offset: 0x21AA6C1 VA: 0x21AA5C0
	|-Behavior.FindTasks<object>
	*/

	// RVA: -1 Offset: -1
	private void FindTasks<T>(Task task, ref List<T> taskList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CDE70 Offset: 0x21CDF71 VA: 0x21CDE70
	|-Behavior.FindTasks<object>
	*/

	// RVA: 0x1762A50 Offset: 0x1762B51 VA: 0x1762A50
	public Task FindTaskWithName(string taskName) { }

	// RVA: 0x1762A90 Offset: 0x1762B91 VA: 0x1762A90
	private Task FindTaskWithName(string taskName, Task task) { }

	// RVA: 0x1762BC0 Offset: 0x1762CC1 VA: 0x1762BC0
	public List<Task> FindTasksWithName(string taskName) { }

	// RVA: 0x1762C70 Offset: 0x1762D71 VA: 0x1762C70
	private void FindTasksWithName(string taskName, Task task, ref List<Task> taskList) { }

	// RVA: 0x1762DB0 Offset: 0x1762EB1 VA: 0x1762DB0
	public List<Task> GetActiveTasks() { }

	// RVA: 0x1763100 Offset: 0x1763201 VA: 0x1763100
	public Coroutine StartTaskCoroutine(Task task, string methodName) { }

	// RVA: 0x17633A0 Offset: 0x17634A1 VA: 0x17633A0
	public Coroutine StartTaskCoroutine(Task task, string methodName, object value) { }

	// RVA: 0x1763690 Offset: 0x1763791 VA: 0x1763690
	public void StopTaskCoroutine(string methodName) { }

	// RVA: 0x1763770 Offset: 0x1763871 VA: 0x1763770
	public void StopAllTaskCoroutines() { }

	// RVA: 0x1763920 Offset: 0x1763A21 VA: 0x1763920
	public void TaskCoroutineEnded(TaskCoroutine taskCoroutine, string coroutineName) { }

	// RVA: 0x1763A30 Offset: 0x1763B31 VA: 0x1763A30
	public void OnBehaviorStarted() { }

	// RVA: 0x1763EF0 Offset: 0x1763FF1 VA: 0x1763EF0
	public void OnBehaviorRestarted() { }

	// RVA: 0x1763F10 Offset: 0x1764011 VA: 0x1763F10
	public void OnBehaviorEnded() { }

	// RVA: 0x1763F30 Offset: 0x1764031 VA: 0x1763F30
	private void RegisterEvent(string name, Delegate handler) { }

	// RVA: 0x17640F0 Offset: 0x17641F1 VA: 0x17640F0
	public void RegisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void RegisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE060 Offset: 0x21CE161 VA: 0x21CE060
	|-Behavior.RegisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE040 Offset: 0x21CE141 VA: 0x21CE040
	|-Behavior.RegisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void RegisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE020 Offset: 0x21CE121 VA: 0x21CE020
	|-Behavior.RegisterEvent<object, object, object>
	*/

	// RVA: 0x1764100 Offset: 0x1764201 VA: 0x1764100
	private Delegate GetDelegate(string name, Type type) { }

	// RVA: 0x17641C0 Offset: 0x17642C1 VA: 0x17641C0
	public void SendEvent(string name) { }

	// RVA: -1 Offset: -1
	public void SendEvent<T>(string name, T arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE2B0 Offset: 0x21CE3B1 VA: 0x21CE2B0
	|-Behavior.SendEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U>(string name, T arg1, U arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE1A0 Offset: 0x21CE2A1 VA: 0x21CE1A0
	|-Behavior.SendEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void SendEvent<T, U, V>(string name, T arg1, U arg2, V arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE080 Offset: 0x21CE181 VA: 0x21CE080
	|-Behavior.SendEvent<object, object, object>
	*/

	// RVA: 0x1764300 Offset: 0x1764401 VA: 0x1764300
	private void UnregisterEvent(string name, Delegate handler) { }

	// RVA: 0x17643F0 Offset: 0x17644F1 VA: 0x17643F0
	public void UnregisterEvent(string name, Action handler) { }

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T>(string name, Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3F0 Offset: 0x21CE4F1 VA: 0x21CE3F0
	|-Behavior.UnregisterEvent<object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U>(string name, Action<T, U> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3D0 Offset: 0x21CE4D1 VA: 0x21CE3D0
	|-Behavior.UnregisterEvent<object, object>
	*/

	// RVA: -1 Offset: -1
	public void UnregisterEvent<T, U, V>(string name, Action<T, U, V> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE3B0 Offset: 0x21CE4B1 VA: 0x21CE3B0
	|-Behavior.UnregisterEvent<object, object, object>
	*/

	// RVA: 0x1764400 Offset: 0x1764501 VA: 0x1764400
	public void SaveResetValues() { }

	// RVA: 0x17644E0 Offset: 0x17645E1 VA: 0x17644E0
	private void SaveValues() { }

	// RVA: 0x1764770 Offset: 0x1764871 VA: 0x1764770
	private void SaveValue(Task task) { }

	// RVA: 0x1764600 Offset: 0x1764701 VA: 0x1764600
	private void ResetValues() { }

	// RVA: 0x1764AD0 Offset: 0x1764BD1 VA: 0x1764AD0
	private void ResetValue(Task task) { }

	// RVA: 0x1764D30 Offset: 0x1764E31 VA: 0x1764D30 Slot: 3
	public override string ToString() { }

	// RVA: 0x175EF60 Offset: 0x175F061 VA: 0x175EF60
	public static BehaviorManager CreateBehaviorManager() { }

	// RVA: 0x1764D50 Offset: 0x1764E51 VA: 0x1764D50 Slot: 12
	virtual int BehaviorDesigner.Runtime.IBehavior.GetInstanceID() { }
}


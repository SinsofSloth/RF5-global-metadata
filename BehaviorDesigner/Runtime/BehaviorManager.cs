[AddComponentMenu] // RVA: 0x12CE40 Offset: 0x12CF41 VA: 0x12CE40
public class BehaviorManager : MonoBehaviour // TypeDefIndex: 4653
{
	// Fields
	public static BehaviorManager instance; // 0x0
	[SerializeField] // RVA: 0x12D4E0 Offset: 0x12D5E1 VA: 0x12D4E0
	private UpdateIntervalType updateInterval; // 0x18
	[SerializeField] // RVA: 0x12D4F0 Offset: 0x12D5F1 VA: 0x12D4F0
	private float updateIntervalSeconds; // 0x1C
	[SerializeField] // RVA: 0x12D500 Offset: 0x12D601 VA: 0x12D500
	private BehaviorManager.ExecutionsPerTickType executionsPerTick; // 0x20
	[SerializeField] // RVA: 0x12D510 Offset: 0x12D611 VA: 0x12D510
	private int maxTaskExecutionsPerTick; // 0x24
	private WaitForSeconds updateWait; // 0x28
	public BehaviorManager.BehaviorManagerHandler onEnableBehavior; // 0x30
	public BehaviorManager.BehaviorManagerHandler onTaskBreakpoint; // 0x38
	private static bool isPlaying; // 0x8
	private Object lockObject; // 0x40
	private List<BehaviorManager.BehaviorTree> behaviorTrees; // 0x48
	private Dictionary<Behavior, BehaviorManager.BehaviorTree> pausedBehaviorTrees; // 0x50
	private Dictionary<Behavior, BehaviorManager.BehaviorTree> behaviorTreeMap; // 0x58
	private List<int> conditionalParentIndexes; // 0x60
	private List<BehaviorManager.BehaviorThreadLoader> activeThreads; // 0x68
	private IEnumerator threadLoaderCoroutine; // 0x70
	private Dictionary<object, BehaviorManager.ThirdPartyTask> objectTaskMap; // 0x78
	private Dictionary<BehaviorManager.ThirdPartyTask, object> taskObjectMap; // 0x80
	private BehaviorManager.ThirdPartyTask thirdPartyTaskCompare; // 0x88
	private static MethodInfo playMakerStopMethod; // 0x10
	private static MethodInfo uScriptStopMethod; // 0x18
	private static MethodInfo dialogueSystemStopMethod; // 0x20
	private static MethodInfo uSequencerStopMethod; // 0x28
	private static object[] invokeParameters; // 0x30
	private Behavior breakpointTree; // 0x90
	private bool dirty; // 0x98

	// Properties
	public UpdateIntervalType UpdateInterval { get; set; }
	public float UpdateIntervalSeconds { get; set; }
	public BehaviorManager.ExecutionsPerTickType ExecutionsPerTick { get; set; }
	public int MaxTaskExecutionsPerTick { get; set; }
	public BehaviorManager.BehaviorManagerHandler OnEnableBehavior { set; }
	public BehaviorManager.BehaviorManagerHandler OnTaskBreakpoint { get; set; }
	public static bool IsPlaying { get; }
	public List<BehaviorManager.BehaviorTree> BehaviorTrees { get; }
	private static MethodInfo PlayMakerStopMethod { get; }
	private static MethodInfo UScriptStopMethod { get; }
	private static MethodInfo DialogueSystemStopMethod { get; }
	private static MethodInfo USequencerStopMethod { get; }
	public Behavior BreakpointTree { get; set; }
	public bool Dirty { get; set; }

	// Methods

	// RVA: 0x17652B0 Offset: 0x17653B1 VA: 0x17652B0
	public void .ctor() { }

	// RVA: 0x17654D0 Offset: 0x17655D1 VA: 0x17654D0
	private static void .cctor() { }

	// RVA: 0x17654E0 Offset: 0x17655E1 VA: 0x17654E0
	public UpdateIntervalType get_UpdateInterval() { }

	// RVA: 0x17654F0 Offset: 0x17655F1 VA: 0x17654F0
	public void set_UpdateInterval(UpdateIntervalType value) { }

	// RVA: 0x17655E0 Offset: 0x17656E1 VA: 0x17655E0
	public float get_UpdateIntervalSeconds() { }

	// RVA: 0x17655F0 Offset: 0x17656F1 VA: 0x17655F0
	public void set_UpdateIntervalSeconds(float value) { }

	// RVA: 0x1765600 Offset: 0x1765701 VA: 0x1765600
	public BehaviorManager.ExecutionsPerTickType get_ExecutionsPerTick() { }

	// RVA: 0x1765610 Offset: 0x1765711 VA: 0x1765610
	public void set_ExecutionsPerTick(BehaviorManager.ExecutionsPerTickType value) { }

	// RVA: 0x1765620 Offset: 0x1765721 VA: 0x1765620
	public int get_MaxTaskExecutionsPerTick() { }

	// RVA: 0x1765630 Offset: 0x1765731 VA: 0x1765630
	public void set_MaxTaskExecutionsPerTick(int value) { }

	// RVA: 0x1765640 Offset: 0x1765741 VA: 0x1765640
	public void set_OnEnableBehavior(BehaviorManager.BehaviorManagerHandler value) { }

	// RVA: 0x1765650 Offset: 0x1765751 VA: 0x1765650
	public BehaviorManager.BehaviorManagerHandler get_OnTaskBreakpoint() { }

	// RVA: 0x1765660 Offset: 0x1765761 VA: 0x1765660
	public void set_OnTaskBreakpoint(BehaviorManager.BehaviorManagerHandler value) { }

	// RVA: 0x17656F0 Offset: 0x17657F1 VA: 0x17656F0
	public static bool get_IsPlaying() { }

	// RVA: 0x1765760 Offset: 0x1765861 VA: 0x1765760
	public List<BehaviorManager.BehaviorTree> get_BehaviorTrees() { }

	// RVA: 0x1765770 Offset: 0x1765871 VA: 0x1765770
	private static MethodInfo get_PlayMakerStopMethod() { }

	// RVA: 0x17658A0 Offset: 0x17659A1 VA: 0x17658A0
	private static MethodInfo get_UScriptStopMethod() { }

	// RVA: 0x17659D0 Offset: 0x1765AD1 VA: 0x17659D0
	private static MethodInfo get_DialogueSystemStopMethod() { }

	// RVA: 0x1765B00 Offset: 0x1765C01 VA: 0x1765B00
	private static MethodInfo get_USequencerStopMethod() { }

	// RVA: 0x1765C30 Offset: 0x1765D31 VA: 0x1765C30
	public Behavior get_BreakpointTree() { }

	// RVA: 0x1765C40 Offset: 0x1765D41 VA: 0x1765C40
	public void set_BreakpointTree(Behavior value) { }

	// RVA: 0x1765C50 Offset: 0x1765D51 VA: 0x1765C50
	public bool get_Dirty() { }

	// RVA: 0x1765C60 Offset: 0x1765D61 VA: 0x1765C60
	public void set_Dirty(bool value) { }

	// RVA: 0x1765C70 Offset: 0x1765D71 VA: 0x1765C70
	public void Awake() { }

	// RVA: 0x1765500 Offset: 0x1765601 VA: 0x1765500
	private void UpdateIntervalChanged() { }

	// RVA: 0x1765D00 Offset: 0x1765E01 VA: 0x1765D00
	public void OnDestroy() { }

	// RVA: 0x1765E20 Offset: 0x1765F21 VA: 0x1765E20
	public void OnApplicationQuit() { }

	// RVA: 0x175F070 Offset: 0x175F171 VA: 0x175F070
	public void EnableBehavior(Behavior behavior) { }

	[DebuggerHiddenAttribute] // RVA: 0x12D9B0 Offset: 0x12DAB1 VA: 0x12D9B0
	// RVA: 0x1766070 Offset: 0x1766171 VA: 0x1766070
	private IEnumerator CheckThreadLoaders() { }

	// RVA: 0x17660F0 Offset: 0x17661F1 VA: 0x17660F0
	private BehaviorManager.BehaviorTree LoadBehavior(Behavior behavior, GameObject behaviorGameObject, string gameObjectName, Transform behaviorTransform) { }

	// RVA: 0x17667D0 Offset: 0x17668D1 VA: 0x17667D0
	private void LoadBehaviorComplete(Behavior behavior, BehaviorManager.BehaviorTree behaviorTree) { }

	// RVA: 0x1767130 Offset: 0x1767231 VA: 0x1767130
	private int AddToTaskList(BehaviorManager.BehaviorTree behaviorTree, Task task, GameObject behaviorGameObject, Transform behaviorTransform, ref bool hasExternalBehavior, BehaviorManager.TaskAddData data) { }

	// RVA: 0x1769300 Offset: 0x1769401 VA: 0x1769300
	private void OverrideFields(BehaviorManager.BehaviorTree behaviorTree, BehaviorManager.TaskAddData data, object obj) { }

	// RVA: 0x1769AA0 Offset: 0x1769BA1 VA: 0x1769AA0
	private SharedVariable OverrideSharedVariable(BehaviorManager.BehaviorTree behaviorTree, BehaviorManager.TaskAddData data, Type fieldType, SharedVariable sharedVariable) { }

	// RVA: 0x175E8C0 Offset: 0x175E9C1 VA: 0x175E8C0
	public void DisableBehavior(Behavior behavior) { }

	// RVA: 0x175F4B0 Offset: 0x175F5B1 VA: 0x175F4B0
	public void DisableBehavior(Behavior behavior, bool paused) { }

	// RVA: 0x176A290 Offset: 0x176A391 VA: 0x176A290
	public void DisableBehavior(Behavior behavior, bool paused, TaskStatus executionStatus) { }

	// RVA: 0x175F7C0 Offset: 0x175F8C1 VA: 0x175F7C0
	public void DestroyBehavior(Behavior behavior) { }

	// RVA: 0x176A5D0 Offset: 0x176A6D1 VA: 0x176A5D0
	public void DestroyBehavior(Behavior behavior, TaskStatus executionStatus) { }

	// RVA: 0x176BB80 Offset: 0x176BC81 VA: 0x176BB80
	public void RestartBehavior(Behavior behavior) { }

	// RVA: 0x1765ED0 Offset: 0x1765FD1 VA: 0x1765ED0
	public bool IsBehaviorEnabled(Behavior behavior) { }

	// RVA: 0x176BED0 Offset: 0x176BFD1 VA: 0x176BED0
	public void Update() { }

	// RVA: 0x176C010 Offset: 0x176C111 VA: 0x176C010
	public void LateUpdate() { }

	// RVA: 0x176C200 Offset: 0x176C301 VA: 0x176C200
	public void FixedUpdate() { }

	[DebuggerHiddenAttribute] // RVA: 0x12D9C0 Offset: 0x12DAC1 VA: 0x12D9C0
	// RVA: 0x176C3F0 Offset: 0x176C4F1 VA: 0x176C3F0
	private IEnumerator CoroutineUpdate() { }

	// RVA: 0x176BF70 Offset: 0x176C071 VA: 0x176BF70
	public void Tick() { }

	// RVA: 0x176CA10 Offset: 0x176CB11 VA: 0x176CA10
	public void Tick(Behavior behavior) { }

	// RVA: 0x176C480 Offset: 0x176C581 VA: 0x176C480
	private void Tick(BehaviorManager.BehaviorTree behaviorTree) { }

	// RVA: 0x176CD80 Offset: 0x176CE81 VA: 0x176CD80
	private void ReevaluateConditionalTasks(BehaviorManager.BehaviorTree behaviorTree) { }

	// RVA: 0x176CAE0 Offset: 0x176CBE1 VA: 0x176CAE0
	private void ReevaluateParentTasks(BehaviorManager.BehaviorTree behaviorTree) { }

	// RVA: 0x176DFB0 Offset: 0x176E0B1 VA: 0x176DFB0
	private TaskStatus RunTask(BehaviorManager.BehaviorTree behaviorTree, int taskIndex, int stackIndex, TaskStatus previousStatus) { }

	// RVA: 0x176E950 Offset: 0x176EA51 VA: 0x176E950
	private TaskStatus RunParentTask(BehaviorManager.BehaviorTree behaviorTree, int taskIndex, ref int stackIndex, TaskStatus status) { }

	// RVA: 0x1768E90 Offset: 0x1768F91 VA: 0x1768E90
	private void PushTask(BehaviorManager.BehaviorTree behaviorTree, int taskIndex, int stackIndex) { }

	// RVA: 0x176DFA0 Offset: 0x176E0A1 VA: 0x176DFA0
	private void PopTask(BehaviorManager.BehaviorTree behaviorTree, int taskIndex, int stackIndex, ref TaskStatus status, bool popChildren) { }

	// RVA: 0x176A960 Offset: 0x176AA61 VA: 0x176A960
	private void PopTask(BehaviorManager.BehaviorTree behaviorTree, int taskIndex, int stackIndex, ref TaskStatus status, bool popChildren, bool notifyOnEmptyStack) { }

	// RVA: 0x176B9C0 Offset: 0x176BAC1 VA: 0x176B9C0
	private void RemoveChildConditionalReevaluate(BehaviorManager.BehaviorTree behaviorTree, int compositeIndex) { }

	// RVA: 0x176BD40 Offset: 0x176BE41 VA: 0x176BD40
	private void Restart(BehaviorManager.BehaviorTree behaviorTree) { }

	// RVA: 0x176E890 Offset: 0x176E991 VA: 0x176E890
	private bool IsParentTask(BehaviorManager.BehaviorTree behaviorTree, int possibleParent, int possibleChild) { }

	// RVA: 0x176E940 Offset: 0x176EA41 VA: 0x176E940
	public void Interrupt(Behavior behavior, Task task, TaskStatus interruptTaskStatus = 1) { }

	// RVA: 0x176F1A0 Offset: 0x176F2A1 VA: 0x176F1A0
	public void Interrupt(Behavior behavior, Task task, Task interruptionTask, TaskStatus interruptTaskStatus = 1) { }

	// RVA: 0x176EE70 Offset: 0x176EF71 VA: 0x176EE70
	public void StopThirdPartyTask(BehaviorManager.BehaviorTree behaviorTree, int taskIndex) { }

	// RVA: 0x176F670 Offset: 0x176F771 VA: 0x176F670
	public void RemoveActiveThirdPartyTask(Task task) { }

	// RVA: 0x176ED50 Offset: 0x176EE51 VA: 0x176ED50
	private void RemoveStack(BehaviorManager.BehaviorTree behaviorTree, int stackIndex) { }

	// RVA: 0x176E610 Offset: 0x176E711 VA: 0x176E610
	private int FindLCA(BehaviorManager.BehaviorTree behaviorTree, int taskIndex1, int taskIndex2) { }

	// RVA: 0x176E7C0 Offset: 0x176E8C1 VA: 0x176E7C0
	private bool IsChild(BehaviorManager.BehaviorTree behaviorTree, int taskIndex1, int taskIndex2) { }

	// RVA: 0x1762EA0 Offset: 0x1762FA1 VA: 0x1762EA0
	public List<Task> GetActiveTasks(Behavior behavior) { }

	// RVA: 0x1760180 Offset: 0x1760281 VA: 0x1760180
	public void BehaviorOnCollisionEnter(Collision collision, Behavior behavior) { }

	// RVA: 0x1760570 Offset: 0x1760671 VA: 0x1760570
	public void BehaviorOnCollisionExit(Collision collision, Behavior behavior) { }

	// RVA: 0x1760960 Offset: 0x1760A61 VA: 0x1760960
	public void BehaviorOnTriggerEnter(Collider other, Behavior behavior) { }

	// RVA: 0x1760D50 Offset: 0x1760E51 VA: 0x1760D50
	public void BehaviorOnTriggerExit(Collider other, Behavior behavior) { }

	// RVA: 0x1761140 Offset: 0x1761241 VA: 0x1761140
	public void BehaviorOnCollisionEnter2D(Collision2D collision, Behavior behavior) { }

	// RVA: 0x1761530 Offset: 0x1761631 VA: 0x1761530
	public void BehaviorOnCollisionExit2D(Collision2D collision, Behavior behavior) { }

	// RVA: 0x1761920 Offset: 0x1761A21 VA: 0x1761920
	public void BehaviorOnTriggerEnter2D(Collider2D other, Behavior behavior) { }

	// RVA: 0x1761D10 Offset: 0x1761E11 VA: 0x1761D10
	public void BehaviorOnTriggerExit2D(Collider2D other, Behavior behavior) { }

	// RVA: 0x1762100 Offset: 0x1762201 VA: 0x1762100
	public void BehaviorOnControllerColliderHit(ControllerColliderHit hit, Behavior behavior) { }

	// RVA: 0x17624E0 Offset: 0x17625E1 VA: 0x17624E0
	public void BehaviorOnAnimatorIK(Behavior behavior) { }

	// RVA: 0x176F770 Offset: 0x176F871 VA: 0x176F770
	public bool MapObjectToTask(object objectKey, Task task, BehaviorManager.ThirdPartyObjectType objectType) { }

	// RVA: 0x176F930 Offset: 0x176FA31 VA: 0x176F930
	public Task TaskForObject(object objectKey) { }

	// RVA: 0x1768B90 Offset: 0x1768C91 VA: 0x1768B90
	private Decimal RoundedTime() { }

	// RVA: 0x176F9D0 Offset: 0x176FAD1 VA: 0x176F9D0
	public List<Task> GetTaskList(Behavior behavior) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x12D9D0 Offset: 0x12DAD1 VA: 0x12D9D0
	// RVA: 0x176FA70 Offset: 0x176FB71 VA: 0x176FA70
	private static void DomainReset() { }
}


public class SystemTextGenerator : MonoBehaviour // TypeDefIndex: 8753
{
	// Fields
	private static SystemTextGenerator _SystemTextGenerator; // 0x0
	[SerializeField] // RVA: 0x173240 Offset: 0x173341 VA: 0x173240
	private SystemTextDisp SystemTextDispPrefabs; // 0x18
	private List<SystemTextDisp> SystemTextDispList; // 0x20

	// Properties
	public static SystemTextGenerator MySystemTextGenerator { get; }

	// Methods

	// RVA: 0x1C69A80 Offset: 0x1C69B81 VA: 0x1C69A80
	public static SystemTextGenerator get_MySystemTextGenerator() { }

	// RVA: 0x1C69AD0 Offset: 0x1C69BD1 VA: 0x1C69AD0
	public void AddSystemMessage(string text) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8420 Offset: 0x1A8521 VA: 0x1A8420
	// RVA: 0x1C69B70 Offset: 0x1C69C71 VA: 0x1C69B70
	private IEnumerator impl_AddSystemMessage(string text) { }

	// RVA: 0x1C696E0 Offset: 0x1C697E1 VA: 0x1C696E0
	public void OnDestroyTextDisp(SystemTextDisp systemTextDisp) { }

	// RVA: 0x1C69D90 Offset: 0x1C69E91 VA: 0x1C69D90
	private void Awake() { }

	// RVA: 0x1C69C40 Offset: 0x1C69D41 VA: 0x1C69C40
	private void AdjustPosition() { }

	// RVA: 0x1C69E20 Offset: 0x1C69F21 VA: 0x1C69E20
	private void Update() { }

	// RVA: 0x1C69F10 Offset: 0x1C6A011 VA: 0x1C69F10
	public void .ctor() { }
}


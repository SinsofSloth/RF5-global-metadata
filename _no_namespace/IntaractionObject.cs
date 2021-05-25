public class IntaractionObject : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 7436
{
	// Fields
	[SerializeField] // RVA: 0x166720 Offset: 0x166821 VA: 0x166720
	protected string FoucsNameTextID; // 0x18
	protected string FocusName; // 0x20
	public UnityEvent DoInteractionEvent; // 0x28

	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x20CC000 Offset: 0x20CC101 VA: 0x20CC000 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x20CC010 Offset: 0x20CC111 VA: 0x20CC010 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x20CC020 Offset: 0x20CC121 VA: 0x20CC020 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x20CC030 Offset: 0x20CC131 VA: 0x20CC030 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x20CC040 Offset: 0x20CC141 VA: 0x20CC040 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x20CC050 Offset: 0x20CC151 VA: 0x20CC050 Slot: 11
	public void OnFocus() { }

	// RVA: 0x20CC060 Offset: 0x20CC161 VA: 0x20CC060 Slot: 12
	public void OffFocus() { }

	// RVA: 0x20CC070 Offset: 0x20CC171 VA: 0x20CC070 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x20CC130 Offset: 0x20CC231 VA: 0x20CC130 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x20CC150 Offset: 0x20CC251 VA: 0x20CC150 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x20CC100 Offset: 0x20CC201 VA: 0x20CC100 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x20CC1A0 Offset: 0x20CC2A1 VA: 0x20CC1A0
	private void Start() { }

	// RVA: 0x20CC300 Offset: 0x20CC401 VA: 0x20CC300 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x20CC310 Offset: 0x20CC411 VA: 0x20CC310 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x20CC320 Offset: 0x20CC421 VA: 0x20CC320
	public void .ctor() { }

	// RVA: 0x20CC3D0 Offset: 0x20CC4D1 VA: 0x20CC3D0 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x20CC3E0 Offset: 0x20CC4E1 VA: 0x20CC3E0 Slot: 18
	private Transform FocusInterface.get_transform() { }
}


public class DirectSignInteraction : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 8740
{
	// Fields
	[SerializeField] // RVA: 0x173080 Offset: 0x173181 VA: 0x173080
	private int SignNo; // 0x18
	[SerializeField] // RVA: 0x173090 Offset: 0x173191 VA: 0x173090
	private float InteractionAngle; // 0x1C

	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1CEBC10 Offset: 0x1CEBD11 VA: 0x1CEBC10 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x1CEBDB0 Offset: 0x1CEBEB1 VA: 0x1CEBDB0 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1CEBDC0 Offset: 0x1CEBEC1 VA: 0x1CEBDC0 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x1CEBDD0 Offset: 0x1CEBED1 VA: 0x1CEBDD0 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1CEBDE0 Offset: 0x1CEBEE1 VA: 0x1CEBDE0 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1CEBF00 Offset: 0x1CEC001 VA: 0x1CEBF00 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x1CEBFF0 Offset: 0x1CEC0F1 VA: 0x1CEBFF0 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x1CEC040 Offset: 0x1CEC141 VA: 0x1CEC040 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x1CEC050 Offset: 0x1CEC151 VA: 0x1CEC050 Slot: 11
	public void OnFocus() { }

	// RVA: 0x1CEC060 Offset: 0x1CEC161 VA: 0x1CEC060 Slot: 12
	public void OffFocus() { }

	// RVA: 0x1CEC070 Offset: 0x1CEC171 VA: 0x1CEC070 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1CEC180 Offset: 0x1CEC281 VA: 0x1CEC180 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1CEC190 Offset: 0x1CEC291 VA: 0x1CEC190 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1CEC1A0 Offset: 0x1CEC2A1 VA: 0x1CEC1A0
	public void .ctor() { }

	// RVA: 0x1CEC1C0 Offset: 0x1CEC2C1 VA: 0x1CEC1C0 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1CEC1D0 Offset: 0x1CEC2D1 VA: 0x1CEC1D0 Slot: 18
	private Transform FocusInterface.get_transform() { }
}


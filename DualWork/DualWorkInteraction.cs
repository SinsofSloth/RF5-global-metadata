public class DualWorkInteraction : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 10384
{
	// Fields
	[SerializeField] // RVA: 0x181630 Offset: 0x181731 VA: 0x181630
	private DualWorkObject DualWorkObject; // 0x18
	private string FocusNameBySystemTextID; // 0x20

	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1CF6400 Offset: 0x1CF6501 VA: 0x1CF6400
	private void Awake() { }

	// RVA: 0x1CF6550 Offset: 0x1CF6651 VA: 0x1CF6550 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x1CF65E0 Offset: 0x1CF66E1 VA: 0x1CF65E0 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1CF65F0 Offset: 0x1CF66F1 VA: 0x1CF65F0 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x1CF6600 Offset: 0x1CF6701 VA: 0x1CF6600 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1CF6610 Offset: 0x1CF6711 VA: 0x1CF6610 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1CF6620 Offset: 0x1CF6721 VA: 0x1CF6620 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1CF6640 Offset: 0x1CF6741 VA: 0x1CF6640 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x1CF6740 Offset: 0x1CF6841 VA: 0x1CF6740 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x1CF6790 Offset: 0x1CF6891 VA: 0x1CF6790 Slot: 12
	public void OffFocus() { }

	// RVA: 0x1CF67A0 Offset: 0x1CF68A1 VA: 0x1CF67A0 Slot: 11
	public void OnFocus() { }

	// RVA: 0x1CF67B0 Offset: 0x1CF68B1 VA: 0x1CF67B0 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x1CF6820 Offset: 0x1CF6921 VA: 0x1CF6820
	public void Reset() { }

	// RVA: 0x1CF68E0 Offset: 0x1CF69E1 VA: 0x1CF68E0 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1CF68F0 Offset: 0x1CF69F1 VA: 0x1CF68F0 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1CF6900 Offset: 0x1CF6A01 VA: 0x1CF6900
	public void .ctor() { }

	// RVA: 0x1CF6910 Offset: 0x1CF6A11 VA: 0x1CF6910 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1CF6920 Offset: 0x1CF6A21 VA: 0x1CF6920 Slot: 18
	private Transform FocusInterface.get_transform() { }
}


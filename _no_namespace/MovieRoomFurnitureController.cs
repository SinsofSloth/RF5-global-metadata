public class MovieRoomFurnitureController : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 7542
{
	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1CE0DE0 Offset: 0x1CE0EE1 VA: 0x1CE0DE0 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x1CE0ED0 Offset: 0x1CE0FD1 VA: 0x1CE0ED0 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x1CE0EE0 Offset: 0x1CE0FE1 VA: 0x1CE0EE0 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1CE0EF0 Offset: 0x1CE0FF1 VA: 0x1CE0EF0 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x1CE0F00 Offset: 0x1CE1001 VA: 0x1CE0F00 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1CE0F10 Offset: 0x1CE1011 VA: 0x1CE0F10 Slot: 11
	public void OnFocus() { }

	// RVA: 0x1CE0F20 Offset: 0x1CE1021 VA: 0x1CE0F20 Slot: 12
	public void OffFocus() { }

	// RVA: 0x1CE0F30 Offset: 0x1CE1031 VA: 0x1CE0F30 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x1CE0FF0 Offset: 0x1CE10F1 VA: 0x1CE0FF0 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1CE1060 Offset: 0x1CE1161 VA: 0x1CE1060 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x1CE0FC0 Offset: 0x1CE10C1 VA: 0x1CE0FC0 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1CE10B0 Offset: 0x1CE11B1 VA: 0x1CE10B0 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1CE10C0 Offset: 0x1CE11C1 VA: 0x1CE10C0 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1CE10D0 Offset: 0x1CE11D1 VA: 0x1CE10D0
	public void .ctor() { }

	// RVA: 0x1CE10E0 Offset: 0x1CE11E1 VA: 0x1CE10E0 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1CE10F0 Offset: 0x1CE11F1 VA: 0x1CE10F0 Slot: 18
	private Transform FocusInterface.get_transform() { }
}


public class CalendarFurnitureController : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 7538
{
	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1D320A0 Offset: 0x1D321A1 VA: 0x1D320A0 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x1D32190 Offset: 0x1D32291 VA: 0x1D32190 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x1D321A0 Offset: 0x1D322A1 VA: 0x1D321A0 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1D321B0 Offset: 0x1D322B1 VA: 0x1D321B0 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x1D321C0 Offset: 0x1D322C1 VA: 0x1D321C0 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1D321D0 Offset: 0x1D322D1 VA: 0x1D321D0 Slot: 11
	public void OnFocus() { }

	// RVA: 0x1D321E0 Offset: 0x1D322E1 VA: 0x1D321E0 Slot: 12
	public void OffFocus() { }

	// RVA: 0x1D321F0 Offset: 0x1D322F1 VA: 0x1D321F0 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x1D322B0 Offset: 0x1D323B1 VA: 0x1D322B0 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1D32350 Offset: 0x1D32451 VA: 0x1D32350 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x1D32280 Offset: 0x1D32381 VA: 0x1D32280 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1D323A0 Offset: 0x1D324A1 VA: 0x1D323A0 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1D323B0 Offset: 0x1D324B1 VA: 0x1D323B0 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1D323C0 Offset: 0x1D324C1 VA: 0x1D323C0
	public void .ctor() { }

	// RVA: 0x1D323D0 Offset: 0x1D324D1 VA: 0x1D323D0 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1D323E0 Offset: 0x1D324E1 VA: 0x1D323E0 Slot: 18
	private Transform FocusInterface.get_transform() { }
}


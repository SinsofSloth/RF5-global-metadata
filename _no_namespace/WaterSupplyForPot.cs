public class WaterSupplyForPot : MonoBehaviour, PotInteractionInterface, ToolInteractionInterface, FocusInterface // TypeDefIndex: 7612
{
	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1D075B0 Offset: 0x1D076B1 VA: 0x1D075B0 Slot: 4
	public bool UsePot(HumanController humanController, EquipItemData equipItemData) { }

	// RVA: 0x1D075C0 Offset: 0x1D076C1 VA: 0x1D075C0 Slot: 5
	public bool CanUsePot(HumanController humanController, EquipItemData equipItemData, bool isRange) { }

	// RVA: 0x1D075D0 Offset: 0x1D076D1 VA: 0x1D075D0 Slot: 6
	public string GetFocusName() { }

	// RVA: 0x1D07620 Offset: 0x1D07721 VA: 0x1D07620 Slot: 7
	public bool get_Focusable() { }

	// RVA: 0x1D07630 Offset: 0x1D07731 VA: 0x1D07630 Slot: 10
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1D07640 Offset: 0x1D07741 VA: 0x1D07640 Slot: 11
	public int get_FocusPriority() { }

	// RVA: 0x1D07650 Offset: 0x1D07751 VA: 0x1D07650 Slot: 12
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1D07660 Offset: 0x1D07761 VA: 0x1D07660 Slot: 8
	public void OnFocus() { }

	// RVA: 0x1D07670 Offset: 0x1D07771 VA: 0x1D07670 Slot: 9
	public void OffFocus() { }

	// RVA: 0x1D07680 Offset: 0x1D07781 VA: 0x1D07680 Slot: 13
	public ushort GetInteractionType() { }

	// RVA: 0x1D07690 Offset: 0x1D07791 VA: 0x1D07690
	public void .ctor() { }

	// RVA: 0x1D076A0 Offset: 0x1D077A1 VA: 0x1D076A0 Slot: 14
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1D076B0 Offset: 0x1D077B1 VA: 0x1D076B0 Slot: 15
	private Transform FocusInterface.get_transform() { }
}


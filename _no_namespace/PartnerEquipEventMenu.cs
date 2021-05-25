public class PartnerEquipEventMenu : CursorEvent // TypeDefIndex: 8684
{
	// Fields
	private FriendsMenuController friendsMenuController; // 0x18
	[SerializeField] // RVA: 0x1723D0 Offset: 0x1724D1 VA: 0x1723D0
	private CursorLinker ParameterMenu; // 0x20
	[SerializeField] // RVA: 0x1723E0 Offset: 0x1724E1 VA: 0x1723E0
	private UIEquipSlot.SlotOwner owner; // 0x28
	[SerializeField] // RVA: 0x1723F0 Offset: 0x1724F1 VA: 0x1723F0
	private UIEquipSlot[] EquipSlots; // 0x30

	// Properties
	public override bool UseCANCEL { get; }

	// Methods

	// RVA: 0x21C27D0 Offset: 0x21C28D1 VA: 0x21C27D0 Slot: 4
	public override bool get_UseCANCEL() { }

	// RVA: 0x21C27E0 Offset: 0x21C28E1 VA: 0x21C27E0
	public void OpenWindows(UIEquipSlot.SlotOwner _owner, CursorLinker parameterMenu, FriendsMenuController _friendsMenuController) { }

	// RVA: 0x21C2910 Offset: 0x21C2A11 VA: 0x21C2910
	public void Close() { }

	// RVA: 0x21C2980 Offset: 0x21C2A81 VA: 0x21C2980
	public void .ctor() { }
}


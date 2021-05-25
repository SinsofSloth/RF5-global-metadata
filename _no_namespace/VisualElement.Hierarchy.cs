[DefaultMemberAttribute] // RVA: 0x11DFC0 Offset: 0x11E0C1 VA: 0x11DFC0
public struct VisualElement.Hierarchy // TypeDefIndex: 4137
{
	// Fields
	private readonly VisualElement m_Owner; // 0x0

	// Properties
	public VisualElement parent { get; }
	public int childCount { get; }
	public VisualElement Item { get; }

	// Methods

	// RVA: 0x25390 Offset: 0x25491 VA: 0x25390
	public VisualElement get_parent() { }

	// RVA: 0x253B0 Offset: 0x254B1 VA: 0x253B0
	public int get_childCount() { }

	// RVA: 0x25410 Offset: 0x25511 VA: 0x25410
	public VisualElement get_Item(int key) { }

	// RVA: 0x25490 Offset: 0x25591 VA: 0x25490
	public bool Equals(VisualElement.Hierarchy other) { }

	// RVA: 0x254A0 Offset: 0x255A1 VA: 0x254A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25550 Offset: 0x25651 VA: 0x25550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BC9CA0 Offset: 0x1BC9DA1 VA: 0x1BC9CA0
	public static bool op_Equality(VisualElement.Hierarchy x, VisualElement.Hierarchy y) { }
}


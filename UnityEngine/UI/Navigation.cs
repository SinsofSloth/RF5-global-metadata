[Serializable]
public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 3989
{
	// Fields
	[SerializeField] // RVA: 0x11C260 Offset: 0x11C361 VA: 0x11C260
	private Navigation.Mode m_Mode; // 0x0
	[SerializeField] // RVA: 0x11C270 Offset: 0x11C371 VA: 0x11C270
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField] // RVA: 0x11C280 Offset: 0x11C381 VA: 0x11C280
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField] // RVA: 0x11C290 Offset: 0x11C391 VA: 0x11C290
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField] // RVA: 0x11C2A0 Offset: 0x11C3A1 VA: 0x11C2A0
	private Selectable m_SelectOnRight; // 0x20

	// Properties
	public Navigation.Mode mode { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }

	// Methods

	// RVA: 0xE460 Offset: 0xE561 VA: 0xE460
	public Navigation.Mode get_mode() { }

	// RVA: 0xE470 Offset: 0xE571 VA: 0xE470
	public void set_mode(Navigation.Mode value) { }

	// RVA: 0xE480 Offset: 0xE581 VA: 0xE480
	public Selectable get_selectOnUp() { }

	// RVA: 0xE490 Offset: 0xE591 VA: 0xE490
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0xE4A0 Offset: 0xE5A1 VA: 0xE4A0
	public Selectable get_selectOnDown() { }

	// RVA: 0xE4B0 Offset: 0xE5B1 VA: 0xE4B0
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0xE4C0 Offset: 0xE5C1 VA: 0xE4C0
	public Selectable get_selectOnLeft() { }

	// RVA: 0xE4D0 Offset: 0xE5D1 VA: 0xE4D0
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0xE4E0 Offset: 0xE5E1 VA: 0xE4E0
	public Selectable get_selectOnRight() { }

	// RVA: 0xE4F0 Offset: 0xE5F1 VA: 0xE4F0
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x18C2C70 Offset: 0x18C2D71 VA: 0x18C2C70
	public static Navigation get_defaultNavigation() { }

	// RVA: 0xE500 Offset: 0xE601 VA: 0xE500 Slot: 4
	public bool Equals(Navigation other) { }
}


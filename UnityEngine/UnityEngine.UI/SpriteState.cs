[Serializable]
public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 4010
{
	// Fields
	[SerializeField] // RVA: 0x11C8B0 Offset: 0x11C9B1 VA: 0x11C8B0
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField] // RVA: 0x11C8C0 Offset: 0x11C9C1 VA: 0x11C8C0
	private Sprite m_PressedSprite; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0x11C8D0 Offset: 0x11C9D1 VA: 0x11C8D0
	[SerializeField] // RVA: 0x11C8D0 Offset: 0x11C9D1 VA: 0x11C8D0
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField] // RVA: 0x11C920 Offset: 0x11CA21 VA: 0x11C920
	private Sprite m_DisabledSprite; // 0x18

	// Properties
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }

	// Methods

	// RVA: 0x22280 Offset: 0x22381 VA: 0x22280
	public Sprite get_highlightedSprite() { }

	// RVA: 0x22290 Offset: 0x22391 VA: 0x22290
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x222A0 Offset: 0x223A1 VA: 0x222A0
	public Sprite get_pressedSprite() { }

	// RVA: 0x222B0 Offset: 0x223B1 VA: 0x222B0
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x222C0 Offset: 0x223C1 VA: 0x222C0
	public Sprite get_selectedSprite() { }

	// RVA: 0x222D0 Offset: 0x223D1 VA: 0x222D0
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x222E0 Offset: 0x223E1 VA: 0x222E0
	public Sprite get_disabledSprite() { }

	// RVA: 0x222F0 Offset: 0x223F1 VA: 0x222F0
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x22300 Offset: 0x22401 VA: 0x22300 Slot: 4
	public bool Equals(SpriteState other) { }
}


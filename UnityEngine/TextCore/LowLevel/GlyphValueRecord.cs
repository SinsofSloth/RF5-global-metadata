[UsedByNativeCodeAttribute] // RVA: 0x100BC0 Offset: 0x100CC1 VA: 0x100BC0
[Serializable]
public struct GlyphValueRecord : IEquatable<GlyphValueRecord> // TypeDefIndex: 3682
{
	// Fields
	[NativeNameAttribute] // RVA: 0x101730 Offset: 0x101831 VA: 0x101730
	[SerializeField] // RVA: 0x101730 Offset: 0x101831 VA: 0x101730
	private float m_XPlacement; // 0x0
	[NativeNameAttribute] // RVA: 0x101780 Offset: 0x101881 VA: 0x101780
	[SerializeField] // RVA: 0x101780 Offset: 0x101881 VA: 0x101780
	private float m_YPlacement; // 0x4
	[NativeNameAttribute] // RVA: 0x1017D0 Offset: 0x1018D1 VA: 0x1017D0
	[SerializeField] // RVA: 0x1017D0 Offset: 0x1018D1 VA: 0x1017D0
	private float m_XAdvance; // 0x8
	[NativeNameAttribute] // RVA: 0x101820 Offset: 0x101921 VA: 0x101820
	[SerializeField] // RVA: 0x101820 Offset: 0x101921 VA: 0x101820
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; }
	public float yPlacement { get; }
	public float xAdvance { get; }
	public float yAdvance { get; }

	// Methods

	// RVA: 0x25130 Offset: 0x25231 VA: 0x25130
	public float get_xPlacement() { }

	// RVA: 0x25140 Offset: 0x25241 VA: 0x25140
	public float get_yPlacement() { }

	// RVA: 0x25150 Offset: 0x25251 VA: 0x25150
	public float get_xAdvance() { }

	// RVA: 0x25160 Offset: 0x25261 VA: 0x25160
	public float get_yAdvance() { }

	// RVA: 0x25170 Offset: 0x25271 VA: 0x25170 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x251F0 Offset: 0x252F1 VA: 0x251F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25280 Offset: 0x25381 VA: 0x25280 Slot: 4
	public bool Equals(GlyphValueRecord other) { }
}


[Serializable]
public struct TMP_GlyphValueRecord // TypeDefIndex: 5798
{
	// Fields
	[SerializeField] // RVA: 0x13F6B0 Offset: 0x13F7B1 VA: 0x13F6B0
	internal float m_XPlacement; // 0x0
	[SerializeField] // RVA: 0x13F6C0 Offset: 0x13F7C1 VA: 0x13F6C0
	internal float m_YPlacement; // 0x4
	[SerializeField] // RVA: 0x13F6D0 Offset: 0x13F7D1 VA: 0x13F6D0
	internal float m_XAdvance; // 0x8
	[SerializeField] // RVA: 0x13F6E0 Offset: 0x13F7E1 VA: 0x13F6E0
	internal float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }

	// Methods

	// RVA: 0x3010 Offset: 0x3111 VA: 0x3010
	public float get_xPlacement() { }

	// RVA: 0x3020 Offset: 0x3121 VA: 0x3020
	public void set_xPlacement(float value) { }

	// RVA: 0x3030 Offset: 0x3131 VA: 0x3030
	public float get_yPlacement() { }

	// RVA: 0x3040 Offset: 0x3141 VA: 0x3040
	public void set_yPlacement(float value) { }

	// RVA: 0x3050 Offset: 0x3151 VA: 0x3050
	public float get_xAdvance() { }

	// RVA: 0x3060 Offset: 0x3161 VA: 0x3060
	public void set_xAdvance(float value) { }

	// RVA: 0x3070 Offset: 0x3171 VA: 0x3070
	public float get_yAdvance() { }

	// RVA: 0x3080 Offset: 0x3181 VA: 0x3080
	public void set_yAdvance(float value) { }

	// RVA: 0x3090 Offset: 0x3191 VA: 0x3090
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x30B0 Offset: 0x31B1 VA: 0x30B0
	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	// RVA: 0x30D0 Offset: 0x31D1 VA: 0x30D0
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0x155F1D0 Offset: 0x155F2D1 VA: 0x155F1D0
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }
}


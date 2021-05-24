[Serializable]
public class KerningPair // TypeDefIndex: 5787
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x13F590 Offset: 0x13F691 VA: 0x13F590
	[SerializeField] // RVA: 0x13F590 Offset: 0x13F691 VA: 0x13F590
	private uint m_FirstGlyph; // 0x10
	[SerializeField] // RVA: 0x13F5E0 Offset: 0x13F6E1 VA: 0x13F5E0
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAsAttribute] // RVA: 0x13F5F0 Offset: 0x13F6F1 VA: 0x13F5F0
	[SerializeField] // RVA: 0x13F5F0 Offset: 0x13F6F1 VA: 0x13F5F0
	private uint m_SecondGlyph; // 0x24
	[SerializeField] // RVA: 0x13F640 Offset: 0x13F741 VA: 0x13F640
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x13F650 Offset: 0x13F751 VA: 0x13F650
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField] // RVA: 0x13F690 Offset: 0x13F791 VA: 0x13F690
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x154AC70 Offset: 0x154AD71 VA: 0x154AC70
	public uint get_firstGlyph() { }

	// RVA: 0x154AC80 Offset: 0x154AD81 VA: 0x154AC80
	public void set_firstGlyph(uint value) { }

	// RVA: 0x154AC90 Offset: 0x154AD91 VA: 0x154AC90
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x154ACA0 Offset: 0x154ADA1 VA: 0x154ACA0
	public uint get_secondGlyph() { }

	// RVA: 0x154ACB0 Offset: 0x154ADB1 VA: 0x154ACB0
	public void set_secondGlyph(uint value) { }

	// RVA: 0x154ACC0 Offset: 0x154ADC1 VA: 0x154ACC0
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0x154ACD0 Offset: 0x154ADD1 VA: 0x154ACD0
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0x154ACE0 Offset: 0x154ADE1 VA: 0x154ACE0
	public void .ctor() { }

	// RVA: 0x154AD10 Offset: 0x154AE11 VA: 0x154AD10
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0x154AD60 Offset: 0x154AE61 VA: 0x154AD60
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0x154AE00 Offset: 0x154AF01 VA: 0x154AE00
	internal void ConvertLegacyKerningData() { }

	// RVA: 0x154AE10 Offset: 0x154AF11 VA: 0x154AE10
	private static void .cctor() { }
}

[Serializable]
public class KerningPair // TypeDefIndex: 5787
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x13F590 Offset: 0x13F691 VA: 0x13F590
	[SerializeField] // RVA: 0x13F590 Offset: 0x13F691 VA: 0x13F590
	private uint m_FirstGlyph; // 0x10
	[SerializeField] // RVA: 0x13F5E0 Offset: 0x13F6E1 VA: 0x13F5E0
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAsAttribute] // RVA: 0x13F5F0 Offset: 0x13F6F1 VA: 0x13F5F0
	[SerializeField] // RVA: 0x13F5F0 Offset: 0x13F6F1 VA: 0x13F5F0
	private uint m_SecondGlyph; // 0x24
	[SerializeField] // RVA: 0x13F640 Offset: 0x13F741 VA: 0x13F640
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x13F650 Offset: 0x13F751 VA: 0x13F650
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField] // RVA: 0x13F690 Offset: 0x13F791 VA: 0x13F690
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x154AC70 Offset: 0x154AD71 VA: 0x154AC70
	public uint get_firstGlyph() { }

	// RVA: 0x154AC80 Offset: 0x154AD81 VA: 0x154AC80
	public void set_firstGlyph(uint value) { }

	// RVA: 0x154AC90 Offset: 0x154AD91 VA: 0x154AC90
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x154ACA0 Offset: 0x154ADA1 VA: 0x154ACA0
	public uint get_secondGlyph() { }

	// RVA: 0x154ACB0 Offset: 0x154ADB1 VA: 0x154ACB0
	public void set_secondGlyph(uint value) { }

	// RVA: 0x154ACC0 Offset: 0x154ADC1 VA: 0x154ACC0
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0x154ACD0 Offset: 0x154ADD1 VA: 0x154ACD0
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0x154ACE0 Offset: 0x154ADE1 VA: 0x154ACE0
	public void .ctor() { }

	// RVA: 0x154AD10 Offset: 0x154AE11 VA: 0x154AD10
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0x154AD60 Offset: 0x154AE61 VA: 0x154AD60
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0x154AE00 Offset: 0x154AF01 VA: 0x154AE00
	internal void ConvertLegacyKerningData() { }

	// RVA: 0x154AE10 Offset: 0x154AF11 VA: 0x154AE10
	private static void .cctor() { }
}

[Serializable]
public class KerningPair // TypeDefIndex: 5787
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x13F590 Offset: 0x13F691 VA: 0x13F590
	[SerializeField] // RVA: 0x13F590 Offset: 0x13F691 VA: 0x13F590
	private uint m_FirstGlyph; // 0x10
	[SerializeField] // RVA: 0x13F5E0 Offset: 0x13F6E1 VA: 0x13F5E0
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAsAttribute] // RVA: 0x13F5F0 Offset: 0x13F6F1 VA: 0x13F5F0
	[SerializeField] // RVA: 0x13F5F0 Offset: 0x13F6F1 VA: 0x13F5F0
	private uint m_SecondGlyph; // 0x24
	[SerializeField] // RVA: 0x13F640 Offset: 0x13F741 VA: 0x13F640
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x13F650 Offset: 0x13F751 VA: 0x13F650
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField] // RVA: 0x13F690 Offset: 0x13F791 VA: 0x13F690
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x154AC70 Offset: 0x154AD71 VA: 0x154AC70
	public uint get_firstGlyph() { }

	// RVA: 0x154AC80 Offset: 0x154AD81 VA: 0x154AC80
	public void set_firstGlyph(uint value) { }

	// RVA: 0x154AC90 Offset: 0x154AD91 VA: 0x154AC90
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x154ACA0 Offset: 0x154ADA1 VA: 0x154ACA0
	public uint get_secondGlyph() { }

	// RVA: 0x154ACB0 Offset: 0x154ADB1 VA: 0x154ACB0
	public void set_secondGlyph(uint value) { }

	// RVA: 0x154ACC0 Offset: 0x154ADC1 VA: 0x154ACC0
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0x154ACD0 Offset: 0x154ADD1 VA: 0x154ACD0
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0x154ACE0 Offset: 0x154ADE1 VA: 0x154ACE0
	public void .ctor() { }

	// RVA: 0x154AD10 Offset: 0x154AE11 VA: 0x154AD10
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0x154AD60 Offset: 0x154AE61 VA: 0x154AD60
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0x154AE00 Offset: 0x154AF01 VA: 0x154AE00
	internal void ConvertLegacyKerningData() { }

	// RVA: 0x154AE10 Offset: 0x154AF11 VA: 0x154AE10
	private static void .cctor() { }
}

[Serializable]
public class KerningPair // TypeDefIndex: 5787
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x13F590 Offset: 0x13F691 VA: 0x13F590
	[SerializeField] // RVA: 0x13F590 Offset: 0x13F691 VA: 0x13F590
	private uint m_FirstGlyph; // 0x10
	[SerializeField] // RVA: 0x13F5E0 Offset: 0x13F6E1 VA: 0x13F5E0
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAsAttribute] // RVA: 0x13F5F0 Offset: 0x13F6F1 VA: 0x13F5F0
	[SerializeField] // RVA: 0x13F5F0 Offset: 0x13F6F1 VA: 0x13F5F0
	private uint m_SecondGlyph; // 0x24
	[SerializeField] // RVA: 0x13F640 Offset: 0x13F741 VA: 0x13F640
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x13F650 Offset: 0x13F751 VA: 0x13F650
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField] // RVA: 0x13F690 Offset: 0x13F791 VA: 0x13F690
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x154AC70 Offset: 0x154AD71 VA: 0x154AC70
	public uint get_firstGlyph() { }

	// RVA: 0x154AC80 Offset: 0x154AD81 VA: 0x154AC80
	public void set_firstGlyph(uint value) { }

	// RVA: 0x154AC90 Offset: 0x154AD91 VA: 0x154AC90
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x154ACA0 Offset: 0x154ADA1 VA: 0x154ACA0
	public uint get_secondGlyph() { }

	// RVA: 0x154ACB0 Offset: 0x154ADB1 VA: 0x154ACB0
	public void set_secondGlyph(uint value) { }

	// RVA: 0x154ACC0 Offset: 0x154ADC1 VA: 0x154ACC0
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0x154ACD0 Offset: 0x154ADD1 VA: 0x154ACD0
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0x154ACE0 Offset: 0x154ADE1 VA: 0x154ACE0
	public void .ctor() { }

	// RVA: 0x154AD10 Offset: 0x154AE11 VA: 0x154AD10
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0x154AD60 Offset: 0x154AE61 VA: 0x154AD60
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0x154AE00 Offset: 0x154AF01 VA: 0x154AE00
	internal void ConvertLegacyKerningData() { }

	// RVA: 0x154AE10 Offset: 0x154AF11 VA: 0x154AE10
	private static void .cctor() { }
}

[Serializable]
public class KerningPair // TypeDefIndex: 5787
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x13F590 Offset: 0x13F691 VA: 0x13F590
	[SerializeField] // RVA: 0x13F590 Offset: 0x13F691 VA: 0x13F590
	private uint m_FirstGlyph; // 0x10
	[SerializeField] // RVA: 0x13F5E0 Offset: 0x13F6E1 VA: 0x13F5E0
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAsAttribute] // RVA: 0x13F5F0 Offset: 0x13F6F1 VA: 0x13F5F0
	[SerializeField] // RVA: 0x13F5F0 Offset: 0x13F6F1 VA: 0x13F5F0
	private uint m_SecondGlyph; // 0x24
	[SerializeField] // RVA: 0x13F640 Offset: 0x13F741 VA: 0x13F640
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x13F650 Offset: 0x13F751 VA: 0x13F650
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField] // RVA: 0x13F690 Offset: 0x13F791 VA: 0x13F690
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x154AC70 Offset: 0x154AD71 VA: 0x154AC70
	public uint get_firstGlyph() { }

	// RVA: 0x154AC80 Offset: 0x154AD81 VA: 0x154AC80
	public void set_firstGlyph(uint value) { }

	// RVA: 0x154AC90 Offset: 0x154AD91 VA: 0x154AC90
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x154ACA0 Offset: 0x154ADA1 VA: 0x154ACA0
	public uint get_secondGlyph() { }

	// RVA: 0x154ACB0 Offset: 0x154ADB1 VA: 0x154ACB0
	public void set_secondGlyph(uint value) { }

	// RVA: 0x154ACC0 Offset: 0x154ADC1 VA: 0x154ACC0
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0x154ACD0 Offset: 0x154ADD1 VA: 0x154ACD0
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0x154ACE0 Offset: 0x154ADE1 VA: 0x154ACE0
	public void .ctor() { }

	// RVA: 0x154AD10 Offset: 0x154AE11 VA: 0x154AD10
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0x154AD60 Offset: 0x154AE61 VA: 0x154AD60
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0x154AE00 Offset: 0x154AF01 VA: 0x154AE00
	internal void ConvertLegacyKerningData() { }

	// RVA: 0x154AE10 Offset: 0x154AF11 VA: 0x154AE10
	private static void .cctor() { }
}


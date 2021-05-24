[UsedByNativeCodeAttribute] // RVA: 0x100B70 Offset: 0x100C71 VA: 0x100B70
[Serializable]
public struct FaceInfo // TypeDefIndex: 3677
{
	// Fields
	[NativeNameAttribute] // RVA: 0x100CE0 Offset: 0x100DE1 VA: 0x100CE0
	[SerializeField] // RVA: 0x100CE0 Offset: 0x100DE1 VA: 0x100CE0
	private string m_FamilyName; // 0x0
	[SerializeField] // RVA: 0x100D30 Offset: 0x100E31 VA: 0x100D30
	[NativeNameAttribute] // RVA: 0x100D30 Offset: 0x100E31 VA: 0x100D30
	private string m_StyleName; // 0x8
	[NativeNameAttribute] // RVA: 0x100D80 Offset: 0x100E81 VA: 0x100D80
	[SerializeField] // RVA: 0x100D80 Offset: 0x100E81 VA: 0x100D80
	private int m_PointSize; // 0x10
	[NativeNameAttribute] // RVA: 0x100DD0 Offset: 0x100ED1 VA: 0x100DD0
	[SerializeField] // RVA: 0x100DD0 Offset: 0x100ED1 VA: 0x100DD0
	private float m_Scale; // 0x14
	[NativeNameAttribute] // RVA: 0x100E20 Offset: 0x100F21 VA: 0x100E20
	[SerializeField] // RVA: 0x100E20 Offset: 0x100F21 VA: 0x100E20
	private float m_LineHeight; // 0x18
	[SerializeField] // RVA: 0x100E70 Offset: 0x100F71 VA: 0x100E70
	[NativeNameAttribute] // RVA: 0x100E70 Offset: 0x100F71 VA: 0x100E70
	private float m_AscentLine; // 0x1C
	[NativeNameAttribute] // RVA: 0x100EC0 Offset: 0x100FC1 VA: 0x100EC0
	[SerializeField] // RVA: 0x100EC0 Offset: 0x100FC1 VA: 0x100EC0
	private float m_CapLine; // 0x20
	[NativeNameAttribute] // RVA: 0x100F10 Offset: 0x101011 VA: 0x100F10
	[SerializeField] // RVA: 0x100F10 Offset: 0x101011 VA: 0x100F10
	private float m_MeanLine; // 0x24
	[NativeNameAttribute] // RVA: 0x100F60 Offset: 0x101061 VA: 0x100F60
	[SerializeField] // RVA: 0x100F60 Offset: 0x101061 VA: 0x100F60
	private float m_Baseline; // 0x28
	[SerializeField] // RVA: 0x100FB0 Offset: 0x1010B1 VA: 0x100FB0
	[NativeNameAttribute] // RVA: 0x100FB0 Offset: 0x1010B1 VA: 0x100FB0
	private float m_DescentLine; // 0x2C
	[NativeNameAttribute] // RVA: 0x101000 Offset: 0x101101 VA: 0x101000
	[SerializeField] // RVA: 0x101000 Offset: 0x101101 VA: 0x101000
	private float m_SuperscriptOffset; // 0x30
	[SerializeField] // RVA: 0x101050 Offset: 0x101151 VA: 0x101050
	[NativeNameAttribute] // RVA: 0x101050 Offset: 0x101151 VA: 0x101050
	private float m_SuperscriptSize; // 0x34
	[SerializeField] // RVA: 0x1010A0 Offset: 0x1011A1 VA: 0x1010A0
	[NativeNameAttribute] // RVA: 0x1010A0 Offset: 0x1011A1 VA: 0x1010A0
	private float m_SubscriptOffset; // 0x38
	[NativeNameAttribute] // RVA: 0x1010F0 Offset: 0x1011F1 VA: 0x1010F0
	[SerializeField] // RVA: 0x1010F0 Offset: 0x1011F1 VA: 0x1010F0
	private float m_SubscriptSize; // 0x3C
	[NativeNameAttribute] // RVA: 0x101140 Offset: 0x101241 VA: 0x101140
	[SerializeField] // RVA: 0x101140 Offset: 0x101241 VA: 0x101140
	private float m_UnderlineOffset; // 0x40
	[NativeNameAttribute] // RVA: 0x101190 Offset: 0x101291 VA: 0x101190
	[SerializeField] // RVA: 0x101190 Offset: 0x101291 VA: 0x101190
	private float m_UnderlineThickness; // 0x44
	[NativeNameAttribute] // RVA: 0x1011E0 Offset: 0x1012E1 VA: 0x1011E0
	[SerializeField] // RVA: 0x1011E0 Offset: 0x1012E1 VA: 0x1011E0
	private float m_StrikethroughOffset; // 0x48
	[SerializeField] // RVA: 0x101230 Offset: 0x101331 VA: 0x101230
	[NativeNameAttribute] // RVA: 0x101230 Offset: 0x101331 VA: 0x101230
	private float m_StrikethroughThickness; // 0x4C
	[SerializeField] // RVA: 0x101280 Offset: 0x101381 VA: 0x101280
	[NativeNameAttribute] // RVA: 0x101280 Offset: 0x101381 VA: 0x101280
	private float m_TabWidth; // 0x50

	// Properties
	public string familyName { set; }
	public string styleName { set; }
	public int pointSize { get; set; }
	public float scale { get; set; }
	public float lineHeight { get; set; }
	public float ascentLine { get; set; }
	public float capLine { get; set; }
	public float meanLine { get; set; }
	public float baseline { get; set; }
	public float descentLine { get; set; }
	public float superscriptOffset { get; set; }
	public float superscriptSize { get; set; }
	public float subscriptOffset { get; set; }
	public float subscriptSize { get; set; }
	public float underlineOffset { get; set; }
	public float underlineThickness { get; set; }
	public float strikethroughOffset { get; set; }
	public float strikethroughThickness { set; }
	public float tabWidth { get; set; }

	// Methods

	// RVA: 0x249C0 Offset: 0x24AC1 VA: 0x249C0
	public void set_familyName(string value) { }

	// RVA: 0x249D0 Offset: 0x24AD1 VA: 0x249D0
	public void set_styleName(string value) { }

	// RVA: 0x249E0 Offset: 0x24AE1 VA: 0x249E0
	public int get_pointSize() { }

	// RVA: 0x249F0 Offset: 0x24AF1 VA: 0x249F0
	public void set_pointSize(int value) { }

	// RVA: 0x24A00 Offset: 0x24B01 VA: 0x24A00
	public float get_scale() { }

	// RVA: 0x24A10 Offset: 0x24B11 VA: 0x24A10
	public void set_scale(float value) { }

	// RVA: 0x24A20 Offset: 0x24B21 VA: 0x24A20
	public float get_lineHeight() { }

	// RVA: 0x24A30 Offset: 0x24B31 VA: 0x24A30
	public void set_lineHeight(float value) { }

	// RVA: 0x24A40 Offset: 0x24B41 VA: 0x24A40
	public float get_ascentLine() { }

	// RVA: 0x24A50 Offset: 0x24B51 VA: 0x24A50
	public void set_ascentLine(float value) { }

	// RVA: 0x24A60 Offset: 0x24B61 VA: 0x24A60
	public float get_capLine() { }

	// RVA: 0x24A70 Offset: 0x24B71 VA: 0x24A70
	public void set_capLine(float value) { }

	// RVA: 0x24A80 Offset: 0x24B81 VA: 0x24A80
	public float get_meanLine() { }

	// RVA: 0x24A90 Offset: 0x24B91 VA: 0x24A90
	public void set_meanLine(float value) { }

	// RVA: 0x24AA0 Offset: 0x24BA1 VA: 0x24AA0
	public float get_baseline() { }

	// RVA: 0x24AB0 Offset: 0x24BB1 VA: 0x24AB0
	public void set_baseline(float value) { }

	// RVA: 0x24AC0 Offset: 0x24BC1 VA: 0x24AC0
	public float get_descentLine() { }

	// RVA: 0x24AD0 Offset: 0x24BD1 VA: 0x24AD0
	public void set_descentLine(float value) { }

	// RVA: 0x24AE0 Offset: 0x24BE1 VA: 0x24AE0
	public float get_superscriptOffset() { }

	// RVA: 0x24AF0 Offset: 0x24BF1 VA: 0x24AF0
	public void set_superscriptOffset(float value) { }

	// RVA: 0x24B00 Offset: 0x24C01 VA: 0x24B00
	public float get_superscriptSize() { }

	// RVA: 0x24B10 Offset: 0x24C11 VA: 0x24B10
	public void set_superscriptSize(float value) { }

	// RVA: 0x24B20 Offset: 0x24C21 VA: 0x24B20
	public float get_subscriptOffset() { }

	// RVA: 0x24B30 Offset: 0x24C31 VA: 0x24B30
	public void set_subscriptOffset(float value) { }

	// RVA: 0x24B40 Offset: 0x24C41 VA: 0x24B40
	public float get_subscriptSize() { }

	// RVA: 0x24B50 Offset: 0x24C51 VA: 0x24B50
	public void set_subscriptSize(float value) { }

	// RVA: 0x24B60 Offset: 0x24C61 VA: 0x24B60
	public float get_underlineOffset() { }

	// RVA: 0x24B70 Offset: 0x24C71 VA: 0x24B70
	public void set_underlineOffset(float value) { }

	// RVA: 0x24B80 Offset: 0x24C81 VA: 0x24B80
	public float get_underlineThickness() { }

	// RVA: 0x24B90 Offset: 0x24C91 VA: 0x24B90
	public void set_underlineThickness(float value) { }

	// RVA: 0x24BA0 Offset: 0x24CA1 VA: 0x24BA0
	public float get_strikethroughOffset() { }

	// RVA: 0x24BB0 Offset: 0x24CB1 VA: 0x24BB0
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x24BC0 Offset: 0x24CC1 VA: 0x24BC0
	public void set_strikethroughThickness(float value) { }

	// RVA: 0x24BD0 Offset: 0x24CD1 VA: 0x24BD0
	public float get_tabWidth() { }

	// RVA: 0x24BE0 Offset: 0x24CE1 VA: 0x24BE0
	public void set_tabWidth(float value) { }
}


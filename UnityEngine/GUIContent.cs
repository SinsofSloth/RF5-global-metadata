[RequiredByNativeCodeAttribute] // RVA: 0xF4A70 Offset: 0xF4B71 VA: 0xF4A70
[NativeHeaderAttribute] // RVA: 0xF4A70 Offset: 0xF4B71 VA: 0xF4A70
[Serializable]
public class GUIContent // TypeDefIndex: 3593
{
	// Fields
	[SerializeField] // RVA: 0xF5650 Offset: 0xF5751 VA: 0xF5650
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0xF5660 Offset: 0xF5761 VA: 0xF5660
	private Texture m_Image; // 0x18
	[SerializeField] // RVA: 0xF5670 Offset: 0xF5771 VA: 0xF5670
	private string m_Tooltip; // 0x20
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	// Properties
	public string text { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }

	// Methods

	// RVA: 0x2D06E10 Offset: 0x2D06F11 VA: 0x2D06E10
	public string get_text() { }

	// RVA: 0x2D06E20 Offset: 0x2D06F21 VA: 0x2D06E20
	public void set_text(string value) { }

	// RVA: 0x2D0FBA0 Offset: 0x2D0FCA1 VA: 0x2D0FBA0
	public void set_image(Texture value) { }

	// RVA: 0x2D09F50 Offset: 0x2D0A051 VA: 0x2D09F50
	public string get_tooltip() { }

	// RVA: 0x2D0FBB0 Offset: 0x2D0FCB1 VA: 0x2D0FBB0
	public void set_tooltip(string value) { }

	// RVA: 0x2D0FBC0 Offset: 0x2D0FCC1 VA: 0x2D0FBC0
	public void .ctor() { }

	// RVA: 0x2D0FC40 Offset: 0x2D0FD41 VA: 0x2D0FC40
	public void .ctor(string text) { }

	// RVA: 0x2D0FD90 Offset: 0x2D0FE91 VA: 0x2D0FD90
	public void .ctor(Texture image) { }

	// RVA: 0x2D0FCB0 Offset: 0x2D0FDB1 VA: 0x2D0FCB0
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x2D0FE00 Offset: 0x2D0FF01 VA: 0x2D0FE00
	public void .ctor(GUIContent src) { }

	// RVA: 0x2D04120 Offset: 0x2D04221 VA: 0x2D04120
	internal static GUIContent Temp(string t) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF6930 Offset: 0xF6A31 VA: 0xF6930
	// RVA: 0x2D0FED0 Offset: 0x2D0FFD1 VA: 0x2D0FED0
	internal static void ClearStaticCache() { }

	// RVA: 0x2D0FFF0 Offset: 0x2D100F1 VA: 0x2D0FFF0
	internal static GUIContent[] Temp(string[] texts) { }

	// RVA: 0x2D101D0 Offset: 0x2D102D1 VA: 0x2D101D0
	private static void .cctor() { }
}


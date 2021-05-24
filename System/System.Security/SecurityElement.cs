[ComVisibleAttribute] // RVA: 0xAF9B0 Offset: 0xAFAB1 VA: 0xAF9B0
[Serializable]
public sealed class SecurityElement // TypeDefIndex: 889
{
	// Fields
	private string text; // 0x10
	private string tag; // 0x18
	private ArrayList attributes; // 0x20
	private ArrayList children; // 0x28
	private static readonly char[] invalid_tag_chars; // 0x0
	private static readonly char[] invalid_text_chars; // 0x8
	private static readonly char[] invalid_attr_name_chars; // 0x10
	private static readonly char[] invalid_attr_value_chars; // 0x18
	private static readonly char[] invalid_chars; // 0x20

	// Properties
	public Hashtable Attributes { get; }
	public ArrayList Children { get; }
	public string Tag { get; }
	public string Text { get; set; }
	internal string m_strText { set; }

	// Methods

	// RVA: 0x263FFD0 Offset: 0x26400D1 VA: 0x263FFD0
	public void .ctor(string tag) { }

	// RVA: 0x2640250 Offset: 0x2640351 VA: 0x2640250
	public void .ctor(string tag, string text) { }

	// RVA: 0x2640720 Offset: 0x2640821 VA: 0x2640720
	public Hashtable get_Attributes() { }

	// RVA: 0x2640B20 Offset: 0x2640C21 VA: 0x2640B20
	public ArrayList get_Children() { }

	// RVA: 0x2640B30 Offset: 0x2640C31 VA: 0x2640B30
	public string get_Tag() { }

	// RVA: 0x2640B40 Offset: 0x2640C41 VA: 0x2640B40
	public string get_Text() { }

	// RVA: 0x26405B0 Offset: 0x26406B1 VA: 0x26405B0
	public void set_Text(string value) { }

	// RVA: 0x263FFE0 Offset: 0x26400E1 VA: 0x263FFE0
	public void AddAttribute(string name, string value) { }

	// RVA: 0x2640170 Offset: 0x2640271 VA: 0x2640170
	public void AddChild(SecurityElement child) { }

	// RVA: 0x26414A0 Offset: 0x26415A1 VA: 0x26414A0
	public static string Escape(string str) { }

	// RVA: 0x2640BF0 Offset: 0x2640CF1 VA: 0x2640BF0
	private static string Unescape(string str) { }

	// RVA: 0x2641730 Offset: 0x2641831 VA: 0x2641730
	public static SecurityElement FromString(string xml) { }

	// RVA: 0x2641930 Offset: 0x2641A31 VA: 0x2641930
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x26419D0 Offset: 0x2641AD1 VA: 0x26419D0
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x2640400 Offset: 0x2640501 VA: 0x2640400
	public static bool IsValidTag(string tag) { }

	// RVA: 0x2640B50 Offset: 0x2640C51 VA: 0x2640B50
	public static bool IsValidText(string text) { }

	// RVA: 0x2641A70 Offset: 0x2641B71 VA: 0x2641A70
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x2641BB0 Offset: 0x2641CB1 VA: 0x2641BB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2641C40 Offset: 0x2641D41 VA: 0x2641C40
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x2640D30 Offset: 0x2640E31 VA: 0x2640D30
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x26421B0 Offset: 0x26422B1 VA: 0x26421B0
	internal void set_m_strText(string value) { }

	// RVA: 0x26421C0 Offset: 0x26422C1 VA: 0x26421C0
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x26427F0 Offset: 0x26428F1 VA: 0x26427F0
	private static void .cctor() { }
}


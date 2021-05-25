[Serializable]
public class TMP_Style // TypeDefIndex: 5848
{
	// Fields
	internal static TMP_Style k_NormalStyle; // 0x0
	[SerializeField] // RVA: 0x13FCE0 Offset: 0x13FDE1 VA: 0x13FCE0
	private string m_Name; // 0x10
	[SerializeField] // RVA: 0x13FCF0 Offset: 0x13FDF1 VA: 0x13FCF0
	private int m_HashCode; // 0x18
	[SerializeField] // RVA: 0x13FD00 Offset: 0x13FE01 VA: 0x13FD00
	private string m_OpeningDefinition; // 0x20
	[SerializeField] // RVA: 0x13FD10 Offset: 0x13FE11 VA: 0x13FD10
	private string m_ClosingDefinition; // 0x28
	[SerializeField] // RVA: 0x13FD20 Offset: 0x13FE21 VA: 0x13FD20
	private int[] m_OpeningTagArray; // 0x30
	[SerializeField] // RVA: 0x13FD30 Offset: 0x13FE31 VA: 0x13FD30
	private int[] m_ClosingTagArray; // 0x38

	// Properties
	public static TMP_Style NormalStyle { get; }
	public string name { get; set; }
	public int hashCode { get; set; }
	public string styleOpeningDefinition { get; }
	public string styleClosingDefinition { get; }
	public int[] styleOpeningTagArray { get; }
	public int[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0x14C9FA0 Offset: 0x14CA0A1 VA: 0x14C9FA0
	public static TMP_Style get_NormalStyle() { }

	// RVA: 0x14CA130 Offset: 0x14CA231 VA: 0x14CA130
	public string get_name() { }

	// RVA: 0x14CA140 Offset: 0x14CA241 VA: 0x14CA140
	public void set_name(string value) { }

	// RVA: 0x14CA190 Offset: 0x14CA291 VA: 0x14CA190
	public int get_hashCode() { }

	// RVA: 0x14CA1A0 Offset: 0x14CA2A1 VA: 0x14CA1A0
	public void set_hashCode(int value) { }

	// RVA: 0x14CA1C0 Offset: 0x14CA2C1 VA: 0x14CA1C0
	public string get_styleOpeningDefinition() { }

	// RVA: 0x14CA1D0 Offset: 0x14CA2D1 VA: 0x14CA1D0
	public string get_styleClosingDefinition() { }

	// RVA: 0x14CA1E0 Offset: 0x14CA2E1 VA: 0x14CA1E0
	public int[] get_styleOpeningTagArray() { }

	// RVA: 0x14CA1F0 Offset: 0x14CA2F1 VA: 0x14CA1F0
	public int[] get_styleClosingTagArray() { }

	// RVA: 0x14CA060 Offset: 0x14CA161 VA: 0x14CA060
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x14CA200 Offset: 0x14CA301 VA: 0x14CA200
	public void RefreshStyle() { }
}


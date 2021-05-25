[Serializable]
public class PresentItemParamDataTable // TypeDefIndex: 7031
{
	// Fields
	[SerializeField] // RVA: 0x162900 Offset: 0x162A01 VA: 0x162900
	public Parameter Parameter; // 0x10
	[SerializeField] // RVA: 0x162910 Offset: 0x162A11 VA: 0x162910
	public bool IsMulti; // 0xCC
	private static PresentItemParamDataTableArray _PresentItemParamDataTableArray; // 0x0

	// Methods

	// RVA: 0x1DE9900 Offset: 0x1DE9A01 VA: 0x1DE9900
	public static bool HasDataTable(ItemID id) { }

	// RVA: 0x1DE9A40 Offset: 0x1DE9B41 VA: 0x1DE9A40
	public static PresentItemParamDataTable GetDataTable(ItemID id) { }

	// RVA: 0x1DE9B80 Offset: 0x1DE9C81 VA: 0x1DE9B80
	public static PresentItemParamDataTable GetDataTable(PresentMonsterCategoryID id) { }

	// RVA: 0x1DE9CD0 Offset: 0x1DE9DD1 VA: 0x1DE9CD0
	public void .ctor() { }
}


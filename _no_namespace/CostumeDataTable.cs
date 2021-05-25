[Serializable]
public class CostumeDataTable // TypeDefIndex: 6934
{
	// Fields
	[SerializeField] // RVA: 0x161980 Offset: 0x161A81 VA: 0x161980
	public UITextDic.DICID MaleNameKey; // 0x10
	[SerializeField] // RVA: 0x161990 Offset: 0x161A91 VA: 0x161990
	public UITextDic.DICID FemaleNameKey; // 0x14
	private static CostumeDataTableArray _CostumeDataTableArray; // 0x0

	// Methods

	// RVA: 0x1FCB6D0 Offset: 0x1FCB7D1 VA: 0x1FCB6D0
	public static CostumeDataTable GetDataTable(VariationNo variationNo) { }

	// RVA: 0x1FCB820 Offset: 0x1FCB921 VA: 0x1FCB820
	public static UITextDic.DICID GetCostumeTitleKey(VariationNo variationNo, bool male) { }

	// RVA: 0x1FCB860 Offset: 0x1FCB961 VA: 0x1FCB860
	public void .ctor() { }
}


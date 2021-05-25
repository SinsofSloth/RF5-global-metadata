[Serializable]
public class RecipePanCountDataTable // TypeDefIndex: 7034
{
	// Fields
	[SerializeField] // RVA: 0x162920 Offset: 0x162A21 VA: 0x162920
	public PanShopType PanShopType; // 0x10
	[SerializeField] // RVA: 0x162930 Offset: 0x162A31 VA: 0x162930
	public BuilderId Release_BuilderID; // 0x14
	[SerializeField] // RVA: 0x162940 Offset: 0x162A41 VA: 0x162940
	public int Count; // 0x18
	private static RecipePanCountDataTableArray _RecipePanCountDataTableArray; // 0x0

	// Methods

	// RVA: 0x1DB01B0 Offset: 0x1DB02B1 VA: 0x1DB01B0
	private static int GetCount(PanShopType panShopType, BuilderId builderId) { }

	// RVA: 0x1DB03A0 Offset: 0x1DB04A1 VA: 0x1DB03A0
	public static int GetCount_Restaurant() { }

	// RVA: 0x1DB0580 Offset: 0x1DB0681 VA: 0x1DB0580
	public static int GetCount_Bakery() { }

	// RVA: 0x1DB0760 Offset: 0x1DB0861 VA: 0x1DB0760
	public void .ctor() { }

	// RVA: 0x1DB0770 Offset: 0x1DB0871 VA: 0x1DB0770
	private static void .cctor() { }
}


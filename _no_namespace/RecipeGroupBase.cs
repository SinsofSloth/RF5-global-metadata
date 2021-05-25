public class RecipeGroupBase // TypeDefIndex: 8705
{
	// Fields
	public CraftCategoryDataTable.CraftCategoryData data; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x172870 Offset: 0x172971 VA: 0x172870
	private int <RecipeGroupNo>k__BackingField; // 0x18
	private static readonly FurnitureID[] furnitureIDTable; // 0x0

	// Properties
	public string name { get; }
	public string discription { get; }
	public int RecipeGroupNo { get; set; }
	public int Released { get; }
	public int Total { get; }
	public float CompletePercent { get; }
	public CraftCategoryId CraftCategoryId { get; }
	public FurnitureID CraftFurniture { get; }

	// Methods

	// RVA: 0x1DAB950 Offset: 0x1DABA51 VA: 0x1DAB950
	public string get_name() { }

	// RVA: 0x1DABA50 Offset: 0x1DABB51 VA: 0x1DABA50
	public string get_discription() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8100 Offset: 0x1A8201 VA: 0x1A8100
	// RVA: 0x1DABC00 Offset: 0x1DABD01 VA: 0x1DABC00
	public int get_RecipeGroupNo() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8110 Offset: 0x1A8211 VA: 0x1A8110
	// RVA: 0x1DABC10 Offset: 0x1DABD11 VA: 0x1DABC10
	private void set_RecipeGroupNo(int value) { }

	// RVA: 0x1DABC20 Offset: 0x1DABD21 VA: 0x1DABC20
	public int get_Released() { }

	// RVA: 0x1DABDD0 Offset: 0x1DABED1 VA: 0x1DABDD0
	public int get_Total() { }

	// RVA: 0x1DABBB0 Offset: 0x1DABCB1 VA: 0x1DABBB0
	public float get_CompletePercent() { }

	// RVA: 0x1DABE00 Offset: 0x1DABF01 VA: 0x1DABE00
	public void .ctor(int recipeGroupNo) { }

	// RVA: 0x1DABF40 Offset: 0x1DAC041 VA: 0x1DABF40
	public void .ctor(RecipeId RecipeId) { }

	// RVA: 0x1DAC270 Offset: 0x1DAC371 VA: 0x1DAC270
	public CraftCategoryId get_CraftCategoryId() { }

	// RVA: 0x1DAC280 Offset: 0x1DAC381 VA: 0x1DAC280
	public static FurnitureID CraftCategoryIDToFurnitureID(CraftCategoryId id) { }

	// RVA: 0x1DAC320 Offset: 0x1DAC421 VA: 0x1DAC320
	public FurnitureID get_CraftFurniture() { }

	// RVA: 0x1DAC410 Offset: 0x1DAC511 VA: 0x1DAC410
	private static void .cctor() { }
}


public class RecipeIdDispBlock : UIButtonLinkerInScrollBox // TypeDefIndex: 8708
{
	// Fields
	[SerializeField] // RVA: 0x172900 Offset: 0x172A01 VA: 0x172900
	private Text NameText; // 0x70
	[SerializeField] // RVA: 0x172910 Offset: 0x172A11 VA: 0x172910
	private Text DifficultyRankText; // 0x78
	[SerializeField] // RVA: 0x172920 Offset: 0x172A21 VA: 0x172920
	private Image OnSelectImage; // 0x80
	[SerializeField] // RVA: 0x172930 Offset: 0x172A31 VA: 0x172930
	private Image OutSelectImage; // 0x88
	private bool hasItem; // 0x90
	private RecipeItemPage recipeItemPage; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x172940 Offset: 0x172A41 VA: 0x172940
	private RecipeId <recipeId>k__BackingField; // 0xA0
	private readonly Color EMTPY_COLOR; // 0xA4

	// Properties
	public RecipeId recipeId { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A8140 Offset: 0x1A8241 VA: 0x1A8140
	// RVA: 0x1DACB00 Offset: 0x1DACC01 VA: 0x1DACB00
	public RecipeId get_recipeId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8150 Offset: 0x1A8251 VA: 0x1A8150
	// RVA: 0x1DACB10 Offset: 0x1DACC11 VA: 0x1DACB10
	private void set_recipeId(RecipeId value) { }

	// RVA: 0x1DACB20 Offset: 0x1DACC21 VA: 0x1DACB20 Slot: 16
	public override void Init() { }

	// RVA: 0x1DACBB0 Offset: 0x1DACCB1 VA: 0x1DACBB0
	public ItemID GetResultItem() { }

	// RVA: 0x1DACCE0 Offset: 0x1DACDE1 VA: 0x1DACCE0
	private Color GetNameTextColor(bool focusing) { }

	// RVA: 0x1DACD40 Offset: 0x1DACE41 VA: 0x1DACD40
	public int GetSkillLv() { }

	// RVA: 0x1DACE70 Offset: 0x1DACF71 VA: 0x1DACE70
	public void InitOnInstantiate(int blockNum, RecipeId id) { }

	// RVA: 0x1DADA90 Offset: 0x1DADB91 VA: 0x1DADA90 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1DADDA0 Offset: 0x1DADEA1 VA: 0x1DADDA0 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x1DADE40 Offset: 0x1DADF41 VA: 0x1DADE40
	public void .ctor() { }
}


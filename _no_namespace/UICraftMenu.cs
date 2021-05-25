public class UICraftMenu : CursorLinkConnector // TypeDefIndex: 8737
{
	// Fields
	public CraftCategoryId CraftCategoryId; // 0x58
	[SerializeField] // RVA: 0x172FD0 Offset: 0x1730D1 VA: 0x172FD0
	private RecipeItemPage RecipeItemPage; // 0x60
	[SerializeField] // RVA: 0x172FE0 Offset: 0x1730E1 VA: 0x172FE0
	private List<ButtonLinker> CraftSlots; // 0x68
	[SerializeField] // RVA: 0x172FF0 Offset: 0x1730F1 VA: 0x172FF0
	private ButtonLinker[] materialSlot; // 0x70
	[SerializeField] // RVA: 0x173000 Offset: 0x173101 VA: 0x173000
	private UIStrengtheningTopMenu topMenu; // 0x78
	[SerializeField] // RVA: 0x173010 Offset: 0x173111 VA: 0x173010
	private UICraftResult craftResult; // 0x80
	[SerializeField] // RVA: 0x173020 Offset: 0x173121 VA: 0x173020
	private CursorLinker itemSlotL1; // 0x88
	[SerializeField] // RVA: 0x173030 Offset: 0x173131 VA: 0x173030
	private CursorLinker itemSlotR1; // 0x90
	[SerializeField] // RVA: 0x173040 Offset: 0x173141 VA: 0x173040
	private Text USERP_Text; // 0x98
	[SerializeField] // RVA: 0x173050 Offset: 0x173151 VA: 0x173050
	private Text CraftNumText; // 0xA0
	private List<CraftCategoryId> CraftCategoryIdList; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x173060 Offset: 0x173161 VA: 0x173060
	private RecipeId <SelectedRecipeId>k__BackingField; // 0xB0
	private int CraftNum; // 0xB4
	private int OneCostRP; // 0xB8
	public bool OnTutorial; // 0xBC
	private int CraftNumMax; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x173070 Offset: 0x173171 VA: 0x173070
	private static bool <IsCraftFist>k__BackingField; // 0x0

	// Properties
	public RecipeId SelectedRecipeId { get; set; }
	public static bool IsCraftFist { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A8390 Offset: 0x1A8491 VA: 0x1A8390
	// RVA: 0x1F07430 Offset: 0x1F07531 VA: 0x1F07430
	public RecipeId get_SelectedRecipeId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A83A0 Offset: 0x1A84A1 VA: 0x1A83A0
	// RVA: 0x1F07440 Offset: 0x1F07541 VA: 0x1F07440
	public void set_SelectedRecipeId(RecipeId value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A83B0 Offset: 0x1A84B1 VA: 0x1A83B0
	// RVA: 0x1F07450 Offset: 0x1F07551 VA: 0x1F07450
	public static bool get_IsCraftFist() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A83C0 Offset: 0x1A84C1 VA: 0x1A83C0
	// RVA: 0x1F074A0 Offset: 0x1F075A1 VA: 0x1F074A0
	private static void set_IsCraftFist(bool value) { }

	// RVA: 0x1F07500 Offset: 0x1F07601 VA: 0x1F07500
	private void Start() { }

	// RVA: 0x1F07EA0 Offset: 0x1F07FA1 VA: 0x1F07EA0
	private void OnDestroy() { }

	// RVA: 0x1F07BA0 Offset: 0x1F07CA1 VA: 0x1F07BA0
	public void OpenRecipeItemPage(CraftCategoryId id) { }

	// RVA: 0x1F07F00 Offset: 0x1F08001 VA: 0x1F07F00
	public void CloseRecipeItemPage() { }

	// RVA: 0x1F082A0 Offset: 0x1F083A1 VA: 0x1F082A0
	public void OnCraftPage() { }

	// RVA: 0x1F09300 Offset: 0x1F09401 VA: 0x1F09300
	public void DoTutorialCraft() { }

	// RVA: 0x1F09820 Offset: 0x1F09921 VA: 0x1F09820
	public void DoSynthesis(DualWorkType workType) { }

	// RVA: 0x1F0A810 Offset: 0x1F0A911 VA: 0x1F0A810
	public bool CanRequestCraftNum(bool isLeft) { }

	// RVA: 0x1F0A8B0 Offset: 0x1F0A9B1 VA: 0x1F0A8B0
	public void RequestCraftNum(bool isLeft) { }

	// RVA: 0x1F0A9B0 Offset: 0x1F0AAB1 VA: 0x1F0A9B0
	public void OnUpdateCraftSlot() { }

	// RVA: 0x1F08AB0 Offset: 0x1F08BB1 VA: 0x1F08AB0
	private void UpdateCraftNumMax(ItemID[] itemIDs) { }

	// RVA: 0x1F08F90 Offset: 0x1F09091 VA: 0x1F08F90
	private void UpdateUSERP(ItemData[] itemDatas) { }

	// RVA: 0x1F07CC0 Offset: 0x1F07DC1 VA: 0x1F07CC0
	private void UpdateMenuTitle(CraftCategoryId craftCategoryId) { }

	// RVA: 0x1F07D60 Offset: 0x1F07E61 VA: 0x1F07D60
	private void UpdatePlayerStatusOnTopMenu() { }

	// RVA: 0x1F0AC80 Offset: 0x1F0AD81 VA: 0x1F0AC80
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A83D0 Offset: 0x1A84D1 VA: 0x1A83D0
	// RVA: 0x1F0AD00 Offset: 0x1F0AE01 VA: 0x1F0AD00
	private void <DoTutorialCraft>b__28_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A83E0 Offset: 0x1A84E1 VA: 0x1A83E0
	// RVA: 0x1F0AD10 Offset: 0x1F0AE11 VA: 0x1F0AD10
	private void <DoSynthesis>b__29_7() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A83F0 Offset: 0x1A84F1 VA: 0x1A83F0
	// RVA: 0x1F0AD20 Offset: 0x1F0AE21 VA: 0x1F0AD20
	private void <DoSynthesis>b__29_8() { }
}


public class RecipeItemPage : UIScrollBoxBase // TypeDefIndex: 8709
{
	// Fields
	[SerializeField] // RVA: 0x172950 Offset: 0x172A51 VA: 0x172950
	private SText CategoryText; // 0x68
	[SerializeField] // RVA: 0x172960 Offset: 0x172A61 VA: 0x172960
	private UISortBlock sortBlock; // 0x70
	private bool sortRevert; // 0x78
	[SerializeField] // RVA: 0x172970 Offset: 0x172A71 VA: 0x172970
	private Text RPText; // 0x80
	[SerializeField] // RVA: 0x172980 Offset: 0x172A81 VA: 0x172980
	private CraftCategoryId CraftCategoryId; // 0x88
	private List<RecipeId> RecipeIdList; // 0x90
	[SerializeField] // RVA: 0x172990 Offset: 0x172A91 VA: 0x172990
	private GameObject CraftPageObj; // 0x98
	[SerializeField] // RVA: 0x1729A0 Offset: 0x172AA1 VA: 0x1729A0
	private CursorLinker CraftPageMainCursorPoint; // 0xA0
	[SerializeField] // RVA: 0x1729B0 Offset: 0x172AB1 VA: 0x1729B0
	private UICraftMenu UICraftMenu; // 0xA8
	[SerializeField] // RVA: 0x1729C0 Offset: 0x172AC1 VA: 0x1729C0
	private GameObject[] HideOnCraftPageObjects; // 0xB0
	private bool SortUpDown; // 0xB8
	private List<CraftCategoryId> CraftCategoryIds; // 0xC0
	[SerializeField] // RVA: 0x1729D0 Offset: 0x172AD1 VA: 0x1729D0
	private GameObject CategorySwitchButton; // 0xC8
	[SerializeField] // RVA: 0x1729E0 Offset: 0x172AE1 VA: 0x1729E0
	private RecipeMaterialSlot[] materialSlot; // 0xD0
	[SerializeField] // RVA: 0x1729F0 Offset: 0x172AF1 VA: 0x1729F0
	private UICanvasGroupAnimation recipeGroup; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x172A00 Offset: 0x172B01 VA: 0x172A00
	private CursorLinkConnector <CursorLinker>k__BackingField; // 0xE0
	private CursorLinker recipeBackLinker; // 0xE8
	[SerializeField] // RVA: 0x172A10 Offset: 0x172B11 VA: 0x172A10
	private NonFocusButton L_Button; // 0xF0
	[SerializeField] // RVA: 0x172A20 Offset: 0x172B21 VA: 0x172A20
	private NonFocusButton R_Button; // 0xF8

	// Properties
	public CursorLinkConnector CursorLinker { get; set; }
	public bool HaveRecipe { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A8160 Offset: 0x1A8261 VA: 0x1A8160
	// RVA: 0x1DADEB0 Offset: 0x1DADFB1 VA: 0x1DADEB0
	public CursorLinkConnector get_CursorLinker() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8170 Offset: 0x1A8271 VA: 0x1A8170
	// RVA: 0x1DADEC0 Offset: 0x1DADFC1 VA: 0x1DADEC0
	private void set_CursorLinker(CursorLinkConnector value) { }

	// RVA: 0x1DADD40 Offset: 0x1DADE41 VA: 0x1DADD40
	public bool get_HaveRecipe() { }

	// RVA: 0x1DADED0 Offset: 0x1DADFD1 VA: 0x1DADED0
	private void Awake() { }

	// RVA: 0x1DADFD0 Offset: 0x1DAE0D1 VA: 0x1DADFD0 Slot: 9
	protected override void Update() { }

	// RVA: 0x1DAE3B0 Offset: 0x1DAE4B1 VA: 0x1DAE3B0 Slot: 10
	protected override void OnDisable() { }

	// RVA: 0x1DAE440 Offset: 0x1DAE541 VA: 0x1DAE440
	public void InitOnInstantiate(CraftCategoryId _RecipeDataTableId, CursorLinker headBackLinker, List<CraftCategoryId> _craftCategoryIds) { }

	// RVA: 0x1DAE5A0 Offset: 0x1DAE6A1 VA: 0x1DAE5A0
	private void GenerateRecipeBlock() { }

	// RVA: 0x1DAEAA0 Offset: 0x1DAEBA1 VA: 0x1DAEAA0
	private void ChangeCategory(int movPage) { }

	// RVA: 0x1DAEC70 Offset: 0x1DAED71 VA: 0x1DAEC70
	private void ChangeCategory(CraftCategoryId _RecipeDataTableId) { }

	// RVA: 0x1DAE170 Offset: 0x1DAE271 VA: 0x1DAE170
	private void SetSort() { }

	// RVA: 0x1DADC10 Offset: 0x1DADD11 VA: 0x1DADC10
	public void SetDispBlockOnFocus(RecipeIdDispBlock _recipe) { }

	// RVA: 0x1DAB500 Offset: 0x1DAB601 VA: 0x1DAB500
	public void OpenCraftPage(RecipeIdDispBlock backLink) { }

	// RVA: 0x1DAD310 Offset: 0x1DAD411 VA: 0x1DAD310
	public bool[] HaveMaterial(RecipeId _recipe_id) { }

	// RVA: 0x1DAED50 Offset: 0x1DAEE51 VA: 0x1DAED50 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1DAEDA0 Offset: 0x1DAEEA1 VA: 0x1DAEDA0 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1DAEE60 Offset: 0x1DAEF61 VA: 0x1DAEE60 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1DAF1C0 Offset: 0x1DAF2C1 VA: 0x1DAF1C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8180 Offset: 0x1A8281 VA: 0x1A8180
	// RVA: 0x1DAF240 Offset: 0x1DAF341 VA: 0x1DAF240
	private void <Awake>b__24_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8190 Offset: 0x1A8291 VA: 0x1A8190
	// RVA: 0x1DAF2B0 Offset: 0x1DAF3B1 VA: 0x1DAF2B0
	private void <Awake>b__24_1() { }
}


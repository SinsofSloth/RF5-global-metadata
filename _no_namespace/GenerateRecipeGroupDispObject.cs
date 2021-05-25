public class GenerateRecipeGroupDispObject : UIScrollBoxBase // TypeDefIndex: 8676
{
	// Fields
	[SerializeField] // RVA: 0x172120 Offset: 0x172221 VA: 0x172120
	private Transform ItemPageParent; // 0x68
	[SerializeField] // RVA: 0x172130 Offset: 0x172231 VA: 0x172130
	private RecipeItemPage RecipeItemPage; // 0x70
	[SerializeField] // RVA: 0x172140 Offset: 0x172241 VA: 0x172140
	private GameObject MainBorder; // 0x78
	[SerializeField] // RVA: 0x172150 Offset: 0x172251 VA: 0x172150
	private GameObject RecipeDetail; // 0x80
	private List<RecipeGroupBase> recipeBases; // 0x88

	// Methods

	// RVA: 0x1E49880 Offset: 0x1E49981 VA: 0x1E49880
	private void OnEnable() { }

	// RVA: 0x1E49AC0 Offset: 0x1E49BC1 VA: 0x1E49AC0
	public void SetEnable(bool state) { }

	// RVA: 0x1E49C40 Offset: 0x1E49D41 VA: 0x1E49C40
	public void OpenRecipeItemPage(int blockId, CursorLinker backLinker) { }

	// RVA: 0x1E498E0 Offset: 0x1E499E1 VA: 0x1E498E0
	private void GetRecipeData() { }

	// RVA: 0x1E49B10 Offset: 0x1E49C11 VA: 0x1E49B10
	private void Generate() { }

	// RVA: 0x1E49D50 Offset: 0x1E49E51 VA: 0x1E49D50 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1E49DA0 Offset: 0x1E49EA1 VA: 0x1E49DA0 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1E49E70 Offset: 0x1E49F71 VA: 0x1E49E70 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1E49E80 Offset: 0x1E49F81 VA: 0x1E49E80
	public void .ctor() { }
}


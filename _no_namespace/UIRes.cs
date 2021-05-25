public class UIRes // TypeDefIndex: 8945
{
	// Fields
	private readonly MasterPreload[] TextGroupMasterPreloadID; // 0x10
	private readonly Master[] TextGroupMasterLoaderID; // 0x18
	private MonsterUIData _MonsterUIData; // 0x20
	private NPCUIData _NPCUIData; // 0x28
	private StringFormatData _ItemParameterTextFormat; // 0x30
	private StringFormatData _ItemDetailFullText; // 0x38
	private CraftCategoryDataTable _CraftCategoryDataTable; // 0x40
	private RecipeDataTableArray _RecipeData; // 0x48
	private Font font; // 0x50
	private UISystemTextData[] UISystemTextData; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x174D50 Offset: 0x174E51 VA: 0x174D50
	private SysLang <m_lang>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x174D60 Offset: 0x174E61 VA: 0x174D60
	private CharaCallTable <CharaCallTable>k__BackingField; // 0x68

	// Properties
	public MonsterUIData MonsterUIData { get; }
	public NPCUIData NPCUIData { get; }
	public StringFormatData ItemParameterTextFormat { get; }
	public StringFormatData ItemDetailFullText { get; }
	public CraftCategoryDataTable CraftCategoryData { get; }
	public RecipeDataTableArray RecipeData { get; }
	public SysLang m_lang { get; set; }
	public CharaCallTable CharaCallTable { get; set; }

	// Methods

	// RVA: 0x1DD25D0 Offset: 0x1DD26D1 VA: 0x1DD25D0
	public MonsterUIData get_MonsterUIData() { }

	// RVA: 0x1DD1B60 Offset: 0x1DD1C61 VA: 0x1DD1B60
	public string MonsterName(MonsterID monsterID) { }

	// RVA: 0x1DD26D0 Offset: 0x1DD27D1 VA: 0x1DD26D0
	public string MonsterNickName(MonsterID monsterID, int index) { }

	// RVA: 0x1DD2810 Offset: 0x1DD2911 VA: 0x1DD2810
	public string MonsterDetail(MonsterID monsterID) { }

	// RVA: 0x1DD2880 Offset: 0x1DD2981 VA: 0x1DD2880
	public NPCUIData get_NPCUIData() { }

	// RVA: 0x1DD2980 Offset: 0x1DD2A81 VA: 0x1DD2980
	public StringFormatData get_ItemParameterTextFormat() { }

	// RVA: 0x1DD2A80 Offset: 0x1DD2B81 VA: 0x1DD2A80
	public StringFormatData get_ItemDetailFullText() { }

	// RVA: 0x1DD2B80 Offset: 0x1DD2C81 VA: 0x1DD2B80
	public CraftCategoryDataTable get_CraftCategoryData() { }

	// RVA: 0x1DD2C80 Offset: 0x1DD2D81 VA: 0x1DD2C80
	public RecipeDataTableArray get_RecipeData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A92F0 Offset: 0x1A93F1 VA: 0x1A92F0
	// RVA: 0x1DD2D80 Offset: 0x1DD2E81 VA: 0x1DD2D80
	public SysLang get_m_lang() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9300 Offset: 0x1A9401 VA: 0x1A9300
	// RVA: 0x1DD2D90 Offset: 0x1DD2E91 VA: 0x1DD2D90
	private void set_m_lang(SysLang value) { }

	// RVA: 0x1DCE4C0 Offset: 0x1DCE5C1 VA: 0x1DCE4C0
	public string GetText(SysTextGroup textGroup, string textID) { }

	// RVA: 0x1DD2DA0 Offset: 0x1DD2EA1 VA: 0x1DD2DA0
	public string GetSystemText(int dicid) { }

	// RVA: 0x1DD1BD0 Offset: 0x1DD1CD1 VA: 0x1DD1BD0
	public string GetSystemText(UITextDic.DICID dicid) { }

	// RVA: 0x1DD30D0 Offset: 0x1DD31D1 VA: 0x1DD30D0
	private string GetNpcName(int baseId) { }

	// RVA: 0x1DD3310 Offset: 0x1DD3411 VA: 0x1DD3310
	private string GetNpcDiscript(int baseId) { }

	// RVA: 0x1DD1A90 Offset: 0x1DD1B91 VA: 0x1DD1A90
	public string GetText(SysTextGroup textGroup, int textID) { }

	// RVA: 0x1DD31D0 Offset: 0x1DD32D1 VA: 0x1DD31D0
	public string GetTextByIndex(int textGroup, int textID) { }

	// RVA: 0x1DD2F10 Offset: 0x1DD3011 VA: 0x1DD2F10
	private void LoadUITextResource(int textGroup) { }

	// RVA: 0x1DD3570 Offset: 0x1DD3671 VA: 0x1DD3570
	private void LoadUITextResource() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9310 Offset: 0x1A9411 VA: 0x1A9310
	// RVA: 0x1DD3620 Offset: 0x1DD3721 VA: 0x1DD3620
	public CharaCallTable get_CharaCallTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9320 Offset: 0x1A9421 VA: 0x1A9320
	// RVA: 0x1DD3630 Offset: 0x1DD3731 VA: 0x1DD3630
	private void set_CharaCallTable(CharaCallTable value) { }

	// RVA: 0x1DD3640 Offset: 0x1DD3741 VA: 0x1DD3640
	public void ReleaseResource() { }

	// RVA: 0x1DD36C0 Offset: 0x1DD37C1 VA: 0x1DD36C0
	public void .ctor() { }

	// RVA: 0x1DD3880 Offset: 0x1DD3981 VA: 0x1DD3880 Slot: 1
	protected override void Finalize() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9330 Offset: 0x1A9431 VA: 0x1A9330
	// RVA: 0x1DD3950 Offset: 0x1DD3A51 VA: 0x1DD3950
	private void <.ctor>b__43_0(AssetHandle<Font> handle) { }
}


public class SeasonManager : SingletonMonoBehaviour<SeasonManager> // TypeDefIndex: 7474
{
	// Fields
	private readonly string SeasonTerrainTextureSearchString; // 0x18
	[SerializeField] // RVA: 0x1669F0 Offset: 0x166AF1 VA: 0x1669F0
	private Season _Season; // 0x20
	public Season RequestSeason; // 0x24
	[SerializeField] // RVA: 0x166A00 Offset: 0x166B01 VA: 0x166A00
	private SeasonMaterialDataTableArray _SeasonMaterialDataTableArray; // 0x28
	[SerializeField] // RVA: 0x166A10 Offset: 0x166B11 VA: 0x166A10
	private SeasonTextureDataTableArray _SeasonTextureDataTableArray; // 0x30
	[SerializeField] // RVA: 0x166A20 Offset: 0x166B21 VA: 0x166A20
	private SeasonTextureDataTableArray _SeasonTerrainTextureDataTableArray; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x166A30 Offset: 0x166B31 VA: 0x166A30
	private HashSet<SeasonChangeObject> <ChangeTextureObjectHashSet>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x166A40 Offset: 0x166B41 VA: 0x166A40
	private HashSet<SeasonChangeObject> <ChangeTerrainObjectHashSet>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x166A50 Offset: 0x166B51 VA: 0x166A50
	private HashSet<SeasonVisibleObject>[] <ChangeVisibleObjectHashSet>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x166A60 Offset: 0x166B61 VA: 0x166A60
	private Dictionary<int, TextureChangeMaterialParam> <TextureChangeMaterialDictinary>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x166A70 Offset: 0x166B71 VA: 0x166A70
	private HashSet<Material> <ApplyMaterialHashSet>k__BackingField; // 0x60
	private Dictionary<Texture, Texture> _LoadTextureDictinary; // 0x68
	private Dictionary<string, Material> _LoadMaterialDictinary; // 0x70
	private bool[] _LoadedSeason; // 0x78
	private bool[] _LoadedSeasonMaterial; // 0x80
	private bool IsLoadEnd; // 0x88
	private bool PrevFade; // 0x89
	private bool PrevPause; // 0x8A

	// Properties
	public Season Season { get; set; }
	public SeasonMaterialDataTableArray SeasonMaterialDataTableArray { get; }
	public SeasonTextureDataTableArray SeasonTextureDataTableArray { get; }
	public SeasonTextureDataTableArray SeasonTerrainTextureDataTableArray { get; }
	public HashSet<SeasonChangeObject> ChangeTextureObjectHashSet { get; set; }
	public HashSet<SeasonChangeObject> ChangeTerrainObjectHashSet { get; set; }
	public HashSet<SeasonVisibleObject>[] ChangeVisibleObjectHashSet { get; set; }
	private Dictionary<int, TextureChangeMaterialParam> TextureChangeMaterialDictinary { get; set; }
	private HashSet<Material> ApplyMaterialHashSet { get; set; }
	public Dictionary<Texture, Texture> LoadTextureDictinary { get; }
	public Dictionary<string, Material> LoadMaterialDictinary { get; }

	// Methods

	// RVA: 0x1C82E80 Offset: 0x1C82F81 VA: 0x1C82E80
	public Season get_Season() { }

	// RVA: 0x1C82E90 Offset: 0x1C82F91 VA: 0x1C82E90
	public void set_Season(Season value) { }

	// RVA: 0x1C82EA0 Offset: 0x1C82FA1 VA: 0x1C82EA0
	public SeasonMaterialDataTableArray get_SeasonMaterialDataTableArray() { }

	// RVA: 0x1C82EB0 Offset: 0x1C82FB1 VA: 0x1C82EB0
	public SeasonTextureDataTableArray get_SeasonTextureDataTableArray() { }

	// RVA: 0x1C82EC0 Offset: 0x1C82FC1 VA: 0x1C82EC0
	public SeasonTextureDataTableArray get_SeasonTerrainTextureDataTableArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A10D0 Offset: 0x1A11D1 VA: 0x1A10D0
	// RVA: 0x1C82ED0 Offset: 0x1C82FD1 VA: 0x1C82ED0
	public HashSet<SeasonChangeObject> get_ChangeTextureObjectHashSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A10E0 Offset: 0x1A11E1 VA: 0x1A10E0
	// RVA: 0x1C82EE0 Offset: 0x1C82FE1 VA: 0x1C82EE0
	public void set_ChangeTextureObjectHashSet(HashSet<SeasonChangeObject> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A10F0 Offset: 0x1A11F1 VA: 0x1A10F0
	// RVA: 0x1C82EF0 Offset: 0x1C82FF1 VA: 0x1C82EF0
	public HashSet<SeasonChangeObject> get_ChangeTerrainObjectHashSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1100 Offset: 0x1A1201 VA: 0x1A1100
	// RVA: 0x1C82F00 Offset: 0x1C83001 VA: 0x1C82F00
	public void set_ChangeTerrainObjectHashSet(HashSet<SeasonChangeObject> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1110 Offset: 0x1A1211 VA: 0x1A1110
	// RVA: 0x1C82F10 Offset: 0x1C83011 VA: 0x1C82F10
	public HashSet<SeasonVisibleObject>[] get_ChangeVisibleObjectHashSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1120 Offset: 0x1A1221 VA: 0x1A1120
	// RVA: 0x1C82F20 Offset: 0x1C83021 VA: 0x1C82F20
	public void set_ChangeVisibleObjectHashSet(HashSet<SeasonVisibleObject>[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1130 Offset: 0x1A1231 VA: 0x1A1130
	// RVA: 0x1C82F30 Offset: 0x1C83031 VA: 0x1C82F30
	private Dictionary<int, TextureChangeMaterialParam> get_TextureChangeMaterialDictinary() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1140 Offset: 0x1A1241 VA: 0x1A1140
	// RVA: 0x1C82F40 Offset: 0x1C83041 VA: 0x1C82F40
	private void set_TextureChangeMaterialDictinary(Dictionary<int, TextureChangeMaterialParam> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1150 Offset: 0x1A1251 VA: 0x1A1150
	// RVA: 0x1C82F50 Offset: 0x1C83051 VA: 0x1C82F50
	private HashSet<Material> get_ApplyMaterialHashSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1160 Offset: 0x1A1261 VA: 0x1A1160
	// RVA: 0x1C82F60 Offset: 0x1C83061 VA: 0x1C82F60
	private void set_ApplyMaterialHashSet(HashSet<Material> value) { }

	// RVA: 0x1C82F70 Offset: 0x1C83071 VA: 0x1C82F70
	public Dictionary<Texture, Texture> get_LoadTextureDictinary() { }

	// RVA: 0x1C82F80 Offset: 0x1C83081 VA: 0x1C82F80
	public Dictionary<string, Material> get_LoadMaterialDictinary() { }

	// RVA: 0x1C82AC0 Offset: 0x1C82BC1 VA: 0x1C82AC0
	public void AddChangeObject(SeasonChangeObject obj) { }

	// RVA: 0x1C82C90 Offset: 0x1C82D91 VA: 0x1C82C90
	public void RemoveChangeObject(SeasonChangeObject obj) { }

	// RVA: 0x1C82F90 Offset: 0x1C83091 VA: 0x1C82F90
	public void AddChangeObject(SeasonVisibleObject obj) { }

	// RVA: 0x1C83030 Offset: 0x1C83131 VA: 0x1C83030
	public void RemoveChangeObject(SeasonVisibleObject obj) { }

	// RVA: 0x1C830D0 Offset: 0x1C831D1 VA: 0x1C830D0
	private void OnDestroy() { }

	// RVA: 0x1C830E0 Offset: 0x1C831E1 VA: 0x1C830E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1C832A0 Offset: 0x1C833A1 VA: 0x1C832A0
	private void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1170 Offset: 0x1A1271 VA: 0x1A1170
	// RVA: 0x1C83E10 Offset: 0x1C83F11 VA: 0x1C83E10
	public IEnumerator OnSceneChangeSeason() { }

	// RVA: 0x1C83EC0 Offset: 0x1C83FC1 VA: 0x1C83EC0
	private void OnSeasonChange(int elapsedSeason) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A11E0 Offset: 0x1A12E1 VA: 0x1A11E0
	// RVA: 0x1C84070 Offset: 0x1C84171 VA: 0x1C84070
	public IEnumerator SeasonChangeLoad(Season season) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1250 Offset: 0x1A1351 VA: 0x1A1250
	// RVA: 0x1C84100 Offset: 0x1C84201 VA: 0x1C84100
	public IEnumerator SeasonChangeFade(Season season) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A12C0 Offset: 0x1A13C1 VA: 0x1A12C0
	// RVA: 0x1C83CF0 Offset: 0x1C83DF1 VA: 0x1C83CF0
	public IEnumerator LoadTexture(Season loadSeason) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1330 Offset: 0x1A1431 VA: 0x1A1330
	// RVA: 0x1C83D80 Offset: 0x1C83E81 VA: 0x1C83D80
	public IEnumerator LoadTerrainTexture(Season loadSeason) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A13A0 Offset: 0x1A14A1 VA: 0x1A13A0
	// RVA: 0x1C84250 Offset: 0x1C84351 VA: 0x1C84250
	public IEnumerator LoadTexture(Season loadSeason, Dictionary<string, Texture[]> seasonTextureTable, Dictionary<Texture, Texture> loadTextureDict) { }

	// RVA: 0x1C84320 Offset: 0x1C84421 VA: 0x1C84320
	public void UnloadTexture(Season useSeason) { }

	// RVA: 0x1C84650 Offset: 0x1C84751 VA: 0x1C84650
	public void UnloadTerrainTexture(Season useSeason) { }

	// RVA: 0x1C843A0 Offset: 0x1C844A1 VA: 0x1C843A0
	public void UnloadTexture(Season useSeason, Dictionary<string, Texture[]> seasonTextureTable, Dictionary<Texture, Texture> loadTextureDict) { }

	// RVA: 0x1C84670 Offset: 0x1C84771 VA: 0x1C84670
	public void ChangeMaterialTexture(Season setSeason) { }

	// RVA: 0x1C84770 Offset: 0x1C84871 VA: 0x1C84770
	public void ChangeMaterialTexture(Season setSeason, SeasonChangeObject changeObject) { }

	// RVA: 0x1C84B30 Offset: 0x1C84C31 VA: 0x1C84B30
	public void ChangeTerrainTexture(Season setSeason) { }

	// RVA: 0x1C84C30 Offset: 0x1C84D31 VA: 0x1C84C30
	public void ChangeTerrainTexture(Season setSeason, SeasonChangeObject changeObject) { }

	// RVA: 0x1C82B80 Offset: 0x1C82C81 VA: 0x1C82B80
	public void ChangeSeasonObject(SeasonChangeObject changeObject) { }

	// RVA: 0x1C84EE0 Offset: 0x1C84FE1 VA: 0x1C84EE0
	public void ChangeVisibleObject(Season setSeason) { }

	// RVA: 0x1C85070 Offset: 0x1C85171 VA: 0x1C85070
	public void ChangeSeasonObject(SeasonVisibleObject changeObject) { }

	// RVA: 0x1C85160 Offset: 0x1C85261 VA: 0x1C85160
	public void ChangeVisibleObject(Season setSeason, SeasonVisibleObject changeObject) { }

	// RVA: 0x1C851F0 Offset: 0x1C852F1 VA: 0x1C851F0
	public void AfterLoadGameData() { }

	// RVA: 0x1C85330 Offset: 0x1C85431 VA: 0x1C85330
	public void .ctor() { }
}


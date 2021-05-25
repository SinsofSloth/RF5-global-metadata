public class FurnitureManager : SingletonMonoBehaviour<FurnitureManager> // TypeDefIndex: 10265
{
	// Fields
	public int NotEntryPetIndex; // 0x18
	public bool GramophoneBgmPlay; // 0x1C
	[SerializeField] // RVA: 0x180AD0 Offset: 0x180BD1 VA: 0x180AD0
	private FurnitureShadow furnitureShadow; // 0x20
	private PlayerItemFurniture2 playerItemFurniture2; // 0x28
	private FurnitureBlock furnitureBlock; // 0x30
	[HideInInspector] // RVA: 0x180AE0 Offset: 0x180BE1 VA: 0x180AE0
	public FlyingNimbus flyingNimbus; // 0x38
	private List<PlayerItemFurniture2> FurnitureObjectList; // 0x40
	private FurnitureManager.SendPos[] sendpos_tbl_; // 0x48
	private List<VariationNo> CostumeList; // 0x50
	private List<string> SelectStringList; // 0x58
	private int WhoCostumeChange; // 0x60
	private bool[] HaveCostume; // 0x68
	private List<BgmList> RecordList; // 0x70
	public FurnitureID CreateId; // 0x78
	private List<GameObject> SameRoomFurnitureList; // 0x80
	[SerializeField] // RVA: 0x180AF0 Offset: 0x180BF1 VA: 0x180AF0
	[RangeAttribute] // RVA: 0x180AF0 Offset: 0x180BF1 VA: 0x180AF0
	[HeaderAttribute] // RVA: 0x180AF0 Offset: 0x180BF1 VA: 0x180AF0
	public float ShadowHeight; // 0x88
	[SerializeField] // RVA: 0x180B60 Offset: 0x180C61 VA: 0x180B60
	[RangeAttribute] // RVA: 0x180B60 Offset: 0x180C61 VA: 0x180B60
	[HeaderAttribute] // RVA: 0x180B60 Offset: 0x180C61 VA: 0x180B60
	public float ShadowStep; // 0x8C
	[SerializeField] // RVA: 0x180BD0 Offset: 0x180CD1 VA: 0x180BD0
	[RangeAttribute] // RVA: 0x180BD0 Offset: 0x180CD1 VA: 0x180BD0
	[HeaderAttribute] // RVA: 0x180BD0 Offset: 0x180CD1 VA: 0x180BD0
	public float Thunderbolt_Short_or_Long; // 0x90
	[SerializeField] // RVA: 0x180C40 Offset: 0x180D41 VA: 0x180C40
	[RangeAttribute] // RVA: 0x180C40 Offset: 0x180D41 VA: 0x180C40
	public float Thunderbolt_Damage_Interval; // 0x94

	// Properties
	private string GetZenin { get; }
	private string GetYameru { get; }
	public FurnitureShadow FurnitureShadow { get; }
	public PlayerItemFurniture2 PlayerItemFurniture2 { get; set; }

	// Methods

	// RVA: 0x1F31280 Offset: 0x1F31381 VA: 0x1F31280
	public void ClearGramophoneBgmPlay() { }

	// RVA: 0x1F31290 Offset: 0x1F31391 VA: 0x1F31290
	public bool IsGramophone() { }

	// RVA: 0x1F31490 Offset: 0x1F31591 VA: 0x1F31490
	private string get_GetZenin() { }

	// RVA: 0x1F31580 Offset: 0x1F31681 VA: 0x1F31580
	private string get_GetYameru() { }

	// RVA: 0x1F31670 Offset: 0x1F31771 VA: 0x1F31670
	private string GetCharaterName(ActorID actorID) { }

	// RVA: 0x1F317E0 Offset: 0x1F318E1 VA: 0x1F317E0
	public FurnitureShadow get_FurnitureShadow() { }

	// RVA: 0x1F317F0 Offset: 0x1F318F1 VA: 0x1F317F0
	public PlayerItemFurniture2 get_PlayerItemFurniture2() { }

	// RVA: 0x1F31800 Offset: 0x1F31901 VA: 0x1F31800
	public void set_PlayerItemFurniture2(PlayerItemFurniture2 value) { }

	// RVA: 0x1F31810 Offset: 0x1F31911 VA: 0x1F31810
	public void SetFurnitureBlock(FurnitureBlock block) { }

	// RVA: 0x1F31820 Offset: 0x1F31921 VA: 0x1F31820
	public void SetFlyingNimbus(FlyingNimbus nimbus) { }

	// RVA: 0x1F31830 Offset: 0x1F31931 VA: 0x1F31830
	public bool IsFlyingNimbusRide() { }

	// RVA: 0x1F318D0 Offset: 0x1F319D1 VA: 0x1F318D0
	private void WarpFlyingNimbus() { }

	// RVA: 0x1F31AC0 Offset: 0x1F31BC1 VA: 0x1F31AC0
	private void FlyingNimbusSaveBlock(bool enable) { }

	// RVA: 0x1F31BA0 Offset: 0x1F31CA1 VA: 0x1F31BA0
	private void Start() { }

	// RVA: 0x1F31CC0 Offset: 0x1F31DC1 VA: 0x1F31CC0
	private void OnSceneLoadComplete() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADC30 Offset: 0x1ADD31 VA: 0x1ADC30
	// RVA: 0x1F31D50 Offset: 0x1F31E51 VA: 0x1F31D50
	private IEnumerator OnSceneLoad() { }

	// RVA: 0x1F31E00 Offset: 0x1F31F01 VA: 0x1F31E00
	private bool CheckSameScene(FieldSceneId _furniture_scene) { }

	// RVA: 0x1F31EF0 Offset: 0x1F31FF1 VA: 0x1F31EF0
	private void Update() { }

	// RVA: 0x1F31FA0 Offset: 0x1F320A1 VA: 0x1F31FA0
	private void UpdateHide() { }

	// RVA: 0x1F320B0 Offset: 0x1F321B1 VA: 0x1F320B0
	public void AddObject(PlayerItemFurniture2 furniture) { }

	// RVA: 0x1F32120 Offset: 0x1F32221 VA: 0x1F32120
	public void RemoveObject(PlayerItemFurniture2 furniture) { }

	// RVA: 0x1F32190 Offset: 0x1F32291 VA: 0x1F32190
	private bool IsCreate(string guid) { }

	// RVA: 0x1F322C0 Offset: 0x1F323C1 VA: 0x1F322C0
	public int Count() { }

	// RVA: 0x1F322F0 Offset: 0x1F323F1 VA: 0x1F322F0
	public bool IsBreak() { }

	// RVA: 0x1F32320 Offset: 0x1F32421 VA: 0x1F32320
	private void SetFurniture(FurnitureSaveData newdata, bool is_reserve = False) { }

	// RVA: 0x1F32370 Offset: 0x1F32471 VA: 0x1F32370
	public bool IsMax() { }

	// RVA: 0x1F323A0 Offset: 0x1F324A1 VA: 0x1F323A0
	public bool IsCreate(FurnitureCreatePoint point) { }

	// RVA: 0x1F323E0 Offset: 0x1F324E1 VA: 0x1F323E0
	public void Send(FurnitureCreatePoint point, FurnitureID id, bool create = True, bool is_reserve = False, bool sound_se = False) { }

	// RVA: 0x1F329D0 Offset: 0x1F32AD1 VA: 0x1F329D0
	public void Create(FurnitureID id) { }

	// RVA: 0x1F32C00 Offset: 0x1F32D01 VA: 0x1F32C00
	public void Create(FurnitureID id, Vector3 pos, float ry, FieldSceneId fieldSceneId, bool create = False, bool effect = False, bool is_reserve = False) { }

	// RVA: 0x1F32ED0 Offset: 0x1F32FD1 VA: 0x1F32ED0
	public void CreateHave(FurnitureID id) { }

	// RVA: 0x1F331C0 Offset: 0x1F332C1 VA: 0x1F331C0
	public void HaveFanitureReload() { }

	// RVA: 0x1F33470 Offset: 0x1F33571 VA: 0x1F33470
	public void HaveSaveData(string guid) { }

	// RVA: 0x1F334B0 Offset: 0x1F335B1 VA: 0x1F334B0
	public void RemoveSave(string guid) { }

	// RVA: 0x1F33530 Offset: 0x1F33631 VA: 0x1F33530
	public int GetFurnitureCount(FurnitureID furnitureId) { }

	// RVA: 0x1F33570 Offset: 0x1F33671 VA: 0x1F33570
	public void AllBreak() { }

	// RVA: 0x1F336D0 Offset: 0x1F337D1 VA: 0x1F336D0
	public void OnPutSave(string guid, Vector3 pos, Quaternion rot) { }

	// RVA: 0x1F32860 Offset: 0x1F32961 VA: 0x1F32860
	private void Create(int PrefabId, Vector3 pos, Quaternion rot, string unique_id, int hp, Action<PlayerItemFurniture2> callback, bool effect = False) { }

	// RVA: 0x1F33780 Offset: 0x1F33881 VA: 0x1F33780
	private void Craft(CraftCategoryId category) { }

	// RVA: 0x1F33960 Offset: 0x1F33A61 VA: 0x1F33960
	private void OpenStorage(UILoader.ObjectNumber storage) { }

	// RVA: 0x1F33AB0 Offset: 0x1F33BB1 VA: 0x1F33AB0
	public void Command(int cmd_id, int para1, int para2, Action callback) { }

	// RVA: 0x1F36180 Offset: 0x1F36281 VA: 0x1F36180
	private void SekizaiMokuzaiPopAll() { }

	// RVA: 0x1F363B0 Offset: 0x1F364B1 VA: 0x1F363B0
	private void WeedPopAll() { }

	// RVA: 0x1F365A0 Offset: 0x1F366A1 VA: 0x1F365A0
	private void GrassPopAll() { }

	// RVA: 0x1F36970 Offset: 0x1F36A71 VA: 0x1F36970
	public void SetHaveCostume() { }

	// RVA: 0x1F36DA0 Offset: 0x1F36EA1 VA: 0x1F36DA0
	private void CostumeChange(ActorID actorId = 0, ActorType actorType = 1, CharID charId = 0, VariationNo variationNo = 0, HairType hairType = 0) { }

	// RVA: 0x1F35DB0 Offset: 0x1F35EB1 VA: 0x1F35DB0
	private void PlayerCostumeChange(VariationNo variationNo = 0) { }

	// RVA: 0x1F35E40 Offset: 0x1F35F41 VA: 0x1F35E40
	private void PartyCostumeChange(int num, VariationNo variationNo = 0) { }

	// RVA: 0x1F36EE0 Offset: 0x1F36FE1 VA: 0x1F36EE0
	private void GetList(CharID charId, HairType hairType = 0) { }

	// RVA: 0x1F35940 Offset: 0x1F35A41 VA: 0x1F35940
	private void GetCostumeListString(CharID charID = 0, HairType hairType = 0) { }

	// RVA: 0x1F31AD0 Offset: 0x1F31BD1 VA: 0x1F31AD0
	private int GetPartyNum_Nimbus() { }

	// RVA: 0x1F35BB0 Offset: 0x1F35CB1 VA: 0x1F35BB0
	private int GetPartyNum() { }

	// RVA: 0x1F35600 Offset: 0x1F35701 VA: 0x1F35600
	private void GetPartyString() { }

	// RVA: 0x1F35CA0 Offset: 0x1F35DA1 VA: 0x1F35CA0
	private CharID GetPartyCharID(int num) { }

	// RVA: 0x1F36E40 Offset: 0x1F36F41 VA: 0x1F36E40
	private bool IsActiveVariation(CharID charID, VariationNo variationNo) { }

	// RVA: 0x1F37250 Offset: 0x1F37351 VA: 0x1F37250
	private bool CheckAndCreateWardrobe(FieldSceneId sceneId) { }

	// RVA: 0x1F373D0 Offset: 0x1F374D1 VA: 0x1F373D0
	private static bool CheckDLCWithDLCCosutume() { }

	// RVA: 0x1F37490 Offset: 0x1F37591 VA: 0x1F37490
	public bool CreateWardrobe(FurnitureCreatePoint point = 0, FurnitureID id = 20, bool create = False) { }

	// RVA: 0x1F35810 Offset: 0x1F35911 VA: 0x1F35810
	private void SelectList(List<string> selectList, int select_jump_no, int return_jump_no) { }

	// RVA: 0x1F360D0 Offset: 0x1F361D1 VA: 0x1F360D0
	private void PlayBgm(BGMID id) { }

	// RVA: 0x1F37550 Offset: 0x1F37651 VA: 0x1F37550
	private void ReturnScript(string script_name) { }

	// RVA: 0x1F375D0 Offset: 0x1F376D1 VA: 0x1F375D0
	private void CallScript(string script_name) { }

	// RVA: 0x1F37390 Offset: 0x1F37491 VA: 0x1F37390
	public static bool CheckHadFurniture(FurnitureID id) { }

	// RVA: 0x1F37670 Offset: 0x1F37771 VA: 0x1F37670
	public List<GameObject> GetSameRoomFurniture(FieldSceneId fieldSceneId) { }

	// RVA: 0x1F379A0 Offset: 0x1F37AA1 VA: 0x1F379A0
	public void UpdateMeshShadow(Func<float, bool> checkEnableShadowFunc) { }

	// RVA: 0x1F37CC0 Offset: 0x1F37DC1 VA: 0x1F37CC0
	public void ResetMeshShadow() { }

	// RVA: 0x1F37E80 Offset: 0x1F37F81 VA: 0x1F37E80
	public void ShippingBoxShake() { }

	// RVA: 0x1F380B0 Offset: 0x1F381B1 VA: 0x1F380B0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADCA0 Offset: 0x1ADDA1 VA: 0x1ADCA0
	// RVA: 0x1F385B0 Offset: 0x1F386B1 VA: 0x1F385B0
	private void <Create>b__42_0(PlayerItemFurniture2 obj) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADCB0 Offset: 0x1ADDB1 VA: 0x1ADCB0
	// RVA: 0x1F38620 Offset: 0x1F38721 VA: 0x1F38620
	private void <CreateHave>b__43_0(PlayerItemFurniture2 obj) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADCC0 Offset: 0x1ADDC1 VA: 0x1ADCC0
	// RVA: 0x1F38740 Offset: 0x1F38841 VA: 0x1F38740
	private void <HaveFanitureReload>b__44_0(PlayerItemFurniture2 obj) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADCD0 Offset: 0x1ADDD1 VA: 0x1ADCD0
	// RVA: 0x1F387C0 Offset: 0x1F388C1 VA: 0x1F387C0
	private void <Command>b__53_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADCE0 Offset: 0x1ADDE1 VA: 0x1ADCE0
	// RVA: 0x1F38810 Offset: 0x1F38911 VA: 0x1F38810
	private void <Command>b__53_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADCF0 Offset: 0x1ADDF1 VA: 0x1ADCF0
	// RVA: 0x1F38860 Offset: 0x1F38961 VA: 0x1F38860
	private void <Command>b__53_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADD00 Offset: 0x1ADE01 VA: 0x1ADD00
	// RVA: 0x1F38900 Offset: 0x1F38A01 VA: 0x1F38900
	private void <Command>b__53_5() { }
}


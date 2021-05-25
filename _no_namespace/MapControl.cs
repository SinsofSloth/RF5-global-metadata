public class MapControl : MonoBehaviour // TypeDefIndex: 8586
{
	// Fields
	[SerializeField] // RVA: 0x170D90 Offset: 0x170E91 VA: 0x170D90
	private RectTransform MapObjectsRect; // 0x18
	[SerializeField] // RVA: 0x170DA0 Offset: 0x170EA1 VA: 0x170DA0
	private RectTransform MainMap; // 0x20
	[SerializeField] // RVA: 0x170DB0 Offset: 0x170EB1 VA: 0x170DB0
	private RectTransform PlayerIcon; // 0x28
	[SerializeField] // RVA: 0x170DC0 Offset: 0x170EC1 VA: 0x170DC0
	private Transform NPCIconParents; // 0x30
	[SerializeField] // RVA: 0x170DD0 Offset: 0x170ED1 VA: 0x170DD0
	private Transform IconParents; // 0x38
	[SerializeField] // RVA: 0x170DE0 Offset: 0x170EE1 VA: 0x170DE0
	private Transform EventIconParents; // 0x40
	[SerializeField] // RVA: 0x170DF0 Offset: 0x170EF1 VA: 0x170DF0
	private RectTransform NpcImage; // 0x48
	[SerializeField] // RVA: 0x170E00 Offset: 0x170F01 VA: 0x170E00
	private RectTransform PartnerImage; // 0x50
	[SerializeField] // RVA: 0x170E10 Offset: 0x170F11 VA: 0x170E10
	private GameObject BuildImage; // 0x58
	[SerializeField] // RVA: 0x170E20 Offset: 0x170F21 VA: 0x170E20
	private GameObject WarpImage; // 0x60
	[SerializeField] // RVA: 0x170E30 Offset: 0x170F31 VA: 0x170E30
	private UIObjectLoadingCheck checkLoad; // 0x68
	[SerializeField] // RVA: 0x170E40 Offset: 0x170F41 VA: 0x170E40
	private Text MapNameText; // 0x70
	[SerializeField] // RVA: 0x170E50 Offset: 0x170F51 VA: 0x170E50
	private Image MapNameImg; // 0x78
	private RectTransform[] MapNPCPoitnList; // 0x80
	private RectTransform[] NPCMapRect; // 0x88
	private RectTransform[] PartnerMapRect; // 0x90
	private RectTransform[] FriMonMapRect; // 0x98
	private RectTransform[] QuestMapRect; // 0xA0
	private RectTransform[] MobMapRect; // 0xA8
	private GameObject[] BuildMapObj; // 0xB0
	private RectTransform[] BuildObjRect; // 0xB8
	private BuildIconControl[] BuildMapIconCtrl; // 0xC0
	private GameObject[] WarpMapObj; // 0xC8
	private RectTransform[] WarpObjRect; // 0xD0
	private WarpIconControl[] WarpMapIconCtrl; // 0xD8
	private List<WarpPoints.WarpPoint> WarpableList; // 0xE0
	private List<WarpPoints.WarpPoint> WarpableFloorList; // 0xE8
	private List<WarpPoints.WarpPoint> WarpableGuideList; // 0xF0
	[SerializeField] // RVA: 0x170E60 Offset: 0x170F61 VA: 0x170E60
	private BuildWindowController buildWindowController; // 0xF8
	[SerializeField] // RVA: 0x170E70 Offset: 0x170F71 VA: 0x170E70
	private Sprite homeIcon; // 0x100
	[SerializeField] // RVA: 0x170E80 Offset: 0x170F81 VA: 0x170E80
	private RectTransform NewMapRect; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x170E90 Offset: 0x170F91 VA: 0x170E90
	private bool <IsActiveInput>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x170EA0 Offset: 0x170FA1 VA: 0x170EA0
	private bool <IsEndFirstInput>k__BackingField; // 0x111
	[CompilerGeneratedAttribute] // RVA: 0x170EB0 Offset: 0x170FB1 VA: 0x170EB0
	private bool <IsWarpHold>k__BackingField; // 0x112
	private MapShaderController ShaderCtrl; // 0x118
	private GameObject mapPrefab; // 0x120
	private MapControl.MapCntlStep step; // 0x128
	private float MapScale; // 0x12C
	private Vector2 MapScaleSize; // 0x130
	private Vector2 MaxMapPos; // 0x138
	private float mapBaseSize; // 0x140
	private Vector2 ScreenSize; // 0x144
	private const int BuildMax = 25;
	private string currentSceneName; // 0x150
	private FieldSceneId currentFieldId; // 0x158
	private string FieldSceneName; // 0x160
	private MapControl.MapMode mapMode; // 0x168
	private bool fieldFlg; // 0x16C
	private Vector3 cursorPos; // 0x170
	private static int NPCMax; // 0x0
	private int[,] buildNPCList; // 0x180
	private int[] buildNPCCnt; // 0x188
	private int warpObjVal; // 0x190
	private int OldHitObjNo; // 0x194
	private int HitObjNo; // 0x198
	private int isWarpHoldNo; // 0x19C
	private Vector3 HitObjPos; // 0x1A0
	public static byte[] maskBuff; // 0x8
	private int mapDataId; // 0x1AC
	private int mapFloorNo; // 0x1B0
	private int loadPrefabId; // 0x1B4
	private int nowFileNo; // 0x1B8
	private bool monsterHutFlg; // 0x1BC
	[CompilerGeneratedAttribute] // RVA: 0x170EC0 Offset: 0x170FC1 VA: 0x170EC0
	private static int <MapGuideID>k__BackingField; // 0x10
	private string guideSystemTextId; // 0x1C0
	private float guideTime; // 0x1C8
	private bool guideNewFlg; // 0x1CC
	private float guideNewTime; // 0x1D0
	private float guideNewScale; // 0x1D4
	[CompilerGeneratedAttribute] // RVA: 0x170ED0 Offset: 0x170FD1 VA: 0x170ED0
	private int <MapInfoID>k__BackingField; // 0x1D8
	private float infoMoveSpeed; // 0x1DC
	private Vector2 infoStartPoint; // 0x1E0
	private Vector2 infoEndPoint; // 0x1E8
	private float infoDistance; // 0x1F0
	private float infoStartTime; // 0x1F4
	private float infoScrollTime; // 0x1F8
	private List<QuestIconData> questIconList; // 0x200
	private Vector3 NpcIconScale; // 0x208
	private Vector3 FriIconScale; // 0x214
	private Vector3 MobIconScale; // 0x220
	private Vector3 PlyrIconScale; // 0x22C
	private Vector3 WarpIconScale; // 0x238
	private Vector3 WarpDiaIconScale; // 0x244
	private Vector3 WarpFDIconScale; // 0x250
	private Vector3 BuildIconScale; // 0x25C
	private Vector3 QuestIconScale; // 0x268
	private Vector3 NewIconScale; // 0x274
	private static readonly int[] FieldPrefabIds; // 0x18

	// Properties
	public bool IsActiveInput { get; set; }
	public bool IsEndFirstInput { get; set; }
	public bool IsWarpHold { get; set; }
	public static int MapGuideID { get; set; }
	private int MapInfoID { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7CE0 Offset: 0x1A7DE1 VA: 0x1A7CE0
	// RVA: 0x1E13070 Offset: 0x1E13171 VA: 0x1E13070
	public bool get_IsActiveInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7CF0 Offset: 0x1A7DF1 VA: 0x1A7CF0
	// RVA: 0x1E13080 Offset: 0x1E13181 VA: 0x1E13080
	public void set_IsActiveInput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7D00 Offset: 0x1A7E01 VA: 0x1A7D00
	// RVA: 0x1E13090 Offset: 0x1E13191 VA: 0x1E13090
	public bool get_IsEndFirstInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7D10 Offset: 0x1A7E11 VA: 0x1A7D10
	// RVA: 0x1E130A0 Offset: 0x1E131A1 VA: 0x1E130A0
	public void set_IsEndFirstInput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7D20 Offset: 0x1A7E21 VA: 0x1A7D20
	// RVA: 0x1E130B0 Offset: 0x1E131B1 VA: 0x1E130B0
	public bool get_IsWarpHold() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7D30 Offset: 0x1A7E31 VA: 0x1A7D30
	// RVA: 0x1E130C0 Offset: 0x1E131C1 VA: 0x1E130C0
	public void set_IsWarpHold(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7D40 Offset: 0x1A7E41 VA: 0x1A7D40
	// RVA: 0x1E130D0 Offset: 0x1E131D1 VA: 0x1E130D0
	public static int get_MapGuideID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7D50 Offset: 0x1A7E51 VA: 0x1A7D50
	// RVA: 0x1E13140 Offset: 0x1E13241 VA: 0x1E13140
	public static void set_MapGuideID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7D60 Offset: 0x1A7E61 VA: 0x1A7D60
	// RVA: 0x1E131B0 Offset: 0x1E132B1 VA: 0x1E131B0
	private int get_MapInfoID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7D70 Offset: 0x1A7E71 VA: 0x1A7D70
	// RVA: 0x1E131C0 Offset: 0x1E132C1 VA: 0x1E131C0
	private void set_MapInfoID(int value) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A7D80 Offset: 0x1A7E81 VA: 0x1A7D80
	// RVA: 0x1E131D0 Offset: 0x1E132D1 VA: 0x1E131D0
	private IEnumerator createMap(int id) { }

	// RVA: 0x1E13290 Offset: 0x1E13391 VA: 0x1E13290
	private void LoadMap(FieldSceneId fieldId) { }

	// RVA: 0x1E140A0 Offset: 0x1E141A1 VA: 0x1E140A0
	private int getMonsterHutDataID(FieldSceneId fieldId) { }

	// RVA: 0x1E13F60 Offset: 0x1E14061 VA: 0x1E13F60
	private int getFieldMapId() { }

	// RVA: 0x1E14540 Offset: 0x1E14641 VA: 0x1E14540
	private Vector3 getPlayerMapPos(FieldSceneId fieldId) { }

	// RVA: 0x1E14AD0 Offset: 0x1E14BD1 VA: 0x1E14AD0
	private void Start() { }

	// RVA: 0x1E15880 Offset: 0x1E15981 VA: 0x1E15880
	private void Update() { }

	// RVA: 0x1E18F10 Offset: 0x1E19011 VA: 0x1E18F10
	private void OnDestroy() { }

	// RVA: 0x1E17480 Offset: 0x1E17581 VA: 0x1E17480
	private void NpcSet() { }

	// RVA: 0x1E19A20 Offset: 0x1E19B21 VA: 0x1E19A20
	private bool IsNPCIcon(int type, NpcData npcdata) { }

	// RVA: 0x1E197E0 Offset: 0x1E198E1 VA: 0x1E197E0
	private bool CheckNpcIcon(NpcData npcData) { }

	// RVA: 0x1E19070 Offset: 0x1E19171 VA: 0x1E19070
	private void DestroyNpcIcon() { }

	// RVA: 0x1E16B40 Offset: 0x1E16C41 VA: 0x1E16B40
	private void MobSet() { }

	// RVA: 0x1E19180 Offset: 0x1E19281 VA: 0x1E19180
	private void DestroyMobIcon() { }

	// RVA: 0x1E19B20 Offset: 0x1E19C21 VA: 0x1E19B20
	private bool IsNpcField(NpcData npcdata) { }

	// RVA: 0x1E19C30 Offset: 0x1E19D31 VA: 0x1E19C30
	private bool IsNpcRoom(NpcData npcdata) { }

	// RVA: 0x1E18380 Offset: 0x1E18481 VA: 0x1E18380
	private void SetPlayerIcon() { }

	// RVA: 0x1E17A80 Offset: 0x1E17B81 VA: 0x1E17A80
	private void PartnerSet() { }

	// RVA: 0x1E19290 Offset: 0x1E19391 VA: 0x1E19290
	private void DestroyPartnerIcon() { }

	// RVA: 0x1E17120 Offset: 0x1E17221 VA: 0x1E17120
	private void FriendMonsterSet() { }

	// RVA: 0x1E193A0 Offset: 0x1E194A1 VA: 0x1E193A0
	private void DestroyFriMonsIcon() { }

	// RVA: 0x1E180C0 Offset: 0x1E181C1 VA: 0x1E180C0
	private void QuestSet() { }

	// RVA: 0x1E19DD0 Offset: 0x1E19ED1 VA: 0x1E19DD0
	private List<QuestIconData> GetQuestIconData() { }

	// RVA: 0x1E1A3F0 Offset: 0x1E1A4F1 VA: 0x1E1A3F0
	private void CreateQuestIcon(int DataNo, int iconType, Vector3 iconScale) { }

	// RVA: 0x1E194B0 Offset: 0x1E195B1 VA: 0x1E194B0
	private void DestroyQuestIcon() { }

	// RVA: 0x1E15D50 Offset: 0x1E15E51 VA: 0x1E15D50
	private void BuildSet() { }

	// RVA: 0x1E195C0 Offset: 0x1E196C1 VA: 0x1E195C0
	private void DestroyBuildIcon() { }

	// RVA: 0x1E16270 Offset: 0x1E16371 VA: 0x1E16270
	private void WarpIconSet() { }

	// RVA: 0x1E196D0 Offset: 0x1E197D1 VA: 0x1E196D0
	private void DestroyWarpIcon() { }

	// RVA: 0x1E14DE0 Offset: 0x1E14EE1 VA: 0x1E14DE0
	private void SearchWarpable() { }

	// RVA: 0x1E1A880 Offset: 0x1E1A981 VA: 0x1E1A880
	private bool checkHit(Vector2 cursorPos, Vector2 rectPos, Vector2 rectSize) { }

	// RVA: 0x1E1A8C0 Offset: 0x1E1A9C1 VA: 0x1E1A8C0
	private int checkHitBuild(Vector2 cursorPos, int winPosType) { }

	// RVA: 0x1E1AE10 Offset: 0x1E1AF11 VA: 0x1E1AE10
	private int checkHitWarp(Vector2 cursorPos) { }

	// RVA: 0x1E1B3B0 Offset: 0x1E1B4B1 VA: 0x1E1B3B0
	private void checkHitIcon() { }

	// RVA: 0x1E15B30 Offset: 0x1E15C31 VA: 0x1E15B30
	private void setBuildNPCList() { }

	// RVA: 0x1E13F50 Offset: 0x1E14051 VA: 0x1E13F50
	private void setMapData(int mapId, int floorNo) { }

	// RVA: 0x1E185A0 Offset: 0x1E186A1 VA: 0x1E185A0
	private float getStartScale() { }

	// RVA: 0x1E1B7F0 Offset: 0x1E1B8F1 VA: 0x1E1B7F0
	private float getScalePoint(int no) { }

	// RVA: 0x1E187F0 Offset: 0x1E188F1 VA: 0x1E187F0
	private void InitGuidStatus() { }

	// RVA: 0x1E18B30 Offset: 0x1E18C31 VA: 0x1E18B30
	private void UpdateGuidStatus() { }

	// RVA: 0x1E1B890 Offset: 0x1E1B991 VA: 0x1E1B890
	private void NewSet(Vector3 pos) { }

	// RVA: 0x1E18D50 Offset: 0x1E18E51 VA: 0x1E18D50
	private void UpdateNewIcon() { }

	// RVA: 0x1E1B9A0 Offset: 0x1E1BAA1 VA: 0x1E1B9A0
	private void CheckMapScrollMax() { }

	// RVA: 0x1E1BAD0 Offset: 0x1E1BBD1 VA: 0x1E1BAD0
	public void updateInput() { }

	// RVA: 0x1E1BB10 Offset: 0x1E1BC11 VA: 0x1E1BB10
	public void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x1E1BB90 Offset: 0x1E1BC91 VA: 0x1E1BB90
	public MapControl.MapCntlStep GetStep() { }

	// RVA: 0x1E18670 Offset: 0x1E18771 VA: 0x1E18670
	public void SetScroll(Vector2 addScroll) { }

	// RVA: 0x1E1BBA0 Offset: 0x1E1BCA1 VA: 0x1E1BBA0
	public void SetCursorPos(Vector3 setPos) { }

	// RVA: 0x1E1BBB0 Offset: 0x1E1BCB1 VA: 0x1E1BBB0
	public void updateScale(float addScale, bool touchFlg) { }

	// RVA: 0x1E18610 Offset: 0x1E18711 VA: 0x1E18610
	public void setScale(float scale) { }

	// RVA: 0x1E1BE70 Offset: 0x1E1BF71 VA: 0x1E1BE70
	public float getScale() { }

	// RVA: 0x1E1BE80 Offset: 0x1E1BF81 VA: 0x1E1BE80
	public int[,] getBuildNPCList() { }

	// RVA: 0x1E1BE90 Offset: 0x1E1BF91 VA: 0x1E1BE90
	public int getHitObjNo() { }

	// RVA: 0x1E1BEA0 Offset: 0x1E1BFA1 VA: 0x1E1BEA0
	public void setHitObjNo(int hitNo) { }

	// RVA: 0x1E1BEB0 Offset: 0x1E1BFB1 VA: 0x1E1BEB0
	public int getOldHitObjNo() { }

	// RVA: 0x1E1BEC0 Offset: 0x1E1BFC1 VA: 0x1E1BEC0
	public Vector3 getHitObjPos() { }

	// RVA: 0x1E1BED0 Offset: 0x1E1BFD1 VA: 0x1E1BED0
	public int getWarpObjVal() { }

	// RVA: 0x1E1BEE0 Offset: 0x1E1BFE1 VA: 0x1E1BEE0
	public List<WarpPoints.WarpPoint> getWarpableList() { }

	// RVA: 0x1E1BEF0 Offset: 0x1E1BFF1 VA: 0x1E1BEF0
	public List<WarpPoints.WarpPoint> getWarpableFloorList() { }

	// RVA: 0x1E1BF00 Offset: 0x1E1C001 VA: 0x1E1BF00
	public static byte[] getMaskBuff() { }

	// RVA: 0x1E1BF70 Offset: 0x1E1C071 VA: 0x1E1BF70
	public void InitInfoStatus(int infoID) { }

	// RVA: 0x1E1C0E0 Offset: 0x1E1C1E1 VA: 0x1E1C0E0
	public void UpdateInfoStatus() { }

	// RVA: 0x1E1C310 Offset: 0x1E1C411 VA: 0x1E1C310
	public void changeWarpIcon(int iconNo) { }

	// RVA: 0x1E1C5E0 Offset: 0x1E1C6E1 VA: 0x1E1C5E0
	public bool getFieldFlg() { }

	// RVA: 0x1E1C5F0 Offset: 0x1E1C6F1 VA: 0x1E1C5F0
	public void .ctor() { }

	// RVA: 0x1E1CAF0 Offset: 0x1E1CBF1 VA: 0x1E1CAF0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7DF0 Offset: 0x1A7EF1 VA: 0x1A7DF0
	// RVA: 0x1E1CB90 Offset: 0x1E1CC91 VA: 0x1E1CB90
	private void <UpdateGuidStatus>b__144_0(bool select) { }
}


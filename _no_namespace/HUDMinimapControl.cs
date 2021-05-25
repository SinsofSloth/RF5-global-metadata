public class HUDMinimapControl : SingletonMonoBehaviour<HUDMinimapControl> // TypeDefIndex: 8568
{
	// Fields
	[SerializeField] // RVA: 0x170A70 Offset: 0x170B71 VA: 0x170A70
	private float DispRange; // 0x18
	[SerializeField] // RVA: 0x170A80 Offset: 0x170B81 VA: 0x170A80
	private RectTransform MinimapGroupRect; // 0x20
	[SerializeField] // RVA: 0x170A90 Offset: 0x170B91 VA: 0x170A90
	private RectTransform PlayerRect; // 0x28
	[SerializeField] // RVA: 0x170AA0 Offset: 0x170BA1 VA: 0x170AA0
	private RectTransform NpcImage; // 0x30
	[SerializeField] // RVA: 0x170AB0 Offset: 0x170BB1 VA: 0x170AB0
	private RectTransform PartnerImage; // 0x38
	[SerializeField] // RVA: 0x170AC0 Offset: 0x170BC1 VA: 0x170AC0
	private RectTransform EnemyImage; // 0x40
	[SerializeField] // RVA: 0x170AD0 Offset: 0x170BD1 VA: 0x170AD0
	private RectTransform BuildImage; // 0x48
	[SerializeField] // RVA: 0x170AE0 Offset: 0x170BE1 VA: 0x170AE0
	private RectTransform NpcIconParent; // 0x50
	[SerializeField] // RVA: 0x170AF0 Offset: 0x170BF1 VA: 0x170AF0
	private RectTransform IconParent; // 0x58
	[SerializeField] // RVA: 0x170B00 Offset: 0x170C01 VA: 0x170B00
	private RectTransform EventIconParent; // 0x60
	private RectTransform[] NPCMapRect; // 0x68
	private RectTransform[] PartnerMapRect; // 0x70
	private ActorID[] PartnerIconType; // 0x78
	private RectTransform[] FriMonMapRect; // 0x80
	private RectTransform[] QuestMapRect; // 0x88
	private int[] QuestIconType; // 0x90
	private RectTransform[] MobMapRect; // 0x98
	private List<HUDMinimapControl.RectImage> EnemyMapRect; // 0xA0
	private RectTransform[] BuildMapRect; // 0xA8
	private List<HUDMinimapControl.RectImage> WarpMapRect; // 0xB0
	[SerializeField] // RVA: 0x170B10 Offset: 0x170C11 VA: 0x170B10
	private Sprite[] miniMapShdrMask; // 0xB8
	[SerializeField] // RVA: 0x170B20 Offset: 0x170C21 VA: 0x170B20
	private Sprite[] miniMapBgMask; // 0xC0
	private FieldSceneId _nowScene; // 0xC8
	private List<Transform> EnemyRect; // 0xD0
	private bool RunOnScene; // 0xD8
	[SerializeField] // RVA: 0x170B30 Offset: 0x170C31 VA: 0x170B30
	private GameObject mapBg; // 0xE0
	[SerializeField] // RVA: 0x170B40 Offset: 0x170C41 VA: 0x170B40
	private GameObject[] miniMapFrame; // 0xE8
	[SerializeField] // RVA: 0x170B50 Offset: 0x170C51 VA: 0x170B50
	private GameObject[] miniMapFrameRoom; // 0xF0
	[SerializeField] // RVA: 0x170B60 Offset: 0x170C61 VA: 0x170B60
	private Image[] miniMapMaskImg; // 0xF8
	private MiniMapShaderController ShaderCtrl; // 0x100
	private GameObject mapPrefab; // 0x108
	private int windowType; // 0x110
	private HUDMinimapControl.STEP step; // 0x114
	private int mapDataId; // 0x118
	private int mapFloorNo; // 0x11C
	private List<WarpPoints.WarpPoint> WarpableList; // 0x120
	private static List<WarpPoints.WarpPoint> AllWarpableList; // 0x0
	private string FieldSceneName; // 0x128
	public static byte[] maskBuff; // 0x8
	private int loadPrefabId; // 0x130
	private int nowFileNo; // 0x134
	private bool monsterHutFlg; // 0x138
	private bool farmDragonFlg; // 0x139
	private List<Vector3> BuildIconPos; // 0x140
	private List<QuestIconData> questIconList; // 0x148
	private bool IsMiniMapNpcActive; // 0x150
	private Vector3 BuildIconScale; // 0x154
	private Vector3 NpcIconScale; // 0x160
	private Vector3 WarpIconScale; // 0x16C
	private Vector3 QuestIconScale; // 0x178
	private Vector3 LoveIconScale; // 0x184
	private Vector3 EnmIconScale; // 0x190
	private Vector3 BossIconScale; // 0x19C
	private Vector3 MobIconScale; // 0x1A8
	private Vector3 FriIconScale; // 0x1B4
	[SerializeField] // RVA: 0x170B70 Offset: 0x170C71 VA: 0x170B70
	private Image smallMapNorth; // 0x1C0
	[SerializeField] // RVA: 0x170B80 Offset: 0x170C81 VA: 0x170B80
	private Image bigMapNorth; // 0x1C8
	private static readonly int[] FieldPrefabIds; // 0x10

	// Properties
	private FieldSceneId nowScene { get; set; }

	// Methods

	// RVA: 0x1EC22F0 Offset: 0x1EC23F1 VA: 0x1EC22F0
	private void set_nowScene(FieldSceneId value) { }

	// RVA: 0x1EC57C0 Offset: 0x1EC58C1 VA: 0x1EC57C0
	private FieldSceneId get_nowScene() { }

	// RVA: 0x1EC57D0 Offset: 0x1EC58D1 VA: 0x1EC57D0
	private void Start() { }

	// RVA: 0x1EC5FC0 Offset: 0x1EC60C1 VA: 0x1EC5FC0
	private void Update() { }

	// RVA: 0x1EC6DF0 Offset: 0x1EC6EF1 VA: 0x1EC6DF0
	private void OnDestroy() { }

	// RVA: 0x1EC2330 Offset: 0x1EC2431 VA: 0x1EC2330
	private void OnSceneChange(FieldSceneId fieldId) { }

	// RVA: 0x1EC6E80 Offset: 0x1EC6F81 VA: 0x1EC6E80
	private int getMonsterHutDataID(FieldSceneId fieldId) { }

	// RVA: 0x1EC6AB0 Offset: 0x1EC6BB1 VA: 0x1EC6AB0
	private void updateMapParam() { }

	// RVA: 0x1EC75B0 Offset: 0x1EC76B1 VA: 0x1EC75B0
	private void updateMapIcon(Vector3 playerPos) { }

	// RVA: 0x1ECAC30 Offset: 0x1ECAD31 VA: 0x1ECAC30
	private float GetDistance(Vector3 worldPos) { }

	// RVA: 0x1ECADA0 Offset: 0x1ECAEA1 VA: 0x1ECADA0
	private Vector2 GetPosOnMap(Vector3 worldPos) { }

	// RVA: 0x1EC6F60 Offset: 0x1EC7061 VA: 0x1EC6F60
	private void BuildImgSet() { }

	// RVA: 0x1EC7870 Offset: 0x1EC7971 VA: 0x1EC7870
	private void BuildSet(Vector3 plyPos) { }

	// RVA: 0x1EC7F90 Offset: 0x1EC8091 VA: 0x1EC7F90
	private void WarpSet(Vector3 plyPos) { }

	// RVA: 0x1ECB000 Offset: 0x1ECB101 VA: 0x1ECB000
	public void SetMiniMapNpcActive(bool active) { }

	// RVA: 0x1EC9850 Offset: 0x1EC9951 VA: 0x1EC9850
	private void NpcSet(Vector3 plyPos) { }

	// RVA: 0x1EC8510 Offset: 0x1EC8611 VA: 0x1EC8510
	private void MobSet(Vector3 plyPos) { }

	// RVA: 0x1EC9FA0 Offset: 0x1ECA0A1 VA: 0x1EC9FA0
	private void PartnerSet(Vector3 plyPos) { }

	// RVA: 0x1ECA7E0 Offset: 0x1ECA8E1 VA: 0x1ECA7E0
	private void QuestSet(Vector3 plyPos) { }

	// RVA: 0x1ECB010 Offset: 0x1ECB111 VA: 0x1ECB010
	private void CreateQuestIcon(int DataNo, int IconNo, Vector3 Scale) { }

	// RVA: 0x1ECB290 Offset: 0x1ECB391 VA: 0x1ECB290
	private void SetQuestIconScale(int DataNo, int IconNo, Vector3 Scale) { }

	// RVA: 0x1EC8AA0 Offset: 0x1EC8BA1 VA: 0x1EC8AA0
	private void EnemySet() { }

	// RVA: 0x1EC9290 Offset: 0x1EC9391 VA: 0x1EC9290
	private void FriendMonsterSet(Vector3 plyPos) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A7C70 Offset: 0x1A7D71 VA: 0x1A7C70
	// RVA: 0x1EC72F0 Offset: 0x1EC73F1 VA: 0x1EC72F0
	private IEnumerator createMap(int id) { }

	// RVA: 0x1EC7680 Offset: 0x1EC7781 VA: 0x1EC7680
	private void mapRotate() { }

	// RVA: 0x1EC6140 Offset: 0x1EC6241 VA: 0x1EC6140
	private void setMapFrame() { }

	// RVA: 0x1EC64C0 Offset: 0x1EC65C1 VA: 0x1EC64C0
	private void SearchWarpable() { }

	// RVA: 0x1EC5D40 Offset: 0x1EC5E41 VA: 0x1EC5D40
	private void SearchAllWarpable() { }

	// RVA: 0x1EC6E70 Offset: 0x1EC6F71 VA: 0x1EC6E70
	private void setMapData(int mapId, int floorNo) { }

	// RVA: 0x1ECB400 Offset: 0x1ECB501 VA: 0x1ECB400
	private void setMapSizeInfo(int scaleType, Vector3 pos) { }

	// RVA: 0x1EC7380 Offset: 0x1EC7481 VA: 0x1EC7380
	private void updateMapPos(Vector3 pos) { }

	// RVA: 0x1ECAEE0 Offset: 0x1ECAFE1 VA: 0x1ECAEE0
	private Vector3 getIconMapPos(Vector3 pos, Vector3 plyPos) { }

	// RVA: 0x1EC7450 Offset: 0x1EC7551 VA: 0x1EC7450
	private bool IsRoom() { }

	// RVA: 0x1EC74F0 Offset: 0x1EC75F1 VA: 0x1EC74F0
	private Vector3 getPlayerPos() { }

	// RVA: 0x1ECB350 Offset: 0x1ECB451 VA: 0x1ECB350
	private void setMaskImage(Sprite spr) { }

	// RVA: 0x1ECB4E0 Offset: 0x1ECB5E1 VA: 0x1ECB4E0
	private List<QuestIconData> GetQuestIconData() { }

	// RVA: 0x1EBB820 Offset: 0x1EBB921 VA: 0x1EBB820
	public void setMapSize(int sizeNo) { }

	// RVA: 0x1ECCA40 Offset: 0x1ECCB41 VA: 0x1ECCA40
	public int getWindowType() { }

	// RVA: 0x1ECCA50 Offset: 0x1ECCB51 VA: 0x1ECCA50
	public void setMaskBuff(byte[] maskList) { }

	// RVA: 0x1EC7130 Offset: 0x1EC7231 VA: 0x1EC7130
	public void updateQuestIcon() { }

	// RVA: 0x1ECCAC0 Offset: 0x1ECCBC1 VA: 0x1ECCAC0
	public static byte[] getMaskBuff() { }

	// RVA: 0x1ECCB30 Offset: 0x1ECCC31 VA: 0x1ECCB30
	public static List<WarpPoints.WarpPoint> getAllWarpList() { }

	// RVA: 0x1ECBA40 Offset: 0x1ECBB41 VA: 0x1ECBA40
	public static Vector3 GetQuestIconFieldPos(FieldSceneId fieldSceneId) { }

	// RVA: 0x1ECCBA0 Offset: 0x1ECCCA1 VA: 0x1ECCBA0
	public void ChangeSeasonFieldMap(FieldSceneId fieldSceneId) { }

	// RVA: 0x1ECCC10 Offset: 0x1ECCD11 VA: 0x1ECCC10
	public bool IsNotGoD2Pri() { }

	// RVA: 0x1ECCD80 Offset: 0x1ECCE81 VA: 0x1ECCD80
	public bool IsNotGoHuman() { }

	// RVA: 0x1ECCF10 Offset: 0x1ECD011 VA: 0x1ECCF10
	public void .ctor() { }

	// RVA: 0x1ECD300 Offset: 0x1ECD401 VA: 0x1ECD300
	private static void .cctor() { }
}


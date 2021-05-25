public class FesMinimapControl : MonoBehaviour // TypeDefIndex: 8535
{
	// Fields
	[SerializeField] // RVA: 0x1703C0 Offset: 0x1704C1 VA: 0x1703C0
	private float DispRange; // 0x18
	[SerializeField] // RVA: 0x1703D0 Offset: 0x1704D1 VA: 0x1703D0
	private RectTransform MinimapGroupRect; // 0x20
	[SerializeField] // RVA: 0x1703E0 Offset: 0x1704E1 VA: 0x1703E0
	private RectTransform PlayerRect; // 0x28
	[SerializeField] // RVA: 0x1703F0 Offset: 0x1704F1 VA: 0x1703F0
	private MinimapIconPoint IconPoint; // 0x30
	[SerializeField] // RVA: 0x170400 Offset: 0x170501 VA: 0x170400
	private RectTransform NpcIconParent; // 0x38
	private MinimapIconPoint[] IconObj; // 0x40
	[SerializeField] // RVA: 0x170410 Offset: 0x170511 VA: 0x170410
	private Sprite[] miniMapShdrMask; // 0x48
	[SerializeField] // RVA: 0x170420 Offset: 0x170521 VA: 0x170420
	private Sprite[] miniMapBgMask; // 0x50
	private List<Transform> ObjRect; // 0x58
	private bool RunOnScene; // 0x60
	[SerializeField] // RVA: 0x170430 Offset: 0x170531 VA: 0x170430
	private GameObject[] miniMapFrame; // 0x68
	[SerializeField] // RVA: 0x170440 Offset: 0x170541 VA: 0x170440
	private Image[] miniMapMaskImg; // 0x70
	[SerializeField] // RVA: 0x170450 Offset: 0x170551 VA: 0x170450
	private Sprite[] ObjIconSpr; // 0x78
	[SerializeField] // RVA: 0x170460 Offset: 0x170561 VA: 0x170460
	private FesMiniMapShaderController ShaderCtrl; // 0x80
	private int windowType; // 0x88
	private int step; // 0x8C
	private List<WarpPoints.WarpPoint> WarpableList; // 0x90
	private int loadPrefabId; // 0x98
	private int nowFileNo; // 0x9C
	private int OBJ_MAX; // 0xA0
	[SerializeField] // RVA: 0x170470 Offset: 0x170571 VA: 0x170470
	private Transform[] MinimapParents; // 0xA8
	[SerializeField] // RVA: 0x170480 Offset: 0x170581 VA: 0x170480
	private RectTransform RectTrans; // 0xB0

	// Methods

	// RVA: 0x20368D0 Offset: 0x20369D1 VA: 0x20368D0
	private void Start() { }

	// RVA: 0x2036B00 Offset: 0x2036C01 VA: 0x2036B00
	private void Update() { }

	// RVA: 0x20375C0 Offset: 0x20376C1 VA: 0x20375C0
	private void OnDestroy() { }

	// RVA: 0x2036A50 Offset: 0x2036B51 VA: 0x2036A50
	private void MapLoad() { }

	// RVA: 0x2037680 Offset: 0x2037781 VA: 0x2037680
	private float GetDistance(Vector3 worldPos) { }

	// RVA: 0x20377B0 Offset: 0x20378B1 VA: 0x20377B0
	private Vector2 GetPosOnMap(Vector3 worldPos) { }

	// RVA: 0x2037110 Offset: 0x2037211 VA: 0x2037110
	private void IconObjSet() { }

	// RVA: 0x2037430 Offset: 0x2037531 VA: 0x2037430
	private void MapRotate() { }

	// RVA: 0x2036EC0 Offset: 0x2036FC1 VA: 0x2036EC0
	private void SetMapFrame() { }

	// RVA: 0x20378D0 Offset: 0x20379D1 VA: 0x20378D0
	public void SetMapSize(int sizeNo) { }

	// RVA: 0x2037990 Offset: 0x2037A91 VA: 0x2037990
	public int GetWindowType() { }

	// RVA: 0x20379A0 Offset: 0x2037AA1 VA: 0x20379A0
	public void ChangeMapSize() { }

	// RVA: 0x2037B80 Offset: 0x2037C81 VA: 0x2037B80
	public void SetNormalScale() { }

	// RVA: 0x2037C10 Offset: 0x2037D11 VA: 0x2037C10
	public void .ctor() { }
}


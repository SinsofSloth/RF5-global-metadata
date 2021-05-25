public class BuildWindowController : MonoBehaviour // TypeDefIndex: 8629
{
	// Fields
	[SerializeField] // RVA: 0x1713A0 Offset: 0x1714A1 VA: 0x1713A0
	private RectTransform parentRect; // 0x18
	[SerializeField] // RVA: 0x1713B0 Offset: 0x1714B1 VA: 0x1713B0
	private RectTransform windowRect; // 0x20
	[SerializeField] // RVA: 0x1713C0 Offset: 0x1714C1 VA: 0x1713C0
	private GameObject iconParent; // 0x28
	[SerializeField] // RVA: 0x1713D0 Offset: 0x1714D1 VA: 0x1713D0
	private Image PhotoImg; // 0x30
	[SerializeField] // RVA: 0x1713E0 Offset: 0x1714E1 VA: 0x1713E0
	private Text buildName; // 0x38
	[SerializeField] // RVA: 0x1713F0 Offset: 0x1714F1 VA: 0x1713F0
	private Image IconImg; // 0x40
	[SerializeField] // RVA: 0x171400 Offset: 0x171501 VA: 0x171400
	private Sprite[] BuildPhoto_Before; // 0x48
	[SerializeField] // RVA: 0x171410 Offset: 0x171511 VA: 0x171410
	private Sprite[] BuildPhoto_After; // 0x50
	[SerializeField] // RVA: 0x171420 Offset: 0x171521 VA: 0x171420
	private string[] BuildName_Before; // 0x58
	[SerializeField] // RVA: 0x171430 Offset: 0x171531 VA: 0x171430
	private string[] BuildName_After; // 0x60
	[SerializeField] // RVA: 0x171440 Offset: 0x171541 VA: 0x171440
	private Sprite[] BuildIcon; // 0x68
	[SerializeField] // RVA: 0x171450 Offset: 0x171551 VA: 0x171450
	private MapControl mapCntl; // 0x70
	private Image[] iconList; // 0x78
	private GameObject[] photoList; // 0x80
	private int[,] buildList; // 0x88

	// Methods

	// RVA: 0x205F460 Offset: 0x205F561 VA: 0x205F460
	private void Awake() { }

	// RVA: 0x205F860 Offset: 0x205F961 VA: 0x205F860
	private void OnEnable() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A7EE0 Offset: 0x1A7FE1 VA: 0x1A7EE0
	// RVA: 0x205F8F0 Offset: 0x205F9F1 VA: 0x205F8F0
	private IEnumerator OnEnableAnim() { }

	// RVA: 0x205F9A0 Offset: 0x205FAA1 VA: 0x205F9A0
	private void Start() { }

	// RVA: 0x205F9B0 Offset: 0x205FAB1 VA: 0x205F9B0
	private void Update() { }

	// RVA: 0x205F4A0 Offset: 0x205F5A1 VA: 0x205F4A0
	private void FineObject() { }

	// RVA: 0x205F9C0 Offset: 0x205FAC1 VA: 0x205F9C0
	private void setBuildName(int buildNo) { }

	// RVA: 0x205FCA0 Offset: 0x205FDA1 VA: 0x205FCA0
	private void setWindowSize(int buildNo) { }

	// RVA: 0x205FF80 Offset: 0x2060081 VA: 0x205FF80
	private void setPosition(int type) { }

	// RVA: 0x205FDE0 Offset: 0x205FEE1 VA: 0x205FDE0
	private void setNPCIcon(int buildNo) { }

	// RVA: 0x2060070 Offset: 0x2060171 VA: 0x2060070
	private void setBuildPhoto(int buildNo) { }

	// RVA: 0x2060320 Offset: 0x2060421 VA: 0x2060320
	private void setBuildIcon(int buildNo) { }

	// RVA: 0x20604B0 Offset: 0x20605B1 VA: 0x20604B0
	public void setBuildWindow(int buildNo, int posType) { }

	// RVA: 0x2060540 Offset: 0x2060641 VA: 0x2060540
	public void .ctor() { }
}


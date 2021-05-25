public class ButtonHintMain : MonoBehaviour // TypeDefIndex: 9841
{
	// Fields
	[SerializeField] // RVA: 0x17F820 Offset: 0x17F921 VA: 0x17F820
	private Sprite[] ButtonSprites; // 0x18
	[SerializeField] // RVA: 0x17F830 Offset: 0x17F931 VA: 0x17F830
	private Image Border; // 0x20
	[SerializeField] // RVA: 0x17F840 Offset: 0x17F941 VA: 0x17F840
	private ButtonHintBlock prefabs; // 0x28
	private RectTransform RectTransform; // 0x30
	private Vector3 OpenPos; // 0x38
	private Vector3 ClosePos; // 0x44
	private const float MoveTimeMax = 0.15;
	private float MoveTime; // 0x50
	private bool isOpen; // 0x54
	private bool ClearFlag; // 0x55
	private float totalSize; // 0x58
	private const float paddingWidth = 15;
	private List<ButtonHintBlock> usingObjs; // 0x60
	private bool StartInited; // 0x68
	private ButtonGuideDataTable ButtonGuideDataTable; // 0x70
	private Dictionary<ButtonGuideId, int> DataDic; // 0x78

	// Methods

	// RVA: 0x1DFE510 Offset: 0x1DFE611 VA: 0x1DFE510
	private void InitOnStart() { }

	// RVA: 0x1DFE7A0 Offset: 0x1DFE8A1 VA: 0x1DFE7A0
	public void Disp(ButtonGuideId buttonGuideId) { }

	// RVA: 0x1DFECB0 Offset: 0x1DFEDB1 VA: 0x1DFECB0
	public void AddBlock(ButtonType button, TextId textId) { }

	// RVA: 0x1DFE9B0 Offset: 0x1DFEAB1 VA: 0x1DFE9B0
	public void AddBlock(ButtonType button, int textId) { }

	// RVA: 0x1DFE970 Offset: 0x1DFEA71 VA: 0x1DFE970
	public void Clear() { }

	// RVA: 0x1DFECC0 Offset: 0x1DFEDC1 VA: 0x1DFECC0
	private void Update() { }

	// RVA: 0x1DFEED0 Offset: 0x1DFEFD1 VA: 0x1DFEED0
	public bool IsLoading() { }

	// RVA: 0x1DFEF40 Offset: 0x1DFF041 VA: 0x1DFEF40
	public void .ctor() { }
}


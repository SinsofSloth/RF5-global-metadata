public class AdvStaffRollControl : MonoBehaviour // TypeDefIndex: 8425
{
	// Fields
	[SerializeField] // RVA: 0x16F5D0 Offset: 0x16F6D1 VA: 0x16F5D0
	private Image[] imageList; // 0x18
	[SerializeField] // RVA: 0x16F5E0 Offset: 0x16F6E1 VA: 0x16F5E0
	private Sprite[] staffrollList; // 0x20
	private Vector2 ScreenSize; // 0x28
	private int cnt; // 0x30
	private RectTransform[] imageRect; // 0x38
	private const int base_scale = 2;
	private int imageCntMax; // 0x40
	private bool scrollFlg; // 0x44
	private float scroll_spd; // 0x48
	private float scroll_time; // 0x4C
	private float scroll_hmax; // 0x50
	private float time_count; // 0x54
	private int lastImgNo; // 0x58

	// Methods

	// RVA: 0x22784A0 Offset: 0x22785A1 VA: 0x22784A0
	public void StartStaffRoll(float time) { }

	// RVA: 0x2278AB0 Offset: 0x2278BB1 VA: 0x2278AB0
	public void EndStaffRoll() { }

	// RVA: 0x2278E10 Offset: 0x2278F11 VA: 0x2278E10
	public bool getScrollFlg() { }

	// RVA: 0x2278E20 Offset: 0x2278F21 VA: 0x2278E20
	private void Awake() { }

	// RVA: 0x2278FA0 Offset: 0x22790A1 VA: 0x2278FA0
	private void Update() { }

	// RVA: 0x2279380 Offset: 0x2279481 VA: 0x2279380
	public void .ctor() { }
}


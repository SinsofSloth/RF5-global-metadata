public class UIItemAutoPick : SingletonMonoBehaviour<UIItemAutoPick> // TypeDefIndex: 8610
{
	// Fields
	[SerializeField] // RVA: 0x171180 Offset: 0x171281 VA: 0x171180
	private GameObject itemObject; // 0x18
	[SerializeField] // RVA: 0x171190 Offset: 0x171291 VA: 0x171190
	private Image itemIcon; // 0x20
	[SerializeField] // RVA: 0x1711A0 Offset: 0x1712A1 VA: 0x1711A0
	private RectTransform itemNameRect; // 0x28
	[SerializeField] // RVA: 0x1711B0 Offset: 0x1712B1 VA: 0x1711B0
	private Text itemName; // 0x30
	[SerializeField] // RVA: 0x1711C0 Offset: 0x1712C1 VA: 0x1711C0
	private AnimationCurve fadeCurve; // 0x38
	[SerializeField] // RVA: 0x1711D0 Offset: 0x1712D1 VA: 0x1711D0
	private AnimationCurve slideCurve; // 0x40
	private CanvasGroup canvasGroup; // 0x48
	private Queue<ItemData> pickedItemList; // 0x50
	private Vector3 itemObjectPos; // 0x58
	private bool isPlaying; // 0x64
	[SerializeField] // RVA: 0x1711E0 Offset: 0x1712E1 VA: 0x1711E0
	private float animHeight; // 0x68
	[SerializeField] // RVA: 0x1711F0 Offset: 0x1712F1 VA: 0x1711F0
	private float curveSpeed; // 0x6C
	private float curveRate; // 0x70

	// Methods

	// RVA: 0x1F15940 Offset: 0x1F15A41 VA: 0x1F15940
	private void Start() { }

	// RVA: 0x1F159E0 Offset: 0x1F15AE1 VA: 0x1F159E0
	private void Update() { }

	// RVA: 0x1F15D40 Offset: 0x1F15E41 VA: 0x1F15D40
	private void StartItemAnim(ItemData _item) { }

	// RVA: 0x1F15EA0 Offset: 0x1F15FA1 VA: 0x1F15EA0
	public void AddItem(ItemData _item) { }

	// RVA: 0x1F15F10 Offset: 0x1F16011 VA: 0x1F15F10
	public void ClearItemList() { }

	// RVA: 0x1F15F70 Offset: 0x1F16071 VA: 0x1F15F70
	public void .ctor() { }
}


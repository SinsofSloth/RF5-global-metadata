public class NoChoicePopupMain : MonoBehaviour // TypeDefIndex: 8812
{
	// Fields
	[SerializeField] // RVA: 0x173AE0 Offset: 0x173BE1 VA: 0x173AE0
	private ChoiceButton yesButton; // 0x18
	[SerializeField] // RVA: 0x173AF0 Offset: 0x173BF1 VA: 0x173AF0
	private Image YesChoiceImg; // 0x20
	[SerializeField] // RVA: 0x173B00 Offset: 0x173C01 VA: 0x173B00
	private Text HeadText; // 0x28
	[SerializeField] // RVA: 0x173B10 Offset: 0x173C11 VA: 0x173B10
	private RectTransform BorderMask; // 0x30
	private bool isOpening; // 0x38
	private bool isYesSelect; // 0x39
	private UnityAction<bool> OnSelected; // 0x40
	private bool Selected; // 0x48
	private float openTime; // 0x4C
	private float openTimeMax; // 0x50
	private float closeTime; // 0x54
	private float closeTimeMax; // 0x58
	private bool modePage; // 0x5C
	private int pageCnt; // 0x60
	private List<string> messTextList; // 0x68
	private float inputStayTime; // 0x70
	private ButtonGuideId guideOnOpenId; // 0x74

	// Methods

	// RVA: 0x1FB6430 Offset: 0x1FB6531 VA: 0x1FB6430
	public void OpenMenu(UnityAction<bool> _OnSelected, string str, TextAnchor anchor = 4) { }

	// RVA: 0x1FB66D0 Offset: 0x1FB67D1 VA: 0x1FB66D0
	public void OpenMenu(UnityAction<bool> _OnSelected, List<string> strList, TextAnchor anchor = 4) { }

	// RVA: 0x1FB6A60 Offset: 0x1FB6B61 VA: 0x1FB6A60
	public void TouchSelect() { }

	// RVA: 0x1FB6AF0 Offset: 0x1FB6BF1 VA: 0x1FB6AF0
	private void Update() { }

	// RVA: 0x1FB6D70 Offset: 0x1FB6E71 VA: 0x1FB6D70
	private void updateClose() { }

	// RVA: 0x1FB6F10 Offset: 0x1FB7011 VA: 0x1FB6F10 Slot: 4
	protected virtual void InitButtonHint() { }

	// RVA: 0x1FB6FA0 Offset: 0x1FB70A1 VA: 0x1FB6FA0 Slot: 5
	protected virtual void ClearButtonHint() { }

	// RVA: 0x1FB6400 Offset: 0x1FB6501 VA: 0x1FB6400
	public void .ctor() { }
}


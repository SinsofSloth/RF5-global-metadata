public class TwoChoicePopupMain : MonoBehaviour // TypeDefIndex: 8814
{
	// Fields
	[SerializeField] // RVA: 0x173B20 Offset: 0x173C21 VA: 0x173B20
	private ChoiceButton yesButton; // 0x18
	[SerializeField] // RVA: 0x173B30 Offset: 0x173C31 VA: 0x173B30
	private ChoiceButton noButton; // 0x20
	[SerializeField] // RVA: 0x173B40 Offset: 0x173C41 VA: 0x173B40
	private Image YesChoiceImg; // 0x28
	[SerializeField] // RVA: 0x173B50 Offset: 0x173C51 VA: 0x173B50
	private Image NoChoiceImg; // 0x30
	[SerializeField] // RVA: 0x173B60 Offset: 0x173C61 VA: 0x173B60
	private Text HeadText; // 0x38
	[SerializeField] // RVA: 0x173B70 Offset: 0x173C71 VA: 0x173B70
	private RectTransform BorderMask; // 0x40
	private bool isOpening; // 0x48
	private bool isYesSelect; // 0x49
	private UnityAction<bool> OnSelected; // 0x50
	private bool Selected; // 0x58
	private float openTime; // 0x5C
	private float openTimeMax; // 0x60
	private float closeTime; // 0x64
	private float closeTimeMax; // 0x68
	private ButtonGuideId guideOnOpenId; // 0x6C

	// Methods

	// RVA: 0x1F00FB0 Offset: 0x1F010B1 VA: 0x1F00FB0
	public void OpenMenu(UnityAction<bool> _OnSelected, string str, bool StartOnYesButton) { }

	// RVA: 0x1F012D0 Offset: 0x1F013D1 VA: 0x1F012D0
	public void TouchSelect() { }

	// RVA: 0x1F01360 Offset: 0x1F01461 VA: 0x1F01360
	private void SwitchButton(bool selectButton) { }

	// RVA: 0x1F01450 Offset: 0x1F01551 VA: 0x1F01450
	private void Update() { }

	// RVA: 0x1F01960 Offset: 0x1F01A61 VA: 0x1F01960 Slot: 4
	protected virtual void InitButtonHint() { }

	// RVA: 0x1F019F0 Offset: 0x1F01AF1 VA: 0x1F019F0 Slot: 5
	protected virtual void ClearButtonHint() { }

	// RVA: 0x1F00F80 Offset: 0x1F01081 VA: 0x1F00F80
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8800 Offset: 0x1A8901 VA: 0x1A8800
	// RVA: 0x1F01AB0 Offset: 0x1F01BB1 VA: 0x1F01AB0
	private void <OpenMenu>b__15_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8810 Offset: 0x1A8911 VA: 0x1A8810
	// RVA: 0x1F01AC0 Offset: 0x1F01BC1 VA: 0x1F01AC0
	private void <OpenMenu>b__15_1() { }
}


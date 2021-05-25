public abstract class UIScrollBoxBase : MonoBehaviour // TypeDefIndex: 8473
{
	// Fields
	[SerializeField] // RVA: 0x16FEE0 Offset: 0x16FFE1 VA: 0x16FEE0
	private Scrollbar scrollBar; // 0x18
	[SerializeField] // RVA: 0x16FEF0 Offset: 0x16FFF1 VA: 0x16FEF0
	private GameObject buttonListParent; // 0x20
	[SerializeField] // RVA: 0x16FF00 Offset: 0x170001 VA: 0x16FF00
	private bool isEnableZR; // 0x28
	[SerializeField] // RVA: 0x16FF10 Offset: 0x170011 VA: 0x16FF10
	private bool isEnableStick; // 0x29
	private float startPosY; // 0x2C
	private float buttonSpace; // 0x30
	private readonly float SCROLL_SPEED; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x16FF20 Offset: 0x170021 VA: 0x16FF20
	private UIButtonLinkerInScrollBox <FocusingButton>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x16FF30 Offset: 0x170031 VA: 0x16FF30
	private int <ScrollRange>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x16FF40 Offset: 0x170041 VA: 0x16FF40
	private int <ScrollHeadIndex>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x16FF50 Offset: 0x170051 VA: 0x16FF50
	private int <ButtonMax>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x16FF60 Offset: 0x170061 VA: 0x16FF60
	private List<UIButtonLinkerInScrollBox> <ButtonList>k__BackingField; // 0x50
	private UIButtonLinkerInScrollBox[] topButton; // 0x58
	private UIButtonLinkerInScrollBox[] bottomButton; // 0x60

	// Properties
	protected GameObject ButtonListParent { get; }
	protected UIButtonLinkerInScrollBox FocusingButton { get; set; }
	protected int ScrollRange { get; set; }
	protected int ScrollHeadIndex { get; set; }
	protected int ScrollIndex { get; }
	protected int ButtonMax { get; set; }
	protected List<UIButtonLinkerInScrollBox> ButtonList { get; set; }
	protected virtual int RowMax { get; }

	// Methods

	// RVA: 0x1DD9880 Offset: 0x1DD9981 VA: 0x1DD9880
	protected GameObject get_ButtonListParent() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7A00 Offset: 0x1A7B01 VA: 0x1A7A00
	// RVA: 0x1DD9890 Offset: 0x1DD9991 VA: 0x1DD9890
	protected UIButtonLinkerInScrollBox get_FocusingButton() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7A10 Offset: 0x1A7B11 VA: 0x1A7A10
	// RVA: 0x1DD98A0 Offset: 0x1DD99A1 VA: 0x1DD98A0
	private void set_FocusingButton(UIButtonLinkerInScrollBox value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7A20 Offset: 0x1A7B21 VA: 0x1A7A20
	// RVA: 0x1DD98B0 Offset: 0x1DD99B1 VA: 0x1DD98B0
	protected int get_ScrollRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7A30 Offset: 0x1A7B31 VA: 0x1A7A30
	// RVA: 0x1DD98C0 Offset: 0x1DD99C1 VA: 0x1DD98C0
	private void set_ScrollRange(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7A40 Offset: 0x1A7B41 VA: 0x1A7A40
	// RVA: 0x1DD98D0 Offset: 0x1DD99D1 VA: 0x1DD98D0
	protected int get_ScrollHeadIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7A50 Offset: 0x1A7B51 VA: 0x1A7A50
	// RVA: 0x1DD98E0 Offset: 0x1DD99E1 VA: 0x1DD98E0
	private void set_ScrollHeadIndex(int value) { }

	// RVA: 0x1DCF410 Offset: 0x1DCF511 VA: 0x1DCF410
	protected int get_ScrollIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7A60 Offset: 0x1A7B61 VA: 0x1A7A60
	// RVA: 0x1DD98F0 Offset: 0x1DD99F1 VA: 0x1DD98F0
	protected int get_ButtonMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7A70 Offset: 0x1A7B71 VA: 0x1A7A70
	// RVA: 0x1DD9900 Offset: 0x1DD9A01 VA: 0x1DD9900
	private void set_ButtonMax(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7A80 Offset: 0x1A7B81 VA: 0x1A7A80
	// RVA: 0x1DD9910 Offset: 0x1DD9A11 VA: 0x1DD9910
	protected List<UIButtonLinkerInScrollBox> get_ButtonList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7A90 Offset: 0x1A7B91 VA: 0x1A7A90
	// RVA: 0x1DD9920 Offset: 0x1DD9A21 VA: 0x1DD9920
	private void set_ButtonList(List<UIButtonLinkerInScrollBox> value) { }

	// RVA: 0x1DD9930 Offset: 0x1DD9A31 VA: 0x1DD9930 Slot: 4
	protected virtual int get_RowMax() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int GetListCount() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetFocusDetail() { }

	// RVA: 0x1DCE230 Offset: 0x1DCE331 VA: 0x1DCE230 Slot: 8
	protected virtual void Start() { }

	// RVA: 0x1DCF080 Offset: 0x1DCF181 VA: 0x1DCF080 Slot: 9
	protected virtual void Update() { }

	// RVA: 0x1DD5AE0 Offset: 0x1DD5BE1 VA: 0x1DD5AE0 Slot: 10
	protected virtual void OnDisable() { }

	// RVA: 0x1DCE4F0 Offset: 0x1DCE5F1 VA: 0x1DCE4F0
	protected void Setup() { }

	// RVA: 0x1DD9B10 Offset: 0x1DD9C11 VA: 0x1DD9B10
	private void SetScrollBar() { }

	// RVA: 0x1DD9940 Offset: 0x1DD9A41 VA: 0x1DD9940
	private void UpdateInput() { }

	// RVA: 0x1DD9DA0 Offset: 0x1DD9EA1 VA: 0x1DD9DA0
	private void InputUp() { }

	// RVA: 0x1DDA100 Offset: 0x1DDA201 VA: 0x1DDA100
	private void InputDown() { }

	// RVA: 0x1DDA400 Offset: 0x1DDA501 VA: 0x1DDA400
	private void PageUp() { }

	// RVA: 0x1DDA620 Offset: 0x1DDA721 VA: 0x1DDA620
	private void PageDown() { }

	// RVA: 0x1DDA8C0 Offset: 0x1DDA9C1 VA: 0x1DDA8C0
	public void SetFocusButton(UIButtonLinkerInScrollBox _button) { }

	// RVA: 0x1DCEC00 Offset: 0x1DCED01 VA: 0x1DCEC00
	public void RedispAll() { }

	// RVA: 0x1DD61F0 Offset: 0x1DD62F1 VA: 0x1DD61F0
	public void ResetScrollBox(int _index = 0) { }

	// RVA: 0x1DD96C0 Offset: 0x1DD97C1 VA: 0x1DD96C0
	public void SetScrollbarActive(bool _flag) { }

	// RVA: 0x1DD9D20 Offset: 0x1DD9E21 VA: 0x1DD9D20
	private void SetScrollValue() { }

	// RVA: 0x1DDA8D0 Offset: 0x1DDA9D1 VA: 0x1DDA8D0
	private void OnScrollBarDrag(float _value) { }

	// RVA: 0x1DCFAD0 Offset: 0x1DCFBD1 VA: 0x1DCFAD0
	protected void .ctor() { }
}


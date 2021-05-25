public class OptionFlagButton : ButtonLinkerSetImage // TypeDefIndex: 8802
{
	// Fields
	[SerializeField] // RVA: 0x173920 Offset: 0x173A21 VA: 0x173920
	private RF5OptionData.FLAG optionFlag; // 0xBC
	[SerializeField] // RVA: 0x173930 Offset: 0x173A31 VA: 0x173930
	private Text valueText; // 0xC0
	[SerializeField] // RVA: 0x173940 Offset: 0x173A41 VA: 0x173940
	private NonFocusButton leftArrow; // 0xC8
	[SerializeField] // RVA: 0x173950 Offset: 0x173A51 VA: 0x173950
	private NonFocusButton rightArrow; // 0xD0
	private string[] valueTextID; // 0xD8
	private readonly bool[] valueTable; // 0xE0

	// Properties
	private int _Value { get; set; }

	// Methods

	// RVA: 0x1F1B910 Offset: 0x1F1BA11 VA: 0x1F1B910
	private int get__Value() { }

	// RVA: 0x1F1B9A0 Offset: 0x1F1BAA1 VA: 0x1F1B9A0
	private void set__Value(int value) { }

	// RVA: 0x1F1BA00 Offset: 0x1F1BB01 VA: 0x1F1BA00
	private void OnEnable() { }

	// RVA: 0x1F1BC10 Offset: 0x1F1BD11 VA: 0x1F1BC10
	private void Start() { }

	// RVA: 0x1F1C070 Offset: 0x1F1C171 VA: 0x1F1C070
	private void Update() { }

	// RVA: 0x1F1C1F0 Offset: 0x1F1C2F1 VA: 0x1F1C1F0
	private void DoLeft() { }

	// RVA: 0x1F1C410 Offset: 0x1F1C511 VA: 0x1F1C410
	private void DoRight() { }

	// RVA: 0x1F1BCE0 Offset: 0x1F1BDE1 VA: 0x1F1BCE0
	private void InitValueText() { }

	// RVA: 0x1F1BBA0 Offset: 0x1F1BCA1 VA: 0x1F1BBA0
	private void CheckDrawArrow() { }

	// RVA: 0x1F1C640 Offset: 0x1F1C741 VA: 0x1F1C640 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1F1C650 Offset: 0x1F1C751 VA: 0x1F1C650 Slot: 8
	public override void OnNextFocus(CursorLinker nextObject) { }

	// RVA: 0x1F1C660 Offset: 0x1F1C761 VA: 0x1F1C660
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8770 Offset: 0x1A8871 VA: 0x1A8770
	// RVA: 0x1F1C700 Offset: 0x1F1C801 VA: 0x1F1C700
	private void <Start>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8780 Offset: 0x1A8881 VA: 0x1A8780
	// RVA: 0x1F1C770 Offset: 0x1F1C871 VA: 0x1F1C770
	private void <Start>b__10_1() { }
}


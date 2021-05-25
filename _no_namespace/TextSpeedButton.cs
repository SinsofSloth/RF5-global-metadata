public class TextSpeedButton : ButtonLinkerSetImage // TypeDefIndex: 8807
{
	// Fields
	[SerializeField] // RVA: 0x1739C0 Offset: 0x173AC1 VA: 0x1739C0
	private Text valueText; // 0xC0
	private readonly string[] ValueTextID; // 0xC8
	private readonly float[] ValueTable; // 0xD0
	[SerializeField] // RVA: 0x1739D0 Offset: 0x173AD1 VA: 0x1739D0
	private NonFocusButton leftArrow; // 0xD8
	[SerializeField] // RVA: 0x1739E0 Offset: 0x173AE1 VA: 0x1739E0
	private NonFocusButton rightArrow; // 0xE0

	// Properties
	private int _Value { get; set; }

	// Methods

	// RVA: 0x20B8940 Offset: 0x20B8A41 VA: 0x20B8940
	private int get__Value() { }

	// RVA: 0x20B8A40 Offset: 0x20B8B41 VA: 0x20B8A40
	private void set__Value(int value) { }

	// RVA: 0x20B8AA0 Offset: 0x20B8BA1 VA: 0x20B8AA0
	private void OnEnable() { }

	// RVA: 0x20B8D40 Offset: 0x20B8E41 VA: 0x20B8D40
	private void Start() { }

	// RVA: 0x20B8E10 Offset: 0x20B8F11 VA: 0x20B8E10
	private void Update() { }

	// RVA: 0x20B8C30 Offset: 0x20B8D31 VA: 0x20B8C30
	private void CheckDrawArrow() { }

	// RVA: 0x20B89D0 Offset: 0x20B8AD1 VA: 0x20B89D0
	private int GetTableId(float value) { }

	// RVA: 0x20B8F90 Offset: 0x20B9091 VA: 0x20B8F90
	private void DoLeft() { }

	// RVA: 0x20B9200 Offset: 0x20B9301 VA: 0x20B9200
	private void DoRight() { }

	// RVA: 0x20B9480 Offset: 0x20B9581 VA: 0x20B9480 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x20B9490 Offset: 0x20B9591 VA: 0x20B9490 Slot: 8
	public override void OnNextFocus(CursorLinker nextObject) { }

	// RVA: 0x20B94A0 Offset: 0x20B95A1 VA: 0x20B94A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8790 Offset: 0x1A8891 VA: 0x1A8790
	// RVA: 0x20B9670 Offset: 0x20B9771 VA: 0x20B9670
	private void <Start>b__9_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A87A0 Offset: 0x1A88A1 VA: 0x1A87A0
	// RVA: 0x20B96E0 Offset: 0x20B97E1 VA: 0x20B96E0
	private void <Start>b__9_1() { }
}


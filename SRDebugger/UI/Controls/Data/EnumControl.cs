public class EnumControl : DataBoundControl // TypeDefIndex: 5600
{
	// Fields
	private object _lastValue; // 0x80
	private string[] _names; // 0x88
	private Array _values; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C9E0 Offset: 0x13CAE1 VA: 0x13C9E0
	public LayoutElement ContentLayoutElement; // 0x98
	public GameObject[] DisableOnReadOnly; // 0xA0
	[RequiredFieldAttribute] // RVA: 0x13C9F0 Offset: 0x13CAF1 VA: 0x13C9F0
	public SRSpinner Spinner; // 0xA8
	[RequiredFieldAttribute] // RVA: 0x13CA00 Offset: 0x13CB01 VA: 0x13CA00
	public Text Title; // 0xB0
	[RequiredFieldAttribute] // RVA: 0x13CA10 Offset: 0x13CB11 VA: 0x13CA10
	public Text Value; // 0xB8

	// Methods

	// RVA: 0x1544CC0 Offset: 0x1544DC1 VA: 0x1544CC0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1544D00 Offset: 0x1544E01 VA: 0x1544D00 Slot: 12
	protected override void OnBind(string propertyName, Type t) { }

	// RVA: 0x1544F70 Offset: 0x1545071 VA: 0x1544F70 Slot: 13
	protected override void OnValueUpdated(object newValue) { }

	// RVA: 0x1544FD0 Offset: 0x15450D1 VA: 0x1544FD0 Slot: 14
	public override bool CanBind(Type type, bool isReadOnly) { }

	// RVA: 0x1545000 Offset: 0x1545101 VA: 0x1545000
	private void SetIndex(int i) { }

	// RVA: 0x1545090 Offset: 0x1545191 VA: 0x1545090
	public void GoToNext() { }

	// RVA: 0x1545150 Offset: 0x1545251 VA: 0x1545150
	public void GoToPrevious() { }

	// RVA: 0x1545210 Offset: 0x1545311 VA: 0x1545210
	public void .ctor() { }
}


public class ActionControl : OptionsControlBase // TypeDefIndex: 5598
{
	// Fields
	private MethodReference _method; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C9A0 Offset: 0x13CAA1 VA: 0x13C9A0
	public Button Button; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C9B0 Offset: 0x13CAB1 VA: 0x13C9B0
	public Text Title; // 0x70

	// Properties
	public MethodReference Method { get; }

	// Methods

	// RVA: 0x15446C0 Offset: 0x15447C1 VA: 0x15446C0
	public MethodReference get_Method() { }

	// RVA: 0x15446D0 Offset: 0x15447D1 VA: 0x15446D0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1544770 Offset: 0x1544871 VA: 0x1544770
	private void ButtonOnClick() { }

	// RVA: 0x152F630 Offset: 0x152F731 VA: 0x152F630
	public void SetMethod(string methodName, MethodReference method) { }

	// RVA: 0x15448C0 Offset: 0x15449C1 VA: 0x15448C0
	public void .ctor() { }
}


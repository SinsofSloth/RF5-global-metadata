[AttributeUsageAttribute] // RVA: 0xB1050 Offset: 0xB1151 VA: 0xB1050
[ComVisibleAttribute] // RVA: 0xB1050 Offset: 0xB1151 VA: 0xB1050
public sealed class SoapMethodAttribute : SoapAttribute // TypeDefIndex: 1185
{
	// Fields
	private string _responseElement; // 0x28
	private string _responseNamespace; // 0x30
	private string _returnElement; // 0x38
	private string _soapAction; // 0x40
	private bool _useAttribute; // 0x48
	private string _namespace; // 0x50

	// Properties
	public override bool UseAttribute { get; }
	public override string XmlNamespace { get; }

	// Methods

	// RVA: 0x174A4B0 Offset: 0x174A5B1 VA: 0x174A4B0
	public void .ctor() { }

	// RVA: 0x175CAA0 Offset: 0x175CBA1 VA: 0x175CAA0 Slot: 4
	public override bool get_UseAttribute() { }

	// RVA: 0x175CAB0 Offset: 0x175CBB1 VA: 0x175CAB0 Slot: 5
	public override string get_XmlNamespace() { }

	// RVA: 0x175CAC0 Offset: 0x175CBC1 VA: 0x175CAC0 Slot: 6
	internal override void SetReflectionObject(object reflectionObject) { }
}


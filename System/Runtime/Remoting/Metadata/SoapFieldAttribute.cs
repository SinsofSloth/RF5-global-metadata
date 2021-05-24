[AttributeUsageAttribute] // RVA: 0xB1010 Offset: 0xB1111 VA: 0xB1010
[ComVisibleAttribute] // RVA: 0xB1010 Offset: 0xB1111 VA: 0xB1010
public sealed class SoapFieldAttribute : SoapAttribute // TypeDefIndex: 1184
{
	// Fields
	private string _elementName; // 0x28
	private bool _isElement; // 0x30

	// Properties
	public string XmlElementName { get; }

	// Methods

	// RVA: 0x174A4A0 Offset: 0x174A5A1 VA: 0x174A4A0
	public void .ctor() { }

	// RVA: 0x175C9B0 Offset: 0x175CAB1 VA: 0x175C9B0
	public string get_XmlElementName() { }

	// RVA: 0x175C9C0 Offset: 0x175CAC1 VA: 0x175C9C0
	public bool IsInteropXmlElement() { }

	// RVA: 0x175C9D0 Offset: 0x175CAD1 VA: 0x175C9D0 Slot: 6
	internal override void SetReflectionObject(object reflectionObject) { }
}


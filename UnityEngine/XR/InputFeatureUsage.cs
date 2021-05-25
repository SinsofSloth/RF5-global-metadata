[NativeConditionalAttribute] // RVA: 0x106510 Offset: 0x106611 VA: 0x106510
[RequiredByNativeCodeAttribute] // RVA: 0x106510 Offset: 0x106611 VA: 0x106510
[NativeHeaderAttribute] // RVA: 0x106510 Offset: 0x106611 VA: 0x106510
public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 3724
{
	// Fields
	internal string m_Name; // 0x0
	[NativeNameAttribute] // RVA: 0x106F70 Offset: 0x107071 VA: 0x106F70
	internal InputFeatureType m_InternalType; // 0x8

	// Properties
	public string name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0x25C90 Offset: 0x25D91 VA: 0x25C90
	public string get_name() { }

	// RVA: 0x25CA0 Offset: 0x25DA1 VA: 0x25CA0
	internal InputFeatureType get_internalType() { }

	// RVA: 0x25CB0 Offset: 0x25DB1 VA: 0x25CB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25D80 Offset: 0x25E81 VA: 0x25D80 Slot: 4
	public bool Equals(InputFeatureUsage other) { }

	// RVA: 0x25DD0 Offset: 0x25ED1 VA: 0x25DD0 Slot: 2
	public override int GetHashCode() { }
}


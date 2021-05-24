[NativeHeaderAttribute] // RVA: 0x1066B0 Offset: 0x1067B1 VA: 0x1066B0
[NativeHeaderAttribute] // RVA: 0x1066B0 Offset: 0x1067B1 VA: 0x1066B0
[NativeConditionalAttribute] // RVA: 0x1066B0 Offset: 0x1067B1 VA: 0x1066B0
[NativeHeaderAttribute] // RVA: 0x1066B0 Offset: 0x1067B1 VA: 0x1066B0
[RequiredByNativeCodeAttribute] // RVA: 0x1066B0 Offset: 0x1067B1 VA: 0x1066B0
[StaticAccessorAttribute] // RVA: 0x1066B0 Offset: 0x1067B1 VA: 0x1066B0
public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 3727
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x256F0 Offset: 0x257F1 VA: 0x256F0
	internal ulong get_deviceId() { }

	// RVA: 0x25700 Offset: 0x25801 VA: 0x25700
	internal uint get_featureIndex() { }

	// RVA: 0x25710 Offset: 0x25811 VA: 0x25710 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x257E0 Offset: 0x258E1 VA: 0x257E0 Slot: 4
	public bool Equals(Eyes other) { }

	// RVA: 0x25810 Offset: 0x25911 VA: 0x25810 Slot: 2
	public override int GetHashCode() { }
}


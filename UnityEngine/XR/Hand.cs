[NativeHeaderAttribute] // RVA: 0x1065D0 Offset: 0x1066D1 VA: 0x1065D0
[RequiredByNativeCodeAttribute] // RVA: 0x1065D0 Offset: 0x1066D1 VA: 0x1065D0
[NativeConditionalAttribute] // RVA: 0x1065D0 Offset: 0x1066D1 VA: 0x1065D0
[StaticAccessorAttribute] // RVA: 0x1065D0 Offset: 0x1066D1 VA: 0x1065D0
[NativeHeaderAttribute] // RVA: 0x1065D0 Offset: 0x1066D1 VA: 0x1065D0
[NativeHeaderAttribute] // RVA: 0x1065D0 Offset: 0x1066D1 VA: 0x1065D0
public struct Hand : IEquatable<Hand> // TypeDefIndex: 3726
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x25870 Offset: 0x25971 VA: 0x25870
	internal ulong get_deviceId() { }

	// RVA: 0x25880 Offset: 0x25981 VA: 0x25880
	internal uint get_featureIndex() { }

	// RVA: 0x25890 Offset: 0x25991 VA: 0x25890 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25960 Offset: 0x25A61 VA: 0x25960 Slot: 4
	public bool Equals(Hand other) { }

	// RVA: 0x25990 Offset: 0x25A91 VA: 0x25990 Slot: 2
	public override int GetHashCode() { }
}


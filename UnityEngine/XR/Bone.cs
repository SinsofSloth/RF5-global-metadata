[NativeConditionalAttribute] // RVA: 0x106790 Offset: 0x106891 VA: 0x106790
[StaticAccessorAttribute] // RVA: 0x106790 Offset: 0x106891 VA: 0x106790
[NativeHeaderAttribute] // RVA: 0x106790 Offset: 0x106891 VA: 0x106790
[NativeHeaderAttribute] // RVA: 0x106790 Offset: 0x106891 VA: 0x106790
[NativeHeaderAttribute] // RVA: 0x106790 Offset: 0x106891 VA: 0x106790
[RequiredByNativeCodeAttribute] // RVA: 0x106790 Offset: 0x106891 VA: 0x106790
public struct Bone : IEquatable<Bone> // TypeDefIndex: 3728
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x25570 Offset: 0x25671 VA: 0x25570
	internal ulong get_deviceId() { }

	// RVA: 0x25580 Offset: 0x25681 VA: 0x25580
	internal uint get_featureIndex() { }

	// RVA: 0x25590 Offset: 0x25691 VA: 0x25590 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25660 Offset: 0x25761 VA: 0x25660 Slot: 4
	public bool Equals(Bone other) { }

	// RVA: 0x25690 Offset: 0x25791 VA: 0x25690 Slot: 2
	public override int GetHashCode() { }
}


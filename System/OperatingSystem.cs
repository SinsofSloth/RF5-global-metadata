[ComVisibleAttribute] // RVA: 0xACE90 Offset: 0xACF91 VA: 0xACE90
[Serializable]
public sealed class OperatingSystem : ICloneable, ISerializable // TypeDefIndex: 395
{
	// Fields
	private PlatformID _platform; // 0x10
	private Version _version; // 0x18
	private string _servicePack; // 0x20

	// Properties
	public PlatformID Platform { get; }
	public string ServicePack { get; }

	// Methods

	// RVA: 0x18EBC10 Offset: 0x18EBD11 VA: 0x18EBC10
	public void .ctor(PlatformID platform, Version version) { }

	// RVA: 0x18EBD70 Offset: 0x18EBE71 VA: 0x18EBD70
	private void .ctor(SerializationInfo information, StreamingContext context) { }

	// RVA: 0x18EBF00 Offset: 0x18EC001 VA: 0x18EBF00
	public PlatformID get_Platform() { }

	// RVA: 0x18EBF10 Offset: 0x18EC011 VA: 0x18EBF10
	public string get_ServicePack() { }

	// RVA: 0x18EBF20 Offset: 0x18EC021 VA: 0x18EBF20 Slot: 4
	public object Clone() { }

	// RVA: 0x18EBFA0 Offset: 0x18EC0A1 VA: 0x18EBFA0 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18EC070 Offset: 0x18EC171 VA: 0x18EC070 Slot: 3
	public override string ToString() { }
}


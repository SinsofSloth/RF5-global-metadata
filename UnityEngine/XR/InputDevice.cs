[NativeConditionalAttribute] // RVA: 0x106580 Offset: 0x106681 VA: 0x106580
[UsedByNativeCodeAttribute] // RVA: 0x106580 Offset: 0x106681 VA: 0x106580
public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 3725
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	// Properties
	private ulong deviceId { get; }

	// Methods

	// RVA: 0x25A40 Offset: 0x25B41 VA: 0x25A40
	internal void .ctor(ulong deviceId) { }

	// RVA: 0x25A50 Offset: 0x25B51 VA: 0x25A50
	private ulong get_deviceId() { }

	// RVA: 0x25A70 Offset: 0x25B71 VA: 0x25A70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25B40 Offset: 0x25C41 VA: 0x25B40 Slot: 4
	public bool Equals(InputDevice other) { }

	// RVA: 0x25B70 Offset: 0x25C71 VA: 0x25B70 Slot: 2
	public override int GetHashCode() { }
}


public struct NpadState // TypeDefIndex: 11564
{
	// Fields
	public long samplingNumber; // 0x0
	public NpadButton buttons; // 0x8
	public AnalogStickState analogStickL; // 0x10
	public AnalogStickState analogStickR; // 0x18
	public NpadAttribute attributes; // 0x20
	public NpadButton preButtons; // 0x28

	// Methods

	// RVA: 0x3855C0 Offset: 0x3856C1 VA: 0x3855C0
	public void Clear() { }

	// RVA: 0x385600 Offset: 0x385701 VA: 0x385600
	public bool GetButton(NpadButton button) { }

	// RVA: 0x385610 Offset: 0x385711 VA: 0x385610
	public bool GetButtonDown(NpadButton button) { }

	// RVA: 0x385640 Offset: 0x385741 VA: 0x385640
	public bool GetButtonUp(NpadButton button) { }

	// RVA: 0x385670 Offset: 0x385771 VA: 0x385670 Slot: 3
	public override string ToString() { }
}


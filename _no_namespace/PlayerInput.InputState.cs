protected class PlayerInput.InputState // TypeDefIndex: 6685
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1954B0 Offset: 0x1955B1 VA: 0x1954B0
	private Key <Key>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x1954C0 Offset: 0x1955C1 VA: 0x1954C0
	private PlayerInput.KeyState <State>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x1954D0 Offset: 0x1955D1 VA: 0x1954D0
	private float <Elapsed>k__BackingField; // 0x18
	private bool m_EnablePushEnter; // 0x1C

	// Properties
	public Key Key { get; set; }
	public PlayerInput.KeyState State { get; set; }
	public bool IsStandby { get; }
	public bool IsEntry { get; }
	public bool IsPress { get; }
	public bool IsRelease { get; }
	public float Elapsed { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B0950 Offset: 0x1B0A51 VA: 0x1B0950
	// RVA: 0x21FDB40 Offset: 0x21FDC41 VA: 0x21FDB40
	public Key get_Key() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B0960 Offset: 0x1B0A61 VA: 0x1B0960
	// RVA: 0x21FDB50 Offset: 0x21FDC51 VA: 0x21FDB50
	private void set_Key(Key value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B0970 Offset: 0x1B0A71 VA: 0x1B0970
	// RVA: 0x21FDB60 Offset: 0x21FDC61 VA: 0x21FDB60
	public PlayerInput.KeyState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B0980 Offset: 0x1B0A81 VA: 0x1B0980
	// RVA: 0x21FDB70 Offset: 0x21FDC71 VA: 0x21FDB70
	private void set_State(PlayerInput.KeyState value) { }

	// RVA: 0x21FDB80 Offset: 0x21FDC81 VA: 0x21FDB80
	public bool get_IsStandby() { }

	// RVA: 0x21FDB90 Offset: 0x21FDC91 VA: 0x21FDB90
	public bool get_IsEntry() { }

	// RVA: 0x21FDBA0 Offset: 0x21FDCA1 VA: 0x21FDBA0
	public bool get_IsPress() { }

	// RVA: 0x21FDBC0 Offset: 0x21FDCC1 VA: 0x21FDBC0
	public bool get_IsRelease() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B0990 Offset: 0x1B0A91 VA: 0x1B0990
	// RVA: 0x21FDBD0 Offset: 0x21FDCD1 VA: 0x21FDBD0
	public float get_Elapsed() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B09A0 Offset: 0x1B0AA1 VA: 0x1B09A0
	// RVA: 0x21FDBE0 Offset: 0x21FDCE1 VA: 0x21FDBE0
	public void set_Elapsed(float value) { }

	// RVA: 0x21FDBF0 Offset: 0x21FDCF1 VA: 0x21FDBF0
	public void .ctor(Key key, bool enablePushEnter) { }

	// RVA: 0x21FDC50 Offset: 0x21FDD51 VA: 0x21FDC50
	public void Update() { }

	// RVA: 0x21FDDC0 Offset: 0x21FDEC1 VA: 0x21FDDC0
	public void Press() { }

	// RVA: 0x21FDDE0 Offset: 0x21FDEE1 VA: 0x21FDDE0
	public void Release() { }

	// RVA: 0x21FDC40 Offset: 0x21FDD41 VA: 0x21FDC40
	public void Clear() { }
}


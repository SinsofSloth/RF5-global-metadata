[RequiredByNativeCodeAttribute] // RVA: 0xE8970 Offset: 0xE8A71 VA: 0xE8970
[NativeHeaderAttribute] // RVA: 0xE8970 Offset: 0xE8A71 VA: 0xE8970
public struct AnimatorStateInfo // TypeDefIndex: 3483
{
	// Fields
	private int m_Name; // 0x0
	private int m_Path; // 0x4
	private int m_FullPath; // 0x8
	private float m_NormalizedTime; // 0xC
	private float m_Length; // 0x10
	private float m_Speed; // 0x14
	private float m_SpeedMultiplier; // 0x18
	private int m_Tag; // 0x1C
	private int m_Loop; // 0x20

	// Properties
	public int fullPathHash { get; }
	public int shortNameHash { get; }
	public float normalizedTime { get; }
	public float length { get; }
	public float speed { get; }
	public bool loop { get; }

	// Methods

	// RVA: 0x1D930 Offset: 0x1DA31 VA: 0x1D930
	public bool IsName(string name) { }

	// RVA: 0x1D9D0 Offset: 0x1DAD1 VA: 0x1D9D0
	public int get_fullPathHash() { }

	// RVA: 0x1D9E0 Offset: 0x1DAE1 VA: 0x1D9E0
	public int get_shortNameHash() { }

	// RVA: 0x1D9F0 Offset: 0x1DAF1 VA: 0x1D9F0
	public float get_normalizedTime() { }

	// RVA: 0x1DA00 Offset: 0x1DB01 VA: 0x1DA00
	public float get_length() { }

	// RVA: 0x1DA10 Offset: 0x1DB11 VA: 0x1DA10
	public float get_speed() { }

	// RVA: 0x1DA20 Offset: 0x1DB21 VA: 0x1DA20
	public bool get_loop() { }
}


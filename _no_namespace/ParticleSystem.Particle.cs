[RequiredByNativeCodeAttribute] // RVA: 0x111C80 Offset: 0x111D81 VA: 0x111C80
public struct ParticleSystem.Particle // TypeDefIndex: 3821
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Vector3 m_Velocity; // 0xC
	private Vector3 m_AnimatedVelocity; // 0x18
	private Vector3 m_InitialVelocity; // 0x24
	private Vector3 m_AxisOfRotation; // 0x30
	private Vector3 m_Rotation; // 0x3C
	private Vector3 m_AngularVelocity; // 0x48
	private Vector3 m_StartSize; // 0x54
	private Color32 m_StartColor; // 0x60
	private uint m_RandomSeed; // 0x64
	private uint m_ParentRandomSeed; // 0x68
	private float m_Lifetime; // 0x6C
	private float m_StartLifetime; // 0x70
	private int m_MeshIndex; // 0x74
	private float m_EmitAccumulator0; // 0x78
	private float m_EmitAccumulator1; // 0x7C
	private uint m_Flags; // 0x80

	// Properties
	[ObsoleteAttribute] // RVA: 0x113BF0 Offset: 0x113CF1 VA: 0x113BF0
	public float lifetime { set; }
	public Vector3 position { get; set; }
	public Vector3 velocity { set; }
	public float remainingLifetime { set; }
	public float startLifetime { set; }
	public Color32 startColor { set; }
	public uint randomSeed { set; }
	public float startSize { set; }
	public Vector3 rotation3D { set; }
	public Vector3 angularVelocity3D { set; }

	// Methods

	// RVA: 0x1FC50 Offset: 0x1FD51 VA: 0x1FC50
	public void set_lifetime(float value) { }

	// RVA: 0x1FC60 Offset: 0x1FD61 VA: 0x1FC60
	public Vector3 get_position() { }

	// RVA: 0x1FC70 Offset: 0x1FD71 VA: 0x1FC70
	public void set_position(Vector3 value) { }

	// RVA: 0x1FC80 Offset: 0x1FD81 VA: 0x1FC80
	public void set_velocity(Vector3 value) { }

	// RVA: 0x1FC90 Offset: 0x1FD91 VA: 0x1FC90
	public void set_remainingLifetime(float value) { }

	// RVA: 0x1FCA0 Offset: 0x1FDA1 VA: 0x1FCA0
	public void set_startLifetime(float value) { }

	// RVA: 0x1FCB0 Offset: 0x1FDB1 VA: 0x1FCB0
	public void set_startColor(Color32 value) { }

	// RVA: 0x1FCC0 Offset: 0x1FDC1 VA: 0x1FCC0
	public void set_randomSeed(uint value) { }

	// RVA: 0x1FCD0 Offset: 0x1FDD1 VA: 0x1FCD0
	public void set_startSize(float value) { }

	// RVA: 0x1FD20 Offset: 0x1FE21 VA: 0x1FD20
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x1FDD0 Offset: 0x1FED1 VA: 0x1FDD0
	public void set_angularVelocity3D(Vector3 value) { }
}


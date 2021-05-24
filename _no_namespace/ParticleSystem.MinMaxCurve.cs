[NativeTypeAttribute] // RVA: 0x111CD0 Offset: 0x111DD1 VA: 0x111CD0
[Serializable]
public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 3822
{
	// Fields
	[SerializeField] // RVA: 0x112020 Offset: 0x112121 VA: 0x112020
	private ParticleSystemCurveMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x112030 Offset: 0x112131 VA: 0x112030
	private float m_CurveMultiplier; // 0x4
	[SerializeField] // RVA: 0x112040 Offset: 0x112141 VA: 0x112040
	private AnimationCurve m_CurveMin; // 0x8
	[SerializeField] // RVA: 0x112050 Offset: 0x112151 VA: 0x112050
	private AnimationCurve m_CurveMax; // 0x10
	[SerializeField] // RVA: 0x112060 Offset: 0x112161 VA: 0x112060
	private float m_ConstantMin; // 0x18
	[SerializeField] // RVA: 0x112070 Offset: 0x112171 VA: 0x112070
	private float m_ConstantMax; // 0x1C

	// Properties
	public float constantMax { get; }

	// Methods

	// RVA: 0x1FAF0 Offset: 0x1FBF1 VA: 0x1FAF0
	public void .ctor(float constant) { }

	// RVA: 0x1FB40 Offset: 0x1FC41 VA: 0x1FB40
	public float get_constantMax() { }

	// RVA: 0x1B5EE60 Offset: 0x1B5EF61 VA: 0x1B5EE60
	public static ParticleSystem.MinMaxCurve op_Implicit(float constant) { }
}


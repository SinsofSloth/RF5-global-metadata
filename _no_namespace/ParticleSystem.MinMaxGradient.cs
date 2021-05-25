[NativeTypeAttribute] // RVA: 0x111D30 Offset: 0x111E31 VA: 0x111D30
[Serializable]
public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 3823
{
	// Fields
	[SerializeField] // RVA: 0x112080 Offset: 0x112181 VA: 0x112080
	private ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x112090 Offset: 0x112191 VA: 0x112090
	private Gradient m_GradientMin; // 0x8
	[SerializeField] // RVA: 0x1120A0 Offset: 0x1121A1 VA: 0x1120A0
	private Gradient m_GradientMax; // 0x10
	[SerializeField] // RVA: 0x1120B0 Offset: 0x1121B1 VA: 0x1120B0
	private Color m_ColorMin; // 0x18
	[SerializeField] // RVA: 0x1120C0 Offset: 0x1121C1 VA: 0x1120C0
	private Color m_ColorMax; // 0x28

	// Properties
	public Color color { get; }

	// Methods

	// RVA: 0x1FB50 Offset: 0x1FC51 VA: 0x1FB50
	public void .ctor(Color color) { }

	// RVA: 0x1FBE0 Offset: 0x1FCE1 VA: 0x1FBE0
	public Color get_color() { }

	// RVA: 0x1B5F430 Offset: 0x1B5F531 VA: 0x1B5F430
	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }
}


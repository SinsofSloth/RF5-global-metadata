public struct ParticleSystem.EmissionModule // TypeDefIndex: 3817
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { set; }
	public float rateOverTimeMultiplier { get; }

	// Methods

	// RVA: 0x1E820 Offset: 0x1E921 VA: 0x1E820
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x1E830 Offset: 0x1E931 VA: 0x1E830
	public bool get_enabled() { }

	// RVA: 0x1E880 Offset: 0x1E981 VA: 0x1E880
	public void set_enabled(bool value) { }

	// RVA: 0x1E8D0 Offset: 0x1E9D1 VA: 0x1E8D0
	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1E930 Offset: 0x1EA31 VA: 0x1E930
	public float get_rateOverTimeMultiplier() { }

	// RVA: 0x1B625A0 Offset: 0x1B626A1 VA: 0x1B625A0
	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x1B625F0 Offset: 0x1B626F1 VA: 0x1B625F0
	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	// RVA: 0x1B62640 Offset: 0x1B62741 VA: 0x1B62640
	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B62690 Offset: 0x1B62791 VA: 0x1B62690
	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }
}


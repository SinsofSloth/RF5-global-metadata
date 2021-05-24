public struct ParticleSystem.MainModule // TypeDefIndex: 3816
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public float duration { get; }
	public bool loop { get; set; }
	public bool prewarm { set; }
	public ParticleSystem.MinMaxCurve startDelay { set; }
	public float startDelayMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startLifetime { get; set; }
	public float startLifetimeMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startSpeed { set; }
	public float startSpeedMultiplier { get; set; }
	[NativeNameAttribute] // RVA: 0x113AF0 Offset: 0x113BF1 VA: 0x113AF0
	public ParticleSystem.MinMaxCurve startSize { set; }
	[NativeNameAttribute] // RVA: 0x113B30 Offset: 0x113C31 VA: 0x113B30
	public float startSizeMultiplier { get; set; }
	[NativeNameAttribute] // RVA: 0x113B70 Offset: 0x113C71 VA: 0x113B70
	public ParticleSystem.MinMaxCurve startRotation { set; }
	[NativeNameAttribute] // RVA: 0x113BB0 Offset: 0x113CB1 VA: 0x113BB0
	public float startRotationMultiplier { get; set; }
	public float startRotationXMultiplier { get; set; }
	public float startRotationYMultiplier { get; set; }
	public float startRotationZMultiplier { get; set; }
	public ParticleSystem.MinMaxGradient startColor { get; set; }
	public float gravityModifierMultiplier { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { get; set; }
	public float simulationSpeed { get; set; }
	public ParticleSystemScalingMode scalingMode { get; set; }
	public bool playOnAwake { get; set; }
	public int maxParticles { get; set; }
	public ParticleSystemStopAction stopAction { set; }

	// Methods

	// RVA: 0x1ED30 Offset: 0x1EE31 VA: 0x1ED30
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x1ED40 Offset: 0x1EE41 VA: 0x1ED40
	public float get_duration() { }

	// RVA: 0x1ED90 Offset: 0x1EE91 VA: 0x1ED90
	public bool get_loop() { }

	// RVA: 0x1EDE0 Offset: 0x1EEE1 VA: 0x1EDE0
	public void set_loop(bool value) { }

	// RVA: 0x1EE30 Offset: 0x1EF31 VA: 0x1EE30
	public void set_prewarm(bool value) { }

	// RVA: 0x1EE80 Offset: 0x1EF81 VA: 0x1EE80
	public void set_startDelay(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1EEE0 Offset: 0x1EFE1 VA: 0x1EEE0
	public float get_startDelayMultiplier() { }

	// RVA: 0x1EF30 Offset: 0x1F031 VA: 0x1EF30
	public void set_startDelayMultiplier(float value) { }

	// RVA: 0x1EF80 Offset: 0x1F081 VA: 0x1EF80
	public ParticleSystem.MinMaxCurve get_startLifetime() { }

	// RVA: 0x1F000 Offset: 0x1F101 VA: 0x1F000
	public void set_startLifetime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1F060 Offset: 0x1F161 VA: 0x1F060
	public float get_startLifetimeMultiplier() { }

	// RVA: 0x1F0B0 Offset: 0x1F1B1 VA: 0x1F0B0
	public void set_startLifetimeMultiplier(float value) { }

	// RVA: 0x1F100 Offset: 0x1F201 VA: 0x1F100
	public void set_startSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1F160 Offset: 0x1F261 VA: 0x1F160
	public float get_startSpeedMultiplier() { }

	// RVA: 0x1F1B0 Offset: 0x1F2B1 VA: 0x1F1B0
	public void set_startSpeedMultiplier(float value) { }

	// RVA: 0x1F200 Offset: 0x1F301 VA: 0x1F200
	public void set_startSize(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1F260 Offset: 0x1F361 VA: 0x1F260
	public float get_startSizeMultiplier() { }

	// RVA: 0x1F2B0 Offset: 0x1F3B1 VA: 0x1F2B0
	public void set_startSizeMultiplier(float value) { }

	// RVA: 0x1F300 Offset: 0x1F401 VA: 0x1F300
	public void set_startRotation(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1F360 Offset: 0x1F461 VA: 0x1F360
	public float get_startRotationMultiplier() { }

	// RVA: 0x1F3B0 Offset: 0x1F4B1 VA: 0x1F3B0
	public void set_startRotationMultiplier(float value) { }

	// RVA: 0x1F400 Offset: 0x1F501 VA: 0x1F400
	public float get_startRotationXMultiplier() { }

	// RVA: 0x1F450 Offset: 0x1F551 VA: 0x1F450
	public void set_startRotationXMultiplier(float value) { }

	// RVA: 0x1F4A0 Offset: 0x1F5A1 VA: 0x1F4A0
	public float get_startRotationYMultiplier() { }

	// RVA: 0x1F4F0 Offset: 0x1F5F1 VA: 0x1F4F0
	public void set_startRotationYMultiplier(float value) { }

	// RVA: 0x1F540 Offset: 0x1F641 VA: 0x1F540
	public float get_startRotationZMultiplier() { }

	// RVA: 0x1F590 Offset: 0x1F691 VA: 0x1F590
	public void set_startRotationZMultiplier(float value) { }

	// RVA: 0x1F5E0 Offset: 0x1F6E1 VA: 0x1F5E0
	public ParticleSystem.MinMaxGradient get_startColor() { }

	// RVA: 0x1F670 Offset: 0x1F771 VA: 0x1F670
	public void set_startColor(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x1F6E0 Offset: 0x1F7E1 VA: 0x1F6E0
	public float get_gravityModifierMultiplier() { }

	// RVA: 0x1F730 Offset: 0x1F831 VA: 0x1F730
	public void set_gravityModifierMultiplier(float value) { }

	// RVA: 0x1F780 Offset: 0x1F881 VA: 0x1F780
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	// RVA: 0x1F7D0 Offset: 0x1F8D1 VA: 0x1F7D0
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x1F820 Offset: 0x1F921 VA: 0x1F820
	public float get_simulationSpeed() { }

	// RVA: 0x1F870 Offset: 0x1F971 VA: 0x1F870
	public void set_simulationSpeed(float value) { }

	// RVA: 0x1F8C0 Offset: 0x1F9C1 VA: 0x1F8C0
	public ParticleSystemScalingMode get_scalingMode() { }

	// RVA: 0x1F910 Offset: 0x1FA11 VA: 0x1F910
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0x1F960 Offset: 0x1FA61 VA: 0x1F960
	public bool get_playOnAwake() { }

	// RVA: 0x1F9B0 Offset: 0x1FAB1 VA: 0x1F9B0
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1FA00 Offset: 0x1FB01 VA: 0x1FA00
	public int get_maxParticles() { }

	// RVA: 0x1FA50 Offset: 0x1FB51 VA: 0x1FA50
	public void set_maxParticles(int value) { }

	// RVA: 0x1FAA0 Offset: 0x1FBA1 VA: 0x1FAA0
	public void set_stopAction(ParticleSystemStopAction value) { }

	// RVA: 0x1B626E0 Offset: 0x1B627E1 VA: 0x1B626E0
	private static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B62730 Offset: 0x1B62831 VA: 0x1B62730
	private static bool get_loop_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B62780 Offset: 0x1B62881 VA: 0x1B62780
	private static void set_loop_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x1B62820 Offset: 0x1B62921 VA: 0x1B62820
	private static void set_prewarm_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x1B628C0 Offset: 0x1B629C1 VA: 0x1B628C0
	private static void set_startDelay_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B62910 Offset: 0x1B62A11 VA: 0x1B62910
	private static float get_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B62960 Offset: 0x1B62A61 VA: 0x1B62960
	private static void set_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1B62A30 Offset: 0x1B62B31 VA: 0x1B62A30
	private static void get_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1B62AD0 Offset: 0x1B62BD1 VA: 0x1B62AD0
	private static void set_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B62B20 Offset: 0x1B62C21 VA: 0x1B62B20
	private static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B62B70 Offset: 0x1B62C71 VA: 0x1B62B70
	private static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1B62C10 Offset: 0x1B62D11 VA: 0x1B62C10
	private static void set_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B62C60 Offset: 0x1B62D61 VA: 0x1B62C60
	private static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B62CB0 Offset: 0x1B62DB1 VA: 0x1B62CB0
	private static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1B62D50 Offset: 0x1B62E51 VA: 0x1B62D50
	private static void set_startSize_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B62DA0 Offset: 0x1B62EA1 VA: 0x1B62DA0
	private static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B62DF0 Offset: 0x1B62EF1 VA: 0x1B62DF0
	private static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1B62E90 Offset: 0x1B62F91 VA: 0x1B62E90
	private static void set_startRotation_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B62EE0 Offset: 0x1B62FE1 VA: 0x1B62EE0
	private static float get_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B62F30 Offset: 0x1B63031 VA: 0x1B62F30
	private static void set_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1B62F80 Offset: 0x1B63081 VA: 0x1B62F80
	private static float get_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B62FD0 Offset: 0x1B630D1 VA: 0x1B62FD0
	private static void set_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1B63020 Offset: 0x1B63121 VA: 0x1B63020
	private static float get_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B63070 Offset: 0x1B63171 VA: 0x1B63070
	private static void set_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1B630C0 Offset: 0x1B631C1 VA: 0x1B630C0
	private static float get_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B63110 Offset: 0x1B63211 VA: 0x1B63110
	private static void set_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1B63160 Offset: 0x1B63261 VA: 0x1B63160
	private static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret) { }

	// RVA: 0x1B631B0 Offset: 0x1B632B1 VA: 0x1B631B0
	private static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x1B63200 Offset: 0x1B63301 VA: 0x1B63200
	private static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B63250 Offset: 0x1B63351 VA: 0x1B63250
	private static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1B632A0 Offset: 0x1B633A1 VA: 0x1B632A0
	private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B632F0 Offset: 0x1B633F1 VA: 0x1B632F0
	private static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	// RVA: 0x1B63340 Offset: 0x1B63441 VA: 0x1B63340
	private static float get_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B63390 Offset: 0x1B63491 VA: 0x1B63390
	private static void set_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1B633E0 Offset: 0x1B634E1 VA: 0x1B633E0
	private static ParticleSystemScalingMode get_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B63430 Offset: 0x1B63531 VA: 0x1B63430
	private static void set_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemScalingMode value) { }

	// RVA: 0x1B63480 Offset: 0x1B63581 VA: 0x1B63480
	private static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B634D0 Offset: 0x1B635D1 VA: 0x1B634D0
	private static void set_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x1B63520 Offset: 0x1B63621 VA: 0x1B63520
	private static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1B63570 Offset: 0x1B63671 VA: 0x1B63570
	private static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value) { }

	// RVA: 0x1B63610 Offset: 0x1B63711 VA: 0x1B63610
	private static void set_stopAction_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemStopAction value) { }
}


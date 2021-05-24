[NativeHeaderAttribute] // RVA: 0x111AD0 Offset: 0x111BD1 VA: 0x111AD0
[UsedByNativeCodeAttribute] // RVA: 0x111AD0 Offset: 0x111BD1 VA: 0x111AD0
[NativeHeaderAttribute] // RVA: 0x111AD0 Offset: 0x111BD1 VA: 0x111AD0
[NativeHeaderAttribute] // RVA: 0x111AD0 Offset: 0x111BD1 VA: 0x111AD0
[RequireComponent] // RVA: 0x111AD0 Offset: 0x111BD1 VA: 0x111AD0
[NativeHeaderAttribute] // RVA: 0x111AD0 Offset: 0x111BD1 VA: 0x111AD0
[NativeHeaderAttribute] // RVA: 0x111AD0 Offset: 0x111BD1 VA: 0x111AD0
[NativeHeaderAttribute] // RVA: 0x111AD0 Offset: 0x111BD1 VA: 0x111AD0
[NativeHeaderAttribute] // RVA: 0x111AD0 Offset: 0x111BD1 VA: 0x111AD0
[NativeHeaderAttribute] // RVA: 0x111AD0 Offset: 0x111BD1 VA: 0x111AD0
public sealed class ParticleSystem : Component // TypeDefIndex: 3815
{
	// Properties
	[ObsoleteAttribute] // RVA: 0x113670 Offset: 0x113771 VA: 0x113670
	public float startDelay { get; set; }
	[ObsoleteAttribute] // RVA: 0x1136B0 Offset: 0x1137B1 VA: 0x1136B0
	public bool loop { get; set; }
	[ObsoleteAttribute] // RVA: 0x1136F0 Offset: 0x1137F1 VA: 0x1136F0
	public bool playOnAwake { get; set; }
	[ObsoleteAttribute] // RVA: 0x113730 Offset: 0x113831 VA: 0x113730
	public float duration { get; }
	[ObsoleteAttribute] // RVA: 0x113770 Offset: 0x113871 VA: 0x113770
	public float playbackSpeed { get; set; }
	[ObsoleteAttribute] // RVA: 0x1137B0 Offset: 0x1138B1 VA: 0x1137B0
	public bool enableEmission { get; set; }
	[ObsoleteAttribute] // RVA: 0x1137F0 Offset: 0x1138F1 VA: 0x1137F0
	public float emissionRate { get; set; }
	[ObsoleteAttribute] // RVA: 0x113830 Offset: 0x113931 VA: 0x113830
	public float startSpeed { get; set; }
	[ObsoleteAttribute] // RVA: 0x113870 Offset: 0x113971 VA: 0x113870
	public float startSize { get; set; }
	[ObsoleteAttribute] // RVA: 0x1138B0 Offset: 0x1139B1 VA: 0x1138B0
	public Color startColor { get; set; }
	[ObsoleteAttribute] // RVA: 0x1138F0 Offset: 0x1139F1 VA: 0x1138F0
	public float startRotation { get; set; }
	[ObsoleteAttribute] // RVA: 0x113930 Offset: 0x113A31 VA: 0x113930
	public Vector3 startRotation3D { get; set; }
	[ObsoleteAttribute] // RVA: 0x113970 Offset: 0x113A71 VA: 0x113970
	public float startLifetime { get; set; }
	[ObsoleteAttribute] // RVA: 0x1139B0 Offset: 0x113AB1 VA: 0x1139B0
	public float gravityModifier { get; set; }
	[ObsoleteAttribute] // RVA: 0x1139F0 Offset: 0x113AF1 VA: 0x1139F0
	public int maxParticles { get; set; }
	[ObsoleteAttribute] // RVA: 0x113A30 Offset: 0x113B31 VA: 0x113A30
	public ParticleSystemSimulationSpace simulationSpace { get; set; }
	[ObsoleteAttribute] // RVA: 0x113A70 Offset: 0x113B71 VA: 0x113A70
	public ParticleSystemScalingMode scalingMode { get; set; }
	[ObsoleteAttribute] // RVA: 0x113AB0 Offset: 0x113BB1 VA: 0x113AB0
	public bool automaticCullingEnabled { get; }
	public bool isPlaying { get; }
	public bool isEmitting { get; }
	public bool isStopped { get; }
	public bool isPaused { get; }
	public int particleCount { get; }
	public float time { get; set; }
	public uint randomSeed { get; set; }
	public bool useAutoRandomSeed { get; set; }
	public bool proceduralSimulationSupported { get; }
	public ParticleSystem.MainModule main { get; }
	public ParticleSystem.EmissionModule emission { get; }
	public ParticleSystem.ShapeModule shape { get; }
	public ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime { get; }
	public ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get; }
	public ParticleSystem.InheritVelocityModule inheritVelocity { get; }
	public ParticleSystem.ForceOverLifetimeModule forceOverLifetime { get; }
	public ParticleSystem.ColorOverLifetimeModule colorOverLifetime { get; }
	public ParticleSystem.ColorBySpeedModule colorBySpeed { get; }
	public ParticleSystem.SizeOverLifetimeModule sizeOverLifetime { get; }
	public ParticleSystem.SizeBySpeedModule sizeBySpeed { get; }
	public ParticleSystem.RotationOverLifetimeModule rotationOverLifetime { get; }
	public ParticleSystem.RotationBySpeedModule rotationBySpeed { get; }
	public ParticleSystem.ExternalForcesModule externalForces { get; }
	public ParticleSystem.NoiseModule noise { get; }
	public ParticleSystem.CollisionModule collision { get; }
	public ParticleSystem.TriggerModule trigger { get; }
	public ParticleSystem.SubEmittersModule subEmitters { get; }
	public ParticleSystem.TextureSheetAnimationModule textureSheetAnimation { get; }
	public ParticleSystem.LightsModule lights { get; }
	public ParticleSystem.TrailModule trails { get; }
	public ParticleSystem.CustomDataModule customData { get; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x1123D0 Offset: 0x1124D1 VA: 0x1123D0
	// RVA: 0x1B5DFB0 Offset: 0x1B5E0B1 VA: 0x1B5DFB0
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[ObsoleteAttribute] // RVA: 0x112410 Offset: 0x112511 VA: 0x112410
	// RVA: 0x1B5E460 Offset: 0x1B5E561 VA: 0x1B5E460
	public void Emit(ParticleSystem.Particle particle) { }

	// RVA: 0x1B5E4B0 Offset: 0x1B5E5B1 VA: 0x1B5E4B0
	public float get_startDelay() { }

	// RVA: 0x1B5E590 Offset: 0x1B5E691 VA: 0x1B5E590
	public void set_startDelay(float value) { }

	// RVA: 0x1B5E650 Offset: 0x1B5E751 VA: 0x1B5E650
	public bool get_loop() { }

	// RVA: 0x1B5E700 Offset: 0x1B5E801 VA: 0x1B5E700
	public void set_loop(bool value) { }

	// RVA: 0x1B5E7C0 Offset: 0x1B5E8C1 VA: 0x1B5E7C0
	public bool get_playOnAwake() { }

	// RVA: 0x1B5E870 Offset: 0x1B5E971 VA: 0x1B5E870
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1B5E930 Offset: 0x1B5EA31 VA: 0x1B5E930
	public float get_duration() { }

	// RVA: 0x1B5E9E0 Offset: 0x1B5EAE1 VA: 0x1B5E9E0
	public float get_playbackSpeed() { }

	// RVA: 0x1B5EA90 Offset: 0x1B5EB91 VA: 0x1B5EA90
	public void set_playbackSpeed(float value) { }

	// RVA: 0x1B5EB50 Offset: 0x1B5EC51 VA: 0x1B5EB50
	public bool get_enableEmission() { }

	// RVA: 0x1B5EC30 Offset: 0x1B5ED31 VA: 0x1B5EC30
	public void set_enableEmission(bool value) { }

	// RVA: 0x1B5ECF0 Offset: 0x1B5EDF1 VA: 0x1B5ECF0
	public float get_emissionRate() { }

	// RVA: 0x1B5EDA0 Offset: 0x1B5EEA1 VA: 0x1B5EDA0
	public void set_emissionRate(float value) { }

	// RVA: 0x1B5EF40 Offset: 0x1B5F041 VA: 0x1B5EF40
	public float get_startSpeed() { }

	// RVA: 0x1B5EFF0 Offset: 0x1B5F0F1 VA: 0x1B5EFF0
	public void set_startSpeed(float value) { }

	// RVA: 0x1B5F0B0 Offset: 0x1B5F1B1 VA: 0x1B5F0B0
	public float get_startSize() { }

	// RVA: 0x1B5F160 Offset: 0x1B5F261 VA: 0x1B5F160
	public void set_startSize(float value) { }

	// RVA: 0x1B5F220 Offset: 0x1B5F321 VA: 0x1B5F220
	public Color get_startColor() { }

	// RVA: 0x1B5F340 Offset: 0x1B5F441 VA: 0x1B5F340
	public void set_startColor(Color value) { }

	// RVA: 0x1B5F550 Offset: 0x1B5F651 VA: 0x1B5F550
	public float get_startRotation() { }

	// RVA: 0x1B5F600 Offset: 0x1B5F701 VA: 0x1B5F600
	public void set_startRotation(float value) { }

	// RVA: 0x1B5F6C0 Offset: 0x1B5F7C1 VA: 0x1B5F6C0
	public Vector3 get_startRotation3D() { }

	// RVA: 0x1B5F8D0 Offset: 0x1B5F9D1 VA: 0x1B5F8D0
	public void set_startRotation3D(Vector3 value) { }

	// RVA: 0x1B5FAA0 Offset: 0x1B5FBA1 VA: 0x1B5FAA0
	public float get_startLifetime() { }

	// RVA: 0x1B5FB50 Offset: 0x1B5FC51 VA: 0x1B5FB50
	public void set_startLifetime(float value) { }

	// RVA: 0x1B5FC10 Offset: 0x1B5FD11 VA: 0x1B5FC10
	public float get_gravityModifier() { }

	// RVA: 0x1B5FCC0 Offset: 0x1B5FDC1 VA: 0x1B5FCC0
	public void set_gravityModifier(float value) { }

	// RVA: 0x1B5FD80 Offset: 0x1B5FE81 VA: 0x1B5FD80
	public int get_maxParticles() { }

	// RVA: 0x1B5FE30 Offset: 0x1B5FF31 VA: 0x1B5FE30
	public void set_maxParticles(int value) { }

	// RVA: 0x1B5FEF0 Offset: 0x1B5FFF1 VA: 0x1B5FEF0
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	// RVA: 0x1B5FFA0 Offset: 0x1B600A1 VA: 0x1B5FFA0
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x1B60060 Offset: 0x1B60161 VA: 0x1B60060
	public ParticleSystemScalingMode get_scalingMode() { }

	// RVA: 0x1B60110 Offset: 0x1B60211 VA: 0x1B60110
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0x1B601D0 Offset: 0x1B602D1 VA: 0x1B601D0
	public bool get_automaticCullingEnabled() { }

	[NativeNameAttribute] // RVA: 0x112450 Offset: 0x112551 VA: 0x112450
	// RVA: 0x1B60270 Offset: 0x1B60371 VA: 0x1B60270
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0x112490 Offset: 0x112591 VA: 0x112490
	// RVA: 0x1B602C0 Offset: 0x1B603C1 VA: 0x1B602C0
	public bool get_isEmitting() { }

	[NativeNameAttribute] // RVA: 0x1124D0 Offset: 0x1125D1 VA: 0x1124D0
	// RVA: 0x1B60310 Offset: 0x1B60411 VA: 0x1B60310
	public bool get_isStopped() { }

	[NativeNameAttribute] // RVA: 0x112510 Offset: 0x112611 VA: 0x112510
	// RVA: 0x1B60360 Offset: 0x1B60461 VA: 0x1B60360
	public bool get_isPaused() { }

	[NativeNameAttribute] // RVA: 0x112550 Offset: 0x112651 VA: 0x112550
	// RVA: 0x1B603B0 Offset: 0x1B604B1 VA: 0x1B603B0
	public int get_particleCount() { }

	[NativeNameAttribute] // RVA: 0x112590 Offset: 0x112691 VA: 0x112590
	// RVA: 0x1B60400 Offset: 0x1B60501 VA: 0x1B60400
	public float get_time() { }

	[NativeNameAttribute] // RVA: 0x1125D0 Offset: 0x1126D1 VA: 0x1125D0
	// RVA: 0x1B60450 Offset: 0x1B60551 VA: 0x1B60450
	public void set_time(float value) { }

	[NativeNameAttribute] // RVA: 0x112610 Offset: 0x112711 VA: 0x112610
	// RVA: 0x1B604A0 Offset: 0x1B605A1 VA: 0x1B604A0
	public uint get_randomSeed() { }

	[NativeNameAttribute] // RVA: 0x112650 Offset: 0x112751 VA: 0x112650
	// RVA: 0x1B604F0 Offset: 0x1B605F1 VA: 0x1B604F0
	public void set_randomSeed(uint value) { }

	[NativeNameAttribute] // RVA: 0x112690 Offset: 0x112791 VA: 0x112690
	// RVA: 0x1B60540 Offset: 0x1B60641 VA: 0x1B60540
	public bool get_useAutoRandomSeed() { }

	[NativeNameAttribute] // RVA: 0x1126D0 Offset: 0x1127D1 VA: 0x1126D0
	// RVA: 0x1B60590 Offset: 0x1B60691 VA: 0x1B60590
	public void set_useAutoRandomSeed(bool value) { }

	// RVA: 0x1B60220 Offset: 0x1B60321 VA: 0x1B60220
	public bool get_proceduralSimulationSupported() { }

	[FreeFunctionAttribute] // RVA: 0x112710 Offset: 0x112811 VA: 0x112710
	// RVA: 0x1B605E0 Offset: 0x1B606E1 VA: 0x1B605E0
	internal float GetParticleCurrentSize(ref ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x112760 Offset: 0x112861 VA: 0x112760
	// RVA: 0x1B60630 Offset: 0x1B60731 VA: 0x1B60630
	internal Vector3 GetParticleCurrentSize3D(ref ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x1127B0 Offset: 0x1128B1 VA: 0x1127B0
	// RVA: 0x1B60700 Offset: 0x1B60801 VA: 0x1B60700
	internal Color32 GetParticleCurrentColor(ref ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x112800 Offset: 0x112901 VA: 0x112800
	// RVA: 0x1B607C0 Offset: 0x1B608C1 VA: 0x1B607C0
	internal int GetParticleMeshIndex(ref ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x112850 Offset: 0x112951 VA: 0x112850
	// RVA: 0x1B60810 Offset: 0x1B60911 VA: 0x1B60810
	public void SetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset) { }

	// RVA: 0x1B60880 Offset: 0x1B60981 VA: 0x1B60880
	public void SetParticles([Out] ParticleSystem.Particle[] particles, int size) { }

	// RVA: 0x1B608E0 Offset: 0x1B609E1 VA: 0x1B608E0
	public void SetParticles([Out] ParticleSystem.Particle[] particles) { }

	[FreeFunctionAttribute] // RVA: 0x1128A0 Offset: 0x1129A1 VA: 0x1128A0
	// RVA: 0x1B60940 Offset: 0x1B60A41 VA: 0x1B60940
	private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x1B609B0 Offset: 0x1B60AB1 VA: 0x1B609B0
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset) { }

	// RVA: 0x1B60A70 Offset: 0x1B60B71 VA: 0x1B60A70
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size) { }

	// RVA: 0x1B60B30 Offset: 0x1B60C31 VA: 0x1B60B30
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles) { }

	[FreeFunctionAttribute] // RVA: 0x1128F0 Offset: 0x1129F1 VA: 0x1128F0
	// RVA: 0x1B60BE0 Offset: 0x1B60CE1 VA: 0x1B60BE0
	public int GetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset) { }

	// RVA: 0x1B60C50 Offset: 0x1B60D51 VA: 0x1B60C50
	public int GetParticles([Out] ParticleSystem.Particle[] particles, int size) { }

	// RVA: 0x1B60CB0 Offset: 0x1B60DB1 VA: 0x1B60CB0
	public int GetParticles([Out] ParticleSystem.Particle[] particles) { }

	[FreeFunctionAttribute] // RVA: 0x112940 Offset: 0x112A41 VA: 0x112940
	// RVA: 0x1B60D10 Offset: 0x1B60E11 VA: 0x1B60D10
	private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x1B60D80 Offset: 0x1B60E81 VA: 0x1B60D80
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset) { }

	// RVA: 0x1B60E40 Offset: 0x1B60F41 VA: 0x1B60E40
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size) { }

	// RVA: 0x1B60F00 Offset: 0x1B61001 VA: 0x1B60F00
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles) { }

	[FreeFunctionAttribute] // RVA: 0x112990 Offset: 0x112A91 VA: 0x112990
	// RVA: 0x1B60FB0 Offset: 0x1B610B1 VA: 0x1B60FB0
	public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	[FreeFunctionAttribute] // RVA: 0x1129E0 Offset: 0x112AE1 VA: 0x1129E0
	// RVA: 0x1B61010 Offset: 0x1B61111 VA: 0x1B61010
	public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	// RVA: 0x1B61070 Offset: 0x1B61171 VA: 0x1B61070
	public ParticleSystem.PlaybackState GetPlaybackState() { }

	// RVA: 0x1B61140 Offset: 0x1B61241 VA: 0x1B61140
	public void SetPlaybackState(ParticleSystem.PlaybackState playbackState) { }

	[FreeFunctionAttribute] // RVA: 0x112A30 Offset: 0x112B31 VA: 0x112A30
	// RVA: 0x1B611E0 Offset: 0x1B612E1 VA: 0x1B611E0
	private void GetTrailDataInternal(ref ParticleSystem.Trails trailData) { }

	// RVA: 0x1B61230 Offset: 0x1B61331 VA: 0x1B61230
	public ParticleSystem.Trails GetTrails() { }

	[FreeFunctionAttribute] // RVA: 0x112A80 Offset: 0x112B81 VA: 0x112A80
	// RVA: 0x1B613C0 Offset: 0x1B614C1 VA: 0x1B613C0
	public void SetTrails(ParticleSystem.Trails trailData) { }

	[FreeFunctionAttribute] // RVA: 0x112AD0 Offset: 0x112BD1 VA: 0x112AD0
	// RVA: 0x1B61460 Offset: 0x1B61561 VA: 0x1B61460
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x1B614E0 Offset: 0x1B615E1 VA: 0x1B614E0
	public void Simulate(float t, bool withChildren, bool restart) { }

	// RVA: 0x1B61550 Offset: 0x1B61651 VA: 0x1B61550
	public void Simulate(float t, bool withChildren) { }

	// RVA: 0x1B615C0 Offset: 0x1B616C1 VA: 0x1B615C0
	public void Simulate(float t) { }

	[FreeFunctionAttribute] // RVA: 0x112B20 Offset: 0x112C21 VA: 0x112B20
	// RVA: 0x1B61620 Offset: 0x1B61721 VA: 0x1B61620
	public void Play(bool withChildren) { }

	// RVA: 0x1B61670 Offset: 0x1B61771 VA: 0x1B61670
	public void Play() { }

	[FreeFunctionAttribute] // RVA: 0x112B70 Offset: 0x112C71 VA: 0x112B70
	// RVA: 0x1B616C0 Offset: 0x1B617C1 VA: 0x1B616C0
	public void Pause(bool withChildren) { }

	// RVA: 0x1B61710 Offset: 0x1B61811 VA: 0x1B61710
	public void Pause() { }

	[FreeFunctionAttribute] // RVA: 0x112BC0 Offset: 0x112CC1 VA: 0x112BC0
	// RVA: 0x1B61760 Offset: 0x1B61861 VA: 0x1B61760
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x1B617C0 Offset: 0x1B618C1 VA: 0x1B617C0
	public void Stop(bool withChildren) { }

	// RVA: 0x1B61820 Offset: 0x1B61921 VA: 0x1B61820
	public void Stop() { }

	[FreeFunctionAttribute] // RVA: 0x112C10 Offset: 0x112D11 VA: 0x112C10
	// RVA: 0x1B61870 Offset: 0x1B61971 VA: 0x1B61870
	public void Clear(bool withChildren) { }

	// RVA: 0x1B618C0 Offset: 0x1B619C1 VA: 0x1B618C0
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x112C60 Offset: 0x112D61 VA: 0x112C60
	// RVA: 0x1B61910 Offset: 0x1B61A11 VA: 0x1B61910
	public bool IsAlive(bool withChildren) { }

	// RVA: 0x1B61960 Offset: 0x1B61A61 VA: 0x1B61960
	public bool IsAlive() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x112CB0 Offset: 0x112DB1 VA: 0x112CB0
	// RVA: 0x1B619B0 Offset: 0x1B61AB1 VA: 0x1B619B0
	public void Emit(int count) { }

	[NativeNameAttribute] // RVA: 0x112CC0 Offset: 0x112DC1 VA: 0x112CC0
	// RVA: 0x1B61A00 Offset: 0x1B61B01 VA: 0x1B61A00
	private void Emit_Internal(int count) { }

	[NativeNameAttribute] // RVA: 0x112D00 Offset: 0x112E01 VA: 0x112D00
	// RVA: 0x1B61A50 Offset: 0x1B61B51 VA: 0x1B61A50
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeNameAttribute] // RVA: 0x112D40 Offset: 0x112E41 VA: 0x112D40
	// RVA: 0x1B5E410 Offset: 0x1B5E511 VA: 0x1B5E410
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x1B61B10 Offset: 0x1B61C11 VA: 0x1B61B10
	public void TriggerSubEmitter(int subEmitterIndex) { }

	// RVA: 0x1B61BD0 Offset: 0x1B61CD1 VA: 0x1B61BD0
	public void TriggerSubEmitter(int subEmitterIndex, ref ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x112D80 Offset: 0x112E81 VA: 0x112D80
	// RVA: 0x1B61C50 Offset: 0x1B61D51 VA: 0x1B61C50
	internal void TriggerSubEmitterForParticle(int subEmitterIndex, ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x112DD0 Offset: 0x112ED1 VA: 0x112DD0
	// RVA: 0x1B61B70 Offset: 0x1B61C71 VA: 0x1B61B70
	public void TriggerSubEmitter(int subEmitterIndex, List<ParticleSystem.Particle> particles) { }

	[FreeFunctionAttribute] // RVA: 0x112E20 Offset: 0x112F21 VA: 0x112E20
	// RVA: 0x1B61D10 Offset: 0x1B61E11 VA: 0x1B61D10
	public static void ResetPreMappedBufferMemory() { }

	[FreeFunctionAttribute] // RVA: 0x112E70 Offset: 0x112F71 VA: 0x112E70
	// RVA: 0x1B61D50 Offset: 0x1B61E51 VA: 0x1B61D50
	public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) { }

	// RVA: 0x1B61DA0 Offset: 0x1B61EA1 VA: 0x1B61DA0
	internal void* GetManagedJobData() { }

	// RVA: 0x1B61DF0 Offset: 0x1B61EF1 VA: 0x1B61DF0
	internal JobHandle GetManagedJobHandle() { }

	// RVA: 0x1B61EA0 Offset: 0x1B61FA1 VA: 0x1B61EA0
	internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunctionAttribute] // RVA: 0x112EC0 Offset: 0x112FC1 VA: 0x112EC0
	// RVA: 0x1B61F50 Offset: 0x1B62051 VA: 0x1B61F50
	internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafeAttribute] // RVA: 0x112F00 Offset: 0x113001 VA: 0x112F00
	// RVA: 0x1B62020 Offset: 0x1B62121 VA: 0x1B62020
	internal static void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) { }

	// RVA: 0x1B5E510 Offset: 0x1B5E611 VA: 0x1B5E510
	public ParticleSystem.MainModule get_main() { }

	// RVA: 0x1B5EBB0 Offset: 0x1B5ECB1 VA: 0x1B5EBB0
	public ParticleSystem.EmissionModule get_emission() { }

	// RVA: 0x1B62090 Offset: 0x1B62191 VA: 0x1B62090
	public ParticleSystem.ShapeModule get_shape() { }

	// RVA: 0x1B620D0 Offset: 0x1B621D1 VA: 0x1B620D0
	public ParticleSystem.VelocityOverLifetimeModule get_velocityOverLifetime() { }

	// RVA: 0x1B62110 Offset: 0x1B62211 VA: 0x1B62110
	public ParticleSystem.LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	// RVA: 0x1B62150 Offset: 0x1B62251 VA: 0x1B62150
	public ParticleSystem.InheritVelocityModule get_inheritVelocity() { }

	// RVA: 0x1B62190 Offset: 0x1B62291 VA: 0x1B62190
	public ParticleSystem.ForceOverLifetimeModule get_forceOverLifetime() { }

	// RVA: 0x1B621D0 Offset: 0x1B622D1 VA: 0x1B621D0
	public ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime() { }

	// RVA: 0x1B62210 Offset: 0x1B62311 VA: 0x1B62210
	public ParticleSystem.ColorBySpeedModule get_colorBySpeed() { }

	// RVA: 0x1B62250 Offset: 0x1B62351 VA: 0x1B62250
	public ParticleSystem.SizeOverLifetimeModule get_sizeOverLifetime() { }

	// RVA: 0x1B62290 Offset: 0x1B62391 VA: 0x1B62290
	public ParticleSystem.SizeBySpeedModule get_sizeBySpeed() { }

	// RVA: 0x1B622D0 Offset: 0x1B623D1 VA: 0x1B622D0
	public ParticleSystem.RotationOverLifetimeModule get_rotationOverLifetime() { }

	// RVA: 0x1B62310 Offset: 0x1B62411 VA: 0x1B62310
	public ParticleSystem.RotationBySpeedModule get_rotationBySpeed() { }

	// RVA: 0x1B62350 Offset: 0x1B62451 VA: 0x1B62350
	public ParticleSystem.ExternalForcesModule get_externalForces() { }

	// RVA: 0x1B62390 Offset: 0x1B62491 VA: 0x1B62390
	public ParticleSystem.NoiseModule get_noise() { }

	// RVA: 0x1B623D0 Offset: 0x1B624D1 VA: 0x1B623D0
	public ParticleSystem.CollisionModule get_collision() { }

	// RVA: 0x1B62410 Offset: 0x1B62511 VA: 0x1B62410
	public ParticleSystem.TriggerModule get_trigger() { }

	// RVA: 0x1B62450 Offset: 0x1B62551 VA: 0x1B62450
	public ParticleSystem.SubEmittersModule get_subEmitters() { }

	// RVA: 0x1B62490 Offset: 0x1B62591 VA: 0x1B62490
	public ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation() { }

	// RVA: 0x1B624D0 Offset: 0x1B625D1 VA: 0x1B624D0
	public ParticleSystem.LightsModule get_lights() { }

	// RVA: 0x1B62510 Offset: 0x1B62611 VA: 0x1B62510
	public ParticleSystem.TrailModule get_trails() { }

	// RVA: 0x1B62550 Offset: 0x1B62651 VA: 0x1B62550
	public ParticleSystem.CustomDataModule get_customData() { }

	// RVA: 0x1B62590 Offset: 0x1B62691 VA: 0x1B62590
	public void .ctor() { }

	// RVA: 0x1B606A0 Offset: 0x1B607A1 VA: 0x1B606A0
	private void GetParticleCurrentSize3D_Injected(ref ParticleSystem.Particle particle, out Vector3 ret) { }

	// RVA: 0x1B60760 Offset: 0x1B60861 VA: 0x1B60760
	private void GetParticleCurrentColor_Injected(ref ParticleSystem.Particle particle, out Color32 ret) { }

	// RVA: 0x1B610F0 Offset: 0x1B611F1 VA: 0x1B610F0
	private void GetPlaybackState_Injected(out ParticleSystem.PlaybackState ret) { }

	// RVA: 0x1B61190 Offset: 0x1B61291 VA: 0x1B61190
	private void SetPlaybackState_Injected(ref ParticleSystem.PlaybackState playbackState) { }

	// RVA: 0x1B61410 Offset: 0x1B61511 VA: 0x1B61410
	private void SetTrails_Injected(ref ParticleSystem.Trails trailData) { }

	// RVA: 0x1B61AB0 Offset: 0x1B61BB1 VA: 0x1B61AB0
	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }

	// RVA: 0x1B61CB0 Offset: 0x1B61DB1 VA: 0x1B61CB0
	private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref ParticleSystem.Particle particle) { }

	// RVA: 0x1B61E50 Offset: 0x1B61F51 VA: 0x1B61E50
	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	// RVA: 0x1B61F00 Offset: 0x1B62001 VA: 0x1B61F00
	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	// RVA: 0x1B61FC0 Offset: 0x1B620C1 VA: 0x1B61FC0
	private static void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret) { }
}


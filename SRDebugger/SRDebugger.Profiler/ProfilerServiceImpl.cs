public class ProfilerServiceImpl : SRServiceBase<IProfilerService>, IProfilerService // TypeDefIndex: 5644
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13CB40 Offset: 0x13CC41 VA: 0x13CB40
	private float <AverageFrameTime>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x13CB50 Offset: 0x13CC51 VA: 0x13CB50
	private float <LastFrameTime>k__BackingField; // 0x4C
	private const int FrameBufferSize = 400;
	private readonly CircularBuffer<ProfilerFrame> _frameBuffer; // 0x50
	private ProfilerLateUpdateListener _lateUpdateListener; // 0x58
	private readonly Stopwatch _stopwatch; // 0x60
	private double _updateDuration; // 0x68
	private double _renderStartTime; // 0x70
	private double _renderDuration; // 0x78
	private int _camerasThisFrame; // 0x80

	// Properties
	public float AverageFrameTime { get; set; }
	public float LastFrameTime { get; set; }
	public CircularBuffer<ProfilerFrame> FrameBuffer { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13D410 Offset: 0x13D511 VA: 0x13D410
	// RVA: 0x1531530 Offset: 0x1531631 VA: 0x1531530 Slot: 11
	public float get_AverageFrameTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D420 Offset: 0x13D521 VA: 0x13D420
	// RVA: 0x1531540 Offset: 0x1531641 VA: 0x1531540
	private void set_AverageFrameTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D430 Offset: 0x13D531 VA: 0x13D430
	// RVA: 0x1531550 Offset: 0x1531651 VA: 0x1531550 Slot: 12
	public float get_LastFrameTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D440 Offset: 0x13D541 VA: 0x13D440
	// RVA: 0x1531560 Offset: 0x1531661 VA: 0x1531560
	private void set_LastFrameTime(float value) { }

	// RVA: 0x1531570 Offset: 0x1531671 VA: 0x1531570 Slot: 13
	public CircularBuffer<ProfilerFrame> get_FrameBuffer() { }

	// RVA: 0x1531580 Offset: 0x1531681 VA: 0x1531580 Slot: 4
	protected override void Awake() { }

	// RVA: 0x15317D0 Offset: 0x15318D1 VA: 0x15317D0 Slot: 6
	protected override void Update() { }

	// RVA: 0x1531A50 Offset: 0x1531B51 VA: 0x1531A50
	protected void PushFrame(double totalTime, double updateTime, double renderTime) { }

	// RVA: 0x1531AE0 Offset: 0x1531BE1 VA: 0x1531AE0
	private void OnLateUpdate() { }

	// RVA: 0x1531B30 Offset: 0x1531C31 VA: 0x1531B30
	private void OnCameraPreRender(Camera cam) { }

	// RVA: 0x1531B90 Offset: 0x1531C91 VA: 0x1531B90
	private void OnCameraPostRender(Camera cam) { }

	// RVA: 0x1531970 Offset: 0x1531A71 VA: 0x1531970
	private void EndFrame() { }

	// RVA: 0x1531BE0 Offset: 0x1531CE1 VA: 0x1531BE0
	public void .ctor() { }
}


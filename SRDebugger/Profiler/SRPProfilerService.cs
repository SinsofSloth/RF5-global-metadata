public class SRPProfilerService : SRServiceBase<IProfilerService>, IProfilerService // TypeDefIndex: 5645
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13CB60 Offset: 0x13CC61 VA: 0x13CB60
	private float <AverageFrameTime>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x13CB70 Offset: 0x13CC71 VA: 0x13CB70
	private float <LastFrameTime>k__BackingField; // 0x4C
	private const int FrameBufferSize = 400;
	private readonly CircularBuffer<ProfilerFrame> _frameBuffer; // 0x50
	private ProfilerLateUpdateListener _lateUpdateListener; // 0x58
	private double _updateDuration; // 0x60
	private double _renderStartTime; // 0x68
	private double _renderDuration; // 0x70
	private readonly Stopwatch _stopwatch; // 0x78

	// Properties
	public float AverageFrameTime { get; set; }
	public float LastFrameTime { get; set; }
	public CircularBuffer<ProfilerFrame> FrameBuffer { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13D450 Offset: 0x13D551 VA: 0x13D450
	// RVA: 0x1531CA0 Offset: 0x1531DA1 VA: 0x1531CA0 Slot: 11
	public float get_AverageFrameTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D460 Offset: 0x13D561 VA: 0x13D460
	// RVA: 0x1531CB0 Offset: 0x1531DB1 VA: 0x1531CB0
	private void set_AverageFrameTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D470 Offset: 0x13D571 VA: 0x13D470
	// RVA: 0x1531CC0 Offset: 0x1531DC1 VA: 0x1531CC0 Slot: 12
	public float get_LastFrameTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D480 Offset: 0x13D581 VA: 0x13D480
	// RVA: 0x1531CD0 Offset: 0x1531DD1 VA: 0x1531CD0
	private void set_LastFrameTime(float value) { }

	// RVA: 0x1531CE0 Offset: 0x1531DE1 VA: 0x1531CE0 Slot: 13
	public CircularBuffer<ProfilerFrame> get_FrameBuffer() { }

	// RVA: 0x1531CF0 Offset: 0x1531DF1 VA: 0x1531CF0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1531F90 Offset: 0x1532091 VA: 0x1531F90 Slot: 6
	protected override void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x13D490 Offset: 0x13D591 VA: 0x13D490
	// RVA: 0x1531F10 Offset: 0x1532011 VA: 0x1531F10
	private IEnumerator EndOfFrameCoroutine() { }

	// RVA: 0x1532240 Offset: 0x1532341 VA: 0x1532240
	protected void PushFrame(double totalTime, double updateTime, double renderTime) { }

	// RVA: 0x15322D0 Offset: 0x15323D1 VA: 0x15322D0
	private void OnLateUpdate() { }

	// RVA: 0x1532320 Offset: 0x1532421 VA: 0x1532320
	private void RenderPipelineOnBeginFrameRendering(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x1532130 Offset: 0x1532231 VA: 0x1532130
	private void EndFrame() { }

	// RVA: 0x1532370 Offset: 0x1532471 VA: 0x1532370
	public void .ctor() { }
}


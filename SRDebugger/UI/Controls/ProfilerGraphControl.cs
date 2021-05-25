[ExecuteInEditMode] // RVA: 0x13B570 Offset: 0x13B671 VA: 0x13B570
[RequireComponent] // RVA: 0x13B570 Offset: 0x13B671 VA: 0x13B570
[RequireComponent] // RVA: 0x13B570 Offset: 0x13B671 VA: 0x13B570
public class ProfilerGraphControl : Graphic // TypeDefIndex: 5595
{
	// Fields
	public ProfilerGraphControl.VerticalAlignments VerticalAlignment; // 0x8C
	private static readonly float[] ScaleSteps; // 0x0
	public bool FloatingScale; // 0x90
	public bool TargetFpsUseApplication; // 0x91
	public bool DrawAxes; // 0x92
	public int TargetFps; // 0x94
	public bool Clip; // 0x98
	public const float DataPointMargin = 2;
	public const float DataPointVerticalMargin = 2;
	public const float DataPointWidth = 4;
	public int VerticalPadding; // 0x9C
	public const int LineCount = 3;
	public Color[] LineColours; // 0xA0
	private IProfilerService _profilerService; // 0xA8
	private ProfilerGraphAxisLabel[] _axisLabels; // 0xB0
	private Rect _clipBounds; // 0xB8
	private readonly List<Vector3> _meshVertices; // 0xC8
	private readonly List<Color32> _meshVertexColors; // 0xD0
	private readonly List<int> _meshTriangles; // 0xD8

	// Methods

	// RVA: 0x1548390 Offset: 0x1548491 VA: 0x1548390 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1548420 Offset: 0x1548521 VA: 0x1548420 Slot: 6
	protected override void Start() { }

	// RVA: 0x1548430 Offset: 0x1548531 VA: 0x1548430
	protected void Update() { }

	[ObsoleteAttribute] // RVA: 0x13CFD0 Offset: 0x13D0D1 VA: 0x13CFD0
	// RVA: 0x1548440 Offset: 0x1548541 VA: 0x1548440 Slot: 43
	protected override void OnPopulateMesh(Mesh m) { }

	// RVA: 0x1548CA0 Offset: 0x1548DA1 VA: 0x1548CA0
	protected void DrawDataPoint(float xPosition, float verticalScale, ProfilerFrame frame) { }

	// RVA: 0x1549130 Offset: 0x1549231 VA: 0x1549130
	protected void DrawAxis(float frameTime, float yPosition, ProfilerGraphAxisLabel label) { }

	// RVA: 0x15493E0 Offset: 0x15494E1 VA: 0x15493E0
	protected void AddRect(Vector3 tl, Vector3 tr, Vector3 bl, Vector3 br, Color c) { }

	// RVA: 0x1548BB0 Offset: 0x1548CB1 VA: 0x1548BB0
	protected ProfilerFrame GetFrame(int i) { }

	// RVA: 0x1548A20 Offset: 0x1548B21 VA: 0x1548A20
	protected int CalculateVisibleDataPointCount() { }

	// RVA: 0x1548AE0 Offset: 0x1548BE1 VA: 0x1548AE0
	protected int GetFrameBufferCurrentSize() { }

	// RVA: 0x15496C0 Offset: 0x15497C1 VA: 0x15496C0
	protected int GetFrameBufferMaxSize() { }

	// RVA: 0x1548940 Offset: 0x1548A41 VA: 0x1548940
	protected float CalculateMaxFrameTime() { }

	// RVA: 0x1549030 Offset: 0x1549131 VA: 0x1549030
	private ProfilerGraphAxisLabel GetAxisLabel(int index) { }

	// RVA: 0x15497A0 Offset: 0x15498A1 VA: 0x15497A0
	public void .ctor() { }

	// RVA: 0x15498F0 Offset: 0x15499F1 VA: 0x15498F0
	private static void .cctor() { }
}


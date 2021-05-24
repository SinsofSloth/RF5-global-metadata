[DisallowMultipleComponent] // RVA: 0x149A20 Offset: 0x149B21 VA: 0x149A20
[RequireComponent] // RVA: 0x149A20 Offset: 0x149B21 VA: 0x149A20
[ExecuteInEditMode] // RVA: 0x149A20 Offset: 0x149B21 VA: 0x149A20
public class MeshBender : MonoBehaviour // TypeDefIndex: 9753
{
	// Fields
	private bool isDirty; // 0x18
	private Mesh result; // 0x20
	private bool useSpline; // 0x28
	private Spline spline; // 0x30
	private float intervalStart; // 0x38
	private float intervalEnd; // 0x3C
	private CubicBezierCurve curve; // 0x40
	private Dictionary<float, CurveSample> sampleCache; // 0x48
	private SourceMesh source; // 0x50
	private MeshBender.FillingMode mode; // 0x98

	// Properties
	public SourceMesh Source { get; set; }
	public MeshBender.FillingMode Mode { get; set; }

	// Methods

	// RVA: 0x223C320 Offset: 0x223C421 VA: 0x223C320
	public SourceMesh get_Source() { }

	// RVA: 0x223C350 Offset: 0x223C451 VA: 0x223C350
	public void set_Source(SourceMesh value) { }

	// RVA: 0x223C520 Offset: 0x223C621 VA: 0x223C520
	public MeshBender.FillingMode get_Mode() { }

	// RVA: 0x223C530 Offset: 0x223C631 VA: 0x223C530
	public void set_Mode(MeshBender.FillingMode value) { }

	// RVA: 0x223C550 Offset: 0x223C651 VA: 0x223C550
	public void SetInterval(CubicBezierCurve curve) { }

	// RVA: 0x223C6B0 Offset: 0x223C7B1 VA: 0x223C6B0
	public void SetInterval(Spline spline, float intervalStart, float intervalEnd = 0) { }

	// RVA: 0x223C9A0 Offset: 0x223CAA1 VA: 0x223C9A0
	private void OnEnable() { }

	// RVA: 0x223CB10 Offset: 0x223CC11 VA: 0x223CB10
	private void Update() { }

	// RVA: 0x223CB50 Offset: 0x223CC51 VA: 0x223CB50
	public void ComputeIfNeeded() { }

	// RVA: 0x223C510 Offset: 0x223C611 VA: 0x223C510
	private void SetDirty() { }

	// RVA: 0x223CB90 Offset: 0x223CC91 VA: 0x223CB90
	private void Compute() { }

	// RVA: 0x223E8F0 Offset: 0x223E9F1 VA: 0x223E8F0
	private void OnDestroy() { }

	// RVA: 0x223CBC0 Offset: 0x223CCC1 VA: 0x223CBC0
	private void FillOnce() { }

	// RVA: 0x223D3D0 Offset: 0x223D4D1 VA: 0x223D3D0
	private void FillRepeat() { }

	// RVA: 0x223DFE0 Offset: 0x223E0E1 VA: 0x223DFE0
	private void FillStretch() { }

	// RVA: 0x223F0F0 Offset: 0x223F1F1 VA: 0x223F0F0
	public void .ctor() { }
}


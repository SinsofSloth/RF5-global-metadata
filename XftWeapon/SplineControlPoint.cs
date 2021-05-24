public class SplineControlPoint // TypeDefIndex: 9104
{
	// Fields
	public Vector3 Position; // 0x10
	public Vector3 Normal; // 0x1C
	public int ControlPointIndex; // 0x28
	public int SegmentIndex; // 0x2C
	public float Dist; // 0x30
	protected Spline mSpline; // 0x38

	// Properties
	public SplineControlPoint NextControlPoint { get; }
	public SplineControlPoint PreviousControlPoint { get; }
	public Vector3 NextPosition { get; }
	public Vector3 PreviousPosition { get; }
	public Vector3 NextNormal { get; }
	public Vector3 PreviousNormal { get; }
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1D0F830 Offset: 0x1D0F931 VA: 0x1D0F830
	public SplineControlPoint get_NextControlPoint() { }

	// RVA: 0x1D0F8F0 Offset: 0x1D0F9F1 VA: 0x1D0F8F0
	public SplineControlPoint get_PreviousControlPoint() { }

	// RVA: 0x1D0F9B0 Offset: 0x1D0FAB1 VA: 0x1D0F9B0
	public Vector3 get_NextPosition() { }

	// RVA: 0x1D0F9D0 Offset: 0x1D0FAD1 VA: 0x1D0F9D0
	public Vector3 get_PreviousPosition() { }

	// RVA: 0x1D0F9F0 Offset: 0x1D0FAF1 VA: 0x1D0F9F0
	public Vector3 get_NextNormal() { }

	// RVA: 0x1D0FA10 Offset: 0x1D0FB11 VA: 0x1D0FA10
	public Vector3 get_PreviousNormal() { }

	// RVA: 0x1D0F6C0 Offset: 0x1D0F7C1 VA: 0x1D0F6C0
	public bool get_IsValid() { }

	// RVA: 0x1D0FA30 Offset: 0x1D0FB31 VA: 0x1D0FA30
	private Vector3 GetNext2Position() { }

	// RVA: 0x1D0FBB0 Offset: 0x1D0FCB1 VA: 0x1D0FBB0
	private Vector3 GetNext2Normal() { }

	// RVA: 0x1D0ED80 Offset: 0x1D0EE81 VA: 0x1D0ED80
	public Vector3 Interpolate(float localF) { }

	// RVA: 0x1D0EF90 Offset: 0x1D0F091 VA: 0x1D0EF90
	public Vector3 InterpolateNormal(float localF) { }

	// RVA: 0x1D0F280 Offset: 0x1D0F381 VA: 0x1D0F280
	public void Init(Spline owner) { }

	// RVA: 0x1D0F270 Offset: 0x1D0F371 VA: 0x1D0F270
	public void .ctor() { }
}


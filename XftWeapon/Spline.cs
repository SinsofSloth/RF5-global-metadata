[DefaultMemberAttribute] // RVA: 0x147B10 Offset: 0x147C11 VA: 0x147B10
public class Spline // TypeDefIndex: 9103
{
	// Fields
	private List<SplineControlPoint> mControlPoints; // 0x10
	private List<SplineControlPoint> mSegments; // 0x18
	public int Granularity; // 0x20

	// Properties
	public SplineControlPoint Item { get; }
	public List<SplineControlPoint> Segments { get; }
	public List<SplineControlPoint> ControlPoints { get; }

	// Methods

	// RVA: 0x1D0E4F0 Offset: 0x1D0E5F1 VA: 0x1D0E4F0
	public SplineControlPoint get_Item(int index) { }

	// RVA: 0x1D0E5A0 Offset: 0x1D0E6A1 VA: 0x1D0E5A0
	public List<SplineControlPoint> get_Segments() { }

	// RVA: 0x1D0E5B0 Offset: 0x1D0E6B1 VA: 0x1D0E5B0
	public List<SplineControlPoint> get_ControlPoints() { }

	// RVA: 0x1D0E5C0 Offset: 0x1D0E6C1 VA: 0x1D0E5C0
	public SplineControlPoint NextControlPoint(SplineControlPoint controlpoint) { }

	// RVA: 0x1D0E680 Offset: 0x1D0E781 VA: 0x1D0E680
	public SplineControlPoint PreviousControlPoint(SplineControlPoint controlpoint) { }

	// RVA: 0x1D0E740 Offset: 0x1D0E841 VA: 0x1D0E740
	public Vector3 NextPosition(SplineControlPoint controlpoint) { }

	// RVA: 0x1D0E7F0 Offset: 0x1D0E8F1 VA: 0x1D0E7F0
	public Vector3 PreviousPosition(SplineControlPoint controlpoint) { }

	// RVA: 0x1D0E8A0 Offset: 0x1D0E9A1 VA: 0x1D0E8A0
	public Vector3 PreviousNormal(SplineControlPoint controlpoint) { }

	// RVA: 0x1D0E950 Offset: 0x1D0EA51 VA: 0x1D0E950
	public Vector3 NextNormal(SplineControlPoint controlpoint) { }

	// RVA: 0x1D0EA00 Offset: 0x1D0EB01 VA: 0x1D0EA00
	public SplineControlPoint LenToSegment(float t, out float localF) { }

	// RVA: 0x1D0EBC0 Offset: 0x1D0ECC1 VA: 0x1D0EBC0
	public static Vector3 CatmulRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f) { }

	// RVA: 0x1D0ED50 Offset: 0x1D0EE51 VA: 0x1D0ED50
	public Vector3 InterpolateByLen(float tl) { }

	// RVA: 0x1D0EF60 Offset: 0x1D0F061 VA: 0x1D0EF60
	public Vector3 InterpolateNormalByLen(float tl) { }

	// RVA: 0x1D0F170 Offset: 0x1D0F271 VA: 0x1D0F170
	public SplineControlPoint AddControlPoint(Vector3 pos, Vector3 up) { }

	// RVA: 0x1D0F2B0 Offset: 0x1D0F3B1 VA: 0x1D0F2B0
	public void Clear() { }

	// RVA: 0x1D0F310 Offset: 0x1D0F411 VA: 0x1D0F310
	private void RefreshDistance() { }

	// RVA: 0x1D0F510 Offset: 0x1D0F611 VA: 0x1D0F510
	public void RefreshSpline() { }

	// RVA: 0x1D0F780 Offset: 0x1D0F881 VA: 0x1D0F780
	public void .ctor() { }
}


[Serializable]
public class Path // TypeDefIndex: 5059
{
	// Fields
	private static CatmullRomDecoder _catmullRomDecoder; // 0x0
	private static LinearDecoder _linearDecoder; // 0x8
	private static CubicBezierDecoder _cubicBezierDecoder; // 0x10
	public float[] wpLengths; // 0x10
	[SerializeField] // RVA: 0x137B90 Offset: 0x137C91 VA: 0x137B90
	internal PathType type; // 0x18
	[SerializeField] // RVA: 0x137BA0 Offset: 0x137CA1 VA: 0x137BA0
	internal int subdivisionsXSegment; // 0x1C
	[SerializeField] // RVA: 0x137BB0 Offset: 0x137CB1 VA: 0x137BB0
	internal int subdivisions; // 0x20
	[SerializeField] // RVA: 0x137BC0 Offset: 0x137CC1 VA: 0x137BC0
	internal Vector3[] wps; // 0x28
	[SerializeField] // RVA: 0x137BD0 Offset: 0x137CD1 VA: 0x137BD0
	internal ControlPoint[] controlPoints; // 0x30
	[SerializeField] // RVA: 0x137BE0 Offset: 0x137CE1 VA: 0x137BE0
	internal float length; // 0x38
	[SerializeField] // RVA: 0x137BF0 Offset: 0x137CF1 VA: 0x137BF0
	internal bool isFinalized; // 0x3C
	[SerializeField] // RVA: 0x137C00 Offset: 0x137D01 VA: 0x137C00
	internal float[] timesTable; // 0x40
	[SerializeField] // RVA: 0x137C10 Offset: 0x137D11 VA: 0x137C10
	internal float[] lengthsTable; // 0x48
	internal int linearWPIndex; // 0x50
	internal bool addedExtraStartWp; // 0x54
	internal bool addedExtraEndWp; // 0x55
	private Path _incrementalClone; // 0x58
	private int _incrementalIndex; // 0x60
	private ABSPathDecoder _decoder; // 0x68
	private bool _changed; // 0x70
	internal Vector3[] nonLinearDrawWps; // 0x78
	internal Vector3 targetPosition; // 0x80
	internal Nullable<Vector3> lookAtPosition; // 0x8C
	internal Color gizmoColor; // 0x9C

	// Methods

	// RVA: 0x199BA20 Offset: 0x199BB21 VA: 0x199BA20
	public void .ctor(PathType type, Vector3[] waypoints, int subdivisionsXSegment, Nullable<Color> gizmoColor) { }

	// RVA: 0x199BE30 Offset: 0x199BF31 VA: 0x199BE30
	internal void .ctor() { }

	// RVA: 0x199BEA0 Offset: 0x199BFA1 VA: 0x199BEA0
	internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal) { }

	// RVA: 0x199C0C0 Offset: 0x199C1C1 VA: 0x199C0C0
	internal Vector3 GetPoint(float perc, bool convertToConstantPerc = False) { }

	// RVA: 0x199C110 Offset: 0x199C211 VA: 0x199C110
	internal float ConvertToConstantPathPerc(float perc) { }

	// RVA: 0x199C230 Offset: 0x199C331 VA: 0x199C230
	internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward) { }

	// RVA: 0x199C2F0 Offset: 0x199C3F1 VA: 0x199C2F0
	internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment) { }

	// RVA: 0x199C420 Offset: 0x199C521 VA: 0x199C420
	internal static void RefreshNonLinearDrawWps(Path p) { }

	// RVA: 0x199C550 Offset: 0x199C651 VA: 0x199C550
	internal void Destroy() { }

	// RVA: 0x199C6B0 Offset: 0x199C7B1 VA: 0x199C6B0
	internal Path CloneIncremental(int loopIncrement) { }

	// RVA: 0x199BBD0 Offset: 0x199BCD1 VA: 0x199BBD0
	internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = False) { }

	// RVA: 0x199BCE0 Offset: 0x199BDE1 VA: 0x199BCE0
	internal void AssignDecoder(PathType pathType) { }

	// RVA: 0x199CE90 Offset: 0x199CF91 VA: 0x199CE90
	internal void Draw() { }

	// RVA: 0x199CEA0 Offset: 0x199CFA1 VA: 0x199CEA0
	private static void Draw(Path p) { }
}


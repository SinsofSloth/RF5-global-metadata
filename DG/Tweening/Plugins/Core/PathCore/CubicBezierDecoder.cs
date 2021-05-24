internal class CubicBezierDecoder : ABSPathDecoder // TypeDefIndex: 5054
{
	// Fields
	private static readonly ControlPoint[] _PartialControlPs; // 0x0
	private static readonly Vector3[] _PartialWps; // 0x8

	// Methods

	// RVA: 0x199A830 Offset: 0x199A931 VA: 0x199A830 Slot: 4
	internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) { }

	// RVA: 0x199B240 Offset: 0x199B341 VA: 0x199B240 Slot: 5
	internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) { }

	// RVA: 0x199ACA0 Offset: 0x199ADA1 VA: 0x199ACA0
	internal void SetTimeToLengthTables(Path p, int subdivisions) { }

	// RVA: 0x199AF10 Offset: 0x199B011 VA: 0x199AF10
	internal void SetWaypointsLengths(Path p, int subdivisions) { }

	// RVA: 0x199B4D0 Offset: 0x199B5D1 VA: 0x199B4D0
	public void .ctor() { }

	// RVA: 0x199B4E0 Offset: 0x199B5E1 VA: 0x199B4E0
	private static void .cctor() { }
}


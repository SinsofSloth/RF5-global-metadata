[ExtensionAttribute] // RVA: 0x1414A0 Offset: 0x1415A1 VA: 0x1414A0
public static class Math // TypeDefIndex: 5957
{
	// Methods

	[ExtensionAttribute] // RVA: 0x142520 Offset: 0x142621 VA: 0x142520
	// RVA: 0x1A93DA0 Offset: 0x1A93EA1 VA: 0x1A93DA0
	internal static Vector2 RotateAroundPoint(Vector2 v, Vector2 origin, float theta) { }

	[ExtensionAttribute] // RVA: 0x142530 Offset: 0x142631 VA: 0x142530
	// RVA: 0x1A93E90 Offset: 0x1A93F91 VA: 0x1A93E90
	public static Vector2 ScaleAroundPoint(Vector2 v, Vector2 origin, Vector2 scale) { }

	// RVA: 0x1A93F50 Offset: 0x1A94051 VA: 0x1A93F50
	public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0x1A94130 Offset: 0x1A94231 VA: 0x1A94130
	public static Vector3 Normal(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1A94D10 Offset: 0x1A94E11 VA: 0x1A94D10
	internal static Vector2 SmallestVector2(Vector2[] v, IList<int> indexes) { }

	// RVA: 0x1A950B0 Offset: 0x1A951B1 VA: 0x1A950B0
	internal static Vector2 LargestVector2(Vector2[] v, IList<int> indexes) { }

	[ExtensionAttribute] // RVA: 0x142540 Offset: 0x142641 VA: 0x142540
	// RVA: 0x1A95450 Offset: 0x1A95551 VA: 0x1A95450
	internal static bool Approx2(Vector2 a, Vector2 b, float delta = 0.0001) { }

	[ExtensionAttribute] // RVA: 0x142550 Offset: 0x142651 VA: 0x142550
	// RVA: 0x1A95520 Offset: 0x1A95621 VA: 0x1A95520
	internal static bool Approx3(Vector3 a, Vector3 b, float delta = 0.0001) { }

	[ExtensionAttribute] // RVA: 0x142560 Offset: 0x142661 VA: 0x142560
	// RVA: 0x1A95630 Offset: 0x1A95731 VA: 0x1A95630
	internal static bool Approx4(Vector4 a, Vector4 b, float delta = 0.0001) { }

	[ExtensionAttribute] // RVA: 0x142570 Offset: 0x142671 VA: 0x142570
	// RVA: 0x1A95780 Offset: 0x1A95881 VA: 0x1A95780
	internal static bool ApproxC(Color a, Color b, float delta = 0.0001) { }

	[ExtensionAttribute] // RVA: 0x142580 Offset: 0x142681 VA: 0x142580
	// RVA: 0x1A958D0 Offset: 0x1A959D1 VA: 0x1A958D0
	internal static bool Approx(float a, float b, float delta = 0.0001) { }

	// RVA: 0x1A95960 Offset: 0x1A95A61 VA: 0x1A95960
	public static int Clamp(int value, int lowerBound, int upperBound) { }

	// RVA: 0x1A940F0 Offset: 0x1A941F1 VA: 0x1A940F0
	internal static void Cross(float ax, float ay, float az, float bx, float by, float bz, ref float x, ref float y, ref float z) { }
}


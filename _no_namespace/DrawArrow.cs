public static class DrawArrow // TypeDefIndex: 8198
{
	// Methods

	// RVA: 0x1CF18C0 Offset: 0x1CF19C1 VA: 0x1CF18C0
	public static void ForGizmo(Vector3 pos, Vector3 direction, float arrowHeadLength = 0.25, float arrowHeadAngle = 20) { }

	// RVA: 0x1CF1C00 Offset: 0x1CF1D01 VA: 0x1CF1C00
	public static void ForGizmo(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength = 0.25, float arrowHeadAngle = 20) { }

	// RVA: 0x1CF1F40 Offset: 0x1CF2041 VA: 0x1CF1F40
	public static void ForDebug(Vector3 pos, Vector3 direction, float arrowHeadLength = 0.25, float arrowHeadAngle = 20) { }

	// RVA: 0x1CF22A0 Offset: 0x1CF23A1 VA: 0x1CF22A0
	public static void ForDebug(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength = 0.25, float arrowHeadAngle = 20) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A6580 Offset: 0x1A6681 VA: 0x1A6580
	// RVA: 0x1CF2620 Offset: 0x1CF2721 VA: 0x1CF2620
	public static IEnumerator DrawCoroutine(float duration, Vector3 pos, Vector3 direction, Color color) { }
}


public static class TMP_TextUtilities // TypeDefIndex: 5879
{
	// Fields
	private static Vector3[] m_rectWorldCorners; // 0x0
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Methods

	// RVA: 0x159DB00 Offset: 0x159DC01 VA: 0x159DB00
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	// RVA: 0x159E2F0 Offset: 0x159E3F1 VA: 0x159E2F0
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	// RVA: 0x159E530 Offset: 0x159E631 VA: 0x159E530
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x159E7C0 Offset: 0x159E8C1 VA: 0x159E7C0
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	// RVA: 0x159F0C0 Offset: 0x159F1C1 VA: 0x159F0C0
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	// RVA: 0x159F240 Offset: 0x159F341 VA: 0x159F240
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x159DCB0 Offset: 0x159DDB1 VA: 0x159DCB0
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x159F4F0 Offset: 0x159F5F1 VA: 0x159F4F0
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x159FBE0 Offset: 0x159FCE1 VA: 0x159FBE0
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x15A03E0 Offset: 0x15A04E1 VA: 0x15A03E0
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x15A0620 Offset: 0x15A0721 VA: 0x15A0620
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x15A0B00 Offset: 0x15A0C01 VA: 0x15A0B00
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x159EBF0 Offset: 0x159ECF1 VA: 0x159EBF0
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x159E0A0 Offset: 0x159E1A1 VA: 0x159E0A0
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x15A1310 Offset: 0x15A1411 VA: 0x15A1310
	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	// RVA: 0x159EE50 Offset: 0x159EF51 VA: 0x159EE50
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x15A1530 Offset: 0x15A1631 VA: 0x15A1530
	public static char ToLowerFast(char c) { }

	// RVA: 0x15A15B0 Offset: 0x15A16B1 VA: 0x15A15B0
	public static char ToUpperFast(char c) { }

	// RVA: 0x15A1630 Offset: 0x15A1731 VA: 0x15A1630
	public static int GetHashCode(string s) { }

	// RVA: 0x15A1770 Offset: 0x15A1871 VA: 0x15A1770
	public static int GetSimpleHashCode(string s) { }

	// RVA: 0x15A17F0 Offset: 0x15A18F1 VA: 0x15A17F0
	public static uint GetSimpleHashCodeLowercase(string s) { }

	// RVA: 0x15A1930 Offset: 0x15A1A31 VA: 0x15A1930
	public static int HexToInt(char hex) { }

	// RVA: 0x15A1960 Offset: 0x15A1A61 VA: 0x15A1960
	public static int StringHexToInt(string s) { }

	// RVA: 0x15A1A80 Offset: 0x15A1B81 VA: 0x15A1A80
	private static void .cctor() { }
}


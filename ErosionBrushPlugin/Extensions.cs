[ExtensionAttribute] // RVA: 0x1495A0 Offset: 0x1496A1 VA: 0x1495A0
public static class Extensions // TypeDefIndex: 9715
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1AC7C0 Offset: 0x1AC8C1 VA: 0x1AC7C0
	// RVA: 0x2AF0350 Offset: 0x2AF0451 VA: 0x2AF0350
	public static bool InRange(Rect rect, Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x1AC7D0 Offset: 0x1AC8D1 VA: 0x1AC7D0
	// RVA: 0x2AF0450 Offset: 0x2AF0551 VA: 0x2AF0450
	public static Vector3 ToDir(float angle) { }

	[ExtensionAttribute] // RVA: 0x1AC7E0 Offset: 0x1AC8E1 VA: 0x1AC7E0
	// RVA: 0x2AF0510 Offset: 0x2AF0611 VA: 0x2AF0510
	public static float ToAngle(Vector3 dir) { }

	[ExtensionAttribute] // RVA: 0x1AC7F0 Offset: 0x1AC8F1 VA: 0x1AC7F0
	// RVA: 0x2AF05A0 Offset: 0x2AF06A1 VA: 0x2AF05A0
	public static Vector3 V3(Vector2 v2) { }

	[ExtensionAttribute] // RVA: 0x1AC800 Offset: 0x1AC901 VA: 0x1AC800
	// RVA: 0x2AF05E0 Offset: 0x2AF06E1 VA: 0x2AF05E0
	public static Vector2 V2(Vector3 v3) { }

	[ExtensionAttribute] // RVA: 0x1AC810 Offset: 0x1AC911 VA: 0x1AC810
	// RVA: 0x2AF0610 Offset: 0x2AF0711 VA: 0x2AF0610
	public static Vector3 ToV3(float f) { }

	[ExtensionAttribute] // RVA: 0x1AC820 Offset: 0x1AC921 VA: 0x1AC820
	// RVA: 0x2AF0650 Offset: 0x2AF0751 VA: 0x2AF0650
	public static Quaternion EulerToQuat(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x1AC830 Offset: 0x1AC931 VA: 0x1AC830
	// RVA: 0x2AF0710 Offset: 0x2AF0811 VA: 0x2AF0710
	public static Quaternion EulerToQuat(float f) { }

	[ExtensionAttribute] // RVA: 0x1AC840 Offset: 0x1AC941 VA: 0x1AC840
	// RVA: 0x2AF07D0 Offset: 0x2AF08D1 VA: 0x2AF07D0
	public static Vector3 Direction(float angle) { }

	[ExtensionAttribute] // RVA: 0x1AC850 Offset: 0x1AC951 VA: 0x1AC850
	// RVA: 0x2AF0890 Offset: 0x2AF0991 VA: 0x2AF0890
	public static float Angle(Vector3 dir) { }

	[ExtensionAttribute] // RVA: 0x1AC860 Offset: 0x1AC961 VA: 0x1AC860
	// RVA: 0x2AF0920 Offset: 0x2AF0A21 VA: 0x2AF0920
	public static Rect Clamp(Rect r, float p) { }

	[ExtensionAttribute] // RVA: 0x1AC870 Offset: 0x1AC971 VA: 0x1AC870
	// RVA: 0x2AF09C0 Offset: 0x2AF0AC1 VA: 0x2AF09C0
	public static Rect ClampFromLeft(Rect r, float p) { }

	[ExtensionAttribute] // RVA: 0x1AC880 Offset: 0x1AC981 VA: 0x1AC880
	// RVA: 0x2AF0A80 Offset: 0x2AF0B81 VA: 0x2AF0A80
	public static Rect Clamp(Rect r, int p) { }

	[ExtensionAttribute] // RVA: 0x1AC890 Offset: 0x1AC991 VA: 0x1AC890
	// RVA: 0x2AF0B10 Offset: 0x2AF0C11 VA: 0x2AF0B10
	public static Rect ClampFromLeft(Rect r, int p) { }

	[ExtensionAttribute] // RVA: 0x1AC8A0 Offset: 0x1AC9A1 VA: 0x1AC8A0
	// RVA: 0x2AF0BC0 Offset: 0x2AF0CC1 VA: 0x2AF0BC0
	public static bool Intersects(Rect r1, Rect r2) { }

	[ExtensionAttribute] // RVA: 0x1AC8B0 Offset: 0x1AC9B1 VA: 0x1AC8B0
	// RVA: 0x2AF0C70 Offset: 0x2AF0D71 VA: 0x2AF0C70
	public static bool Intersects(Rect r1, Rect[] rects) { }

	[ExtensionAttribute] // RVA: 0x1AC8C0 Offset: 0x1AC9C1 VA: 0x1AC8C0
	// RVA: 0x2AF0D20 Offset: 0x2AF0E21 VA: 0x2AF0D20
	public static bool Contains(Rect r1, Rect r2) { }

	[ExtensionAttribute] // RVA: 0x1AC8D0 Offset: 0x1AC9D1 VA: 0x1AC8D0
	// RVA: 0x2AF0DE0 Offset: 0x2AF0EE1 VA: 0x2AF0DE0
	public static Rect Extend(Rect r, float f) { }

	[ExtensionAttribute] // RVA: 0x1AC8E0 Offset: 0x1AC9E1 VA: 0x1AC8E0
	// RVA: 0x2AF0E80 Offset: 0x2AF0F81 VA: 0x2AF0E80
	public static Coord RoundToCoord(Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x1AC8F0 Offset: 0x1AC9F1 VA: 0x1AC8F0
	// RVA: 0x2AF0EC0 Offset: 0x2AF0FC1 VA: 0x2AF0EC0
	public static Coord FloorToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC900 Offset: 0x1ACA01 VA: 0x1AC900
	// RVA: 0x2AF0F60 Offset: 0x2AF1061 VA: 0x2AF0F60
	public static Coord CeilToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC910 Offset: 0x1ACA11 VA: 0x1AC910
	// RVA: 0x2AF1000 Offset: 0x2AF1101 VA: 0x2AF1000
	public static Coord RoundToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC920 Offset: 0x1ACA21 VA: 0x1AC920
	// RVA: 0x2AED5A0 Offset: 0x2AED6A1 VA: 0x2AED5A0
	public static CoordRect ToCoordRect(Vector3 pos, float range, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC930 Offset: 0x1ACA31 VA: 0x1AC930
	// RVA: 0x2AED2D0 Offset: 0x2AED3D1 VA: 0x2AED2D0
	public static CoordRect ToCoordRect(Vector3 pos, float range, float cellSizeX, float cellSizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC940 Offset: 0x1ACA41 VA: 0x1AC940
	// RVA: 0x2AEDC70 Offset: 0x2AEDD71 VA: 0x2AEDC70
	public static CoordRect GetHeightRect(Terrain terrain) { }

	[ExtensionAttribute] // RVA: 0x1AC950 Offset: 0x1ACA51 VA: 0x1AC950
	// RVA: 0x2AEDDE0 Offset: 0x2AEDEE1 VA: 0x2AEDDE0
	public static CoordRect GetSplatRect(Terrain terrain) { }

	[ExtensionAttribute] // RVA: 0x1AC960 Offset: 0x1ACA61 VA: 0x1AC960
	// RVA: 0x2AF0070 Offset: 0x2AF0171 VA: 0x2AF0070
	public static float[,] SafeGetHeights(TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC970 Offset: 0x1ACA71 VA: 0x1AC970
	// RVA: 0x2AF0100 Offset: 0x2AF0201 VA: 0x2AF0100
	public static float[,,] SafeGetAlphamaps(TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC980 Offset: 0x1ACA81 VA: 0x1AC980
	// RVA: 0x2AF10A0 Offset: 0x2AF11A1 VA: 0x2AF10A0
	public static List<Type> GetAllChildTypes(Type type) { }

	// RVA: 0x2AF1220 Offset: 0x2AF1321 VA: 0x2AF1220
	public static Texture2D ColorTexture(int width, int height, Color color) { }

	// RVA: 0x2AF1350 Offset: 0x2AF1451 VA: 0x2AF1350
	public static bool Equal(Vector3 v1, Vector3 v2) { }

	// RVA: 0x2AF1460 Offset: 0x2AF1561 VA: 0x2AF1460
	public static bool Equal(Ray r1, Ray r2) { }

	[ExtensionAttribute] // RVA: 0x1AC990 Offset: 0x1ACA91 VA: 0x1AC990
	// RVA: 0x2AF1530 Offset: 0x2AF1631 VA: 0x2AF1530
	public static void RemoveChildren(Transform tfm) { }

	[ExtensionAttribute] // RVA: 0x1AC9A0 Offset: 0x1ACAA1 VA: 0x1AC9A0
	// RVA: 0x2AF15F0 Offset: 0x2AF16F1 VA: 0x2AF15F0
	public static Transform FindChildRecursive(Transform tfm, string name) { }

	[ExtensionAttribute] // RVA: 0x1AC9B0 Offset: 0x1ACAB1 VA: 0x1AC9B0
	// RVA: 0x2AF1730 Offset: 0x2AF1831 VA: 0x2AF1730
	public static void ToggleDisplayWireframe(Transform tfm, bool show) { }

	[ExtensionAttribute] // RVA: 0x1AC9C0 Offset: 0x1ACAC1 VA: 0x1AC9C0
	// RVA: 0x2AF1740 Offset: 0x2AF1841 VA: 0x2AF1740
	public static int ToInt(Coord coord) { }

	[ExtensionAttribute] // RVA: 0x1AC9D0 Offset: 0x1ACAD1 VA: 0x1AC9D0
	// RVA: 0x2AF1780 Offset: 0x2AF1881 VA: 0x2AF1780
	public static Coord ToCoord(int hash) { }

	[ExtensionAttribute] // RVA: 0x1AC9E0 Offset: 0x1ACAE1 VA: 0x1AC9E0
	// RVA: -1 Offset: -1
	public static void CheckAdd<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, TValue value, bool replace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0290 Offset: 0x21D0391 VA: 0x21D0290
	|-Extensions.CheckAdd<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1AC9F0 Offset: 0x1ACAF1 VA: 0x1AC9F0
	// RVA: -1 Offset: -1
	public static void CheckRemove<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D03A0 Offset: 0x21D04A1 VA: 0x21D03A0
	|-Extensions.CheckRemove<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA00 Offset: 0x1ACB01 VA: 0x1ACA00
	// RVA: -1 Offset: -1
	public static TValue CheckGet<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CAE0 Offset: 0x226CBE1 VA: 0x226CAE0
	|-Extensions.CheckGet<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA10 Offset: 0x1ACB11 VA: 0x1ACA10
	// RVA: -1 Offset: -1
	public static void CheckAdd<T>(HashSet<T> set, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0330 Offset: 0x21D0431 VA: 0x21D0330
	|-Extensions.CheckAdd<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA20 Offset: 0x1ACB21 VA: 0x1ACA20
	// RVA: -1 Offset: -1
	public static void CheckRemove<T>(HashSet<T> set, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0410 Offset: 0x21D0511 VA: 0x21D0410
	|-Extensions.CheckRemove<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA30 Offset: 0x1ACB31 VA: 0x1ACA30
	// RVA: -1 Offset: -1
	public static void SetState<T>(HashSet<T> set, T obj, bool state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0C60 Offset: 0x21D0D61 VA: 0x21D0C60
	|-Extensions.SetState<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA40 Offset: 0x1ACB41 VA: 0x1ACA40
	// RVA: 0x2AF17F0 Offset: 0x2AF18F1 VA: 0x2AF17F0
	public static void Normalize(float[,,] array, int pinnedLayer) { }

	[ExtensionAttribute] // RVA: 0x1ACA50 Offset: 0x1ACB51 VA: 0x1ACA50
	// RVA: 0x2AF1A00 Offset: 0x2AF1B01 VA: 0x2AF1A00
	public static void DrawDebug(Vector3 pos, float range = 1, Color color) { }

	[ExtensionAttribute] // RVA: 0x1ACA60 Offset: 0x1ACB61 VA: 0x1ACA60
	// RVA: 0x2AF1ED0 Offset: 0x2AF1FD1 VA: 0x2AF1ED0
	public static void DrawDebug(Rect rect, Color color) { }

	[ExtensionAttribute] // RVA: 0x1ACA70 Offset: 0x1ACB71 VA: 0x1ACA70
	// RVA: 0x2AF22B0 Offset: 0x2AF23B1 VA: 0x2AF22B0
	public static void Resize(Terrain terrain, int resolution, Vector3 size) { }

	[ExtensionAttribute] // RVA: 0x1ACA80 Offset: 0x1ACB81 VA: 0x1ACA80
	// RVA: 0x2AF24F0 Offset: 0x2AF25F1 VA: 0x2AF24F0
	public static Transform AddChild(Transform tfm, string name = "", Vector3 offset) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACA90 Offset: 0x1ACB91 VA: 0x1ACA90
	[ExtensionAttribute] // RVA: 0x1ACA90 Offset: 0x1ACB91 VA: 0x1ACA90
	// RVA: 0x2AF25E0 Offset: 0x2AF26E1 VA: 0x2AF25E0
	public static IEnumerable<Vector3> CircleAround(Vector3 center, float radius, int numPoints, bool endWhereStart = False) { }

	[ExtensionAttribute] // RVA: 0x1ACB10 Offset: 0x1ACC11 VA: 0x1ACB10
	// RVA: 0x2AF26F0 Offset: 0x2AF27F1 VA: 0x2AF26F0
	public static float EvaluateMultithreaded(AnimationCurve curve, float time) { }

	[ExtensionAttribute] // RVA: 0x1ACB20 Offset: 0x1ACC21 VA: 0x1ACB20
	// RVA: -1 Offset: -1
	public static void GetPropertiesFrom<T1, T2>(T1 dst, T2 src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0480 Offset: 0x21D0581 VA: 0x21D0480
	|-Extensions.GetPropertiesFrom<object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1ACB30 Offset: 0x1ACC31 VA: 0x1ACB30
	[ExtensionAttribute] // RVA: 0x1ACB30 Offset: 0x1ACC31 VA: 0x1ACB30
	// RVA: 0x2AF2A90 Offset: 0x2AF2B91 VA: 0x2AF2A90
	public static IEnumerable<FieldInfo> UsableFields(Type type, bool nonPublic = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACBB0 Offset: 0x1ACCB1 VA: 0x1ACBB0
	[ExtensionAttribute] // RVA: 0x1ACBB0 Offset: 0x1ACCB1 VA: 0x1ACBB0
	// RVA: 0x2AF2B70 Offset: 0x2AF2C71 VA: 0x2AF2B70
	public static IEnumerable<PropertyInfo> UsableProperties(Type type, bool nonPublic = False, bool skipItems = True) { }

	// RVA: 0x2AF2C60 Offset: 0x2AF2D61 VA: 0x2AF2C60
	public static Component CopyComponent(Component src, GameObject go) { }

	[ExtensionAttribute] // RVA: 0x1ACC30 Offset: 0x1ACD31 VA: 0x1ACC30
	// RVA: -1 Offset: -1
	public static void ReflectionReset<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0660 Offset: 0x21D0761 VA: 0x21D0660
	|-Extensions.ReflectionReset<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACC40 Offset: 0x1ACD41 VA: 0x1ACC40
	// RVA: -1 Offset: -1
	public static T ReflectionCopy<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C0850 Offset: 0x23C0951 VA: 0x23C0850
	|-Extensions.ReflectionCopy<object>
	*/
}

[ExtensionAttribute] // RVA: 0x1495A0 Offset: 0x1496A1 VA: 0x1495A0
public static class Extensions // TypeDefIndex: 9715
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1AC7C0 Offset: 0x1AC8C1 VA: 0x1AC7C0
	// RVA: 0x2AF0350 Offset: 0x2AF0451 VA: 0x2AF0350
	public static bool InRange(Rect rect, Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x1AC7D0 Offset: 0x1AC8D1 VA: 0x1AC7D0
	// RVA: 0x2AF0450 Offset: 0x2AF0551 VA: 0x2AF0450
	public static Vector3 ToDir(float angle) { }

	[ExtensionAttribute] // RVA: 0x1AC7E0 Offset: 0x1AC8E1 VA: 0x1AC7E0
	// RVA: 0x2AF0510 Offset: 0x2AF0611 VA: 0x2AF0510
	public static float ToAngle(Vector3 dir) { }

	[ExtensionAttribute] // RVA: 0x1AC7F0 Offset: 0x1AC8F1 VA: 0x1AC7F0
	// RVA: 0x2AF05A0 Offset: 0x2AF06A1 VA: 0x2AF05A0
	public static Vector3 V3(Vector2 v2) { }

	[ExtensionAttribute] // RVA: 0x1AC800 Offset: 0x1AC901 VA: 0x1AC800
	// RVA: 0x2AF05E0 Offset: 0x2AF06E1 VA: 0x2AF05E0
	public static Vector2 V2(Vector3 v3) { }

	[ExtensionAttribute] // RVA: 0x1AC810 Offset: 0x1AC911 VA: 0x1AC810
	// RVA: 0x2AF0610 Offset: 0x2AF0711 VA: 0x2AF0610
	public static Vector3 ToV3(float f) { }

	[ExtensionAttribute] // RVA: 0x1AC820 Offset: 0x1AC921 VA: 0x1AC820
	// RVA: 0x2AF0650 Offset: 0x2AF0751 VA: 0x2AF0650
	public static Quaternion EulerToQuat(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x1AC830 Offset: 0x1AC931 VA: 0x1AC830
	// RVA: 0x2AF0710 Offset: 0x2AF0811 VA: 0x2AF0710
	public static Quaternion EulerToQuat(float f) { }

	[ExtensionAttribute] // RVA: 0x1AC840 Offset: 0x1AC941 VA: 0x1AC840
	// RVA: 0x2AF07D0 Offset: 0x2AF08D1 VA: 0x2AF07D0
	public static Vector3 Direction(float angle) { }

	[ExtensionAttribute] // RVA: 0x1AC850 Offset: 0x1AC951 VA: 0x1AC850
	// RVA: 0x2AF0890 Offset: 0x2AF0991 VA: 0x2AF0890
	public static float Angle(Vector3 dir) { }

	[ExtensionAttribute] // RVA: 0x1AC860 Offset: 0x1AC961 VA: 0x1AC860
	// RVA: 0x2AF0920 Offset: 0x2AF0A21 VA: 0x2AF0920
	public static Rect Clamp(Rect r, float p) { }

	[ExtensionAttribute] // RVA: 0x1AC870 Offset: 0x1AC971 VA: 0x1AC870
	// RVA: 0x2AF09C0 Offset: 0x2AF0AC1 VA: 0x2AF09C0
	public static Rect ClampFromLeft(Rect r, float p) { }

	[ExtensionAttribute] // RVA: 0x1AC880 Offset: 0x1AC981 VA: 0x1AC880
	// RVA: 0x2AF0A80 Offset: 0x2AF0B81 VA: 0x2AF0A80
	public static Rect Clamp(Rect r, int p) { }

	[ExtensionAttribute] // RVA: 0x1AC890 Offset: 0x1AC991 VA: 0x1AC890
	// RVA: 0x2AF0B10 Offset: 0x2AF0C11 VA: 0x2AF0B10
	public static Rect ClampFromLeft(Rect r, int p) { }

	[ExtensionAttribute] // RVA: 0x1AC8A0 Offset: 0x1AC9A1 VA: 0x1AC8A0
	// RVA: 0x2AF0BC0 Offset: 0x2AF0CC1 VA: 0x2AF0BC0
	public static bool Intersects(Rect r1, Rect r2) { }

	[ExtensionAttribute] // RVA: 0x1AC8B0 Offset: 0x1AC9B1 VA: 0x1AC8B0
	// RVA: 0x2AF0C70 Offset: 0x2AF0D71 VA: 0x2AF0C70
	public static bool Intersects(Rect r1, Rect[] rects) { }

	[ExtensionAttribute] // RVA: 0x1AC8C0 Offset: 0x1AC9C1 VA: 0x1AC8C0
	// RVA: 0x2AF0D20 Offset: 0x2AF0E21 VA: 0x2AF0D20
	public static bool Contains(Rect r1, Rect r2) { }

	[ExtensionAttribute] // RVA: 0x1AC8D0 Offset: 0x1AC9D1 VA: 0x1AC8D0
	// RVA: 0x2AF0DE0 Offset: 0x2AF0EE1 VA: 0x2AF0DE0
	public static Rect Extend(Rect r, float f) { }

	[ExtensionAttribute] // RVA: 0x1AC8E0 Offset: 0x1AC9E1 VA: 0x1AC8E0
	// RVA: 0x2AF0E80 Offset: 0x2AF0F81 VA: 0x2AF0E80
	public static Coord RoundToCoord(Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x1AC8F0 Offset: 0x1AC9F1 VA: 0x1AC8F0
	// RVA: 0x2AF0EC0 Offset: 0x2AF0FC1 VA: 0x2AF0EC0
	public static Coord FloorToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC900 Offset: 0x1ACA01 VA: 0x1AC900
	// RVA: 0x2AF0F60 Offset: 0x2AF1061 VA: 0x2AF0F60
	public static Coord CeilToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC910 Offset: 0x1ACA11 VA: 0x1AC910
	// RVA: 0x2AF1000 Offset: 0x2AF1101 VA: 0x2AF1000
	public static Coord RoundToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC920 Offset: 0x1ACA21 VA: 0x1AC920
	// RVA: 0x2AED5A0 Offset: 0x2AED6A1 VA: 0x2AED5A0
	public static CoordRect ToCoordRect(Vector3 pos, float range, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC930 Offset: 0x1ACA31 VA: 0x1AC930
	// RVA: 0x2AED2D0 Offset: 0x2AED3D1 VA: 0x2AED2D0
	public static CoordRect ToCoordRect(Vector3 pos, float range, float cellSizeX, float cellSizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC940 Offset: 0x1ACA41 VA: 0x1AC940
	// RVA: 0x2AEDC70 Offset: 0x2AEDD71 VA: 0x2AEDC70
	public static CoordRect GetHeightRect(Terrain terrain) { }

	[ExtensionAttribute] // RVA: 0x1AC950 Offset: 0x1ACA51 VA: 0x1AC950
	// RVA: 0x2AEDDE0 Offset: 0x2AEDEE1 VA: 0x2AEDDE0
	public static CoordRect GetSplatRect(Terrain terrain) { }

	[ExtensionAttribute] // RVA: 0x1AC960 Offset: 0x1ACA61 VA: 0x1AC960
	// RVA: 0x2AF0070 Offset: 0x2AF0171 VA: 0x2AF0070
	public static float[,] SafeGetHeights(TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC970 Offset: 0x1ACA71 VA: 0x1AC970
	// RVA: 0x2AF0100 Offset: 0x2AF0201 VA: 0x2AF0100
	public static float[,,] SafeGetAlphamaps(TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC980 Offset: 0x1ACA81 VA: 0x1AC980
	// RVA: 0x2AF10A0 Offset: 0x2AF11A1 VA: 0x2AF10A0
	public static List<Type> GetAllChildTypes(Type type) { }

	// RVA: 0x2AF1220 Offset: 0x2AF1321 VA: 0x2AF1220
	public static Texture2D ColorTexture(int width, int height, Color color) { }

	// RVA: 0x2AF1350 Offset: 0x2AF1451 VA: 0x2AF1350
	public static bool Equal(Vector3 v1, Vector3 v2) { }

	// RVA: 0x2AF1460 Offset: 0x2AF1561 VA: 0x2AF1460
	public static bool Equal(Ray r1, Ray r2) { }

	[ExtensionAttribute] // RVA: 0x1AC990 Offset: 0x1ACA91 VA: 0x1AC990
	// RVA: 0x2AF1530 Offset: 0x2AF1631 VA: 0x2AF1530
	public static void RemoveChildren(Transform tfm) { }

	[ExtensionAttribute] // RVA: 0x1AC9A0 Offset: 0x1ACAA1 VA: 0x1AC9A0
	// RVA: 0x2AF15F0 Offset: 0x2AF16F1 VA: 0x2AF15F0
	public static Transform FindChildRecursive(Transform tfm, string name) { }

	[ExtensionAttribute] // RVA: 0x1AC9B0 Offset: 0x1ACAB1 VA: 0x1AC9B0
	// RVA: 0x2AF1730 Offset: 0x2AF1831 VA: 0x2AF1730
	public static void ToggleDisplayWireframe(Transform tfm, bool show) { }

	[ExtensionAttribute] // RVA: 0x1AC9C0 Offset: 0x1ACAC1 VA: 0x1AC9C0
	// RVA: 0x2AF1740 Offset: 0x2AF1841 VA: 0x2AF1740
	public static int ToInt(Coord coord) { }

	[ExtensionAttribute] // RVA: 0x1AC9D0 Offset: 0x1ACAD1 VA: 0x1AC9D0
	// RVA: 0x2AF1780 Offset: 0x2AF1881 VA: 0x2AF1780
	public static Coord ToCoord(int hash) { }

	[ExtensionAttribute] // RVA: 0x1AC9E0 Offset: 0x1ACAE1 VA: 0x1AC9E0
	// RVA: -1 Offset: -1
	public static void CheckAdd<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, TValue value, bool replace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0290 Offset: 0x21D0391 VA: 0x21D0290
	|-Extensions.CheckAdd<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1AC9F0 Offset: 0x1ACAF1 VA: 0x1AC9F0
	// RVA: -1 Offset: -1
	public static void CheckRemove<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D03A0 Offset: 0x21D04A1 VA: 0x21D03A0
	|-Extensions.CheckRemove<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA00 Offset: 0x1ACB01 VA: 0x1ACA00
	// RVA: -1 Offset: -1
	public static TValue CheckGet<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CAE0 Offset: 0x226CBE1 VA: 0x226CAE0
	|-Extensions.CheckGet<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA10 Offset: 0x1ACB11 VA: 0x1ACA10
	// RVA: -1 Offset: -1
	public static void CheckAdd<T>(HashSet<T> set, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0330 Offset: 0x21D0431 VA: 0x21D0330
	|-Extensions.CheckAdd<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA20 Offset: 0x1ACB21 VA: 0x1ACA20
	// RVA: -1 Offset: -1
	public static void CheckRemove<T>(HashSet<T> set, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0410 Offset: 0x21D0511 VA: 0x21D0410
	|-Extensions.CheckRemove<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA30 Offset: 0x1ACB31 VA: 0x1ACA30
	// RVA: -1 Offset: -1
	public static void SetState<T>(HashSet<T> set, T obj, bool state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0C60 Offset: 0x21D0D61 VA: 0x21D0C60
	|-Extensions.SetState<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA40 Offset: 0x1ACB41 VA: 0x1ACA40
	// RVA: 0x2AF17F0 Offset: 0x2AF18F1 VA: 0x2AF17F0
	public static void Normalize(float[,,] array, int pinnedLayer) { }

	[ExtensionAttribute] // RVA: 0x1ACA50 Offset: 0x1ACB51 VA: 0x1ACA50
	// RVA: 0x2AF1A00 Offset: 0x2AF1B01 VA: 0x2AF1A00
	public static void DrawDebug(Vector3 pos, float range = 1, Color color) { }

	[ExtensionAttribute] // RVA: 0x1ACA60 Offset: 0x1ACB61 VA: 0x1ACA60
	// RVA: 0x2AF1ED0 Offset: 0x2AF1FD1 VA: 0x2AF1ED0
	public static void DrawDebug(Rect rect, Color color) { }

	[ExtensionAttribute] // RVA: 0x1ACA70 Offset: 0x1ACB71 VA: 0x1ACA70
	// RVA: 0x2AF22B0 Offset: 0x2AF23B1 VA: 0x2AF22B0
	public static void Resize(Terrain terrain, int resolution, Vector3 size) { }

	[ExtensionAttribute] // RVA: 0x1ACA80 Offset: 0x1ACB81 VA: 0x1ACA80
	// RVA: 0x2AF24F0 Offset: 0x2AF25F1 VA: 0x2AF24F0
	public static Transform AddChild(Transform tfm, string name = "", Vector3 offset) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACA90 Offset: 0x1ACB91 VA: 0x1ACA90
	[ExtensionAttribute] // RVA: 0x1ACA90 Offset: 0x1ACB91 VA: 0x1ACA90
	// RVA: 0x2AF25E0 Offset: 0x2AF26E1 VA: 0x2AF25E0
	public static IEnumerable<Vector3> CircleAround(Vector3 center, float radius, int numPoints, bool endWhereStart = False) { }

	[ExtensionAttribute] // RVA: 0x1ACB10 Offset: 0x1ACC11 VA: 0x1ACB10
	// RVA: 0x2AF26F0 Offset: 0x2AF27F1 VA: 0x2AF26F0
	public static float EvaluateMultithreaded(AnimationCurve curve, float time) { }

	[ExtensionAttribute] // RVA: 0x1ACB20 Offset: 0x1ACC21 VA: 0x1ACB20
	// RVA: -1 Offset: -1
	public static void GetPropertiesFrom<T1, T2>(T1 dst, T2 src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0480 Offset: 0x21D0581 VA: 0x21D0480
	|-Extensions.GetPropertiesFrom<object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1ACB30 Offset: 0x1ACC31 VA: 0x1ACB30
	[ExtensionAttribute] // RVA: 0x1ACB30 Offset: 0x1ACC31 VA: 0x1ACB30
	// RVA: 0x2AF2A90 Offset: 0x2AF2B91 VA: 0x2AF2A90
	public static IEnumerable<FieldInfo> UsableFields(Type type, bool nonPublic = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACBB0 Offset: 0x1ACCB1 VA: 0x1ACBB0
	[ExtensionAttribute] // RVA: 0x1ACBB0 Offset: 0x1ACCB1 VA: 0x1ACBB0
	// RVA: 0x2AF2B70 Offset: 0x2AF2C71 VA: 0x2AF2B70
	public static IEnumerable<PropertyInfo> UsableProperties(Type type, bool nonPublic = False, bool skipItems = True) { }

	// RVA: 0x2AF2C60 Offset: 0x2AF2D61 VA: 0x2AF2C60
	public static Component CopyComponent(Component src, GameObject go) { }

	[ExtensionAttribute] // RVA: 0x1ACC30 Offset: 0x1ACD31 VA: 0x1ACC30
	// RVA: -1 Offset: -1
	public static void ReflectionReset<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0660 Offset: 0x21D0761 VA: 0x21D0660
	|-Extensions.ReflectionReset<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACC40 Offset: 0x1ACD41 VA: 0x1ACC40
	// RVA: -1 Offset: -1
	public static T ReflectionCopy<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C0850 Offset: 0x23C0951 VA: 0x23C0850
	|-Extensions.ReflectionCopy<object>
	*/
}

[ExtensionAttribute] // RVA: 0x1495A0 Offset: 0x1496A1 VA: 0x1495A0
public static class Extensions // TypeDefIndex: 9715
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1AC7C0 Offset: 0x1AC8C1 VA: 0x1AC7C0
	// RVA: 0x2AF0350 Offset: 0x2AF0451 VA: 0x2AF0350
	public static bool InRange(Rect rect, Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x1AC7D0 Offset: 0x1AC8D1 VA: 0x1AC7D0
	// RVA: 0x2AF0450 Offset: 0x2AF0551 VA: 0x2AF0450
	public static Vector3 ToDir(float angle) { }

	[ExtensionAttribute] // RVA: 0x1AC7E0 Offset: 0x1AC8E1 VA: 0x1AC7E0
	// RVA: 0x2AF0510 Offset: 0x2AF0611 VA: 0x2AF0510
	public static float ToAngle(Vector3 dir) { }

	[ExtensionAttribute] // RVA: 0x1AC7F0 Offset: 0x1AC8F1 VA: 0x1AC7F0
	// RVA: 0x2AF05A0 Offset: 0x2AF06A1 VA: 0x2AF05A0
	public static Vector3 V3(Vector2 v2) { }

	[ExtensionAttribute] // RVA: 0x1AC800 Offset: 0x1AC901 VA: 0x1AC800
	// RVA: 0x2AF05E0 Offset: 0x2AF06E1 VA: 0x2AF05E0
	public static Vector2 V2(Vector3 v3) { }

	[ExtensionAttribute] // RVA: 0x1AC810 Offset: 0x1AC911 VA: 0x1AC810
	// RVA: 0x2AF0610 Offset: 0x2AF0711 VA: 0x2AF0610
	public static Vector3 ToV3(float f) { }

	[ExtensionAttribute] // RVA: 0x1AC820 Offset: 0x1AC921 VA: 0x1AC820
	// RVA: 0x2AF0650 Offset: 0x2AF0751 VA: 0x2AF0650
	public static Quaternion EulerToQuat(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x1AC830 Offset: 0x1AC931 VA: 0x1AC830
	// RVA: 0x2AF0710 Offset: 0x2AF0811 VA: 0x2AF0710
	public static Quaternion EulerToQuat(float f) { }

	[ExtensionAttribute] // RVA: 0x1AC840 Offset: 0x1AC941 VA: 0x1AC840
	// RVA: 0x2AF07D0 Offset: 0x2AF08D1 VA: 0x2AF07D0
	public static Vector3 Direction(float angle) { }

	[ExtensionAttribute] // RVA: 0x1AC850 Offset: 0x1AC951 VA: 0x1AC850
	// RVA: 0x2AF0890 Offset: 0x2AF0991 VA: 0x2AF0890
	public static float Angle(Vector3 dir) { }

	[ExtensionAttribute] // RVA: 0x1AC860 Offset: 0x1AC961 VA: 0x1AC860
	// RVA: 0x2AF0920 Offset: 0x2AF0A21 VA: 0x2AF0920
	public static Rect Clamp(Rect r, float p) { }

	[ExtensionAttribute] // RVA: 0x1AC870 Offset: 0x1AC971 VA: 0x1AC870
	// RVA: 0x2AF09C0 Offset: 0x2AF0AC1 VA: 0x2AF09C0
	public static Rect ClampFromLeft(Rect r, float p) { }

	[ExtensionAttribute] // RVA: 0x1AC880 Offset: 0x1AC981 VA: 0x1AC880
	// RVA: 0x2AF0A80 Offset: 0x2AF0B81 VA: 0x2AF0A80
	public static Rect Clamp(Rect r, int p) { }

	[ExtensionAttribute] // RVA: 0x1AC890 Offset: 0x1AC991 VA: 0x1AC890
	// RVA: 0x2AF0B10 Offset: 0x2AF0C11 VA: 0x2AF0B10
	public static Rect ClampFromLeft(Rect r, int p) { }

	[ExtensionAttribute] // RVA: 0x1AC8A0 Offset: 0x1AC9A1 VA: 0x1AC8A0
	// RVA: 0x2AF0BC0 Offset: 0x2AF0CC1 VA: 0x2AF0BC0
	public static bool Intersects(Rect r1, Rect r2) { }

	[ExtensionAttribute] // RVA: 0x1AC8B0 Offset: 0x1AC9B1 VA: 0x1AC8B0
	// RVA: 0x2AF0C70 Offset: 0x2AF0D71 VA: 0x2AF0C70
	public static bool Intersects(Rect r1, Rect[] rects) { }

	[ExtensionAttribute] // RVA: 0x1AC8C0 Offset: 0x1AC9C1 VA: 0x1AC8C0
	// RVA: 0x2AF0D20 Offset: 0x2AF0E21 VA: 0x2AF0D20
	public static bool Contains(Rect r1, Rect r2) { }

	[ExtensionAttribute] // RVA: 0x1AC8D0 Offset: 0x1AC9D1 VA: 0x1AC8D0
	// RVA: 0x2AF0DE0 Offset: 0x2AF0EE1 VA: 0x2AF0DE0
	public static Rect Extend(Rect r, float f) { }

	[ExtensionAttribute] // RVA: 0x1AC8E0 Offset: 0x1AC9E1 VA: 0x1AC8E0
	// RVA: 0x2AF0E80 Offset: 0x2AF0F81 VA: 0x2AF0E80
	public static Coord RoundToCoord(Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x1AC8F0 Offset: 0x1AC9F1 VA: 0x1AC8F0
	// RVA: 0x2AF0EC0 Offset: 0x2AF0FC1 VA: 0x2AF0EC0
	public static Coord FloorToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC900 Offset: 0x1ACA01 VA: 0x1AC900
	// RVA: 0x2AF0F60 Offset: 0x2AF1061 VA: 0x2AF0F60
	public static Coord CeilToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC910 Offset: 0x1ACA11 VA: 0x1AC910
	// RVA: 0x2AF1000 Offset: 0x2AF1101 VA: 0x2AF1000
	public static Coord RoundToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC920 Offset: 0x1ACA21 VA: 0x1AC920
	// RVA: 0x2AED5A0 Offset: 0x2AED6A1 VA: 0x2AED5A0
	public static CoordRect ToCoordRect(Vector3 pos, float range, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC930 Offset: 0x1ACA31 VA: 0x1AC930
	// RVA: 0x2AED2D0 Offset: 0x2AED3D1 VA: 0x2AED2D0
	public static CoordRect ToCoordRect(Vector3 pos, float range, float cellSizeX, float cellSizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC940 Offset: 0x1ACA41 VA: 0x1AC940
	// RVA: 0x2AEDC70 Offset: 0x2AEDD71 VA: 0x2AEDC70
	public static CoordRect GetHeightRect(Terrain terrain) { }

	[ExtensionAttribute] // RVA: 0x1AC950 Offset: 0x1ACA51 VA: 0x1AC950
	// RVA: 0x2AEDDE0 Offset: 0x2AEDEE1 VA: 0x2AEDDE0
	public static CoordRect GetSplatRect(Terrain terrain) { }

	[ExtensionAttribute] // RVA: 0x1AC960 Offset: 0x1ACA61 VA: 0x1AC960
	// RVA: 0x2AF0070 Offset: 0x2AF0171 VA: 0x2AF0070
	public static float[,] SafeGetHeights(TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC970 Offset: 0x1ACA71 VA: 0x1AC970
	// RVA: 0x2AF0100 Offset: 0x2AF0201 VA: 0x2AF0100
	public static float[,,] SafeGetAlphamaps(TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC980 Offset: 0x1ACA81 VA: 0x1AC980
	// RVA: 0x2AF10A0 Offset: 0x2AF11A1 VA: 0x2AF10A0
	public static List<Type> GetAllChildTypes(Type type) { }

	// RVA: 0x2AF1220 Offset: 0x2AF1321 VA: 0x2AF1220
	public static Texture2D ColorTexture(int width, int height, Color color) { }

	// RVA: 0x2AF1350 Offset: 0x2AF1451 VA: 0x2AF1350
	public static bool Equal(Vector3 v1, Vector3 v2) { }

	// RVA: 0x2AF1460 Offset: 0x2AF1561 VA: 0x2AF1460
	public static bool Equal(Ray r1, Ray r2) { }

	[ExtensionAttribute] // RVA: 0x1AC990 Offset: 0x1ACA91 VA: 0x1AC990
	// RVA: 0x2AF1530 Offset: 0x2AF1631 VA: 0x2AF1530
	public static void RemoveChildren(Transform tfm) { }

	[ExtensionAttribute] // RVA: 0x1AC9A0 Offset: 0x1ACAA1 VA: 0x1AC9A0
	// RVA: 0x2AF15F0 Offset: 0x2AF16F1 VA: 0x2AF15F0
	public static Transform FindChildRecursive(Transform tfm, string name) { }

	[ExtensionAttribute] // RVA: 0x1AC9B0 Offset: 0x1ACAB1 VA: 0x1AC9B0
	// RVA: 0x2AF1730 Offset: 0x2AF1831 VA: 0x2AF1730
	public static void ToggleDisplayWireframe(Transform tfm, bool show) { }

	[ExtensionAttribute] // RVA: 0x1AC9C0 Offset: 0x1ACAC1 VA: 0x1AC9C0
	// RVA: 0x2AF1740 Offset: 0x2AF1841 VA: 0x2AF1740
	public static int ToInt(Coord coord) { }

	[ExtensionAttribute] // RVA: 0x1AC9D0 Offset: 0x1ACAD1 VA: 0x1AC9D0
	// RVA: 0x2AF1780 Offset: 0x2AF1881 VA: 0x2AF1780
	public static Coord ToCoord(int hash) { }

	[ExtensionAttribute] // RVA: 0x1AC9E0 Offset: 0x1ACAE1 VA: 0x1AC9E0
	// RVA: -1 Offset: -1
	public static void CheckAdd<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, TValue value, bool replace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0290 Offset: 0x21D0391 VA: 0x21D0290
	|-Extensions.CheckAdd<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1AC9F0 Offset: 0x1ACAF1 VA: 0x1AC9F0
	// RVA: -1 Offset: -1
	public static void CheckRemove<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D03A0 Offset: 0x21D04A1 VA: 0x21D03A0
	|-Extensions.CheckRemove<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA00 Offset: 0x1ACB01 VA: 0x1ACA00
	// RVA: -1 Offset: -1
	public static TValue CheckGet<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CAE0 Offset: 0x226CBE1 VA: 0x226CAE0
	|-Extensions.CheckGet<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA10 Offset: 0x1ACB11 VA: 0x1ACA10
	// RVA: -1 Offset: -1
	public static void CheckAdd<T>(HashSet<T> set, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0330 Offset: 0x21D0431 VA: 0x21D0330
	|-Extensions.CheckAdd<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA20 Offset: 0x1ACB21 VA: 0x1ACA20
	// RVA: -1 Offset: -1
	public static void CheckRemove<T>(HashSet<T> set, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0410 Offset: 0x21D0511 VA: 0x21D0410
	|-Extensions.CheckRemove<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA30 Offset: 0x1ACB31 VA: 0x1ACA30
	// RVA: -1 Offset: -1
	public static void SetState<T>(HashSet<T> set, T obj, bool state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0C60 Offset: 0x21D0D61 VA: 0x21D0C60
	|-Extensions.SetState<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA40 Offset: 0x1ACB41 VA: 0x1ACA40
	// RVA: 0x2AF17F0 Offset: 0x2AF18F1 VA: 0x2AF17F0
	public static void Normalize(float[,,] array, int pinnedLayer) { }

	[ExtensionAttribute] // RVA: 0x1ACA50 Offset: 0x1ACB51 VA: 0x1ACA50
	// RVA: 0x2AF1A00 Offset: 0x2AF1B01 VA: 0x2AF1A00
	public static void DrawDebug(Vector3 pos, float range = 1, Color color) { }

	[ExtensionAttribute] // RVA: 0x1ACA60 Offset: 0x1ACB61 VA: 0x1ACA60
	// RVA: 0x2AF1ED0 Offset: 0x2AF1FD1 VA: 0x2AF1ED0
	public static void DrawDebug(Rect rect, Color color) { }

	[ExtensionAttribute] // RVA: 0x1ACA70 Offset: 0x1ACB71 VA: 0x1ACA70
	// RVA: 0x2AF22B0 Offset: 0x2AF23B1 VA: 0x2AF22B0
	public static void Resize(Terrain terrain, int resolution, Vector3 size) { }

	[ExtensionAttribute] // RVA: 0x1ACA80 Offset: 0x1ACB81 VA: 0x1ACA80
	// RVA: 0x2AF24F0 Offset: 0x2AF25F1 VA: 0x2AF24F0
	public static Transform AddChild(Transform tfm, string name = "", Vector3 offset) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACA90 Offset: 0x1ACB91 VA: 0x1ACA90
	[ExtensionAttribute] // RVA: 0x1ACA90 Offset: 0x1ACB91 VA: 0x1ACA90
	// RVA: 0x2AF25E0 Offset: 0x2AF26E1 VA: 0x2AF25E0
	public static IEnumerable<Vector3> CircleAround(Vector3 center, float radius, int numPoints, bool endWhereStart = False) { }

	[ExtensionAttribute] // RVA: 0x1ACB10 Offset: 0x1ACC11 VA: 0x1ACB10
	// RVA: 0x2AF26F0 Offset: 0x2AF27F1 VA: 0x2AF26F0
	public static float EvaluateMultithreaded(AnimationCurve curve, float time) { }

	[ExtensionAttribute] // RVA: 0x1ACB20 Offset: 0x1ACC21 VA: 0x1ACB20
	// RVA: -1 Offset: -1
	public static void GetPropertiesFrom<T1, T2>(T1 dst, T2 src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0480 Offset: 0x21D0581 VA: 0x21D0480
	|-Extensions.GetPropertiesFrom<object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1ACB30 Offset: 0x1ACC31 VA: 0x1ACB30
	[ExtensionAttribute] // RVA: 0x1ACB30 Offset: 0x1ACC31 VA: 0x1ACB30
	// RVA: 0x2AF2A90 Offset: 0x2AF2B91 VA: 0x2AF2A90
	public static IEnumerable<FieldInfo> UsableFields(Type type, bool nonPublic = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACBB0 Offset: 0x1ACCB1 VA: 0x1ACBB0
	[ExtensionAttribute] // RVA: 0x1ACBB0 Offset: 0x1ACCB1 VA: 0x1ACBB0
	// RVA: 0x2AF2B70 Offset: 0x2AF2C71 VA: 0x2AF2B70
	public static IEnumerable<PropertyInfo> UsableProperties(Type type, bool nonPublic = False, bool skipItems = True) { }

	// RVA: 0x2AF2C60 Offset: 0x2AF2D61 VA: 0x2AF2C60
	public static Component CopyComponent(Component src, GameObject go) { }

	[ExtensionAttribute] // RVA: 0x1ACC30 Offset: 0x1ACD31 VA: 0x1ACC30
	// RVA: -1 Offset: -1
	public static void ReflectionReset<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0660 Offset: 0x21D0761 VA: 0x21D0660
	|-Extensions.ReflectionReset<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACC40 Offset: 0x1ACD41 VA: 0x1ACC40
	// RVA: -1 Offset: -1
	public static T ReflectionCopy<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C0850 Offset: 0x23C0951 VA: 0x23C0850
	|-Extensions.ReflectionCopy<object>
	*/
}

[ExtensionAttribute] // RVA: 0x1495A0 Offset: 0x1496A1 VA: 0x1495A0
public static class Extensions // TypeDefIndex: 9715
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1AC7C0 Offset: 0x1AC8C1 VA: 0x1AC7C0
	// RVA: 0x2AF0350 Offset: 0x2AF0451 VA: 0x2AF0350
	public static bool InRange(Rect rect, Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x1AC7D0 Offset: 0x1AC8D1 VA: 0x1AC7D0
	// RVA: 0x2AF0450 Offset: 0x2AF0551 VA: 0x2AF0450
	public static Vector3 ToDir(float angle) { }

	[ExtensionAttribute] // RVA: 0x1AC7E0 Offset: 0x1AC8E1 VA: 0x1AC7E0
	// RVA: 0x2AF0510 Offset: 0x2AF0611 VA: 0x2AF0510
	public static float ToAngle(Vector3 dir) { }

	[ExtensionAttribute] // RVA: 0x1AC7F0 Offset: 0x1AC8F1 VA: 0x1AC7F0
	// RVA: 0x2AF05A0 Offset: 0x2AF06A1 VA: 0x2AF05A0
	public static Vector3 V3(Vector2 v2) { }

	[ExtensionAttribute] // RVA: 0x1AC800 Offset: 0x1AC901 VA: 0x1AC800
	// RVA: 0x2AF05E0 Offset: 0x2AF06E1 VA: 0x2AF05E0
	public static Vector2 V2(Vector3 v3) { }

	[ExtensionAttribute] // RVA: 0x1AC810 Offset: 0x1AC911 VA: 0x1AC810
	// RVA: 0x2AF0610 Offset: 0x2AF0711 VA: 0x2AF0610
	public static Vector3 ToV3(float f) { }

	[ExtensionAttribute] // RVA: 0x1AC820 Offset: 0x1AC921 VA: 0x1AC820
	// RVA: 0x2AF0650 Offset: 0x2AF0751 VA: 0x2AF0650
	public static Quaternion EulerToQuat(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x1AC830 Offset: 0x1AC931 VA: 0x1AC830
	// RVA: 0x2AF0710 Offset: 0x2AF0811 VA: 0x2AF0710
	public static Quaternion EulerToQuat(float f) { }

	[ExtensionAttribute] // RVA: 0x1AC840 Offset: 0x1AC941 VA: 0x1AC840
	// RVA: 0x2AF07D0 Offset: 0x2AF08D1 VA: 0x2AF07D0
	public static Vector3 Direction(float angle) { }

	[ExtensionAttribute] // RVA: 0x1AC850 Offset: 0x1AC951 VA: 0x1AC850
	// RVA: 0x2AF0890 Offset: 0x2AF0991 VA: 0x2AF0890
	public static float Angle(Vector3 dir) { }

	[ExtensionAttribute] // RVA: 0x1AC860 Offset: 0x1AC961 VA: 0x1AC860
	// RVA: 0x2AF0920 Offset: 0x2AF0A21 VA: 0x2AF0920
	public static Rect Clamp(Rect r, float p) { }

	[ExtensionAttribute] // RVA: 0x1AC870 Offset: 0x1AC971 VA: 0x1AC870
	// RVA: 0x2AF09C0 Offset: 0x2AF0AC1 VA: 0x2AF09C0
	public static Rect ClampFromLeft(Rect r, float p) { }

	[ExtensionAttribute] // RVA: 0x1AC880 Offset: 0x1AC981 VA: 0x1AC880
	// RVA: 0x2AF0A80 Offset: 0x2AF0B81 VA: 0x2AF0A80
	public static Rect Clamp(Rect r, int p) { }

	[ExtensionAttribute] // RVA: 0x1AC890 Offset: 0x1AC991 VA: 0x1AC890
	// RVA: 0x2AF0B10 Offset: 0x2AF0C11 VA: 0x2AF0B10
	public static Rect ClampFromLeft(Rect r, int p) { }

	[ExtensionAttribute] // RVA: 0x1AC8A0 Offset: 0x1AC9A1 VA: 0x1AC8A0
	// RVA: 0x2AF0BC0 Offset: 0x2AF0CC1 VA: 0x2AF0BC0
	public static bool Intersects(Rect r1, Rect r2) { }

	[ExtensionAttribute] // RVA: 0x1AC8B0 Offset: 0x1AC9B1 VA: 0x1AC8B0
	// RVA: 0x2AF0C70 Offset: 0x2AF0D71 VA: 0x2AF0C70
	public static bool Intersects(Rect r1, Rect[] rects) { }

	[ExtensionAttribute] // RVA: 0x1AC8C0 Offset: 0x1AC9C1 VA: 0x1AC8C0
	// RVA: 0x2AF0D20 Offset: 0x2AF0E21 VA: 0x2AF0D20
	public static bool Contains(Rect r1, Rect r2) { }

	[ExtensionAttribute] // RVA: 0x1AC8D0 Offset: 0x1AC9D1 VA: 0x1AC8D0
	// RVA: 0x2AF0DE0 Offset: 0x2AF0EE1 VA: 0x2AF0DE0
	public static Rect Extend(Rect r, float f) { }

	[ExtensionAttribute] // RVA: 0x1AC8E0 Offset: 0x1AC9E1 VA: 0x1AC8E0
	// RVA: 0x2AF0E80 Offset: 0x2AF0F81 VA: 0x2AF0E80
	public static Coord RoundToCoord(Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x1AC8F0 Offset: 0x1AC9F1 VA: 0x1AC8F0
	// RVA: 0x2AF0EC0 Offset: 0x2AF0FC1 VA: 0x2AF0EC0
	public static Coord FloorToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC900 Offset: 0x1ACA01 VA: 0x1AC900
	// RVA: 0x2AF0F60 Offset: 0x2AF1061 VA: 0x2AF0F60
	public static Coord CeilToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC910 Offset: 0x1ACA11 VA: 0x1AC910
	// RVA: 0x2AF1000 Offset: 0x2AF1101 VA: 0x2AF1000
	public static Coord RoundToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC920 Offset: 0x1ACA21 VA: 0x1AC920
	// RVA: 0x2AED5A0 Offset: 0x2AED6A1 VA: 0x2AED5A0
	public static CoordRect ToCoordRect(Vector3 pos, float range, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC930 Offset: 0x1ACA31 VA: 0x1AC930
	// RVA: 0x2AED2D0 Offset: 0x2AED3D1 VA: 0x2AED2D0
	public static CoordRect ToCoordRect(Vector3 pos, float range, float cellSizeX, float cellSizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC940 Offset: 0x1ACA41 VA: 0x1AC940
	// RVA: 0x2AEDC70 Offset: 0x2AEDD71 VA: 0x2AEDC70
	public static CoordRect GetHeightRect(Terrain terrain) { }

	[ExtensionAttribute] // RVA: 0x1AC950 Offset: 0x1ACA51 VA: 0x1AC950
	// RVA: 0x2AEDDE0 Offset: 0x2AEDEE1 VA: 0x2AEDDE0
	public static CoordRect GetSplatRect(Terrain terrain) { }

	[ExtensionAttribute] // RVA: 0x1AC960 Offset: 0x1ACA61 VA: 0x1AC960
	// RVA: 0x2AF0070 Offset: 0x2AF0171 VA: 0x2AF0070
	public static float[,] SafeGetHeights(TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC970 Offset: 0x1ACA71 VA: 0x1AC970
	// RVA: 0x2AF0100 Offset: 0x2AF0201 VA: 0x2AF0100
	public static float[,,] SafeGetAlphamaps(TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC980 Offset: 0x1ACA81 VA: 0x1AC980
	// RVA: 0x2AF10A0 Offset: 0x2AF11A1 VA: 0x2AF10A0
	public static List<Type> GetAllChildTypes(Type type) { }

	// RVA: 0x2AF1220 Offset: 0x2AF1321 VA: 0x2AF1220
	public static Texture2D ColorTexture(int width, int height, Color color) { }

	// RVA: 0x2AF1350 Offset: 0x2AF1451 VA: 0x2AF1350
	public static bool Equal(Vector3 v1, Vector3 v2) { }

	// RVA: 0x2AF1460 Offset: 0x2AF1561 VA: 0x2AF1460
	public static bool Equal(Ray r1, Ray r2) { }

	[ExtensionAttribute] // RVA: 0x1AC990 Offset: 0x1ACA91 VA: 0x1AC990
	// RVA: 0x2AF1530 Offset: 0x2AF1631 VA: 0x2AF1530
	public static void RemoveChildren(Transform tfm) { }

	[ExtensionAttribute] // RVA: 0x1AC9A0 Offset: 0x1ACAA1 VA: 0x1AC9A0
	// RVA: 0x2AF15F0 Offset: 0x2AF16F1 VA: 0x2AF15F0
	public static Transform FindChildRecursive(Transform tfm, string name) { }

	[ExtensionAttribute] // RVA: 0x1AC9B0 Offset: 0x1ACAB1 VA: 0x1AC9B0
	// RVA: 0x2AF1730 Offset: 0x2AF1831 VA: 0x2AF1730
	public static void ToggleDisplayWireframe(Transform tfm, bool show) { }

	[ExtensionAttribute] // RVA: 0x1AC9C0 Offset: 0x1ACAC1 VA: 0x1AC9C0
	// RVA: 0x2AF1740 Offset: 0x2AF1841 VA: 0x2AF1740
	public static int ToInt(Coord coord) { }

	[ExtensionAttribute] // RVA: 0x1AC9D0 Offset: 0x1ACAD1 VA: 0x1AC9D0
	// RVA: 0x2AF1780 Offset: 0x2AF1881 VA: 0x2AF1780
	public static Coord ToCoord(int hash) { }

	[ExtensionAttribute] // RVA: 0x1AC9E0 Offset: 0x1ACAE1 VA: 0x1AC9E0
	// RVA: -1 Offset: -1
	public static void CheckAdd<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, TValue value, bool replace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0290 Offset: 0x21D0391 VA: 0x21D0290
	|-Extensions.CheckAdd<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1AC9F0 Offset: 0x1ACAF1 VA: 0x1AC9F0
	// RVA: -1 Offset: -1
	public static void CheckRemove<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D03A0 Offset: 0x21D04A1 VA: 0x21D03A0
	|-Extensions.CheckRemove<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA00 Offset: 0x1ACB01 VA: 0x1ACA00
	// RVA: -1 Offset: -1
	public static TValue CheckGet<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CAE0 Offset: 0x226CBE1 VA: 0x226CAE0
	|-Extensions.CheckGet<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA10 Offset: 0x1ACB11 VA: 0x1ACA10
	// RVA: -1 Offset: -1
	public static void CheckAdd<T>(HashSet<T> set, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0330 Offset: 0x21D0431 VA: 0x21D0330
	|-Extensions.CheckAdd<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA20 Offset: 0x1ACB21 VA: 0x1ACA20
	// RVA: -1 Offset: -1
	public static void CheckRemove<T>(HashSet<T> set, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0410 Offset: 0x21D0511 VA: 0x21D0410
	|-Extensions.CheckRemove<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA30 Offset: 0x1ACB31 VA: 0x1ACA30
	// RVA: -1 Offset: -1
	public static void SetState<T>(HashSet<T> set, T obj, bool state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0C60 Offset: 0x21D0D61 VA: 0x21D0C60
	|-Extensions.SetState<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA40 Offset: 0x1ACB41 VA: 0x1ACA40
	// RVA: 0x2AF17F0 Offset: 0x2AF18F1 VA: 0x2AF17F0
	public static void Normalize(float[,,] array, int pinnedLayer) { }

	[ExtensionAttribute] // RVA: 0x1ACA50 Offset: 0x1ACB51 VA: 0x1ACA50
	// RVA: 0x2AF1A00 Offset: 0x2AF1B01 VA: 0x2AF1A00
	public static void DrawDebug(Vector3 pos, float range = 1, Color color) { }

	[ExtensionAttribute] // RVA: 0x1ACA60 Offset: 0x1ACB61 VA: 0x1ACA60
	// RVA: 0x2AF1ED0 Offset: 0x2AF1FD1 VA: 0x2AF1ED0
	public static void DrawDebug(Rect rect, Color color) { }

	[ExtensionAttribute] // RVA: 0x1ACA70 Offset: 0x1ACB71 VA: 0x1ACA70
	// RVA: 0x2AF22B0 Offset: 0x2AF23B1 VA: 0x2AF22B0
	public static void Resize(Terrain terrain, int resolution, Vector3 size) { }

	[ExtensionAttribute] // RVA: 0x1ACA80 Offset: 0x1ACB81 VA: 0x1ACA80
	// RVA: 0x2AF24F0 Offset: 0x2AF25F1 VA: 0x2AF24F0
	public static Transform AddChild(Transform tfm, string name = "", Vector3 offset) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACA90 Offset: 0x1ACB91 VA: 0x1ACA90
	[ExtensionAttribute] // RVA: 0x1ACA90 Offset: 0x1ACB91 VA: 0x1ACA90
	// RVA: 0x2AF25E0 Offset: 0x2AF26E1 VA: 0x2AF25E0
	public static IEnumerable<Vector3> CircleAround(Vector3 center, float radius, int numPoints, bool endWhereStart = False) { }

	[ExtensionAttribute] // RVA: 0x1ACB10 Offset: 0x1ACC11 VA: 0x1ACB10
	// RVA: 0x2AF26F0 Offset: 0x2AF27F1 VA: 0x2AF26F0
	public static float EvaluateMultithreaded(AnimationCurve curve, float time) { }

	[ExtensionAttribute] // RVA: 0x1ACB20 Offset: 0x1ACC21 VA: 0x1ACB20
	// RVA: -1 Offset: -1
	public static void GetPropertiesFrom<T1, T2>(T1 dst, T2 src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0480 Offset: 0x21D0581 VA: 0x21D0480
	|-Extensions.GetPropertiesFrom<object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1ACB30 Offset: 0x1ACC31 VA: 0x1ACB30
	[ExtensionAttribute] // RVA: 0x1ACB30 Offset: 0x1ACC31 VA: 0x1ACB30
	// RVA: 0x2AF2A90 Offset: 0x2AF2B91 VA: 0x2AF2A90
	public static IEnumerable<FieldInfo> UsableFields(Type type, bool nonPublic = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACBB0 Offset: 0x1ACCB1 VA: 0x1ACBB0
	[ExtensionAttribute] // RVA: 0x1ACBB0 Offset: 0x1ACCB1 VA: 0x1ACBB0
	// RVA: 0x2AF2B70 Offset: 0x2AF2C71 VA: 0x2AF2B70
	public static IEnumerable<PropertyInfo> UsableProperties(Type type, bool nonPublic = False, bool skipItems = True) { }

	// RVA: 0x2AF2C60 Offset: 0x2AF2D61 VA: 0x2AF2C60
	public static Component CopyComponent(Component src, GameObject go) { }

	[ExtensionAttribute] // RVA: 0x1ACC30 Offset: 0x1ACD31 VA: 0x1ACC30
	// RVA: -1 Offset: -1
	public static void ReflectionReset<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0660 Offset: 0x21D0761 VA: 0x21D0660
	|-Extensions.ReflectionReset<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACC40 Offset: 0x1ACD41 VA: 0x1ACC40
	// RVA: -1 Offset: -1
	public static T ReflectionCopy<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C0850 Offset: 0x23C0951 VA: 0x23C0850
	|-Extensions.ReflectionCopy<object>
	*/
}

[ExtensionAttribute] // RVA: 0x1495A0 Offset: 0x1496A1 VA: 0x1495A0
public static class Extensions // TypeDefIndex: 9715
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1AC7C0 Offset: 0x1AC8C1 VA: 0x1AC7C0
	// RVA: 0x2AF0350 Offset: 0x2AF0451 VA: 0x2AF0350
	public static bool InRange(Rect rect, Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x1AC7D0 Offset: 0x1AC8D1 VA: 0x1AC7D0
	// RVA: 0x2AF0450 Offset: 0x2AF0551 VA: 0x2AF0450
	public static Vector3 ToDir(float angle) { }

	[ExtensionAttribute] // RVA: 0x1AC7E0 Offset: 0x1AC8E1 VA: 0x1AC7E0
	// RVA: 0x2AF0510 Offset: 0x2AF0611 VA: 0x2AF0510
	public static float ToAngle(Vector3 dir) { }

	[ExtensionAttribute] // RVA: 0x1AC7F0 Offset: 0x1AC8F1 VA: 0x1AC7F0
	// RVA: 0x2AF05A0 Offset: 0x2AF06A1 VA: 0x2AF05A0
	public static Vector3 V3(Vector2 v2) { }

	[ExtensionAttribute] // RVA: 0x1AC800 Offset: 0x1AC901 VA: 0x1AC800
	// RVA: 0x2AF05E0 Offset: 0x2AF06E1 VA: 0x2AF05E0
	public static Vector2 V2(Vector3 v3) { }

	[ExtensionAttribute] // RVA: 0x1AC810 Offset: 0x1AC911 VA: 0x1AC810
	// RVA: 0x2AF0610 Offset: 0x2AF0711 VA: 0x2AF0610
	public static Vector3 ToV3(float f) { }

	[ExtensionAttribute] // RVA: 0x1AC820 Offset: 0x1AC921 VA: 0x1AC820
	// RVA: 0x2AF0650 Offset: 0x2AF0751 VA: 0x2AF0650
	public static Quaternion EulerToQuat(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x1AC830 Offset: 0x1AC931 VA: 0x1AC830
	// RVA: 0x2AF0710 Offset: 0x2AF0811 VA: 0x2AF0710
	public static Quaternion EulerToQuat(float f) { }

	[ExtensionAttribute] // RVA: 0x1AC840 Offset: 0x1AC941 VA: 0x1AC840
	// RVA: 0x2AF07D0 Offset: 0x2AF08D1 VA: 0x2AF07D0
	public static Vector3 Direction(float angle) { }

	[ExtensionAttribute] // RVA: 0x1AC850 Offset: 0x1AC951 VA: 0x1AC850
	// RVA: 0x2AF0890 Offset: 0x2AF0991 VA: 0x2AF0890
	public static float Angle(Vector3 dir) { }

	[ExtensionAttribute] // RVA: 0x1AC860 Offset: 0x1AC961 VA: 0x1AC860
	// RVA: 0x2AF0920 Offset: 0x2AF0A21 VA: 0x2AF0920
	public static Rect Clamp(Rect r, float p) { }

	[ExtensionAttribute] // RVA: 0x1AC870 Offset: 0x1AC971 VA: 0x1AC870
	// RVA: 0x2AF09C0 Offset: 0x2AF0AC1 VA: 0x2AF09C0
	public static Rect ClampFromLeft(Rect r, float p) { }

	[ExtensionAttribute] // RVA: 0x1AC880 Offset: 0x1AC981 VA: 0x1AC880
	// RVA: 0x2AF0A80 Offset: 0x2AF0B81 VA: 0x2AF0A80
	public static Rect Clamp(Rect r, int p) { }

	[ExtensionAttribute] // RVA: 0x1AC890 Offset: 0x1AC991 VA: 0x1AC890
	// RVA: 0x2AF0B10 Offset: 0x2AF0C11 VA: 0x2AF0B10
	public static Rect ClampFromLeft(Rect r, int p) { }

	[ExtensionAttribute] // RVA: 0x1AC8A0 Offset: 0x1AC9A1 VA: 0x1AC8A0
	// RVA: 0x2AF0BC0 Offset: 0x2AF0CC1 VA: 0x2AF0BC0
	public static bool Intersects(Rect r1, Rect r2) { }

	[ExtensionAttribute] // RVA: 0x1AC8B0 Offset: 0x1AC9B1 VA: 0x1AC8B0
	// RVA: 0x2AF0C70 Offset: 0x2AF0D71 VA: 0x2AF0C70
	public static bool Intersects(Rect r1, Rect[] rects) { }

	[ExtensionAttribute] // RVA: 0x1AC8C0 Offset: 0x1AC9C1 VA: 0x1AC8C0
	// RVA: 0x2AF0D20 Offset: 0x2AF0E21 VA: 0x2AF0D20
	public static bool Contains(Rect r1, Rect r2) { }

	[ExtensionAttribute] // RVA: 0x1AC8D0 Offset: 0x1AC9D1 VA: 0x1AC8D0
	// RVA: 0x2AF0DE0 Offset: 0x2AF0EE1 VA: 0x2AF0DE0
	public static Rect Extend(Rect r, float f) { }

	[ExtensionAttribute] // RVA: 0x1AC8E0 Offset: 0x1AC9E1 VA: 0x1AC8E0
	// RVA: 0x2AF0E80 Offset: 0x2AF0F81 VA: 0x2AF0E80
	public static Coord RoundToCoord(Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x1AC8F0 Offset: 0x1AC9F1 VA: 0x1AC8F0
	// RVA: 0x2AF0EC0 Offset: 0x2AF0FC1 VA: 0x2AF0EC0
	public static Coord FloorToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC900 Offset: 0x1ACA01 VA: 0x1AC900
	// RVA: 0x2AF0F60 Offset: 0x2AF1061 VA: 0x2AF0F60
	public static Coord CeilToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC910 Offset: 0x1ACA11 VA: 0x1AC910
	// RVA: 0x2AF1000 Offset: 0x2AF1101 VA: 0x2AF1000
	public static Coord RoundToCoord(Vector3 pos, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC920 Offset: 0x1ACA21 VA: 0x1AC920
	// RVA: 0x2AED5A0 Offset: 0x2AED6A1 VA: 0x2AED5A0
	public static CoordRect ToCoordRect(Vector3 pos, float range, float cellSize) { }

	[ExtensionAttribute] // RVA: 0x1AC930 Offset: 0x1ACA31 VA: 0x1AC930
	// RVA: 0x2AED2D0 Offset: 0x2AED3D1 VA: 0x2AED2D0
	public static CoordRect ToCoordRect(Vector3 pos, float range, float cellSizeX, float cellSizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC940 Offset: 0x1ACA41 VA: 0x1AC940
	// RVA: 0x2AEDC70 Offset: 0x2AEDD71 VA: 0x2AEDC70
	public static CoordRect GetHeightRect(Terrain terrain) { }

	[ExtensionAttribute] // RVA: 0x1AC950 Offset: 0x1ACA51 VA: 0x1AC950
	// RVA: 0x2AEDDE0 Offset: 0x2AEDEE1 VA: 0x2AEDDE0
	public static CoordRect GetSplatRect(Terrain terrain) { }

	[ExtensionAttribute] // RVA: 0x1AC960 Offset: 0x1ACA61 VA: 0x1AC960
	// RVA: 0x2AF0070 Offset: 0x2AF0171 VA: 0x2AF0070
	public static float[,] SafeGetHeights(TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC970 Offset: 0x1ACA71 VA: 0x1AC970
	// RVA: 0x2AF0100 Offset: 0x2AF0201 VA: 0x2AF0100
	public static float[,,] SafeGetAlphamaps(TerrainData data, int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	[ExtensionAttribute] // RVA: 0x1AC980 Offset: 0x1ACA81 VA: 0x1AC980
	// RVA: 0x2AF10A0 Offset: 0x2AF11A1 VA: 0x2AF10A0
	public static List<Type> GetAllChildTypes(Type type) { }

	// RVA: 0x2AF1220 Offset: 0x2AF1321 VA: 0x2AF1220
	public static Texture2D ColorTexture(int width, int height, Color color) { }

	// RVA: 0x2AF1350 Offset: 0x2AF1451 VA: 0x2AF1350
	public static bool Equal(Vector3 v1, Vector3 v2) { }

	// RVA: 0x2AF1460 Offset: 0x2AF1561 VA: 0x2AF1460
	public static bool Equal(Ray r1, Ray r2) { }

	[ExtensionAttribute] // RVA: 0x1AC990 Offset: 0x1ACA91 VA: 0x1AC990
	// RVA: 0x2AF1530 Offset: 0x2AF1631 VA: 0x2AF1530
	public static void RemoveChildren(Transform tfm) { }

	[ExtensionAttribute] // RVA: 0x1AC9A0 Offset: 0x1ACAA1 VA: 0x1AC9A0
	// RVA: 0x2AF15F0 Offset: 0x2AF16F1 VA: 0x2AF15F0
	public static Transform FindChildRecursive(Transform tfm, string name) { }

	[ExtensionAttribute] // RVA: 0x1AC9B0 Offset: 0x1ACAB1 VA: 0x1AC9B0
	// RVA: 0x2AF1730 Offset: 0x2AF1831 VA: 0x2AF1730
	public static void ToggleDisplayWireframe(Transform tfm, bool show) { }

	[ExtensionAttribute] // RVA: 0x1AC9C0 Offset: 0x1ACAC1 VA: 0x1AC9C0
	// RVA: 0x2AF1740 Offset: 0x2AF1841 VA: 0x2AF1740
	public static int ToInt(Coord coord) { }

	[ExtensionAttribute] // RVA: 0x1AC9D0 Offset: 0x1ACAD1 VA: 0x1AC9D0
	// RVA: 0x2AF1780 Offset: 0x2AF1881 VA: 0x2AF1780
	public static Coord ToCoord(int hash) { }

	[ExtensionAttribute] // RVA: 0x1AC9E0 Offset: 0x1ACAE1 VA: 0x1AC9E0
	// RVA: -1 Offset: -1
	public static void CheckAdd<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, TValue value, bool replace = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0290 Offset: 0x21D0391 VA: 0x21D0290
	|-Extensions.CheckAdd<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1AC9F0 Offset: 0x1ACAF1 VA: 0x1AC9F0
	// RVA: -1 Offset: -1
	public static void CheckRemove<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D03A0 Offset: 0x21D04A1 VA: 0x21D03A0
	|-Extensions.CheckRemove<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA00 Offset: 0x1ACB01 VA: 0x1ACA00
	// RVA: -1 Offset: -1
	public static TValue CheckGet<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CAE0 Offset: 0x226CBE1 VA: 0x226CAE0
	|-Extensions.CheckGet<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA10 Offset: 0x1ACB11 VA: 0x1ACA10
	// RVA: -1 Offset: -1
	public static void CheckAdd<T>(HashSet<T> set, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0330 Offset: 0x21D0431 VA: 0x21D0330
	|-Extensions.CheckAdd<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA20 Offset: 0x1ACB21 VA: 0x1ACA20
	// RVA: -1 Offset: -1
	public static void CheckRemove<T>(HashSet<T> set, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0410 Offset: 0x21D0511 VA: 0x21D0410
	|-Extensions.CheckRemove<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA30 Offset: 0x1ACB31 VA: 0x1ACA30
	// RVA: -1 Offset: -1
	public static void SetState<T>(HashSet<T> set, T obj, bool state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0C60 Offset: 0x21D0D61 VA: 0x21D0C60
	|-Extensions.SetState<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACA40 Offset: 0x1ACB41 VA: 0x1ACA40
	// RVA: 0x2AF17F0 Offset: 0x2AF18F1 VA: 0x2AF17F0
	public static void Normalize(float[,,] array, int pinnedLayer) { }

	[ExtensionAttribute] // RVA: 0x1ACA50 Offset: 0x1ACB51 VA: 0x1ACA50
	// RVA: 0x2AF1A00 Offset: 0x2AF1B01 VA: 0x2AF1A00
	public static void DrawDebug(Vector3 pos, float range = 1, Color color) { }

	[ExtensionAttribute] // RVA: 0x1ACA60 Offset: 0x1ACB61 VA: 0x1ACA60
	// RVA: 0x2AF1ED0 Offset: 0x2AF1FD1 VA: 0x2AF1ED0
	public static void DrawDebug(Rect rect, Color color) { }

	[ExtensionAttribute] // RVA: 0x1ACA70 Offset: 0x1ACB71 VA: 0x1ACA70
	// RVA: 0x2AF22B0 Offset: 0x2AF23B1 VA: 0x2AF22B0
	public static void Resize(Terrain terrain, int resolution, Vector3 size) { }

	[ExtensionAttribute] // RVA: 0x1ACA80 Offset: 0x1ACB81 VA: 0x1ACA80
	// RVA: 0x2AF24F0 Offset: 0x2AF25F1 VA: 0x2AF24F0
	public static Transform AddChild(Transform tfm, string name = "", Vector3 offset) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACA90 Offset: 0x1ACB91 VA: 0x1ACA90
	[ExtensionAttribute] // RVA: 0x1ACA90 Offset: 0x1ACB91 VA: 0x1ACA90
	// RVA: 0x2AF25E0 Offset: 0x2AF26E1 VA: 0x2AF25E0
	public static IEnumerable<Vector3> CircleAround(Vector3 center, float radius, int numPoints, bool endWhereStart = False) { }

	[ExtensionAttribute] // RVA: 0x1ACB10 Offset: 0x1ACC11 VA: 0x1ACB10
	// RVA: 0x2AF26F0 Offset: 0x2AF27F1 VA: 0x2AF26F0
	public static float EvaluateMultithreaded(AnimationCurve curve, float time) { }

	[ExtensionAttribute] // RVA: 0x1ACB20 Offset: 0x1ACC21 VA: 0x1ACB20
	// RVA: -1 Offset: -1
	public static void GetPropertiesFrom<T1, T2>(T1 dst, T2 src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0480 Offset: 0x21D0581 VA: 0x21D0480
	|-Extensions.GetPropertiesFrom<object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1ACB30 Offset: 0x1ACC31 VA: 0x1ACB30
	[ExtensionAttribute] // RVA: 0x1ACB30 Offset: 0x1ACC31 VA: 0x1ACB30
	// RVA: 0x2AF2A90 Offset: 0x2AF2B91 VA: 0x2AF2A90
	public static IEnumerable<FieldInfo> UsableFields(Type type, bool nonPublic = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACBB0 Offset: 0x1ACCB1 VA: 0x1ACBB0
	[ExtensionAttribute] // RVA: 0x1ACBB0 Offset: 0x1ACCB1 VA: 0x1ACBB0
	// RVA: 0x2AF2B70 Offset: 0x2AF2C71 VA: 0x2AF2B70
	public static IEnumerable<PropertyInfo> UsableProperties(Type type, bool nonPublic = False, bool skipItems = True) { }

	// RVA: 0x2AF2C60 Offset: 0x2AF2D61 VA: 0x2AF2C60
	public static Component CopyComponent(Component src, GameObject go) { }

	[ExtensionAttribute] // RVA: 0x1ACC30 Offset: 0x1ACD31 VA: 0x1ACC30
	// RVA: -1 Offset: -1
	public static void ReflectionReset<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0660 Offset: 0x21D0761 VA: 0x21D0660
	|-Extensions.ReflectionReset<object>
	*/

	[ExtensionAttribute] // RVA: 0x1ACC40 Offset: 0x1ACD41 VA: 0x1ACC40
	// RVA: -1 Offset: -1
	public static T ReflectionCopy<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C0850 Offset: 0x23C0951 VA: 0x23C0850
	|-Extensions.ReflectionCopy<object>
	*/
}


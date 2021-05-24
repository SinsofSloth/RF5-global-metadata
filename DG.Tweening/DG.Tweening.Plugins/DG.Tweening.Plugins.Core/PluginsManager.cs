internal static class PluginsManager // TypeDefIndex: 5053
{
	// Fields
	private static ITweenPlugin _floatPlugin; // 0x0
	private static ITweenPlugin _doublePlugin; // 0x8
	private static ITweenPlugin _intPlugin; // 0x10
	private static ITweenPlugin _uintPlugin; // 0x18
	private static ITweenPlugin _longPlugin; // 0x20
	private static ITweenPlugin _ulongPlugin; // 0x28
	private static ITweenPlugin _vector2Plugin; // 0x30
	private static ITweenPlugin _vector3Plugin; // 0x38
	private static ITweenPlugin _vector4Plugin; // 0x40
	private static ITweenPlugin _quaternionPlugin; // 0x48
	private static ITweenPlugin _colorPlugin; // 0x50
	private static ITweenPlugin _rectPlugin; // 0x58
	private static ITweenPlugin _rectOffsetPlugin; // 0x60
	private static ITweenPlugin _stringPlugin; // 0x68
	private static ITweenPlugin _vector3ArrayPlugin; // 0x70
	private static ITweenPlugin _color2Plugin; // 0x78
	private const int _MaxCustomPlugins = 20;
	private static Dictionary<Type, ITweenPlugin> _customPlugins; // 0x80

	// Methods

	// RVA: -1 Offset: -1
	internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB8BE0 Offset: 0x1AB8CE1 VA: 0x1AB8BE0
	|-PluginsManager.GetDefaultPlugin<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB9650 Offset: 0x1AB9751 VA: 0x1AB9650
	|-PluginsManager.GetDefaultPlugin<double, double, NoOptions>
	|
	|-RVA: 0x1ABA0C0 Offset: 0x1ABA1C1 VA: 0x1ABA0C0
	|-PluginsManager.GetDefaultPlugin<int, int, NoOptions>
	|
	|-RVA: 0x1ABAB30 Offset: 0x1ABAC31 VA: 0x1ABAB30
	|-PluginsManager.GetDefaultPlugin<long, long, NoOptions>
	|
	|-RVA: 0x1B00D00 Offset: 0x1B00E01 VA: 0x1B00D00
	|-PluginsManager.GetDefaultPlugin<object, object, NoOptions>
	|
	|-RVA: 0x1B01770 Offset: 0x1B01871 VA: 0x1B01770
	|-PluginsManager.GetDefaultPlugin<object, object, StringOptions>
	|
	|-RVA: 0x1B021E0 Offset: 0x1B022E1 VA: 0x1B021E0
	|-PluginsManager.GetDefaultPlugin<float, float, FloatOptions>
	|
	|-RVA: 0x1B02C50 Offset: 0x1B02D51 VA: 0x1B02C50
	|-PluginsManager.GetDefaultPlugin<uint, uint, UintOptions>
	|
	|-RVA: 0x1B036C0 Offset: 0x1B037C1 VA: 0x1B036C0
	|-PluginsManager.GetDefaultPlugin<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1B04130 Offset: 0x1B04231 VA: 0x1B04130
	|-PluginsManager.GetDefaultPlugin<Color, Color, ColorOptions>
	|
	|-RVA: 0x1B04BA0 Offset: 0x1B04CA1 VA: 0x1B04BA0
	|-PluginsManager.GetDefaultPlugin<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1B05610 Offset: 0x1B05711 VA: 0x1B05610
	|-PluginsManager.GetDefaultPlugin<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1B06080 Offset: 0x1B06181 VA: 0x1B06080
	|-PluginsManager.GetDefaultPlugin<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1B06AF0 Offset: 0x1B06BF1 VA: 0x1B06AF0
	|-PluginsManager.GetDefaultPlugin<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1B07560 Offset: 0x1B07661 VA: 0x1B07560
	|-PluginsManager.GetDefaultPlugin<Vector3, object, PathOptions>
	|
	|-RVA: 0x1B07FD0 Offset: 0x1B080D1 VA: 0x1B07FD0
	|-PluginsManager.GetDefaultPlugin<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1B08A40 Offset: 0x1B08B41 VA: 0x1B08A40
	|-PluginsManager.GetDefaultPlugin<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1B094B0 Offset: 0x1B095B1 VA: 0x1B094B0
	|-PluginsManager.GetDefaultPlugin<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB8A70 Offset: 0x1AB8B71 VA: 0x1AB8A70
	|-PluginsManager.GetCustomPlugin<PathPlugin, Vector3, Path, PathOptions>
	|-PluginsManager.GetCustomPlugin<object, Vector3, object, PathOptions>
	*/

	// RVA: 0x1993F30 Offset: 0x1994031 VA: 0x1993F30
	internal static void PurgeAll() { }
}


[NativeHeaderAttribute] // RVA: 0xC4980 Offset: 0xC4A81 VA: 0xC4980
[UsedByNativeCodeAttribute] // RVA: 0xC4980 Offset: 0xC4A81 VA: 0xC4980
public class Display // TypeDefIndex: 2868
{
	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0xC9C90 Offset: 0xC9D91 VA: 0xC9C90
	[DebuggerBrowsableAttribute] // RVA: 0xC9C90 Offset: 0xC9D91 VA: 0xC9C90
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x10

	// Properties
	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0x2B068D0 Offset: 0x2B069D1 VA: 0x2B068D0
	internal void .ctor() { }

	// RVA: 0x2B06910 Offset: 0x2B06A11 VA: 0x2B06910
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x2B06940 Offset: 0x2B06A41 VA: 0x2B06940
	public int get_renderingWidth() { }

	// RVA: 0x2B06A60 Offset: 0x2B06B61 VA: 0x2B06A60
	public int get_renderingHeight() { }

	// RVA: 0x2B06B20 Offset: 0x2B06C21 VA: 0x2B06B20
	public int get_systemWidth() { }

	// RVA: 0x2B06C40 Offset: 0x2B06D41 VA: 0x2B06C40
	public int get_systemHeight() { }

	// RVA: 0x2B06D00 Offset: 0x2B06E01 VA: 0x2B06D00
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x2B06E50 Offset: 0x2B06F51 VA: 0x2B06E50
	public static Display get_main() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCDF10 Offset: 0xCE011 VA: 0xCDF10
	// RVA: 0x2B06EC0 Offset: 0x2B06FC1 VA: 0x2B06EC0
	private static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCDF20 Offset: 0xCE021 VA: 0xCDF20
	// RVA: 0x2B07090 Offset: 0x2B07191 VA: 0x2B07090
	private static void FireDisplaysUpdated() { }

	[FreeFunctionAttribute] // RVA: 0xCDF30 Offset: 0xCE031 VA: 0xCDF30
	// RVA: 0x2B06BE0 Offset: 0x2B06CE1 VA: 0x2B06BE0
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0xCDF70 Offset: 0xCE071 VA: 0xCDF70
	// RVA: 0x2B06A00 Offset: 0x2B06B01 VA: 0x2B06A00
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0xCDFB0 Offset: 0xCE0B1 VA: 0xCDFB0
	// RVA: 0x2B06DE0 Offset: 0x2B06EE1 VA: 0x2B06DE0
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	// RVA: 0x2B07380 Offset: 0x2B07481 VA: 0x2B07380
	private static void .cctor() { }
}


[NativeHeaderAttribute] // RVA: 0xF9880 Offset: 0xF9981 VA: 0xF9880
public class Input // TypeDefIndex: 3633
{
	// Properties
	[NativeThrowsAttribute] // RVA: 0xF9B30 Offset: 0xF9C31 VA: 0xF9B30
	public static string inputString { get; }
	[NativeThrowsAttribute] // RVA: 0xF9B40 Offset: 0xF9C41 VA: 0xF9B40
	public static Vector3 mousePosition { get; }
	[NativeThrowsAttribute] // RVA: 0xF9B50 Offset: 0xF9C51 VA: 0xF9B50
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static bool mousePresent { get; }
	public static int touchCount { get; }
	public static bool touchSupported { get; }
	public static Vector3 acceleration { get; }
	public static Touch[] touches { get; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0xF9940 Offset: 0xF9A41 VA: 0xF9940
	// RVA: 0x1BDB770 Offset: 0x1BDB871 VA: 0x1BDB770
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0xF9950 Offset: 0xF9A51 VA: 0xF9950
	// RVA: 0x1BDB7C0 Offset: 0x1BDB8C1 VA: 0x1BDB7C0
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0xF9960 Offset: 0xF9A61 VA: 0xF9960
	// RVA: 0x1BDB810 Offset: 0x1BDB911 VA: 0x1BDB810
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0xF9970 Offset: 0xF9A71 VA: 0xF9970
	// RVA: 0x1BDB860 Offset: 0x1BDB961 VA: 0x1BDB860
	private static bool GetKeyDownString(string name) { }

	[NativeThrowsAttribute] // RVA: 0xF9980 Offset: 0xF9A81 VA: 0xF9980
	// RVA: 0x1BDB8B0 Offset: 0x1BDB9B1 VA: 0x1BDB8B0
	public static float GetAxis(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0xF9990 Offset: 0xF9A91 VA: 0xF9990
	// RVA: 0x1BDB900 Offset: 0x1BDBA01 VA: 0x1BDB900
	public static float GetAxisRaw(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0xF99A0 Offset: 0xF9AA1 VA: 0xF99A0
	// RVA: 0x1BDB950 Offset: 0x1BDBA51 VA: 0x1BDB950
	public static bool GetButton(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0xF99B0 Offset: 0xF9AB1 VA: 0xF99B0
	// RVA: 0x1BDB9A0 Offset: 0x1BDBAA1 VA: 0x1BDB9A0
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0xF99C0 Offset: 0xF9AC1 VA: 0xF99C0
	// RVA: 0x1BDB9F0 Offset: 0x1BDBAF1 VA: 0x1BDB9F0
	public static bool GetButtonUp(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0xF99D0 Offset: 0xF9AD1 VA: 0xF99D0
	// RVA: 0x1BDBA40 Offset: 0x1BDBB41 VA: 0x1BDBA40
	public static bool GetMouseButton(int button) { }

	[NativeThrowsAttribute] // RVA: 0xF99E0 Offset: 0xF9AE1 VA: 0xF99E0
	// RVA: 0x1BDBA90 Offset: 0x1BDBB91 VA: 0x1BDBA90
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrowsAttribute] // RVA: 0xF99F0 Offset: 0xF9AF1 VA: 0xF99F0
	// RVA: 0x1BDBAE0 Offset: 0x1BDBBE1 VA: 0x1BDBAE0
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrowsAttribute] // RVA: 0xF9A00 Offset: 0xF9B01 VA: 0xF9A00
	// RVA: 0x1BDBB30 Offset: 0x1BDBC31 VA: 0x1BDBB30
	public static Touch GetTouch(int index) { }

	// RVA: 0x1BDBC20 Offset: 0x1BDBD21 VA: 0x1BDBC20
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x1BDBC70 Offset: 0x1BDBD71 VA: 0x1BDBC70
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x1BDBCC0 Offset: 0x1BDBDC1 VA: 0x1BDBCC0
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x1BDBD10 Offset: 0x1BDBE11 VA: 0x1BDBD10
	public static bool GetKeyDown(string name) { }

	// RVA: 0x1BDBD60 Offset: 0x1BDBE61 VA: 0x1BDBD60
	public static string get_inputString() { }

	// RVA: 0x1BDBDA0 Offset: 0x1BDBEA1 VA: 0x1BDBDA0
	public static Vector3 get_mousePosition() { }

	// RVA: 0x1BDBE50 Offset: 0x1BDBF51 VA: 0x1BDBE50
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x1BDBEF0 Offset: 0x1BDBFF1 VA: 0x1BDBEF0
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x1BDBF30 Offset: 0x1BDC031 VA: 0x1BDBF30
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1BDBF80 Offset: 0x1BDC081 VA: 0x1BDBF80
	public static string get_compositionString() { }

	// RVA: 0x1BDBFC0 Offset: 0x1BDC0C1 VA: 0x1BDBFC0
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x1BDC060 Offset: 0x1BDC161 VA: 0x1BDC060
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xF9A10 Offset: 0xF9B11 VA: 0xF9A10
	// RVA: 0x1BDC100 Offset: 0x1BDC201 VA: 0x1BDC100
	public static bool get_mousePresent() { }

	[FreeFunctionAttribute] // RVA: 0xF9A50 Offset: 0xF9B51 VA: 0xF9A50
	// RVA: 0x1BDC140 Offset: 0x1BDC241 VA: 0x1BDC140
	public static int get_touchCount() { }

	[FreeFunctionAttribute] // RVA: 0xF9A90 Offset: 0xF9B91 VA: 0xF9A90
	// RVA: 0x1BDC180 Offset: 0x1BDC281 VA: 0x1BDC180
	public static bool get_touchSupported() { }

	[FreeFunctionAttribute] // RVA: 0xF9AD0 Offset: 0xF9BD1 VA: 0xF9AD0
	// RVA: 0x1BDC1C0 Offset: 0x1BDC2C1 VA: 0x1BDC1C0
	public static Vector3 get_acceleration() { }

	// RVA: 0x1BDC270 Offset: 0x1BDC371 VA: 0x1BDC270
	public static Touch[] get_touches() { }

	// RVA: 0x1BDBBD0 Offset: 0x1BDBCD1 VA: 0x1BDBBD0
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x1BDBE00 Offset: 0x1BDBF01 VA: 0x1BDBE00
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x1BDBEA0 Offset: 0x1BDBFA1 VA: 0x1BDBEA0
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x1BDC010 Offset: 0x1BDC111 VA: 0x1BDC010
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x1BDC0B0 Offset: 0x1BDC1B1 VA: 0x1BDC0B0
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	// RVA: 0x1BDC220 Offset: 0x1BDC321 VA: 0x1BDC220
	private static void get_acceleration_Injected(out Vector3 ret) { }
}


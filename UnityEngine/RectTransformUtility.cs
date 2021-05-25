[NativeHeaderAttribute] // RVA: 0x1030F0 Offset: 0x1031F1 VA: 0x1030F0
[NativeHeaderAttribute] // RVA: 0x1030F0 Offset: 0x1031F1 VA: 0x1030F0
[NativeHeaderAttribute] // RVA: 0x1030F0 Offset: 0x1031F1 VA: 0x1030F0
[StaticAccessorAttribute] // RVA: 0x1030F0 Offset: 0x1031F1 VA: 0x1030F0
[NativeHeaderAttribute] // RVA: 0x1030F0 Offset: 0x1031F1 VA: 0x1030F0
public sealed class RectTransformUtility // TypeDefIndex: 3696
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x1BC1C10 Offset: 0x1BC1D11 VA: 0x1BC1C10
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x1BC1D50 Offset: 0x1BC1E51 VA: 0x1BC1D50
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x1BC1E70 Offset: 0x1BC1F71 VA: 0x1BC1E70
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x1BC1FB0 Offset: 0x1BC20B1 VA: 0x1BC1FB0
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x1BC20A0 Offset: 0x1BC21A1 VA: 0x1BC20A0
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x1BC21E0 Offset: 0x1BC22E1 VA: 0x1BC21E0
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x1BC25B0 Offset: 0x1BC26B1 VA: 0x1BC25B0
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x1BC2410 Offset: 0x1BC2511 VA: 0x1BC2410
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x1BC2700 Offset: 0x1BC2801 VA: 0x1BC2700
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x1BC2810 Offset: 0x1BC2911 VA: 0x1BC2810
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x1BC2AC0 Offset: 0x1BC2BC1 VA: 0x1BC2AC0
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x1BC2DA0 Offset: 0x1BC2EA1 VA: 0x1BC2DA0
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x1BC2DE0 Offset: 0x1BC2EE1 VA: 0x1BC2DE0
	private static void .cctor() { }

	// RVA: 0x1BC1CE0 Offset: 0x1BC1DE1 VA: 0x1BC1CE0
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x1BC1E10 Offset: 0x1BC1F11 VA: 0x1BC1E10
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x1BC1F40 Offset: 0x1BC2041 VA: 0x1BC1F40
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset) { }
}


[NativeHeaderAttribute] // RVA: 0xF4910 Offset: 0xF4A11 VA: 0xF4910
[VisibleToOtherModulesAttribute] // RVA: 0xF4910 Offset: 0xF4A11 VA: 0xF4910
[NativeHeaderAttribute] // RVA: 0xF4910 Offset: 0xF4A11 VA: 0xF4910
internal sealed class GUIClip // TypeDefIndex: 3591
{
	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xF6480 Offset: 0xF6581 VA: 0xF6480
	// RVA: 0x2D09F60 Offset: 0x2D0A061 VA: 0x2D09F60
	internal static Rect get_visibleRect() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF64C0 Offset: 0xF65C1 VA: 0xF64C0
	// RVA: 0x2D0F700 Offset: 0x2D0F801 VA: 0x2D0F700
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF6550 Offset: 0xF6651 VA: 0xF6550
	// RVA: 0x2D0C780 Offset: 0x2D0C881 VA: 0x2D0C780
	internal static void Internal_Pop() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF65E0 Offset: 0xF66E1 VA: 0xF65E0
	[FreeFunctionAttribute] // RVA: 0xF65E0 Offset: 0xF66E1 VA: 0xF65E0
	// RVA: 0x2D0F7E0 Offset: 0x2D0F8E1 VA: 0x2D0F7E0
	internal static int Internal_GetCount() { }

	[FreeFunctionAttribute] // RVA: 0xF6690 Offset: 0xF6791 VA: 0xF6690
	// RVA: 0x2D0F820 Offset: 0x2D0F921 VA: 0x2D0F820
	private static Vector2 ClipToWindow_Vector2(Vector2 absolutePos) { }

	[FreeFunctionAttribute] // RVA: 0xF66D0 Offset: 0xF67D1 VA: 0xF66D0
	[VisibleToOtherModulesAttribute] // RVA: 0xF66D0 Offset: 0xF67D1 VA: 0xF66D0
	// RVA: 0x2D03EB0 Offset: 0x2D03FB1 VA: 0x2D03EB0
	internal static Matrix4x4 GetMatrix() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF6780 Offset: 0xF6881 VA: 0xF6780
	// RVA: 0x2D03FA0 Offset: 0x2D040A1 VA: 0x2D03FA0
	internal static void SetMatrix(Matrix4x4 m) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF6810 Offset: 0xF6911 VA: 0xF6810
	// RVA: 0x2D0F970 Offset: 0x2D0FA71 VA: 0x2D0F970
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF68A0 Offset: 0xF69A1 VA: 0xF68A0
	// RVA: 0x2D0FA20 Offset: 0x2D0FB21 VA: 0x2D0FA20
	internal static void Internal_PopParentClip() { }

	// RVA: 0x2D0C6C0 Offset: 0x2D0C7C1 VA: 0x2D0C6C0
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x2D0E2D0 Offset: 0x2D0E3D1 VA: 0x2D0E2D0
	internal static void Pop() { }

	// RVA: 0x2D0FA60 Offset: 0x2D0FB61 VA: 0x2D0FA60
	public static Vector2 ClipToWindow(Vector2 absolutePos) { }

	// RVA: 0x2D0F6B0 Offset: 0x2D0F7B1 VA: 0x2D0F6B0
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x2D0F770 Offset: 0x2D0F871 VA: 0x2D0F770
	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x2D0F880 Offset: 0x2D0F981 VA: 0x2D0F880
	private static void ClipToWindow_Vector2_Injected(ref Vector2 absolutePos, out Vector2 ret) { }

	// RVA: 0x2D0F8D0 Offset: 0x2D0F9D1 VA: 0x2D0F8D0
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2D0F920 Offset: 0x2D0FA21 VA: 0x2D0F920
	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x2D0F9D0 Offset: 0x2D0FAD1 VA: 0x2D0F9D0
	private static void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect) { }
}


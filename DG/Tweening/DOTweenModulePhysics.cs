[ExtensionAttribute] // RVA: 0x157370 Offset: 0x157471 VA: 0x157370
public static class DOTweenModulePhysics // TypeDefIndex: 11732
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1B0060 Offset: 0x1B0161 VA: 0x1B0060
	// RVA: 0x1C9C0F0 Offset: 0x1C9C1F1 VA: 0x1C9C0F0
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(Rigidbody target, Vector3 endValue, float duration, bool snapping = False) { }

	[ExtensionAttribute] // RVA: 0x1B0070 Offset: 0x1B0171 VA: 0x1B0070
	// RVA: 0x1C9C280 Offset: 0x1C9C381 VA: 0x1C9C280
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(Rigidbody target, float endValue, float duration, bool snapping = False) { }

	[ExtensionAttribute] // RVA: 0x1B0080 Offset: 0x1B0181 VA: 0x1B0080
	// RVA: 0x1C9C430 Offset: 0x1C9C531 VA: 0x1C9C430
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(Rigidbody target, float endValue, float duration, bool snapping = False) { }

	[ExtensionAttribute] // RVA: 0x1B0090 Offset: 0x1B0191 VA: 0x1B0090
	// RVA: 0x1C9C5E0 Offset: 0x1C9C6E1 VA: 0x1C9C5E0
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(Rigidbody target, float endValue, float duration, bool snapping = False) { }

	[ExtensionAttribute] // RVA: 0x1B00A0 Offset: 0x1B01A1 VA: 0x1B00A0
	// RVA: 0x1C9C790 Offset: 0x1C9C891 VA: 0x1C9C790
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(Rigidbody target, Vector3 endValue, float duration, RotateMode mode = 0) { }

	[ExtensionAttribute] // RVA: 0x1B00B0 Offset: 0x1B01B1 VA: 0x1B00B0
	// RVA: 0x1C9C920 Offset: 0x1C9CA21 VA: 0x1C9C920
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = 0, Nullable<Vector3> up) { }

	[ExtensionAttribute] // RVA: 0x1B00C0 Offset: 0x1B01C1 VA: 0x1B00C0
	// RVA: 0x1C9CB30 Offset: 0x1C9CC31 VA: 0x1C9CB30
	public static Sequence DOJump(Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = False) { }

	[ExtensionAttribute] // RVA: 0x1B00D0 Offset: 0x1B01D1 VA: 0x1B00D0
	// RVA: 0x1C9CFF0 Offset: 0x1C9D0F1 VA: 0x1C9CFF0
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(Rigidbody target, Vector3[] path, float duration, PathType pathType = 0, PathMode pathMode = 1, int resolution = 10, Nullable<Color> gizmoColor) { }

	[ExtensionAttribute] // RVA: 0x1B00E0 Offset: 0x1B01E1 VA: 0x1B00E0
	// RVA: 0x1C9D200 Offset: 0x1C9D301 VA: 0x1C9D200
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(Rigidbody target, Vector3[] path, float duration, PathType pathType = 0, PathMode pathMode = 1, int resolution = 10, Nullable<Color> gizmoColor) { }

	[ExtensionAttribute] // RVA: 0x1B00F0 Offset: 0x1B01F1 VA: 0x1B00F0
	// RVA: 0x1C9D430 Offset: 0x1C9D531 VA: 0x1C9D430
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(Rigidbody target, Path path, float duration, PathMode pathMode = 1) { }

	[ExtensionAttribute] // RVA: 0x1B0100 Offset: 0x1B0201 VA: 0x1B0100
	// RVA: 0x1C9D5D0 Offset: 0x1C9D6D1 VA: 0x1C9D5D0
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(Rigidbody target, Path path, float duration, PathMode pathMode = 1) { }
}


[ExtensionAttribute] // RVA: 0x157380 Offset: 0x157481 VA: 0x157380
public static class DOTweenModulePhysics2D // TypeDefIndex: 11744
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1B0110 Offset: 0x1B0211 VA: 0x1B0110
	// RVA: 0x1C9DC30 Offset: 0x1C9DD31 VA: 0x1C9DC30
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(Rigidbody2D target, Vector2 endValue, float duration, bool snapping = False) { }

	[ExtensionAttribute] // RVA: 0x1B0120 Offset: 0x1B0221 VA: 0x1B0120
	// RVA: 0x1C9DDC0 Offset: 0x1C9DEC1 VA: 0x1C9DDC0
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(Rigidbody2D target, float endValue, float duration, bool snapping = False) { }

	[ExtensionAttribute] // RVA: 0x1B0130 Offset: 0x1B0231 VA: 0x1B0130
	// RVA: 0x1C9DF60 Offset: 0x1C9E061 VA: 0x1C9DF60
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(Rigidbody2D target, float endValue, float duration, bool snapping = False) { }

	[ExtensionAttribute] // RVA: 0x1B0140 Offset: 0x1B0241 VA: 0x1B0140
	// RVA: 0x1C9E100 Offset: 0x1C9E201 VA: 0x1C9E100
	public static TweenerCore<float, float, FloatOptions> DORotate(Rigidbody2D target, float endValue, float duration) { }

	[ExtensionAttribute] // RVA: 0x1B0150 Offset: 0x1B0251 VA: 0x1B0150
	// RVA: 0x1C9E260 Offset: 0x1C9E361 VA: 0x1C9E260
	public static Sequence DOJump(Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = False) { }
}


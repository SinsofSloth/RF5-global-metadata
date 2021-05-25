[NativeHeaderAttribute] // RVA: 0xFB080 Offset: 0xFB181 VA: 0xFB080
[RequireComponent] // RVA: 0xFB080 Offset: 0xFB181 VA: 0xFB080
[RequiredByNativeCodeAttribute] // RVA: 0xFB080 Offset: 0xFB181 VA: 0xFB080
public class Collider2D : Behaviour // TypeDefIndex: 3646
{
	// Properties
	public Vector2 offset { get; set; }
	public Rigidbody2D attachedRigidbody { get; }

	// Methods

	// RVA: 0x1BC32A0 Offset: 0x1BC33A1 VA: 0x1BC32A0
	public Vector2 get_offset() { }

	// RVA: 0x1BC3350 Offset: 0x1BC3451 VA: 0x1BC3350
	public void set_offset(Vector2 value) { }

	[NativeMethodAttribute] // RVA: 0xFBE80 Offset: 0xFBF81 VA: 0xFBE80
	// RVA: 0x1BC3400 Offset: 0x1BC3501 VA: 0x1BC3400
	public Rigidbody2D get_attachedRigidbody() { }

	// RVA: 0x1BC3450 Offset: 0x1BC3551 VA: 0x1BC3450
	public bool OverlapPoint(Vector2 point) { }

	// RVA: 0x1BC31F0 Offset: 0x1BC32F1 VA: 0x1BC31F0
	public void .ctor() { }

	// RVA: 0x1BC3300 Offset: 0x1BC3401 VA: 0x1BC3300
	private void get_offset_Injected(out Vector2 ret) { }

	// RVA: 0x1BC33B0 Offset: 0x1BC34B1 VA: 0x1BC33B0
	private void set_offset_Injected(ref Vector2 value) { }

	// RVA: 0x1BC34B0 Offset: 0x1BC35B1 VA: 0x1BC34B0
	private bool OverlapPoint_Injected(ref Vector2 point) { }
}


[RequireComponent] // RVA: 0xFB1F0 Offset: 0xFB2F1 VA: 0xFB1F0
[NativeHeaderAttribute] // RVA: 0xFB1F0 Offset: 0xFB2F1 VA: 0xFB1F0
public sealed class CompositeCollider2D : Collider2D // TypeDefIndex: 3650
{
	// Properties
	public int pathCount { get; }
	public int pointCount { get; }

	// Methods

	// RVA: 0x1BC3890 Offset: 0x1BC3991 VA: 0x1BC3890
	public int get_pathCount() { }

	// RVA: 0x1BC38E0 Offset: 0x1BC39E1 VA: 0x1BC38E0
	public int get_pointCount() { }

	// RVA: 0x1BC3930 Offset: 0x1BC3A31 VA: 0x1BC3930
	public int GetPath(int index, Vector2[] points) { }

	[NativeMethodAttribute] // RVA: 0xFBF40 Offset: 0xFC041 VA: 0xFBF40
	// RVA: 0x1BC3AC0 Offset: 0x1BC3BC1 VA: 0x1BC3AC0
	private int GetPathArray_Internal(int index, Vector2[] points) { }
}


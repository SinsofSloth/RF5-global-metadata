public interface ICinemachineTargetGroup // TypeDefIndex: 4772
{
	// Properties
	public abstract Transform Transform { get; }
	public abstract Bounds BoundingBox { get; }
	public abstract BoundingSphere Sphere { get; }
	public abstract bool IsEmpty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Transform get_Transform() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Bounds get_BoundingBox() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract BoundingSphere get_Sphere() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsEmpty() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Bounds GetViewSpaceBoundingBox(Matrix4x4 observer) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange) { }
}


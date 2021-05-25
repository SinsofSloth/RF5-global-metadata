public interface IPlayerCamera // TypeDefIndex: 6499
{
	// Properties
	public abstract float DistanceOffset { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PreUpdate() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void FrameUpdate() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void TimeStepUpdate() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CameraReset(Nullable<Quaternion> resetRotation) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_DistanceOffset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_DistanceOffset(float value) { }
}


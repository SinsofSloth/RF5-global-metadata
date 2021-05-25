public interface IMarker // TypeDefIndex: 4586
{
	// Properties
	public abstract double time { get; set; }
	public abstract TrackAsset parent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract double get_time() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_time(double value) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TrackAsset get_parent() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Initialize(TrackAsset parent) { }
}


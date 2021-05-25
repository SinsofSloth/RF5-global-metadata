public interface IKeyframeGroup // TypeDefIndex: 9640
{
	// Properties
	public abstract string name { get; set; }
	public abstract string id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_name() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_name(string value) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_id() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SortKeyframes() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void TrimToSingleKeyframe() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RemoveKeyFrame(IBaseKeyframe keyframe) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int GetKeyFrameCount() { }
}


internal interface ICurvesOwner // TypeDefIndex: 4545
{
	// Properties
	public abstract AnimationClip curves { get; }
	public abstract bool hasCurves { get; }
	public abstract double duration { get; }
	public abstract string defaultCurvesName { get; }
	public abstract Object asset { get; }
	public abstract Object assetOwner { get; }
	public abstract TrackAsset targetTrack { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AnimationClip get_curves() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_hasCurves() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract double get_duration() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CreateCurves(string curvesClipName) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_defaultCurvesName() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Object get_asset() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Object get_assetOwner() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract TrackAsset get_targetTrack() { }
}


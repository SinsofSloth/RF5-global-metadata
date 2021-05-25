[AssetFileNameExtensionAttribute] // RVA: 0xC8BA0 Offset: 0xC8CA1 VA: 0xC8BA0
[RequiredByNativeCodeAttribute] // RVA: 0xC8BA0 Offset: 0xC8CA1 VA: 0xC8BA0
[Serializable]
public abstract class PlayableAsset : ScriptableObject, IPlayableAsset // TypeDefIndex: 3347
{
	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x2B6D3F0 Offset: 0x2B6D4F1 VA: 0x2B6D3F0 Slot: 7
	public virtual double get_duration() { }

	// RVA: 0x2B6D460 Offset: 0x2B6D561 VA: 0x2B6D460 Slot: 8
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9C80 Offset: 0xD9D81 VA: 0xD9C80
	// RVA: 0x2B6D4D0 Offset: 0x2B6D5D1 VA: 0x2B6D4D0
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9C90 Offset: 0xD9D91 VA: 0xD9C90
	// RVA: 0x2B6D6E0 Offset: 0x2B6D7E1 VA: 0x2B6D6E0
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x2B6D720 Offset: 0x2B6D821 VA: 0x2B6D720
	protected void .ctor() { }
}


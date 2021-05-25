[Serializable]
public class VideoScriptPlayableAsset : PlayableAsset // TypeDefIndex: 11810
{
	// Fields
	public ExposedReference<VideoPlayer> videoPlayer; // 0x18
	[SerializeField] // RVA: 0x195300 Offset: 0x195401 VA: 0x195300
	[NotKeyableAttribute] // RVA: 0x195300 Offset: 0x195401 VA: 0x195300
	public VideoClip videoClip; // 0x28
	[SerializeField] // RVA: 0x195340 Offset: 0x195441 VA: 0x195340
	[NotKeyableAttribute] // RVA: 0x195340 Offset: 0x195441 VA: 0x195340
	public bool mute; // 0x30
	[SerializeField] // RVA: 0x195380 Offset: 0x195481 VA: 0x195380
	[NotKeyableAttribute] // RVA: 0x195380 Offset: 0x195481 VA: 0x195380
	public bool loop; // 0x31
	[SerializeField] // RVA: 0x1953C0 Offset: 0x1954C1 VA: 0x1953C0
	[NotKeyableAttribute] // RVA: 0x1953C0 Offset: 0x1954C1 VA: 0x1953C0
	public double preloadTime; // 0x38
	[SerializeField] // RVA: 0x195400 Offset: 0x195501 VA: 0x195400
	[NotKeyableAttribute] // RVA: 0x195400 Offset: 0x195501 VA: 0x195400
	public double clipInTime; // 0x40

	// Methods

	// RVA: 0x1CFC4D0 Offset: 0x1CFC5D1 VA: 0x1CFC4D0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x1CFC610 Offset: 0x1CFC711 VA: 0x1CFC610
	public void .ctor() { }
}


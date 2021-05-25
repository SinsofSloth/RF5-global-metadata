[ExecuteInEditMode] // RVA: 0x145220 Offset: 0x145321 VA: 0x145220
public class ActorImporter : MonoBehaviour // TypeDefIndex: 6303
{
	// Fields
	[SerializeField] // RVA: 0x15BFF0 Offset: 0x15C0F1 VA: 0x15BFF0
	private PlayableDirector playableDirector; // 0x18
	[SerializeField] // RVA: 0x15C000 Offset: 0x15C101 VA: 0x15C000
	private ActorID actorID; // 0x20
	[SerializeField] // RVA: 0x15C010 Offset: 0x15C111 VA: 0x15C010
	private CharID charID; // 0x24
	[SerializeField] // RVA: 0x15C020 Offset: 0x15C121 VA: 0x15C020
	private Transform BaseTransform; // 0x28
	[SerializeField] // RVA: 0x15C030 Offset: 0x15C131 VA: 0x15C030
	private ReplaceData[] replaceDatas; // 0x30
	private List<TimelineClip> animationPlayables; // 0x38
	private List<TimelineClip> changeAvatorClips; // 0x40
	private List<TimelineClip> dialogueClips; // 0x48
	private List<TimelineClip> rfAudioClips; // 0x50
	private Dictionary<ActorID, CharID> otherActors; // 0x58
	private Actor actor_; // 0x60
	private bool actorDispOn_; // 0x68
	private ActorType actorType_; // 0x6C
	private HumanModel humanModel_; // 0x70
	private bool IsInit; // 0x78

	// Properties
	public ActorID ActorID { get; set; }
	public CharID CharID { get; set; }
	private Transform ParentBase { get; }

	// Methods

	// RVA: 0x1BE9C00 Offset: 0x1BE9D01 VA: 0x1BE9C00
	public ActorID get_ActorID() { }

	// RVA: 0x1BE9C10 Offset: 0x1BE9D11 VA: 0x1BE9C10
	public void set_ActorID(ActorID value) { }

	// RVA: 0x1BE9C20 Offset: 0x1BE9D21 VA: 0x1BE9C20
	public CharID get_CharID() { }

	// RVA: 0x1BE9C30 Offset: 0x1BE9D31 VA: 0x1BE9C30
	public void set_CharID(CharID value) { }

	// RVA: 0x1BE9C40 Offset: 0x1BE9D41 VA: 0x1BE9C40
	private Transform get_ParentBase() { }

	// RVA: 0x1BE9CD0 Offset: 0x1BE9DD1 VA: 0x1BE9CD0
	private void Awake() { }

	// RVA: 0x1BE9E80 Offset: 0x1BE9F81 VA: 0x1BE9E80
	private void OnDestroy() { }

	// RVA: 0x1BE9EE0 Offset: 0x1BE9FE1 VA: 0x1BE9EE0
	private void OnEnable() { }

	// RVA: 0x1BE9CE0 Offset: 0x1BE9DE1 VA: 0x1BE9CE0
	public void OnInit() { }

	// RVA: 0x1BE9EB0 Offset: 0x1BE9FB1 VA: 0x1BE9EB0
	public void OnEnd() { }

	// RVA: 0x1BE9EF0 Offset: 0x1BE9FF1 VA: 0x1BE9EF0
	private void TakeActor() { }

	// RVA: 0x1BEB6B0 Offset: 0x1BEB7B1 VA: 0x1BEB6B0
	private void ReturnActor() { }

	// RVA: 0x1BEA2B0 Offset: 0x1BEA3B1 VA: 0x1BEA2B0
	private void GetAnimationPlayableAsset() { }

	// RVA: 0x1BEA8B0 Offset: 0x1BEA9B1 VA: 0x1BEA8B0
	private void ResetElementsReplaceDatas() { }

	// RVA: 0x1BEB7A0 Offset: 0x1BEB8A1 VA: 0x1BEB7A0
	private void GetAnimationTrack(TrackAsset track) { }

	// RVA: 0x1BEBD40 Offset: 0x1BEBE41 VA: 0x1BEBD40
	private void GetChangeAvatorTrack(TrackAsset track) { }

	// RVA: 0x1BEC1D0 Offset: 0x1BEC2D1 VA: 0x1BEC1D0
	private void GetDialogueTrack(TrackAsset track) { }

	// RVA: 0x1BEC660 Offset: 0x1BEC761 VA: 0x1BEC660
	private void GetRfAudioTrack(TrackAsset track) { }

	// RVA: 0x1BECAF0 Offset: 0x1BECBF1 VA: 0x1BECAF0
	private void GetHumanEquipTrack(TrackAsset track) { }

	// RVA: 0x1BEA9D0 Offset: 0x1BEAAD1 VA: 0x1BEA9D0
	private void Replace(ReplaceData replaceData) { }

	// RVA: 0x1BED660 Offset: 0x1BED761 VA: 0x1BED660
	public void .ctor() { }
}


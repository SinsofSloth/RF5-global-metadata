[DefaultMemberAttribute] // RVA: 0x141170 Offset: 0x141271 VA: 0x141170
[RequireComponent] // RVA: 0x141170 Offset: 0x141271 VA: 0x141170
[RequireComponent] // RVA: 0x141170 Offset: 0x141271 VA: 0x141170
public class SimpleAnimation : MonoBehaviour, IAnimationClipSource // TypeDefIndex: 5923
{
	// Fields
	private const string kDefaultStateName = "Default";
	protected PlayableGraph m_Graph; // 0x18
	protected PlayableHandle m_LayerMixer; // 0x28
	protected PlayableHandle m_TransitionMixer; // 0x38
	protected Animator m_Animator; // 0x48
	protected bool m_Initialized; // 0x50
	protected bool m_IsPlaying; // 0x51
	protected SimpleAnimationPlayable m_Playable; // 0x58
	[SerializeField] // RVA: 0x141280 Offset: 0x141381 VA: 0x141280
	protected bool m_PlayAutomatically; // 0x60
	[SerializeField] // RVA: 0x141290 Offset: 0x141391 VA: 0x141290
	protected bool m_AnimatePhysics; // 0x61
	[SerializeField] // RVA: 0x1412A0 Offset: 0x1413A1 VA: 0x1412A0
	protected AnimatorCullingMode m_CullingMode; // 0x64
	[SerializeField] // RVA: 0x1412B0 Offset: 0x1413B1 VA: 0x1412B0
	protected WrapMode m_WrapMode; // 0x68
	[SerializeField] // RVA: 0x1412C0 Offset: 0x1413C1 VA: 0x1412C0
	protected AnimationClip m_Clip; // 0x70
	[SerializeField] // RVA: 0x1412D0 Offset: 0x1413D1 VA: 0x1412D0
	private SimpleAnimation.EditorState[] m_States; // 0x78

	// Properties
	public Animator animator { get; }
	public bool animatePhysics { get; set; }
	public AnimatorCullingMode cullingMode { get; set; }
	public bool isPlaying { get; }
	public bool playAutomatically { get; set; }
	public AnimationClip clip { get; set; }
	public WrapMode wrapMode { get; set; }
	public SimpleAnimation.State Item { get; }

	// Methods

	// RVA: 0x1B85B50 Offset: 0x1B85C51 VA: 0x1B85B50
	public Animator get_animator() { }

	// RVA: 0x1B85C00 Offset: 0x1B85D01 VA: 0x1B85C00
	public bool get_animatePhysics() { }

	// RVA: 0x1B85C10 Offset: 0x1B85D11 VA: 0x1B85C10
	public void set_animatePhysics(bool value) { }

	// RVA: 0x1B85CE0 Offset: 0x1B85DE1 VA: 0x1B85CE0
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x1B85DA0 Offset: 0x1B85EA1 VA: 0x1B85DA0
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x1B85E60 Offset: 0x1B85F61 VA: 0x1B85E60
	public bool get_isPlaying() { }

	// RVA: 0x1B85EB0 Offset: 0x1B85FB1 VA: 0x1B85EB0
	public bool get_playAutomatically() { }

	// RVA: 0x1B85EC0 Offset: 0x1B85FC1 VA: 0x1B85EC0
	public void set_playAutomatically(bool value) { }

	// RVA: 0x1B85ED0 Offset: 0x1B85FD1 VA: 0x1B85ED0
	public AnimationClip get_clip() { }

	// RVA: 0x1B85EE0 Offset: 0x1B85FE1 VA: 0x1B85EE0
	public void set_clip(AnimationClip value) { }

	// RVA: 0x1B86010 Offset: 0x1B86111 VA: 0x1B86010
	public WrapMode get_wrapMode() { }

	// RVA: 0x1B86020 Offset: 0x1B86121 VA: 0x1B86020
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x1B86030 Offset: 0x1B86131 VA: 0x1B86030
	public void AddClip(AnimationClip clip, string newName) { }

	// RVA: 0x1B86140 Offset: 0x1B86241 VA: 0x1B86140
	public void Blend(string stateName, float targetWeight, float fadeLength) { }

	// RVA: 0x1B862E0 Offset: 0x1B863E1 VA: 0x1B862E0
	public void CrossFade(string stateName, float fadeLength) { }

	// RVA: 0x1B86450 Offset: 0x1B86551 VA: 0x1B86450
	public void CrossFadeQueued(string stateName, float fadeLength, QueueMode queueMode) { }

	// RVA: 0x1B865B0 Offset: 0x1B866B1 VA: 0x1B865B0
	public int GetClipCount() { }

	// RVA: 0x1B86730 Offset: 0x1B86831 VA: 0x1B86730
	public bool IsPlaying(string stateName) { }

	// RVA: 0x1B867E0 Offset: 0x1B868E1 VA: 0x1B867E0
	public void Stop() { }

	// RVA: 0x1B86900 Offset: 0x1B86A01 VA: 0x1B86900
	public void Stop(string stateName) { }

	// RVA: 0x1B86A00 Offset: 0x1B86B01 VA: 0x1B86A00
	public void Sample() { }

	// RVA: 0x1B86A10 Offset: 0x1B86B11 VA: 0x1B86A10
	public bool Play() { }

	// RVA: 0x1B860C0 Offset: 0x1B861C1 VA: 0x1B860C0
	public void AddState(AnimationClip clip, string name) { }

	// RVA: 0x1B87150 Offset: 0x1B87251 VA: 0x1B87150
	public void RemoveState(string name) { }

	// RVA: 0x1B87280 Offset: 0x1B87381 VA: 0x1B87280
	public bool Play(string stateName) { }

	// RVA: 0x1B872F0 Offset: 0x1B873F1 VA: 0x1B872F0
	public void PlayQueued(string stateName, QueueMode queueMode) { }

	// RVA: 0x1B87440 Offset: 0x1B87541 VA: 0x1B87440
	public void RemoveClip(AnimationClip clip) { }

	// RVA: 0x1B87570 Offset: 0x1B87671 VA: 0x1B87570
	public void Rewind() { }

	// RVA: 0x1B876E0 Offset: 0x1B877E1 VA: 0x1B876E0
	public void Rewind(string stateName) { }

	// RVA: 0x1B877F0 Offset: 0x1B878F1 VA: 0x1B877F0
	public SimpleAnimation.State GetState(string stateName) { }

	// RVA: 0x1B879B0 Offset: 0x1B87AB1 VA: 0x1B879B0
	public IEnumerable<SimpleAnimation.State> GetStates() { }

	// RVA: 0x1B87A60 Offset: 0x1B87B61 VA: 0x1B87A60
	public SimpleAnimation.State get_Item(string name) { }

	// RVA: 0x1B861C0 Offset: 0x1B862C1 VA: 0x1B861C0
	protected void Kick() { }

	// RVA: 0x1B87A70 Offset: 0x1B87B71 VA: 0x1B87A70 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x1B87E70 Offset: 0x1B87F71 VA: 0x1B87E70 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x1B87EB0 Offset: 0x1B87FB1 VA: 0x1B87EB0
	private void Reset() { }

	// RVA: 0x1B87AC0 Offset: 0x1B87BC1 VA: 0x1B87AC0
	private void Initialize() { }

	// RVA: 0x1B88010 Offset: 0x1B88111 VA: 0x1B88010
	private void EnsureDefaultStateExists() { }

	// RVA: 0x1B88100 Offset: 0x1B88201 VA: 0x1B88100 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0x1B88110 Offset: 0x1B88211 VA: 0x1B88110
	protected void OnDestroy() { }

	// RVA: 0x1B88150 Offset: 0x1B88251 VA: 0x1B88150
	private void OnPlayableDone() { }

	// RVA: 0x1B86CA0 Offset: 0x1B86DA1 VA: 0x1B86CA0
	private void RebuildStates() { }

	// RVA: 0x1B88180 Offset: 0x1B88281 VA: 0x1B88180
	private SimpleAnimation.EditorState CreateDefaultEditorState() { }

	// RVA: 0x1B85F20 Offset: 0x1B86021 VA: 0x1B85F20
	private static void LegacyClipCheck(AnimationClip clip) { }

	// RVA: 0x1B88230 Offset: 0x1B88331 VA: 0x1B88230
	private void InvalidLegacyClipError(string clipName, string stateName) { }

	// RVA: 0x1B88370 Offset: 0x1B88471 VA: 0x1B88370
	private void OnValidate() { }

	// RVA: 0x1B88AA0 Offset: 0x1B88BA1 VA: 0x1B88AA0 Slot: 7
	public void GetAnimationClips(List<AnimationClip> results) { }

	// RVA: 0x1B88C10 Offset: 0x1B88D11 VA: 0x1B88C10
	public void .ctor() { }
}


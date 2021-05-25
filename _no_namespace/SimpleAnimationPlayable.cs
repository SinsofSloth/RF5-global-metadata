public class SimpleAnimationPlayable : PlayableBehaviour // TypeDefIndex: 5929
{
	// Fields
	private LinkedList<SimpleAnimationPlayable.QueuedState> m_StateQueue; // 0x10
	private SimpleAnimationPlayable.StateManagement m_States; // 0x18
	private bool m_Initialized; // 0x20
	private bool m_KeepStoppedPlayablesConnected; // 0x21
	protected Playable m_ActualPlayable; // 0x28
	private AnimationMixerPlayable m_Mixer; // 0x38
	public Action onDone; // 0x48
	private int m_StatesVersion; // 0x50

	// Properties
	public bool keepStoppedPlayablesConnected { get; set; }
	protected Playable self { get; }
	public Playable playable { get; }
	protected PlayableGraph graph { get; }

	// Methods

	// RVA: 0x1B89FC0 Offset: 0x1B8A0C1 VA: 0x1B89FC0
	public bool get_keepStoppedPlayablesConnected() { }

	// RVA: 0x1B89FD0 Offset: 0x1B8A0D1 VA: 0x1B89FD0
	public void set_keepStoppedPlayablesConnected(bool value) { }

	// RVA: 0x1B89FF0 Offset: 0x1B8A0F1 VA: 0x1B89FF0
	private void UpdateStoppedPlayablesConnections() { }

	// RVA: 0x1B8A3D0 Offset: 0x1B8A4D1 VA: 0x1B8A3D0
	protected Playable get_self() { }

	// RVA: 0x1B880F0 Offset: 0x1B881F1 VA: 0x1B880F0
	public Playable get_playable() { }

	// RVA: 0x1B8A3E0 Offset: 0x1B8A4E1 VA: 0x1B8A3E0
	protected PlayableGraph get_graph() { }

	// RVA: 0x1B87EF0 Offset: 0x1B87FF1 VA: 0x1B87EF0
	public void .ctor() { }

	// RVA: 0x1B8A4B0 Offset: 0x1B8A5B1 VA: 0x1B8A4B0
	public Playable GetInput(int index) { }

	// RVA: 0x1B8A560 Offset: 0x1B8A661 VA: 0x1B8A560 Slot: 15
	public override void OnPlayableCreate(Playable playable) { }

	// RVA: 0x1B88EF0 Offset: 0x1B88FF1 VA: 0x1B88EF0
	public IEnumerable<SimpleAnimationPlayable.IState> GetStates() { }

	// RVA: 0x1B878A0 Offset: 0x1B879A1 VA: 0x1B878A0
	public SimpleAnimationPlayable.IState GetState(string name) { }

	// RVA: 0x1B8A8A0 Offset: 0x1B8A9A1 VA: 0x1B8A8A0
	private SimpleAnimationPlayable.StateInfo DoAddClip(string name, AnimationClip clip) { }

	// RVA: 0x1B86BB0 Offset: 0x1B86CB1 VA: 0x1B86BB0
	public bool AddClip(AnimationClip clip, string name) { }

	// RVA: 0x1B87190 Offset: 0x1B87291 VA: 0x1B87190
	public bool RemoveClip(string name) { }

	// RVA: 0x1B87540 Offset: 0x1B87641 VA: 0x1B87540
	public bool RemoveClip(AnimationClip clip) { }

	// RVA: 0x1B86AE0 Offset: 0x1B86BE1 VA: 0x1B86AE0
	public bool Play(string name) { }

	// RVA: 0x1B8B130 Offset: 0x1B8B231 VA: 0x1B8B130
	private bool Play(int index) { }

	// RVA: 0x1B87360 Offset: 0x1B87461 VA: 0x1B87360
	public bool PlayQueued(string name, QueueMode queueMode) { }

	// RVA: 0x1B8B340 Offset: 0x1B8B441 VA: 0x1B8B340
	private bool PlayQueued(int index, QueueMode queueMode) { }

	// RVA: 0x1B87730 Offset: 0x1B87831 VA: 0x1B87730
	public void Rewind(string name) { }

	// RVA: 0x1B8B690 Offset: 0x1B8B791 VA: 0x1B8B690
	private void Rewind(int index) { }

	// RVA: 0x1B875C0 Offset: 0x1B876C1 VA: 0x1B875C0
	public void Rewind() { }

	// RVA: 0x1B8ADB0 Offset: 0x1B8AEB1 VA: 0x1B8ADB0
	private void RemoveClones(SimpleAnimationPlayable.StateInfo state) { }

	// RVA: 0x1B86920 Offset: 0x1B86A21 VA: 0x1B86920
	public bool Stop(string name) { }

	// RVA: 0x1B8B280 Offset: 0x1B8B381 VA: 0x1B8B280
	private void DoStop(int index) { }

	// RVA: 0x1B86870 Offset: 0x1B86971 VA: 0x1B86870
	public bool StopAll() { }

	// RVA: 0x1B85E90 Offset: 0x1B85F91 VA: 0x1B85E90
	public bool IsPlaying() { }

	// RVA: 0x1B86790 Offset: 0x1B86891 VA: 0x1B86790
	public bool IsPlaying(string stateName) { }

	// RVA: 0x1B8B9F0 Offset: 0x1B8BAF1 VA: 0x1B8B9F0
	private bool IsClonePlaying(SimpleAnimationPlayable.StateInfo state) { }

	// RVA: 0x1B86670 Offset: 0x1B86771 VA: 0x1B86670
	public int GetClipCount() { }

	// RVA: 0x1B8BB60 Offset: 0x1B8BC61 VA: 0x1B8BB60
	private void SetupLerp(SimpleAnimationPlayable.StateInfo state, float targetWeight, float time) { }

	// RVA: 0x1B8BD40 Offset: 0x1B8BE41 VA: 0x1B8BD40
	private bool Crossfade(int index, float time) { }

	// RVA: 0x1B8B470 Offset: 0x1B8B571 VA: 0x1B8B470
	private SimpleAnimationPlayable.StateInfo CloneState(int index) { }

	// RVA: 0x1B86360 Offset: 0x1B86461 VA: 0x1B86360
	public bool Crossfade(string name, float time) { }

	// RVA: 0x1B864D0 Offset: 0x1B865D1 VA: 0x1B864D0
	public bool CrossfadeQueued(string name, float time, QueueMode queueMode) { }

	// RVA: 0x1B8BFB0 Offset: 0x1B8C0B1 VA: 0x1B8BFB0
	private bool CrossfadeQueued(int index, float time, QueueMode queueMode) { }

	// RVA: 0x1B8C0F0 Offset: 0x1B8C1F1 VA: 0x1B8C0F0
	private bool Blend(int index, float targetWeight, float time) { }

	// RVA: 0x1B86200 Offset: 0x1B86301 VA: 0x1B86200
	public bool Blend(string name, float targetWeight, float time) { }

	// RVA: 0x1B8C240 Offset: 0x1B8C341 VA: 0x1B8C240 Slot: 14
	public override void OnGraphStop(Playable playable) { }

	// RVA: 0x1B8AD00 Offset: 0x1B8AE01 VA: 0x1B8AD00
	private void UpdateDoneStatus() { }

	// RVA: 0x1B8C430 Offset: 0x1B8C531 VA: 0x1B8C430
	private void CleanClonedStates() { }

	// RVA: 0x1B8A280 Offset: 0x1B8A381 VA: 0x1B8A280
	private void DisconnectInput(int index) { }

	// RVA: 0x1B8A160 Offset: 0x1B8A261 VA: 0x1B8A160
	private void ConnectInput(int index) { }

	// RVA: 0x1B8C600 Offset: 0x1B8C701 VA: 0x1B8C600
	private void UpdateStates(float deltaTime) { }

	// RVA: 0x1B8CF50 Offset: 0x1B8D051 VA: 0x1B8CF50
	private float CalculateQueueTimes() { }

	// RVA: 0x1B8D1F0 Offset: 0x1B8D2F1 VA: 0x1B8D1F0
	private void ClearQueuedStates() { }

	// RVA: 0x1B8D3A0 Offset: 0x1B8D4A1 VA: 0x1B8D3A0
	private void UpdateQueuedStates() { }

	// RVA: 0x1B8D490 Offset: 0x1B8D591 VA: 0x1B8D490
	private void InvalidateStateTimes() { }

	// RVA: 0x1B8D560 Offset: 0x1B8D661 VA: 0x1B8D560 Slot: 19
	public override void PrepareFrame(Playable owner, FrameData data) { }

	// RVA: 0x1B8D5B0 Offset: 0x1B8D6B1 VA: 0x1B8D5B0
	public bool ValidateInput(int index, Playable input) { }

	// RVA: 0x1B8D710 Offset: 0x1B8D811 VA: 0x1B8D710
	public bool ValidateIndex(int index) { }

	// RVA: 0x1B8ADA0 Offset: 0x1B8AEA1 VA: 0x1B8ADA0
	private void InvalidateStates() { }

	// RVA: 0x1B8B5B0 Offset: 0x1B8B6B1 VA: 0x1B8B5B0
	private SimpleAnimationPlayable.StateHandle StateInfoToHandle(SimpleAnimationPlayable.StateInfo info) { }
}


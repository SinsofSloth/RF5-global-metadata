public struct ScriptPlayable<T> : IPlayable, IEquatable<ScriptPlayable<T>> // TypeDefIndex: 3360
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly ScriptPlayable<T> m_NullPlayable; // 0x0

	// Properties
	public static ScriptPlayable<T> Null { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> get_Null() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC00F0 Offset: 0x2CC01F1 VA: 0x2CC00F0
	|-ScriptPlayable<ActivationControlPlayable>.get_Null
	|-ScriptPlayable<DirectorControlPlayable>.get_Null
	|-ScriptPlayable<ParticleControlPlayable>.get_Null
	|-ScriptPlayable<PrefabControlPlayable>.get_Null
	|-ScriptPlayable<TimeControlPlayable>.get_Null
	|-ScriptPlayable<TimeNotificationBehaviour>.get_Null
	|-ScriptPlayable<object>.get_Null
	*/

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC0220 Offset: 0x2CC0321 VA: 0x2CC0220
	|-ScriptPlayable<ChangeAvatorMixerBehavior>.Create
	|-ScriptPlayable<CinemachineMixer>.Create
	|-ScriptPlayable<CinemachineShotPlayable>.Create
	|-ScriptPlayable<ConstraintMixerBehavior>.Create
	|-ScriptPlayable<DualworkLoopBehaviour>.Create
	|-ScriptPlayable<DualworkLoopMixerBehaviour>.Create
	|-ScriptPlayable<FxProBehaviour>.Create
	|-ScriptPlayable<FxProMixerBehavior>.Create
	|-ScriptPlayable<GrounderIKMixerBehavior>.Create
	|-ScriptPlayable<HumanEquipMixerBehavior>.Create
	|-ScriptPlayable<HumanIKMixerBehavior>.Create
	|-ScriptPlayable<LightControlMixerBehaviour>.Create
	|-ScriptPlayable<NavMeshAgentControlMixerBehaviour>.Create
	|-ScriptPlayable<ScreenFaderMixerBehaviour>.Create
	|-ScriptPlayable<SptingBoneMixerBehavior>.Create
	|-ScriptPlayable<TimelineEventMixerBehaviour>.Create
	|-ScriptPlayable<TextSwitcherMixerBehaviour>.Create
	|-ScriptPlayable<TimeDilationMixerBehaviour>.Create
	|-ScriptPlayable<TimelineIKMixerBehaviour>.Create
	|-ScriptPlayable<TransformTweenMixerBehaviour>.Create
	|-ScriptPlayable<ActivationControlPlayable>.Create
	|-ScriptPlayable<ActivationMixerPlayable>.Create
	|-ScriptPlayable<DirectorControlPlayable>.Create
	|-ScriptPlayable<ParticleControlPlayable>.Create
	|-ScriptPlayable<PrefabControlPlayable>.Create
	|-ScriptPlayable<TimeControlPlayable>.Create
	|-ScriptPlayable<TimeNotificationBehaviour>.Create
	|-ScriptPlayable<TimelinePlayable>.Create
	|-ScriptPlayable<VideoPlayableBehaviour>.Create
	|-ScriptPlayable<VideoSchedulerPlayableBehaviour>.Create
	|-ScriptPlayable<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC03D0 Offset: 0x2CC04D1 VA: 0x2CC03D0
	|-ScriptPlayable<ActionScriptBehavior>.Create
	|-ScriptPlayable<ChangeAvatorBehavior>.Create
	|-ScriptPlayable<ConstraintBehavior>.Create
	|-ScriptPlayable<CutInTelopBehavior>.Create
	|-ScriptPlayable<DialogueBehaviour>.Create
	|-ScriptPlayable<EmotionBehavior>.Create
	|-ScriptPlayable<GrounderIKBehavior>.Create
	|-ScriptPlayable<HumanEquipBehavior>.Create
	|-ScriptPlayable<HumanIKBehavior>.Create
	|-ScriptPlayable<LightControlBehaviour>.Create
	|-ScriptPlayable<NavMeshAgentControlBehaviour>.Create
	|-ScriptPlayable<RF_AudioBehaviour>.Create
	|-ScriptPlayable<ScreenFaderBehaviour>.Create
	|-ScriptPlayable<SimpleAnimationPlayable>.Create
	|-ScriptPlayable<SpringBoneBehavior>.Create
	|-ScriptPlayable<SpringBoneInitBehavior>.Create
	|-ScriptPlayable<TimelineEventBehaviour>.Create
	|-ScriptPlayable<TextSwitcherBehaviour>.Create
	|-ScriptPlayable<TimeDilationBehaviour>.Create
	|-ScriptPlayable<TimeMachineBehaviour>.Create
	|-ScriptPlayable<TimelineIKBehaviour>.Create
	|-ScriptPlayable<TransformTweenBehaviour>.Create
	|-ScriptPlayable<BasicPlayableBehaviour>.Create
	|-ScriptPlayable<object>.Create
	*/

	// RVA: -1 Offset: -1
	private static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC0590 Offset: 0x2CC0691 VA: 0x2CC0590
	|-ScriptPlayable<object>.CreateHandle
	*/

	// RVA: -1 Offset: -1
	private static object CreateScriptInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC0930 Offset: 0x2CC0A31 VA: 0x2CC0930
	|-ScriptPlayable<object>.CreateScriptInstance
	*/

	// RVA: -1 Offset: -1
	private static object CloneScriptInstance(IPlayableBehaviour source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC0B40 Offset: 0x2CC0C41 VA: 0x2CC0B40
	|-ScriptPlayable<object>.CloneScriptInstance
	*/

	// RVA: -1 Offset: -1
	private static object CloneScriptInstanceFromEngineObject(Object source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC0E60 Offset: 0x2CC0F61 VA: 0x2CC0E60
	|-ScriptPlayable<object>.CloneScriptInstanceFromEngineObject
	*/

	// RVA: -1 Offset: -1
	private static object CloneScriptInstanceFromIClonable(ICloneable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC0F10 Offset: 0x2CC1011 VA: 0x2CC0F10
	|-ScriptPlayable<object>.CloneScriptInstanceFromIClonable
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(PlayableHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BB40 Offset: 0x38BC41 VA: 0x38BB40
	|-ScriptPlayable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public PlayableHandle GetHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BB50 Offset: 0x38BC51 VA: 0x38BB50
	|-ScriptPlayable<object>.GetHandle
	*/

	// RVA: -1 Offset: -1
	public T GetBehaviour() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BB60 Offset: 0x38BC61 VA: 0x38BB60
	|-ScriptPlayable<ChangeAvatorBehavior>.GetBehaviour
	|-ScriptPlayable<CinemachineShotPlayable>.GetBehaviour
	|-ScriptPlayable<ConstraintBehavior>.GetBehaviour
	|-ScriptPlayable<EmotionBehavior>.GetBehaviour
	|-ScriptPlayable<FxProBehaviour>.GetBehaviour
	|-ScriptPlayable<FxProMixerBehavior>.GetBehaviour
	|-ScriptPlayable<GrounderIKBehavior>.GetBehaviour
	|-ScriptPlayable<HumanEquipBehavior>.GetBehaviour
	|-ScriptPlayable<HumanIKBehavior>.GetBehaviour
	|-ScriptPlayable<LightControlBehaviour>.GetBehaviour
	|-ScriptPlayable<NavMeshAgentControlBehaviour>.GetBehaviour
	|-ScriptPlayable<RF_AudioBehaviour>.GetBehaviour
	|-ScriptPlayable<ScreenFaderBehaviour>.GetBehaviour
	|-ScriptPlayable<SimpleAnimationPlayable>.GetBehaviour
	|-ScriptPlayable<SpringBoneBehavior>.GetBehaviour
	|-ScriptPlayable<SpringBoneInitBehavior>.GetBehaviour
	|-ScriptPlayable<TimelineEventBehaviour>.GetBehaviour
	|-ScriptPlayable<TextSwitcherBehaviour>.GetBehaviour
	|-ScriptPlayable<TimeDilationBehaviour>.GetBehaviour
	|-ScriptPlayable<TimelineIKBehaviour>.GetBehaviour
	|-ScriptPlayable<TransformTweenBehaviour>.GetBehaviour
	|-ScriptPlayable<ActivationControlPlayable>.GetBehaviour
	|-ScriptPlayable<ActivationMixerPlayable>.GetBehaviour
	|-ScriptPlayable<DirectorControlPlayable>.GetBehaviour
	|-ScriptPlayable<ParticleControlPlayable>.GetBehaviour
	|-ScriptPlayable<PrefabControlPlayable>.GetBehaviour
	|-ScriptPlayable<TimeControlPlayable>.GetBehaviour
	|-ScriptPlayable<TimeNotificationBehaviour>.GetBehaviour
	|-ScriptPlayable<TimelinePlayable>.GetBehaviour
	|-ScriptPlayable<VideoPlayableBehaviour>.GetBehaviour
	|-ScriptPlayable<VideoSchedulerPlayableBehaviour>.GetBehaviour
	|-ScriptPlayable<object>.GetBehaviour
	*/

	// RVA: -1 Offset: -1
	public static Playable op_Implicit(ScriptPlayable<T> playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC11A0 Offset: 0x2CC12A1 VA: 0x2CC11A0
	|-ScriptPlayable<ActionScriptBehavior>.op_Implicit
	|-ScriptPlayable<ChangeAvatorBehavior>.op_Implicit
	|-ScriptPlayable<ChangeAvatorMixerBehavior>.op_Implicit
	|-ScriptPlayable<CinemachineMixer>.op_Implicit
	|-ScriptPlayable<CinemachineShotPlayable>.op_Implicit
	|-ScriptPlayable<ConstraintBehavior>.op_Implicit
	|-ScriptPlayable<ConstraintMixerBehavior>.op_Implicit
	|-ScriptPlayable<CutInTelopBehavior>.op_Implicit
	|-ScriptPlayable<DialogueBehaviour>.op_Implicit
	|-ScriptPlayable<DualworkLoopBehaviour>.op_Implicit
	|-ScriptPlayable<DualworkLoopMixerBehaviour>.op_Implicit
	|-ScriptPlayable<EmotionBehavior>.op_Implicit
	|-ScriptPlayable<FxProBehaviour>.op_Implicit
	|-ScriptPlayable<FxProMixerBehavior>.op_Implicit
	|-ScriptPlayable<GrounderIKBehavior>.op_Implicit
	|-ScriptPlayable<GrounderIKMixerBehavior>.op_Implicit
	|-ScriptPlayable<HumanEquipBehavior>.op_Implicit
	|-ScriptPlayable<HumanEquipMixerBehavior>.op_Implicit
	|-ScriptPlayable<HumanIKBehavior>.op_Implicit
	|-ScriptPlayable<HumanIKMixerBehavior>.op_Implicit
	|-ScriptPlayable<LightControlBehaviour>.op_Implicit
	|-ScriptPlayable<LightControlMixerBehaviour>.op_Implicit
	|-ScriptPlayable<NavMeshAgentControlBehaviour>.op_Implicit
	|-ScriptPlayable<NavMeshAgentControlMixerBehaviour>.op_Implicit
	|-ScriptPlayable<RF_AudioBehaviour>.op_Implicit
	|-ScriptPlayable<ScreenFaderBehaviour>.op_Implicit
	|-ScriptPlayable<ScreenFaderMixerBehaviour>.op_Implicit
	|-ScriptPlayable<SpringBoneBehavior>.op_Implicit
	|-ScriptPlayable<SpringBoneInitBehavior>.op_Implicit
	|-ScriptPlayable<SptingBoneMixerBehavior>.op_Implicit
	|-ScriptPlayable<object>.op_Implicit
	|-ScriptPlayable<TimelineEventBehaviour>.op_Implicit
	|-ScriptPlayable<TimelineEventMixerBehaviour>.op_Implicit
	|-ScriptPlayable<TextSwitcherBehaviour>.op_Implicit
	|-ScriptPlayable<TextSwitcherMixerBehaviour>.op_Implicit
	|-ScriptPlayable<TimeDilationBehaviour>.op_Implicit
	|-ScriptPlayable<TimeDilationMixerBehaviour>.op_Implicit
	|-ScriptPlayable<TimeMachineBehaviour>.op_Implicit
	|-ScriptPlayable<TimelineIKBehaviour>.op_Implicit
	|-ScriptPlayable<TimelineIKMixerBehaviour>.op_Implicit
	|-ScriptPlayable<TransformTweenBehaviour>.op_Implicit
	|-ScriptPlayable<TransformTweenMixerBehaviour>.op_Implicit
	|-ScriptPlayable<ActivationControlPlayable>.op_Implicit
	|-ScriptPlayable<ActivationMixerPlayable>.op_Implicit
	|-ScriptPlayable<BasicPlayableBehaviour>.op_Implicit
	|-ScriptPlayable<DirectorControlPlayable>.op_Implicit
	|-ScriptPlayable<ParticleControlPlayable>.op_Implicit
	|-ScriptPlayable<PrefabControlPlayable>.op_Implicit
	|-ScriptPlayable<TimeControlPlayable>.op_Implicit
	|-ScriptPlayable<TimeNotificationBehaviour>.op_Implicit
	|-ScriptPlayable<TimelinePlayable>.op_Implicit
	|-ScriptPlayable<VideoPlayableBehaviour>.op_Implicit
	|-ScriptPlayable<VideoSchedulerPlayableBehaviour>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> op_Explicit(Playable playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC1200 Offset: 0x2CC1301 VA: 0x2CC1200
	|-ScriptPlayable<CinemachineShotPlayable>.op_Explicit
	|-ScriptPlayable<LightControlBehaviour>.op_Explicit
	|-ScriptPlayable<NavMeshAgentControlBehaviour>.op_Explicit
	|-ScriptPlayable<ScreenFaderBehaviour>.op_Explicit
	|-ScriptPlayable<TextSwitcherBehaviour>.op_Explicit
	|-ScriptPlayable<TimeDilationBehaviour>.op_Explicit
	|-ScriptPlayable<TimelineIKBehaviour>.op_Explicit
	|-ScriptPlayable<TransformTweenBehaviour>.op_Explicit
	|-ScriptPlayable<VideoPlayableBehaviour>.op_Explicit
	|-ScriptPlayable<object>.op_Explicit
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool Equals(ScriptPlayable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38BBA0 Offset: 0x38BCA1 VA: 0x38BBA0
	|-ScriptPlayable<object>.Equals
	|-ScriptPlayable<TimeNotificationBehaviour>.Equals
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC1350 Offset: 0x2CC1451 VA: 0x2CC1350
	|-ScriptPlayable<object>..cctor
	*/
}


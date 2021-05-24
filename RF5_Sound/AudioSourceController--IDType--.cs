public abstract class AudioSourceController<IDType> : MonoBehaviour // TypeDefIndex: 9863
{
	// Fields
	private AudioSource _AudioSource; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F900 Offset: 0x17FA01 VA: 0x17F900
	private Transform <Constraint>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F910 Offset: 0x17FA11 VA: 0x17F910
	private bool <IsConstraint>k__BackingField; // 0x0
	private IDType _CurrentID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F920 Offset: 0x17FA21 VA: 0x17F920
	private IDType <CurrentID>k__BackingField; // 0x0
	private int EntriedAssetID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F930 Offset: 0x17FA31 VA: 0x17F930
	private float <FadeTime>k__BackingField; // 0x0
	private float FadeAlpha; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F940 Offset: 0x17FA41 VA: 0x17F940
	private bool <IsPause>k__BackingField; // 0x0
	public DestroyMode DestroyMode; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F950 Offset: 0x17FA51 VA: 0x17F950
	private float <Volume>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F960 Offset: 0x17FA61 VA: 0x17F960
	private float <DataTable_Volume>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F970 Offset: 0x17FA71 VA: 0x17F970
	private int <Priority>k__BackingField; // 0x0
	private static int stateElementTableCount; // 0x0
	private AudioSourceController.Command<IDType> AfterLoad; // 0x0
	private AudioSourceController.State<IDType> InitialState; // 0x0
	private StateMachine<AudioSourceController.State<IDType>> sm; // 0x0
	private float m_PlayTime; // 0x0
	private static TransitionTables[] TransitionTables; // 0x0
	private bool IsTimeline; // 0x0
	private bool IsTimelineLoop; // 0x0
	private bool wait_first_frame; // 0x0

	// Properties
	public AudioSource AudioSource { get; set; }
	public Transform Constraint { get; set; }
	public bool IsConstraint { get; set; }
	public IDType CurrentID { get; set; }
	protected float FadeTime { get; set; }
	protected virtual AnimationCurve FadeCurve { get; }
	public bool IsPause { get; set; }
	public float Volume { get; set; }
	protected float DataTable_Volume { get; set; }
	public int Priority { get; set; }
	public float PlayTime { get; }
	public AudioSourceController.State<IDType> GetState { get; }
	public abstract IDType EmptyValue { get; }
	public abstract bool IsLoopClip { get; }
	public bool IsLoopAudioSource { get; }

	// Methods

	// RVA: -1 Offset: -1
	public AudioSource get_AudioSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C989F0 Offset: 0x2C98AF1 VA: 0x2C989F0
	|-AudioSourceController<BGMID>.get_AudioSource
	|-AudioSourceController<SoundID>.get_AudioSource
	|-AudioSourceController<Int32Enum>.get_AudioSource
	|
	|-RVA: 0x2C9D9A0 Offset: 0x2C9DAA1 VA: 0x2C9D9A0
	|-AudioSourceController<object>.get_AudioSource
	*/

	// RVA: -1 Offset: -1
	public void set_AudioSource(AudioSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AA0 Offset: 0x2C98BA1 VA: 0x2C98AA0
	|-AudioSourceController<Int32Enum>.set_AudioSource
	|
	|-RVA: 0x2C9DA50 Offset: 0x2C9DB51 VA: 0x2C9DA50
	|-AudioSourceController<object>.set_AudioSource
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD150 Offset: 0x1AD251 VA: 0x1AD150
	// RVA: -1 Offset: -1
	public Transform get_Constraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AB0 Offset: 0x2C98BB1 VA: 0x2C98AB0
	|-AudioSourceController<Int32Enum>.get_Constraint
	|
	|-RVA: 0x2C9DA60 Offset: 0x2C9DB61 VA: 0x2C9DA60
	|-AudioSourceController<object>.get_Constraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD160 Offset: 0x1AD261 VA: 0x1AD160
	// RVA: -1 Offset: -1
	public void set_Constraint(Transform value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AC0 Offset: 0x2C98BC1 VA: 0x2C98AC0
	|-AudioSourceController<SoundID>.set_Constraint
	|-AudioSourceController<Int32Enum>.set_Constraint
	|
	|-RVA: 0x2C9DA70 Offset: 0x2C9DB71 VA: 0x2C9DA70
	|-AudioSourceController<object>.set_Constraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD170 Offset: 0x1AD271 VA: 0x1AD170
	// RVA: -1 Offset: -1
	public bool get_IsConstraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AD0 Offset: 0x2C98BD1 VA: 0x2C98AD0
	|-AudioSourceController<Int32Enum>.get_IsConstraint
	|
	|-RVA: 0x2C9DA80 Offset: 0x2C9DB81 VA: 0x2C9DA80
	|-AudioSourceController<object>.get_IsConstraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD180 Offset: 0x1AD281 VA: 0x1AD180
	// RVA: -1 Offset: -1
	public void set_IsConstraint(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AE0 Offset: 0x2C98BE1 VA: 0x2C98AE0
	|-AudioSourceController<SoundID>.set_IsConstraint
	|-AudioSourceController<Int32Enum>.set_IsConstraint
	|
	|-RVA: 0x2C9DA90 Offset: 0x2C9DB91 VA: 0x2C9DA90
	|-AudioSourceController<object>.set_IsConstraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD190 Offset: 0x1AD291 VA: 0x1AD190
	// RVA: -1 Offset: -1
	public IDType get_CurrentID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AF0 Offset: 0x2C98BF1 VA: 0x2C98AF0
	|-AudioSourceController<BGMID>.get_CurrentID
	|-AudioSourceController<SoundID>.get_CurrentID
	|-AudioSourceController<Int32Enum>.get_CurrentID
	|
	|-RVA: 0x2C9DAA0 Offset: 0x2C9DBA1 VA: 0x2C9DAA0
	|-AudioSourceController<object>.get_CurrentID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1A0 Offset: 0x1AD2A1 VA: 0x1AD1A0
	// RVA: -1 Offset: -1
	public void set_CurrentID(IDType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98B00 Offset: 0x2C98C01 VA: 0x2C98B00
	|-AudioSourceController<SoundID>.set_CurrentID
	|-AudioSourceController<Int32Enum>.set_CurrentID
	|
	|-RVA: 0x2C9DAB0 Offset: 0x2C9DBB1 VA: 0x2C9DAB0
	|-AudioSourceController<object>.set_CurrentID
	*/

	// RVA: -1 Offset: -1
	protected void SetAssetID(Audio id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98B10 Offset: 0x2C98C11 VA: 0x2C98B10
	|-AudioSourceController<BGMID>.SetAssetID
	|-AudioSourceController<SoundID>.SetAssetID
	|-AudioSourceController<Int32Enum>.SetAssetID
	|
	|-RVA: 0x2C9DAC0 Offset: 0x2C9DBC1 VA: 0x2C9DAC0
	|-AudioSourceController<object>.SetAssetID
	*/

	// RVA: -1 Offset: -1
	private bool RemoveAssetID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98BF0 Offset: 0x2C98CF1 VA: 0x2C98BF0
	|-AudioSourceController<Int32Enum>.RemoveAssetID
	|
	|-RVA: 0x2C9DBA0 Offset: 0x2C9DCA1 VA: 0x2C9DBA0
	|-AudioSourceController<object>.RemoveAssetID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1B0 Offset: 0x1AD2B1 VA: 0x1AD1B0
	// RVA: -1 Offset: -1
	protected float get_FadeTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98C80 Offset: 0x2C98D81 VA: 0x2C98C80
	|-AudioSourceController<Int32Enum>.get_FadeTime
	|
	|-RVA: 0x2C9DC30 Offset: 0x2C9DD31 VA: 0x2C9DC30
	|-AudioSourceController<object>.get_FadeTime
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1C0 Offset: 0x1AD2C1 VA: 0x1AD1C0
	// RVA: -1 Offset: -1
	protected void set_FadeTime(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98C90 Offset: 0x2C98D91 VA: 0x2C98C90
	|-AudioSourceController<Int32Enum>.set_FadeTime
	|
	|-RVA: 0x2C9DC40 Offset: 0x2C9DD41 VA: 0x2C9DC40
	|-AudioSourceController<object>.set_FadeTime
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual AnimationCurve get_FadeCurve() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98CA0 Offset: 0x2C98DA1 VA: 0x2C98CA0
	|-AudioSourceController<BGMID>.get_FadeCurve
	|-AudioSourceController<SoundID>.get_FadeCurve
	|-AudioSourceController<Int32Enum>.get_FadeCurve
	|
	|-RVA: 0x2C9DC50 Offset: 0x2C9DD51 VA: 0x2C9DC50
	|-AudioSourceController<object>.get_FadeCurve
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1D0 Offset: 0x1AD2D1 VA: 0x1AD1D0
	// RVA: -1 Offset: -1
	public bool get_IsPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D00 Offset: 0x2C98E01 VA: 0x2C98D00
	|-AudioSourceController<Int32Enum>.get_IsPause
	|
	|-RVA: 0x2C9DCB0 Offset: 0x2C9DDB1 VA: 0x2C9DCB0
	|-AudioSourceController<object>.get_IsPause
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1E0 Offset: 0x1AD2E1 VA: 0x1AD1E0
	// RVA: -1 Offset: -1
	protected void set_IsPause(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D10 Offset: 0x2C98E11 VA: 0x2C98D10
	|-AudioSourceController<Int32Enum>.set_IsPause
	|
	|-RVA: 0x2C9DCC0 Offset: 0x2C9DDC1 VA: 0x2C9DCC0
	|-AudioSourceController<object>.set_IsPause
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1F0 Offset: 0x1AD2F1 VA: 0x1AD1F0
	// RVA: -1 Offset: -1
	public float get_Volume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D20 Offset: 0x2C98E21 VA: 0x2C98D20
	|-AudioSourceController<Int32Enum>.get_Volume
	|
	|-RVA: 0x2C9DCD0 Offset: 0x2C9DDD1 VA: 0x2C9DCD0
	|-AudioSourceController<object>.get_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD200 Offset: 0x1AD301 VA: 0x1AD200
	// RVA: -1 Offset: -1
	public void set_Volume(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D30 Offset: 0x2C98E31 VA: 0x2C98D30
	|-AudioSourceController<SoundID>.set_Volume
	|-AudioSourceController<Int32Enum>.set_Volume
	|
	|-RVA: 0x2C9DCE0 Offset: 0x2C9DDE1 VA: 0x2C9DCE0
	|-AudioSourceController<object>.set_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD210 Offset: 0x1AD311 VA: 0x1AD210
	// RVA: -1 Offset: -1
	protected float get_DataTable_Volume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D40 Offset: 0x2C98E41 VA: 0x2C98D40
	|-AudioSourceController<Int32Enum>.get_DataTable_Volume
	|
	|-RVA: 0x2C9DCF0 Offset: 0x2C9DDF1 VA: 0x2C9DCF0
	|-AudioSourceController<object>.get_DataTable_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD220 Offset: 0x1AD321 VA: 0x1AD220
	// RVA: -1 Offset: -1
	protected void set_DataTable_Volume(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D50 Offset: 0x2C98E51 VA: 0x2C98D50
	|-AudioSourceController<SoundID>.set_DataTable_Volume
	|-AudioSourceController<Int32Enum>.set_DataTable_Volume
	|
	|-RVA: 0x2C9DD00 Offset: 0x2C9DE01 VA: 0x2C9DD00
	|-AudioSourceController<object>.set_DataTable_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD230 Offset: 0x1AD331 VA: 0x1AD230
	// RVA: -1 Offset: -1
	public int get_Priority() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D60 Offset: 0x2C98E61 VA: 0x2C98D60
	|-AudioSourceController<BGMID>.get_Priority
	|-AudioSourceController<SoundID>.get_Priority
	|-AudioSourceController<Int32Enum>.get_Priority
	|
	|-RVA: 0x2C9DD10 Offset: 0x2C9DE11 VA: 0x2C9DD10
	|-AudioSourceController<object>.get_Priority
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD240 Offset: 0x1AD341 VA: 0x1AD240
	// RVA: -1 Offset: -1
	private void set_Priority(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D70 Offset: 0x2C98E71 VA: 0x2C98D70
	|-AudioSourceController<Int32Enum>.set_Priority
	|
	|-RVA: 0x2C9DD20 Offset: 0x2C9DE21 VA: 0x2C9DD20
	|-AudioSourceController<object>.set_Priority
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual AudioSource ReadyAudioSourceComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D80 Offset: 0x2C98E81 VA: 0x2C98D80
	|-AudioSourceController<BGMID>.ReadyAudioSourceComponent
	|-AudioSourceController<SoundID>.ReadyAudioSourceComponent
	|-AudioSourceController<Int32Enum>.ReadyAudioSourceComponent
	|
	|-RVA: 0x2C9DD30 Offset: 0x2C9DE31 VA: 0x2C9DD30
	|-AudioSourceController<object>.ReadyAudioSourceComponent
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98DF0 Offset: 0x2C98EF1 VA: 0x2C98DF0
	|-AudioSourceController<BGMID>.Awake
	|-AudioSourceController<SoundID>.Awake
	|-AudioSourceController<Int32Enum>.Awake
	|
	|-RVA: 0x2C9DDA0 Offset: 0x2C9DEA1 VA: 0x2C9DDA0
	|-AudioSourceController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99550 Offset: 0x2C99651 VA: 0x2C99550
	|-AudioSourceController<BGMID>.OnDestroy
	|-AudioSourceController<SoundID>.OnDestroy
	|-AudioSourceController<Int32Enum>.OnDestroy
	|
	|-RVA: 0x2C9E500 Offset: 0x2C9E601 VA: 0x2C9E500
	|-AudioSourceController<object>.OnDestroy
	*/

	// RVA: -1 Offset: -1
	public float get_PlayTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99580 Offset: 0x2C99681 VA: 0x2C99580
	|-AudioSourceController<Int32Enum>.get_PlayTime
	|
	|-RVA: 0x2C9E530 Offset: 0x2C9E631 VA: 0x2C9E530
	|-AudioSourceController<object>.get_PlayTime
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual void ResetByRemoveAllResources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C995D0 Offset: 0x2C996D1 VA: 0x2C995D0
	|-AudioSourceController<BGMID>.ResetByRemoveAllResources
	|-AudioSourceController<SoundID>.ResetByRemoveAllResources
	|-AudioSourceController<Int32Enum>.ResetByRemoveAllResources
	|
	|-RVA: 0x2C9E580 Offset: 0x2C9E681 VA: 0x2C9E580
	|-AudioSourceController<object>.ResetByRemoveAllResources
	*/

	// RVA: -1 Offset: -1
	private bool UpdateConstraintPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99730 Offset: 0x2C99831 VA: 0x2C99730
	|-AudioSourceController<Int32Enum>.UpdateConstraintPosition
	|
	|-RVA: 0x2C9E6E0 Offset: 0x2C9E7E1 VA: 0x2C9E6E0
	|-AudioSourceController<object>.UpdateConstraintPosition
	*/

	// RVA: -1 Offset: -1
	public void Pause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99830 Offset: 0x2C99931 VA: 0x2C99830
	|-AudioSourceController<BGMID>.Pause
	|-AudioSourceController<SoundID>.Pause
	|-AudioSourceController<Int32Enum>.Pause
	|
	|-RVA: 0x2C9E7E0 Offset: 0x2C9E8E1 VA: 0x2C9E7E0
	|-AudioSourceController<object>.Pause
	*/

	// RVA: -1 Offset: -1
	public void UnPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99990 Offset: 0x2C99A91 VA: 0x2C99990
	|-AudioSourceController<BGMID>.UnPause
	|-AudioSourceController<SoundID>.UnPause
	|-AudioSourceController<Int32Enum>.UnPause
	|
	|-RVA: 0x2C9E940 Offset: 0x2C9EA41 VA: 0x2C9E940
	|-AudioSourceController<object>.UnPause
	*/

	// RVA: -1 Offset: -1
	public bool IsPlaying() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99A80 Offset: 0x2C99B81 VA: 0x2C99A80
	|-AudioSourceController<SoundID>.IsPlaying
	|-AudioSourceController<Int32Enum>.IsPlaying
	|
	|-RVA: 0x2C9EA30 Offset: 0x2C9EB31 VA: 0x2C9EA30
	|-AudioSourceController<object>.IsPlaying
	*/

	// RVA: -1 Offset: -1
	public bool IsDoneLoad() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99C70 Offset: 0x2C99D71 VA: 0x2C99C70
	|-AudioSourceController<SoundID>.IsDoneLoad
	|-AudioSourceController<Int32Enum>.IsDoneLoad
	|
	|-RVA: 0x2C9EC20 Offset: 0x2C9ED21 VA: 0x2C9EC20
	|-AudioSourceController<object>.IsDoneLoad
	*/

	// RVA: -1 Offset: -1
	public AudioSourceController.State<IDType> get_GetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99E50 Offset: 0x2C99F51 VA: 0x2C99E50
	|-AudioSourceController<BGMID>.get_GetState
	|-AudioSourceController<SoundID>.get_GetState
	|-AudioSourceController<Int32Enum>.get_GetState
	|
	|-RVA: 0x2C9EE00 Offset: 0x2C9EF01 VA: 0x2C9EE00
	|-AudioSourceController<object>.get_GetState
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IDType get_EmptyValue() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.get_EmptyValue
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual void DoPlay(IDType id, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99EE0 Offset: 0x2C99FE1 VA: 0x2C99EE0
	|-AudioSourceController<BGMID>.DoPlay
	|-AudioSourceController<SoundID>.DoPlay
	|-AudioSourceController<Int32Enum>.DoPlay
	|
	|-RVA: 0x2C9EE90 Offset: 0x2C9EF91 VA: 0x2C9EE90
	|-AudioSourceController<object>.DoPlay
	*/

	// RVA: -1 Offset: -1
	public void DoPlayForTimeline(IDType id, bool isLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A160 Offset: 0x2C9A261 VA: 0x2C9A160
	|-AudioSourceController<SoundID>.DoPlayForTimeline
	|-AudioSourceController<Int32Enum>.DoPlayForTimeline
	|
	|-RVA: 0x2C9F0E0 Offset: 0x2C9F1E1 VA: 0x2C9F0E0
	|-AudioSourceController<object>.DoPlayForTimeline
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual void DoResume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A190 Offset: 0x2C9A291 VA: 0x2C9A190
	|-AudioSourceController<BGMID>.DoResume
	|-AudioSourceController<SoundID>.DoResume
	|-AudioSourceController<Int32Enum>.DoResume
	|
	|-RVA: 0x2C9F110 Offset: 0x2C9F211 VA: 0x2C9F110
	|-AudioSourceController<object>.DoResume
	*/

	// RVA: -1 Offset: -1
	public void DoFadeIn(IDType id, float fadetime = 3, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A210 Offset: 0x2C9A311 VA: 0x2C9A210
	|-AudioSourceController<BGMID>.DoFadeIn
	|-AudioSourceController<SoundID>.DoFadeIn
	|-AudioSourceController<Int32Enum>.DoFadeIn
	|
	|-RVA: 0x2C9F190 Offset: 0x2C9F291 VA: 0x2C9F190
	|-AudioSourceController<object>.DoFadeIn
	*/

	// RVA: -1 Offset: -1
	public void DoFadeOut(float fadetime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A3D0 Offset: 0x2C9A4D1 VA: 0x2C9A3D0
	|-AudioSourceController<BGMID>.DoFadeOut
	|-AudioSourceController<SoundID>.DoFadeOut
	|-AudioSourceController<Int32Enum>.DoFadeOut
	|
	|-RVA: 0x2C9F320 Offset: 0x2C9F421 VA: 0x2C9F320
	|-AudioSourceController<object>.DoFadeOut
	*/

	// RVA: -1 Offset: -1
	public void DoStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A470 Offset: 0x2C9A571 VA: 0x2C9A470
	|-AudioSourceController<BGMID>.DoStop
	|-AudioSourceController<SoundID>.DoStop
	|-AudioSourceController<Int32Enum>.DoStop
	|
	|-RVA: 0x2C9F3C0 Offset: 0x2C9F4C1 VA: 0x2C9F3C0
	|-AudioSourceController<object>.DoStop
	*/

	// RVA: -1 Offset: -1
	public void DoImmediateStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A510 Offset: 0x2C9A611 VA: 0x2C9A510
	|-AudioSourceController<BGMID>.DoImmediateStop
	|-AudioSourceController<SoundID>.DoImmediateStop
	|-AudioSourceController<Int32Enum>.DoImmediateStop
	|
	|-RVA: 0x2C9F460 Offset: 0x2C9F561 VA: 0x2C9F460
	|-AudioSourceController<object>.DoImmediateStop
	*/

	// RVA: -1 Offset: -1
	public void SetCustomRolloffCurve(AnimationCurve animationCurve) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A590 Offset: 0x2C9A691 VA: 0x2C9A590
	|-AudioSourceController<Int32Enum>.SetCustomRolloffCurve
	|
	|-RVA: 0x2C9F4E0 Offset: 0x2C9F5E1 VA: 0x2C9F4E0
	|-AudioSourceController<object>.SetCustomRolloffCurve
	*/

	// RVA: -1 Offset: -1
	public void LoadWithWait(IDType id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A670 Offset: 0x2C9A771 VA: 0x2C9A670
	|-AudioSourceController<SoundID>.LoadWithWait
	|-AudioSourceController<Int32Enum>.LoadWithWait
	|
	|-RVA: 0x2C9F5C0 Offset: 0x2C9F6C1 VA: 0x2C9F5C0
	|-AudioSourceController<object>.LoadWithWait
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract AudioMixerGroup GetOutputMixer(IDType id) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.GetOutputMixer
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void SetupBeforePlayByDataTable() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.SetupBeforePlayByDataTable
	*/

	// RVA: -1 Offset: -1
	private void NotInit_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A710 Offset: 0x2C9A811 VA: 0x2C9A710
	|-AudioSourceController<Int32Enum>.NotInit_Enter
	|
	|-RVA: 0x2C9F660 Offset: 0x2C9F761 VA: 0x2C9F660
	|-AudioSourceController<object>.NotInit_Enter
	*/

	// RVA: -1 Offset: -1
	private void Play_internal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A810 Offset: 0x2C9A911 VA: 0x2C9A810
	|-AudioSourceController<Int32Enum>.Play_internal
	|
	|-RVA: 0x2C9F760 Offset: 0x2C9F861 VA: 0x2C9F760
	|-AudioSourceController<object>.Play_internal
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void Loading_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.Loading_Enter
	*/

	// RVA: -1 Offset: -1
	protected void Loading_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9AB30 Offset: 0x2C9AC31 VA: 0x2C9AB30
	|-AudioSourceController<Int32Enum>.Loading_Update
	|
	|-RVA: 0x2C9FA80 Offset: 0x2C9FB81 VA: 0x2C9FA80
	|-AudioSourceController<object>.Loading_Update
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void Play_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9AD10 Offset: 0x2C9AE11 VA: 0x2C9AD10
	|-AudioSourceController<BGMID>.Play_Enter
	|-AudioSourceController<SoundID>.Play_Enter
	|-AudioSourceController<Int32Enum>.Play_Enter
	|
	|-RVA: 0x2C9FC60 Offset: 0x2C9FD61 VA: 0x2C9FC60
	|-AudioSourceController<object>.Play_Enter
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual void Play_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9ADF0 Offset: 0x2C9AEF1 VA: 0x2C9ADF0
	|-AudioSourceController<BGMID>.Play_Update
	|-AudioSourceController<SoundID>.Play_Update
	|-AudioSourceController<Int32Enum>.Play_Update
	|
	|-RVA: 0x2C9FD40 Offset: 0x2C9FE41 VA: 0x2C9FD40
	|-AudioSourceController<object>.Play_Update
	*/

	// RVA: -1 Offset: -1
	protected void Play_Exit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B100 Offset: 0x2C9B201 VA: 0x2C9B100
	|-AudioSourceController<Int32Enum>.Play_Exit
	|
	|-RVA: 0x2CA0050 Offset: 0x2CA0151 VA: 0x2CA0050
	|-AudioSourceController<object>.Play_Exit
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_IsLoopClip() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.get_IsLoopClip
	*/

	// RVA: -1 Offset: -1
	public bool get_IsLoopAudioSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B110 Offset: 0x2C9B211 VA: 0x2C9B110
	|-AudioSourceController<Int32Enum>.get_IsLoopAudioSource
	|
	|-RVA: 0x2CA0060 Offset: 0x2CA0161 VA: 0x2CA0060
	|-AudioSourceController<object>.get_IsLoopAudioSource
	*/

	// RVA: -1 Offset: -1
	protected void FadeIn_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B150 Offset: 0x2C9B251 VA: 0x2C9B150
	|-AudioSourceController<Int32Enum>.FadeIn_Enter
	|
	|-RVA: 0x2CA00A0 Offset: 0x2CA01A1 VA: 0x2CA00A0
	|-AudioSourceController<object>.FadeIn_Enter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	protected virtual void FadeIn_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B230 Offset: 0x2C9B331 VA: 0x2C9B230
	|-AudioSourceController<BGMID>.FadeIn_Update
	|-AudioSourceController<SoundID>.FadeIn_Update
	|-AudioSourceController<Int32Enum>.FadeIn_Update
	|
	|-RVA: 0x2CA0180 Offset: 0x2CA0281 VA: 0x2CA0180
	|-AudioSourceController<object>.FadeIn_Update
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected virtual void FadeOut_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B510 Offset: 0x2C9B611 VA: 0x2C9B510
	|-AudioSourceController<BGMID>.FadeOut_Update
	|-AudioSourceController<SoundID>.FadeOut_Update
	|-AudioSourceController<Int32Enum>.FadeOut_Update
	|
	|-RVA: 0x2CA0460 Offset: 0x2CA0561 VA: 0x2CA0460
	|-AudioSourceController<object>.FadeOut_Update
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected virtual void Done_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B780 Offset: 0x2C9B881 VA: 0x2C9B780
	|-AudioSourceController<BGMID>.Done_Enter
	|-AudioSourceController<SoundID>.Done_Enter
	|-AudioSourceController<Int32Enum>.Done_Enter
	|
	|-RVA: 0x2CA06D0 Offset: 0x2CA07D1 VA: 0x2CA06D0
	|-AudioSourceController<object>.Done_Enter
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B870 Offset: 0x2C9B971 VA: 0x2C9B870
	|-AudioSourceController<BGMID>..ctor
	|-AudioSourceController<SoundID>..ctor
	|-AudioSourceController<Int32Enum>..ctor
	|
	|-RVA: 0x2CA07C0 Offset: 0x2CA08C1 VA: 0x2CA07C0
	|-AudioSourceController<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B890 Offset: 0x2C9B991 VA: 0x2C9B890
	|-AudioSourceController<Int32Enum>..cctor
	|
	|-RVA: 0x2CA07E0 Offset: 0x2CA08E1 VA: 0x2CA07E0
	|-AudioSourceController<object>..cctor
	*/
}

public abstract class AudioSourceController<IDType> : MonoBehaviour // TypeDefIndex: 9863
{
	// Fields
	private AudioSource _AudioSource; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F900 Offset: 0x17FA01 VA: 0x17F900
	private Transform <Constraint>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F910 Offset: 0x17FA11 VA: 0x17F910
	private bool <IsConstraint>k__BackingField; // 0x0
	private IDType _CurrentID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F920 Offset: 0x17FA21 VA: 0x17F920
	private IDType <CurrentID>k__BackingField; // 0x0
	private int EntriedAssetID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F930 Offset: 0x17FA31 VA: 0x17F930
	private float <FadeTime>k__BackingField; // 0x0
	private float FadeAlpha; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F940 Offset: 0x17FA41 VA: 0x17F940
	private bool <IsPause>k__BackingField; // 0x0
	public DestroyMode DestroyMode; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F950 Offset: 0x17FA51 VA: 0x17F950
	private float <Volume>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F960 Offset: 0x17FA61 VA: 0x17F960
	private float <DataTable_Volume>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F970 Offset: 0x17FA71 VA: 0x17F970
	private int <Priority>k__BackingField; // 0x0
	private static int stateElementTableCount; // 0x0
	private AudioSourceController.Command<IDType> AfterLoad; // 0x0
	private AudioSourceController.State<IDType> InitialState; // 0x0
	private StateMachine<AudioSourceController.State<IDType>> sm; // 0x0
	private float m_PlayTime; // 0x0
	private static TransitionTables[] TransitionTables; // 0x0
	private bool IsTimeline; // 0x0
	private bool IsTimelineLoop; // 0x0
	private bool wait_first_frame; // 0x0

	// Properties
	public AudioSource AudioSource { get; set; }
	public Transform Constraint { get; set; }
	public bool IsConstraint { get; set; }
	public IDType CurrentID { get; set; }
	protected float FadeTime { get; set; }
	protected virtual AnimationCurve FadeCurve { get; }
	public bool IsPause { get; set; }
	public float Volume { get; set; }
	protected float DataTable_Volume { get; set; }
	public int Priority { get; set; }
	public float PlayTime { get; }
	public AudioSourceController.State<IDType> GetState { get; }
	public abstract IDType EmptyValue { get; }
	public abstract bool IsLoopClip { get; }
	public bool IsLoopAudioSource { get; }

	// Methods

	// RVA: -1 Offset: -1
	public AudioSource get_AudioSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C989F0 Offset: 0x2C98AF1 VA: 0x2C989F0
	|-AudioSourceController<BGMID>.get_AudioSource
	|-AudioSourceController<SoundID>.get_AudioSource
	|-AudioSourceController<Int32Enum>.get_AudioSource
	|
	|-RVA: 0x2C9D9A0 Offset: 0x2C9DAA1 VA: 0x2C9D9A0
	|-AudioSourceController<object>.get_AudioSource
	*/

	// RVA: -1 Offset: -1
	public void set_AudioSource(AudioSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AA0 Offset: 0x2C98BA1 VA: 0x2C98AA0
	|-AudioSourceController<Int32Enum>.set_AudioSource
	|
	|-RVA: 0x2C9DA50 Offset: 0x2C9DB51 VA: 0x2C9DA50
	|-AudioSourceController<object>.set_AudioSource
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD150 Offset: 0x1AD251 VA: 0x1AD150
	// RVA: -1 Offset: -1
	public Transform get_Constraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AB0 Offset: 0x2C98BB1 VA: 0x2C98AB0
	|-AudioSourceController<Int32Enum>.get_Constraint
	|
	|-RVA: 0x2C9DA60 Offset: 0x2C9DB61 VA: 0x2C9DA60
	|-AudioSourceController<object>.get_Constraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD160 Offset: 0x1AD261 VA: 0x1AD160
	// RVA: -1 Offset: -1
	public void set_Constraint(Transform value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AC0 Offset: 0x2C98BC1 VA: 0x2C98AC0
	|-AudioSourceController<SoundID>.set_Constraint
	|-AudioSourceController<Int32Enum>.set_Constraint
	|
	|-RVA: 0x2C9DA70 Offset: 0x2C9DB71 VA: 0x2C9DA70
	|-AudioSourceController<object>.set_Constraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD170 Offset: 0x1AD271 VA: 0x1AD170
	// RVA: -1 Offset: -1
	public bool get_IsConstraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AD0 Offset: 0x2C98BD1 VA: 0x2C98AD0
	|-AudioSourceController<Int32Enum>.get_IsConstraint
	|
	|-RVA: 0x2C9DA80 Offset: 0x2C9DB81 VA: 0x2C9DA80
	|-AudioSourceController<object>.get_IsConstraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD180 Offset: 0x1AD281 VA: 0x1AD180
	// RVA: -1 Offset: -1
	public void set_IsConstraint(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AE0 Offset: 0x2C98BE1 VA: 0x2C98AE0
	|-AudioSourceController<SoundID>.set_IsConstraint
	|-AudioSourceController<Int32Enum>.set_IsConstraint
	|
	|-RVA: 0x2C9DA90 Offset: 0x2C9DB91 VA: 0x2C9DA90
	|-AudioSourceController<object>.set_IsConstraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD190 Offset: 0x1AD291 VA: 0x1AD190
	// RVA: -1 Offset: -1
	public IDType get_CurrentID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AF0 Offset: 0x2C98BF1 VA: 0x2C98AF0
	|-AudioSourceController<BGMID>.get_CurrentID
	|-AudioSourceController<SoundID>.get_CurrentID
	|-AudioSourceController<Int32Enum>.get_CurrentID
	|
	|-RVA: 0x2C9DAA0 Offset: 0x2C9DBA1 VA: 0x2C9DAA0
	|-AudioSourceController<object>.get_CurrentID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1A0 Offset: 0x1AD2A1 VA: 0x1AD1A0
	// RVA: -1 Offset: -1
	public void set_CurrentID(IDType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98B00 Offset: 0x2C98C01 VA: 0x2C98B00
	|-AudioSourceController<SoundID>.set_CurrentID
	|-AudioSourceController<Int32Enum>.set_CurrentID
	|
	|-RVA: 0x2C9DAB0 Offset: 0x2C9DBB1 VA: 0x2C9DAB0
	|-AudioSourceController<object>.set_CurrentID
	*/

	// RVA: -1 Offset: -1
	protected void SetAssetID(Audio id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98B10 Offset: 0x2C98C11 VA: 0x2C98B10
	|-AudioSourceController<BGMID>.SetAssetID
	|-AudioSourceController<SoundID>.SetAssetID
	|-AudioSourceController<Int32Enum>.SetAssetID
	|
	|-RVA: 0x2C9DAC0 Offset: 0x2C9DBC1 VA: 0x2C9DAC0
	|-AudioSourceController<object>.SetAssetID
	*/

	// RVA: -1 Offset: -1
	private bool RemoveAssetID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98BF0 Offset: 0x2C98CF1 VA: 0x2C98BF0
	|-AudioSourceController<Int32Enum>.RemoveAssetID
	|
	|-RVA: 0x2C9DBA0 Offset: 0x2C9DCA1 VA: 0x2C9DBA0
	|-AudioSourceController<object>.RemoveAssetID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1B0 Offset: 0x1AD2B1 VA: 0x1AD1B0
	// RVA: -1 Offset: -1
	protected float get_FadeTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98C80 Offset: 0x2C98D81 VA: 0x2C98C80
	|-AudioSourceController<Int32Enum>.get_FadeTime
	|
	|-RVA: 0x2C9DC30 Offset: 0x2C9DD31 VA: 0x2C9DC30
	|-AudioSourceController<object>.get_FadeTime
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1C0 Offset: 0x1AD2C1 VA: 0x1AD1C0
	// RVA: -1 Offset: -1
	protected void set_FadeTime(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98C90 Offset: 0x2C98D91 VA: 0x2C98C90
	|-AudioSourceController<Int32Enum>.set_FadeTime
	|
	|-RVA: 0x2C9DC40 Offset: 0x2C9DD41 VA: 0x2C9DC40
	|-AudioSourceController<object>.set_FadeTime
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual AnimationCurve get_FadeCurve() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98CA0 Offset: 0x2C98DA1 VA: 0x2C98CA0
	|-AudioSourceController<BGMID>.get_FadeCurve
	|-AudioSourceController<SoundID>.get_FadeCurve
	|-AudioSourceController<Int32Enum>.get_FadeCurve
	|
	|-RVA: 0x2C9DC50 Offset: 0x2C9DD51 VA: 0x2C9DC50
	|-AudioSourceController<object>.get_FadeCurve
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1D0 Offset: 0x1AD2D1 VA: 0x1AD1D0
	// RVA: -1 Offset: -1
	public bool get_IsPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D00 Offset: 0x2C98E01 VA: 0x2C98D00
	|-AudioSourceController<Int32Enum>.get_IsPause
	|
	|-RVA: 0x2C9DCB0 Offset: 0x2C9DDB1 VA: 0x2C9DCB0
	|-AudioSourceController<object>.get_IsPause
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1E0 Offset: 0x1AD2E1 VA: 0x1AD1E0
	// RVA: -1 Offset: -1
	protected void set_IsPause(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D10 Offset: 0x2C98E11 VA: 0x2C98D10
	|-AudioSourceController<Int32Enum>.set_IsPause
	|
	|-RVA: 0x2C9DCC0 Offset: 0x2C9DDC1 VA: 0x2C9DCC0
	|-AudioSourceController<object>.set_IsPause
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1F0 Offset: 0x1AD2F1 VA: 0x1AD1F0
	// RVA: -1 Offset: -1
	public float get_Volume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D20 Offset: 0x2C98E21 VA: 0x2C98D20
	|-AudioSourceController<Int32Enum>.get_Volume
	|
	|-RVA: 0x2C9DCD0 Offset: 0x2C9DDD1 VA: 0x2C9DCD0
	|-AudioSourceController<object>.get_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD200 Offset: 0x1AD301 VA: 0x1AD200
	// RVA: -1 Offset: -1
	public void set_Volume(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D30 Offset: 0x2C98E31 VA: 0x2C98D30
	|-AudioSourceController<SoundID>.set_Volume
	|-AudioSourceController<Int32Enum>.set_Volume
	|
	|-RVA: 0x2C9DCE0 Offset: 0x2C9DDE1 VA: 0x2C9DCE0
	|-AudioSourceController<object>.set_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD210 Offset: 0x1AD311 VA: 0x1AD210
	// RVA: -1 Offset: -1
	protected float get_DataTable_Volume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D40 Offset: 0x2C98E41 VA: 0x2C98D40
	|-AudioSourceController<Int32Enum>.get_DataTable_Volume
	|
	|-RVA: 0x2C9DCF0 Offset: 0x2C9DDF1 VA: 0x2C9DCF0
	|-AudioSourceController<object>.get_DataTable_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD220 Offset: 0x1AD321 VA: 0x1AD220
	// RVA: -1 Offset: -1
	protected void set_DataTable_Volume(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D50 Offset: 0x2C98E51 VA: 0x2C98D50
	|-AudioSourceController<SoundID>.set_DataTable_Volume
	|-AudioSourceController<Int32Enum>.set_DataTable_Volume
	|
	|-RVA: 0x2C9DD00 Offset: 0x2C9DE01 VA: 0x2C9DD00
	|-AudioSourceController<object>.set_DataTable_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD230 Offset: 0x1AD331 VA: 0x1AD230
	// RVA: -1 Offset: -1
	public int get_Priority() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D60 Offset: 0x2C98E61 VA: 0x2C98D60
	|-AudioSourceController<BGMID>.get_Priority
	|-AudioSourceController<SoundID>.get_Priority
	|-AudioSourceController<Int32Enum>.get_Priority
	|
	|-RVA: 0x2C9DD10 Offset: 0x2C9DE11 VA: 0x2C9DD10
	|-AudioSourceController<object>.get_Priority
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD240 Offset: 0x1AD341 VA: 0x1AD240
	// RVA: -1 Offset: -1
	private void set_Priority(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D70 Offset: 0x2C98E71 VA: 0x2C98D70
	|-AudioSourceController<Int32Enum>.set_Priority
	|
	|-RVA: 0x2C9DD20 Offset: 0x2C9DE21 VA: 0x2C9DD20
	|-AudioSourceController<object>.set_Priority
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual AudioSource ReadyAudioSourceComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D80 Offset: 0x2C98E81 VA: 0x2C98D80
	|-AudioSourceController<BGMID>.ReadyAudioSourceComponent
	|-AudioSourceController<SoundID>.ReadyAudioSourceComponent
	|-AudioSourceController<Int32Enum>.ReadyAudioSourceComponent
	|
	|-RVA: 0x2C9DD30 Offset: 0x2C9DE31 VA: 0x2C9DD30
	|-AudioSourceController<object>.ReadyAudioSourceComponent
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98DF0 Offset: 0x2C98EF1 VA: 0x2C98DF0
	|-AudioSourceController<BGMID>.Awake
	|-AudioSourceController<SoundID>.Awake
	|-AudioSourceController<Int32Enum>.Awake
	|
	|-RVA: 0x2C9DDA0 Offset: 0x2C9DEA1 VA: 0x2C9DDA0
	|-AudioSourceController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99550 Offset: 0x2C99651 VA: 0x2C99550
	|-AudioSourceController<BGMID>.OnDestroy
	|-AudioSourceController<SoundID>.OnDestroy
	|-AudioSourceController<Int32Enum>.OnDestroy
	|
	|-RVA: 0x2C9E500 Offset: 0x2C9E601 VA: 0x2C9E500
	|-AudioSourceController<object>.OnDestroy
	*/

	// RVA: -1 Offset: -1
	public float get_PlayTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99580 Offset: 0x2C99681 VA: 0x2C99580
	|-AudioSourceController<Int32Enum>.get_PlayTime
	|
	|-RVA: 0x2C9E530 Offset: 0x2C9E631 VA: 0x2C9E530
	|-AudioSourceController<object>.get_PlayTime
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual void ResetByRemoveAllResources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C995D0 Offset: 0x2C996D1 VA: 0x2C995D0
	|-AudioSourceController<BGMID>.ResetByRemoveAllResources
	|-AudioSourceController<SoundID>.ResetByRemoveAllResources
	|-AudioSourceController<Int32Enum>.ResetByRemoveAllResources
	|
	|-RVA: 0x2C9E580 Offset: 0x2C9E681 VA: 0x2C9E580
	|-AudioSourceController<object>.ResetByRemoveAllResources
	*/

	// RVA: -1 Offset: -1
	private bool UpdateConstraintPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99730 Offset: 0x2C99831 VA: 0x2C99730
	|-AudioSourceController<Int32Enum>.UpdateConstraintPosition
	|
	|-RVA: 0x2C9E6E0 Offset: 0x2C9E7E1 VA: 0x2C9E6E0
	|-AudioSourceController<object>.UpdateConstraintPosition
	*/

	// RVA: -1 Offset: -1
	public void Pause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99830 Offset: 0x2C99931 VA: 0x2C99830
	|-AudioSourceController<BGMID>.Pause
	|-AudioSourceController<SoundID>.Pause
	|-AudioSourceController<Int32Enum>.Pause
	|
	|-RVA: 0x2C9E7E0 Offset: 0x2C9E8E1 VA: 0x2C9E7E0
	|-AudioSourceController<object>.Pause
	*/

	// RVA: -1 Offset: -1
	public void UnPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99990 Offset: 0x2C99A91 VA: 0x2C99990
	|-AudioSourceController<BGMID>.UnPause
	|-AudioSourceController<SoundID>.UnPause
	|-AudioSourceController<Int32Enum>.UnPause
	|
	|-RVA: 0x2C9E940 Offset: 0x2C9EA41 VA: 0x2C9E940
	|-AudioSourceController<object>.UnPause
	*/

	// RVA: -1 Offset: -1
	public bool IsPlaying() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99A80 Offset: 0x2C99B81 VA: 0x2C99A80
	|-AudioSourceController<SoundID>.IsPlaying
	|-AudioSourceController<Int32Enum>.IsPlaying
	|
	|-RVA: 0x2C9EA30 Offset: 0x2C9EB31 VA: 0x2C9EA30
	|-AudioSourceController<object>.IsPlaying
	*/

	// RVA: -1 Offset: -1
	public bool IsDoneLoad() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99C70 Offset: 0x2C99D71 VA: 0x2C99C70
	|-AudioSourceController<SoundID>.IsDoneLoad
	|-AudioSourceController<Int32Enum>.IsDoneLoad
	|
	|-RVA: 0x2C9EC20 Offset: 0x2C9ED21 VA: 0x2C9EC20
	|-AudioSourceController<object>.IsDoneLoad
	*/

	// RVA: -1 Offset: -1
	public AudioSourceController.State<IDType> get_GetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99E50 Offset: 0x2C99F51 VA: 0x2C99E50
	|-AudioSourceController<BGMID>.get_GetState
	|-AudioSourceController<SoundID>.get_GetState
	|-AudioSourceController<Int32Enum>.get_GetState
	|
	|-RVA: 0x2C9EE00 Offset: 0x2C9EF01 VA: 0x2C9EE00
	|-AudioSourceController<object>.get_GetState
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IDType get_EmptyValue() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.get_EmptyValue
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual void DoPlay(IDType id, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99EE0 Offset: 0x2C99FE1 VA: 0x2C99EE0
	|-AudioSourceController<BGMID>.DoPlay
	|-AudioSourceController<SoundID>.DoPlay
	|-AudioSourceController<Int32Enum>.DoPlay
	|
	|-RVA: 0x2C9EE90 Offset: 0x2C9EF91 VA: 0x2C9EE90
	|-AudioSourceController<object>.DoPlay
	*/

	// RVA: -1 Offset: -1
	public void DoPlayForTimeline(IDType id, bool isLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A160 Offset: 0x2C9A261 VA: 0x2C9A160
	|-AudioSourceController<SoundID>.DoPlayForTimeline
	|-AudioSourceController<Int32Enum>.DoPlayForTimeline
	|
	|-RVA: 0x2C9F0E0 Offset: 0x2C9F1E1 VA: 0x2C9F0E0
	|-AudioSourceController<object>.DoPlayForTimeline
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual void DoResume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A190 Offset: 0x2C9A291 VA: 0x2C9A190
	|-AudioSourceController<BGMID>.DoResume
	|-AudioSourceController<SoundID>.DoResume
	|-AudioSourceController<Int32Enum>.DoResume
	|
	|-RVA: 0x2C9F110 Offset: 0x2C9F211 VA: 0x2C9F110
	|-AudioSourceController<object>.DoResume
	*/

	// RVA: -1 Offset: -1
	public void DoFadeIn(IDType id, float fadetime = 3, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A210 Offset: 0x2C9A311 VA: 0x2C9A210
	|-AudioSourceController<BGMID>.DoFadeIn
	|-AudioSourceController<SoundID>.DoFadeIn
	|-AudioSourceController<Int32Enum>.DoFadeIn
	|
	|-RVA: 0x2C9F190 Offset: 0x2C9F291 VA: 0x2C9F190
	|-AudioSourceController<object>.DoFadeIn
	*/

	// RVA: -1 Offset: -1
	public void DoFadeOut(float fadetime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A3D0 Offset: 0x2C9A4D1 VA: 0x2C9A3D0
	|-AudioSourceController<BGMID>.DoFadeOut
	|-AudioSourceController<SoundID>.DoFadeOut
	|-AudioSourceController<Int32Enum>.DoFadeOut
	|
	|-RVA: 0x2C9F320 Offset: 0x2C9F421 VA: 0x2C9F320
	|-AudioSourceController<object>.DoFadeOut
	*/

	// RVA: -1 Offset: -1
	public void DoStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A470 Offset: 0x2C9A571 VA: 0x2C9A470
	|-AudioSourceController<BGMID>.DoStop
	|-AudioSourceController<SoundID>.DoStop
	|-AudioSourceController<Int32Enum>.DoStop
	|
	|-RVA: 0x2C9F3C0 Offset: 0x2C9F4C1 VA: 0x2C9F3C0
	|-AudioSourceController<object>.DoStop
	*/

	// RVA: -1 Offset: -1
	public void DoImmediateStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A510 Offset: 0x2C9A611 VA: 0x2C9A510
	|-AudioSourceController<BGMID>.DoImmediateStop
	|-AudioSourceController<SoundID>.DoImmediateStop
	|-AudioSourceController<Int32Enum>.DoImmediateStop
	|
	|-RVA: 0x2C9F460 Offset: 0x2C9F561 VA: 0x2C9F460
	|-AudioSourceController<object>.DoImmediateStop
	*/

	// RVA: -1 Offset: -1
	public void SetCustomRolloffCurve(AnimationCurve animationCurve) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A590 Offset: 0x2C9A691 VA: 0x2C9A590
	|-AudioSourceController<Int32Enum>.SetCustomRolloffCurve
	|
	|-RVA: 0x2C9F4E0 Offset: 0x2C9F5E1 VA: 0x2C9F4E0
	|-AudioSourceController<object>.SetCustomRolloffCurve
	*/

	// RVA: -1 Offset: -1
	public void LoadWithWait(IDType id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A670 Offset: 0x2C9A771 VA: 0x2C9A670
	|-AudioSourceController<SoundID>.LoadWithWait
	|-AudioSourceController<Int32Enum>.LoadWithWait
	|
	|-RVA: 0x2C9F5C0 Offset: 0x2C9F6C1 VA: 0x2C9F5C0
	|-AudioSourceController<object>.LoadWithWait
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract AudioMixerGroup GetOutputMixer(IDType id) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.GetOutputMixer
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void SetupBeforePlayByDataTable() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.SetupBeforePlayByDataTable
	*/

	// RVA: -1 Offset: -1
	private void NotInit_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A710 Offset: 0x2C9A811 VA: 0x2C9A710
	|-AudioSourceController<Int32Enum>.NotInit_Enter
	|
	|-RVA: 0x2C9F660 Offset: 0x2C9F761 VA: 0x2C9F660
	|-AudioSourceController<object>.NotInit_Enter
	*/

	// RVA: -1 Offset: -1
	private void Play_internal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A810 Offset: 0x2C9A911 VA: 0x2C9A810
	|-AudioSourceController<Int32Enum>.Play_internal
	|
	|-RVA: 0x2C9F760 Offset: 0x2C9F861 VA: 0x2C9F760
	|-AudioSourceController<object>.Play_internal
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void Loading_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.Loading_Enter
	*/

	// RVA: -1 Offset: -1
	protected void Loading_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9AB30 Offset: 0x2C9AC31 VA: 0x2C9AB30
	|-AudioSourceController<Int32Enum>.Loading_Update
	|
	|-RVA: 0x2C9FA80 Offset: 0x2C9FB81 VA: 0x2C9FA80
	|-AudioSourceController<object>.Loading_Update
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void Play_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9AD10 Offset: 0x2C9AE11 VA: 0x2C9AD10
	|-AudioSourceController<BGMID>.Play_Enter
	|-AudioSourceController<SoundID>.Play_Enter
	|-AudioSourceController<Int32Enum>.Play_Enter
	|
	|-RVA: 0x2C9FC60 Offset: 0x2C9FD61 VA: 0x2C9FC60
	|-AudioSourceController<object>.Play_Enter
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual void Play_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9ADF0 Offset: 0x2C9AEF1 VA: 0x2C9ADF0
	|-AudioSourceController<BGMID>.Play_Update
	|-AudioSourceController<SoundID>.Play_Update
	|-AudioSourceController<Int32Enum>.Play_Update
	|
	|-RVA: 0x2C9FD40 Offset: 0x2C9FE41 VA: 0x2C9FD40
	|-AudioSourceController<object>.Play_Update
	*/

	// RVA: -1 Offset: -1
	protected void Play_Exit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B100 Offset: 0x2C9B201 VA: 0x2C9B100
	|-AudioSourceController<Int32Enum>.Play_Exit
	|
	|-RVA: 0x2CA0050 Offset: 0x2CA0151 VA: 0x2CA0050
	|-AudioSourceController<object>.Play_Exit
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_IsLoopClip() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.get_IsLoopClip
	*/

	// RVA: -1 Offset: -1
	public bool get_IsLoopAudioSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B110 Offset: 0x2C9B211 VA: 0x2C9B110
	|-AudioSourceController<Int32Enum>.get_IsLoopAudioSource
	|
	|-RVA: 0x2CA0060 Offset: 0x2CA0161 VA: 0x2CA0060
	|-AudioSourceController<object>.get_IsLoopAudioSource
	*/

	// RVA: -1 Offset: -1
	protected void FadeIn_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B150 Offset: 0x2C9B251 VA: 0x2C9B150
	|-AudioSourceController<Int32Enum>.FadeIn_Enter
	|
	|-RVA: 0x2CA00A0 Offset: 0x2CA01A1 VA: 0x2CA00A0
	|-AudioSourceController<object>.FadeIn_Enter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	protected virtual void FadeIn_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B230 Offset: 0x2C9B331 VA: 0x2C9B230
	|-AudioSourceController<BGMID>.FadeIn_Update
	|-AudioSourceController<SoundID>.FadeIn_Update
	|-AudioSourceController<Int32Enum>.FadeIn_Update
	|
	|-RVA: 0x2CA0180 Offset: 0x2CA0281 VA: 0x2CA0180
	|-AudioSourceController<object>.FadeIn_Update
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected virtual void FadeOut_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B510 Offset: 0x2C9B611 VA: 0x2C9B510
	|-AudioSourceController<BGMID>.FadeOut_Update
	|-AudioSourceController<SoundID>.FadeOut_Update
	|-AudioSourceController<Int32Enum>.FadeOut_Update
	|
	|-RVA: 0x2CA0460 Offset: 0x2CA0561 VA: 0x2CA0460
	|-AudioSourceController<object>.FadeOut_Update
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected virtual void Done_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B780 Offset: 0x2C9B881 VA: 0x2C9B780
	|-AudioSourceController<BGMID>.Done_Enter
	|-AudioSourceController<SoundID>.Done_Enter
	|-AudioSourceController<Int32Enum>.Done_Enter
	|
	|-RVA: 0x2CA06D0 Offset: 0x2CA07D1 VA: 0x2CA06D0
	|-AudioSourceController<object>.Done_Enter
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B870 Offset: 0x2C9B971 VA: 0x2C9B870
	|-AudioSourceController<BGMID>..ctor
	|-AudioSourceController<SoundID>..ctor
	|-AudioSourceController<Int32Enum>..ctor
	|
	|-RVA: 0x2CA07C0 Offset: 0x2CA08C1 VA: 0x2CA07C0
	|-AudioSourceController<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B890 Offset: 0x2C9B991 VA: 0x2C9B890
	|-AudioSourceController<Int32Enum>..cctor
	|
	|-RVA: 0x2CA07E0 Offset: 0x2CA08E1 VA: 0x2CA07E0
	|-AudioSourceController<object>..cctor
	*/
}

public abstract class AudioSourceController<IDType> : MonoBehaviour // TypeDefIndex: 9863
{
	// Fields
	private AudioSource _AudioSource; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F900 Offset: 0x17FA01 VA: 0x17F900
	private Transform <Constraint>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F910 Offset: 0x17FA11 VA: 0x17F910
	private bool <IsConstraint>k__BackingField; // 0x0
	private IDType _CurrentID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F920 Offset: 0x17FA21 VA: 0x17F920
	private IDType <CurrentID>k__BackingField; // 0x0
	private int EntriedAssetID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F930 Offset: 0x17FA31 VA: 0x17F930
	private float <FadeTime>k__BackingField; // 0x0
	private float FadeAlpha; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F940 Offset: 0x17FA41 VA: 0x17F940
	private bool <IsPause>k__BackingField; // 0x0
	public DestroyMode DestroyMode; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F950 Offset: 0x17FA51 VA: 0x17F950
	private float <Volume>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F960 Offset: 0x17FA61 VA: 0x17F960
	private float <DataTable_Volume>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F970 Offset: 0x17FA71 VA: 0x17F970
	private int <Priority>k__BackingField; // 0x0
	private static int stateElementTableCount; // 0x0
	private AudioSourceController.Command<IDType> AfterLoad; // 0x0
	private AudioSourceController.State<IDType> InitialState; // 0x0
	private StateMachine<AudioSourceController.State<IDType>> sm; // 0x0
	private float m_PlayTime; // 0x0
	private static TransitionTables[] TransitionTables; // 0x0
	private bool IsTimeline; // 0x0
	private bool IsTimelineLoop; // 0x0
	private bool wait_first_frame; // 0x0

	// Properties
	public AudioSource AudioSource { get; set; }
	public Transform Constraint { get; set; }
	public bool IsConstraint { get; set; }
	public IDType CurrentID { get; set; }
	protected float FadeTime { get; set; }
	protected virtual AnimationCurve FadeCurve { get; }
	public bool IsPause { get; set; }
	public float Volume { get; set; }
	protected float DataTable_Volume { get; set; }
	public int Priority { get; set; }
	public float PlayTime { get; }
	public AudioSourceController.State<IDType> GetState { get; }
	public abstract IDType EmptyValue { get; }
	public abstract bool IsLoopClip { get; }
	public bool IsLoopAudioSource { get; }

	// Methods

	// RVA: -1 Offset: -1
	public AudioSource get_AudioSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C989F0 Offset: 0x2C98AF1 VA: 0x2C989F0
	|-AudioSourceController<BGMID>.get_AudioSource
	|-AudioSourceController<SoundID>.get_AudioSource
	|-AudioSourceController<Int32Enum>.get_AudioSource
	|
	|-RVA: 0x2C9D9A0 Offset: 0x2C9DAA1 VA: 0x2C9D9A0
	|-AudioSourceController<object>.get_AudioSource
	*/

	// RVA: -1 Offset: -1
	public void set_AudioSource(AudioSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AA0 Offset: 0x2C98BA1 VA: 0x2C98AA0
	|-AudioSourceController<Int32Enum>.set_AudioSource
	|
	|-RVA: 0x2C9DA50 Offset: 0x2C9DB51 VA: 0x2C9DA50
	|-AudioSourceController<object>.set_AudioSource
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD150 Offset: 0x1AD251 VA: 0x1AD150
	// RVA: -1 Offset: -1
	public Transform get_Constraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AB0 Offset: 0x2C98BB1 VA: 0x2C98AB0
	|-AudioSourceController<Int32Enum>.get_Constraint
	|
	|-RVA: 0x2C9DA60 Offset: 0x2C9DB61 VA: 0x2C9DA60
	|-AudioSourceController<object>.get_Constraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD160 Offset: 0x1AD261 VA: 0x1AD160
	// RVA: -1 Offset: -1
	public void set_Constraint(Transform value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AC0 Offset: 0x2C98BC1 VA: 0x2C98AC0
	|-AudioSourceController<SoundID>.set_Constraint
	|-AudioSourceController<Int32Enum>.set_Constraint
	|
	|-RVA: 0x2C9DA70 Offset: 0x2C9DB71 VA: 0x2C9DA70
	|-AudioSourceController<object>.set_Constraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD170 Offset: 0x1AD271 VA: 0x1AD170
	// RVA: -1 Offset: -1
	public bool get_IsConstraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AD0 Offset: 0x2C98BD1 VA: 0x2C98AD0
	|-AudioSourceController<Int32Enum>.get_IsConstraint
	|
	|-RVA: 0x2C9DA80 Offset: 0x2C9DB81 VA: 0x2C9DA80
	|-AudioSourceController<object>.get_IsConstraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD180 Offset: 0x1AD281 VA: 0x1AD180
	// RVA: -1 Offset: -1
	public void set_IsConstraint(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AE0 Offset: 0x2C98BE1 VA: 0x2C98AE0
	|-AudioSourceController<SoundID>.set_IsConstraint
	|-AudioSourceController<Int32Enum>.set_IsConstraint
	|
	|-RVA: 0x2C9DA90 Offset: 0x2C9DB91 VA: 0x2C9DA90
	|-AudioSourceController<object>.set_IsConstraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD190 Offset: 0x1AD291 VA: 0x1AD190
	// RVA: -1 Offset: -1
	public IDType get_CurrentID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AF0 Offset: 0x2C98BF1 VA: 0x2C98AF0
	|-AudioSourceController<BGMID>.get_CurrentID
	|-AudioSourceController<SoundID>.get_CurrentID
	|-AudioSourceController<Int32Enum>.get_CurrentID
	|
	|-RVA: 0x2C9DAA0 Offset: 0x2C9DBA1 VA: 0x2C9DAA0
	|-AudioSourceController<object>.get_CurrentID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1A0 Offset: 0x1AD2A1 VA: 0x1AD1A0
	// RVA: -1 Offset: -1
	public void set_CurrentID(IDType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98B00 Offset: 0x2C98C01 VA: 0x2C98B00
	|-AudioSourceController<SoundID>.set_CurrentID
	|-AudioSourceController<Int32Enum>.set_CurrentID
	|
	|-RVA: 0x2C9DAB0 Offset: 0x2C9DBB1 VA: 0x2C9DAB0
	|-AudioSourceController<object>.set_CurrentID
	*/

	// RVA: -1 Offset: -1
	protected void SetAssetID(Audio id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98B10 Offset: 0x2C98C11 VA: 0x2C98B10
	|-AudioSourceController<BGMID>.SetAssetID
	|-AudioSourceController<SoundID>.SetAssetID
	|-AudioSourceController<Int32Enum>.SetAssetID
	|
	|-RVA: 0x2C9DAC0 Offset: 0x2C9DBC1 VA: 0x2C9DAC0
	|-AudioSourceController<object>.SetAssetID
	*/

	// RVA: -1 Offset: -1
	private bool RemoveAssetID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98BF0 Offset: 0x2C98CF1 VA: 0x2C98BF0
	|-AudioSourceController<Int32Enum>.RemoveAssetID
	|
	|-RVA: 0x2C9DBA0 Offset: 0x2C9DCA1 VA: 0x2C9DBA0
	|-AudioSourceController<object>.RemoveAssetID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1B0 Offset: 0x1AD2B1 VA: 0x1AD1B0
	// RVA: -1 Offset: -1
	protected float get_FadeTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98C80 Offset: 0x2C98D81 VA: 0x2C98C80
	|-AudioSourceController<Int32Enum>.get_FadeTime
	|
	|-RVA: 0x2C9DC30 Offset: 0x2C9DD31 VA: 0x2C9DC30
	|-AudioSourceController<object>.get_FadeTime
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1C0 Offset: 0x1AD2C1 VA: 0x1AD1C0
	// RVA: -1 Offset: -1
	protected void set_FadeTime(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98C90 Offset: 0x2C98D91 VA: 0x2C98C90
	|-AudioSourceController<Int32Enum>.set_FadeTime
	|
	|-RVA: 0x2C9DC40 Offset: 0x2C9DD41 VA: 0x2C9DC40
	|-AudioSourceController<object>.set_FadeTime
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual AnimationCurve get_FadeCurve() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98CA0 Offset: 0x2C98DA1 VA: 0x2C98CA0
	|-AudioSourceController<BGMID>.get_FadeCurve
	|-AudioSourceController<SoundID>.get_FadeCurve
	|-AudioSourceController<Int32Enum>.get_FadeCurve
	|
	|-RVA: 0x2C9DC50 Offset: 0x2C9DD51 VA: 0x2C9DC50
	|-AudioSourceController<object>.get_FadeCurve
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1D0 Offset: 0x1AD2D1 VA: 0x1AD1D0
	// RVA: -1 Offset: -1
	public bool get_IsPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D00 Offset: 0x2C98E01 VA: 0x2C98D00
	|-AudioSourceController<Int32Enum>.get_IsPause
	|
	|-RVA: 0x2C9DCB0 Offset: 0x2C9DDB1 VA: 0x2C9DCB0
	|-AudioSourceController<object>.get_IsPause
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1E0 Offset: 0x1AD2E1 VA: 0x1AD1E0
	// RVA: -1 Offset: -1
	protected void set_IsPause(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D10 Offset: 0x2C98E11 VA: 0x2C98D10
	|-AudioSourceController<Int32Enum>.set_IsPause
	|
	|-RVA: 0x2C9DCC0 Offset: 0x2C9DDC1 VA: 0x2C9DCC0
	|-AudioSourceController<object>.set_IsPause
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1F0 Offset: 0x1AD2F1 VA: 0x1AD1F0
	// RVA: -1 Offset: -1
	public float get_Volume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D20 Offset: 0x2C98E21 VA: 0x2C98D20
	|-AudioSourceController<Int32Enum>.get_Volume
	|
	|-RVA: 0x2C9DCD0 Offset: 0x2C9DDD1 VA: 0x2C9DCD0
	|-AudioSourceController<object>.get_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD200 Offset: 0x1AD301 VA: 0x1AD200
	// RVA: -1 Offset: -1
	public void set_Volume(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D30 Offset: 0x2C98E31 VA: 0x2C98D30
	|-AudioSourceController<SoundID>.set_Volume
	|-AudioSourceController<Int32Enum>.set_Volume
	|
	|-RVA: 0x2C9DCE0 Offset: 0x2C9DDE1 VA: 0x2C9DCE0
	|-AudioSourceController<object>.set_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD210 Offset: 0x1AD311 VA: 0x1AD210
	// RVA: -1 Offset: -1
	protected float get_DataTable_Volume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D40 Offset: 0x2C98E41 VA: 0x2C98D40
	|-AudioSourceController<Int32Enum>.get_DataTable_Volume
	|
	|-RVA: 0x2C9DCF0 Offset: 0x2C9DDF1 VA: 0x2C9DCF0
	|-AudioSourceController<object>.get_DataTable_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD220 Offset: 0x1AD321 VA: 0x1AD220
	// RVA: -1 Offset: -1
	protected void set_DataTable_Volume(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D50 Offset: 0x2C98E51 VA: 0x2C98D50
	|-AudioSourceController<SoundID>.set_DataTable_Volume
	|-AudioSourceController<Int32Enum>.set_DataTable_Volume
	|
	|-RVA: 0x2C9DD00 Offset: 0x2C9DE01 VA: 0x2C9DD00
	|-AudioSourceController<object>.set_DataTable_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD230 Offset: 0x1AD331 VA: 0x1AD230
	// RVA: -1 Offset: -1
	public int get_Priority() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D60 Offset: 0x2C98E61 VA: 0x2C98D60
	|-AudioSourceController<BGMID>.get_Priority
	|-AudioSourceController<SoundID>.get_Priority
	|-AudioSourceController<Int32Enum>.get_Priority
	|
	|-RVA: 0x2C9DD10 Offset: 0x2C9DE11 VA: 0x2C9DD10
	|-AudioSourceController<object>.get_Priority
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD240 Offset: 0x1AD341 VA: 0x1AD240
	// RVA: -1 Offset: -1
	private void set_Priority(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D70 Offset: 0x2C98E71 VA: 0x2C98D70
	|-AudioSourceController<Int32Enum>.set_Priority
	|
	|-RVA: 0x2C9DD20 Offset: 0x2C9DE21 VA: 0x2C9DD20
	|-AudioSourceController<object>.set_Priority
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual AudioSource ReadyAudioSourceComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D80 Offset: 0x2C98E81 VA: 0x2C98D80
	|-AudioSourceController<BGMID>.ReadyAudioSourceComponent
	|-AudioSourceController<SoundID>.ReadyAudioSourceComponent
	|-AudioSourceController<Int32Enum>.ReadyAudioSourceComponent
	|
	|-RVA: 0x2C9DD30 Offset: 0x2C9DE31 VA: 0x2C9DD30
	|-AudioSourceController<object>.ReadyAudioSourceComponent
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98DF0 Offset: 0x2C98EF1 VA: 0x2C98DF0
	|-AudioSourceController<BGMID>.Awake
	|-AudioSourceController<SoundID>.Awake
	|-AudioSourceController<Int32Enum>.Awake
	|
	|-RVA: 0x2C9DDA0 Offset: 0x2C9DEA1 VA: 0x2C9DDA0
	|-AudioSourceController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99550 Offset: 0x2C99651 VA: 0x2C99550
	|-AudioSourceController<BGMID>.OnDestroy
	|-AudioSourceController<SoundID>.OnDestroy
	|-AudioSourceController<Int32Enum>.OnDestroy
	|
	|-RVA: 0x2C9E500 Offset: 0x2C9E601 VA: 0x2C9E500
	|-AudioSourceController<object>.OnDestroy
	*/

	// RVA: -1 Offset: -1
	public float get_PlayTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99580 Offset: 0x2C99681 VA: 0x2C99580
	|-AudioSourceController<Int32Enum>.get_PlayTime
	|
	|-RVA: 0x2C9E530 Offset: 0x2C9E631 VA: 0x2C9E530
	|-AudioSourceController<object>.get_PlayTime
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual void ResetByRemoveAllResources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C995D0 Offset: 0x2C996D1 VA: 0x2C995D0
	|-AudioSourceController<BGMID>.ResetByRemoveAllResources
	|-AudioSourceController<SoundID>.ResetByRemoveAllResources
	|-AudioSourceController<Int32Enum>.ResetByRemoveAllResources
	|
	|-RVA: 0x2C9E580 Offset: 0x2C9E681 VA: 0x2C9E580
	|-AudioSourceController<object>.ResetByRemoveAllResources
	*/

	// RVA: -1 Offset: -1
	private bool UpdateConstraintPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99730 Offset: 0x2C99831 VA: 0x2C99730
	|-AudioSourceController<Int32Enum>.UpdateConstraintPosition
	|
	|-RVA: 0x2C9E6E0 Offset: 0x2C9E7E1 VA: 0x2C9E6E0
	|-AudioSourceController<object>.UpdateConstraintPosition
	*/

	// RVA: -1 Offset: -1
	public void Pause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99830 Offset: 0x2C99931 VA: 0x2C99830
	|-AudioSourceController<BGMID>.Pause
	|-AudioSourceController<SoundID>.Pause
	|-AudioSourceController<Int32Enum>.Pause
	|
	|-RVA: 0x2C9E7E0 Offset: 0x2C9E8E1 VA: 0x2C9E7E0
	|-AudioSourceController<object>.Pause
	*/

	// RVA: -1 Offset: -1
	public void UnPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99990 Offset: 0x2C99A91 VA: 0x2C99990
	|-AudioSourceController<BGMID>.UnPause
	|-AudioSourceController<SoundID>.UnPause
	|-AudioSourceController<Int32Enum>.UnPause
	|
	|-RVA: 0x2C9E940 Offset: 0x2C9EA41 VA: 0x2C9E940
	|-AudioSourceController<object>.UnPause
	*/

	// RVA: -1 Offset: -1
	public bool IsPlaying() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99A80 Offset: 0x2C99B81 VA: 0x2C99A80
	|-AudioSourceController<SoundID>.IsPlaying
	|-AudioSourceController<Int32Enum>.IsPlaying
	|
	|-RVA: 0x2C9EA30 Offset: 0x2C9EB31 VA: 0x2C9EA30
	|-AudioSourceController<object>.IsPlaying
	*/

	// RVA: -1 Offset: -1
	public bool IsDoneLoad() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99C70 Offset: 0x2C99D71 VA: 0x2C99C70
	|-AudioSourceController<SoundID>.IsDoneLoad
	|-AudioSourceController<Int32Enum>.IsDoneLoad
	|
	|-RVA: 0x2C9EC20 Offset: 0x2C9ED21 VA: 0x2C9EC20
	|-AudioSourceController<object>.IsDoneLoad
	*/

	// RVA: -1 Offset: -1
	public AudioSourceController.State<IDType> get_GetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99E50 Offset: 0x2C99F51 VA: 0x2C99E50
	|-AudioSourceController<BGMID>.get_GetState
	|-AudioSourceController<SoundID>.get_GetState
	|-AudioSourceController<Int32Enum>.get_GetState
	|
	|-RVA: 0x2C9EE00 Offset: 0x2C9EF01 VA: 0x2C9EE00
	|-AudioSourceController<object>.get_GetState
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IDType get_EmptyValue() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.get_EmptyValue
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual void DoPlay(IDType id, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99EE0 Offset: 0x2C99FE1 VA: 0x2C99EE0
	|-AudioSourceController<BGMID>.DoPlay
	|-AudioSourceController<SoundID>.DoPlay
	|-AudioSourceController<Int32Enum>.DoPlay
	|
	|-RVA: 0x2C9EE90 Offset: 0x2C9EF91 VA: 0x2C9EE90
	|-AudioSourceController<object>.DoPlay
	*/

	// RVA: -1 Offset: -1
	public void DoPlayForTimeline(IDType id, bool isLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A160 Offset: 0x2C9A261 VA: 0x2C9A160
	|-AudioSourceController<SoundID>.DoPlayForTimeline
	|-AudioSourceController<Int32Enum>.DoPlayForTimeline
	|
	|-RVA: 0x2C9F0E0 Offset: 0x2C9F1E1 VA: 0x2C9F0E0
	|-AudioSourceController<object>.DoPlayForTimeline
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual void DoResume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A190 Offset: 0x2C9A291 VA: 0x2C9A190
	|-AudioSourceController<BGMID>.DoResume
	|-AudioSourceController<SoundID>.DoResume
	|-AudioSourceController<Int32Enum>.DoResume
	|
	|-RVA: 0x2C9F110 Offset: 0x2C9F211 VA: 0x2C9F110
	|-AudioSourceController<object>.DoResume
	*/

	// RVA: -1 Offset: -1
	public void DoFadeIn(IDType id, float fadetime = 3, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A210 Offset: 0x2C9A311 VA: 0x2C9A210
	|-AudioSourceController<BGMID>.DoFadeIn
	|-AudioSourceController<SoundID>.DoFadeIn
	|-AudioSourceController<Int32Enum>.DoFadeIn
	|
	|-RVA: 0x2C9F190 Offset: 0x2C9F291 VA: 0x2C9F190
	|-AudioSourceController<object>.DoFadeIn
	*/

	// RVA: -1 Offset: -1
	public void DoFadeOut(float fadetime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A3D0 Offset: 0x2C9A4D1 VA: 0x2C9A3D0
	|-AudioSourceController<BGMID>.DoFadeOut
	|-AudioSourceController<SoundID>.DoFadeOut
	|-AudioSourceController<Int32Enum>.DoFadeOut
	|
	|-RVA: 0x2C9F320 Offset: 0x2C9F421 VA: 0x2C9F320
	|-AudioSourceController<object>.DoFadeOut
	*/

	// RVA: -1 Offset: -1
	public void DoStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A470 Offset: 0x2C9A571 VA: 0x2C9A470
	|-AudioSourceController<BGMID>.DoStop
	|-AudioSourceController<SoundID>.DoStop
	|-AudioSourceController<Int32Enum>.DoStop
	|
	|-RVA: 0x2C9F3C0 Offset: 0x2C9F4C1 VA: 0x2C9F3C0
	|-AudioSourceController<object>.DoStop
	*/

	// RVA: -1 Offset: -1
	public void DoImmediateStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A510 Offset: 0x2C9A611 VA: 0x2C9A510
	|-AudioSourceController<BGMID>.DoImmediateStop
	|-AudioSourceController<SoundID>.DoImmediateStop
	|-AudioSourceController<Int32Enum>.DoImmediateStop
	|
	|-RVA: 0x2C9F460 Offset: 0x2C9F561 VA: 0x2C9F460
	|-AudioSourceController<object>.DoImmediateStop
	*/

	// RVA: -1 Offset: -1
	public void SetCustomRolloffCurve(AnimationCurve animationCurve) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A590 Offset: 0x2C9A691 VA: 0x2C9A590
	|-AudioSourceController<Int32Enum>.SetCustomRolloffCurve
	|
	|-RVA: 0x2C9F4E0 Offset: 0x2C9F5E1 VA: 0x2C9F4E0
	|-AudioSourceController<object>.SetCustomRolloffCurve
	*/

	// RVA: -1 Offset: -1
	public void LoadWithWait(IDType id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A670 Offset: 0x2C9A771 VA: 0x2C9A670
	|-AudioSourceController<SoundID>.LoadWithWait
	|-AudioSourceController<Int32Enum>.LoadWithWait
	|
	|-RVA: 0x2C9F5C0 Offset: 0x2C9F6C1 VA: 0x2C9F5C0
	|-AudioSourceController<object>.LoadWithWait
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract AudioMixerGroup GetOutputMixer(IDType id) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.GetOutputMixer
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void SetupBeforePlayByDataTable() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.SetupBeforePlayByDataTable
	*/

	// RVA: -1 Offset: -1
	private void NotInit_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A710 Offset: 0x2C9A811 VA: 0x2C9A710
	|-AudioSourceController<Int32Enum>.NotInit_Enter
	|
	|-RVA: 0x2C9F660 Offset: 0x2C9F761 VA: 0x2C9F660
	|-AudioSourceController<object>.NotInit_Enter
	*/

	// RVA: -1 Offset: -1
	private void Play_internal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A810 Offset: 0x2C9A911 VA: 0x2C9A810
	|-AudioSourceController<Int32Enum>.Play_internal
	|
	|-RVA: 0x2C9F760 Offset: 0x2C9F861 VA: 0x2C9F760
	|-AudioSourceController<object>.Play_internal
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void Loading_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.Loading_Enter
	*/

	// RVA: -1 Offset: -1
	protected void Loading_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9AB30 Offset: 0x2C9AC31 VA: 0x2C9AB30
	|-AudioSourceController<Int32Enum>.Loading_Update
	|
	|-RVA: 0x2C9FA80 Offset: 0x2C9FB81 VA: 0x2C9FA80
	|-AudioSourceController<object>.Loading_Update
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void Play_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9AD10 Offset: 0x2C9AE11 VA: 0x2C9AD10
	|-AudioSourceController<BGMID>.Play_Enter
	|-AudioSourceController<SoundID>.Play_Enter
	|-AudioSourceController<Int32Enum>.Play_Enter
	|
	|-RVA: 0x2C9FC60 Offset: 0x2C9FD61 VA: 0x2C9FC60
	|-AudioSourceController<object>.Play_Enter
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual void Play_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9ADF0 Offset: 0x2C9AEF1 VA: 0x2C9ADF0
	|-AudioSourceController<BGMID>.Play_Update
	|-AudioSourceController<SoundID>.Play_Update
	|-AudioSourceController<Int32Enum>.Play_Update
	|
	|-RVA: 0x2C9FD40 Offset: 0x2C9FE41 VA: 0x2C9FD40
	|-AudioSourceController<object>.Play_Update
	*/

	// RVA: -1 Offset: -1
	protected void Play_Exit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B100 Offset: 0x2C9B201 VA: 0x2C9B100
	|-AudioSourceController<Int32Enum>.Play_Exit
	|
	|-RVA: 0x2CA0050 Offset: 0x2CA0151 VA: 0x2CA0050
	|-AudioSourceController<object>.Play_Exit
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_IsLoopClip() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.get_IsLoopClip
	*/

	// RVA: -1 Offset: -1
	public bool get_IsLoopAudioSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B110 Offset: 0x2C9B211 VA: 0x2C9B110
	|-AudioSourceController<Int32Enum>.get_IsLoopAudioSource
	|
	|-RVA: 0x2CA0060 Offset: 0x2CA0161 VA: 0x2CA0060
	|-AudioSourceController<object>.get_IsLoopAudioSource
	*/

	// RVA: -1 Offset: -1
	protected void FadeIn_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B150 Offset: 0x2C9B251 VA: 0x2C9B150
	|-AudioSourceController<Int32Enum>.FadeIn_Enter
	|
	|-RVA: 0x2CA00A0 Offset: 0x2CA01A1 VA: 0x2CA00A0
	|-AudioSourceController<object>.FadeIn_Enter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	protected virtual void FadeIn_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B230 Offset: 0x2C9B331 VA: 0x2C9B230
	|-AudioSourceController<BGMID>.FadeIn_Update
	|-AudioSourceController<SoundID>.FadeIn_Update
	|-AudioSourceController<Int32Enum>.FadeIn_Update
	|
	|-RVA: 0x2CA0180 Offset: 0x2CA0281 VA: 0x2CA0180
	|-AudioSourceController<object>.FadeIn_Update
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected virtual void FadeOut_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B510 Offset: 0x2C9B611 VA: 0x2C9B510
	|-AudioSourceController<BGMID>.FadeOut_Update
	|-AudioSourceController<SoundID>.FadeOut_Update
	|-AudioSourceController<Int32Enum>.FadeOut_Update
	|
	|-RVA: 0x2CA0460 Offset: 0x2CA0561 VA: 0x2CA0460
	|-AudioSourceController<object>.FadeOut_Update
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected virtual void Done_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B780 Offset: 0x2C9B881 VA: 0x2C9B780
	|-AudioSourceController<BGMID>.Done_Enter
	|-AudioSourceController<SoundID>.Done_Enter
	|-AudioSourceController<Int32Enum>.Done_Enter
	|
	|-RVA: 0x2CA06D0 Offset: 0x2CA07D1 VA: 0x2CA06D0
	|-AudioSourceController<object>.Done_Enter
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B870 Offset: 0x2C9B971 VA: 0x2C9B870
	|-AudioSourceController<BGMID>..ctor
	|-AudioSourceController<SoundID>..ctor
	|-AudioSourceController<Int32Enum>..ctor
	|
	|-RVA: 0x2CA07C0 Offset: 0x2CA08C1 VA: 0x2CA07C0
	|-AudioSourceController<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B890 Offset: 0x2C9B991 VA: 0x2C9B890
	|-AudioSourceController<Int32Enum>..cctor
	|
	|-RVA: 0x2CA07E0 Offset: 0x2CA08E1 VA: 0x2CA07E0
	|-AudioSourceController<object>..cctor
	*/
}

public abstract class AudioSourceController<IDType> : MonoBehaviour // TypeDefIndex: 9863
{
	// Fields
	private AudioSource _AudioSource; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F900 Offset: 0x17FA01 VA: 0x17F900
	private Transform <Constraint>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F910 Offset: 0x17FA11 VA: 0x17F910
	private bool <IsConstraint>k__BackingField; // 0x0
	private IDType _CurrentID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F920 Offset: 0x17FA21 VA: 0x17F920
	private IDType <CurrentID>k__BackingField; // 0x0
	private int EntriedAssetID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F930 Offset: 0x17FA31 VA: 0x17F930
	private float <FadeTime>k__BackingField; // 0x0
	private float FadeAlpha; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F940 Offset: 0x17FA41 VA: 0x17F940
	private bool <IsPause>k__BackingField; // 0x0
	public DestroyMode DestroyMode; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F950 Offset: 0x17FA51 VA: 0x17F950
	private float <Volume>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F960 Offset: 0x17FA61 VA: 0x17F960
	private float <DataTable_Volume>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F970 Offset: 0x17FA71 VA: 0x17F970
	private int <Priority>k__BackingField; // 0x0
	private static int stateElementTableCount; // 0x0
	private AudioSourceController.Command<IDType> AfterLoad; // 0x0
	private AudioSourceController.State<IDType> InitialState; // 0x0
	private StateMachine<AudioSourceController.State<IDType>> sm; // 0x0
	private float m_PlayTime; // 0x0
	private static TransitionTables[] TransitionTables; // 0x0
	private bool IsTimeline; // 0x0
	private bool IsTimelineLoop; // 0x0
	private bool wait_first_frame; // 0x0

	// Properties
	public AudioSource AudioSource { get; set; }
	public Transform Constraint { get; set; }
	public bool IsConstraint { get; set; }
	public IDType CurrentID { get; set; }
	protected float FadeTime { get; set; }
	protected virtual AnimationCurve FadeCurve { get; }
	public bool IsPause { get; set; }
	public float Volume { get; set; }
	protected float DataTable_Volume { get; set; }
	public int Priority { get; set; }
	public float PlayTime { get; }
	public AudioSourceController.State<IDType> GetState { get; }
	public abstract IDType EmptyValue { get; }
	public abstract bool IsLoopClip { get; }
	public bool IsLoopAudioSource { get; }

	// Methods

	// RVA: -1 Offset: -1
	public AudioSource get_AudioSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C989F0 Offset: 0x2C98AF1 VA: 0x2C989F0
	|-AudioSourceController<BGMID>.get_AudioSource
	|-AudioSourceController<SoundID>.get_AudioSource
	|-AudioSourceController<Int32Enum>.get_AudioSource
	|
	|-RVA: 0x2C9D9A0 Offset: 0x2C9DAA1 VA: 0x2C9D9A0
	|-AudioSourceController<object>.get_AudioSource
	*/

	// RVA: -1 Offset: -1
	public void set_AudioSource(AudioSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AA0 Offset: 0x2C98BA1 VA: 0x2C98AA0
	|-AudioSourceController<Int32Enum>.set_AudioSource
	|
	|-RVA: 0x2C9DA50 Offset: 0x2C9DB51 VA: 0x2C9DA50
	|-AudioSourceController<object>.set_AudioSource
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD150 Offset: 0x1AD251 VA: 0x1AD150
	// RVA: -1 Offset: -1
	public Transform get_Constraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AB0 Offset: 0x2C98BB1 VA: 0x2C98AB0
	|-AudioSourceController<Int32Enum>.get_Constraint
	|
	|-RVA: 0x2C9DA60 Offset: 0x2C9DB61 VA: 0x2C9DA60
	|-AudioSourceController<object>.get_Constraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD160 Offset: 0x1AD261 VA: 0x1AD160
	// RVA: -1 Offset: -1
	public void set_Constraint(Transform value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AC0 Offset: 0x2C98BC1 VA: 0x2C98AC0
	|-AudioSourceController<SoundID>.set_Constraint
	|-AudioSourceController<Int32Enum>.set_Constraint
	|
	|-RVA: 0x2C9DA70 Offset: 0x2C9DB71 VA: 0x2C9DA70
	|-AudioSourceController<object>.set_Constraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD170 Offset: 0x1AD271 VA: 0x1AD170
	// RVA: -1 Offset: -1
	public bool get_IsConstraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AD0 Offset: 0x2C98BD1 VA: 0x2C98AD0
	|-AudioSourceController<Int32Enum>.get_IsConstraint
	|
	|-RVA: 0x2C9DA80 Offset: 0x2C9DB81 VA: 0x2C9DA80
	|-AudioSourceController<object>.get_IsConstraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD180 Offset: 0x1AD281 VA: 0x1AD180
	// RVA: -1 Offset: -1
	public void set_IsConstraint(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AE0 Offset: 0x2C98BE1 VA: 0x2C98AE0
	|-AudioSourceController<SoundID>.set_IsConstraint
	|-AudioSourceController<Int32Enum>.set_IsConstraint
	|
	|-RVA: 0x2C9DA90 Offset: 0x2C9DB91 VA: 0x2C9DA90
	|-AudioSourceController<object>.set_IsConstraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD190 Offset: 0x1AD291 VA: 0x1AD190
	// RVA: -1 Offset: -1
	public IDType get_CurrentID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AF0 Offset: 0x2C98BF1 VA: 0x2C98AF0
	|-AudioSourceController<BGMID>.get_CurrentID
	|-AudioSourceController<SoundID>.get_CurrentID
	|-AudioSourceController<Int32Enum>.get_CurrentID
	|
	|-RVA: 0x2C9DAA0 Offset: 0x2C9DBA1 VA: 0x2C9DAA0
	|-AudioSourceController<object>.get_CurrentID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1A0 Offset: 0x1AD2A1 VA: 0x1AD1A0
	// RVA: -1 Offset: -1
	public void set_CurrentID(IDType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98B00 Offset: 0x2C98C01 VA: 0x2C98B00
	|-AudioSourceController<SoundID>.set_CurrentID
	|-AudioSourceController<Int32Enum>.set_CurrentID
	|
	|-RVA: 0x2C9DAB0 Offset: 0x2C9DBB1 VA: 0x2C9DAB0
	|-AudioSourceController<object>.set_CurrentID
	*/

	// RVA: -1 Offset: -1
	protected void SetAssetID(Audio id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98B10 Offset: 0x2C98C11 VA: 0x2C98B10
	|-AudioSourceController<BGMID>.SetAssetID
	|-AudioSourceController<SoundID>.SetAssetID
	|-AudioSourceController<Int32Enum>.SetAssetID
	|
	|-RVA: 0x2C9DAC0 Offset: 0x2C9DBC1 VA: 0x2C9DAC0
	|-AudioSourceController<object>.SetAssetID
	*/

	// RVA: -1 Offset: -1
	private bool RemoveAssetID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98BF0 Offset: 0x2C98CF1 VA: 0x2C98BF0
	|-AudioSourceController<Int32Enum>.RemoveAssetID
	|
	|-RVA: 0x2C9DBA0 Offset: 0x2C9DCA1 VA: 0x2C9DBA0
	|-AudioSourceController<object>.RemoveAssetID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1B0 Offset: 0x1AD2B1 VA: 0x1AD1B0
	// RVA: -1 Offset: -1
	protected float get_FadeTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98C80 Offset: 0x2C98D81 VA: 0x2C98C80
	|-AudioSourceController<Int32Enum>.get_FadeTime
	|
	|-RVA: 0x2C9DC30 Offset: 0x2C9DD31 VA: 0x2C9DC30
	|-AudioSourceController<object>.get_FadeTime
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1C0 Offset: 0x1AD2C1 VA: 0x1AD1C0
	// RVA: -1 Offset: -1
	protected void set_FadeTime(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98C90 Offset: 0x2C98D91 VA: 0x2C98C90
	|-AudioSourceController<Int32Enum>.set_FadeTime
	|
	|-RVA: 0x2C9DC40 Offset: 0x2C9DD41 VA: 0x2C9DC40
	|-AudioSourceController<object>.set_FadeTime
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual AnimationCurve get_FadeCurve() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98CA0 Offset: 0x2C98DA1 VA: 0x2C98CA0
	|-AudioSourceController<BGMID>.get_FadeCurve
	|-AudioSourceController<SoundID>.get_FadeCurve
	|-AudioSourceController<Int32Enum>.get_FadeCurve
	|
	|-RVA: 0x2C9DC50 Offset: 0x2C9DD51 VA: 0x2C9DC50
	|-AudioSourceController<object>.get_FadeCurve
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1D0 Offset: 0x1AD2D1 VA: 0x1AD1D0
	// RVA: -1 Offset: -1
	public bool get_IsPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D00 Offset: 0x2C98E01 VA: 0x2C98D00
	|-AudioSourceController<Int32Enum>.get_IsPause
	|
	|-RVA: 0x2C9DCB0 Offset: 0x2C9DDB1 VA: 0x2C9DCB0
	|-AudioSourceController<object>.get_IsPause
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1E0 Offset: 0x1AD2E1 VA: 0x1AD1E0
	// RVA: -1 Offset: -1
	protected void set_IsPause(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D10 Offset: 0x2C98E11 VA: 0x2C98D10
	|-AudioSourceController<Int32Enum>.set_IsPause
	|
	|-RVA: 0x2C9DCC0 Offset: 0x2C9DDC1 VA: 0x2C9DCC0
	|-AudioSourceController<object>.set_IsPause
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1F0 Offset: 0x1AD2F1 VA: 0x1AD1F0
	// RVA: -1 Offset: -1
	public float get_Volume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D20 Offset: 0x2C98E21 VA: 0x2C98D20
	|-AudioSourceController<Int32Enum>.get_Volume
	|
	|-RVA: 0x2C9DCD0 Offset: 0x2C9DDD1 VA: 0x2C9DCD0
	|-AudioSourceController<object>.get_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD200 Offset: 0x1AD301 VA: 0x1AD200
	// RVA: -1 Offset: -1
	public void set_Volume(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D30 Offset: 0x2C98E31 VA: 0x2C98D30
	|-AudioSourceController<SoundID>.set_Volume
	|-AudioSourceController<Int32Enum>.set_Volume
	|
	|-RVA: 0x2C9DCE0 Offset: 0x2C9DDE1 VA: 0x2C9DCE0
	|-AudioSourceController<object>.set_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD210 Offset: 0x1AD311 VA: 0x1AD210
	// RVA: -1 Offset: -1
	protected float get_DataTable_Volume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D40 Offset: 0x2C98E41 VA: 0x2C98D40
	|-AudioSourceController<Int32Enum>.get_DataTable_Volume
	|
	|-RVA: 0x2C9DCF0 Offset: 0x2C9DDF1 VA: 0x2C9DCF0
	|-AudioSourceController<object>.get_DataTable_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD220 Offset: 0x1AD321 VA: 0x1AD220
	// RVA: -1 Offset: -1
	protected void set_DataTable_Volume(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D50 Offset: 0x2C98E51 VA: 0x2C98D50
	|-AudioSourceController<SoundID>.set_DataTable_Volume
	|-AudioSourceController<Int32Enum>.set_DataTable_Volume
	|
	|-RVA: 0x2C9DD00 Offset: 0x2C9DE01 VA: 0x2C9DD00
	|-AudioSourceController<object>.set_DataTable_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD230 Offset: 0x1AD331 VA: 0x1AD230
	// RVA: -1 Offset: -1
	public int get_Priority() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D60 Offset: 0x2C98E61 VA: 0x2C98D60
	|-AudioSourceController<BGMID>.get_Priority
	|-AudioSourceController<SoundID>.get_Priority
	|-AudioSourceController<Int32Enum>.get_Priority
	|
	|-RVA: 0x2C9DD10 Offset: 0x2C9DE11 VA: 0x2C9DD10
	|-AudioSourceController<object>.get_Priority
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD240 Offset: 0x1AD341 VA: 0x1AD240
	// RVA: -1 Offset: -1
	private void set_Priority(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D70 Offset: 0x2C98E71 VA: 0x2C98D70
	|-AudioSourceController<Int32Enum>.set_Priority
	|
	|-RVA: 0x2C9DD20 Offset: 0x2C9DE21 VA: 0x2C9DD20
	|-AudioSourceController<object>.set_Priority
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual AudioSource ReadyAudioSourceComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D80 Offset: 0x2C98E81 VA: 0x2C98D80
	|-AudioSourceController<BGMID>.ReadyAudioSourceComponent
	|-AudioSourceController<SoundID>.ReadyAudioSourceComponent
	|-AudioSourceController<Int32Enum>.ReadyAudioSourceComponent
	|
	|-RVA: 0x2C9DD30 Offset: 0x2C9DE31 VA: 0x2C9DD30
	|-AudioSourceController<object>.ReadyAudioSourceComponent
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98DF0 Offset: 0x2C98EF1 VA: 0x2C98DF0
	|-AudioSourceController<BGMID>.Awake
	|-AudioSourceController<SoundID>.Awake
	|-AudioSourceController<Int32Enum>.Awake
	|
	|-RVA: 0x2C9DDA0 Offset: 0x2C9DEA1 VA: 0x2C9DDA0
	|-AudioSourceController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99550 Offset: 0x2C99651 VA: 0x2C99550
	|-AudioSourceController<BGMID>.OnDestroy
	|-AudioSourceController<SoundID>.OnDestroy
	|-AudioSourceController<Int32Enum>.OnDestroy
	|
	|-RVA: 0x2C9E500 Offset: 0x2C9E601 VA: 0x2C9E500
	|-AudioSourceController<object>.OnDestroy
	*/

	// RVA: -1 Offset: -1
	public float get_PlayTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99580 Offset: 0x2C99681 VA: 0x2C99580
	|-AudioSourceController<Int32Enum>.get_PlayTime
	|
	|-RVA: 0x2C9E530 Offset: 0x2C9E631 VA: 0x2C9E530
	|-AudioSourceController<object>.get_PlayTime
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual void ResetByRemoveAllResources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C995D0 Offset: 0x2C996D1 VA: 0x2C995D0
	|-AudioSourceController<BGMID>.ResetByRemoveAllResources
	|-AudioSourceController<SoundID>.ResetByRemoveAllResources
	|-AudioSourceController<Int32Enum>.ResetByRemoveAllResources
	|
	|-RVA: 0x2C9E580 Offset: 0x2C9E681 VA: 0x2C9E580
	|-AudioSourceController<object>.ResetByRemoveAllResources
	*/

	// RVA: -1 Offset: -1
	private bool UpdateConstraintPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99730 Offset: 0x2C99831 VA: 0x2C99730
	|-AudioSourceController<Int32Enum>.UpdateConstraintPosition
	|
	|-RVA: 0x2C9E6E0 Offset: 0x2C9E7E1 VA: 0x2C9E6E0
	|-AudioSourceController<object>.UpdateConstraintPosition
	*/

	// RVA: -1 Offset: -1
	public void Pause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99830 Offset: 0x2C99931 VA: 0x2C99830
	|-AudioSourceController<BGMID>.Pause
	|-AudioSourceController<SoundID>.Pause
	|-AudioSourceController<Int32Enum>.Pause
	|
	|-RVA: 0x2C9E7E0 Offset: 0x2C9E8E1 VA: 0x2C9E7E0
	|-AudioSourceController<object>.Pause
	*/

	// RVA: -1 Offset: -1
	public void UnPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99990 Offset: 0x2C99A91 VA: 0x2C99990
	|-AudioSourceController<BGMID>.UnPause
	|-AudioSourceController<SoundID>.UnPause
	|-AudioSourceController<Int32Enum>.UnPause
	|
	|-RVA: 0x2C9E940 Offset: 0x2C9EA41 VA: 0x2C9E940
	|-AudioSourceController<object>.UnPause
	*/

	// RVA: -1 Offset: -1
	public bool IsPlaying() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99A80 Offset: 0x2C99B81 VA: 0x2C99A80
	|-AudioSourceController<SoundID>.IsPlaying
	|-AudioSourceController<Int32Enum>.IsPlaying
	|
	|-RVA: 0x2C9EA30 Offset: 0x2C9EB31 VA: 0x2C9EA30
	|-AudioSourceController<object>.IsPlaying
	*/

	// RVA: -1 Offset: -1
	public bool IsDoneLoad() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99C70 Offset: 0x2C99D71 VA: 0x2C99C70
	|-AudioSourceController<SoundID>.IsDoneLoad
	|-AudioSourceController<Int32Enum>.IsDoneLoad
	|
	|-RVA: 0x2C9EC20 Offset: 0x2C9ED21 VA: 0x2C9EC20
	|-AudioSourceController<object>.IsDoneLoad
	*/

	// RVA: -1 Offset: -1
	public AudioSourceController.State<IDType> get_GetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99E50 Offset: 0x2C99F51 VA: 0x2C99E50
	|-AudioSourceController<BGMID>.get_GetState
	|-AudioSourceController<SoundID>.get_GetState
	|-AudioSourceController<Int32Enum>.get_GetState
	|
	|-RVA: 0x2C9EE00 Offset: 0x2C9EF01 VA: 0x2C9EE00
	|-AudioSourceController<object>.get_GetState
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IDType get_EmptyValue() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.get_EmptyValue
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual void DoPlay(IDType id, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99EE0 Offset: 0x2C99FE1 VA: 0x2C99EE0
	|-AudioSourceController<BGMID>.DoPlay
	|-AudioSourceController<SoundID>.DoPlay
	|-AudioSourceController<Int32Enum>.DoPlay
	|
	|-RVA: 0x2C9EE90 Offset: 0x2C9EF91 VA: 0x2C9EE90
	|-AudioSourceController<object>.DoPlay
	*/

	// RVA: -1 Offset: -1
	public void DoPlayForTimeline(IDType id, bool isLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A160 Offset: 0x2C9A261 VA: 0x2C9A160
	|-AudioSourceController<SoundID>.DoPlayForTimeline
	|-AudioSourceController<Int32Enum>.DoPlayForTimeline
	|
	|-RVA: 0x2C9F0E0 Offset: 0x2C9F1E1 VA: 0x2C9F0E0
	|-AudioSourceController<object>.DoPlayForTimeline
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual void DoResume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A190 Offset: 0x2C9A291 VA: 0x2C9A190
	|-AudioSourceController<BGMID>.DoResume
	|-AudioSourceController<SoundID>.DoResume
	|-AudioSourceController<Int32Enum>.DoResume
	|
	|-RVA: 0x2C9F110 Offset: 0x2C9F211 VA: 0x2C9F110
	|-AudioSourceController<object>.DoResume
	*/

	// RVA: -1 Offset: -1
	public void DoFadeIn(IDType id, float fadetime = 3, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A210 Offset: 0x2C9A311 VA: 0x2C9A210
	|-AudioSourceController<BGMID>.DoFadeIn
	|-AudioSourceController<SoundID>.DoFadeIn
	|-AudioSourceController<Int32Enum>.DoFadeIn
	|
	|-RVA: 0x2C9F190 Offset: 0x2C9F291 VA: 0x2C9F190
	|-AudioSourceController<object>.DoFadeIn
	*/

	// RVA: -1 Offset: -1
	public void DoFadeOut(float fadetime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A3D0 Offset: 0x2C9A4D1 VA: 0x2C9A3D0
	|-AudioSourceController<BGMID>.DoFadeOut
	|-AudioSourceController<SoundID>.DoFadeOut
	|-AudioSourceController<Int32Enum>.DoFadeOut
	|
	|-RVA: 0x2C9F320 Offset: 0x2C9F421 VA: 0x2C9F320
	|-AudioSourceController<object>.DoFadeOut
	*/

	// RVA: -1 Offset: -1
	public void DoStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A470 Offset: 0x2C9A571 VA: 0x2C9A470
	|-AudioSourceController<BGMID>.DoStop
	|-AudioSourceController<SoundID>.DoStop
	|-AudioSourceController<Int32Enum>.DoStop
	|
	|-RVA: 0x2C9F3C0 Offset: 0x2C9F4C1 VA: 0x2C9F3C0
	|-AudioSourceController<object>.DoStop
	*/

	// RVA: -1 Offset: -1
	public void DoImmediateStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A510 Offset: 0x2C9A611 VA: 0x2C9A510
	|-AudioSourceController<BGMID>.DoImmediateStop
	|-AudioSourceController<SoundID>.DoImmediateStop
	|-AudioSourceController<Int32Enum>.DoImmediateStop
	|
	|-RVA: 0x2C9F460 Offset: 0x2C9F561 VA: 0x2C9F460
	|-AudioSourceController<object>.DoImmediateStop
	*/

	// RVA: -1 Offset: -1
	public void SetCustomRolloffCurve(AnimationCurve animationCurve) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A590 Offset: 0x2C9A691 VA: 0x2C9A590
	|-AudioSourceController<Int32Enum>.SetCustomRolloffCurve
	|
	|-RVA: 0x2C9F4E0 Offset: 0x2C9F5E1 VA: 0x2C9F4E0
	|-AudioSourceController<object>.SetCustomRolloffCurve
	*/

	// RVA: -1 Offset: -1
	public void LoadWithWait(IDType id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A670 Offset: 0x2C9A771 VA: 0x2C9A670
	|-AudioSourceController<SoundID>.LoadWithWait
	|-AudioSourceController<Int32Enum>.LoadWithWait
	|
	|-RVA: 0x2C9F5C0 Offset: 0x2C9F6C1 VA: 0x2C9F5C0
	|-AudioSourceController<object>.LoadWithWait
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract AudioMixerGroup GetOutputMixer(IDType id) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.GetOutputMixer
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void SetupBeforePlayByDataTable() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.SetupBeforePlayByDataTable
	*/

	// RVA: -1 Offset: -1
	private void NotInit_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A710 Offset: 0x2C9A811 VA: 0x2C9A710
	|-AudioSourceController<Int32Enum>.NotInit_Enter
	|
	|-RVA: 0x2C9F660 Offset: 0x2C9F761 VA: 0x2C9F660
	|-AudioSourceController<object>.NotInit_Enter
	*/

	// RVA: -1 Offset: -1
	private void Play_internal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A810 Offset: 0x2C9A911 VA: 0x2C9A810
	|-AudioSourceController<Int32Enum>.Play_internal
	|
	|-RVA: 0x2C9F760 Offset: 0x2C9F861 VA: 0x2C9F760
	|-AudioSourceController<object>.Play_internal
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void Loading_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.Loading_Enter
	*/

	// RVA: -1 Offset: -1
	protected void Loading_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9AB30 Offset: 0x2C9AC31 VA: 0x2C9AB30
	|-AudioSourceController<Int32Enum>.Loading_Update
	|
	|-RVA: 0x2C9FA80 Offset: 0x2C9FB81 VA: 0x2C9FA80
	|-AudioSourceController<object>.Loading_Update
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void Play_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9AD10 Offset: 0x2C9AE11 VA: 0x2C9AD10
	|-AudioSourceController<BGMID>.Play_Enter
	|-AudioSourceController<SoundID>.Play_Enter
	|-AudioSourceController<Int32Enum>.Play_Enter
	|
	|-RVA: 0x2C9FC60 Offset: 0x2C9FD61 VA: 0x2C9FC60
	|-AudioSourceController<object>.Play_Enter
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual void Play_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9ADF0 Offset: 0x2C9AEF1 VA: 0x2C9ADF0
	|-AudioSourceController<BGMID>.Play_Update
	|-AudioSourceController<SoundID>.Play_Update
	|-AudioSourceController<Int32Enum>.Play_Update
	|
	|-RVA: 0x2C9FD40 Offset: 0x2C9FE41 VA: 0x2C9FD40
	|-AudioSourceController<object>.Play_Update
	*/

	// RVA: -1 Offset: -1
	protected void Play_Exit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B100 Offset: 0x2C9B201 VA: 0x2C9B100
	|-AudioSourceController<Int32Enum>.Play_Exit
	|
	|-RVA: 0x2CA0050 Offset: 0x2CA0151 VA: 0x2CA0050
	|-AudioSourceController<object>.Play_Exit
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_IsLoopClip() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.get_IsLoopClip
	*/

	// RVA: -1 Offset: -1
	public bool get_IsLoopAudioSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B110 Offset: 0x2C9B211 VA: 0x2C9B110
	|-AudioSourceController<Int32Enum>.get_IsLoopAudioSource
	|
	|-RVA: 0x2CA0060 Offset: 0x2CA0161 VA: 0x2CA0060
	|-AudioSourceController<object>.get_IsLoopAudioSource
	*/

	// RVA: -1 Offset: -1
	protected void FadeIn_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B150 Offset: 0x2C9B251 VA: 0x2C9B150
	|-AudioSourceController<Int32Enum>.FadeIn_Enter
	|
	|-RVA: 0x2CA00A0 Offset: 0x2CA01A1 VA: 0x2CA00A0
	|-AudioSourceController<object>.FadeIn_Enter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	protected virtual void FadeIn_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B230 Offset: 0x2C9B331 VA: 0x2C9B230
	|-AudioSourceController<BGMID>.FadeIn_Update
	|-AudioSourceController<SoundID>.FadeIn_Update
	|-AudioSourceController<Int32Enum>.FadeIn_Update
	|
	|-RVA: 0x2CA0180 Offset: 0x2CA0281 VA: 0x2CA0180
	|-AudioSourceController<object>.FadeIn_Update
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected virtual void FadeOut_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B510 Offset: 0x2C9B611 VA: 0x2C9B510
	|-AudioSourceController<BGMID>.FadeOut_Update
	|-AudioSourceController<SoundID>.FadeOut_Update
	|-AudioSourceController<Int32Enum>.FadeOut_Update
	|
	|-RVA: 0x2CA0460 Offset: 0x2CA0561 VA: 0x2CA0460
	|-AudioSourceController<object>.FadeOut_Update
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected virtual void Done_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B780 Offset: 0x2C9B881 VA: 0x2C9B780
	|-AudioSourceController<BGMID>.Done_Enter
	|-AudioSourceController<SoundID>.Done_Enter
	|-AudioSourceController<Int32Enum>.Done_Enter
	|
	|-RVA: 0x2CA06D0 Offset: 0x2CA07D1 VA: 0x2CA06D0
	|-AudioSourceController<object>.Done_Enter
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B870 Offset: 0x2C9B971 VA: 0x2C9B870
	|-AudioSourceController<BGMID>..ctor
	|-AudioSourceController<SoundID>..ctor
	|-AudioSourceController<Int32Enum>..ctor
	|
	|-RVA: 0x2CA07C0 Offset: 0x2CA08C1 VA: 0x2CA07C0
	|-AudioSourceController<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B890 Offset: 0x2C9B991 VA: 0x2C9B890
	|-AudioSourceController<Int32Enum>..cctor
	|
	|-RVA: 0x2CA07E0 Offset: 0x2CA08E1 VA: 0x2CA07E0
	|-AudioSourceController<object>..cctor
	*/
}

public abstract class AudioSourceController<IDType> : MonoBehaviour // TypeDefIndex: 9863
{
	// Fields
	private AudioSource _AudioSource; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F900 Offset: 0x17FA01 VA: 0x17F900
	private Transform <Constraint>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F910 Offset: 0x17FA11 VA: 0x17F910
	private bool <IsConstraint>k__BackingField; // 0x0
	private IDType _CurrentID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F920 Offset: 0x17FA21 VA: 0x17F920
	private IDType <CurrentID>k__BackingField; // 0x0
	private int EntriedAssetID; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F930 Offset: 0x17FA31 VA: 0x17F930
	private float <FadeTime>k__BackingField; // 0x0
	private float FadeAlpha; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F940 Offset: 0x17FA41 VA: 0x17F940
	private bool <IsPause>k__BackingField; // 0x0
	public DestroyMode DestroyMode; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F950 Offset: 0x17FA51 VA: 0x17F950
	private float <Volume>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F960 Offset: 0x17FA61 VA: 0x17F960
	private float <DataTable_Volume>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17F970 Offset: 0x17FA71 VA: 0x17F970
	private int <Priority>k__BackingField; // 0x0
	private static int stateElementTableCount; // 0x0
	private AudioSourceController.Command<IDType> AfterLoad; // 0x0
	private AudioSourceController.State<IDType> InitialState; // 0x0
	private StateMachine<AudioSourceController.State<IDType>> sm; // 0x0
	private float m_PlayTime; // 0x0
	private static TransitionTables[] TransitionTables; // 0x0
	private bool IsTimeline; // 0x0
	private bool IsTimelineLoop; // 0x0
	private bool wait_first_frame; // 0x0

	// Properties
	public AudioSource AudioSource { get; set; }
	public Transform Constraint { get; set; }
	public bool IsConstraint { get; set; }
	public IDType CurrentID { get; set; }
	protected float FadeTime { get; set; }
	protected virtual AnimationCurve FadeCurve { get; }
	public bool IsPause { get; set; }
	public float Volume { get; set; }
	protected float DataTable_Volume { get; set; }
	public int Priority { get; set; }
	public float PlayTime { get; }
	public AudioSourceController.State<IDType> GetState { get; }
	public abstract IDType EmptyValue { get; }
	public abstract bool IsLoopClip { get; }
	public bool IsLoopAudioSource { get; }

	// Methods

	// RVA: -1 Offset: -1
	public AudioSource get_AudioSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C989F0 Offset: 0x2C98AF1 VA: 0x2C989F0
	|-AudioSourceController<BGMID>.get_AudioSource
	|-AudioSourceController<SoundID>.get_AudioSource
	|-AudioSourceController<Int32Enum>.get_AudioSource
	|
	|-RVA: 0x2C9D9A0 Offset: 0x2C9DAA1 VA: 0x2C9D9A0
	|-AudioSourceController<object>.get_AudioSource
	*/

	// RVA: -1 Offset: -1
	public void set_AudioSource(AudioSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AA0 Offset: 0x2C98BA1 VA: 0x2C98AA0
	|-AudioSourceController<Int32Enum>.set_AudioSource
	|
	|-RVA: 0x2C9DA50 Offset: 0x2C9DB51 VA: 0x2C9DA50
	|-AudioSourceController<object>.set_AudioSource
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD150 Offset: 0x1AD251 VA: 0x1AD150
	// RVA: -1 Offset: -1
	public Transform get_Constraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AB0 Offset: 0x2C98BB1 VA: 0x2C98AB0
	|-AudioSourceController<Int32Enum>.get_Constraint
	|
	|-RVA: 0x2C9DA60 Offset: 0x2C9DB61 VA: 0x2C9DA60
	|-AudioSourceController<object>.get_Constraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD160 Offset: 0x1AD261 VA: 0x1AD160
	// RVA: -1 Offset: -1
	public void set_Constraint(Transform value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AC0 Offset: 0x2C98BC1 VA: 0x2C98AC0
	|-AudioSourceController<SoundID>.set_Constraint
	|-AudioSourceController<Int32Enum>.set_Constraint
	|
	|-RVA: 0x2C9DA70 Offset: 0x2C9DB71 VA: 0x2C9DA70
	|-AudioSourceController<object>.set_Constraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD170 Offset: 0x1AD271 VA: 0x1AD170
	// RVA: -1 Offset: -1
	public bool get_IsConstraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AD0 Offset: 0x2C98BD1 VA: 0x2C98AD0
	|-AudioSourceController<Int32Enum>.get_IsConstraint
	|
	|-RVA: 0x2C9DA80 Offset: 0x2C9DB81 VA: 0x2C9DA80
	|-AudioSourceController<object>.get_IsConstraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD180 Offset: 0x1AD281 VA: 0x1AD180
	// RVA: -1 Offset: -1
	public void set_IsConstraint(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AE0 Offset: 0x2C98BE1 VA: 0x2C98AE0
	|-AudioSourceController<SoundID>.set_IsConstraint
	|-AudioSourceController<Int32Enum>.set_IsConstraint
	|
	|-RVA: 0x2C9DA90 Offset: 0x2C9DB91 VA: 0x2C9DA90
	|-AudioSourceController<object>.set_IsConstraint
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD190 Offset: 0x1AD291 VA: 0x1AD190
	// RVA: -1 Offset: -1
	public IDType get_CurrentID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98AF0 Offset: 0x2C98BF1 VA: 0x2C98AF0
	|-AudioSourceController<BGMID>.get_CurrentID
	|-AudioSourceController<SoundID>.get_CurrentID
	|-AudioSourceController<Int32Enum>.get_CurrentID
	|
	|-RVA: 0x2C9DAA0 Offset: 0x2C9DBA1 VA: 0x2C9DAA0
	|-AudioSourceController<object>.get_CurrentID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1A0 Offset: 0x1AD2A1 VA: 0x1AD1A0
	// RVA: -1 Offset: -1
	public void set_CurrentID(IDType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98B00 Offset: 0x2C98C01 VA: 0x2C98B00
	|-AudioSourceController<SoundID>.set_CurrentID
	|-AudioSourceController<Int32Enum>.set_CurrentID
	|
	|-RVA: 0x2C9DAB0 Offset: 0x2C9DBB1 VA: 0x2C9DAB0
	|-AudioSourceController<object>.set_CurrentID
	*/

	// RVA: -1 Offset: -1
	protected void SetAssetID(Audio id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98B10 Offset: 0x2C98C11 VA: 0x2C98B10
	|-AudioSourceController<BGMID>.SetAssetID
	|-AudioSourceController<SoundID>.SetAssetID
	|-AudioSourceController<Int32Enum>.SetAssetID
	|
	|-RVA: 0x2C9DAC0 Offset: 0x2C9DBC1 VA: 0x2C9DAC0
	|-AudioSourceController<object>.SetAssetID
	*/

	// RVA: -1 Offset: -1
	private bool RemoveAssetID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98BF0 Offset: 0x2C98CF1 VA: 0x2C98BF0
	|-AudioSourceController<Int32Enum>.RemoveAssetID
	|
	|-RVA: 0x2C9DBA0 Offset: 0x2C9DCA1 VA: 0x2C9DBA0
	|-AudioSourceController<object>.RemoveAssetID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1B0 Offset: 0x1AD2B1 VA: 0x1AD1B0
	// RVA: -1 Offset: -1
	protected float get_FadeTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98C80 Offset: 0x2C98D81 VA: 0x2C98C80
	|-AudioSourceController<Int32Enum>.get_FadeTime
	|
	|-RVA: 0x2C9DC30 Offset: 0x2C9DD31 VA: 0x2C9DC30
	|-AudioSourceController<object>.get_FadeTime
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1C0 Offset: 0x1AD2C1 VA: 0x1AD1C0
	// RVA: -1 Offset: -1
	protected void set_FadeTime(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98C90 Offset: 0x2C98D91 VA: 0x2C98C90
	|-AudioSourceController<Int32Enum>.set_FadeTime
	|
	|-RVA: 0x2C9DC40 Offset: 0x2C9DD41 VA: 0x2C9DC40
	|-AudioSourceController<object>.set_FadeTime
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual AnimationCurve get_FadeCurve() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98CA0 Offset: 0x2C98DA1 VA: 0x2C98CA0
	|-AudioSourceController<BGMID>.get_FadeCurve
	|-AudioSourceController<SoundID>.get_FadeCurve
	|-AudioSourceController<Int32Enum>.get_FadeCurve
	|
	|-RVA: 0x2C9DC50 Offset: 0x2C9DD51 VA: 0x2C9DC50
	|-AudioSourceController<object>.get_FadeCurve
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1D0 Offset: 0x1AD2D1 VA: 0x1AD1D0
	// RVA: -1 Offset: -1
	public bool get_IsPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D00 Offset: 0x2C98E01 VA: 0x2C98D00
	|-AudioSourceController<Int32Enum>.get_IsPause
	|
	|-RVA: 0x2C9DCB0 Offset: 0x2C9DDB1 VA: 0x2C9DCB0
	|-AudioSourceController<object>.get_IsPause
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1E0 Offset: 0x1AD2E1 VA: 0x1AD1E0
	// RVA: -1 Offset: -1
	protected void set_IsPause(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D10 Offset: 0x2C98E11 VA: 0x2C98D10
	|-AudioSourceController<Int32Enum>.set_IsPause
	|
	|-RVA: 0x2C9DCC0 Offset: 0x2C9DDC1 VA: 0x2C9DCC0
	|-AudioSourceController<object>.set_IsPause
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD1F0 Offset: 0x1AD2F1 VA: 0x1AD1F0
	// RVA: -1 Offset: -1
	public float get_Volume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D20 Offset: 0x2C98E21 VA: 0x2C98D20
	|-AudioSourceController<Int32Enum>.get_Volume
	|
	|-RVA: 0x2C9DCD0 Offset: 0x2C9DDD1 VA: 0x2C9DCD0
	|-AudioSourceController<object>.get_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD200 Offset: 0x1AD301 VA: 0x1AD200
	// RVA: -1 Offset: -1
	public void set_Volume(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D30 Offset: 0x2C98E31 VA: 0x2C98D30
	|-AudioSourceController<SoundID>.set_Volume
	|-AudioSourceController<Int32Enum>.set_Volume
	|
	|-RVA: 0x2C9DCE0 Offset: 0x2C9DDE1 VA: 0x2C9DCE0
	|-AudioSourceController<object>.set_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD210 Offset: 0x1AD311 VA: 0x1AD210
	// RVA: -1 Offset: -1
	protected float get_DataTable_Volume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D40 Offset: 0x2C98E41 VA: 0x2C98D40
	|-AudioSourceController<Int32Enum>.get_DataTable_Volume
	|
	|-RVA: 0x2C9DCF0 Offset: 0x2C9DDF1 VA: 0x2C9DCF0
	|-AudioSourceController<object>.get_DataTable_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD220 Offset: 0x1AD321 VA: 0x1AD220
	// RVA: -1 Offset: -1
	protected void set_DataTable_Volume(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D50 Offset: 0x2C98E51 VA: 0x2C98D50
	|-AudioSourceController<SoundID>.set_DataTable_Volume
	|-AudioSourceController<Int32Enum>.set_DataTable_Volume
	|
	|-RVA: 0x2C9DD00 Offset: 0x2C9DE01 VA: 0x2C9DD00
	|-AudioSourceController<object>.set_DataTable_Volume
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD230 Offset: 0x1AD331 VA: 0x1AD230
	// RVA: -1 Offset: -1
	public int get_Priority() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D60 Offset: 0x2C98E61 VA: 0x2C98D60
	|-AudioSourceController<BGMID>.get_Priority
	|-AudioSourceController<SoundID>.get_Priority
	|-AudioSourceController<Int32Enum>.get_Priority
	|
	|-RVA: 0x2C9DD10 Offset: 0x2C9DE11 VA: 0x2C9DD10
	|-AudioSourceController<object>.get_Priority
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD240 Offset: 0x1AD341 VA: 0x1AD240
	// RVA: -1 Offset: -1
	private void set_Priority(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D70 Offset: 0x2C98E71 VA: 0x2C98D70
	|-AudioSourceController<Int32Enum>.set_Priority
	|
	|-RVA: 0x2C9DD20 Offset: 0x2C9DE21 VA: 0x2C9DD20
	|-AudioSourceController<object>.set_Priority
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual AudioSource ReadyAudioSourceComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98D80 Offset: 0x2C98E81 VA: 0x2C98D80
	|-AudioSourceController<BGMID>.ReadyAudioSourceComponent
	|-AudioSourceController<SoundID>.ReadyAudioSourceComponent
	|-AudioSourceController<Int32Enum>.ReadyAudioSourceComponent
	|
	|-RVA: 0x2C9DD30 Offset: 0x2C9DE31 VA: 0x2C9DD30
	|-AudioSourceController<object>.ReadyAudioSourceComponent
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C98DF0 Offset: 0x2C98EF1 VA: 0x2C98DF0
	|-AudioSourceController<BGMID>.Awake
	|-AudioSourceController<SoundID>.Awake
	|-AudioSourceController<Int32Enum>.Awake
	|
	|-RVA: 0x2C9DDA0 Offset: 0x2C9DEA1 VA: 0x2C9DDA0
	|-AudioSourceController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99550 Offset: 0x2C99651 VA: 0x2C99550
	|-AudioSourceController<BGMID>.OnDestroy
	|-AudioSourceController<SoundID>.OnDestroy
	|-AudioSourceController<Int32Enum>.OnDestroy
	|
	|-RVA: 0x2C9E500 Offset: 0x2C9E601 VA: 0x2C9E500
	|-AudioSourceController<object>.OnDestroy
	*/

	// RVA: -1 Offset: -1
	public float get_PlayTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99580 Offset: 0x2C99681 VA: 0x2C99580
	|-AudioSourceController<Int32Enum>.get_PlayTime
	|
	|-RVA: 0x2C9E530 Offset: 0x2C9E631 VA: 0x2C9E530
	|-AudioSourceController<object>.get_PlayTime
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual void ResetByRemoveAllResources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C995D0 Offset: 0x2C996D1 VA: 0x2C995D0
	|-AudioSourceController<BGMID>.ResetByRemoveAllResources
	|-AudioSourceController<SoundID>.ResetByRemoveAllResources
	|-AudioSourceController<Int32Enum>.ResetByRemoveAllResources
	|
	|-RVA: 0x2C9E580 Offset: 0x2C9E681 VA: 0x2C9E580
	|-AudioSourceController<object>.ResetByRemoveAllResources
	*/

	// RVA: -1 Offset: -1
	private bool UpdateConstraintPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99730 Offset: 0x2C99831 VA: 0x2C99730
	|-AudioSourceController<Int32Enum>.UpdateConstraintPosition
	|
	|-RVA: 0x2C9E6E0 Offset: 0x2C9E7E1 VA: 0x2C9E6E0
	|-AudioSourceController<object>.UpdateConstraintPosition
	*/

	// RVA: -1 Offset: -1
	public void Pause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99830 Offset: 0x2C99931 VA: 0x2C99830
	|-AudioSourceController<BGMID>.Pause
	|-AudioSourceController<SoundID>.Pause
	|-AudioSourceController<Int32Enum>.Pause
	|
	|-RVA: 0x2C9E7E0 Offset: 0x2C9E8E1 VA: 0x2C9E7E0
	|-AudioSourceController<object>.Pause
	*/

	// RVA: -1 Offset: -1
	public void UnPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99990 Offset: 0x2C99A91 VA: 0x2C99990
	|-AudioSourceController<BGMID>.UnPause
	|-AudioSourceController<SoundID>.UnPause
	|-AudioSourceController<Int32Enum>.UnPause
	|
	|-RVA: 0x2C9E940 Offset: 0x2C9EA41 VA: 0x2C9E940
	|-AudioSourceController<object>.UnPause
	*/

	// RVA: -1 Offset: -1
	public bool IsPlaying() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99A80 Offset: 0x2C99B81 VA: 0x2C99A80
	|-AudioSourceController<SoundID>.IsPlaying
	|-AudioSourceController<Int32Enum>.IsPlaying
	|
	|-RVA: 0x2C9EA30 Offset: 0x2C9EB31 VA: 0x2C9EA30
	|-AudioSourceController<object>.IsPlaying
	*/

	// RVA: -1 Offset: -1
	public bool IsDoneLoad() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99C70 Offset: 0x2C99D71 VA: 0x2C99C70
	|-AudioSourceController<SoundID>.IsDoneLoad
	|-AudioSourceController<Int32Enum>.IsDoneLoad
	|
	|-RVA: 0x2C9EC20 Offset: 0x2C9ED21 VA: 0x2C9EC20
	|-AudioSourceController<object>.IsDoneLoad
	*/

	// RVA: -1 Offset: -1
	public AudioSourceController.State<IDType> get_GetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99E50 Offset: 0x2C99F51 VA: 0x2C99E50
	|-AudioSourceController<BGMID>.get_GetState
	|-AudioSourceController<SoundID>.get_GetState
	|-AudioSourceController<Int32Enum>.get_GetState
	|
	|-RVA: 0x2C9EE00 Offset: 0x2C9EF01 VA: 0x2C9EE00
	|-AudioSourceController<object>.get_GetState
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IDType get_EmptyValue() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.get_EmptyValue
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual void DoPlay(IDType id, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C99EE0 Offset: 0x2C99FE1 VA: 0x2C99EE0
	|-AudioSourceController<BGMID>.DoPlay
	|-AudioSourceController<SoundID>.DoPlay
	|-AudioSourceController<Int32Enum>.DoPlay
	|
	|-RVA: 0x2C9EE90 Offset: 0x2C9EF91 VA: 0x2C9EE90
	|-AudioSourceController<object>.DoPlay
	*/

	// RVA: -1 Offset: -1
	public void DoPlayForTimeline(IDType id, bool isLoop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A160 Offset: 0x2C9A261 VA: 0x2C9A160
	|-AudioSourceController<SoundID>.DoPlayForTimeline
	|-AudioSourceController<Int32Enum>.DoPlayForTimeline
	|
	|-RVA: 0x2C9F0E0 Offset: 0x2C9F1E1 VA: 0x2C9F0E0
	|-AudioSourceController<object>.DoPlayForTimeline
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual void DoResume() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A190 Offset: 0x2C9A291 VA: 0x2C9A190
	|-AudioSourceController<BGMID>.DoResume
	|-AudioSourceController<SoundID>.DoResume
	|-AudioSourceController<Int32Enum>.DoResume
	|
	|-RVA: 0x2C9F110 Offset: 0x2C9F211 VA: 0x2C9F110
	|-AudioSourceController<object>.DoResume
	*/

	// RVA: -1 Offset: -1
	public void DoFadeIn(IDType id, float fadetime = 3, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A210 Offset: 0x2C9A311 VA: 0x2C9A210
	|-AudioSourceController<BGMID>.DoFadeIn
	|-AudioSourceController<SoundID>.DoFadeIn
	|-AudioSourceController<Int32Enum>.DoFadeIn
	|
	|-RVA: 0x2C9F190 Offset: 0x2C9F291 VA: 0x2C9F190
	|-AudioSourceController<object>.DoFadeIn
	*/

	// RVA: -1 Offset: -1
	public void DoFadeOut(float fadetime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A3D0 Offset: 0x2C9A4D1 VA: 0x2C9A3D0
	|-AudioSourceController<BGMID>.DoFadeOut
	|-AudioSourceController<SoundID>.DoFadeOut
	|-AudioSourceController<Int32Enum>.DoFadeOut
	|
	|-RVA: 0x2C9F320 Offset: 0x2C9F421 VA: 0x2C9F320
	|-AudioSourceController<object>.DoFadeOut
	*/

	// RVA: -1 Offset: -1
	public void DoStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A470 Offset: 0x2C9A571 VA: 0x2C9A470
	|-AudioSourceController<BGMID>.DoStop
	|-AudioSourceController<SoundID>.DoStop
	|-AudioSourceController<Int32Enum>.DoStop
	|
	|-RVA: 0x2C9F3C0 Offset: 0x2C9F4C1 VA: 0x2C9F3C0
	|-AudioSourceController<object>.DoStop
	*/

	// RVA: -1 Offset: -1
	public void DoImmediateStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A510 Offset: 0x2C9A611 VA: 0x2C9A510
	|-AudioSourceController<BGMID>.DoImmediateStop
	|-AudioSourceController<SoundID>.DoImmediateStop
	|-AudioSourceController<Int32Enum>.DoImmediateStop
	|
	|-RVA: 0x2C9F460 Offset: 0x2C9F561 VA: 0x2C9F460
	|-AudioSourceController<object>.DoImmediateStop
	*/

	// RVA: -1 Offset: -1
	public void SetCustomRolloffCurve(AnimationCurve animationCurve) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A590 Offset: 0x2C9A691 VA: 0x2C9A590
	|-AudioSourceController<Int32Enum>.SetCustomRolloffCurve
	|
	|-RVA: 0x2C9F4E0 Offset: 0x2C9F5E1 VA: 0x2C9F4E0
	|-AudioSourceController<object>.SetCustomRolloffCurve
	*/

	// RVA: -1 Offset: -1
	public void LoadWithWait(IDType id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A670 Offset: 0x2C9A771 VA: 0x2C9A670
	|-AudioSourceController<SoundID>.LoadWithWait
	|-AudioSourceController<Int32Enum>.LoadWithWait
	|
	|-RVA: 0x2C9F5C0 Offset: 0x2C9F6C1 VA: 0x2C9F5C0
	|-AudioSourceController<object>.LoadWithWait
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract AudioMixerGroup GetOutputMixer(IDType id) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.GetOutputMixer
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void SetupBeforePlayByDataTable() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.SetupBeforePlayByDataTable
	*/

	// RVA: -1 Offset: -1
	private void NotInit_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A710 Offset: 0x2C9A811 VA: 0x2C9A710
	|-AudioSourceController<Int32Enum>.NotInit_Enter
	|
	|-RVA: 0x2C9F660 Offset: 0x2C9F761 VA: 0x2C9F660
	|-AudioSourceController<object>.NotInit_Enter
	*/

	// RVA: -1 Offset: -1
	private void Play_internal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9A810 Offset: 0x2C9A911 VA: 0x2C9A810
	|-AudioSourceController<Int32Enum>.Play_internal
	|
	|-RVA: 0x2C9F760 Offset: 0x2C9F861 VA: 0x2C9F760
	|-AudioSourceController<object>.Play_internal
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void Loading_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.Loading_Enter
	*/

	// RVA: -1 Offset: -1
	protected void Loading_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9AB30 Offset: 0x2C9AC31 VA: 0x2C9AB30
	|-AudioSourceController<Int32Enum>.Loading_Update
	|
	|-RVA: 0x2C9FA80 Offset: 0x2C9FB81 VA: 0x2C9FA80
	|-AudioSourceController<object>.Loading_Update
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void Play_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9AD10 Offset: 0x2C9AE11 VA: 0x2C9AD10
	|-AudioSourceController<BGMID>.Play_Enter
	|-AudioSourceController<SoundID>.Play_Enter
	|-AudioSourceController<Int32Enum>.Play_Enter
	|
	|-RVA: 0x2C9FC60 Offset: 0x2C9FD61 VA: 0x2C9FC60
	|-AudioSourceController<object>.Play_Enter
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual void Play_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9ADF0 Offset: 0x2C9AEF1 VA: 0x2C9ADF0
	|-AudioSourceController<BGMID>.Play_Update
	|-AudioSourceController<SoundID>.Play_Update
	|-AudioSourceController<Int32Enum>.Play_Update
	|
	|-RVA: 0x2C9FD40 Offset: 0x2C9FE41 VA: 0x2C9FD40
	|-AudioSourceController<object>.Play_Update
	*/

	// RVA: -1 Offset: -1
	protected void Play_Exit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B100 Offset: 0x2C9B201 VA: 0x2C9B100
	|-AudioSourceController<Int32Enum>.Play_Exit
	|
	|-RVA: 0x2CA0050 Offset: 0x2CA0151 VA: 0x2CA0050
	|-AudioSourceController<object>.Play_Exit
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_IsLoopClip() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AudioSourceController<object>.get_IsLoopClip
	*/

	// RVA: -1 Offset: -1
	public bool get_IsLoopAudioSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B110 Offset: 0x2C9B211 VA: 0x2C9B110
	|-AudioSourceController<Int32Enum>.get_IsLoopAudioSource
	|
	|-RVA: 0x2CA0060 Offset: 0x2CA0161 VA: 0x2CA0060
	|-AudioSourceController<object>.get_IsLoopAudioSource
	*/

	// RVA: -1 Offset: -1
	protected void FadeIn_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B150 Offset: 0x2C9B251 VA: 0x2C9B150
	|-AudioSourceController<Int32Enum>.FadeIn_Enter
	|
	|-RVA: 0x2CA00A0 Offset: 0x2CA01A1 VA: 0x2CA00A0
	|-AudioSourceController<object>.FadeIn_Enter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	protected virtual void FadeIn_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B230 Offset: 0x2C9B331 VA: 0x2C9B230
	|-AudioSourceController<BGMID>.FadeIn_Update
	|-AudioSourceController<SoundID>.FadeIn_Update
	|-AudioSourceController<Int32Enum>.FadeIn_Update
	|
	|-RVA: 0x2CA0180 Offset: 0x2CA0281 VA: 0x2CA0180
	|-AudioSourceController<object>.FadeIn_Update
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected virtual void FadeOut_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B510 Offset: 0x2C9B611 VA: 0x2C9B510
	|-AudioSourceController<BGMID>.FadeOut_Update
	|-AudioSourceController<SoundID>.FadeOut_Update
	|-AudioSourceController<Int32Enum>.FadeOut_Update
	|
	|-RVA: 0x2CA0460 Offset: 0x2CA0561 VA: 0x2CA0460
	|-AudioSourceController<object>.FadeOut_Update
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected virtual void Done_Enter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B780 Offset: 0x2C9B881 VA: 0x2C9B780
	|-AudioSourceController<BGMID>.Done_Enter
	|-AudioSourceController<SoundID>.Done_Enter
	|-AudioSourceController<Int32Enum>.Done_Enter
	|
	|-RVA: 0x2CA06D0 Offset: 0x2CA07D1 VA: 0x2CA06D0
	|-AudioSourceController<object>.Done_Enter
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B870 Offset: 0x2C9B971 VA: 0x2C9B870
	|-AudioSourceController<BGMID>..ctor
	|-AudioSourceController<SoundID>..ctor
	|-AudioSourceController<Int32Enum>..ctor
	|
	|-RVA: 0x2CA07C0 Offset: 0x2CA08C1 VA: 0x2CA07C0
	|-AudioSourceController<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B890 Offset: 0x2C9B991 VA: 0x2C9B890
	|-AudioSourceController<Int32Enum>..cctor
	|
	|-RVA: 0x2CA07E0 Offset: 0x2CA08E1 VA: 0x2CA07E0
	|-AudioSourceController<object>..cctor
	*/
}


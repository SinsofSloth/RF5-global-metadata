[Serializable]
public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver // TypeDefIndex: 4546
{
	// Fields
	private const int k_LatestVersion = 1;
	[SerializeField] // RVA: 0x12B370 Offset: 0x12B471 VA: 0x12B370
	[HideInInspector] // RVA: 0x12B370 Offset: 0x12B471 VA: 0x12B370
	private int m_Version; // 0x10
	public static readonly ClipCaps kDefaultClipCaps; // 0x0
	public static readonly float kDefaultClipDurationInSeconds; // 0x4
	public static readonly double kTimeScaleMin; // 0x8
	public static readonly double kTimeScaleMax; // 0x10
	internal static readonly string kDefaultCurvesName; // 0x18
	internal static readonly double kMinDuration; // 0x20
	internal static readonly double kMaxTimeValue; // 0x28
	[SerializeField] // RVA: 0x12B3B0 Offset: 0x12B4B1 VA: 0x12B3B0
	private double m_Start; // 0x18
	[SerializeField] // RVA: 0x12B3C0 Offset: 0x12B4C1 VA: 0x12B3C0
	private double m_ClipIn; // 0x20
	[SerializeField] // RVA: 0x12B3D0 Offset: 0x12B4D1 VA: 0x12B3D0
	private Object m_Asset; // 0x28
	[SerializeField] // RVA: 0x12B3E0 Offset: 0x12B4E1 VA: 0x12B3E0
	[FormerlySerializedAsAttribute] // RVA: 0x12B3E0 Offset: 0x12B4E1 VA: 0x12B3E0
	private double m_Duration; // 0x30
	[SerializeField] // RVA: 0x12B430 Offset: 0x12B531 VA: 0x12B430
	private double m_TimeScale; // 0x38
	[SerializeField] // RVA: 0x12B440 Offset: 0x12B541 VA: 0x12B440
	private TrackAsset m_ParentTrack; // 0x40
	[SerializeField] // RVA: 0x12B450 Offset: 0x12B551 VA: 0x12B450
	private double m_EaseInDuration; // 0x48
	[SerializeField] // RVA: 0x12B460 Offset: 0x12B561 VA: 0x12B460
	private double m_EaseOutDuration; // 0x50
	[SerializeField] // RVA: 0x12B470 Offset: 0x12B571 VA: 0x12B470
	private double m_BlendInDuration; // 0x58
	[SerializeField] // RVA: 0x12B480 Offset: 0x12B581 VA: 0x12B480
	private double m_BlendOutDuration; // 0x60
	[SerializeField] // RVA: 0x12B490 Offset: 0x12B591 VA: 0x12B490
	private AnimationCurve m_MixInCurve; // 0x68
	[SerializeField] // RVA: 0x12B4A0 Offset: 0x12B5A1 VA: 0x12B4A0
	private AnimationCurve m_MixOutCurve; // 0x70
	[SerializeField] // RVA: 0x12B4B0 Offset: 0x12B5B1 VA: 0x12B4B0
	private TimelineClip.BlendCurveMode m_BlendInCurveMode; // 0x78
	[SerializeField] // RVA: 0x12B4C0 Offset: 0x12B5C1 VA: 0x12B4C0
	private TimelineClip.BlendCurveMode m_BlendOutCurveMode; // 0x7C
	[SerializeField] // RVA: 0x12B4D0 Offset: 0x12B5D1 VA: 0x12B4D0
	private List<string> m_ExposedParameterNames; // 0x80
	[SerializeField] // RVA: 0x12B4E0 Offset: 0x12B5E1 VA: 0x12B4E0
	private AnimationClip m_AnimationCurves; // 0x88
	[SerializeField] // RVA: 0x12B4F0 Offset: 0x12B5F1 VA: 0x12B4F0
	private bool m_Recordable; // 0x90
	[SerializeField] // RVA: 0x12B500 Offset: 0x12B601 VA: 0x12B500
	private TimelineClip.ClipExtrapolation m_PostExtrapolationMode; // 0x94
	[SerializeField] // RVA: 0x12B510 Offset: 0x12B611 VA: 0x12B510
	private TimelineClip.ClipExtrapolation m_PreExtrapolationMode; // 0x98
	[SerializeField] // RVA: 0x12B520 Offset: 0x12B621 VA: 0x12B520
	private double m_PostExtrapolationTime; // 0xA0
	[SerializeField] // RVA: 0x12B530 Offset: 0x12B631 VA: 0x12B530
	private double m_PreExtrapolationTime; // 0xA8
	[SerializeField] // RVA: 0x12B540 Offset: 0x12B641 VA: 0x12B540
	private string m_DisplayName; // 0xB0

	// Properties
	public bool hasPreExtrapolation { get; }
	public bool hasPostExtrapolation { get; }
	public double timeScale { get; set; }
	public double start { get; set; }
	public double duration { get; set; }
	public double end { get; }
	public double clipIn { get; set; }
	public string displayName { get; set; }
	public double clipAssetDuration { get; }
	public AnimationClip curves { get; set; }
	private string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; }
	public bool hasCurves { get; }
	public Object asset { get; set; }
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; }
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; }
	[ObsoleteAttribute] // RVA: 0x12C9F0 Offset: 0x12CAF1 VA: 0x12C9F0
	public Object underlyingAsset { get; set; }
	public TrackAsset parentTrack { get; set; }
	public double easeInDuration { get; set; }
	public double easeOutDuration { get; set; }
	[ObsoleteAttribute] // RVA: 0x12CA30 Offset: 0x12CB31 VA: 0x12CA30
	public double eastOutTime { get; }
	public double easeOutTime { get; }
	public double blendInDuration { get; set; }
	public double blendOutDuration { get; set; }
	public TimelineClip.BlendCurveMode blendInCurveMode { get; set; }
	public TimelineClip.BlendCurveMode blendOutCurveMode { get; set; }
	public bool hasBlendIn { get; }
	public bool hasBlendOut { get; }
	public AnimationCurve mixInCurve { get; set; }
	public float mixInPercentage { get; }
	public double mixInDuration { get; }
	public AnimationCurve mixOutCurve { get; set; }
	public double mixOutTime { get; }
	public double mixOutDuration { get; }
	public float mixOutPercentage { get; }
	public bool recordable { get; set; }
	[ObsoleteAttribute] // RVA: 0x12CA70 Offset: 0x12CB71 VA: 0x12CA70
	public List<string> exposedParameters { get; }
	public ClipCaps clipCaps { get; }
	public AnimationClip animationClip { get; }
	public TimelineClip.ClipExtrapolation postExtrapolationMode { get; set; }
	public TimelineClip.ClipExtrapolation preExtrapolationMode { get; set; }
	public double extrapolatedStart { get; }
	public double extrapolatedDuration { get; }

	// Methods

	// RVA: 0x1B38520 Offset: 0x1B38621 VA: 0x1B38520
	private void UpgradeToLatestVersion() { }

	// RVA: 0x1B385A0 Offset: 0x1B386A1 VA: 0x1B385A0
	internal void .ctor(TrackAsset parent) { }

	// RVA: 0x1B38760 Offset: 0x1B38861 VA: 0x1B38760
	public bool get_hasPreExtrapolation() { }

	// RVA: 0x1B38780 Offset: 0x1B38881 VA: 0x1B38780
	public bool get_hasPostExtrapolation() { }

	// RVA: 0x1B387A0 Offset: 0x1B388A1 VA: 0x1B387A0
	public double get_timeScale() { }

	// RVA: 0x1B38980 Offset: 0x1B38A81 VA: 0x1B38980
	public void set_timeScale(double value) { }

	// RVA: 0x1B38A80 Offset: 0x1B38B81 VA: 0x1B38A80
	public double get_start() { }

	// RVA: 0x1B38A90 Offset: 0x1B38B91 VA: 0x1B38A90
	public void set_start(double value) { }

	// RVA: 0x1B38D30 Offset: 0x1B38E31 VA: 0x1B38D30 Slot: 6
	public double get_duration() { }

	// RVA: 0x1B38D40 Offset: 0x1B38E41 VA: 0x1B38D40
	public void set_duration(double value) { }

	// RVA: 0x1B38E00 Offset: 0x1B38F01 VA: 0x1B38E00
	public double get_end() { }

	// RVA: 0x1B38E10 Offset: 0x1B38F11 VA: 0x1B38E10
	public double get_clipIn() { }

	// RVA: 0x1B38E50 Offset: 0x1B38F51 VA: 0x1B38E50
	public void set_clipIn(double value) { }

	// RVA: 0x1B38F40 Offset: 0x1B39041 VA: 0x1B38F40
	public string get_displayName() { }

	// RVA: 0x1B38F50 Offset: 0x1B39051 VA: 0x1B38F50
	public void set_displayName(string value) { }

	// RVA: 0x1B38F60 Offset: 0x1B39061 VA: 0x1B38F60
	public double get_clipAssetDuration() { }

	// RVA: 0x1B39030 Offset: 0x1B39131 VA: 0x1B39030 Slot: 4
	public AnimationClip get_curves() { }

	// RVA: 0x1B39040 Offset: 0x1B39141 VA: 0x1B39040
	internal void set_curves(AnimationClip value) { }

	// RVA: 0x1B39050 Offset: 0x1B39151 VA: 0x1B39050 Slot: 8
	private string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	// RVA: 0x1B390C0 Offset: 0x1B391C1 VA: 0x1B390C0 Slot: 5
	public bool get_hasCurves() { }

	// RVA: 0x1B39170 Offset: 0x1B39271 VA: 0x1B39170 Slot: 9
	public Object get_asset() { }

	// RVA: 0x1B39180 Offset: 0x1B39281 VA: 0x1B39180
	public void set_asset(Object value) { }

	// RVA: 0x1B39190 Offset: 0x1B39291 VA: 0x1B39190 Slot: 10
	private Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	// RVA: 0x1B391A0 Offset: 0x1B392A1 VA: 0x1B391A0 Slot: 11
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	// RVA: 0x1B391B0 Offset: 0x1B392B1 VA: 0x1B391B0
	public Object get_underlyingAsset() { }

	// RVA: 0x1B391C0 Offset: 0x1B392C1 VA: 0x1B391C0
	public void set_underlyingAsset(Object value) { }

	// RVA: 0x1B391D0 Offset: 0x1B392D1 VA: 0x1B391D0
	public TrackAsset get_parentTrack() { }

	// RVA: 0x1B385E0 Offset: 0x1B386E1 VA: 0x1B385E0
	public void set_parentTrack(TrackAsset value) { }

	// RVA: 0x1B39310 Offset: 0x1B39411 VA: 0x1B39310
	public double get_easeInDuration() { }

	// RVA: 0x1B393C0 Offset: 0x1B394C1 VA: 0x1B393C0
	public void set_easeInDuration(double value) { }

	// RVA: 0x1B394B0 Offset: 0x1B395B1 VA: 0x1B394B0
	public double get_easeOutDuration() { }

	// RVA: 0x1B39560 Offset: 0x1B39661 VA: 0x1B39560
	public void set_easeOutDuration(double value) { }

	// RVA: 0x1B39650 Offset: 0x1B39751 VA: 0x1B39650
	public double get_eastOutTime() { }

	// RVA: 0x1B39700 Offset: 0x1B39801 VA: 0x1B39700
	public double get_easeOutTime() { }

	// RVA: 0x1B397B0 Offset: 0x1B398B1 VA: 0x1B397B0
	public double get_blendInDuration() { }

	// RVA: 0x1B397F0 Offset: 0x1B398F1 VA: 0x1B397F0
	public void set_blendInDuration(double value) { }

	// RVA: 0x1B39890 Offset: 0x1B39991 VA: 0x1B39890
	public double get_blendOutDuration() { }

	// RVA: 0x1B398D0 Offset: 0x1B399D1 VA: 0x1B398D0
	public void set_blendOutDuration(double value) { }

	// RVA: 0x1B39970 Offset: 0x1B39A71 VA: 0x1B39970
	public TimelineClip.BlendCurveMode get_blendInCurveMode() { }

	// RVA: 0x1B39980 Offset: 0x1B39A81 VA: 0x1B39980
	public void set_blendInCurveMode(TimelineClip.BlendCurveMode value) { }

	// RVA: 0x1B39990 Offset: 0x1B39A91 VA: 0x1B39990
	public TimelineClip.BlendCurveMode get_blendOutCurveMode() { }

	// RVA: 0x1B399A0 Offset: 0x1B39AA1 VA: 0x1B399A0
	public void set_blendOutCurveMode(TimelineClip.BlendCurveMode value) { }

	// RVA: 0x1B399B0 Offset: 0x1B39AB1 VA: 0x1B399B0
	public bool get_hasBlendIn() { }

	// RVA: 0x1B399F0 Offset: 0x1B39AF1 VA: 0x1B399F0
	public bool get_hasBlendOut() { }

	// RVA: 0x1B39A30 Offset: 0x1B39B31 VA: 0x1B39A30
	public AnimationCurve get_mixInCurve() { }

	// RVA: 0x1B39B00 Offset: 0x1B39C01 VA: 0x1B39B00
	public void set_mixInCurve(AnimationCurve value) { }

	// RVA: 0x1B39B10 Offset: 0x1B39C11 VA: 0x1B39B10
	public float get_mixInPercentage() { }

	// RVA: 0x1B39B40 Offset: 0x1B39C41 VA: 0x1B39B40
	public double get_mixInDuration() { }

	// RVA: 0x1B39C30 Offset: 0x1B39D31 VA: 0x1B39C30
	public AnimationCurve get_mixOutCurve() { }

	// RVA: 0x1B39D00 Offset: 0x1B39E01 VA: 0x1B39D00
	public void set_mixOutCurve(AnimationCurve value) { }

	// RVA: 0x1B39D10 Offset: 0x1B39E11 VA: 0x1B39D10
	public double get_mixOutTime() { }

	// RVA: 0x1B39D50 Offset: 0x1B39E51 VA: 0x1B39D50
	public double get_mixOutDuration() { }

	// RVA: 0x1B39E40 Offset: 0x1B39F41 VA: 0x1B39E40
	public float get_mixOutPercentage() { }

	// RVA: 0x1B39E70 Offset: 0x1B39F71 VA: 0x1B39E70
	public bool get_recordable() { }

	// RVA: 0x1B39E80 Offset: 0x1B39F81 VA: 0x1B39E80
	internal void set_recordable(bool value) { }

	// RVA: 0x1B39E90 Offset: 0x1B39F91 VA: 0x1B39E90
	public List<string> get_exposedParameters() { }

	// RVA: 0x1B38880 Offset: 0x1B38981 VA: 0x1B38880
	public ClipCaps get_clipCaps() { }

	// RVA: 0x1B39F30 Offset: 0x1B3A031 VA: 0x1B39F30
	internal int Hash() { }

	// RVA: 0x1B39FF0 Offset: 0x1B3A0F1 VA: 0x1B39FF0
	public float EvaluateMixOut(double time) { }

	// RVA: 0x1B3A130 Offset: 0x1B3A231 VA: 0x1B3A130
	public float EvaluateMixIn(double time) { }

	// RVA: 0x1B39AE0 Offset: 0x1B39BE1 VA: 0x1B39AE0
	private static AnimationCurve GetDefaultMixInCurve() { }

	// RVA: 0x1B39CE0 Offset: 0x1B39DE1 VA: 0x1B39CE0
	private static AnimationCurve GetDefaultMixOutCurve() { }

	// RVA: 0x1B3A250 Offset: 0x1B3A351 VA: 0x1B3A250
	public double ToLocalTime(double time) { }

	// RVA: 0x1B3A610 Offset: 0x1B3A711 VA: 0x1B3A610
	public double ToLocalTimeUnbound(double time) { }

	// RVA: 0x1B3A670 Offset: 0x1B3A771 VA: 0x1B3A670
	internal double FromLocalTimeUnbound(double time) { }

	// RVA: 0x1B3A6D0 Offset: 0x1B3A7D1 VA: 0x1B3A6D0
	public AnimationClip get_animationClip() { }

	// RVA: 0x1B38BA0 Offset: 0x1B38CA1 VA: 0x1B38BA0
	private static double SanitizeTimeValue(double value, double defaultValue) { }

	// RVA: 0x1B3A7F0 Offset: 0x1B3A8F1 VA: 0x1B3A7F0
	public TimelineClip.ClipExtrapolation get_postExtrapolationMode() { }

	// RVA: 0x1B3A830 Offset: 0x1B3A931 VA: 0x1B3A830
	internal void set_postExtrapolationMode(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x1B3A870 Offset: 0x1B3A971 VA: 0x1B3A870
	public TimelineClip.ClipExtrapolation get_preExtrapolationMode() { }

	// RVA: 0x1B3A8B0 Offset: 0x1B3A9B1 VA: 0x1B3A8B0
	internal void set_preExtrapolationMode(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x1B3A8F0 Offset: 0x1B3A9F1 VA: 0x1B3A8F0
	internal void SetPostExtrapolationTime(double time) { }

	// RVA: 0x1B3A900 Offset: 0x1B3AA01 VA: 0x1B3A900
	internal void SetPreExtrapolationTime(double time) { }

	// RVA: 0x1B3A910 Offset: 0x1B3AA11 VA: 0x1B3A910
	public bool IsExtrapolatedTime(double sequenceTime) { }

	// RVA: 0x1B3A3A0 Offset: 0x1B3A4A1 VA: 0x1B3A3A0
	public bool IsPreExtrapolatedTime(double sequenceTime) { }

	// RVA: 0x1B3A570 Offset: 0x1B3A671 VA: 0x1B3A570
	public bool IsPostExtrapolatedTime(double sequenceTime) { }

	// RVA: 0x1B3A9F0 Offset: 0x1B3AAF1 VA: 0x1B3A9F0
	public double get_extrapolatedStart() { }

	// RVA: 0x1B3AA10 Offset: 0x1B3AB11 VA: 0x1B3AA10
	public double get_extrapolatedDuration() { }

	// RVA: 0x1B3A430 Offset: 0x1B3A531 VA: 0x1B3A430
	private static double GetExtrapolatedTime(double time, TimelineClip.ClipExtrapolation mode, double duration) { }

	// RVA: 0x1B3AAF0 Offset: 0x1B3ABF1 VA: 0x1B3AAF0 Slot: 7
	public void CreateCurves(string curvesClipName) { }

	// RVA: 0x1B3ADB0 Offset: 0x1B3AEB1 VA: 0x1B3ADB0 Slot: 12
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1B3ADC0 Offset: 0x1B3AEC1 VA: 0x1B3ADC0 Slot: 13
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x1B3AE00 Offset: 0x1B3AF01 VA: 0x1B3AE00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B3B020 Offset: 0x1B3B121 VA: 0x1B3B020
	public void ConformEaseValues() { }

	// RVA: 0x1B3B180 Offset: 0x1B3B281 VA: 0x1B3B180
	private static double CalculateEasingRatio(double easeIn, double easeOut) { }

	// RVA: 0x1B38A70 Offset: 0x1B38B71 VA: 0x1B38A70
	private void UpdateDirty(double oldValue, double newValue) { }

	// RVA: 0x1B3B270 Offset: 0x1B3B371 VA: 0x1B3B270
	private static void .cctor() { }
}


[Serializable]
public class KeyframeGroup<T> : IKeyframeGroup // TypeDefIndex: 9641
{
	// Fields
	public List<T> keyframes; // 0x0
	[SerializeField] // RVA: 0x17D780 Offset: 0x17D881 VA: 0x17D780
	private string m_Name; // 0x0
	[SerializeField] // RVA: 0x17D790 Offset: 0x17D891 VA: 0x17D790
	private string m_Id; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17D7A0 Offset: 0x17D8A1 VA: 0x17D7A0
	private int <propertyId>k__BackingField; // 0x0

	// Properties
	public string name { get; set; }
	public string id { get; set; }
	public int propertyId { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public string get_name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C10 Offset: 0x2D21D11 VA: 0x2D21C10
	|-KeyframeGroup<BoolKeyframe>.get_name
	|-KeyframeGroup<ColorKeyframe>.get_name
	|-KeyframeGroup<NumberKeyframe>.get_name
	|-KeyframeGroup<SpherePointKeyframe>.get_name
	|-KeyframeGroup<TextureKeyframe>.get_name
	|-KeyframeGroup<object>.get_name
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_name(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C20 Offset: 0x2D21D21 VA: 0x2D21C20
	|-KeyframeGroup<BoolKeyframe>.set_name
	|-KeyframeGroup<ColorKeyframe>.set_name
	|-KeyframeGroup<NumberKeyframe>.set_name
	|-KeyframeGroup<SpherePointKeyframe>.set_name
	|-KeyframeGroup<TextureKeyframe>.set_name
	|-KeyframeGroup<object>.set_name
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public string get_id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C30 Offset: 0x2D21D31 VA: 0x2D21C30
	|-KeyframeGroup<BoolKeyframe>.get_id
	|-KeyframeGroup<ColorKeyframe>.get_id
	|-KeyframeGroup<NumberKeyframe>.get_id
	|-KeyframeGroup<SpherePointKeyframe>.get_id
	|-KeyframeGroup<TextureKeyframe>.get_id
	|-KeyframeGroup<object>.get_id
	*/

	// RVA: -1 Offset: -1
	public void set_id(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C40 Offset: 0x2D21D41 VA: 0x2D21C40
	|-KeyframeGroup<object>.set_id
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AC5D0 Offset: 0x1AC6D1 VA: 0x1AC5D0
	// RVA: -1 Offset: -1
	public int get_propertyId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C50 Offset: 0x2D21D51 VA: 0x2D21C50
	|-KeyframeGroup<BoolKeyframe>.get_propertyId
	|-KeyframeGroup<ColorKeyframe>.get_propertyId
	|-KeyframeGroup<NumberKeyframe>.get_propertyId
	|-KeyframeGroup<TextureKeyframe>.get_propertyId
	|-KeyframeGroup<object>.get_propertyId
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AC5E0 Offset: 0x1AC6E1 VA: 0x1AC5E0
	// RVA: -1 Offset: -1
	public void set_propertyId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C60 Offset: 0x2D21D61 VA: 0x2D21C60
	|-KeyframeGroup<BoolKeyframe>.set_propertyId
	|-KeyframeGroup<ColorKeyframe>.set_propertyId
	|-KeyframeGroup<NumberKeyframe>.set_propertyId
	|-KeyframeGroup<TextureKeyframe>.set_propertyId
	|-KeyframeGroup<object>.set_propertyId
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C70 Offset: 0x2D21D71 VA: 0x2D21C70
	|-KeyframeGroup<BoolKeyframe>..ctor
	|-KeyframeGroup<ColorKeyframe>..ctor
	|-KeyframeGroup<NumberKeyframe>..ctor
	|-KeyframeGroup<SpherePointKeyframe>..ctor
	|-KeyframeGroup<TextureKeyframe>..ctor
	|-KeyframeGroup<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21DA0 Offset: 0x2D21EA1 VA: 0x2D21DA0
	|-KeyframeGroup<BoolKeyframe>.AddKeyFrame
	|-KeyframeGroup<ColorKeyframe>.AddKeyFrame
	|-KeyframeGroup<NumberKeyframe>.AddKeyFrame
	|-KeyframeGroup<SpherePointKeyframe>.AddKeyFrame
	|-KeyframeGroup<TextureKeyframe>.AddKeyFrame
	|-KeyframeGroup<object>.AddKeyFrame
	*/

	// RVA: -1 Offset: -1
	public void RemoveKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21E00 Offset: 0x2D21F01 VA: 0x2D21E00
	|-KeyframeGroup<ColorKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<NumberKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<object>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void RemoveKeyFrame(IBaseKeyframe keyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21EF0 Offset: 0x2D21FF1 VA: 0x2D21EF0
	|-KeyframeGroup<BoolKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<ColorKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<NumberKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<SpherePointKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<TextureKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<object>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int GetKeyFrameCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21F90 Offset: 0x2D22091 VA: 0x2D21F90
	|-KeyframeGroup<BoolKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<ColorKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<NumberKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<SpherePointKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<TextureKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<object>.GetKeyFrameCount
	*/

	// RVA: -1 Offset: -1
	public T GetKeyframe(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21FC0 Offset: 0x2D220C1 VA: 0x2D21FC0
	|-KeyframeGroup<BoolKeyframe>.GetKeyframe
	|-KeyframeGroup<ColorKeyframe>.GetKeyframe
	|-KeyframeGroup<NumberKeyframe>.GetKeyframe
	|-KeyframeGroup<SpherePointKeyframe>.GetKeyframe
	|-KeyframeGroup<TextureKeyframe>.GetKeyframe
	|-KeyframeGroup<object>.GetKeyframe
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SortKeyframes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21FF0 Offset: 0x2D220F1 VA: 0x2D21FF0
	|-KeyframeGroup<BoolKeyframe>.SortKeyframes
	|-KeyframeGroup<ColorKeyframe>.SortKeyframes
	|-KeyframeGroup<NumberKeyframe>.SortKeyframes
	|-KeyframeGroup<SpherePointKeyframe>.SortKeyframes
	|-KeyframeGroup<TextureKeyframe>.SortKeyframes
	|-KeyframeGroup<object>.SortKeyframes
	*/

	// RVA: -1 Offset: -1
	public float CurveAdjustedBlendingTime(InterpolationCurve curve, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22020 Offset: 0x2D22121 VA: 0x2D22020
	|-KeyframeGroup<ColorKeyframe>.CurveAdjustedBlendingTime
	|-KeyframeGroup<SpherePointKeyframe>.CurveAdjustedBlendingTime
	|-KeyframeGroup<object>.CurveAdjustedBlendingTime
	*/

	// RVA: -1 Offset: -1
	public T GetPreviousKeyFrame(float time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D220E0 Offset: 0x2D221E1 VA: 0x2D220E0
	|-KeyframeGroup<ColorKeyframe>.GetPreviousKeyFrame
	|-KeyframeGroup<NumberKeyframe>.GetPreviousKeyFrame
	|-KeyframeGroup<object>.GetPreviousKeyFrame
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22130 Offset: 0x2D22231 VA: 0x2D22130
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22200 Offset: 0x2D22301 VA: 0x2D22200
	|-KeyframeGroup<BoolKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<ColorKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<NumberKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<SpherePointKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<TextureKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22470 Offset: 0x2D22571 VA: 0x2D22470
	|-KeyframeGroup<ColorKeyframe>.ProgressBetweenSurroundingKeyframes
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22520 Offset: 0x2D22621 VA: 0x2D22520
	|-KeyframeGroup<SpherePointKeyframe>.ProgressBetweenSurroundingKeyframes
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float WidthBetweenCircularValues(float begin, float end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22680 Offset: 0x2D22781 VA: 0x2D22680
	|-KeyframeGroup<object>.WidthBetweenCircularValues
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void TrimToSingleKeyframe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D226A0 Offset: 0x2D227A1 VA: 0x2D226A0
	|-KeyframeGroup<BoolKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<ColorKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<NumberKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<SpherePointKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<TextureKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<object>.TrimToSingleKeyframe
	*/

	// RVA: -1 Offset: -1
	public InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22730 Offset: 0x2D22831 VA: 0x2D22730
	|-KeyframeGroup<object>.GetShortestInterpolationDirection
	*/

	// RVA: -1 Offset: -1
	public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22790 Offset: 0x2D22891 VA: 0x2D22790
	|-KeyframeGroup<object>.CalculateCircularDistances
	*/

	// RVA: -1 Offset: -1
	public float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D227C0 Offset: 0x2D228C1 VA: 0x2D227C0
	|-KeyframeGroup<NumberKeyframe>.InterpolateFloat
	|-KeyframeGroup<object>.InterpolateFloat
	*/

	// RVA: -1 Offset: -1
	public float AutoInterpolation(float curvedTime, float previousValue, float nextValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22A10 Offset: 0x2D22B11 VA: 0x2D22A10
	|-KeyframeGroup<object>.AutoInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22AA0 Offset: 0x2D22BA1 VA: 0x2D22AA0
	|-KeyframeGroup<object>.ForwardInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22B80 Offset: 0x2D22C81 VA: 0x2D22B80
	|-KeyframeGroup<object>.ReverseInterpolation
	*/
}

[Serializable]
public class KeyframeGroup<T> : IKeyframeGroup // TypeDefIndex: 9641
{
	// Fields
	public List<T> keyframes; // 0x0
	[SerializeField] // RVA: 0x17D780 Offset: 0x17D881 VA: 0x17D780
	private string m_Name; // 0x0
	[SerializeField] // RVA: 0x17D790 Offset: 0x17D891 VA: 0x17D790
	private string m_Id; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17D7A0 Offset: 0x17D8A1 VA: 0x17D7A0
	private int <propertyId>k__BackingField; // 0x0

	// Properties
	public string name { get; set; }
	public string id { get; set; }
	public int propertyId { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public string get_name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C10 Offset: 0x2D21D11 VA: 0x2D21C10
	|-KeyframeGroup<BoolKeyframe>.get_name
	|-KeyframeGroup<ColorKeyframe>.get_name
	|-KeyframeGroup<NumberKeyframe>.get_name
	|-KeyframeGroup<SpherePointKeyframe>.get_name
	|-KeyframeGroup<TextureKeyframe>.get_name
	|-KeyframeGroup<object>.get_name
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_name(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C20 Offset: 0x2D21D21 VA: 0x2D21C20
	|-KeyframeGroup<BoolKeyframe>.set_name
	|-KeyframeGroup<ColorKeyframe>.set_name
	|-KeyframeGroup<NumberKeyframe>.set_name
	|-KeyframeGroup<SpherePointKeyframe>.set_name
	|-KeyframeGroup<TextureKeyframe>.set_name
	|-KeyframeGroup<object>.set_name
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public string get_id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C30 Offset: 0x2D21D31 VA: 0x2D21C30
	|-KeyframeGroup<BoolKeyframe>.get_id
	|-KeyframeGroup<ColorKeyframe>.get_id
	|-KeyframeGroup<NumberKeyframe>.get_id
	|-KeyframeGroup<SpherePointKeyframe>.get_id
	|-KeyframeGroup<TextureKeyframe>.get_id
	|-KeyframeGroup<object>.get_id
	*/

	// RVA: -1 Offset: -1
	public void set_id(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C40 Offset: 0x2D21D41 VA: 0x2D21C40
	|-KeyframeGroup<object>.set_id
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AC5D0 Offset: 0x1AC6D1 VA: 0x1AC5D0
	// RVA: -1 Offset: -1
	public int get_propertyId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C50 Offset: 0x2D21D51 VA: 0x2D21C50
	|-KeyframeGroup<BoolKeyframe>.get_propertyId
	|-KeyframeGroup<ColorKeyframe>.get_propertyId
	|-KeyframeGroup<NumberKeyframe>.get_propertyId
	|-KeyframeGroup<TextureKeyframe>.get_propertyId
	|-KeyframeGroup<object>.get_propertyId
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AC5E0 Offset: 0x1AC6E1 VA: 0x1AC5E0
	// RVA: -1 Offset: -1
	public void set_propertyId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C60 Offset: 0x2D21D61 VA: 0x2D21C60
	|-KeyframeGroup<BoolKeyframe>.set_propertyId
	|-KeyframeGroup<ColorKeyframe>.set_propertyId
	|-KeyframeGroup<NumberKeyframe>.set_propertyId
	|-KeyframeGroup<TextureKeyframe>.set_propertyId
	|-KeyframeGroup<object>.set_propertyId
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C70 Offset: 0x2D21D71 VA: 0x2D21C70
	|-KeyframeGroup<BoolKeyframe>..ctor
	|-KeyframeGroup<ColorKeyframe>..ctor
	|-KeyframeGroup<NumberKeyframe>..ctor
	|-KeyframeGroup<SpherePointKeyframe>..ctor
	|-KeyframeGroup<TextureKeyframe>..ctor
	|-KeyframeGroup<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21DA0 Offset: 0x2D21EA1 VA: 0x2D21DA0
	|-KeyframeGroup<BoolKeyframe>.AddKeyFrame
	|-KeyframeGroup<ColorKeyframe>.AddKeyFrame
	|-KeyframeGroup<NumberKeyframe>.AddKeyFrame
	|-KeyframeGroup<SpherePointKeyframe>.AddKeyFrame
	|-KeyframeGroup<TextureKeyframe>.AddKeyFrame
	|-KeyframeGroup<object>.AddKeyFrame
	*/

	// RVA: -1 Offset: -1
	public void RemoveKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21E00 Offset: 0x2D21F01 VA: 0x2D21E00
	|-KeyframeGroup<ColorKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<NumberKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<object>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void RemoveKeyFrame(IBaseKeyframe keyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21EF0 Offset: 0x2D21FF1 VA: 0x2D21EF0
	|-KeyframeGroup<BoolKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<ColorKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<NumberKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<SpherePointKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<TextureKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<object>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int GetKeyFrameCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21F90 Offset: 0x2D22091 VA: 0x2D21F90
	|-KeyframeGroup<BoolKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<ColorKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<NumberKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<SpherePointKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<TextureKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<object>.GetKeyFrameCount
	*/

	// RVA: -1 Offset: -1
	public T GetKeyframe(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21FC0 Offset: 0x2D220C1 VA: 0x2D21FC0
	|-KeyframeGroup<BoolKeyframe>.GetKeyframe
	|-KeyframeGroup<ColorKeyframe>.GetKeyframe
	|-KeyframeGroup<NumberKeyframe>.GetKeyframe
	|-KeyframeGroup<SpherePointKeyframe>.GetKeyframe
	|-KeyframeGroup<TextureKeyframe>.GetKeyframe
	|-KeyframeGroup<object>.GetKeyframe
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SortKeyframes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21FF0 Offset: 0x2D220F1 VA: 0x2D21FF0
	|-KeyframeGroup<BoolKeyframe>.SortKeyframes
	|-KeyframeGroup<ColorKeyframe>.SortKeyframes
	|-KeyframeGroup<NumberKeyframe>.SortKeyframes
	|-KeyframeGroup<SpherePointKeyframe>.SortKeyframes
	|-KeyframeGroup<TextureKeyframe>.SortKeyframes
	|-KeyframeGroup<object>.SortKeyframes
	*/

	// RVA: -1 Offset: -1
	public float CurveAdjustedBlendingTime(InterpolationCurve curve, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22020 Offset: 0x2D22121 VA: 0x2D22020
	|-KeyframeGroup<ColorKeyframe>.CurveAdjustedBlendingTime
	|-KeyframeGroup<SpherePointKeyframe>.CurveAdjustedBlendingTime
	|-KeyframeGroup<object>.CurveAdjustedBlendingTime
	*/

	// RVA: -1 Offset: -1
	public T GetPreviousKeyFrame(float time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D220E0 Offset: 0x2D221E1 VA: 0x2D220E0
	|-KeyframeGroup<ColorKeyframe>.GetPreviousKeyFrame
	|-KeyframeGroup<NumberKeyframe>.GetPreviousKeyFrame
	|-KeyframeGroup<object>.GetPreviousKeyFrame
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22130 Offset: 0x2D22231 VA: 0x2D22130
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22200 Offset: 0x2D22301 VA: 0x2D22200
	|-KeyframeGroup<BoolKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<ColorKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<NumberKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<SpherePointKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<TextureKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22470 Offset: 0x2D22571 VA: 0x2D22470
	|-KeyframeGroup<ColorKeyframe>.ProgressBetweenSurroundingKeyframes
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22520 Offset: 0x2D22621 VA: 0x2D22520
	|-KeyframeGroup<SpherePointKeyframe>.ProgressBetweenSurroundingKeyframes
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float WidthBetweenCircularValues(float begin, float end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22680 Offset: 0x2D22781 VA: 0x2D22680
	|-KeyframeGroup<object>.WidthBetweenCircularValues
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void TrimToSingleKeyframe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D226A0 Offset: 0x2D227A1 VA: 0x2D226A0
	|-KeyframeGroup<BoolKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<ColorKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<NumberKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<SpherePointKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<TextureKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<object>.TrimToSingleKeyframe
	*/

	// RVA: -1 Offset: -1
	public InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22730 Offset: 0x2D22831 VA: 0x2D22730
	|-KeyframeGroup<object>.GetShortestInterpolationDirection
	*/

	// RVA: -1 Offset: -1
	public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22790 Offset: 0x2D22891 VA: 0x2D22790
	|-KeyframeGroup<object>.CalculateCircularDistances
	*/

	// RVA: -1 Offset: -1
	public float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D227C0 Offset: 0x2D228C1 VA: 0x2D227C0
	|-KeyframeGroup<NumberKeyframe>.InterpolateFloat
	|-KeyframeGroup<object>.InterpolateFloat
	*/

	// RVA: -1 Offset: -1
	public float AutoInterpolation(float curvedTime, float previousValue, float nextValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22A10 Offset: 0x2D22B11 VA: 0x2D22A10
	|-KeyframeGroup<object>.AutoInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22AA0 Offset: 0x2D22BA1 VA: 0x2D22AA0
	|-KeyframeGroup<object>.ForwardInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22B80 Offset: 0x2D22C81 VA: 0x2D22B80
	|-KeyframeGroup<object>.ReverseInterpolation
	*/
}

[Serializable]
public class KeyframeGroup<T> : IKeyframeGroup // TypeDefIndex: 9641
{
	// Fields
	public List<T> keyframes; // 0x0
	[SerializeField] // RVA: 0x17D780 Offset: 0x17D881 VA: 0x17D780
	private string m_Name; // 0x0
	[SerializeField] // RVA: 0x17D790 Offset: 0x17D891 VA: 0x17D790
	private string m_Id; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17D7A0 Offset: 0x17D8A1 VA: 0x17D7A0
	private int <propertyId>k__BackingField; // 0x0

	// Properties
	public string name { get; set; }
	public string id { get; set; }
	public int propertyId { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public string get_name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C10 Offset: 0x2D21D11 VA: 0x2D21C10
	|-KeyframeGroup<BoolKeyframe>.get_name
	|-KeyframeGroup<ColorKeyframe>.get_name
	|-KeyframeGroup<NumberKeyframe>.get_name
	|-KeyframeGroup<SpherePointKeyframe>.get_name
	|-KeyframeGroup<TextureKeyframe>.get_name
	|-KeyframeGroup<object>.get_name
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_name(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C20 Offset: 0x2D21D21 VA: 0x2D21C20
	|-KeyframeGroup<BoolKeyframe>.set_name
	|-KeyframeGroup<ColorKeyframe>.set_name
	|-KeyframeGroup<NumberKeyframe>.set_name
	|-KeyframeGroup<SpherePointKeyframe>.set_name
	|-KeyframeGroup<TextureKeyframe>.set_name
	|-KeyframeGroup<object>.set_name
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public string get_id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C30 Offset: 0x2D21D31 VA: 0x2D21C30
	|-KeyframeGroup<BoolKeyframe>.get_id
	|-KeyframeGroup<ColorKeyframe>.get_id
	|-KeyframeGroup<NumberKeyframe>.get_id
	|-KeyframeGroup<SpherePointKeyframe>.get_id
	|-KeyframeGroup<TextureKeyframe>.get_id
	|-KeyframeGroup<object>.get_id
	*/

	// RVA: -1 Offset: -1
	public void set_id(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C40 Offset: 0x2D21D41 VA: 0x2D21C40
	|-KeyframeGroup<object>.set_id
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AC5D0 Offset: 0x1AC6D1 VA: 0x1AC5D0
	// RVA: -1 Offset: -1
	public int get_propertyId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C50 Offset: 0x2D21D51 VA: 0x2D21C50
	|-KeyframeGroup<BoolKeyframe>.get_propertyId
	|-KeyframeGroup<ColorKeyframe>.get_propertyId
	|-KeyframeGroup<NumberKeyframe>.get_propertyId
	|-KeyframeGroup<TextureKeyframe>.get_propertyId
	|-KeyframeGroup<object>.get_propertyId
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AC5E0 Offset: 0x1AC6E1 VA: 0x1AC5E0
	// RVA: -1 Offset: -1
	public void set_propertyId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C60 Offset: 0x2D21D61 VA: 0x2D21C60
	|-KeyframeGroup<BoolKeyframe>.set_propertyId
	|-KeyframeGroup<ColorKeyframe>.set_propertyId
	|-KeyframeGroup<NumberKeyframe>.set_propertyId
	|-KeyframeGroup<TextureKeyframe>.set_propertyId
	|-KeyframeGroup<object>.set_propertyId
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C70 Offset: 0x2D21D71 VA: 0x2D21C70
	|-KeyframeGroup<BoolKeyframe>..ctor
	|-KeyframeGroup<ColorKeyframe>..ctor
	|-KeyframeGroup<NumberKeyframe>..ctor
	|-KeyframeGroup<SpherePointKeyframe>..ctor
	|-KeyframeGroup<TextureKeyframe>..ctor
	|-KeyframeGroup<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21DA0 Offset: 0x2D21EA1 VA: 0x2D21DA0
	|-KeyframeGroup<BoolKeyframe>.AddKeyFrame
	|-KeyframeGroup<ColorKeyframe>.AddKeyFrame
	|-KeyframeGroup<NumberKeyframe>.AddKeyFrame
	|-KeyframeGroup<SpherePointKeyframe>.AddKeyFrame
	|-KeyframeGroup<TextureKeyframe>.AddKeyFrame
	|-KeyframeGroup<object>.AddKeyFrame
	*/

	// RVA: -1 Offset: -1
	public void RemoveKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21E00 Offset: 0x2D21F01 VA: 0x2D21E00
	|-KeyframeGroup<ColorKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<NumberKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<object>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void RemoveKeyFrame(IBaseKeyframe keyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21EF0 Offset: 0x2D21FF1 VA: 0x2D21EF0
	|-KeyframeGroup<BoolKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<ColorKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<NumberKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<SpherePointKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<TextureKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<object>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int GetKeyFrameCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21F90 Offset: 0x2D22091 VA: 0x2D21F90
	|-KeyframeGroup<BoolKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<ColorKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<NumberKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<SpherePointKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<TextureKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<object>.GetKeyFrameCount
	*/

	// RVA: -1 Offset: -1
	public T GetKeyframe(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21FC0 Offset: 0x2D220C1 VA: 0x2D21FC0
	|-KeyframeGroup<BoolKeyframe>.GetKeyframe
	|-KeyframeGroup<ColorKeyframe>.GetKeyframe
	|-KeyframeGroup<NumberKeyframe>.GetKeyframe
	|-KeyframeGroup<SpherePointKeyframe>.GetKeyframe
	|-KeyframeGroup<TextureKeyframe>.GetKeyframe
	|-KeyframeGroup<object>.GetKeyframe
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SortKeyframes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21FF0 Offset: 0x2D220F1 VA: 0x2D21FF0
	|-KeyframeGroup<BoolKeyframe>.SortKeyframes
	|-KeyframeGroup<ColorKeyframe>.SortKeyframes
	|-KeyframeGroup<NumberKeyframe>.SortKeyframes
	|-KeyframeGroup<SpherePointKeyframe>.SortKeyframes
	|-KeyframeGroup<TextureKeyframe>.SortKeyframes
	|-KeyframeGroup<object>.SortKeyframes
	*/

	// RVA: -1 Offset: -1
	public float CurveAdjustedBlendingTime(InterpolationCurve curve, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22020 Offset: 0x2D22121 VA: 0x2D22020
	|-KeyframeGroup<ColorKeyframe>.CurveAdjustedBlendingTime
	|-KeyframeGroup<SpherePointKeyframe>.CurveAdjustedBlendingTime
	|-KeyframeGroup<object>.CurveAdjustedBlendingTime
	*/

	// RVA: -1 Offset: -1
	public T GetPreviousKeyFrame(float time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D220E0 Offset: 0x2D221E1 VA: 0x2D220E0
	|-KeyframeGroup<ColorKeyframe>.GetPreviousKeyFrame
	|-KeyframeGroup<NumberKeyframe>.GetPreviousKeyFrame
	|-KeyframeGroup<object>.GetPreviousKeyFrame
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22130 Offset: 0x2D22231 VA: 0x2D22130
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22200 Offset: 0x2D22301 VA: 0x2D22200
	|-KeyframeGroup<BoolKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<ColorKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<NumberKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<SpherePointKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<TextureKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22470 Offset: 0x2D22571 VA: 0x2D22470
	|-KeyframeGroup<ColorKeyframe>.ProgressBetweenSurroundingKeyframes
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22520 Offset: 0x2D22621 VA: 0x2D22520
	|-KeyframeGroup<SpherePointKeyframe>.ProgressBetweenSurroundingKeyframes
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float WidthBetweenCircularValues(float begin, float end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22680 Offset: 0x2D22781 VA: 0x2D22680
	|-KeyframeGroup<object>.WidthBetweenCircularValues
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void TrimToSingleKeyframe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D226A0 Offset: 0x2D227A1 VA: 0x2D226A0
	|-KeyframeGroup<BoolKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<ColorKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<NumberKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<SpherePointKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<TextureKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<object>.TrimToSingleKeyframe
	*/

	// RVA: -1 Offset: -1
	public InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22730 Offset: 0x2D22831 VA: 0x2D22730
	|-KeyframeGroup<object>.GetShortestInterpolationDirection
	*/

	// RVA: -1 Offset: -1
	public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22790 Offset: 0x2D22891 VA: 0x2D22790
	|-KeyframeGroup<object>.CalculateCircularDistances
	*/

	// RVA: -1 Offset: -1
	public float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D227C0 Offset: 0x2D228C1 VA: 0x2D227C0
	|-KeyframeGroup<NumberKeyframe>.InterpolateFloat
	|-KeyframeGroup<object>.InterpolateFloat
	*/

	// RVA: -1 Offset: -1
	public float AutoInterpolation(float curvedTime, float previousValue, float nextValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22A10 Offset: 0x2D22B11 VA: 0x2D22A10
	|-KeyframeGroup<object>.AutoInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22AA0 Offset: 0x2D22BA1 VA: 0x2D22AA0
	|-KeyframeGroup<object>.ForwardInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22B80 Offset: 0x2D22C81 VA: 0x2D22B80
	|-KeyframeGroup<object>.ReverseInterpolation
	*/
}

[Serializable]
public class KeyframeGroup<T> : IKeyframeGroup // TypeDefIndex: 9641
{
	// Fields
	public List<T> keyframes; // 0x0
	[SerializeField] // RVA: 0x17D780 Offset: 0x17D881 VA: 0x17D780
	private string m_Name; // 0x0
	[SerializeField] // RVA: 0x17D790 Offset: 0x17D891 VA: 0x17D790
	private string m_Id; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17D7A0 Offset: 0x17D8A1 VA: 0x17D7A0
	private int <propertyId>k__BackingField; // 0x0

	// Properties
	public string name { get; set; }
	public string id { get; set; }
	public int propertyId { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public string get_name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C10 Offset: 0x2D21D11 VA: 0x2D21C10
	|-KeyframeGroup<BoolKeyframe>.get_name
	|-KeyframeGroup<ColorKeyframe>.get_name
	|-KeyframeGroup<NumberKeyframe>.get_name
	|-KeyframeGroup<SpherePointKeyframe>.get_name
	|-KeyframeGroup<TextureKeyframe>.get_name
	|-KeyframeGroup<object>.get_name
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_name(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C20 Offset: 0x2D21D21 VA: 0x2D21C20
	|-KeyframeGroup<BoolKeyframe>.set_name
	|-KeyframeGroup<ColorKeyframe>.set_name
	|-KeyframeGroup<NumberKeyframe>.set_name
	|-KeyframeGroup<SpherePointKeyframe>.set_name
	|-KeyframeGroup<TextureKeyframe>.set_name
	|-KeyframeGroup<object>.set_name
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public string get_id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C30 Offset: 0x2D21D31 VA: 0x2D21C30
	|-KeyframeGroup<BoolKeyframe>.get_id
	|-KeyframeGroup<ColorKeyframe>.get_id
	|-KeyframeGroup<NumberKeyframe>.get_id
	|-KeyframeGroup<SpherePointKeyframe>.get_id
	|-KeyframeGroup<TextureKeyframe>.get_id
	|-KeyframeGroup<object>.get_id
	*/

	// RVA: -1 Offset: -1
	public void set_id(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C40 Offset: 0x2D21D41 VA: 0x2D21C40
	|-KeyframeGroup<object>.set_id
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AC5D0 Offset: 0x1AC6D1 VA: 0x1AC5D0
	// RVA: -1 Offset: -1
	public int get_propertyId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C50 Offset: 0x2D21D51 VA: 0x2D21C50
	|-KeyframeGroup<BoolKeyframe>.get_propertyId
	|-KeyframeGroup<ColorKeyframe>.get_propertyId
	|-KeyframeGroup<NumberKeyframe>.get_propertyId
	|-KeyframeGroup<TextureKeyframe>.get_propertyId
	|-KeyframeGroup<object>.get_propertyId
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AC5E0 Offset: 0x1AC6E1 VA: 0x1AC5E0
	// RVA: -1 Offset: -1
	public void set_propertyId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C60 Offset: 0x2D21D61 VA: 0x2D21C60
	|-KeyframeGroup<BoolKeyframe>.set_propertyId
	|-KeyframeGroup<ColorKeyframe>.set_propertyId
	|-KeyframeGroup<NumberKeyframe>.set_propertyId
	|-KeyframeGroup<TextureKeyframe>.set_propertyId
	|-KeyframeGroup<object>.set_propertyId
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C70 Offset: 0x2D21D71 VA: 0x2D21C70
	|-KeyframeGroup<BoolKeyframe>..ctor
	|-KeyframeGroup<ColorKeyframe>..ctor
	|-KeyframeGroup<NumberKeyframe>..ctor
	|-KeyframeGroup<SpherePointKeyframe>..ctor
	|-KeyframeGroup<TextureKeyframe>..ctor
	|-KeyframeGroup<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21DA0 Offset: 0x2D21EA1 VA: 0x2D21DA0
	|-KeyframeGroup<BoolKeyframe>.AddKeyFrame
	|-KeyframeGroup<ColorKeyframe>.AddKeyFrame
	|-KeyframeGroup<NumberKeyframe>.AddKeyFrame
	|-KeyframeGroup<SpherePointKeyframe>.AddKeyFrame
	|-KeyframeGroup<TextureKeyframe>.AddKeyFrame
	|-KeyframeGroup<object>.AddKeyFrame
	*/

	// RVA: -1 Offset: -1
	public void RemoveKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21E00 Offset: 0x2D21F01 VA: 0x2D21E00
	|-KeyframeGroup<ColorKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<NumberKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<object>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void RemoveKeyFrame(IBaseKeyframe keyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21EF0 Offset: 0x2D21FF1 VA: 0x2D21EF0
	|-KeyframeGroup<BoolKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<ColorKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<NumberKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<SpherePointKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<TextureKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<object>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int GetKeyFrameCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21F90 Offset: 0x2D22091 VA: 0x2D21F90
	|-KeyframeGroup<BoolKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<ColorKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<NumberKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<SpherePointKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<TextureKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<object>.GetKeyFrameCount
	*/

	// RVA: -1 Offset: -1
	public T GetKeyframe(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21FC0 Offset: 0x2D220C1 VA: 0x2D21FC0
	|-KeyframeGroup<BoolKeyframe>.GetKeyframe
	|-KeyframeGroup<ColorKeyframe>.GetKeyframe
	|-KeyframeGroup<NumberKeyframe>.GetKeyframe
	|-KeyframeGroup<SpherePointKeyframe>.GetKeyframe
	|-KeyframeGroup<TextureKeyframe>.GetKeyframe
	|-KeyframeGroup<object>.GetKeyframe
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SortKeyframes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21FF0 Offset: 0x2D220F1 VA: 0x2D21FF0
	|-KeyframeGroup<BoolKeyframe>.SortKeyframes
	|-KeyframeGroup<ColorKeyframe>.SortKeyframes
	|-KeyframeGroup<NumberKeyframe>.SortKeyframes
	|-KeyframeGroup<SpherePointKeyframe>.SortKeyframes
	|-KeyframeGroup<TextureKeyframe>.SortKeyframes
	|-KeyframeGroup<object>.SortKeyframes
	*/

	// RVA: -1 Offset: -1
	public float CurveAdjustedBlendingTime(InterpolationCurve curve, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22020 Offset: 0x2D22121 VA: 0x2D22020
	|-KeyframeGroup<ColorKeyframe>.CurveAdjustedBlendingTime
	|-KeyframeGroup<SpherePointKeyframe>.CurveAdjustedBlendingTime
	|-KeyframeGroup<object>.CurveAdjustedBlendingTime
	*/

	// RVA: -1 Offset: -1
	public T GetPreviousKeyFrame(float time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D220E0 Offset: 0x2D221E1 VA: 0x2D220E0
	|-KeyframeGroup<ColorKeyframe>.GetPreviousKeyFrame
	|-KeyframeGroup<NumberKeyframe>.GetPreviousKeyFrame
	|-KeyframeGroup<object>.GetPreviousKeyFrame
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22130 Offset: 0x2D22231 VA: 0x2D22130
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22200 Offset: 0x2D22301 VA: 0x2D22200
	|-KeyframeGroup<BoolKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<ColorKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<NumberKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<SpherePointKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<TextureKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22470 Offset: 0x2D22571 VA: 0x2D22470
	|-KeyframeGroup<ColorKeyframe>.ProgressBetweenSurroundingKeyframes
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22520 Offset: 0x2D22621 VA: 0x2D22520
	|-KeyframeGroup<SpherePointKeyframe>.ProgressBetweenSurroundingKeyframes
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float WidthBetweenCircularValues(float begin, float end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22680 Offset: 0x2D22781 VA: 0x2D22680
	|-KeyframeGroup<object>.WidthBetweenCircularValues
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void TrimToSingleKeyframe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D226A0 Offset: 0x2D227A1 VA: 0x2D226A0
	|-KeyframeGroup<BoolKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<ColorKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<NumberKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<SpherePointKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<TextureKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<object>.TrimToSingleKeyframe
	*/

	// RVA: -1 Offset: -1
	public InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22730 Offset: 0x2D22831 VA: 0x2D22730
	|-KeyframeGroup<object>.GetShortestInterpolationDirection
	*/

	// RVA: -1 Offset: -1
	public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22790 Offset: 0x2D22891 VA: 0x2D22790
	|-KeyframeGroup<object>.CalculateCircularDistances
	*/

	// RVA: -1 Offset: -1
	public float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D227C0 Offset: 0x2D228C1 VA: 0x2D227C0
	|-KeyframeGroup<NumberKeyframe>.InterpolateFloat
	|-KeyframeGroup<object>.InterpolateFloat
	*/

	// RVA: -1 Offset: -1
	public float AutoInterpolation(float curvedTime, float previousValue, float nextValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22A10 Offset: 0x2D22B11 VA: 0x2D22A10
	|-KeyframeGroup<object>.AutoInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22AA0 Offset: 0x2D22BA1 VA: 0x2D22AA0
	|-KeyframeGroup<object>.ForwardInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22B80 Offset: 0x2D22C81 VA: 0x2D22B80
	|-KeyframeGroup<object>.ReverseInterpolation
	*/
}

[Serializable]
public class KeyframeGroup<T> : IKeyframeGroup // TypeDefIndex: 9641
{
	// Fields
	public List<T> keyframes; // 0x0
	[SerializeField] // RVA: 0x17D780 Offset: 0x17D881 VA: 0x17D780
	private string m_Name; // 0x0
	[SerializeField] // RVA: 0x17D790 Offset: 0x17D891 VA: 0x17D790
	private string m_Id; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17D7A0 Offset: 0x17D8A1 VA: 0x17D7A0
	private int <propertyId>k__BackingField; // 0x0

	// Properties
	public string name { get; set; }
	public string id { get; set; }
	public int propertyId { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public string get_name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C10 Offset: 0x2D21D11 VA: 0x2D21C10
	|-KeyframeGroup<BoolKeyframe>.get_name
	|-KeyframeGroup<ColorKeyframe>.get_name
	|-KeyframeGroup<NumberKeyframe>.get_name
	|-KeyframeGroup<SpherePointKeyframe>.get_name
	|-KeyframeGroup<TextureKeyframe>.get_name
	|-KeyframeGroup<object>.get_name
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_name(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C20 Offset: 0x2D21D21 VA: 0x2D21C20
	|-KeyframeGroup<BoolKeyframe>.set_name
	|-KeyframeGroup<ColorKeyframe>.set_name
	|-KeyframeGroup<NumberKeyframe>.set_name
	|-KeyframeGroup<SpherePointKeyframe>.set_name
	|-KeyframeGroup<TextureKeyframe>.set_name
	|-KeyframeGroup<object>.set_name
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public string get_id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C30 Offset: 0x2D21D31 VA: 0x2D21C30
	|-KeyframeGroup<BoolKeyframe>.get_id
	|-KeyframeGroup<ColorKeyframe>.get_id
	|-KeyframeGroup<NumberKeyframe>.get_id
	|-KeyframeGroup<SpherePointKeyframe>.get_id
	|-KeyframeGroup<TextureKeyframe>.get_id
	|-KeyframeGroup<object>.get_id
	*/

	// RVA: -1 Offset: -1
	public void set_id(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C40 Offset: 0x2D21D41 VA: 0x2D21C40
	|-KeyframeGroup<object>.set_id
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AC5D0 Offset: 0x1AC6D1 VA: 0x1AC5D0
	// RVA: -1 Offset: -1
	public int get_propertyId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C50 Offset: 0x2D21D51 VA: 0x2D21C50
	|-KeyframeGroup<BoolKeyframe>.get_propertyId
	|-KeyframeGroup<ColorKeyframe>.get_propertyId
	|-KeyframeGroup<NumberKeyframe>.get_propertyId
	|-KeyframeGroup<TextureKeyframe>.get_propertyId
	|-KeyframeGroup<object>.get_propertyId
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AC5E0 Offset: 0x1AC6E1 VA: 0x1AC5E0
	// RVA: -1 Offset: -1
	public void set_propertyId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C60 Offset: 0x2D21D61 VA: 0x2D21C60
	|-KeyframeGroup<BoolKeyframe>.set_propertyId
	|-KeyframeGroup<ColorKeyframe>.set_propertyId
	|-KeyframeGroup<NumberKeyframe>.set_propertyId
	|-KeyframeGroup<TextureKeyframe>.set_propertyId
	|-KeyframeGroup<object>.set_propertyId
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21C70 Offset: 0x2D21D71 VA: 0x2D21C70
	|-KeyframeGroup<BoolKeyframe>..ctor
	|-KeyframeGroup<ColorKeyframe>..ctor
	|-KeyframeGroup<NumberKeyframe>..ctor
	|-KeyframeGroup<SpherePointKeyframe>..ctor
	|-KeyframeGroup<TextureKeyframe>..ctor
	|-KeyframeGroup<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21DA0 Offset: 0x2D21EA1 VA: 0x2D21DA0
	|-KeyframeGroup<BoolKeyframe>.AddKeyFrame
	|-KeyframeGroup<ColorKeyframe>.AddKeyFrame
	|-KeyframeGroup<NumberKeyframe>.AddKeyFrame
	|-KeyframeGroup<SpherePointKeyframe>.AddKeyFrame
	|-KeyframeGroup<TextureKeyframe>.AddKeyFrame
	|-KeyframeGroup<object>.AddKeyFrame
	*/

	// RVA: -1 Offset: -1
	public void RemoveKeyFrame(T keyFrame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21E00 Offset: 0x2D21F01 VA: 0x2D21E00
	|-KeyframeGroup<ColorKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<NumberKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<object>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void RemoveKeyFrame(IBaseKeyframe keyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21EF0 Offset: 0x2D21FF1 VA: 0x2D21EF0
	|-KeyframeGroup<BoolKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<ColorKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<NumberKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<SpherePointKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<TextureKeyframe>.RemoveKeyFrame
	|-KeyframeGroup<object>.RemoveKeyFrame
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int GetKeyFrameCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21F90 Offset: 0x2D22091 VA: 0x2D21F90
	|-KeyframeGroup<BoolKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<ColorKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<NumberKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<SpherePointKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<TextureKeyframe>.GetKeyFrameCount
	|-KeyframeGroup<object>.GetKeyFrameCount
	*/

	// RVA: -1 Offset: -1
	public T GetKeyframe(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21FC0 Offset: 0x2D220C1 VA: 0x2D21FC0
	|-KeyframeGroup<BoolKeyframe>.GetKeyframe
	|-KeyframeGroup<ColorKeyframe>.GetKeyframe
	|-KeyframeGroup<NumberKeyframe>.GetKeyframe
	|-KeyframeGroup<SpherePointKeyframe>.GetKeyframe
	|-KeyframeGroup<TextureKeyframe>.GetKeyframe
	|-KeyframeGroup<object>.GetKeyframe
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SortKeyframes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D21FF0 Offset: 0x2D220F1 VA: 0x2D21FF0
	|-KeyframeGroup<BoolKeyframe>.SortKeyframes
	|-KeyframeGroup<ColorKeyframe>.SortKeyframes
	|-KeyframeGroup<NumberKeyframe>.SortKeyframes
	|-KeyframeGroup<SpherePointKeyframe>.SortKeyframes
	|-KeyframeGroup<TextureKeyframe>.SortKeyframes
	|-KeyframeGroup<object>.SortKeyframes
	*/

	// RVA: -1 Offset: -1
	public float CurveAdjustedBlendingTime(InterpolationCurve curve, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22020 Offset: 0x2D22121 VA: 0x2D22020
	|-KeyframeGroup<ColorKeyframe>.CurveAdjustedBlendingTime
	|-KeyframeGroup<SpherePointKeyframe>.CurveAdjustedBlendingTime
	|-KeyframeGroup<object>.CurveAdjustedBlendingTime
	*/

	// RVA: -1 Offset: -1
	public T GetPreviousKeyFrame(float time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D220E0 Offset: 0x2D221E1 VA: 0x2D220E0
	|-KeyframeGroup<ColorKeyframe>.GetPreviousKeyFrame
	|-KeyframeGroup<NumberKeyframe>.GetPreviousKeyFrame
	|-KeyframeGroup<object>.GetPreviousKeyFrame
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22130 Offset: 0x2D22231 VA: 0x2D22130
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22200 Offset: 0x2D22301 VA: 0x2D22200
	|-KeyframeGroup<BoolKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<ColorKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<NumberKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<SpherePointKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<TextureKeyframe>.GetSurroundingKeyFrames
	|-KeyframeGroup<object>.GetSurroundingKeyFrames
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22470 Offset: 0x2D22571 VA: 0x2D22470
	|-KeyframeGroup<ColorKeyframe>.ProgressBetweenSurroundingKeyframes
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22520 Offset: 0x2D22621 VA: 0x2D22520
	|-KeyframeGroup<SpherePointKeyframe>.ProgressBetweenSurroundingKeyframes
	|-KeyframeGroup<object>.ProgressBetweenSurroundingKeyframes
	*/

	// RVA: -1 Offset: -1
	public static float WidthBetweenCircularValues(float begin, float end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22680 Offset: 0x2D22781 VA: 0x2D22680
	|-KeyframeGroup<object>.WidthBetweenCircularValues
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void TrimToSingleKeyframe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D226A0 Offset: 0x2D227A1 VA: 0x2D226A0
	|-KeyframeGroup<BoolKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<ColorKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<NumberKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<SpherePointKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<TextureKeyframe>.TrimToSingleKeyframe
	|-KeyframeGroup<object>.TrimToSingleKeyframe
	*/

	// RVA: -1 Offset: -1
	public InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22730 Offset: 0x2D22831 VA: 0x2D22730
	|-KeyframeGroup<object>.GetShortestInterpolationDirection
	*/

	// RVA: -1 Offset: -1
	public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22790 Offset: 0x2D22891 VA: 0x2D22790
	|-KeyframeGroup<object>.CalculateCircularDistances
	*/

	// RVA: -1 Offset: -1
	public float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D227C0 Offset: 0x2D228C1 VA: 0x2D227C0
	|-KeyframeGroup<NumberKeyframe>.InterpolateFloat
	|-KeyframeGroup<object>.InterpolateFloat
	*/

	// RVA: -1 Offset: -1
	public float AutoInterpolation(float curvedTime, float previousValue, float nextValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22A10 Offset: 0x2D22B11 VA: 0x2D22A10
	|-KeyframeGroup<object>.AutoInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22AA0 Offset: 0x2D22BA1 VA: 0x2D22AA0
	|-KeyframeGroup<object>.ForwardInterpolation
	*/

	// RVA: -1 Offset: -1
	public float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D22B80 Offset: 0x2D22C81 VA: 0x2D22B80
	|-KeyframeGroup<object>.ReverseInterpolation
	*/
}


[NativeHeaderAttribute] // RVA: 0xE9B20 Offset: 0xE9C21 VA: 0xE9B20
[RequiredByNativeCodeAttribute] // RVA: 0xE9B20 Offset: 0xE9C21 VA: 0xE9B20
[NativeHeaderAttribute] // RVA: 0xE9B20 Offset: 0xE9C21 VA: 0xE9B20
[MovedFromAttribute] // RVA: 0xE9B20 Offset: 0xE9C21 VA: 0xE9B20
[StaticAccessorAttribute] // RVA: 0xE9B20 Offset: 0xE9C21 VA: 0xE9B20
[NativeHeaderAttribute] // RVA: 0xE9B20 Offset: 0xE9C21 VA: 0xE9B20
public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable> // TypeDefIndex: 3534
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static AnimationScriptPlayable Create<T>(PlayableGraph graph, T jobData, int inputCount = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F85B0 Offset: 0x34F86B1 VA: 0x34F85B0
	|-AnimationScriptPlayable.Create<AimIKJob>
	|
	|-RVA: 0x34F86C0 Offset: 0x34F87C1 VA: 0x34F86C0
	|-AnimationScriptPlayable.Create<CCDIKJob>
	*/

	// RVA: -1 Offset: -1
	private static PlayableHandle CreateHandle<T>(PlayableGraph graph, int inputCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F8D80 Offset: 0x34F8E81 VA: 0x34F8D80
	|-AnimationScriptPlayable.CreateHandle<AimIKJob>
	|
	|-RVA: 0x34F8EA0 Offset: 0x34F8FA1 VA: 0x34F8EA0
	|-AnimationScriptPlayable.CreateHandle<CCDIKJob>
	*/

	// RVA: 0x1C800 Offset: 0x1C901 VA: 0x1C800
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1C810 Offset: 0x1C911 VA: 0x1C810 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: -1 Offset: -1
	private void CheckJobTypeValidity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302720 Offset: 0x302821 VA: 0x302720
	|-AnimationScriptPlayable.CheckJobTypeValidity<AimIKJob>
	|
	|-RVA: 0x302730 Offset: 0x302831 VA: 0x302730
	|-AnimationScriptPlayable.CheckJobTypeValidity<CCDIKJob>
	|
	|-RVA: 0x302740 Offset: 0x302841 VA: 0x302740
	|-AnimationScriptPlayable.CheckJobTypeValidity<object>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void SetJobData<T>(T jobData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302750 Offset: 0x302851 VA: 0x302750
	|-AnimationScriptPlayable.SetJobData<AimIKJob>
	|
	|-RVA: 0x3027E0 Offset: 0x3028E1 VA: 0x3027E0
	|-AnimationScriptPlayable.SetJobData<CCDIKJob>
	*/

	// RVA: 0x1C820 Offset: 0x1C921 VA: 0x1C820 Slot: 5
	public bool Equals(AnimationScriptPlayable other) { }

	[NativeThrowsAttribute] // RVA: 0xECCE0 Offset: 0xECDE1 VA: 0xECCE0
	// RVA: 0x1AF1B10 Offset: 0x1AF1C11 VA: 0x1AF1B10
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData) { }

	// RVA: 0x1AF1C30 Offset: 0x1AF1D31 VA: 0x1AF1C30
	private static void .cctor() { }

	// RVA: 0x1AF1BD0 Offset: 0x1AF1CD1 VA: 0x1AF1BD0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData) { }
}


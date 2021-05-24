[NativeHeaderAttribute] // RVA: 0xC4000 Offset: 0xC4101 VA: 0xC4000
[RequiredByNativeCodeAttribute] // RVA: 0xC4000 Offset: 0xC4101 VA: 0xC4000
[DefaultMemberAttribute] // RVA: 0xC4000 Offset: 0xC4101 VA: 0xC4000
public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 2832
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public Keyframe[] keys { get; set; }
	public Keyframe Item { get; }
	public int length { get; }
	public WrapMode preWrapMode { get; set; }
	public WrapMode postWrapMode { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCC3A0 Offset: 0xCC4A1 VA: 0xCC3A0
	// RVA: 0x2AF4760 Offset: 0x2AF4861 VA: 0x2AF4760
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xCC3F0 Offset: 0xCC4F1 VA: 0xCC3F0
	// RVA: 0x2AF47B0 Offset: 0x2AF48B1 VA: 0x2AF47B0
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0xCC440 Offset: 0xCC541 VA: 0xCC440
	// RVA: 0x2AF4800 Offset: 0x2AF4901 VA: 0x2AF4800
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x2AF4850 Offset: 0x2AF4951 VA: 0x2AF4850 Slot: 1
	protected override void Finalize() { }

	[ThreadSafeAttribute] // RVA: 0xCC490 Offset: 0xCC591 VA: 0xCC490
	// RVA: 0x2AF48F0 Offset: 0x2AF49F1 VA: 0x2AF48F0
	public float Evaluate(float time) { }

	// RVA: 0x2AF4940 Offset: 0x2AF4A41 VA: 0x2AF4940
	public Keyframe[] get_keys() { }

	// RVA: 0x2AF49E0 Offset: 0x2AF4AE1 VA: 0x2AF49E0
	public void set_keys(Keyframe[] value) { }

	[FreeFunctionAttribute] // RVA: 0xCC4A0 Offset: 0xCC5A1 VA: 0xCC4A0
	// RVA: 0x2AF4A80 Offset: 0x2AF4B81 VA: 0x2AF4A80
	public int AddKey(float time, float value) { }

	// RVA: 0x2AF4AE0 Offset: 0x2AF4BE1 VA: 0x2AF4AE0
	public int AddKey(Keyframe key) { }

	[NativeMethodAttribute] // RVA: 0xCC4F0 Offset: 0xCC5F1 VA: 0xCC4F0
	// RVA: 0x2AF4B50 Offset: 0x2AF4C51 VA: 0x2AF4B50
	private int AddKey_Internal(Keyframe key) { }

	// RVA: 0x2AF4BF0 Offset: 0x2AF4CF1 VA: 0x2AF4BF0
	public Keyframe get_Item(int index) { }

	[NativeMethodAttribute] // RVA: 0xCC540 Offset: 0xCC641 VA: 0xCC540
	// RVA: 0x2AF4D30 Offset: 0x2AF4E31 VA: 0x2AF4D30
	public int get_length() { }

	[FreeFunctionAttribute] // RVA: 0xCC590 Offset: 0xCC691 VA: 0xCC590
	// RVA: 0x2AF4A30 Offset: 0x2AF4B31 VA: 0x2AF4A30
	private void SetKeys(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0xCC5E0 Offset: 0xCC6E1 VA: 0xCC5E0
	[NativeThrowsAttribute] // RVA: 0xCC5E0 Offset: 0xCC6E1 VA: 0xCC5E0
	// RVA: 0x2AF4CA0 Offset: 0x2AF4DA1 VA: 0x2AF4CA0
	private Keyframe GetKey(int index) { }

	[FreeFunctionAttribute] // RVA: 0xCC640 Offset: 0xCC741 VA: 0xCC640
	// RVA: 0x2AF4990 Offset: 0x2AF4A91 VA: 0x2AF4990
	private Keyframe[] GetKeys() { }

	// RVA: 0x2AF4DE0 Offset: 0x2AF4EE1 VA: 0x2AF4DE0
	public static AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	// RVA: 0x2AF4DF0 Offset: 0x2AF4EF1 VA: 0x2AF4DF0
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x2AF50B0 Offset: 0x2AF51B1 VA: 0x2AF50B0
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethodAttribute] // RVA: 0xCC690 Offset: 0xCC791 VA: 0xCC690
	// RVA: 0x2AF5300 Offset: 0x2AF5401 VA: 0x2AF5300
	public WrapMode get_preWrapMode() { }

	[NativeMethodAttribute] // RVA: 0xCC6E0 Offset: 0xCC7E1 VA: 0xCC6E0
	// RVA: 0x2AF5350 Offset: 0x2AF5451 VA: 0x2AF5350
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethodAttribute] // RVA: 0xCC730 Offset: 0xCC831 VA: 0xCC730
	// RVA: 0x2AF53A0 Offset: 0x2AF54A1 VA: 0x2AF53A0
	public WrapMode get_postWrapMode() { }

	[NativeMethodAttribute] // RVA: 0xCC780 Offset: 0xCC881 VA: 0xCC780
	// RVA: 0x2AF53F0 Offset: 0x2AF54F1 VA: 0x2AF53F0
	public void set_postWrapMode(WrapMode value) { }

	// RVA: 0x2AF5050 Offset: 0x2AF5151 VA: 0x2AF5050
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCC7D0 Offset: 0xCC8D1 VA: 0xCC7D0
	// RVA: 0x2AF5440 Offset: 0x2AF5541 VA: 0x2AF5440
	public void .ctor() { }

	// RVA: 0x2AF5490 Offset: 0x2AF5591 VA: 0x2AF5490 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2AF55F0 Offset: 0x2AF56F1 VA: 0x2AF55F0 Slot: 4
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x2AF56C0 Offset: 0x2AF57C1 VA: 0x2AF56C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2AF4BA0 Offset: 0x2AF4CA1 VA: 0x2AF4BA0
	private int AddKey_Internal_Injected(ref Keyframe key) { }

	// RVA: 0x2AF4D80 Offset: 0x2AF4E81 VA: 0x2AF4D80
	private void GetKey_Injected(int index, out Keyframe ret) { }
}


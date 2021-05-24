[UsedByNativeCodeAttribute] // RVA: 0xC8DF0 Offset: 0xC8EF1 VA: 0xC8DF0
[NativeHeaderAttribute] // RVA: 0xC8DF0 Offset: 0xC8EF1 VA: 0xC8DF0
[NativeHeaderAttribute] // RVA: 0xC8DF0 Offset: 0xC8EF1 VA: 0xC8DF0
[NativeHeaderAttribute] // RVA: 0xC8DF0 Offset: 0xC8EF1 VA: 0xC8DF0
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 3359
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x2B71250 Offset: 0x2B71351 VA: 0x2B71250
	public static PlayableOutputHandle get_Null() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAED0 Offset: 0xDAFD1 VA: 0xDAED0
	// RVA: -1 Offset: -1
	internal bool IsPlayableOutputOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F2DC0 Offset: 0x2F2EC1 VA: 0x2F2DC0
	|-PlayableOutputHandle.IsPlayableOutputOfType<object>
	|
	|-RVA: 0x2F2E60 Offset: 0x2F2F61 VA: 0x2F2E60
	|-PlayableOutputHandle.IsPlayableOutputOfType<AnimationPlayableOutput>
	|
	|-RVA: 0x2F2F00 Offset: 0x2F3001 VA: 0x2F2F00
	|-PlayableOutputHandle.IsPlayableOutputOfType<AudioPlayableOutput>
	|
	|-RVA: 0x2F2FA0 Offset: 0x2F30A1 VA: 0x2F2FA0
	|-PlayableOutputHandle.IsPlayableOutputOfType<ScriptPlayableOutput>
	*/

	// RVA: 0x3812E0 Offset: 0x3813E1 VA: 0x3812E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2B710E0 Offset: 0x2B711E1 VA: 0x2B710E0
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x381320 Offset: 0x381421 VA: 0x381320 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x381330 Offset: 0x381431 VA: 0x381330 Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x2B71300 Offset: 0x2B71401 VA: 0x2B71300
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAEE0 Offset: 0xDAFE1 VA: 0xDAEE0
	// RVA: 0x3813C0 Offset: 0x3814C1 VA: 0x3813C0
	internal bool IsValid() { }

	[FreeFunctionAttribute] // RVA: 0xDAEF0 Offset: 0xDAFF1 VA: 0xDAEF0
	// RVA: 0x381470 Offset: 0x381571 VA: 0x381470
	internal Type GetPlayableOutputType() { }

	[FreeFunctionAttribute] // RVA: 0xDAF40 Offset: 0xDB041 VA: 0xDAF40
	// RVA: 0x381520 Offset: 0x381621 VA: 0x381520
	internal void SetReferenceObject(Object target) { }

	[FreeFunctionAttribute] // RVA: 0xDAF90 Offset: 0xDB091 VA: 0xDAF90
	// RVA: 0x3815D0 Offset: 0x3816D1 VA: 0x3815D0
	internal void SetUserData(Object target) { }

	[FreeFunctionAttribute] // RVA: 0xDAFE0 Offset: 0xDB0E1 VA: 0xDAFE0
	// RVA: 0x381680 Offset: 0x381781 VA: 0x381680
	internal PlayableHandle GetSourcePlayable() { }

	[FreeFunctionAttribute] // RVA: 0xDB030 Offset: 0xDB131 VA: 0xDB030
	// RVA: 0x381730 Offset: 0x381831 VA: 0x381730
	internal void SetSourcePlayable(PlayableHandle target, int port) { }

	[FreeFunctionAttribute] // RVA: 0xDB080 Offset: 0xDB181 VA: 0xDB080
	// RVA: 0x3817F0 Offset: 0x3818F1 VA: 0x3817F0
	internal int GetSourceOutputPort() { }

	[FreeFunctionAttribute] // RVA: 0xDB0D0 Offset: 0xDB1D1 VA: 0xDB0D0
	// RVA: 0x3818A0 Offset: 0x3819A1 VA: 0x3818A0
	internal void SetWeight(float weight) { }

	[FreeFunctionAttribute] // RVA: 0xDB120 Offset: 0xDB221 VA: 0xDB120
	// RVA: 0x381950 Offset: 0x381A51 VA: 0x381950
	internal void PushNotification(PlayableHandle origin, INotification notification, object context) { }

	[FreeFunctionAttribute] // RVA: 0xDB170 Offset: 0xDB271 VA: 0xDB170
	// RVA: 0x381A20 Offset: 0x381B21 VA: 0x381A20
	internal void AddNotificationReceiver(INotificationReceiver receiver) { }

	// RVA: 0x2B71ED0 Offset: 0x2B71FD1 VA: 0x2B71ED0
	private static void .cctor() { }

	// RVA: 0x2B71550 Offset: 0x2B71651 VA: 0x2B71550
	private static bool IsValid_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0x2B71640 Offset: 0x2B71741 VA: 0x2B71640
	private static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0x2B71740 Offset: 0x2B71841 VA: 0x2B71740
	private static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target) { }

	// RVA: 0x2B71840 Offset: 0x2B71941 VA: 0x2B71840
	private static void SetUserData_Injected(ref PlayableOutputHandle _unity_self, Object target) { }

	// RVA: 0x2B71940 Offset: 0x2B71A41 VA: 0x2B71940
	private static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret) { }

	// RVA: 0x2B71A50 Offset: 0x2B71B51 VA: 0x2B71A50
	private static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port) { }

	// RVA: 0x2B71B50 Offset: 0x2B71C51 VA: 0x2B71B50
	private static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0x2B71C50 Offset: 0x2B71D51 VA: 0x2B71C50
	private static void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight) { }

	// RVA: 0x2B71D60 Offset: 0x2B71E61 VA: 0x2B71D60
	private static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, object context) { }

	// RVA: 0x2B71E80 Offset: 0x2B71F81 VA: 0x2B71E80
	private static void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver) { }
}


[NativeHeaderAttribute] // RVA: 0xC8D30 Offset: 0xC8E31 VA: 0xC8D30
[NativeHeaderAttribute] // RVA: 0xC8D30 Offset: 0xC8E31 VA: 0xC8D30
[UsedByNativeCodeAttribute] // RVA: 0xC8D30 Offset: 0xC8E31 VA: 0xC8D30
[NativeHeaderAttribute] // RVA: 0xC8D30 Offset: 0xC8E31 VA: 0xC8D30
public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 3356
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal T GetObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F1DE0 Offset: 0x2F1EE1 VA: 0x2F1DE0
	|-PlayableHandle.GetObject<AudioClipProperties>
	|-PlayableHandle.GetObject<object>
	*/

	[VisibleToOtherModulesAttribute] // RVA: 0xDA3D0 Offset: 0xDA4D1 VA: 0xDA3D0
	// RVA: -1 Offset: -1
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F2630 Offset: 0x2F2731 VA: 0x2F2630
	|-PlayableHandle.IsPlayableOfType<object>
	|
	|-RVA: 0x2F26D0 Offset: 0x2F27D1 VA: 0x2F26D0
	|-PlayableHandle.IsPlayableOfType<AnimationClipPlayable>
	|
	|-RVA: 0x2F2770 Offset: 0x2F2871 VA: 0x2F2770
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|
	|-RVA: 0x2F2810 Offset: 0x2F2911 VA: 0x2F2810
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|
	|-RVA: 0x2F28B0 Offset: 0x2F29B1 VA: 0x2F28B0
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0x2F2950 Offset: 0x2F2A51 VA: 0x2F2950
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|
	|-RVA: 0x2F29F0 Offset: 0x2F2AF1 VA: 0x2F29F0
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|
	|-RVA: 0x2F2A90 Offset: 0x2F2B91 VA: 0x2F2A90
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|
	|-RVA: 0x2F2B30 Offset: 0x2F2C31 VA: 0x2F2B30
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|
	|-RVA: 0x2F2BD0 Offset: 0x2F2CD1 VA: 0x2F2BD0
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	|
	|-RVA: 0x2F2C70 Offset: 0x2F2D71 VA: 0x2F2C70
	|-PlayableHandle.IsPlayableOfType<AudioClipPlayable>
	|
	|-RVA: 0x2F2D10 Offset: 0x2F2E11 VA: 0x2F2D10
	|-PlayableHandle.IsPlayableOfType<AudioMixerPlayable>
	*/

	// RVA: 0x2B6D380 Offset: 0x2B6D481 VA: 0x2B6D380
	public static PlayableHandle get_Null() { }

	// RVA: 0x37FB20 Offset: 0x37FC21 VA: 0x37FB20
	internal Playable GetInput(int inputPort) { }

	// RVA: 0x37FBE0 Offset: 0x37FCE1 VA: 0x37FBE0
	internal bool SetInputWeight(int inputIndex, float weight) { }

	// RVA: 0x37FCB0 Offset: 0x37FDB1 VA: 0x37FCB0
	internal float GetInputWeight(int inputIndex) { }

	// RVA: 0x37FD60 Offset: 0x37FE61 VA: 0x37FD60
	internal void Destroy() { }

	// RVA: 0x2B6D210 Offset: 0x2B6D311 VA: 0x2B6D210
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x2B6F1B0 Offset: 0x2B6F2B1 VA: 0x2B6F1B0
	public static bool op_Inequality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x37FD70 Offset: 0x37FE71 VA: 0x37FD70 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x37FD80 Offset: 0x37FE81 VA: 0x37FD80 Slot: 4
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x37FE10 Offset: 0x37FF11 VA: 0x37FE10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2B6F170 Offset: 0x2B6F271 VA: 0x2B6F170
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	// RVA: 0x37FE50 Offset: 0x37FF51 VA: 0x37FE50
	internal bool CheckInputBounds(int inputIndex) { }

	// RVA: 0x37FE70 Offset: 0x37FF71 VA: 0x37FE70
	internal bool CheckInputBounds(int inputIndex, bool acceptAny) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA3E0 Offset: 0xDA4E1 VA: 0xDA3E0
	// RVA: 0x37FE90 Offset: 0x37FF91 VA: 0x37FE90
	internal bool IsValid() { }

	[FreeFunctionAttribute] // RVA: 0xDA3F0 Offset: 0xDA4F1 VA: 0xDA3F0
	[VisibleToOtherModulesAttribute] // RVA: 0xDA3F0 Offset: 0xDA4F1 VA: 0xDA3F0
	// RVA: 0x37FF40 Offset: 0x380041 VA: 0x37FF40
	internal Type GetPlayableType() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA450 Offset: 0xDA551 VA: 0xDA450
	[FreeFunctionAttribute] // RVA: 0xDA450 Offset: 0xDA551 VA: 0xDA450
	// RVA: 0x37FFF0 Offset: 0x3800F1 VA: 0x37FFF0
	internal Type GetJobType() { }

	[FreeFunctionAttribute] // RVA: 0xDA4B0 Offset: 0xDA5B1 VA: 0xDA4B0
	[VisibleToOtherModulesAttribute] // RVA: 0xDA4B0 Offset: 0xDA5B1 VA: 0xDA4B0
	// RVA: 0x3800A0 Offset: 0x3801A1 VA: 0x3800A0
	internal void SetScriptInstance(object scriptInstance) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA510 Offset: 0xDA611 VA: 0xDA510
	[FreeFunctionAttribute] // RVA: 0xDA510 Offset: 0xDA611 VA: 0xDA510
	// RVA: 0x380150 Offset: 0x380251 VA: 0x380150
	internal PlayState GetPlayState() { }

	[FreeFunctionAttribute] // RVA: 0xDA570 Offset: 0xDA671 VA: 0xDA570
	[VisibleToOtherModulesAttribute] // RVA: 0xDA570 Offset: 0xDA671 VA: 0xDA570
	// RVA: 0x380200 Offset: 0x380301 VA: 0x380200
	internal void Play() { }

	[FreeFunctionAttribute] // RVA: 0xDA5D0 Offset: 0xDA6D1 VA: 0xDA5D0
	[VisibleToOtherModulesAttribute] // RVA: 0xDA5D0 Offset: 0xDA6D1 VA: 0xDA5D0
	// RVA: 0x3802B0 Offset: 0x3803B1 VA: 0x3802B0
	internal void Pause() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA630 Offset: 0xDA731 VA: 0xDA630
	[FreeFunctionAttribute] // RVA: 0xDA630 Offset: 0xDA731 VA: 0xDA630
	// RVA: 0x380360 Offset: 0x380461 VA: 0x380360
	internal double GetSpeed() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA690 Offset: 0xDA791 VA: 0xDA690
	[FreeFunctionAttribute] // RVA: 0xDA690 Offset: 0xDA791 VA: 0xDA690
	// RVA: 0x380410 Offset: 0x380511 VA: 0x380410
	internal void SetSpeed(double value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA6F0 Offset: 0xDA7F1 VA: 0xDA6F0
	[FreeFunctionAttribute] // RVA: 0xDA6F0 Offset: 0xDA7F1 VA: 0xDA6F0
	// RVA: 0x3804C0 Offset: 0x3805C1 VA: 0x3804C0
	internal double GetTime() { }

	[FreeFunctionAttribute] // RVA: 0xDA750 Offset: 0xDA851 VA: 0xDA750
	[VisibleToOtherModulesAttribute] // RVA: 0xDA750 Offset: 0xDA851 VA: 0xDA750
	// RVA: 0x380570 Offset: 0x380671 VA: 0x380570
	internal void SetTime(double value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA7B0 Offset: 0xDA8B1 VA: 0xDA7B0
	[FreeFunctionAttribute] // RVA: 0xDA7B0 Offset: 0xDA8B1 VA: 0xDA7B0
	// RVA: 0x380620 Offset: 0x380721 VA: 0x380620
	internal bool IsDone() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA810 Offset: 0xDA911 VA: 0xDA810
	[FreeFunctionAttribute] // RVA: 0xDA810 Offset: 0xDA911 VA: 0xDA810
	// RVA: 0x3806D0 Offset: 0x3807D1 VA: 0x3806D0
	internal void SetDone(bool value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA870 Offset: 0xDA971 VA: 0xDA870
	[FreeFunctionAttribute] // RVA: 0xDA870 Offset: 0xDA971 VA: 0xDA870
	// RVA: 0x380780 Offset: 0x380881 VA: 0x380780
	internal double GetDuration() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA8D0 Offset: 0xDA9D1 VA: 0xDA8D0
	[FreeFunctionAttribute] // RVA: 0xDA8D0 Offset: 0xDA9D1 VA: 0xDA8D0
	// RVA: 0x380830 Offset: 0x380931 VA: 0x380830
	internal void SetDuration(double value) { }

	[FreeFunctionAttribute] // RVA: 0xDA930 Offset: 0xDAA31 VA: 0xDA930
	[VisibleToOtherModulesAttribute] // RVA: 0xDA930 Offset: 0xDAA31 VA: 0xDA930
	// RVA: 0x3808E0 Offset: 0x3809E1 VA: 0x3808E0
	internal void SetPropagateSetTime(bool value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA990 Offset: 0xDAA91 VA: 0xDA990
	[FreeFunctionAttribute] // RVA: 0xDA990 Offset: 0xDAA91 VA: 0xDA990
	// RVA: 0x380990 Offset: 0x380A91 VA: 0x380990
	internal PlayableGraph GetGraph() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA9F0 Offset: 0xDAAF1 VA: 0xDA9F0
	[FreeFunctionAttribute] // RVA: 0xDA9F0 Offset: 0xDAAF1 VA: 0xDA9F0
	// RVA: 0x380A40 Offset: 0x380B41 VA: 0x380A40
	internal int GetInputCount() { }

	[FreeFunctionAttribute] // RVA: 0xDAA50 Offset: 0xDAB51 VA: 0xDAA50
	[VisibleToOtherModulesAttribute] // RVA: 0xDAA50 Offset: 0xDAB51 VA: 0xDAA50
	// RVA: 0x380AF0 Offset: 0x380BF1 VA: 0x380AF0
	internal void SetInputCount(int value) { }

	[FreeFunctionAttribute] // RVA: 0xDAAB0 Offset: 0xDABB1 VA: 0xDAAB0
	[VisibleToOtherModulesAttribute] // RVA: 0xDAAB0 Offset: 0xDABB1 VA: 0xDAAB0
	// RVA: 0x380BA0 Offset: 0x380CA1 VA: 0x380BA0
	internal void SetInputWeight(PlayableHandle input, float weight) { }

	[FreeFunctionAttribute] // RVA: 0xDAB10 Offset: 0xDAC11 VA: 0xDAB10
	[VisibleToOtherModulesAttribute] // RVA: 0xDAB10 Offset: 0xDAC11 VA: 0xDAB10
	// RVA: 0x380C60 Offset: 0x380D61 VA: 0x380C60
	internal double GetPreviousTime() { }

	[FreeFunctionAttribute] // RVA: 0xDAB70 Offset: 0xDAC71 VA: 0xDAB70
	[VisibleToOtherModulesAttribute] // RVA: 0xDAB70 Offset: 0xDAC71 VA: 0xDAB70
	// RVA: 0x380D10 Offset: 0x380E11 VA: 0x380D10
	internal void SetTraversalMode(PlayableTraversalMode mode) { }

	[FreeFunctionAttribute] // RVA: 0xDABD0 Offset: 0xDACD1 VA: 0xDABD0
	[VisibleToOtherModulesAttribute] // RVA: 0xDABD0 Offset: 0xDACD1 VA: 0xDABD0
	// RVA: 0x380DC0 Offset: 0x380EC1 VA: 0x380DC0
	internal IntPtr GetJobData() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAC30 Offset: 0xDAD31 VA: 0xDAC30
	[FreeFunctionAttribute] // RVA: 0xDAC30 Offset: 0xDAD31 VA: 0xDAC30
	// RVA: 0x380E70 Offset: 0x380F71 VA: 0x380E70
	internal DirectorWrapMode GetTimeWrapMode() { }

	[FreeFunctionAttribute] // RVA: 0xDAC90 Offset: 0xDAD91 VA: 0xDAC90
	[VisibleToOtherModulesAttribute] // RVA: 0xDAC90 Offset: 0xDAD91 VA: 0xDAC90
	// RVA: 0x380F20 Offset: 0x381021 VA: 0x380F20
	internal void SetTimeWrapMode(DirectorWrapMode mode) { }

	[FreeFunctionAttribute] // RVA: 0xDACF0 Offset: 0xDADF1 VA: 0xDACF0
	// RVA: 0x380FD0 Offset: 0x3810D1 VA: 0x380FD0
	private object GetScriptInstance() { }

	[FreeFunctionAttribute] // RVA: 0xDAD40 Offset: 0xDAE41 VA: 0xDAD40
	// RVA: 0x381080 Offset: 0x381181 VA: 0x381080
	private PlayableHandle GetInputHandle(int index) { }

	[FreeFunctionAttribute] // RVA: 0xDAD90 Offset: 0xDAE91 VA: 0xDAD90
	// RVA: 0x381140 Offset: 0x381241 VA: 0x381140
	private void SetInputWeightFromIndex(int index, float weight) { }

	[FreeFunctionAttribute] // RVA: 0xDADE0 Offset: 0xDAEE1 VA: 0xDADE0
	// RVA: 0x381200 Offset: 0x381301 VA: 0x381200
	private float GetInputWeightFromIndex(int index) { }

	// RVA: 0x2B70F80 Offset: 0x2B71081 VA: 0x2B70F80
	private static void .cctor() { }

	// RVA: 0x2B6F7D0 Offset: 0x2B6F8D1 VA: 0x2B6F7D0
	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B6F820 Offset: 0x2B6F921 VA: 0x2B6F820
	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B6F910 Offset: 0x2B6FA11 VA: 0x2B6F910
	private static Type GetJobType_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B6FA10 Offset: 0x2B6FB11 VA: 0x2B6FA10
	private static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, object scriptInstance) { }

	// RVA: 0x2B6FB00 Offset: 0x2B6FC01 VA: 0x2B6FB00
	private static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B6FBF0 Offset: 0x2B6FCF1 VA: 0x2B6FBF0
	private static void Play_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B6FCE0 Offset: 0x2B6FDE1 VA: 0x2B6FCE0
	private static void Pause_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B6FDD0 Offset: 0x2B6FED1 VA: 0x2B6FDD0
	private static double GetSpeed_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B6FED0 Offset: 0x2B6FFD1 VA: 0x2B6FED0
	private static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value) { }

	// RVA: 0x2B6FFC0 Offset: 0x2B700C1 VA: 0x2B6FFC0
	private static double GetTime_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B700C0 Offset: 0x2B701C1 VA: 0x2B700C0
	private static void SetTime_Injected(ref PlayableHandle _unity_self, double value) { }

	// RVA: 0x2B701B0 Offset: 0x2B702B1 VA: 0x2B701B0
	private static bool IsDone_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B702B0 Offset: 0x2B703B1 VA: 0x2B702B0
	private static void SetDone_Injected(ref PlayableHandle _unity_self, bool value) { }

	// RVA: 0x2B703A0 Offset: 0x2B704A1 VA: 0x2B703A0
	private static double GetDuration_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B704A0 Offset: 0x2B705A1 VA: 0x2B704A0
	private static void SetDuration_Injected(ref PlayableHandle _unity_self, double value) { }

	// RVA: 0x2B705A0 Offset: 0x2B706A1 VA: 0x2B705A0
	private static void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value) { }

	// RVA: 0x2B705F0 Offset: 0x2B706F1 VA: 0x2B705F0
	private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret) { }

	// RVA: 0x2B70640 Offset: 0x2B70741 VA: 0x2B70640
	private static int GetInputCount_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B70740 Offset: 0x2B70841 VA: 0x2B70740
	private static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value) { }

	// RVA: 0x2B70850 Offset: 0x2B70951 VA: 0x2B70850
	private static void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight) { }

	// RVA: 0x2B70950 Offset: 0x2B70A51 VA: 0x2B70950
	private static double GetPreviousTime_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B70A50 Offset: 0x2B70B51 VA: 0x2B70A50
	private static void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode) { }

	// RVA: 0x2B70B40 Offset: 0x2B70C41 VA: 0x2B70B40
	private static IntPtr GetJobData_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B70C30 Offset: 0x2B70D31 VA: 0x2B70C30
	private static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B70D30 Offset: 0x2B70E31 VA: 0x2B70D30
	private static void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode) { }

	// RVA: 0x2B70E20 Offset: 0x2B70F21 VA: 0x2B70E20
	private static object GetScriptInstance_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x2B70E70 Offset: 0x2B70F71 VA: 0x2B70E70
	private static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret) { }

	// RVA: 0x2B70ED0 Offset: 0x2B70FD1 VA: 0x2B70ED0
	private static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight) { }

	// RVA: 0x2B70F30 Offset: 0x2B71031 VA: 0x2B70F30
	private static float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index) { }
}


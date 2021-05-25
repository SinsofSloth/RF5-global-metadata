internal struct ProcessAnimationJobStruct<T> // TypeDefIndex: 3519
{
	// Fields
	private static IntPtr jobReflectionData; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static IntPtr GetJobReflectionData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C16E0 Offset: 0x28C17E1 VA: 0x28C16E0
	|-ProcessAnimationJobStruct<AimIKJob>.GetJobReflectionData
	|
	|-RVA: 0x28C1A80 Offset: 0x28C1B81 VA: 0x28C1A80
	|-ProcessAnimationJobStruct<CCDIKJob>.GetJobReflectionData
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T data, IntPtr animationStreamPtr, IntPtr methodIndex, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C1930 Offset: 0x28C1A31 VA: 0x28C1930
	|-ProcessAnimationJobStruct<AimIKJob>.Execute
	|
	|-RVA: 0x28C1CD0 Offset: 0x28C1DD1 VA: 0x28C1CD0
	|-ProcessAnimationJobStruct<CCDIKJob>.Execute
	*/
}


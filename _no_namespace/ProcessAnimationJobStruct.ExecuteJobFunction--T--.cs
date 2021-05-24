public sealed class ProcessAnimationJobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3520
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C0E60 Offset: 0x28C0F61 VA: 0x28C0E60
	|-ProcessAnimationJobStruct.ExecuteJobFunction<AimIKJob>..ctor
	|
	|-RVA: 0x28C12A0 Offset: 0x28C13A1 VA: 0x28C12A0
	|-ProcessAnimationJobStruct.ExecuteJobFunction<CCDIKJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref T data, IntPtr animationStreamPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C0E80 Offset: 0x28C0F81 VA: 0x28C0E80
	|-ProcessAnimationJobStruct.ExecuteJobFunction<AimIKJob>.Invoke
	|
	|-RVA: 0x28C12C0 Offset: 0x28C13C1 VA: 0x28C12C0
	|-ProcessAnimationJobStruct.ExecuteJobFunction<CCDIKJob>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr animationStreamPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C1170 Offset: 0x28C1271 VA: 0x28C1170
	|-ProcessAnimationJobStruct.ExecuteJobFunction<AimIKJob>.BeginInvoke
	|
	|-RVA: 0x28C15B0 Offset: 0x28C16B1 VA: 0x28C15B0
	|-ProcessAnimationJobStruct.ExecuteJobFunction<CCDIKJob>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C1270 Offset: 0x28C1371 VA: 0x28C1270
	|-ProcessAnimationJobStruct.ExecuteJobFunction<AimIKJob>.EndInvoke
	|
	|-RVA: 0x28C16B0 Offset: 0x28C17B1 VA: 0x28C16B0
	|-ProcessAnimationJobStruct.ExecuteJobFunction<CCDIKJob>.EndInvoke
	*/
}


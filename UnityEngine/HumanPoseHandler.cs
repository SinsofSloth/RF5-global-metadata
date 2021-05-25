[NativeHeaderAttribute] // RVA: 0xE8FE0 Offset: 0xE90E1 VA: 0xE8FE0
[NativeHeaderAttribute] // RVA: 0xE8FE0 Offset: 0xE90E1 VA: 0xE8FE0
public class HumanPoseHandler : IDisposable // TypeDefIndex: 3500
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[FreeFunctionAttribute] // RVA: 0xEC530 Offset: 0xEC631 VA: 0xEC530
	// RVA: 0x1B00580 Offset: 0x1B00681 VA: 0x1B00580
	private static IntPtr Internal_Create(Avatar avatar, Transform root) { }

	[FreeFunctionAttribute] // RVA: 0xEC570 Offset: 0xEC671 VA: 0xEC570
	// RVA: 0x1B005D0 Offset: 0x1B006D1 VA: 0x1B005D0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x1B00620 Offset: 0x1B00721 VA: 0x1B00620
	private void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, [Out] float[] muscles) { }

	// RVA: 0x1B00690 Offset: 0x1B00791 VA: 0x1B00690 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B00750 Offset: 0x1B00851 VA: 0x1B00750
	public void .ctor(Avatar avatar, Transform root) { }

	// RVA: 0x1B00940 Offset: 0x1B00A41 VA: 0x1B00940
	public void GetHumanPose(ref HumanPose humanPose) { }
}


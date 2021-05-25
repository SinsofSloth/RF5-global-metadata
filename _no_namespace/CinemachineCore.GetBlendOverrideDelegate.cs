public sealed class CinemachineCore.GetBlendOverrideDelegate : MulticastDelegate // TypeDefIndex: 4827
{
	// Methods

	// RVA: 0x1720390 Offset: 0x1720491 VA: 0x1720390
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17203B0 Offset: 0x17204B1 VA: 0x17203B0 Slot: 13
	public virtual CinemachineBlendDefinition Invoke(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner) { }

	// RVA: 0x1720860 Offset: 0x1720961 VA: 0x1720860 Slot: 14
	public virtual IAsyncResult BeginInvoke(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner, AsyncCallback callback, object object) { }

	// RVA: 0x1720910 Offset: 0x1720A11 VA: 0x1720910 Slot: 15
	public virtual CinemachineBlendDefinition EndInvoke(IAsyncResult result) { }
}


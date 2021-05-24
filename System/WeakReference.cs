[ComVisibleAttribute] // RVA: 0xAD080 Offset: 0xAD181 VA: 0xAD080
[Serializable]
public class WeakReference : ISerializable // TypeDefIndex: 432
{
	// Fields
	private bool isLongReference; // 0x10
	private GCHandle gcHandle; // 0x14

	// Properties
	public virtual object Target { get; set; }
	public virtual bool TrackResurrection { get; }

	// Methods

	// RVA: 0x1AE8620 Offset: 0x1AE8721 VA: 0x1AE8620
	private void AllocateHandle(object target) { }

	// RVA: 0x1AE8660 Offset: 0x1AE8761 VA: 0x1AE8660
	protected void .ctor() { }

	// RVA: 0x1AE8670 Offset: 0x1AE8771 VA: 0x1AE8670
	public void .ctor(object target) { }

	// RVA: 0x1AE86B0 Offset: 0x1AE87B1 VA: 0x1AE86B0
	public void .ctor(object target, bool trackResurrection) { }

	// RVA: 0x1AE8700 Offset: 0x1AE8801 VA: 0x1AE8700
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AE8890 Offset: 0x1AE8991 VA: 0x1AE8890 Slot: 5
	public virtual object get_Target() { }

	// RVA: 0x1AE88E0 Offset: 0x1AE89E1 VA: 0x1AE88E0 Slot: 6
	public virtual void set_Target(object value) { }

	// RVA: 0x1AE88F0 Offset: 0x1AE89F1 VA: 0x1AE88F0 Slot: 7
	public virtual bool get_TrackResurrection() { }

	// RVA: 0x1AE8900 Offset: 0x1AE8A01 VA: 0x1AE8900 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AE8970 Offset: 0x1AE8A71 VA: 0x1AE8970 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
}


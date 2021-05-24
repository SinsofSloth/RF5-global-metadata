[ComVisibleAttribute] // RVA: 0xB0050 Offset: 0xB0151 VA: 0xB0050
public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 942
{
	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x194E720 Offset: 0x194E821 VA: 0x194E720
	protected void .ctor() { }

	// RVA: 0x194E690 Offset: 0x194E791 VA: 0x194E690 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x194F350 Offset: 0x194F451 VA: 0x194F350 Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x194F3D0 Offset: 0x194F4D1 VA: 0x194F3D0 Slot: 20
	public virtual void set_Key(byte[] value) { }
}


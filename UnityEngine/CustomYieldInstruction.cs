public abstract class CustomYieldInstruction : IEnumerator // TypeDefIndex: 3010
{
	// Properties
	public abstract bool keepWaiting { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_keepWaiting() { }

	// RVA: 0x2B04DB0 Offset: 0x2B04EB1 VA: 0x2B04DB0 Slot: 5
	public object get_Current() { }

	// RVA: 0x2B04DC0 Offset: 0x2B04EC1 VA: 0x2B04DC0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2B04DD0 Offset: 0x2B04ED1 VA: 0x2B04DD0 Slot: 6
	public void Reset() { }

	// RVA: 0x2B04DE0 Offset: 0x2B04EE1 VA: 0x2B04DE0
	protected void .ctor() { }
}


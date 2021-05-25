[ComVisibleAttribute] // RVA: 0xAC610 Offset: 0xAC711 VA: 0xAC610
[Serializable]
public class Random // TypeDefIndex: 297
{
	// Fields
	private int inext; // 0x10
	private int inextp; // 0x14
	private int[] SeedArray; // 0x18

	// Methods

	// RVA: 0x1957C10 Offset: 0x1957D11 VA: 0x1957C10
	public void .ctor() { }

	// RVA: 0x1957C40 Offset: 0x1957D41 VA: 0x1957C40
	public void .ctor(int Seed) { }

	// RVA: 0x19580B0 Offset: 0x19581B1 VA: 0x19580B0 Slot: 4
	protected virtual double Sample() { }

	// RVA: 0x19580E0 Offset: 0x19581E1 VA: 0x19580E0
	private int InternalSample() { }

	// RVA: 0x1958180 Offset: 0x1958281 VA: 0x1958180
	private double GetSampleForLargeRange() { }

	// RVA: 0x19581D0 Offset: 0x19582D1 VA: 0x19581D0 Slot: 5
	public virtual int Next(int minValue, int maxValue) { }

	// RVA: 0x1958370 Offset: 0x1958471 VA: 0x1958370 Slot: 6
	public virtual int Next(int maxValue) { }

	// RVA: 0x1958470 Offset: 0x1958571 VA: 0x1958470 Slot: 7
	public virtual double NextDouble() { }
}


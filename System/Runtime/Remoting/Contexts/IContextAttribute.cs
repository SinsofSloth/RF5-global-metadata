[ComVisibleAttribute] // RVA: 0xB0D00 Offset: 0xB0E01 VA: 0xB0D00
public interface IContextAttribute // TypeDefIndex: 1151
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }
}


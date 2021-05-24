[ComVisibleAttribute] // RVA: 0xADA50 Offset: 0xADB51 VA: 0xADA50
public interface ICustomAttributeProvider // TypeDefIndex: 538
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsDefined(Type attributeType, bool inherit) { }
}

